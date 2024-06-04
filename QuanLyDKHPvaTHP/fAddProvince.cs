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
    public partial class fAddProvince : Form
    {
        private bool flag = false;
        public fAddProvince()
        {
            InitializeComponent();
            Load_Data();
        }

        private void Load_Data()
        {
            string getMaxMaTinhQuery = "SELECT MAX(MaTinh) FROM dbo.TINH";
            object result = DataProvider.Instance.ExecuteScalar(getMaxMaTinhQuery);
            string newMaTinh = GenerateNewMaTinh(result?.ToString());
            labelAddMaTinh.Text = newMaTinh;
        }
        private void btn_AddProvince_Click(object sender, EventArgs e)
        {
            flag = true;
            AddNewProvince();
        }

        private void AddNewProvince()
        {
            if (textBoxAddTinh.Text == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                flag = false;
            }
            else
            {
                string tenTinh = textBoxAddTinh.Text;
                string maTinh = labelAddMaTinh.Text;
                string query = "SELECT COUNT(*) FROM dbo.TINH WHERE TenTinh = N'" + tenTinh + "'";
                int check = (int)DataProvider.Instance.ExecuteScalar(query);
                if (check == 0)
                {
                    try
                    {
                        string insertQuery = "INSERT INTO TINH(MaTinh, TenTinh) VALUES ('" + maTinh + "', N'" + tenTinh + "')";
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
                    MessageBox.Show("Đã tồn tại tỉnh này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flag = false;
                }
            }
        }

        private string GenerateNewMaTinh(string currentMaxMaTinh)
        {
            if (string.IsNullOrEmpty(currentMaxMaTinh))
            {
                return "T01";
            }

            int currentNumber = int.Parse(currentMaxMaTinh.Substring(1));
            int newNumber = currentNumber + 1;
            return $"T{newNumber:D2}";
        }

        private void fAddProvince_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flag)
            {
                if (textBoxAddTinh.Text != "")
                {
                    string tenTinh = textBoxAddTinh.Text;
                    string query = "SELECT COUNT(*) FROM dbo.TINH WHERE TenTinh = N'" + tenTinh + "'";
                    int check = (int)DataProvider.Instance.ExecuteScalar(query);
                    if (check == 0)
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            AddNewProvince();
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