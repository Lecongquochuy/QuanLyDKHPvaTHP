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
    public partial class fAddMajor : Form
    {
        private bool flag = false;
        public fAddMajor()
        {
            InitializeComponent();
            Load_ComboBox();
            Load_Data();
        }

        private void Load_ComboBox()
        {
            string getTenKhoaQuery = "SELECT MaKhoa, TenKhoa FROM dbo.KHOA";
            DataTable data = DataProvider.Instance.ExecuteQuery(getTenKhoaQuery);
            cbBoxAddKhoa.DataSource = data;
            cbBoxAddKhoa.DisplayMember = "TenKhoa";
            cbBoxAddKhoa.ValueMember = "MaKhoa";
        }

        private void Load_Data()
        {
            string MaKhoa = cbBoxAddKhoa.SelectedValue.ToString();
            string getMaxMaNHQuery = "SELECT MAX(MaNH) FROM dbo.NGANHHOC WHERE MaKhoa = '" + MaKhoa + "'";
            object result = DataProvider.Instance.ExecuteScalar(getMaxMaNHQuery);
            string newMaNH = GenerateNewMaNH(MaKhoa, result?.ToString());
            labelAddMaNganh.Text = newMaNH;
        }

        private void cbBoxAddTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btn_AddMajor_Click(object sender, EventArgs e)
        {
            flag = true;
            AddNewMajor();
        }

        private void AddNewMajor()
        {
            if (textBoxAddNganh.Text == "" || cbBoxAddKhoa.Text == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                flag = false;
            }
            else
            {
                string TenNH = textBoxAddNganh.Text;
                string MaNH = labelAddMaNganh.Text;
                string MaKhoa = cbBoxAddKhoa.SelectedValue.ToString();
                string query = "SELECT COUNT(*) FROM dbo.NGANHHOC WHERE TenNH = N'" + TenNH + "' AND MaKhoa = '" + MaKhoa + "'";
                int check = (int)DataProvider.Instance.ExecuteScalar(query);
                if (check == 0)
                {
                    try
                    {
                        string insertQuery = "INSERT INTO NGANHHOC(MaNH, TenNH, MaKhoa) VALUES ('" + MaNH + "', N'" + TenNH + "', '" + MaKhoa + "')";
                        int rowsAffected = DataProvider.Instance.ExecuteNonQuery(insertQuery);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            flag = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.Split('\n')[0], "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flag = false;
                    }
                }
                else
                {
                    MessageBox.Show("Đã tồn tại tên ngành " + TenNH + " trong khoa này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flag = false;
                }
            }
        }

        private string GenerateNewMaNH(string MaKhoa, string currentMaxMaNH)
        {
            if (string.IsNullOrEmpty(currentMaxMaNH))
            {
                return MaKhoa + "N01";
            }
            string MaNH = currentMaxMaNH.Substring(3, 3);
            int currentNumber = int.Parse(MaNH.Substring(1));
            int newNumber = currentNumber + 1;
            return MaKhoa + $"N{newNumber:D2}";
        }

        private void fAddMajor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flag)
            {
                if (textBoxAddNganh.Text != "" && cbBoxAddKhoa.Text != "")
                {
                    string TenNH = textBoxAddNganh.Text;
                    string MaKhoa = cbBoxAddKhoa.SelectedValue.ToString();
                    string query = "SELECT COUNT(*) FROM dbo.NGANHHOC WHERE TenNH = N'" + TenNH + "' AND MaKhoa = '" + MaKhoa + "'";
                    int check = (int)DataProvider.Instance.ExecuteScalar(query);
                    if (check == 0)
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            AddNewMajor();
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
}