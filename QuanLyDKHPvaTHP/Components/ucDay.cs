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
    public partial class ucDay : UserControl
    {
        public ucDay()
        {
            InitializeComponent();
        }
        public void days(int numday)
        {
            lableDay.Text = numday + "";
        }
        public void changecolorDayNow()
        {
            panelday.BackColor = Color.Orange;
            lableDay.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);

        }
    }
}
