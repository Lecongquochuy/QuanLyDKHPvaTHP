using QuanLyDKHPvaTHP.DAO;
using System.Data;

namespace QuanLyDKHPvaTHP
{
    public partial class fViewOpenSubject : Form
    {
        private string namhoc;
        private string NamHoc;
        private string hocky;
        private int namhocIndex;
        private int hockyIndex;
        private string khoa;
        public event EventHandler ExistFormViewOpenSubjectRequested;
        public fViewOpenSubject(string NamHoc, string HocKy)
        {
            InitializeComponent();
            namhoc = NamHoc;
            hocky = HocKy;
        }

        void LoadSubjectList(string query)
        {
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            dataGridView.DataSource = data;
            Padding cellPadding = new Padding(5, 5, 5, 5);

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.DefaultCellStyle.Padding = cellPadding;
            }
        }


        void DefaultLoadSubjectList()
        {
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MH.MaMH) AS STT, MH.MaMH, TenMH, LM.TenLoaiMon, SoTC " +
                "FROM dbo.MONHOC AS MH JOIN dbo.LOAIMON AS LM ON MH.MaLoaiMon = LM.MaLoaiMon JOIN dbo.CT_NGANH as ctnganh " +
                "ON ctnganh.MaMH = MH.MaMH JOIN dbo.DSMHMO as mo ON mo.MaCT_Nganh = ctnganh.MaCT_Nganh JOIN dbo.HOCKY_NAMHOC hky ON hky.MaHKNH = mo.MaHKNH " +
                "WHERE hky.MaHKNH = '" + comboSemester.SelectedValue + "' AND ctnganh.MaNH = '" + comboBoxMajor.SelectedValue + "'";

            LoadSubjectList(query);
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
                    fviewSubjectOpenSubject fViewSub = new fviewSubjectOpenSubject((string)(row.Cells["MaMH"].Value));
                    fViewSub.ShowDialog();
                    break;
                default:
                    break;
            }

        }
        void LoadNamHocToComboBox()
        {
            string query = "SELECT distinct NamHoc FROM dbo.HOCKY_NAMHOC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            comboSchoolYears.DataSource = data;
            comboSchoolYears.DisplayMember = "NamHoc";
            comboSchoolYears.ValueMember = "NamHoc";
            string values;
            int index = 0;
            foreach (DataRow row in data.Rows)
            {
                values = row["NamHoc"].ToString();
                if (values == namhoc)
                {
                    namhocIndex = index;
                    break;
                }
                index++;
            }
            comboSchoolYears.SelectedIndex = namhocIndex;
            namhoc = comboSchoolYears.SelectedValue.ToString();
        }

        void LoadHocKyToComboBox(string years)
        {
            string query = "SELECT HocKy, MaHKNH FROM dbo.HOCKY_NAMHOC WHERE NamHoc = " + years;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            comboSemester.DataSource = data;
            comboSemester.DisplayMember = "HocKy";
            comboSemester.ValueMember = "MaHKNH";
            string values;
            int index = 0;
            foreach (DataRow row in data.Rows)
            {
                values = row["HocKy"].ToString();
                if (values == hocky)
                {
                    hockyIndex = index;
                    break;
                }
                index++;
            }
            comboSemester.SelectedIndex = hockyIndex;
            DefaultLoadSubjectList();
        }

        void LoadKhoaToComboBox()
        {
            string query = "SELECT TenKhoa, MaKhoa FROM dbo.KHOA";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            comboBoxFaculities.DataSource = data;
            comboBoxFaculities.DisplayMember = "TenKhoa";
            comboBoxFaculities.ValueMember = "MaKhoa";
            comboBoxFaculities.SelectedIndex = 1;
            khoa = comboBoxFaculities.SelectedValue.ToString();
        }

        void LoadNganhToComboBox(string faculities)
        {
            string query = "SELECT TenNH, MaNH FROM dbo.NGANHHOC WHERE MaKhoa = '" + faculities + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            comboBoxMajor.DataSource = data;
            comboBoxMajor.DisplayMember = "TenNH";
            comboBoxMajor.ValueMember = "MaNH";
            DefaultLoadSubjectList();
        }
        private void fViewOpenSubject_Shown(object sender, EventArgs e)
        {
            LoadNamHocToComboBox();
            LoadHocKyToComboBox(namhoc);
            LoadKhoaToComboBox();

        }

        private void comboSchoolYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            NamHoc = comboSchoolYears.SelectedValue.ToString();
            if (NamHoc != "" && NamHoc != "System.Data.DataRowView")
                LoadHocKyToComboBox(NamHoc);
        }

        private void comboSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            DefaultLoadSubjectList();
        }

        private void btn_ViewOpenSubjectExist_Click(object sender, EventArgs e)
        {
            ExistFormViewOpenSubjectRequested?.Invoke(this, EventArgs.Empty);
        }

        private void comboBoxFaculities_SelectedIndexChanged(object sender, EventArgs e)
        {
            khoa = comboBoxFaculities.SelectedValue.ToString();
            if (khoa != "" && khoa != "System.Data.DataRowView")
                LoadNganhToComboBox(khoa);
        }

        private void comboBoxMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DefaultLoadSubjectList();
        }
    }
}