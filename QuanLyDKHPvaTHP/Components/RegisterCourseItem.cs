using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDKHPvaTHP.Components
{
    public partial class RegisterCourseItem : UserControl
    {
        public RegisterCourseItem()
        {
            InitializeComponent();
        }
        public string Number { get => lRegisterCourseNumder.Text; set => lRegisterCourseNumder.Text = value; }
        public string MaPhieu { get => lRegisterCourseMaPhieu.Text; set => lRegisterCourseMaPhieu.Text = value; }
        public string MSSV { get => lRegisterCourseMSSV.Text; set => lRegisterCourseMSSV.Text = value; }
        public string NamHoc { get => lRegisterCourseNamHoc + ""; set => lRegisterCourseNamHoc.Text = value; }
        public string HocKy { get => lRegisterCourseHocKy + ""; set => lRegisterCourseHocKy.Text = value; }
        public string NgayLap { get => lRegisterCourseNgayLap + ""; set => lRegisterCourseNgayLap.Text = value; }
        public Image View { get => picRegisterCourseView.Image; set => picRegisterCourseView.Image = value; }
        public Image Update { get => picRegisterCourseUpdate.Image; set => picRegisterCourseUpdate.Image = value; }
        public Image Delete { get => picRegisterCourseDelete.Image; set => picRegisterCourseDelete.Image = value; }

        private void picRegisterCourseView_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xem chi tiết" + MaPhieu);
        }

        private void picRegisterCourseUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chỉnh sửa" + MaPhieu);
        }

        private void picRegisterCourseDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa" + MaPhieu);
        }
    }
}
