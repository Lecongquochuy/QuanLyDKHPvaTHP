
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
    public partial class fviewSubjectOpenSubject : Form
    {
        private string MaMon;
        public fviewSubjectOpenSubject(string Mamon)
        {
            InitializeComponent();
            MaMon = Mamon;
            Load();
        }

        void Load()
        {
            lMaMonViewSub.Text = MaMon;
            string query = "SELECT MaMH, TenMH, SoTiet, SoTC, TenLoaiMon " +
                "FROM dbo.MONHOC as mh JOIN dbo.LOAIMON as lm ON mh.MaLoaiMon = lm.MaLoaiMon " +
                "WHERE mh.MaMH = '" + MaMon + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            lTenMonViewSub.Text = data.Rows[0]["TenMH"].ToString();
            lSoTietViewSub.Text = data.Rows[0]["SoTiet"].ToString();
            lSoTcViewSub.Text = data.Rows[0]["SoTC"].ToString();
            lLoaiMonViewSub.Text = data.Rows[0]["TenLoaiMon"].ToString();
        }
    }
}
