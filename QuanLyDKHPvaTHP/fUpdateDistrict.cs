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
    public partial class fUpdateDistrict : Form
    {
        private bool flag = false;
        private string OldtenHuyen;
        public fUpdateDistrict(string maHuyen, string tenHuyen, string tenTinh, string vsvx)
        {
            InitializeComponent();
            OldtenHuyen = tenHuyen;
            Load_Data(maHuyen, tenHuyen, tenTinh, vsvx);
        }

        private void Load_Data(string maHuyen, string tenHuyen, string tenTinh, string vsvx)
        {
            labelUpdateMaHuyen.Text = maHuyen;
            textBoxUpdateHuyen.Text = tenHuyen;
            labelUpdateTinh.Text = tenTinh;
            ckBoxUpdateVSVX.Checked = int.Parse(vsvx) == 1;
        }

        private void btn_UpdateDistrict_Click(object sender, EventArgs e)
        {
            flag = true;
            UpdateNewDistrict();
        }

        private void UpdateNewDistrict()
        {
            if (textBoxUpdateHuyen.Text == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                flag = false;
            }
            else
            {
                string TenTinh = labelUpdateTinh.Text;
                string MaHuyen = labelUpdateMaHuyen.Text;
                string TenHuyen = textBoxUpdateHuyen.Text;
                string VSVX = (ckBoxUpdateVSVX.Checked ? 1 : 0).ToString();
                string query = "SELECT COUNT(*) FROM dbo.HUYEN JOIN dbo.TINH ON HUYEN.MaTinh = TINH.MaTinh " +
                "WHERE HUYEN.TenHuyen = N'" + TenHuyen + "' AND TINH.TenTinh = N'" + TenTinh + "'";
                int check = (int)DataProvider.Instance.ExecuteScalar(query);
                if ((check == 0 && TenHuyen != OldtenHuyen) || (TenHuyen == OldtenHuyen))
                {
                    try
                    {
                        string updateQuery = "UPDATE HUYEN SET TenHuyen = N'" + TenHuyen + "', VungSauVungXa = " + VSVX + " WHERE MaHuyen = '" + MaHuyen + "'";
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
                        flag = false;
                        MessageBox.Show(ex.Message.Split('\n')[0], "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Đã tồn tại tên huyện " + TenHuyen + " trong tỉnh này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flag = false;
                }
            }
        }

        private void fUpdateDistrict_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flag)
            {
                if (textBoxUpdateHuyen.Text != "")
                {
                    string TenTinh = labelUpdateTinh.Text;
                    string TenHuyen = textBoxUpdateHuyen.Text;
                    string query = "SELECT COUNT(*) FROM dbo.HUYEN JOIN dbo.TINH ON HUYEN.MaTinh = TINH.MaTinh " +
                    "WHERE HUYEN.TenHuyen = N'" + TenHuyen + "' AND TINH.TenTinh = N'" + TenTinh + "'";
                    int check = (int)DataProvider.Instance.ExecuteScalar(query);
                    if ((check == 0 && TenHuyen != OldtenHuyen) || (TenHuyen == OldtenHuyen))
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            UpdateNewDistrict();
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