using QuanLyDKHPvaTHP.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyDKHPvaTHP
{
    public partial class fUpdateSemesterSchoolYear : Form
    {
        private string MaHKNH;
        public fUpdateSemesterSchoolYear(string maHKNH)
        {
            InitializeComponent();
            MaHKNH = maHKNH;
            LoadData(MaHKNH);
        }
        private void LoadData(string mahknh)
        {
            string query = "SELECT NamHoc, HocKy, FORMAT(ThoiHanDongHocPhi, 'dd/MM/yyyy') FROM dbo.HOCKY_NAMHOC WHERE MaHKNH = '" + mahknh + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            lbUpdateNamHoc.Text = dt.Rows[0][0].ToString();
            lbUpdateHocKy.Text = dt.Rows[0][1].ToString();
            dTPickerUpdateTHDHP.Value = DateTime.ParseExact(dt.Rows[0][2].ToString().Split(" ")[0], "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        private void btn_UpdateSSY_Click(object sender, EventArgs e)
        {
            DateTime THDHP = dTPickerUpdateTHDHP.Value;
            AddUpdateSSY(THDHP);
        }

        private void AddUpdateSSY(DateTime THDHP)
        {
            try
            {
                string updateQuery = "UPDATE HOCKY_NAMHOC SET ThoiHanDongHocPhi = '" + THDHP + "' WHERE MaHKNH = '" + MaHKNH + "'";
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
