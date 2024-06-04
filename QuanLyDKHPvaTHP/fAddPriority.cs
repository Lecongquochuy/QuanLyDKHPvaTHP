using QuanLyDKHPvaTHP.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDKHPvaTHP
{
    public partial class fAddPriority : Form
    {
        private bool flag = false;
        public fAddPriority()
        {
            InitializeComponent();
        }

        private void btn_AddPriority_Click(object sender, EventArgs e)
        {
            flag = true;
            if (textBoxAddDoiTuong.Text == "" || textBoxAddTLG.Text == "")
            {
                flag = false;
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string tenDT = textBoxAddDoiTuong.Text;
                if (double.TryParse(textBoxAddTLG.Text, out double tiLeGiam))
                {
                    AddNewPriority(tenDT, tiLeGiam);
                }
                else
                {
                    flag = false;
                    MessageBox.Show("Tỉ lệ giảm phải là một số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AddNewPriority(string tenDT, double tiLeGiam)
        {
            string query = "SELECT COUNT(*) FROM dbo.DTUUTIEN WHERE TenDT = N'" + tenDT + "'";
            int check = (int)DataProvider.Instance.ExecuteScalar(query);
            if (check == 0)
            {
                try
                {
                    string getMaxMaDTQuery = "SELECT MAX(MaDT) FROM dbo.DTUUTIEN";
                    object result = DataProvider.Instance.ExecuteScalar(getMaxMaDTQuery);
                    string newMaDT = GenerateNewMaDT(result?.ToString());

                    string insertQuery = "INSERT INTO DTUUTIEN(MaDT, TenDT, TiLeGiam) VALUES ('" + newMaDT + "', N'" + tenDT + "', " + tiLeGiam + ")";
                    int rowsAffected = DataProvider.Instance.ExecuteNonQuery(insertQuery);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                    {
                        flag = false;
                        MessageBox.Show("Có lỗi xảy ra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException ex)
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

        private string GenerateNewMaDT(string currentMaxMaDT)
        {
            if (string.IsNullOrEmpty(currentMaxMaDT))
            {
                return "DT001";
            }

            int currentNumber = int.Parse(currentMaxMaDT.Substring(2));
            int newNumber = currentNumber + 1;
            return $"DT{newNumber:D3}";
        }

        private void fAddPriority_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flag)
            {
                if (textBoxAddDoiTuong.Text != "" && textBoxAddTLG.Text != "")
                {
                    string tenDT = textBoxAddDoiTuong.Text;
                    if (double.TryParse(textBoxAddTLG.Text, out double tiLeGiam))
                    {
                        string query = "SELECT COUNT(*) FROM dbo.DTUUTIEN WHERE TenDT = N'" + tenDT + "'";
                        int check = (int)DataProvider.Instance.ExecuteScalar(query);
                        if (check == 0)
                        {
                            DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                AddNewPriority(tenDT, tiLeGiam);
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
