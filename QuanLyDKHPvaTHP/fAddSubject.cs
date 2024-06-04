using QuanLyDKHPvaTHP.DAO;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyDKHPvaTHP
{
    public partial class fAddSubject : Form
    {
        private bool flag = false;
        public fAddSubject()
        {
            InitializeComponent();
            loaddquery();
            LoadLoaiMonToComboBox();
        }
        DataTable GetLoaiMon()
        {
            string query = "SELECT MaLoaiMon, TenLoaiMon FROM dbo.LOAIMON";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        void LoadLoaiMonToComboBox()
        {
            DataTable data = GetLoaiMon();
            comboLoaiMon.DataSource = data;
            comboLoaiMon.DisplayMember = "TenLoaiMon";
            comboLoaiMon.ValueMember = "MaLoaiMon";
        }
        private string GenerateNewMaMH(string currentMaxMaDT)
        {
            if (string.IsNullOrEmpty(currentMaxMaDT))
            {
                return "MH001";
            }

            int currentNumber = int.Parse(currentMaxMaDT.Substring(2));
            int newNumber = currentNumber + 1;
            return $"MH{newNumber:D3}";
        }
        public void loaddquery()
        {
            string getMaxMaMHQuery = "SELECT MAX(MaMH) FROM dbo.MONHOC";
            object result = DataProvider.Instance.ExecuteScalar(getMaxMaMHQuery);
            string newMaMH = GenerateNewMaMH(result?.ToString());
            textBoxMaMon.Text = newMaMH;
            if (comboLoaiMon.Text != "System.Data.DataRowView")
            {
                string query = "SELECT SoTietMotTC FROM LOAIMON WHERE MaLoaiMon = 'LM1'";
                int sotiet1tc = (int)DataProvider.Instance.ExecuteScalar(query);
                lbDesSoTiet.Text = "Số tiết phải là bội số của " + sotiet1tc.ToString();
            }
        }
        public void loaddataAdd()
        {

            if (textBoxMaMon.Text == "" || textBoxTenMon.Text == "" || textBoxSoTiet.Text == "" || comboLoaiMon.SelectedValue.ToString() == "")
            {
                flag = false;
                MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string maMH = textBoxMaMon.Text;
                string tenMH = textBoxTenMon.Text;
                int soTiet = int.Parse(textBoxSoTiet.Text);
                string maLoaiMon = comboLoaiMon.SelectedValue.ToString();
                SaveSubject(maMH, tenMH, soTiet, maLoaiMon);
            }
        }
        // Phương thức để lưu dữ liệu vào cơ sở dữ liệu
        void SaveSubject(string maMH, string tenMH, int soTiet, string maLoaiMon)
        {
            try
            {
                string query = "INSERT INTO dbo.MONHOC (MaMH, TenMH, SoTiet, MaLoaiMon) " +
                           "VALUES (N'" + maMH + "', N'" + tenMH + "', " + soTiet + ", N'" + maLoaiMon + "')";
                int rowAffect = DataProvider.Instance.ExecuteNonQuery(query);
                if (rowAffect > 0)
                {
                    MessageBox.Show("Lưu dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    flag = false;
                    MessageBox.Show("Lưu dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                flag = false;
                if (ex.Message.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Đã có môn học này trong cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ex.Message.Split('\n')[0], "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_AddSub_Click(object sender, EventArgs e)
        {
            flag = true;
            loaddataAdd();
        }

        private void fAddSubject_Load(object sender, EventArgs e)
        {
        }

        private void comboLoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboLoaiMon.Text != "System.Data.DataRowView")
            {
                string query = "SELECT SoTietMotTC FROM LOAIMON WHERE MaLoaiMon = '" + comboLoaiMon.SelectedValue.ToString() + "'";
                int sotiet1tc = (int)DataProvider.Instance.ExecuteScalar(query);
                lbDesSoTiet.Text = "Số tiết phải là bội số của " + sotiet1tc.ToString();
            }
            // MessageBox.Show(comboLoaiMon.SelectedValue.ToString());
        }

        private void fAddSubject_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flag)
            {
                if (textBoxMaMon.Text != "" && textBoxTenMon.Text != "" && textBoxSoTiet.Text != "" && comboLoaiMon.SelectedValue.ToString() != "")
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        loaddataAdd();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }
    }
}
