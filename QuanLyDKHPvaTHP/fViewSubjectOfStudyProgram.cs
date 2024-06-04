using Microsoft.Data.SqlClient;
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
using SqlDataReader = System.Data.SqlClient.SqlDataReader;

namespace QuanLyDKHPvaTHP
{
    public partial class fViewSubjectOfStudyProgram : Form
    {
        private object MaMH;

        public fViewSubjectOfStudyProgram(string subjectid)
        {
            InitializeComponent();
            this.MaMH = subjectid;
            LoadSubjectDetail(subjectid);
        }

        void LoadSubjectDetail(string subjectid)
        {
            string query = "SELECT MaMH, TenMH, SoTiet, SoTC,  LM.TenLoaiMon " +
                "FROM dbo.MONHOC AS MH JOIN dbo.LOAIMON AS LM ON MH.MaLoaiMon = LM.MaLoaiMon " +
                "WHERE MaMH = '" + subjectid + "'";

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
                MessageBox.Show("Không tìm thấy môn học với mã: " + subjectid);
            }

        }
        public void loaddata(string mamh, string tenmon, int sotiet, int sotc, string loaimon)
        {
            labelShowMaMonCTH.Text = mamh;
            labelShowTenMHCTH.Text = tenmon;
            labelShowLoaiMonCTH.Text = loaimon;
            labelShowSoTCCTH.Text = sotc + "";
            labelShowSoTietCTH.Text = sotiet + "";
        }
    }
}
