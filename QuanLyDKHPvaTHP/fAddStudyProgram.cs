using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;
using QuanLyDKHPvaTHP.DAO;

namespace QuanLyDKHPvaTHP
{
    public partial class fAddStudyProgram : Form
    {
        private DataTable data = new DataTable();
        public EventHandler ExitFormAddStudyProgramRequested;

        public fAddStudyProgram()
        {
            InitializeComponent();
            LoadFaculties();
            LoadMajor();
            DefaultLoadSubjectList();
        }

        void DefaultLoadSubjectList()
        {
            string query = "SELECT HocKy AS [Học kỳ], CTH.MaMH AS [Mã môn], TenMH AS [Tên môn], LM.TenLoaiMon AS [Loại môn], SoTC AS [Số tín chỉ] " +
                "FROM dbo.NGANHHOC AS NH JOIN CT_NGANH AS CTH ON NH.MaNH = CTH.MaNH JOIN dbo.MONHOC AS MH ON CTH.MaMH = MH.MaMH JOIN dbo.LOAIMON AS LM ON MH.MaLoaiMon = LM.MaLoaiMon " +
                "WHERE NH.TenNH = N'" + comboMajor.Text + "' " +
                "ORDER BY HocKy ";
            LoadSubjectList(query);
        }

        void LoadSubjectList(string query)
        {
            data = DataProvider.Instance.ExecuteQuery(query);
            dtgvAddStudyProgram.DataSource = data;
            // Tạo một đối tượng Padding mới với các giá trị padding mong muốn
            Padding cellPadding = new Padding(5, 5, 5, 5); // Lề trên, lề phải, lề dưới, lề trái

            // Lặp qua từng cột trong DataGridView và đặt Padding cho mỗi cell style của cột
            foreach (DataGridViewColumn column in dtgvAddStudyProgram.Columns)
            {
                column.DefaultCellStyle.Padding = cellPadding;
            }
            CalculateCredit();
            CalculateSubject();
        }

        void LoadFaculties()
        {
            string query = "SELECT KH.MaKhoa, TenKhoa " +
                "FROM dbo.NGANHHOC AS NH JOIN dbo.KHOA AS KH ON NH.MaKhoa = KH.MaKhoa " +
                "WHERE NOT EXISTS (SELECT * FROM dbo.CT_NGANH AS CTH WHERE CTH.MaNH = NH.MaNH)";
            comboFaculties.DataSource = DataProvider.Instance.ExecuteQuery(query);
            comboFaculties.DisplayMember = "TenKhoa";
            comboFaculties.ValueMember = "MaKhoa";
            //MessageBox.Show(comboFaculties.SelectedValue.ToString());
        }

        void LoadMajor()
        {
            string query = "SELECT MaNH, TenNH " +
                "FROM dbo.NGANHHOC AS NH JOIN dbo.KHOA AS KH ON NH.MaKhoa = KH.MaKhoa " +
                "WHERE NH.MaKhoa = '" + comboFaculties.SelectedValue + "' " +
                "AND NOT EXISTS (SELECT * FROM dbo.CT_NGANH AS CTH WHERE CTH.MaNH = NH.MaNH)";
            comboMajor.DataSource = DataProvider.Instance.ExecuteQuery(query);
            comboMajor.DisplayMember = "TenNH";
            comboMajor.ValueMember = "MaNH";
        }

        private void CalculateCredit()
        {
            int LT = 0;
            int TH = 0;
            foreach (DataGridViewRow row in dtgvAddStudyProgram.Rows)
            {
                if (row.Cells["lCreditHeader"].Value != null)
                {
                    if (row.Cells["lSubjectTypeHeader"].Value.ToString() == "Lý thuyết")
                    {
                        LT += Convert.ToInt32(row.Cells["lCreditHeader"].Value);
                    }
                    else
                    {
                        TH += Convert.ToInt32(row.Cells["lCreditHeader"].Value);
                    }
                }
            }
            lCreditAmountTheory.Text = LT.ToString();
            lCreditAmountPractice.Text = TH.ToString();
        }

        private void CalculateSubject()
        {
            int count = 0;
            foreach (DataGridViewRow row in dtgvAddStudyProgram.Rows)
            {
                if (row.Cells["lSubjectTypeHeader"].Value != null && row.Cells["lSubjectTypeHeader"].Value.ToString() == "Lý thuyết")
                {
                    count++;
                }
            }
            lSubAmount.Text = count.ToString();
        }

        private void fAddStudyProgram_Shown(object sender, EventArgs e)
        {
            DefaultLoadSubjectList();
        }

        public bool CheckIfExists(string valueToCheck)
        {
            foreach (DataGridViewRow row in dtgvAddStudyProgram.Rows)
            {
                if (row.Cells["lSubjectIDHeader"].Value != null && row.Cells["lSubjectIDHeader"].Value.ToString() == valueToCheck)
                {
                    return true;
                }
            }
            return false;
        }

        private void AddRowToDGV(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                data.Rows.Add(row.ItemArray);
            }
        }

        void LoadData()
        {
            dtgvAddStudyProgram.DataSource = data;
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            fAddSubjectOfAddStudyProgram fAddSub = new fAddSubjectOfAddStudyProgram(this);
            fAddSub.ShowDialog();
            if (fAddSub.check)
            {
                AddRowToDGV(fAddSub.SubjectTable);
            }
            LoadData();
        }

        private string GenerateNewStudyProgramID(string MaxMaCT_Nganh)
        {
            if (string.IsNullOrEmpty(MaxMaCT_Nganh))
            {
                return "CT000001";
            }

            int currentNumber = int.Parse(MaxMaCT_Nganh.Substring(2));
            int newNumber = currentNumber + 1;
            return $"CT{newNumber:D6}";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {


            string getMaxMaCTNganhQuery = "SELECT MAX(MaCT_Nganh) FROM dbo.CT_NGANH";
            object result = DataProvider.Instance.ExecuteScalar(getMaxMaCTNganhQuery);
            string newMaCTNganh = GenerateNewStudyProgramID(result?.ToString());

            string query = "INSERT INTO CT_NGANH(MaCT_Nganh, MaNH, MaMH, HocKy) VALUES ";

            foreach (DataRow row in data.Rows)
            {
                query += "('" + newMaCTNganh + "', '" + comboMajor.SelectedValue + "', '" + row["Mã môn"] + "', " + row["Học kỳ"] + ")";
                if (data.Rows.IndexOf(row) == data.Rows.Count - 1)
                {
                    query += ";";
                }
                else
                {
                    query += ", ";
                }
                newMaCTNganh = GenerateNewStudyProgramID(newMaCTNganh);
            }
            if (query != "INSERT INTO CT_NGANH(MaCT_Nganh, MaNH, MaMH, HocKy) VALUES ")
            {
                try
                {
                    int rowAffect = DataProvider.Instance.ExecuteNonQuery(query);
                    if (rowAffect > 0)
                    {
                        MessageBox.Show("Lưu dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Lưu dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            ExitFormAddStudyProgramRequested?.Invoke(this, EventArgs.Empty);
        }

        private void comboFaculties_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMajor();
            DefaultLoadSubjectList();
        }

        public void reloadStuPro()
        {
            DefaultLoadSubjectList();
        }

        private void dtgvAddStudyProgram_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            DataGridViewColumn column = new DataGridViewColumn();
            column = dtgvAddStudyProgram.Columns[e.ColumnIndex];

            switch (Convert.ToString(column.Name))
            {
                case "View":
                    if (dtgvAddStudyProgram.SelectedCells.Count > 0)
                    {
                        int selectedRowIndex = dtgvAddStudyProgram.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dtgvAddStudyProgram.Rows[selectedRowIndex];
                        string SubjectIDValue = Convert.ToString(selectedRow.Cells["lSubjectIDHeader"].Value);

                        fViewSubjectOfStudyProgram fViewSub = new fViewSubjectOfStudyProgram(SubjectIDValue);
                        fViewSub.Show();
                    }
                    break;
                case "Delete":
                    string query = "SELECT MaMH " +
                        "FROM dbo.MONHOC as mh JOIN dbo.LOAIMON as lm ON mh.MaLoaiMon = lm.MaLoaiMon " +
                        "WHERE mh.TenMH = N'" + data.Rows[e.RowIndex]["Tên môn"] + "' AND mh.MaMH != '" + data.Rows[e.RowIndex]["Mã môn"] + "'";
                    object mamon = DataProvider.Instance.ExecuteScalar(query);
                    int rowindex = -1;
                    if (mamon is not null)
                    {
                        foreach (DataRow dr in data.Rows)
                        {
                            rowindex++;
                            if (dr["Mã môn"].ToString() == mamon.ToString())
                            {
                                break;
                            }
                        }
                        data.Rows.RemoveAt(rowindex);
                    }
                    if (rowindex > -1 && rowindex < e.RowIndex)
                    {
                        data.Rows.RemoveAt(e.RowIndex - 1);
                    }
                    else data.Rows.RemoveAt(e.RowIndex);
                    LoadData();
                    break;
                default:
                    break;
            }
        }

        private void dtgvAddStudyProgram_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateCredit();
            CalculateSubject();
        }

        private void dtgvAddStudyProgram_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculateCredit();
            CalculateSubject();
        }
    }
}