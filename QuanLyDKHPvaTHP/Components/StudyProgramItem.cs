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
    public partial class StudyProgramItem : UserControl
    {
        public StudyProgramItem()
        {
            InitializeComponent();
        }
        public string Number { get => lStudyProgramNumder.Text; set => lStudyProgramNumder.Text = value; }
        public string Nganh { get => lStudyProgramNganh.Text; set => lStudyProgramNganh.Text = value; }
        public string Khoa { get => lStudyProgramKhoa.Text; set => lStudyProgramKhoa.Text = value; }
        public Image View { get => picStudyProgramView.Image; set => picStudyProgramView.Image = value; }
        public Image Update { get => picStudyProgramUpdate.Image; set => picStudyProgramUpdate.Image = value; }
        public Image Delete { get => picStudyProgramDelete.Image; set => picStudyProgramDelete.Image = value; }

        private void picStudyProgramView_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xem chi tiết" + Nganh + " " + Khoa);
        }

        private void picStudyProgramUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chỉnh sửa" + Nganh + " " + Khoa);
        }

        private void picStudyProgramDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa" + Nganh + " " + Khoa);
        }
    }
}
