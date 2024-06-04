using QuanLyDKHPvaTHP.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static QuanLyDKHPvaTHP.fAddSubjectOfUpdateStudyProgram;
using static QuanLyDKHPvaTHP.fUpdateStudyProgram;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyDKHPvaTHP
{
    public partial class fAddSubjectOfAddStudyProgram : Form
    {
        public DataTable SubjectTable = new DataTable();

        private fAddStudyProgram fASP;
        public bool check = true;
        private bool add = true;

        public fAddSubjectOfAddStudyProgram(fAddStudyProgram check)
        {
            InitializeComponent();
            SubjectTable.Columns.Add("Học kỳ", typeof(int));
            SubjectTable.Columns.Add("Mã môn", typeof(string));
            SubjectTable.Columns.Add("Tên môn", typeof(string));
            SubjectTable.Columns.Add("Loại môn", typeof(string));
            SubjectTable.Columns.Add("Số tín chỉ", typeof(int));
            fASP = check;
            LoadSubjectID();
            comboBoxMaMHCTH.SelectedIndex = 1;
        }

        void LoadSubjectID()
        {
            string query = "SELECT MaMH " +
                "FROM dbo.MONHOC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                if (fASP.CheckIfExists(row["MaMH"].ToString()))
                {
                    row.Delete();
                }
            }
            comboBoxMaMHCTH.DataSource = data;
            comboBoxMaMHCTH.DisplayMember = "MaMH";
            comboBoxMaMHCTH.ValueMember = "MaMH";
        }

        public void AddSubject(object sender, EventArgs e)
        {
            SubjectTable.Rows.Add(comboHocKyCTH.Text, comboBoxMaMHCTH.SelectedValue, lTenMonCTH.Text, lLoaiMonCTH.Text, int.Parse(lSoTCCTH.Text));
            string query = "SELECT MaMH, TenMH, SoTiet, SoTC, TenLoaiMon " +
                "FROM dbo.MONHOC as mh JOIN dbo.LOAIMON as lm ON mh.MaLoaiMon = lm.MaLoaiMon " +
                "WHERE mh.TenMH = N'" + lTenMonCTH.Text + "' AND mh.MaMH != '" + comboBoxMaMHCTH.SelectedValue + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                SubjectTable.Rows.Add(comboHocKyCTH.Text, data.Rows[0]["MaMH"], data.Rows[0]["TenMH"], data.Rows[0]["TenLoaiMon"], int.Parse(data.Rows[0]["SoTC"].ToString()));
            }
        }

        private void btn_AddSub_Click(object sender, EventArgs e)
        {
            string SubjectIDValue = comboBoxMaMHCTH.Text;

            bool exists = fASP.CheckIfExists(SubjectIDValue);

            if (exists)
            {
                MessageBox.Show("Môn học đã tồn tại trong chương trình học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                check = false;
            }
            else
            {
                MessageBox.Show("Thêm môn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add = false;
                AddSubject(sender, e);
                this.Hide();
            }
        }

        public class Semester
        {
            public int Display { get; set; }
            public int Value { get; set; }
        }

        List<Semester> semesters = new List<Semester>()
        {
            new Semester { Display = 1, Value = 1 },
            new Semester { Display = 2, Value = 2 },
            new Semester { Display = 3, Value = 3 },
            new Semester { Display = 4, Value = 4 },
            new Semester { Display = 5, Value = 5 },
            new Semester { Display = 6, Value = 6 },
            new Semester { Display = 7, Value = 7 },
            new Semester { Display = 8, Value = 8 },
        };

        private void fAddSubjectOfStudyProgram_Load(object sender, EventArgs e)
        {
            comboHocKyCTH.ValueMember = "Value";

            comboHocKyCTH.DisplayMember = "Display";

            foreach (Semester semester in semesters)
            {
                comboHocKyCTH.Items.Add(semester);
            }

            comboHocKyCTH.SelectedIndex = 0;
        }

        private void fAddSubjectOfAddStudyProgram_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (add)
            {
                if (check == true)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            MessageBox.Show("Thêm môn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AddSubject(sender, e);
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
        }

        private void comboBoxMaMHCTH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT MaMH, TenMH, SoTiet, SoTC, TenLoaiMon " +
                "FROM dbo.MONHOC as mh JOIN dbo.LOAIMON as lm ON mh.MaLoaiMon = lm.MaLoaiMon " +
                "WHERE mh.MaMH = '" + comboBoxMaMHCTH.SelectedValue + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count != 0)
            {
                lTenMonCTH.Text = data.Rows[0]["TenMH"].ToString();
                lSoTietCTH.Text = data.Rows[0]["SoTiet"].ToString();
                lSoTCCTH.Text = data.Rows[0]["SoTC"].ToString();
                lLoaiMonCTH.Text = data.Rows[0]["TenLoaiMon"].ToString();
            }
        }
    }
}