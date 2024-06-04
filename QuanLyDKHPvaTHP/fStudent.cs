using QuanLyDKHPvaTHP.DAO;
using System;
using System.Collections;
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
    public partial class fStudent : Form
    {
        public fStudent(int id)
        {
            InitializeComponent();
            Authorization(id);
        }
        private void Authorization(int id)
        {
            string query = "SELECT Type FROM dbo.ACCOUNT WHERE ID = " + id;
            int role = (int)DataProvider.Instance.ExecuteScalar(query);
            if (role == 2)
            {
                dataGridView1.Columns["Update"].Visible = false;
                dataGridView1.Columns["Delete"].Visible = false;
                btnAdd.Visible = false;
            }
        }
        public void reloadStudent()
        {
            string srch = tbSearch.Text;
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MSSV) AS STT, MSSV, HoTen, TenNH " +
                "FROM dbo.SINHVIEN AS SV JOIN dbo.NGANHHOC AS NH ON SV.MaNH = NH.MaNH " +
                "WHERE MSSV LIKE '%" + srch + "%' OR HoTen LIKE N'%" + srch + "%' OR TenNH LIKE N'%" + srch + "%'";

            LoadOpenSubjectList(query);

        }
        void DefaultLoadOpenSubjectList()
        {
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MSSV) AS STT, MSSV, HoTen, TenNH " +
                "FROM dbo.SINHVIEN AS SV JOIN dbo.NGANHHOC AS NH ON SV.MaNH = NH.MaNH";

            LoadOpenSubjectList(query);
        }

        void LoadOpenSubjectList(string query)
        {
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery(query);
            // Tạo một đối tượng Padding mới với các giá trị padding mong muốn
            Padding cellPadding = new Padding(5, 5, 5, 5); // Lề trên, lề phải, lề dưới, lề trái

            // Lặp qua từng cột trong DataGridView và đặt Padding cho mỗi cell style của cột
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Padding = cellPadding;
            }
        }


        private void fOpenSubject_Shown(object sender, EventArgs e)
        {
            DefaultLoadOpenSubjectList();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string srch = tbSearch.Text;
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MSSV) AS STT, MSSV, HoTen, TenNH " +
                "FROM dbo.SINHVIEN AS SV JOIN dbo.NGANHHOC AS NH ON SV.MaNH = NH.MaNH " +
                "WHERE MSSV LIKE '%" + srch + "%' OR HoTen LIKE N'%" + srch + "%' OR TenNH LIKE N'%" + srch + "%'";
            LoadOpenSubjectList(query);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            DataGridViewColumn column = new DataGridViewColumn();
            column = dataGridView1.Columns[e.ColumnIndex];

            switch (Convert.ToString(column.Name))
            {
                case "View":
                    row = dataGridView1.Rows[e.RowIndex];
                    //MessageBox.Show("View " + Convert.ToString(row.Cells["OpenSubjectID"].Value));
                    fViewStudent viewstudent = new fViewStudent(Convert.ToString(row.Cells["MSSV"].Value));
                    viewstudent.ShowDialog();
                    break;
                case "Update":
                    row = dataGridView1.Rows[e.RowIndex];
                    //MessageBox.Show("Update " + Convert.ToString(row.Cells["OpenSubjectID"].Value));
                    fUpdateStudent updatestudent = new fUpdateStudent(Convert.ToString(row.Cells["MSSV"].Value));
                    updatestudent.ShowDialog();
                    reloadStudent();
                    break;
                case "Delete":
                    row = dataGridView1.Rows[e.RowIndex];
                    //MessageBox.Show("Delete " + Convert.ToString(row.Cells["OpenSubjectID"].Value));
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            row = dataGridView1.Rows[e.RowIndex];
                            string mssv = Convert.ToString(row.Cells["MSSV"].Value);
                            string query = "DELETE FROM dbo.SINHVIEN " +
                                "WHERE MSSV = '" + mssv + "'";
                            int rowAffect = DataProvider.Instance.ExecuteNonQuery(query);
                            if (rowAffect == 0)
                            {
                                MessageBox.Show("Xóa dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        reloadStudent();
                    }
                    break;
                default:
                    break;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddStudent fAddStudent = new fAddStudent();
            fAddStudent.ShowDialog();
            reloadStudent();
        }
    }
}
