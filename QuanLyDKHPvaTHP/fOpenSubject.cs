using QuanLyDKHPvaTHP.DAO;
using System.Windows.Forms;

namespace QuanLyDKHPvaTHP
{
    public partial class fOpenSubject : Form
    {
        public string NamHoc;
        public string HocKy;
        public string localquery;

        public event EventHandler ShowFormAddOpenSubjectRequested;
        public event EventHandler ShowFormViewOpenSubjectRequested;
        public event EventHandler ShowFormUpdateOpenSubjectRequested;
        public fOpenSubject(int id)
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
                btnAdd.Visible = false;
            }
        }
        public void DefaultLoadOpenSubjectList()
        {
            string query = "SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY MaHKNH) AS STT, NamHoc AS [Năm học], HocKy AS [Học kỳ] " +
                "FROM dbo.HOCKY_NAMHOC as HKy " +
                "WHERE EXISTS (SELECT * FROM dbo.DSMHMO as MHMo WHERE HKy.MaHKNH = MHMo.MaHKNH)";
            localquery = query;
            LoadOpenSubjectList(query);
        }

        void LoadOpenSubjectList(string query)
        {
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery(query);
            Padding cellPadding = new Padding(5, 5, 5, 5);
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
            string query = "SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY MaHKNH) AS STT, NamHoc AS [Năm học], HocKy AS [Học kỳ] " +
                "FROM dbo.HOCKY_NAMHOC as HKy " +
                "WHERE EXISTS (SELECT * FROM dbo.DSMHMO as MHMo WHERE HKy.MaHKNH = MHMo.MaHKNH) AND NamHoc LIKE '%" + srch + "%' OR HocKy LIKE '%" + srch + "%'";
            localquery = query;
            LoadOpenSubjectList(query);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            DataGridViewColumn column = new DataGridViewColumn();
            column = dataGridView1.Columns[e.ColumnIndex];

            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

            NamHoc = selectedRow.Cells["SchoolYear"].Value.ToString();
            HocKy = selectedRow.Cells["Semester"].Value.ToString();

            switch (Convert.ToString(column.Name))
            {
                case "View":
                    ShowFormViewOpenSubjectRequested?.Invoke(this, EventArgs.Empty);
                    break;
                case "Update":
                    DateTime date = DateTime.Now;
                    DateTime ky1 = new DateTime(int.Parse(NamHoc), 8, 1);
                    DateTime ky2 = new DateTime(int.Parse(NamHoc) + 1, 1, 1);
                    DateTime kyhe = new DateTime(int.Parse(NamHoc) + 1, 7, 1);
                    switch (HocKy)
                    {
                        case "1":
                            if (date < ky1)
                            {
                                ShowFormUpdateOpenSubjectRequested?.Invoke(this, EventArgs.Empty);
                            }
                            else
                            {
                                MessageBox.Show("Đã qua thời gian chỉnh sửa danh sách môn học mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                        case "2":
                            if (date < ky2)
                            {
                                ShowFormUpdateOpenSubjectRequested?.Invoke(this, EventArgs.Empty);
                            }
                            else
                            {
                                MessageBox.Show("Đã qua thời gian chỉnh sửa danh sách môn học mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                        default:
                            if (date < kyhe)
                            {
                                ShowFormUpdateOpenSubjectRequested?.Invoke(this, EventArgs.Empty);
                            }
                            else
                            {
                                MessageBox.Show("Đã qua thời gian chỉnh sửa danh sách môn học mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                    }

                    break;
                default:
                    break;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowFormAddOpenSubjectRequested?.Invoke(this, EventArgs.Empty);
        }

    }
}