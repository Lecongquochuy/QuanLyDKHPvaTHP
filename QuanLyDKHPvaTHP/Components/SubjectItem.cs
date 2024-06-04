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
    public partial class SubjectItem : UserControl
    {
        public SubjectItem()
        {
            InitializeComponent();
        }
        public string Number { get => lSubjectNumder.Text; set => lSubjectNumder.Text = value; }
        public string Id { get => lSubjectID.Text; set => lSubjectID.Text = value; }
        public string Name { get => lSubjectName.Text; set => lSubjectName.Text = value; }
        public string Type { get => lSubjectType.Text; set => lSubjectType.Text = value; }
        public string SoTC { get => lSubjectSoTC + ""; set => lSubjectSoTC.Text = value; }
        public Image View { get => picSubjectView.Image; set => picSubjectView.Image = value; }
        public Image Update { get => picSubjectUpdate.Image; set => picSubjectUpdate.Image = value; }
        public Image Delete { get => picSubjectDelete.Image; set => picSubjectDelete.Image = value; }

        private void picSubjectView_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xem chi tiết" + Id);
        }

        private void picSubjectUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chỉnh sửa" + Id);
        }

        private void picSubjectDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa" + Id);
        }
    }
}
