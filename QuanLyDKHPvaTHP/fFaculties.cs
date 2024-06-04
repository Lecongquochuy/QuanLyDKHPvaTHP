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
    public partial class fFaculties : Form
    {
        public fFaculties(int id)
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

        void DefaultLoadList()
        {
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MaKhoa) AS STT, MaKhoa, TenKhoa FROM dbo.KHOA";
            LoadList(query);
        }

        void LoadList(string query)
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

        private void fFaculties_Load(object sender, EventArgs e)
        {
            DefaultLoadList();
        }


        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            DataGridViewColumn column = new DataGridViewColumn();
            column = dataGridView1.Columns[e.ColumnIndex];

            switch (Convert.ToString(column.Name))
            {
                case "Update":
                    row = dataGridView1.Rows[e.RowIndex];
                    string maKhoa = Convert.ToString(row.Cells["FacultiesId"].Value);
                    string tenKhoa = Convert.ToString(row.Cells["FacultiesName"].Value);
                    fUpdateFaculties f = new fUpdateFaculties(maKhoa, tenKhoa);
                    f.ShowDialog();
                    Reload();
                    break;
                case "Delete":
                    row = dataGridView1.Rows[e.RowIndex];
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xoá chứ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            maKhoa = Convert.ToString(row.Cells["FacultiesId"].Value);
                            string deleteQuery = "DELETE FROM KHOA WHERE MaKhoa =  '" + maKhoa + "'";
                            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(deleteQuery);

                            if (rowsAffected == 0)
                            {
                                MessageBox.Show("Có lỗi xảy ra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.Split('\n')[0], "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Reload();
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddFaculties f = new fAddFaculties();
            f.ShowDialog();
            Reload();
        }

        private void Reload()
        {
            string srch = tbSearch.Text;
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MaKhoa) AS STT, " +
                "MaKhoa, TenKhoa FROM dbo.KHOA " +
                "WHERE MaKhoa LIKE '%" + srch + "%' OR TenKhoa LIKE N'%" + srch + "%'";
            LoadList(query);
        }
    }
}