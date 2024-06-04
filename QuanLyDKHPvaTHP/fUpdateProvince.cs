using QuanLyDKHPvaTHP.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDKHPvaTHP
{
    public partial class fUpdateProvince : Form
    {
        private bool flag = false;
        public fUpdateProvince(string maTinh, string tenTinh)
        {
            InitializeComponent();
            Load_TextBox(maTinh, tenTinh);
        }

        private void Load_TextBox(string maTinh, string tenTinh)
        {
            labelUpdateMaTinh.Text = maTinh;
            textBoxUpdateTinh.Text = tenTinh;
        }

        private void btn_UpdateProvince_Click(object sender, EventArgs e)
        {
            flag = true;
            UpdateNewProvince();
        }

        private void UpdateNewProvince()
        {
            if (textBoxUpdateTinh.Text == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                flag = false;
            }
            else
            {
                string TenTinh = textBoxUpdateTinh.Text;
                string MaTinh = labelUpdateMaTinh.Text;
                string query = "SELECT COUNT(*) FROM dbo.TINH WHERE TenTinh = N'" + TenTinh + "'";
                int check = (int)DataProvider.Instance.ExecuteScalar(query);
                if (check == 0)
                {
                    try
                    {
                        string updateQuery = "UPDATE TINH SET TenTinh = N'" + TenTinh + "' WHERE MaTinh = '" + MaTinh + "'";
                        int rowsAffected = DataProvider.Instance.ExecuteNonQuery(updateQuery);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void fUpdateProvince_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flag)
            {
                if (textBoxUpdateTinh.Text != "")
                {
                    string TenTinh = textBoxUpdateTinh.Text;
                    string query = "SELECT COUNT(*) FROM dbo.TINH WHERE TenTinh = N'" + TenTinh + "'";
                    int check = (int)DataProvider.Instance.ExecuteScalar(query);
                    if (check == 0)
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            UpdateNewProvince();
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