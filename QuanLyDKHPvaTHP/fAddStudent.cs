using PdfSharp.Snippets.Drawing;
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
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyDKHPvaTHP
{
    public partial class fAddStudent : Form
    {
        private bool flag = false;
        public fAddStudent()
        {
            InitializeComponent();
            loaddquery();
            LoadComboBox();
        }
        private string GenerateNewMSSV(string currentMaxMSSV)
        {
            if (string.IsNullOrEmpty(currentMaxMSSV))
            {
                return "21520000";
            }
            int currentNumber = int.Parse(currentMaxMSSV.Substring(4));
            int newNumber = currentNumber + 1; ;
            return $"2152{newNumber:D4}";
        }
        public void loaddquery()
        {
            string getMaxMSSVQuery = "SELECT MAX(MSSV) FROM dbo.SINHVIEN";
            object result = DataProvider.Instance.ExecuteScalar(getMaxMSSVQuery);
            string newMSSV = GenerateNewMSSV(result?.ToString());
            textMSSV.Text = newMSSV;
        }

        void LoadComboBox()
        {
            string query = "SELECT MaDT, TenDT FROM dbo.DTUUTIEN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            cbbPriority.DataSource = data;
            cbbPriority.DisplayMember = "TenDT";
            cbbPriority.ValueMember = "MaDT";

            cbbGender.Items.Add("Nam");
            cbbGender.Items.Add("Nữ");

            query = "SELECT MaTinh, TenTinh FROM dbo.TINH";
            data = DataProvider.Instance.ExecuteQuery(query);
            cbbProvince.DataSource = data;
            cbbProvince.DisplayMember = "TenTinh";
            cbbProvince.ValueMember = "MaTinh";

            query = "SELECT MaKhoa, TenKhoa FROM dbo.KHOA";
            data = DataProvider.Instance.ExecuteQuery(query);
            cbbFaculty.DataSource = data;
            cbbFaculty.DisplayMember = "TenKhoa";
            cbbFaculty.ValueMember = "MaKhoa";
        }
        private void cbbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbbProvince.SelectedValue.ToString());
            string query = "SELECT MaHuyen, TenHuyen FROM dbo.HUYEN WHERE MaTinh = '" + cbbProvince.SelectedValue.ToString() + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            cbbDistrict.DataSource = data;
            cbbDistrict.DisplayMember = "TenHuyen";
            cbbDistrict.ValueMember = "MaHuyen";
        }

        private void cbbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT MaNH, TenNH FROM dbo.NGANHHOC WHERE MaKhoa = '" + cbbFaculty.SelectedValue.ToString() + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            cbbMajor.DataSource = data;
            cbbMajor.DisplayMember = "TenNH";
            cbbMajor.ValueMember = "MaNH";
        }
        public void loaddataAdd()
        {
            if (textMSSV.Text == "" || dtpBirthday.Text == "" || txbFullname.Text == "" || cbbPriority.Text == "" || cbbGender.Text == "" || cbbDistrict.Text == "" || cbbProvince.Text == "" || cbbMajor.Text == "" || cbbFaculty.Text == "")
            {
                flag = false;
                MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string mssv = textMSSV.Text;
                DateTime ngaysinh = dtpBirthday.Value;
                string hoten = txbFullname.Text;
                string madt = cbbPriority.SelectedValue.ToString();
                string gioitinh = cbbGender.Text;
                string mahuyen = cbbDistrict.SelectedValue.ToString();
                string manh = cbbMajor.SelectedValue.ToString();
                SaveStudent(mssv, hoten, madt, ngaysinh, gioitinh, mahuyen, manh);
            }
        }
        // Phương thức để lưu dữ liệu vào cơ sở dữ liệu
        void SaveStudent(string mssv, string hoten, string madt, DateTime ngaysinh, string gioitinh, string mahuyen, string manh)
        {
            try
            {
                //MessageBox.Show(ngaysinh);
                string query = "INSERT INTO dbo.SINHVIEN(MSSV, HoTen, NgaySinh, GioiTinh, MaHuyen, MaDT, MaNH) " +
                    "VALUES ('" + mssv + "', N'" + hoten + "', '" + ngaysinh + "', N'" + gioitinh + "', '" + mahuyen + "', '" + madt + "', '" + manh + "')";
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
                    MessageBox.Show("Đã có sinh viên này trong cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ex.Message.Split('\n')[0], "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            loaddataAdd();
        }

        private void fAddStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flag)
            {
                if (textMSSV.Text != "" && dtpBirthday.Text != "" && txbFullname.Text != "" && cbbPriority.Text != "" && cbbGender.Text != "" && cbbDistrict.Text != "" && cbbProvince.Text != "" && cbbMajor.Text != "" && cbbFaculty.Text != "")
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
