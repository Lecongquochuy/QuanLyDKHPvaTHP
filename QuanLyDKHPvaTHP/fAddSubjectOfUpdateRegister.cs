
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
using static QuanLyDKHPvaTHP.fAddSubjectOfUpdateRegister;
using static QuanLyDKHPvaTHP.fUpdateRegister;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyDKHPvaTHP
{
    public partial class fAddSubjectOfUpdateRegister : Form
    {
        public DataTable SubjectTable = new DataTable();

        private fUpdateRegister fURegister;
        public bool check = true;
        private string maHKNH;
        public fAddSubjectOfUpdateRegister(fUpdateRegister check, string MaHKNH)
        {
            InitializeComponent();
            SubjectTable.Columns.Add("STT", typeof(int));
            SubjectTable.Columns.Add("MaMH", typeof(string));
            SubjectTable.Columns.Add("TenMH", typeof(string));
            SubjectTable.Columns.Add("TenLoaiMon", typeof(string));
            SubjectTable.Columns.Add("SoTC", typeof(string));
            fURegister = check;
            maHKNH = MaHKNH;
        }

        public void AddSubject(object sender, EventArgs e)
        {
            SubjectTable.Rows.Add(0, textBoxMaMonCTH.Text, textBoxTenMonCTH.Text, textBoxLoaiMonCTH.Text, int.Parse(textBoxSoTCCTH.Text));
        }

        private void btn_AddSub_Click(object sender, EventArgs e)
        {
            string SubjectIDValue = textBoxMaMonCTH.Text;
            if (textBoxMaMonCTH.Text == "" || textBoxTenMonCTH.Text == "" || textBoxLoaiMonCTH.Text == "" || textBoxSoTCCTH.Text == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                check = false;
                this.Hide();
            }
            else
            {
                bool exists = fURegister.CheckIfExists(SubjectIDValue);

                if (exists)
                {
                    MessageBox.Show("Môn học đã tồn tại trong chương trình học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    check = false;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Thêm môn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddSubject(sender, e);
                    this.Hide();
                }
            }
        }

        private void textBoxMaMon_Validated(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.DSMHMO " +
                "WHERE MaHKNH = '" + maHKNH + "' AND MaMH = '" + textBoxMaMonCTH.Text + "'";
            object kiemtra = DataProvider.Instance.ExecuteScalar(query);
            if (textBoxMaMonCTH.Text != "")
            {
                if (kiemtra is null)
                {
                    MessageBox.Show("Môn học này không được mở trong học kỳ này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxMaMonCTH.Focus();
                }
                else
                {
                    query = "SELECT MaMH, TenMH, SoTiet, SoTC, TenLoaiMon " +
                    "FROM dbo.MONHOC as mh JOIN dbo.LOAIMON as lm ON mh.MaLoaiMon = lm.MaLoaiMon " +
                    "WHERE mh.MaMH = '" + textBoxMaMonCTH.Text + "'";

                    DataTable data = DataProvider.Instance.ExecuteQuery(query);

                    if (data.Rows.Count != 0)
                    {
                        textBoxTenMonCTH.Text = data.Rows[0]["TenMH"].ToString();
                        textBoxSoTietCTH.Text = data.Rows[0]["SoTiet"].ToString();
                        textBoxSoTCCTH.Text = data.Rows[0]["SoTC"].ToString();
                        textBoxLoaiMonCTH.Text = data.Rows[0]["TenLoaiMon"].ToString();
                        AddSubject(sender, e);
                    }
                    else if (textBoxMaMonCTH.Text.ToString() != "")
                    {
                        MessageBox.Show("Mã môn học không tồn tại");
                    }
                }
            }
        }


        private void fAddSubjectOfUpdateStudyProgram_FormClosed(object sender, FormClosedEventArgs e)
        {
            check = false;
        }
    }
}
