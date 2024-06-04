using QuanLyDKHPvaTHP.Components;
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
    public partial class fStudyProgram : Form
    {
        public event EventHandler ShowFormStudyProgramAddRequested;
        public event EventHandler ShowFormStudyProgramUpdateRequested;
        public event EventHandler ShowFormStudyProgramViewRequested;

        public string FacultiesValue;
        public string MajorValue;

        private string majorID;
        public fStudyProgram(int id)
        {
            InitializeComponent();
            // Tạo một đối tượng Padding mới với các giá trị padding mong muốn
            Padding cellPadding = new Padding(5, 5, 5, 5); // Lề trên, lề phải, lề dưới, lề trái

            // Lặp qua từng cột trong DataGridView và đặt Padding cho mỗi cell style của cột
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.DefaultCellStyle.Padding = cellPadding;
            }
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
        void DefaultLoadStudyProgramList()
        {
            string query = "SELECT distinct NH.MaNH, TenNH, TenKhoa " +
                "FROM dbo.NGANHHOC AS NH JOIN dbo.CT_NGANH AS CT_NG ON CT_NG.MaNH = NH.MaNH " +
                "join dbo.KHOA AS K ON NH.MaKhoa = K.MaKhoa";

            LoadStudyProgramList(query);
        }
        public void reloadStuProList()
        {
            string query = "SELECT distinct NH.MaNH, TenNH, TenKhoa " +
                "FROM dbo.NGANHHOC AS NH JOIN dbo.CT_NGANH AS CT_NG ON CT_NG.MaNH = NH.MaNH " +
                "join dbo.KHOA AS K ON NH.MaKhoa = K.MaKhoa";

            LoadStudyProgramList(query);
        }
        void LoadStudyProgramList(string query)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            DataColumn sttColumn = new DataColumn("STT", typeof(int));
            dt.Columns.Add(sttColumn);
            dt.Columns.Remove("MaNH");
            int counter = 1;
            foreach (DataRow row in dt.Rows)
            {
                row["STT"] = counter;
                counter++;
            }
            dt.Columns["STT"].SetOrdinal(0);
            dataGridView.DataSource = dt;
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            DataGridViewColumn column = new DataGridViewColumn();
            column = dataGridView.Columns[e.ColumnIndex];

            int selectedRowIndex = dataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView.Rows[selectedRowIndex];

            FacultiesValue = Convert.ToString(selectedRow.Cells["TenKhoa"].Value);
            MajorValue = Convert.ToString(selectedRow.Cells["TenNH"].Value);
            string query = "SELECT MaNH FROM dbo.NGANHHOC WHERE TenNH = N'" + MajorValue + "'";
            majorID = (string)DataProvider.Instance.ExecuteScalar(query);

            switch (Convert.ToString(column.Name))
            {
                case "View":
                    ShowFormStudyProgramViewRequested?.Invoke(this, EventArgs.Empty);
                    break;
                case "Update":
                    if (dataGridView.SelectedCells.Count > 0)
                    {
                        ShowFormStudyProgramUpdateRequested?.Invoke(this, EventArgs.Empty);
                    }
                    break;
                case "Delete":
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            string query1 = "DELETE FROM dbo.CT_NGANH " +
                                "WHERE MaNH = '" + majorID + "'";
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
                        reloadStuProList();
                    }
                    break;
                default:
                    break;
            }

        }

        private void txtSearchSubject_TextChanged(object sender, EventArgs e)
        {
            string srch = tbSearch.Text;
            string query = "SELECT distinct NH.MaNH, TenNH, TenKhoa " +
                "FROM dbo.NGANHHOC AS NH JOIN dbo.CT_NGANH AS CT_NG ON CT_NG.MaNH = NH.MaNH " +
                "join dbo.KHOA AS K ON NH.MaKhoa = K.MaKhoa " +
                "WHERE TenNH LIKE N'%" + srch + "%' OR TenKhoa LIKE N'%" + srch + "%'";

            LoadStudyProgramList(query);
        }

        private void fStudyProgram_Load(object sender, EventArgs e)
        {
            DefaultLoadStudyProgramList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowFormStudyProgramAddRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
