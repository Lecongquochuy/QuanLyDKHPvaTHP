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
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyDKHPvaTHP
{
    public partial class fUpdateSubjectType : Form
    {
        private string MaLoaiMon;
        public fUpdateSubjectType(string maloaimon, string tenloaimon, string sotietmottc, string sotienmottc)
        {
            InitializeComponent();
            MaLoaiMon = maloaimon;
            sotienmottc = sotienmottc.Replace(".", "");
            Load_TextBox(MaLoaiMon, tenloaimon, sotietmottc, sotienmottc);

        }

        private void Load_TextBox(string maloaimon, string tenloaimon, string sotietmottc, string sotienmottc)
        {

            txtBoxMaLoaiMon.Text = maloaimon;
            txtBoxTenLoaiMon.Text = tenloaimon;
            txtBoxSoTietMotTC.Text = sotietmottc;
            txtBoxSoTienMotTC.Text = sotienmottc;
        }

        private void btn_UpdateSubjectType_Click(object sender, EventArgs e)
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
                        UpdateNewSubjectType(MaLoaiMon, tenLM, SoTietMotTC, SoTienMotTC);
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

        private void UpdateNewSubjectType(string maloaimon, string tenloaimon, int sotietmottc, int sotienmottc)
        {
            //string query = "SELECT COUNT(*) FROM dbo.LOAIMON WHERE TenLoaiMon = N'" + tenloaimon + "'";
            //int check = (int)DataProvider.Instance.ExecuteScalar(query);
            //if (check == 0)
            //{
                try
                {
                    string updateQuery = "UPDATE LOAIMON SET MaLoaiMon = '" + maloaimon + "', TenLoaiMon = N'" + tenloaimon + "', SoTietMotTC = " + sotietmottc + ", SoTienMotTC = " + sotienmottc + " WHERE MaLoaiMon = '" + maloaimon + "' ";
                    int rowsAffected = DataProvider.Instance.ExecuteNonQuery(updateQuery);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.Split('\n')[0], "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            //}
            //else
            //{
            //    MessageBox.Show("Đã tồn tại đối tượng ưu tiên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

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
                        try
                        {
                            string updateQuery = "UPDATE LOAIMON SET MaLoaiMon = '" + txtBoxMaLoaiMon.Text + "', TenLoaiMon = N'" + tenLM + "', SoTietMotTC = " + SoTietMotTC + ", SoTienMotTC = " + SoTienMotTC + " WHERE MaLoaiMon = '" + txtBoxMaLoaiMon.Text + "' ";
                            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(updateQuery);

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Có lỗi xảy ra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.Split('\n')[0], "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}
