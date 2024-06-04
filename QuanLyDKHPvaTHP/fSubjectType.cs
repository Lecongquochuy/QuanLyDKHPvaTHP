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
    public partial class fSubjectType : Form
    {
        public fSubjectType(int id)
        {
            InitializeComponent();
            DefaultLoadSubjectTypeList();
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
        public void reloadSubType()
        {
            string srch = tbSearch.Text;
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MaLoaiMon) AS STT, MaLoaiMon, TenLoaiMon, SoTietMotTC, REPLACE(FORMAT(CAST(SoTienMotTC AS DECIMAL(19, 0)), 'N0', 'en-US'), ',', '.') AS SoTienMotTC " +
                "FROM dbo.LOAIMON " +
                "WHERE MaLoaiMon LIKE N'%" + srch + "%' OR TenLoaiMon LIKE N'%" + srch + "%'";
            LoadSubjectTypeList(query);

        }
        void DefaultLoadSubjectTypeList()
        {
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MaLoaiMon) AS STT, MaLoaiMon, TenLoaiMon, SoTietMotTC, REPLACE(FORMAT(CAST(SoTienMotTC AS DECIMAL(19, 0)), 'N0', 'en-US'), ',', '.') AS SoTienMotTC " +
                "FROM dbo.LOAIMON";

            LoadSubjectTypeList(query);

        }
        void LoadSubjectTypeList(string query)
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            DataGridViewColumn column = new DataGridViewColumn();
            column = dataGridView.Columns[e.ColumnIndex];

            switch (Convert.ToString(column.Name))
            {
                case "Update":
                    row = dataGridView.Rows[e.RowIndex];
                    string maloaimon = Convert.ToString(row.Cells["MaLoaiMon"].Value);
                    string tenloaimon = Convert.ToString(row.Cells["TenLoaiMon"].Value);
                    string sotietmottc = Convert.ToString(row.Cells["SoTietMotTC"].Value);
                    string sotienmottc = Convert.ToString(row.Cells["SoTienMotTC"].Value);

                    fUpdateSubjectType updatesubtype = new fUpdateSubjectType(maloaimon, tenloaimon, sotietmottc, sotienmottc);
                    updatesubtype.ShowDialog();
                    reloadSubType();
                    break;
                case "Delete":
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            row = dataGridView.Rows[e.RowIndex];
                            string mamh = Convert.ToString(row.Cells["MaLoaiMon"].Value);
                            string query = "DELETE FROM dbo.LOAIMON " +
                                "WHERE MaLoaiMon = '" + mamh + "'";
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
                        reloadSubType();
                    }
                    break;
                default:
                    break;
            }

        }
        private void txtSearchSubject_TextChanged(object sender, EventArgs e)
        {
            reloadSubType();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddSubjectType fAddSubType = new fAddSubjectType();
            fAddSubType.ShowDialog();
            reloadSubType();
        }
    }
}
