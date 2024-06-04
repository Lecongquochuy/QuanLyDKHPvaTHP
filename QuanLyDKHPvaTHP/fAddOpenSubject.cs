using QuanLyDKHPvaTHP.DAO;
using System.Data;

namespace QuanLyDKHPvaTHP
{
    public partial class fAddOpenSubject : Form
    {
        public event EventHandler ExistFormAddOpenSubjectRequested;
        private string str = "";
        private string khoa = "";
        public string manganh;

        public fAddOpenSubject()
        {
            InitializeComponent();
            Padding cellPadding = new Padding(5, 5, 5, 5);
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.DefaultCellStyle.Padding = cellPadding;
            }

            data.Columns.Add("STT", typeof(int));
            data.Columns.Add("MaMH", typeof(string));
            data.Columns.Add("TenMH", typeof(string));
            data.Columns.Add("TenLoaiMon", typeof(string));
            data.Columns.Add("SoTC", typeof(string));
        }

        private int currentYear = DateTime.Now.Year;

        private DataTable data = new DataTable();

        private void AddRowToDGV(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                row["STT"] = dataGridView.RowCount + 1;
                data.Rows.Add(row.ItemArray);
            }

        }

        void LoadData()
        {
            dataGridView.DataSource = data;
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
        }
        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            manganh = comboBoxMajor.SelectedValue.ToString();
            fAddSubjectOfAddOpenSubject fAddSub = new fAddSubjectOfAddOpenSubject(this);
            fAddSub.ShowDialog();
            if (fAddSub.check)
            {
                AddRowToDGV(fAddSub.SubjectTable);
            }
            LoadData();
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
                case "Delete":
                    string query = "SELECT MaMH " +
                    "FROM dbo.MONHOC as mh JOIN dbo.LOAIMON as lm ON mh.MaLoaiMon = lm.MaLoaiMon " +
                    "WHERE mh.TenMH = N'" + data.Rows[e.RowIndex]["TenMH"] + "' AND mh.MaMH != '" + data.Rows[e.RowIndex]["MaMH"] + "'";
                    object mamon = DataProvider.Instance.ExecuteScalar(query);
                    int rowindex = -1;
                    if (mamon is not null)
                    {
                        foreach (DataRow dr in data.Rows)
                        {
                            rowindex++;
                            if (dr["MaMH"].ToString() == mamon.ToString())
                            {
                                break;
                            }
                        }
                        data.Rows.RemoveAt(rowindex);
                    }
                    if (rowindex > -1 && rowindex < e.RowIndex)
                    {
                        data.Rows.RemoveAt(e.RowIndex - 1);
                    }
                    else data.Rows.RemoveAt(e.RowIndex);
                    LoadData();
                    break;
                default:
                    break;
            }

        }

        void LoadNamHocToComboBox()
        {
            string query = "SELECT distinct NamHoc " +
                "FROM dbo.HOCKY_NAMHOC AS HKy WHERE NamHoc >= " + (currentYear - 1)
                + " AND NOT EXISTS (SELECT * FROM dbo.DSMHMO AS MHMo WHERE MHMo.MaHKNH = Hky.MaHKNH) AND HocKy = 3";
            comboSchoolYears.DataSource = DataProvider.Instance.ExecuteQuery(query);
            comboSchoolYears.DisplayMember = "NamHoc";
            comboSchoolYears.ValueMember = "NamHoc";
        }

        void LoadHocKyToComboBox(string years)
        {
            string query = "SELECT HocKy, MaHKNH FROM dbo.HOCKY_NAMHOC AS HKy WHERE NamHoc = " + years
                + " AND NOT EXISTS (SELECT * FROM dbo.DSMHMO AS MHMo WHERE MHMo.MaHKNH = Hky.MaHKNH) AND HocKy = 3";

            comboSemester.DataSource = DataProvider.Instance.ExecuteQuery(query);
            comboSemester.DisplayMember = "HocKy";
            comboSemester.ValueMember = "MaHKNH";

        }
        private void fAddOpenSubject_Shown(object sender, EventArgs e)
        {
            LoadNamHocToComboBox();
            LoadKhoaToComboBox();
        }

        private void comboSchoolYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            str = comboSchoolYears.Text;
            if (str != "" && str != "System.Data.DataRowView")
                LoadHocKyToComboBox(str);
        }

        private void comboSemester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public bool CheckIfExists(string valueToCheck)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["MaMH"].Value != null && row.Cells["MaMH"].Value.ToString() == valueToCheck)
                {
                    return true;
                }
            }
            return false;
        }
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            manganh = comboBoxMajor.SelectedValue.ToString();
            string query = "SELECT MAX(MaMo) FROM dbo.DSMHMO";
            string MaxMM = DataProvider.Instance.ExecuteQuery(query).Rows[0][0].ToString();

            MaxMM = MaxMM.Substring(3);

            int maxMaMo = int.Parse(MaxMM);

            query = "INSERT INTO DSMHMO(MaMo, MaHKNH, MaCT_Nganh) VALUES ";

            foreach (DataRow row in data.Rows)
            {
                string mamo;
                string queryctNganh = "SELECT MaCT_Nganh FROM dbo.CT_NGANH WHERE MaMH = '" + row["MaMH"] + "' AND MaNH = '" + manganh + "'";
                string mactnganh = (string)DataProvider.Instance.ExecuteScalar(queryctNganh);
                MessageBox.Show(queryctNganh + " - " + mactnganh);

                if (maxMaMo < 9)
                {
                    mamo = "MM00000" + (maxMaMo + 1).ToString();
                }
                else if (maxMaMo < 99)
                {
                    mamo = "MM0000" + (maxMaMo + 1).ToString();
                }
                else if (maxMaMo < 999)
                {
                    mamo = "MM000" + (maxMaMo + 1).ToString();
                }
                else if (maxMaMo < 9999)
                {
                    mamo = "MM00" + (maxMaMo + 1).ToString();
                }
                else if (maxMaMo < 99999)
                {
                    mamo = "MM0" + (maxMaMo + 1).ToString();
                }
                else mamo = "MM" + (maxMaMo + 1).ToString();

                maxMaMo += 1;
                query += "('" + mamo + "', '" + comboSemester.SelectedValue + "', '" + mactnganh + "')";

                if (data.Rows.IndexOf(row) == data.Rows.Count - 1)
                {
                    query += ";";
                }
                else
                {
                    query += ", ";
                }
            }
            try
            {
                int rowAffect = DataProvider.Instance.ExecuteNonQuery(query);
                if (rowAffect > 0)
                {
                    MessageBox.Show("Lưu dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Lưu dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ExistFormAddOpenSubjectRequested?.Invoke(this, EventArgs.Empty);
        }

        private void comboBoxFaculities_SelectedIndexChanged(object sender, EventArgs e)
        {
            khoa = comboBoxFaculities.SelectedValue.ToString();
            if (khoa != "" && khoa != "System.Data.DataRowView")
                LoadNganhToComboBox(khoa);
        }
    }
}