using QuanLyDKHPvaTHP.DAO;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDKHPvaTHP
{
    public partial class fViewRegister : Form
    {
        public string MaPhieuDK;
        public event EventHandler ExitFormViewRegisterRequested;
        private string studentID;
        private float tilegiam;
        private int gialt, giath;
        public fViewRegister(string maPhieuDK)
        {
            InitializeComponent();
            MaPhieuDK = maPhieuDK;
            LoadRegisterInfo();
            DefaultLoadSubjectList();
            CalculateCredit();
            CalculateSubject();
            CalculateMoney();
        }
        void GetTiLeGiam()
        {
            string query = "SELECT TiLeGiam FROM dbo.SINHVIEN SV JOIN dbo.DTUUTIEN AS DT ON SV.MaDT = DT.MaDT " +
                "WHERE MSSV = '" + studentID + "' ";
            object tlg = DataProvider.Instance.ExecuteScalar(query);
            tilegiam = Convert.ToSingle(tlg);
        }

        void GetMoneyPerCredit()
        {
            string query = "SELECT SoTienMotTC " +
                "FROM dbo.LOAIMON " +
                "WHERE MaLoaiMon = 'LM1'";
            object giaLT = DataProvider.Instance.ExecuteScalar(query);
            gialt = Convert.ToInt32(giaLT);

            query = "SELECT SoTienMotTC " +
                "FROM dbo.LOAIMON " +
                "WHERE MaLoaiMon = 'LM2'";
            object giaTH = DataProvider.Instance.ExecuteScalar(query);
            giath = Convert.ToInt32(giaTH);
        }

        private void CalculateCredit()
        {
            int total = 0;
            foreach (DataGridViewRow row in dtgvViewStudyProgram.Rows)
            {
                if (row.Cells["SoTC"].Value != null)
                {
                    total += Convert.ToInt32(row.Cells["SoTC"].Value);
                }
            }
            lbCreditAmount.Text = total.ToString();
        }

        private void CalculateSubject()
        {
            int count = 0;
            foreach (DataGridViewRow row in dtgvViewStudyProgram.Rows)
            {
                if (row.Cells["TenLoaiMon"].Value != null && row.Cells["TenLoaiMon"].Value.ToString() == "Lý thuyết")
                {
                    count++;
                }
            }
            lbSubAmount.Text = count.ToString();
        }

        private void CalculateMoney()
        {
            GetTiLeGiam();
            GetMoneyPerCredit();
            int LT = 0;
            int TH = 0;
            foreach (DataGridViewRow row in dtgvViewStudyProgram.Rows)
            {
                if (row.Cells["SoTC"].Value != null)
                {
                    if (row.Cells["TenLoaiMon"].Value.ToString() == "Lý thuyết")
                    {
                        LT += Convert.ToInt32(row.Cells["SoTC"].Value);
                    }
                    else
                    {
                        TH += Convert.ToInt32(row.Cells["SoTC"].Value);
                    }
                }
            }
            lbMoneySum.Text = ((1 - tilegiam) * (LT * gialt + TH * giath)).ToString();
        }

        void DefaultLoadSubjectList()
        {
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MH.MaMH) AS STT, MH.MaMH, " +
                "MH.TenMH, LM.TenLoaiMon, MH.SoTC " +
                "FROM dbo.PHIEUDKHP AS DKHP " +
                "JOIN dbo.CT_DKHP AS CTPDK ON DKHP.MaPhieuDKHP = CTPDK.MaPhieuDKHP " +
                "JOIN dbo.DSMHMO AS MHMO ON CTPDK.MaMo = MHMO.MaMo " +
                "JOIN dbo.CT_NGANH AS CTH ON MHMO.MaCT_Nganh = CTH.MaCT_Nganh " +

                "JOIN dbo.MONHOC AS MH ON CTH.MaMH = MH.MaMH " +
                "JOIN dbo.LOAIMON AS LM ON MH.MaLoaiMon = LM.MaLoaiMon " +
                "WHERE DKHP.MaPhieuDKHP = '" + MaPhieuDK + "'";
            LoadSubjectList(query);
        }

        void LoadSubjectList(string query)
        {
            dtgvViewStudyProgram.DataSource = DataProvider.Instance.ExecuteQuery(query);
            // Tạo một đối tượng Padding mới với các giá trị padding mong muốn
            Padding cellPadding = new Padding(5, 5, 5, 5); // Lề trên, lề phải, lề dưới, lề trái

            // Lặp qua từng cột trong DataGridView và đặt Padding cho mỗi cell style của cột
            foreach (DataGridViewColumn column in dtgvViewStudyProgram.Columns)
            {
                column.DefaultCellStyle.Padding = cellPadding;
            }
        }
        void LoadRegisterInfo()
        {
            string query = "SELECT DKHP.MSSV, HKNH.NamHoc, HKNH.HocKy, FORMAT(DKHP.NgayLap, 'dd/MM/yyyy') AS NgayLap " +
                "FROM dbo.PHIEUDKHP AS DKHP JOIN dbo.HOCKY_NAMHOC AS HKNH ON DKHP.MaHKNH = HKNH.MaHKNH " +
                "WHERE DKHP.MaPhieuDKHP = '" + MaPhieuDK + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            lbRegisterID.Text = MaPhieuDK;
            lbStudentID.Text = (string)data.Rows[0]["MSSV"];
            studentID = lbStudentID.Text;
            lbSchoolYear.Text = data.Rows[0]["NamHoc"].ToString();
            lbSemester.Text = data.Rows[0]["HocKy"].ToString();
            lbDateCreate.Text = data.Rows[0]["NgayLap"].ToString();
        }

        private void fViewRegister_Shown(object sender, EventArgs e)
        {
            DefaultLoadSubjectList();
        }

        private void dtgvViewStudyProgram_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            DataGridViewColumn column = new DataGridViewColumn();
            column = dtgvViewStudyProgram.Columns[e.ColumnIndex];

            if (Convert.ToString(column.Name) == "View")
            {
                if (dtgvViewStudyProgram.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dtgvViewStudyProgram.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dtgvViewStudyProgram.Rows[selectedRowIndex];
                    string SubjectIDValue = Convert.ToString(selectedRow.Cells["MaMH"].Value);

                    fViewSubjectOfRegister fViewSub = new fViewSubjectOfRegister(SubjectIDValue);
                    fViewSub.Show();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitFormViewRegisterRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}