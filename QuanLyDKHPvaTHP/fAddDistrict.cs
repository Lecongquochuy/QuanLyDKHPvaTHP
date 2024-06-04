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

namespace QuanLyDKHPvaTHP
{
    public partial class fAddDistrict : Form
    {
        private bool flag = false;
        public fAddDistrict()
        {
            InitializeComponent();
            Load_ComboBox();
            Load_Data();
        }

        private void Load_ComboBox()
        {
            string getTenTinhQuery = "SELECT MaTinh, TenTinh FROM dbo.TINH";
            DataTable data = DataProvider.Instance.ExecuteQuery(getTenTinhQuery);
            cbBoxAddTinh.DataSource = data;
            cbBoxAddTinh.DisplayMember = "TenTinh";
            cbBoxAddTinh.ValueMember = "MaTinh";
        }

        private void Load_Data()
        {
            string MaTinh = cbBoxAddTinh.SelectedValue.ToString();
            string getMaxMaHuyenQuery = "SELECT MAX(MaHUYEN) FROM dbo.HUYEN WHERE MaTinh = '" + MaTinh + "'";
            object result = DataProvider.Instance.ExecuteScalar(getMaxMaHuyenQuery);
            string newMaHuyen = GenerateNewMaHuyen(MaTinh, result?.ToString());
            labelAddMaHuyen.Text = newMaHuyen;
        }

        private void cbBoxAddTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btn_AddDistrict_Click(object sender, EventArgs e)
        {
            flag = true;
            AddNewDistrict();
        }

        private void AddNewDistrict()
        {
            if (textBoxAddHuyen.Text == "" || cbBoxAddTinh.Text == "")
            {
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                flag = false;
            }
            else
            {
                string tenHuyen = textBoxAddHuyen.Text;
                string maHuyen = labelAddMaHuyen.Text;
                string maTinh = cbBoxAddTinh.SelectedValue.ToString();
                string vsvx = (ckBoxAddVSVX.Checked ? 1 : 0).ToString();
                string query = "SELECT COUNT(*) FROM dbo.HUYEN WHERE TenHuyen = N'" + tenHuyen + "' AND MaTinh = '" + maTinh + "'";
                int check = (int)DataProvider.Instance.ExecuteScalar(query);
                if (check == 0)
                {
                    try
                    {
                        string insertQuery = "INSERT INTO HUYEN(MaHuyen, TenHuyen, MaTinh, VungSauVungXa) VALUES ('" + maHuyen + "', N'" + tenHuyen + "', '" + maTinh + "', " + vsvx + ")";
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
                    MessageBox.Show("Đã tồn tại tên huyện " + tenHuyen + " trong tỉnh này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flag = false;
                }
            }
        }

        private string GenerateNewMaHuyen(string MaTinh, string currentMaxMaHuyen)
        {
            if (string.IsNullOrEmpty(currentMaxMaHuyen))
            {
                return MaTinh + "H01";
            }
            string MaHuyen = currentMaxMaHuyen.Substring(3, 3);
            int currentNumber = int.Parse(MaHuyen.Substring(1));
            int newNumber = currentNumber + 1;
            return MaTinh + $"H{newNumber:D2}";
        }

        private void fAddDistrict_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flag)
            {
                if (textBoxAddHuyen.Text != "" && cbBoxAddTinh.Text != "")
                {
                    string tenHuyen = textBoxAddHuyen.Text;
                    string maTinh = cbBoxAddTinh.SelectedValue.ToString();
                    string query = "SELECT COUNT(*) FROM dbo.HUYEN WHERE TenHuyen = N'" + tenHuyen + "' AND MaTinh = '" + maTinh + "'";
                    int check = (int)DataProvider.Instance.ExecuteScalar(query);
                    if (check == 0)
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            AddNewDistrict();
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