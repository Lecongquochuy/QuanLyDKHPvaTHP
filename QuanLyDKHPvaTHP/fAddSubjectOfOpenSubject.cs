using QuanLyDKHPvaTHP.DAO;
using System.Data;
using System.Windows.Forms;

namespace QuanLyDKHPvaTHP
{
    public partial class fAddSubjectOfAddOpenSubject : Form
    {
        public DataTable SubjectTable = new DataTable();
        public bool check = true;
        private bool add = true;
        private fAddOpenSubject fAddOpenSub;
        public fAddSubjectOfAddOpenSubject(fAddOpenSubject fAOS)
        {
            InitializeComponent();
            SubjectTable.Columns.Add("STT", typeof(int));
            SubjectTable.Columns.Add("MaMH", typeof(string));
            SubjectTable.Columns.Add("TenMH", typeof(string));
            SubjectTable.Columns.Add("TenLoaiMon", typeof(string));
            SubjectTable.Columns.Add("SoTC", typeof(string));
            fAddOpenSub = fAOS;
            LoadSubjectID();
            comboBoxOSMaMon.SelectedIndex = 1;
        }

        void LoadSubjectID()
        {
            string query = "SELECT MaMH " +
                "FROM dbo.MONHOC AS mh " +
                "WHERE mh.MaMH in (SELECT MaMH FROM dbo.CT_NGANH as ct WHERE ct.MaNH = '" + fAddOpenSub.manganh + "') ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                if (fAddOpenSub.CheckIfExists(row["MaMH"].ToString()))
                {
                    row.Delete();
                }
            }
            comboBoxOSMaMon.DataSource = data;
            comboBoxOSMaMon.DisplayMember = "MaMH";
            comboBoxOSMaMon.ValueMember = "MaMH";
        }
        public void AddSubject(object sender, EventArgs e)
        {
            SubjectTable.Rows.Add(0, comboBoxOSMaMon.SelectedValue, labelOSTenMon.Text, labelOSLoaiMon.Text, int.Parse(labelOSSoTC.Text));
            string query = "SELECT MaMH, TenMH, SoTiet, SoTC, TenLoaiMon " +
                    "FROM dbo.MONHOC as mh JOIN dbo.LOAIMON as lm ON mh.MaLoaiMon = lm.MaLoaiMon " +
                    "WHERE mh.TenMH = N'" + labelOSTenMon.Text + "' AND mh.MaMH != '" + comboBoxOSMaMon.SelectedValue + "' AND mh.MaMH in (SELECT MaMH " +
                    "FROM dbo.MONHOC AS mh " +
                    "WHERE mh.MaMH in (SELECT MaMH FROM dbo.CT_NGANH as ct WHERE ct.MaNH = '" + fAddOpenSub.manganh + "') )";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                SubjectTable.Rows.Add(1, data.Rows[0]["MaMH"], data.Rows[0]["TenMH"], data.Rows[0]["TenLoaiMon"], int.Parse(data.Rows[0]["SoTC"].ToString()));
            }
        }
        private void btn_AddSub_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            add = false;
            AddSubject(sender, e);
            this.Hide();
        }


        private void comboBoxOSMaMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT MaMH, TenMH, SoTiet, SoTC, TenLoaiMon " +
                "FROM dbo.MONHOC as mh JOIN dbo.LOAIMON as lm ON mh.MaLoaiMon = lm.MaLoaiMon " +
                "WHERE mh.MaMH = '" + comboBoxOSMaMon.SelectedValue + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count != 0)
            {
                labelOSTenMon.Text = data.Rows[0]["TenMH"].ToString();
                labelOSSoTiet.Text = data.Rows[0]["SoTiet"].ToString();
                labelOSSoTC.Text = data.Rows[0]["SoTC"].ToString();
                labelOSLoaiMon.Text = data.Rows[0]["TenLoaiMon"].ToString();
            }
        }

        private void fAddSubjectOpenSubject_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (add)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        MessageBox.Show("Thêm môn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AddSubject(sender, e);
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    check = false;
                }
            }
        }
    }
}