using QuanLyDKHPvaTHP;
using QuanLyDKHPvaTHP.DAO;

namespace QuanLyDKHP_THP
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassword.Text;
            if (Login(userName, passWord))
            {
                string query = "SELECT ID FROM ACCOUNT WHERE UserName = '" + userName + "' and Password = '" + passWord + "'";
                int id = (int)DataProvider.Instance.ExecuteScalar(query);
                this.Hide();
                txbUserName.Text = "";
                txbPassword.Text = "";
                QuanLyDKHPvaThuHP QL = new QuanLyDKHPvaThuHP(id);
                QL.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }
    }
}
