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

namespace QuanLyDKHPvaTHP
{
    public partial class fViewReport : Form
    {
        public fViewReport(string hocKy, string namHoc)
        {
            InitializeComponent();
            string MaHKNH = namHoc.ToString().Substring(2, 2) + "0" + hocKy;
            LoadData(hocKy, namHoc);
            LoadViewReportList(MaHKNH);
        }

        private void LoadData(string hocKy, string namHoc)
        {
            lbHKViewReport.Text = hocKy;
            lbNHViewReport.Text = namHoc;
        }

        void LoadViewReportList(string MaHKNH)
        {
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY DC.MaHKNH) AS STT, SV.MSSV, HoTen, REPLACE(FORMAT(CAST(TongTien AS DECIMAL(19, 0)), 'N0', 'en-US'), ',', '.') AS TongTien, " + 
                    "REPLACE(FORMAT(CAST(SoTienPhaiDong AS DECIMAL(19, 0)), 'N0', 'en-US'), ',', '.') AS SoTienPhaiDong, " +
                    "REPLACE(FORMAT(CAST(SoTienConLai AS DECIMAL(19, 0)), 'N0', 'en-US'), ',', '.') AS SoTienConLai " +
                    "FROM dbo.BCCHUADONGHP DC " +
                    "JOIN dbo.PHIEUDKHP P ON P.MaHKNH = DC.MaHKNH AND P.MSSV = DC.MSSV " +
                    "JOIN dbo.SINHVIEN SV ON SV.MSSV = P.MSSV " +
                    "WHERE DC.MaHKNH = '" + MaHKNH + "'";
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        public Bitmap CaptureForm()
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            return bmp;
        }
    }
}
