using QuanLyDKHPvaTHP.DAO;
using System;
using System.Collections;
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
    public partial class fUpdateStudent : Form
    {
        private bool flag = false;
        private string MSSV;
        private string makhoa;
        private string matinh;
        public fUpdateStudent(string mssv)
        {
            InitializeComponent();
            MSSV = mssv;
            LoadComboBox();
            LoadStudent(MSSV);
        }
        void LoadStudent(string mssv)
        {
            string query = "SELECT MSSV, HoTen, TenDT, NgaySinh, GioiTinh, TenHuyen, TenTinh, TenKhoa, TenNH " +
                "FROM dbo.SINHVIEN AS SV JOIN dbo.NGANHHOC AS NH ON SV.MaNH = NH.MaNH " +
                "JOIN dbo.KHOA AS K ON NH.MaKhoa = K.MaKhoa " +
                "JOIN dbo.HUYEN AS H ON SV.MaHuyen = H.MaHuyen " +
                "JOIN dbo.TINH AS T ON H.MaTinh = T.MaTinh " +
                "JOIN dbo.DTUUTIEN AS DT ON SV.MaDT = DT.MaDT " +
                "WHERE MSSV = '" + mssv + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                //mssv = row["MSSV"].ToString();
                string hoten = row["HoTen"].ToString();
                string tendt = row["TenDT"].ToString();
                string ngaysinh = row["NgaySinh"].ToString();
                string gioitinh = row["GioiTinh"].ToString();
                string tenhuyen = row["TenHuyen"].ToString();
                string tentinh = row["TenTinh"].ToString();
                string tenkhoa = row["TenKhoa"].ToString();
                string tennh = row["TenNH"].ToString();
                loaddata(mssv, hoten, tendt, ngaysinh, gioitinh, tenhuyen, tentinh, tenkhoa, tennh);
            }
            else
            {
                flag = false;
                MessageBox.Show("Không tìm thấy sinh viên với mã: " + MSSV);
            }
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

            defaultLoadcombo();
        }
        public void loaddata(string mssv, string hoten, string tendt, string ngaysinh, string gioitinh, string tenhuyen, string tentinh, string tenkhoa, string tennh)
        {
            textMSSV.Text = mssv;
            dtpBirthday.Text = ngaysinh;
            txbFullname.Text = hoten;
            cbbPriority.Text = tendt;
            cbbGender.Text = gioitinh;
            cbbDistrict.Text = tenhuyen;
            cbbProvince.Text = tentinh;
            cbbMajor.Text = tennh;
            cbbFaculty.Text = tenkhoa;

        }
        private void defaultLoadcombo()
        {
            string query = "SELECT MaHuyen, TenHuyen FROM dbo.HUYEN WHERE MaTinh = '" + cbbProvince.SelectedValue.ToString() + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            cbbDistrict.DataSource = data;
            cbbDistrict.DisplayMember = "TenHuyen";
            cbbDistrict.ValueMember = "MaHuyen";

            query = "SELECT MaNH, TenNH FROM dbo.NGANHHOC WHERE MaKhoa = '" + cbbFaculty.SelectedValue.ToString() + "'";
            data = DataProvider.Instance.ExecuteQuery(query);
            cbbMajor.DataSource = data;
            cbbMajor.DisplayMember = "TenNH";
            cbbMajor.ValueMember = "MaNH";
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
        public void loaddataUpdate()
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
                string query = "UPDATE dbo.SINHVIEN " +
                    "SET MSSV = '" + mssv + "', HoTen = N'" + hoten + "', NgaySinh = '" + ngaysinh + "', " +
                    "GioiTinh = N'" + gioitinh + "', MaDT = '" + madt + "', MaHuyen = '" + mahuyen + "', MaNH = '" + manh + "' " +
                    "WHERE MSSV = '" + mssv + "'";
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

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            flag = true;
            loaddataUpdate();
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
                        loaddataUpdate();
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
