using PdfSharp.Snippets.Drawing;
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
    public partial class fAddUser : Form
    {
        public fAddUser()
        {
            InitializeComponent();
            loadComboBox();
            loaddquery();
        }
        private void loadComboBox()
        {
            comboBoxType.Items.Add("Admin");
            comboBoxType.Items.Add("Phòng đào tạo");
            comboBoxType.Items.Add("Phòng tài vụ");
        }
        int id;
        public void loaddquery()
        {
            string getMaxMSSVQuery = "SELECT MAX(Id) FROM dbo.ACCOUNT";
            int result = (int)DataProvider.Instance.ExecuteScalar(getMaxMSSVQuery);
            id = result + 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
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

                string query = "INSERT INTO ACCOUNT (Id, DisplayName, UserName, Email, Password, Type) " +
                    "VALUES ( " + id + ", N'" + tenTK + "', '" + username + "', '" + email + "', '" + pass + "', " + typeuser + " )";

                try
                {
                    int rowAffect = DataProvider.Instance.ExecuteNonQuery(query);
                    if (rowAffect > 0)
                    {
                        MessageBox.Show("Lưu dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Lưu dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
