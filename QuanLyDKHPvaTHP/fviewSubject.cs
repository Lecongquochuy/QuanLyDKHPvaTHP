using QuanLyDKHPvaTHP.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDKHPvaTHP
{
    public partial class fViewSubject : Form
    {
        private string MaMH;
        public fViewSubject(string maMH)
        {
            InitializeComponent();
            this.MaMH = maMH;
            //MessageBox.Show("View " + maMH);

            LoadSubject(MaMH);
        }
        void LoadSubject(string maMH)
        {
            string query = "SELECT MaMH, TenMH, SoTiet, SoTC,  LM.TenLoaiMon " +
                "FROM dbo.MONHOC AS MH JOIN dbo.LOAIMON AS LM ON MH.MaLoaiMon = LM.MaLoaiMon " +
                "WHERE MaMH = '" + MaMH + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                string mamon = row["MaMH"].ToString();
                string tenMH = row["TenMH"].ToString();
                int soTiet = Convert.ToInt32(row["SoTiet"]);
                int soTC = Convert.ToInt32(row["SoTC"]);
                string tenLoaiMon = row["TenLoaiMon"].ToString();

                loaddata(mamon, tenMH, soTiet, soTC, tenLoaiMon);
            }
            else
            {
                MessageBox.Show("Không tìm thấy môn học với mã: " + maMH);
            }
        }
        public void loaddata(string mamh, string tenmon, int sotiet, int sotc, string loaimon)
        {
            lMaMonViewSub.Text = mamh;
            lTenMonViewSub.Text = tenmon;
            lLoaiMonViewSub.Text = loaimon;
            lSoTcViewSub.Text = sotc + "";
            lSoTietViewSub.Text = sotiet + "";
        }

    }
}
