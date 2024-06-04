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
    public partial class fAddSubjectType : Form
    {
        string newMaLoaiMon;
        public fAddSubjectType()
        {
            InitializeComponent();
            string getMaxMaLMQuery = "SELECT MAX(MaLoaiMon) FROM dbo.LOAIMON";
            object result = DataProvider.Instance.ExecuteScalar(getMaxMaLMQuery);
            newMaLoaiMon = GenerateNewMaLoaiMon(result?.ToString());
            txtBoxMaLoaiMon.Text = newMaLoaiMon;
        }
        private void saveForm()
        {
            if (txtBoxMaLoaiMon.Text == "" || txtBoxSoTienMotTC.Text == "" || txtBoxSoTietMotTC.Text == "" || txtBoxTenLoaiMon.Text == "")
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string tenLM = txtBoxTenLoaiMon.Text;
                if (int.TryParse(txtBoxSoTietMotTC.Text, out int SoTietMotTC))
                {
                    //AddNewSubjectType(tenLM, SoTietMotTC);
                    if (int.TryParse(txtBoxSoTienMotTC.Text, out int SoTienMotTC))
                    {
                        AddNewSubjectType(tenLM, SoTietMotTC, SoTienMotTC);
                    }
                    else
                    {
                        MessageBox.Show("Số tiền một tín chỉ là một số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Số tiết một phải là một số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btn_AddSubjectType_Click(object sender, EventArgs e)
        {
            saveForm();
        }

        private void AddNewSubjectType(string tenloaimon, int sotietmottc, int sotienmottc)
        {
            string query = "SELECT COUNT(*) FROM dbo.LOAIMON WHERE TenLoaiMon = N'" + tenloaimon + "'";
            int check = (int)DataProvider.Instance.ExecuteScalar(query);
            if (check == 0)
            {
                try
                {
                    string insertQuery = "INSERT INTO LOAIMON(MaLoaiMon, TenLoaiMon, SoTietMotTC, SoTienMotTC) " +
                        "VALUES ('" + newMaLoaiMon + "', N'" + tenloaimon + "', " + sotietmottc + ", " + sotienmottc + ")";
                    int rowsAffected = DataProvider.Instance.ExecuteNonQuery(insertQuery);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message.Split('\n')[0], "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Đã tồn tại loại môn này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GenerateNewMaLoaiMon(string currentMaxMaLM)
        {
            if (string.IsNullOrEmpty(currentMaxMaLM))
            {
                return "LM1";
            }

            int currentNumber = int.Parse(currentMaxMaLM.Substring(2));
            int newNumber = currentNumber + 1;
            return $"LM{newNumber:D1}";
        }

        private void fAddSubjectType_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtBoxMaLoaiMon.Text != "" && txtBoxSoTienMotTC.Text != "" && txtBoxSoTietMotTC.Text != "" && txtBoxTenLoaiMon.Text != "")
            {
                string tenLM = txtBoxTenLoaiMon.Text;
                if (int.TryParse(txtBoxSoTietMotTC.Text, out int SoTietMotTC))
                {
                    if (int.TryParse(txtBoxSoTienMotTC.Text, out int SoTienMotTC))
                    {
                        string query = "SELECT COUNT(*) FROM dbo.LOAIMON WHERE TenLoaiMon = N'" + tenLM + "'";
                        int check = (int)DataProvider.Instance.ExecuteScalar(query);
                        if (check == 0)
                        {
                            try
                            {
                                DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    string insertQuery = "INSERT INTO LOAIMON(MaLoaiMon, TenLoaiMon, SoTietMotTC, SoTienMotTC) " +
                                        "VALUES ('" + newMaLoaiMon + "', N'" + tenLM + "', " + SoTietMotTC + ", " + SoTienMotTC + ")";
                                    int rowsAffected = DataProvider.Instance.ExecuteNonQuery(insertQuery);

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else if (result == DialogResult.Cancel)
                                {
                                    e.Cancel = true;
                                }
                                
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.Message.Split('\n')[0], "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }              
        }
    }
}
