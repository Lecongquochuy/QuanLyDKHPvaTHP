using QuanLyDKHPvaTHP.Components;
using QuanLyDKHPvaTHP.DAO;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot.Annotations;
using HorizontalAlignment = OxyPlot.HorizontalAlignment;
using OxyPlot.Legends;
using System.Windows.Controls;
using Label = System.Windows.Forms.Label;

namespace QuanLyDKHPvaTHP
{
    public partial class fDashboard : Form
    {
        int month, year, day, nmonth, nyear;
        int svDonghp, svChuahp, sv, svDKHP;
        int namHoc;
        public string hknh = "";
        private string hk = "";
        private String namhoc = "";
        public fDashboard()
        {
            InitializeComponent();
            DefaultLoadDashboardList();
            loadDataChart();
            plotHocPhi();
            plotDKHP();
        }
        void plotHocPhi()
        {
            plotView1.BringToFront();
            var plotModel = new PlotModel { Title = "Sinh viên đóng học phí" };
            plotModel.TitleFontSize = 13;
            plotModel.PlotMargins = new OxyThickness(24, 24, 24, 24);
            var pieSeries = new PieSeries
            {
                StrokeThickness = 2.0,
                AngleSpan = 360,
                StartAngle = 120,
                InnerDiameter = 0.7 // Thiết lập để tạo lỗ ở giữa (Donut)
            };
            pieSeries.Slices.Add(new PieSlice("Đã đóng", svDonghp) { IsExploded = true, Fill = OxyColors.LightGreen });
            pieSeries.Slices.Add(new PieSlice("Chưa đóng", svChuahp) { Fill = OxyColors.LightBlue });
            plotModel.Series.Add(pieSeries);
            plotView1.Model = plotModel;
        }
        void plotDKHP()
        {
            plotView2.BringToFront();
            var plotModel = new PlotModel { Title = "Sinh viên DKHP" };
            plotModel.TitleFontSize = 13;
            plotModel.PlotMargins = new OxyThickness(36, 36, 36, 36);
            var pieSeries = new PieSeries
            {
                StrokeThickness = 2.0,
                AngleSpan = 360,
                StartAngle = 120,
                InnerDiameter = 0.7 // Thiết lập để tạo lỗ ở giữa (Donut)
            };
            pieSeries.Slices.Add(new PieSlice("Đăng ký", svDKHP) { IsExploded = true, Fill = OxyColors.PaleVioletRed });
            pieSeries.Slices.Add(new PieSlice("Chưa", sv - svDKHP) { Fill = OxyColors.LightBlue });
            plotModel.Series.Add(pieSeries);
            plotView2.Model = plotModel;
        }
        void loadDataChart()
        {
            sv = int.Parse(numberSV.Text);
            svDKHP = int.Parse(numberDKHP.Text);
            svChuahp = int.Parse(numberTHP.Text);
            svDonghp = svDKHP - svChuahp;
        }
        void loadNamHoc()
        {

        }
        void DefaultLoadDashboardList()
        {
            int nowYear = DateTime.Now.Year;
            int nowMonth = DateTime.Now.Month;
            if (nowMonth >= 8 && nowMonth <= 12)
            {
                hknh = nowYear.ToString().Substring(2, 2) + "01";
                hk = "1";
            }
            else if (nowMonth <= 6)
            {
                nowYear--;
                hknh = nowYear.ToString().Substring(2, 2) + "02";
                hk = "2";
            }
            else
            {
                nowYear--;
                hknh = nowYear.ToString().Substring(2, 2) + "03";
                hk = "3";
            }
            namhoc = nowYear.ToString();

            //MessageBox.Show(hknh);
            string querySV = "SELECT COUNT(MSSV) AS SoLuong FROM dbo.SINHVIEN";
            string queryDKHP = "select COUNT(MaPhieuDKHP) from dbo.PHIEUDKHP where MaHKNH = '" + hknh + "'";
            string queryTHP = "select COUNT(MaPhieuDKHP) from dbo.PHIEUDKHP where MaHKNH = '" + hknh + "' and SoTienConLai != 0";
            LoadDashboardItem(querySV, numberSV);
            LoadDashboardItem(queryDKHP, numberDKHP);
            LoadDashboardItem(queryTHP, numberTHP);
        }
        public void loaddata(int numday, Label lbase)
        {
            lbase.Text = numday + "";
        }

        void LoadDashboardItem(string query, Label lbase)
        {
            lbase.Controls.Clear();

            int data = (int)DataProvider.Instance.ExecuteScalar(query);
            loaddata(data, lbase);

        }
        private void fDashboard_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            nmonth = now.Month;
            nyear = now.Year;
            day = now.Day;
            month = nmonth;
            year = nyear;

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lMonthYear.Text = monthName + " " + year;


            DateTime startoftheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheWeek = Convert.ToInt32(startoftheMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayoftheWeek; i++)
            {
                ucBlankDay ucblank = new ucBlankDay();
                flowLayoutCalendar.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                ucDay ucdays = new ucDay();
                ucdays.days(i);
                if (i == day && month == nmonth && year == nyear)
                {
                    ucdays.changecolorDayNow();
                }
                flowLayoutCalendar.Controls.Add(ucdays);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            flowLayoutCalendar.Controls.Clear();
            if (month == 12)
            {
                month = 1;
                year++;
            }
            else
                month++;
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lMonthYear.Text = monthName + " " + year;

            DateTime startoftheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheWeek = Convert.ToInt32(startoftheMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayoftheWeek; i++)
            {
                ucBlankDay ucblank = new ucBlankDay();
                flowLayoutCalendar.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                ucDay ucdays = new ucDay();
                ucdays.days(i);
                if (i == day && month == nmonth && year == nyear)
                {
                    ucdays.changecolorDayNow();
                }
                flowLayoutCalendar.Controls.Add(ucdays);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            flowLayoutCalendar.Controls.Clear();

            if (month == 1)
            {
                month = 12;
                year--;
            }
            else
                month--;

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lMonthYear.Text = monthName + " " + year;

            DateTime startoftheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheWeek = Convert.ToInt32(startoftheMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayoftheWeek; i++)
            {
                ucBlankDay ucblank = new ucBlankDay();
                flowLayoutCalendar.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                ucDay ucdays = new ucDay();
                ucdays.days(i);
                if (i == day && month == nmonth && year == nyear)
                {
                    ucdays.changecolorDayNow();
                }
                flowLayoutCalendar.Controls.Add(ucdays);
            }
        }

        private void plotView1_Click(object sender, EventArgs e)
        {
            fViewReport f = new fViewReport(hk, namhoc);
            f.ShowDialog();
        }
    }
}
