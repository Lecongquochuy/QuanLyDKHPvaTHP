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
using System.Drawing.Printing;
using System.Drawing;
using System.Drawing.Printing;
using static System.Net.Mime.MediaTypeNames;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.IO;

namespace QuanLyDKHPvaTHP
{
    public partial class fReport : Form
    {
        private PrintDocument printDocument;
        private Bitmap formImage;
        public fReport()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

        }

        void DefaultLoadReportList()
        {
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY HKNH.MaHKNH) AS STT, NamHoc, HocKy " +
                "FROM dbo.HOCKY_NAMHOC HKNH " +
                "WHERE EXISTS ( SELECT 1 FROM BCCHUADONGHP BC WHERE HKNH.MaHKNH = BC.MaHKNH)";

            LoadReportList(query);
        }

        void LoadReportList(string query)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            dataTable.Columns.Add("NewHocKy", typeof(string));
            dataTable.Columns.Add("NewNamHoc", typeof(string));
            foreach (DataRow row in dataTable.Rows)
            {
                if (Convert.ToInt32(row["HocKy"]) == 1)
                {
                    row["NewHocKy"] = "Học kỳ 1";
                }
                if (Convert.ToInt32(row["HocKy"]) == 2)
                {
                    row["NewHocKy"] = "Học kỳ 2";
                }
                if (Convert.ToInt32(row["HocKy"]) == 3)
                {
                    row["NewHocKy"] = "Học kỳ hè";
                }
                row["NewNamHoc"] = Convert.ToInt32(row["NamHoc"]).ToString() + "-" + (Convert.ToInt32(row["NamHoc"]) + 1).ToString();
            }
            dataTable.Columns.Remove("HocKy");
            dataTable.Columns.Remove("NamHoc");
            dataTable.Columns["NewHocKy"].ColumnName = "HocKy";
            dataTable.Columns["NewNamHoc"].ColumnName = "NamHoc";
            dataTable.Columns["STT"].SetOrdinal(0);
            dataTable.Columns["NamHoc"].SetOrdinal(1);
            dataTable.Columns["HocKy"].SetOrdinal(2);
            dataGridView1.DataSource = dataTable;
            // Tạo một đối tượng Padding mới với các giá trị padding mong muốn
            Padding cellPadding = new Padding(5, 5, 5, 5); // Lề trên, lề phải, lề dưới, lề trái

            // Lặp qua từng cột trong DataGridView và đặt Padding cho mỗi cell style của cột
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Padding = cellPadding;
            }
        }

        private void fReport_Load(object sender, EventArgs e)
        {
            DefaultLoadReportList();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            DataGridViewColumn column = new DataGridViewColumn();
            column = dataGridView1.Columns[e.ColumnIndex];

            switch (Convert.ToString(column.Name))
            {
                case "View":
                    row = dataGridView1.Rows[e.RowIndex];
                    string hocKy = Convert.ToString(row.Cells["Semester"].Value);
                    string namHoc = Convert.ToString(row.Cells["SchoolYear"].Value);
                    hocKy = Replace_HocKy(hocKy);
                    namHoc = Replace_NamHoc(namHoc);
                    fViewReport formview = new fViewReport(hocKy, namHoc);
                    formview.ShowDialog();
                    Reload();
                    break;
                case "Print":
                    row = dataGridView1.Rows[e.RowIndex];
                    hocKy = Convert.ToString(row.Cells["Semester"].Value);
                    namHoc = Convert.ToString(row.Cells["SchoolYear"].Value);
                    hocKy = Replace_HocKy(hocKy);
                    namHoc = Replace_NamHoc(namHoc);
                    fViewReport formprint = new fViewReport(hocKy, namHoc);
                    formprint.FormBorderStyle = FormBorderStyle.None;
                    formprint.Show();
                    formImage = formprint.CaptureForm();
                    formprint.FormBorderStyle = FormBorderStyle.Sizable;

                    using (PdfDocument document = new PdfDocument())
                    {
                        PdfPage page = document.AddPage();
                        page.Width = formImage.Width;
                        page.Height = formImage.Height;

                        using (XGraphics gfx = XGraphics.FromPdfPage(page))
                        {
                            using (MemoryStream stream = new MemoryStream())
                            {
                                formImage.Save(stream, ImageFormat.Png);
                                stream.Position = 0;
                                XImage xImage = XImage.FromStream(stream);
                                gfx.DrawImage(xImage, 0, 0, formImage.Width, formImage.Height);
                            }
                        }
                        string folderpath = "Downloads";
                        string filename = "FormPrint";
                        string extension = ".pdf";
                        int counter = 1;
                        string filepath;
                        do
                        {
                            filepath = $"{folderpath}{filename}{counter}{extension}";
                            counter++;
                        } while (File.Exists(filepath));
                        document.Save(filepath);
                        MessageBox.Show("Xuất thành công", "Thông báo");
                        formprint.Hide();
                    }
                    Reload();
                    break;
                default:
                    break;
            }

        }

        private void Reload()
        {
            string srch = tbSearch.Text;
            string query = "";
            string HKstr = "Học kỳ ";
            if (HKstr.Contains(srch))
            {
                srch = "";
            }
            if (srch.StartsWith(HKstr))
            {
                srch = srch.Substring(HKstr.Length);
                if (srch == "hè") srch = "3";
                query = "SELECT ROW_NUMBER() OVER (ORDER BY HKNH.MaHKNH) AS STT, NamHoc, HocKy " +
                "FROM dbo.HOCKY_NAMHOC HKNH " +
                "WHERE EXISTS ( SELECT 1 FROM BCCHUADONGHP BC WHERE HKNH.MaHKNH = BC.MaHKNH) " +
                "AND HocKy LIKE '%" + srch + "%'";
            }
            else
            {
                query = "SELECT ROW_NUMBER() OVER (ORDER BY HKNH.MaHKNH) AS STT, NamHoc, HocKy " +
                "FROM dbo.HOCKY_NAMHOC HKNH " +
                "WHERE EXISTS ( SELECT 1 FROM BCCHUADONGHP BC WHERE HKNH.MaHKNH = BC.MaHKNH) " +
                "AND (NamHoc LIKE '%" + srch + "%' OR HocKy LIKE '%" + srch + "%')";
            }
            if (srch.Contains("-"))
            {
                srch = srch.Split("-")[0];
                query = "SELECT ROW_NUMBER() OVER (ORDER BY HKNH.MaHKNH) AS STT, NamHoc, HocKy " +
                "FROM dbo.HOCKY_NAMHOC HKNH " +
                "WHERE EXISTS ( SELECT 1 FROM BCCHUADONGHP BC WHERE HKNH.MaHKNH = BC.MaHKNH) " +
                "AND (NamHoc LIKE '%" + srch + "%' OR HocKy LIKE '%" + srch + "%')";
            }
            LoadReportList(query);
        }

        string Replace_HocKy(string hocKy)
        {
            switch (hocKy)
            {
                case "Học kỳ 1":
                    hocKy = "1";
                    break;
                case "Học kỳ 2":
                    hocKy = "2";
                    break;
                case "Học kỳ hè":
                    hocKy = "3";
                    break;
                default:
                    break;
            }
            return hocKy;
        }

        string Replace_NamHoc(string namHoc)
        {
            namHoc = namHoc.Split('-')[0];
            return namHoc;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (formImage != null)
            {
                e.Graphics.DrawImage(formImage, new Point(0, 0));
            }
        }
    }
}
