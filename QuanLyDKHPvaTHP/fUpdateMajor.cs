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
    public partial class fUpdateMajor : Form
    {
        private bool flag = false;
        private string OldtenNH;
        public fUpdateMajor(string maNH, string tenNH, string tenKhoa)
        {
            InitializeComponent();
            OldtenNH = tenNH;
            Load_Data(maNH, tenNH, tenKhoa);
        }

        private void Load_Data(string maNH, string tenNH, string tenKhoa)
        {
            labelUpdateMaNganh.Text = maNH;
            textBoxUpdateNganh.Text = tenNH;
            labelUpdateKhoa.Text = tenKhoa;
        }

        private void btn_UpdateMajor_Click(object sender, EventArgs e)
        {
            flag = true;
            UpdateNewMajor();
        }

        private void UpdateNewMajor()
        {
            if (textBoxUpdateNganh.Text == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                flag = false;
            }
            else
            {
                string tenKhoa = labelUpdateKhoa.Text;
                string maNH = labelUpdateMaNganh.Text;
                string tenNH = textBoxUpdateNganh.Text;
                string query = "SELECT COUNT(*) FROM dbo.NGANHHOC JOIN dbo.KHOA ON NGANHHOC.maKhoa = KHOA.maKhoa " +
                "WHERE NGANHHOC.tenNH = N'" + tenNH + "' AND KHOA.tenKhoa = N'" + tenKhoa + "'";
                int check = (int)DataProvider.Instance.ExecuteScalar(query);
                if ((check == 0 && tenNH != OldtenNH) || (tenNH == OldtenNH))
                {
                    try
                    {
                        string updateQuery = "UPDATE NGANHHOC SET tenNH = N'" + tenNH + "' WHERE maNH = '" + maNH + "'";
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
                    MessageBox.Show("Đã tồn tại tên ngành " + tenNH + " trong khoa này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flag = false;
                }
            }
        }

        private void fUpdateMajor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flag)
            {
                if (textBoxUpdateNganh.Text != "")
                {
                    string tenKhoa = labelUpdateKhoa.Text;
                    string tenNH = textBoxUpdateNganh.Text;
                    string query = "SELECT COUNT(*) FROM dbo.NGANHHOC JOIN dbo.KHOA ON NGANHHOC.maKhoa = KHOA.maKhoa " +
                    "WHERE NGANHHOC.tenNH = N'" + tenNH + "' AND KHOA.tenKhoa = N'" + tenKhoa + "'";
                    int check = (int)DataProvider.Instance.ExecuteScalar(query);
                    if ((check == 0 && tenNH != OldtenNH) || (tenNH == OldtenNH))
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            UpdateNewMajor();
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