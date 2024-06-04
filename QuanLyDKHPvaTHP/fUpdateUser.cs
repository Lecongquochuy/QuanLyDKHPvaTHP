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
using System.Xml.Serialization;

namespace QuanLyDKHPvaTHP
{
    public partial class fUpdateUser : Form
    {
        private string ID;
        public fUpdateUser(string id)
        {
            InitializeComponent();
            ID = id;
            loadComboBox();
            loaddata(ID);
        }
        private void loadComboBox()
        {
            comboBoxType.Items.Add("Admin");
            comboBoxType.Items.Add("Phòng đào tạo");
            comboBoxType.Items.Add("Phòng tài vụ");
        }
        private void loaddata(string id)
        {
            string query = "SELECT DisplayName, UserName, Email, Password, Type FROM ACCOUNT WHERE Id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                txbDisplayName.Text = row["DisplayName"].ToString();
                txbUserName.Text = row["UserName"].ToString();
                txbEmail.Text = row["Email"].ToString();
                txbPassword.Text = row["Password"].ToString();
                string cbtype = row["Type"].ToString();
                if (cbtype == "0")
                    cbtype = "Admin";
                else if (cbtype == "1")
                    cbtype = "Phòng đào tạo";
                else if (cbtype == "2")
                    cbtype = "Phòng tài vụ";
                comboBoxType.Text = cbtype;
            }
            else
            {
                MessageBox.Show("Không tìm thấy user với id: " + ID);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txbDisplayName.Text == "" || txbEmail.Text == "" || txbUserName.Text == "" || txbPassword.Text == "" || comboBoxType.Text == "")
                MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string tenTK = txbDisplayName.Text;
                string email = txbEmail.Text;
                string username = txbUserName.Text;
                string pass = txbPassword.Text;
                int typeuser = 0;
                string tmp = comboBoxType.Text;
                if (tmp == "Admin")
                    typeuser = 0;
                else if (tmp == "Phòng đào tạo")
                    typeuser = 1;
                else if (tmp == "Phòng tài vụ")
                    typeuser = 2;

                string query = "UPDATE dbo.ACCOUNT " +
                    "SET DisplayName = N'" + tenTK + "', UserName ='" + username + "', Email = '" + email + "', Password = '" + pass + "', Type = " + typeuser + " " +
                    "WHERE Id = " + ID;

                try
                {
                    int rowAffect = DataProvider.Instance.ExecuteNonQuery(query);
                    if (rowAffect > 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Cập nhật dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
