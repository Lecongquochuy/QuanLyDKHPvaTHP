using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDKHPvaTHP
{
    public partial class fUpdateSubject : Form
    {
        public fUpdateSubject()
        {
            InitializeComponent();
        }

        private void btnUpdateSub_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm môn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
