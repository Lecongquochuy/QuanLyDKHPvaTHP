using QuanLyDKHPvaTHP.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyDKHPvaTHP
{
    public partial class fAddSemesterSchoolYear : Form
    {
        public fAddSemesterSchoolYear()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            int lastYear = DateTime.Now.Year - 1;
            for (int i = 0; i < 5; i++)
            {
                cbBoxAddNamHoc.Items.Add((lastYear + i).ToString() + "-" + (lastYear + i + 1).ToString());
            }
            cbBoxAddHocKy.Items.Add("Học kỳ 1");
            cbBoxAddHocKy.Items.Add("Học kỳ 2");
            cbBoxAddHocKy.Items.Add("Học kỳ hè");
        }

        private void btn_AddSSY_Click(object sender, EventArgs e)
        {
            if (cbBoxAddHocKy.Text == "" || cbBoxAddNamHoc.Text == "")
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int hocKy = 0;
                switch (cbBoxAddHocKy.Text)
                {
                    case "Học kỳ 1":
                        hocKy = 1;
                        break;
                    case "Học kỳ 2":
                        hocKy = 2;
                        break;
                    case "Học kỳ hè":
                        hocKy = 3;
                        break;
                    default:
                        break;
                }
                int namHoc = int.Parse(cbBoxAddNamHoc.Text.Split('-')[0]);
                DateTime THDHP = dTPickerAddTHDHP.Value;
                AddNewSSY(hocKy, namHoc, THDHP);
            }

        }

        private void AddNewSSY(int hocKy, int namHoc, DateTime THDHP)
        {
            try
            {
                string maHKNH = namHoc.ToString().Substring(2, 2) + "0" + hocKy;
                string insertQuery = "INSERT INTO HOCKY_NAMHOC(MaHKNH, NamHoc, HocKy, ThoiHanDongHocPhi) VALUES ('" + maHKNH + "', " + namHoc + ", " + hocKy + ", '" + THDHP + "')";
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
            catch (Exception ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Đã có học kỳ - năm học này trong cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ex.Message.Split('\n')[0], "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
