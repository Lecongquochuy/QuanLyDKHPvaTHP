using PdfSharp.Snippets.Drawing;
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
    public partial class fViewStudent : Form
    {
        private string MSSV;
        public fViewStudent(string mssv)
        {
            InitializeComponent();
            MSSV = mssv;
            LoadStudent(MSSV);
        }
        void LoadStudent(string mssv)
        {
            string query = "SELECT MSSV, HoTen, TenDT, NgaySinh, GioiTinh, TenHuyen, TenTinh, TenKhoa, TenNH " +
                "FROM dbo.SINHVIEN AS SV JOIN dbo.NGANHHOC AS NH ON SV.MaNH = NH.MaNH " +
                "JOIN dbo.KHOA AS K ON NH.MaKhoa = K.MaKhoa " +
                "JOIN dbo.HUYEN AS H ON SV.MaHuyen = H.MaHuyen " +
                "JOIN dbo.TINH AS T ON H.MaTinh = T.MaTinh " +
                "JOIN dbo.DTUUTIEN AS DT ON SV.MaDT = DT.MaDT " +
                "WHERE MSSV = '" + mssv + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                //mssv = row["MSSV"].ToString();
                string hoten = row["HoTen"].ToString();
                string tendt = row["TenDT"].ToString();
                string ngaysinh = row["NgaySinh"].ToString();
                string gioitinh = row["GioiTinh"].ToString();
                string tenhuyen = row["TenHuyen"].ToString();
                string tentinh = row["TenTinh"].ToString();
                string tenkhoa = row["TenKhoa"].ToString();
                string tennh = row["TenNH"].ToString();
                loaddata(mssv, hoten, tendt, ngaysinh, gioitinh, tenhuyen, tentinh, tenkhoa, tennh);
            }
            else
            {
                MessageBox.Show("Không tìm thấy môn học với mã: " + MSSV);
            }
        }
        public void loaddata(string mssv, string hoten, string tendt, string ngaysinh, string gioitinh, string tenhuyen, string tentinh, string tenkhoa, string tennh)
        {
            lMSSV.Text = mssv;
            lNgaySinh.Text = ngaysinh.Split(" ")[0];
            lHoTen.Text = hoten;
            lDTUuTien.Text = tendt;
            lGioiTinh.Text = gioitinh;
            lHuyen.Text = tenhuyen;
            lTinh.Text = tentinh;
            lNganh.Text = tennh;
            lKhoa.Text = tenkhoa;

        }
    }
}
