
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
    public partial class fRegisterCourse : Form
    {
        public event EventHandler ShowFormRegisterAddRequested;
        public event EventHandler ShowFormRegisterUpdateRequested;
        public event EventHandler ShowFormRegisterViewRequested;

        public string maPhieu;

        public fRegisterCourse(int id)
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
        void DefaultLoadRegisterCourseList()
        {
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MaPhieuDKHP) AS STT, MaPhieuDKHP, MSSV, NamHoc, HocKy, NgayLap " +
                           "FROM dbo.PHIEUDKHP AS DKHP JOIN dbo.HOCKY_NAMHOC AS HKNH ON DKHP.MaHKNH = HKNH.MaHKNH";

            LoadRegisterCourseList(query);
        }

        public void reloadRegisterList()
        {
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MaPhieuDKHP) AS STT, MaPhieuDKHP, MSSV, NamHoc, HocKy, NgayLap " +
                           "FROM dbo.PHIEUDKHP AS DKHP JOIN dbo.HOCKY_NAMHOC AS HKNH ON DKHP.MaHKNH = HKNH.MaHKNH";

            LoadRegisterCourseList(query);
        }


        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            DataGridViewColumn column = new DataGridViewColumn();
            column = dataGridView.Columns[e.ColumnIndex];

            int selectedRowIndex = dataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView.Rows[selectedRowIndex];

            maPhieu = Convert.ToString(selectedRow.Cells["MaPhieuDKHP"].Value);

            switch (Convert.ToString(column.Name))
            {
                case "View":
                    ShowFormRegisterViewRequested?.Invoke(this, EventArgs.Empty);
                    break;
                case "Update":
                    if (dataGridView.SelectedCells.Count > 0)
                    {
                        ShowFormRegisterUpdateRequested?.Invoke(this, EventArgs.Empty);
                    }
                    break;
                case "Delete":
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            string query1 = "DELETE FROM PHIEUDKHP " +
                                "WHERE MaPhieuDKHP = '" + maPhieu + "'";
                            int rowAffect = DataProvider.Instance.ExecuteNonQuery(query1);
                            if (rowAffect == 0)
                            {
                                MessageBox.Show("Xóa dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        reloadRegisterList();
                    }
                    break;
                default:
                    break;
            }

        }
        void LoadRegisterCourseList(string query)
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


        private void txtSearchRegisterCourse_TextChanged(object sender, EventArgs e)
        {
            string srch = tbSearch.Text;
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MaPhieuDKHP) AS STT, MaPhieuDKHP, MSSV, NamHoc, HocKy, NgayLap " +
                "FROM dbo.PHIEUDKHP AS DKHP JOIN dbo.HOCKY_NAMHOC AS HKNH ON DKHP.MaHKNH = HKNH.MaHKNH " +
                "WHERE MaPhieuDKHP LIKE N'%" + srch + "%' OR MSSV LIKE N'%" + srch + "%' OR NamHoc LIKE N'%" + srch + "%' OR HocKy LIKE N'%" + srch + "%' OR HocKy LIKE N'%" + srch + "%'";

            LoadRegisterCourseList(query);
        }

        private void fRegisterCourse_Load(object sender, EventArgs e)
        {
            DefaultLoadRegisterCourseList();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowFormRegisterAddRequested?.Invoke(this, EventArgs.Empty);
        }

    }
}