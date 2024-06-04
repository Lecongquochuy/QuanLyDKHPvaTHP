using Microsoft.Web.WebView2.Core;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyDKHPvaTHP
{
    public partial class fProfile : Form
    {
        private string displayname;
        private string username;
        private string email;
        private string password;
        public event EventHandler SaveNameRequested;
        QuanLyDKHPvaThuHP HomePage;
        public fProfile(QuanLyDKHPvaThuHP homePage)
        {
            InitializeComponent();
            HomePage = homePage;
            LoadData(HomePage.ID);
            loadDataUser();
            Authorization(HomePage.ID);
        }
        private void Authorization(int id)
        {
            string query = "SELECT Type FROM dbo.ACCOUNT WHERE Id = " + id;
            int role = (int)DataProvider.Instance.ExecuteScalar(query);
            if (role == 2 || role == 1)
            {
                dataGridView1.Visible = false;
                btnAddUser.Visible = false;
                lbAccount.Visible = false;
            }
        }

        private void loadDataUser()
        {
            string query = "SELECT Id, DisplayName, Type FROM ACCOUNT";
            //dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery(query);


            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            dataTable.Columns.Add("NewType", typeof(string));
            foreach (DataRow row in dataTable.Rows)
            {
                if (Convert.ToInt32(row["Type"]) == 0)
                {
                    row["NewType"] = "Admin";
                }
                if (Convert.ToInt32(row["Type"]) == 1)
                {
                    row["NewType"] = "Phòng đào tạo";
                }
                if (Convert.ToInt32(row["Type"]) == 2)
                {
                    row["NewType"] = "Phòng tài vụ";
                }
            }
            dataTable.Columns.Remove("Type");
            dataTable.Columns["NewType"].ColumnName = "Type";
            //dataTable.Columns["STT"].SetOrdinal(0);
            //dataTable.Columns["HocKy"].SetOrdinal(1);
            //dataTable.Columns["NamHoc"].SetOrdinal(2);
            dataGridView1.DataSource = dataTable;


        }
        private void LoadData(int id)
        {
            string query = "SELECT DisplayName, UserName, Email, Password FROM ACCOUNT WHERE Id = " + id;
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            displayname = dataTable.Rows[0][0].ToString();
            username = dataTable.Rows[0][1].ToString();
            email = dataTable.Rows[0][2].ToString();
            password = dataTable.Rows[0][3].ToString();
            lbDisplayName.Text = displayname;
            txbDisplayName.Text = displayname;
            txbUserName.Text = username;
            txbEmail.Text = email;
            txbPassword.Text = password;
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            HomePage.loadForm(new fDashboard());
            this.Hide();
        }

        private void pbShowPassword_Click(object sender, EventArgs e)
        {
            bool check = txbPassword.UseSystemPasswordChar;
            if (check == true) txbPassword.UseSystemPasswordChar = false;
            else txbPassword.UseSystemPasswordChar = true;
        }

        private void txb_TextChange(object sender, EventArgs e)
        {
            LoadbtnSave();
        }

        private void LoadbtnSave()
        {
            if (txbDisplayName.Text != displayname || txbUserName.Text != username || txbEmail.Text != email || txbPassword.Text != password)
                btnSave.BackColor = Color.LimeGreen;
            else
                btnSave.BackColor = Color.Silver;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.BackColor == Color.LimeGreen)
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn lưu chứ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query = "UPDATE ACCOUNT SET DisplayName = N'" + txbDisplayName.Text + "', " +
                    "UserName = '" + txbUserName.Text + "', Email = '" + txbEmail.Text + "', " +
                    "Password = '" + txbPassword.Text + "' WHERE Id = " + HomePage.ID;
                    int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query);
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Có lỗi xảy ra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        LoadData(HomePage.ID);
                        HomePage.loadUser(HomePage.ID);
                        loadDataUser();
                        LoadbtnSave();
                    }
                }
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage.Close();
        }

        private void btnUpdateP_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    pBUserP.Image = new System.Drawing.Bitmap(filePath);
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            fAddUser f = new fAddUser();
            f.ShowDialog();
            loadDataUser();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            DataGridViewColumn column = new DataGridViewColumn();
            column = dataGridView1.Columns[e.ColumnIndex];

            switch (Convert.ToString(column.Name))
            {
                case "Update":
                    row = dataGridView1.Rows[e.RowIndex];
                    fUpdateUser updateuser = new fUpdateUser(Convert.ToString(row.Cells["Id"].Value));
                    updateuser.ShowDialog();
                    loadDataUser();
                    break;
                case "Delete":
                    row = dataGridView1.Rows[e.RowIndex];
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        //MessageBox.Show(int.Parse(Convert.ToString(row.Cells["Id"].Value)) + "");
                        try
                        {
                            row = dataGridView1.Rows[e.RowIndex];
                            int id = int.Parse(Convert.ToString(row.Cells["Id"].Value));
                            
                            string query = "DELETE FROM dbo.ACCOUNT " +
                                "WHERE Id = " + id;
                            int rowAffect = DataProvider.Instance.ExecuteNonQuery(query);
                            if (rowAffect == 0)
                            {
                                MessageBox.Show("Xóa dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        loadDataUser();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}