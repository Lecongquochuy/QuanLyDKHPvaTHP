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
    public partial class fUpdatePriority : Form
    {
        private bool flag = false;
        private string MaDT;
        private string TenDTOld;
        public fUpdatePriority(string maDT, string tenDT, string tiLeGiam)
        {
            InitializeComponent();
            Load_TextBox(tenDT, tiLeGiam);
            MaDT = maDT;
            TenDTOld = tenDT;
        }

        private void Load_TextBox(string tenDT, string tiLeGiam)
        {
            textBoxUpdateDoiTuong.Text = tenDT;
            textBoxUpdateTLG.Text = tiLeGiam;
        }

        private void btn_UpdatePriority_Click(object sender, EventArgs e)
        {
            if (textBoxUpdateDoiTuong.Text == "" || textBoxUpdateTLG.Text == "")
            {
                flag = false;
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string TenDT = textBoxUpdateDoiTuong.Text;
                if (double.TryParse(textBoxUpdateTLG.Text, out double TiLeGiam))
                {
                    UpdateNewPriority(MaDT, TenDT, TiLeGiam);
                }
                else
                {
                    flag = false;
                    MessageBox.Show("Tỉ lệ giảm phải là một số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void UpdateNewPriority(string maDT, string tenDT, double tiLeGiam)
        {
            string query = "SELECT COUNT(*) FROM dbo.DTUUTIEN WHERE TenDT = N'" + tenDT + "'";
            int check = (int)DataProvider.Instance.ExecuteScalar(query);
            if (check == 0 || TenDTOld == tenDT)
            {
                try
                {
                    string updateQuery = "UPDATE DTUUTIEN SET TenDT = N'" + tenDT + "', TiLeGiam = " + tiLeGiam + " WHERE MaDT = '" + maDT + "'";
                    int rowsAffected = DataProvider.Instance.ExecuteNonQuery(updateQuery);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                    {
                        flag = false;
                        MessageBox.Show("Có lỗi xảy ra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    flag = false;
                    MessageBox.Show(ex.Message.Split('\n')[0], "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                flag = false;
                MessageBox.Show("Đã tồn tại đối tượng ưu tiên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void fAddPriority_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flag)
            {
                if (textBoxUpdateDoiTuong.Text != "" && textBoxUpdateTLG.Text != "")
                {
                    string tenDT = textBoxUpdateDoiTuong.Text;
                    if (double.TryParse(textBoxUpdateTLG.Text, out double tiLeGiam))
                    {
                        string query = "SELECT COUNT(*) FROM dbo.DTUUTIEN WHERE TenDT = N'" + tenDT + "'";
                        int check = (int)DataProvider.Instance.ExecuteScalar(query);
                        if (check == 0)
                        {
                            DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                UpdateNewPriority(MaDT, tenDT, tiLeGiam);
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
}
