using QuanLyDKHPvaTHP.Components;
using QuanLyDKHPvaTHP.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDKHPvaTHP
{
    public partial class fSubject : Form
    {
        public fSubject(int id)
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
                dataGridView.Columns["Update"].Visible = false;
                dataGridView.Columns["Delete"].Visible = false;
                btnAdd.Visible = false;
            }
        }

        public void reloadSub()
        {
            string srch = tbSearch.Text;
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MaMH) AS STT, MaMH, TenMH, LM.TenLoaiMon, SoTC " +
                "FROM dbo.MONHOC AS MH JOIN dbo.LOAIMON AS LM ON MH.MaLoaiMon = LM.MaLoaiMon " +
                "WHERE MaMH LIKE N'%" + srch + "%' OR TenMH LIKE N'%" + srch + "%'";
            LoadSubjectList(query);

        }
        void DefaultLoadSubjectList()
        {
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MaMH) AS STT, MaMH, TenMH, LM.TenLoaiMon, SoTC " + 
                "FROM dbo.MONHOC AS MH JOIN dbo.LOAIMON AS LM ON MH.MaLoaiMon = LM.MaLoaiMon";

            LoadSubjectList(query);

        }
        void LoadSubjectList(string query)
        {
            dataGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
            // Tạo một đối tượng Padding mới với các giá trị padding mong muốn
            Padding cellPadding = new Padding(5, 5, 5, 5); // Lề trên, lề phải, lề dưới, lề trái

            // Lặp qua từng cột trong DataGridView và đặt Padding cho mỗi cell style của cột
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.DefaultCellStyle.Padding = cellPadding;
            }
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            fAddSubject fAddSub = new fAddSubject();
            fAddSub.ShowDialog();
            reloadSub();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            DataGridViewColumn column = new DataGridViewColumn();
            column = dataGridView.Columns[e.ColumnIndex];

            switch (Convert.ToString(column.Name))
            {
                case "View":
                    row = dataGridView.Rows[e.RowIndex];
                    fViewSubject viewsub = new fViewSubject(Convert.ToString(row.Cells["MaMH"].Value));
                    viewsub.ShowDialog();
                    break;
                case "Update":
                    row = dataGridView.Rows[e.RowIndex];
                    fUpdateSubject updatesub = new fUpdateSubject(Convert.ToString(row.Cells["MaMH"].Value));
                    updatesub.ShowDialog();
                    reloadSub();
                    break;
                case "Delete":
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            row = dataGridView.Rows[e.RowIndex];
                            string mamh = Convert.ToString(row.Cells["MaMH"].Value);
                            string query = "DELETE FROM dbo.MONHOC " +
                                "WHERE MaMH = '" + mamh + "'";
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
                        reloadSub();
                    }
                    break;
                default:
                    break;
            }

        }
        
        private void txtSearchSubject_TextChanged(object sender, EventArgs e)
        {
            reloadSub();
        }

        private void fSubject_Load(object sender, EventArgs e)
        {
            DefaultLoadSubjectList();

        }
    }
}
