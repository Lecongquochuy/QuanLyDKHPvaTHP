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

namespace QuanLyDKHPvaTHP
{
    public partial class fSemesterSchoolYear : Form
    {
        private DataTable originalDataTable;
        public fSemesterSchoolYear(int id)
        {
            InitializeComponent();
            Authorization(id);
        }
        private void Authorization(int id)
        {
            string query = "SELECT Type FROM dbo.ACCOUNT WHERE ID = " + id;
            int role = (int)DataProvider.Instance.ExecuteScalar(query);
            if (role == 2)
            {
                dataGridView1.Columns["Update"].Visible = false;
                btnAdd.Visible = false;
            }
        }

        void DefaultLoadSSYList()
        {
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MaHKNH) AS STT, " +
                "HocKy, NamHoc, FORMAT(ThoiHanDongHocPhi, 'dd/MM/yyyy') AS ThoiHanDongHocPhi FROM dbo.HOCKY_NAMHOC";

            LoadSSYList(query);
        }

        void LoadSSYList(string query)
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
            dataTable.Columns["HocKy"].SetOrdinal(1);
            dataTable.Columns["NamHoc"].SetOrdinal(2);
            dataGridView1.DataSource = dataTable;
            // Tạo một đối tượng Padding mới với các giá trị padding mong muốn
            Padding cellPadding = new Padding(5, 5, 5, 5); // Lề trên, lề phải, lề dưới, lề trái

            // Lặp qua từng cột trong DataGridView và đặt Padding cho mỗi cell style của cột
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Padding = cellPadding;
            }
        }


        private void fSSY_Load(object sender, EventArgs e)
        {
            DefaultLoadSSYList();
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
                case "Update":
                    row = dataGridView1.Rows[e.RowIndex];
                    string hocKy = Convert.ToString(row.Cells["Semester"].Value);
                    string namHoc = Convert.ToString(row.Cells["SchoolYear"].Value);
                    hocKy = Replace_HocKy(hocKy);
                    namHoc = Replace_NamHoc(namHoc);
                    string thdhp = Convert.ToString(row.Cells["TuitionDeadline"].Value);
                    string maHKNH = namHoc.ToString().Substring(2, 2) + "0" + hocKy;
                    fUpdateSemesterSchoolYear f = new fUpdateSemesterSchoolYear(maHKNH);
                    f.ShowDialog();
                    Reload();
                    break;
                default:
                    break;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddSemesterSchoolYear f = new fAddSemesterSchoolYear();
            f.ShowDialog();
            Reload();
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
                query = "SELECT ROW_NUMBER() OVER (ORDER BY MaHKNH) AS STT, " +
                "HocKy, NamHoc, FORMAT(ThoiHanDongHocPhi, 'dd/MM/yyyy') AS ThoiHanDongHocPhi FROM dbo.HOCKY_NAMHOC " +
                "WHERE HocKy LIKE '%" + srch + "%'";
            }
            else
            {
                query = "SELECT ROW_NUMBER() OVER (ORDER BY MaHKNH) AS STT, " +
                "HocKy, NamHoc, FORMAT(ThoiHanDongHocPhi, 'dd/MM/yyyy') AS ThoiHanDongHocPhi FROM dbo.HOCKY_NAMHOC " +
                "WHERE HocKy LIKE '%" + srch + "%' OR NamHoc LIKE '%" + srch + "%' OR ThoiHanDongHocPhi LIKE '%" + srch + "%'";
            }
            if (srch.Contains("-"))
            {
                srch = srch.Split("-")[0];
                query = "SELECT ROW_NUMBER() OVER (ORDER BY MaHKNH) AS STT, " +
                "HocKy, NamHoc, FORMAT(ThoiHanDongHocPhi, 'dd/MM/yyyy') AS ThoiHanDongHocPhi FROM dbo.HOCKY_NAMHOC " +
                "WHERE HocKy LIKE '%" + srch + "%' OR NamHoc LIKE '%" + srch + "%' OR ThoiHanDongHocPhi LIKE '%" + srch + "%'";
            }
            LoadSSYList(query);
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



    }
}
