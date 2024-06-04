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
    public partial class fUpdateFaculties : Form
    {
        private bool flag = false;
        public fUpdateFaculties(string maKhoa, string tenKhoa)
        {
            InitializeComponent();
            Load_TextBox(maKhoa, tenKhoa);
        }

        private void Load_TextBox(string maKhoa, string tenKhoa)
        {
            labelUpdateMaKhoa.Text = maKhoa;
            textBoxUpdateKhoa.Text = tenKhoa;
        }

        private void btn_UpdateFaculties_Click(object sender, EventArgs e)
        {
            flag = true;
            UpdateNewFaculties();
        }

        private void UpdateNewFaculties()
        {
            if (textBoxUpdateKhoa.Text == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                flag = false;
            }
            else
            {
                string TenKhoa = textBoxUpdateKhoa.Text;
                string MaKhoa = labelUpdateMaKhoa.Text;
                string query = "SELECT COUNT(*) FROM dbo.KHOA WHERE TenKhoa = N'" + TenKhoa + "'";
                int check = (int)DataProvider.Instance.ExecuteScalar(query);
                if (check == 0)
                {
                    try
                    {
                        string updateQuery = "UPDATE KHOA SET TenKhoa = N'" + TenKhoa + "' WHERE MaKhoa = '" + MaKhoa + "'";
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
                    MessageBox.Show("Đã tồn tại khoa này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flag = false;
                }
            }
        }

        private void fUpdateFaculties_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flag)
            {
                if (textBoxUpdateKhoa.Text != "")
                {
                    string TenKhoa = textBoxUpdateKhoa.Text;
                    string query = "SELECT COUNT(*) FROM dbo.KHOA WHERE TenKhoa = N'" + TenKhoa + "'";
                    int check = (int)DataProvider.Instance.ExecuteScalar(query);
                    if (check == 0)
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            UpdateNewFaculties();
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