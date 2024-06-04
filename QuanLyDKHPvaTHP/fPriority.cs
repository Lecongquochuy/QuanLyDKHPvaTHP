using QuanLyDKHPvaTHP.DAO;
using System.Data;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyDKHPvaTHP
{
    public partial class fPriority : Form
    {
        public fPriority(int id)
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

        void DefaultLoadPriorityList()
        {
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MaDT) AS STT, MaDT, TenDT, TiLeGiam FROM dbo.DTUUTIEN";
            LoadPriorityList(query);
        }

        void LoadPriorityList(string query)
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

        private void fPriority_Load(object sender, EventArgs e)
        {
            DefaultLoadPriorityList();
        }


        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string srch = tbSearch.Text;
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MaDT) AS STT, " +
                "MaDT, TenDT, TiLeGiam FROM dbo.DTUUTIEN " +
                "WHERE MaDT LIKE '%" + srch + "%' OR TenDT LIKE N'%" + srch + "%' OR TiLeGiam LIKE '%" + srch + "%'";

            LoadPriorityList(query);
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
                    string maDT = Convert.ToString(row.Cells["PriorityId"].Value);
                    string tenDT = Convert.ToString(row.Cells["PriorityName"].Value);
                    string tiLeGiam = Convert.ToString(row.Cells["ReducationRate"].Value);
                    fUpdatePriority f = new fUpdatePriority(maDT, tenDT, tiLeGiam);
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
                            maDT = Convert.ToString(row.Cells["PriorityId"].Value);
                            string deleteQuery = "DELETE FROM DTUUTIEN WHERE MaDT =  '" + maDT + "'";
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
            fAddPriority f = new fAddPriority();
            f.ShowDialog();
            Reload();
        }

        private void Reload()
        {
            string srch = tbSearch.Text;
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MaDT) AS STT, " +
                "MaDT, TenDT, TiLeGiam FROM dbo.DTUUTIEN " +
                "WHERE MaDT LIKE '%" + srch + "%' OR TenDT LIKE N'%" + srch + "%' OR TiLeGiam LIKE '%" + srch + "%'";
            LoadPriorityList(query);
        }
    }
}
