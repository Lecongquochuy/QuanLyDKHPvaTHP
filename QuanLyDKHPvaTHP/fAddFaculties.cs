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
    public partial class fAddFaculties : Form
    {
        private bool flag = false;
        public fAddFaculties()
        {
            InitializeComponent();
            Load_Data();
        }

        private void Load_Data()
        {
            string getMaxMaKhoaQuery = "SELECT MAX(MaKhoa) FROM dbo.KHOA";
            object result = DataProvider.Instance.ExecuteScalar(getMaxMaKhoaQuery);
            string newMaKhoa = GenerateNewMaKhoa(result?.ToString());
            labelAddMaKhoa.Text = newMaKhoa;
        }
        private void btn_AddFaculties_Click(object sender, EventArgs e)
        {
            flag = true;
            AddNewFaculties();
        }

        private void AddNewFaculties()
        {
            if (textBoxAddKhoa.Text == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                flag = false;
            }
            else
            {
                string tenKhoa = textBoxAddKhoa.Text;
                string maKhoa = labelAddMaKhoa.Text;
                string query = "SELECT COUNT(*) FROM dbo.KHOA WHERE tenKhoa = N'" + tenKhoa + "'";
                int check = (int)DataProvider.Instance.ExecuteScalar(query);
                if (check == 0)
                {
                    try
                    {
                        string insertQuery = "INSERT INTO KHOA(maKhoa, tenKhoa) VALUES ('" + maKhoa + "', N'" + tenKhoa + "')";
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
                    MessageBox.Show("Đã tồn tại khoa này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flag = false;
                }
            }
        }

        private string GenerateNewMaKhoa(string currentMaxmaKhoa)
        {
            if (string.IsNullOrEmpty(currentMaxmaKhoa))
            {
                return "K01";
            }

            int currentNumber = int.Parse(currentMaxmaKhoa.Substring(1));
            int newNumber = currentNumber + 1;
            return $"K{newNumber:D2}";
        }

        private void fAddFaculties_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flag)
            {
                if (textBoxAddKhoa.Text != "")
                {
                    string tenKhoa = textBoxAddKhoa.Text;
                    string query = "SELECT COUNT(*) FROM dbo.KHOA WHERE tenKhoa = N'" + tenKhoa + "'";
                    int check = (int)DataProvider.Instance.ExecuteScalar(query);
                    if (check == 0)
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            AddNewFaculties();
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