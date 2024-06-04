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
    public partial class fViewTuitionFee : Form
    {
        private string ID;
        public fViewTuitionFee(string TuitipnFeeID)
        {
            InitializeComponent();
            ID = TuitipnFeeID;
            LoadTuitionFeeData();
        }

        private void LoadTuitionFeeData()
        {
            string query = "SELECT FORMAT(hphi.NgayLap, 'dd/MM/yyyy') as NgayLap, sv.MSSV, dkhp.MaPhieuDKHP, SoTienThu " +
                   "FROM dbo.PHIEUDKHP as dkhp JOIN dbo.PHIEUTHUHP as hphi ON " +
                   "dkhp.MaPhieuDKHP = hphi.MaPhieuDKHP JOIN dbo.SINHVIEN as sv ON dkhp.MSSV = sv.MSSV " +
                   "WHERE MaPhieuThu = '" + ID + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            lMaPhieuViewTuition.Text = ID;
            lNgayLapViewTuition.Text = (string)dt.Rows[0]["NgayLap"];
            lMssvViewTuition.Text = (string)dt.Rows[0]["MSSV"];
            lDkhpViewTuition.Text = (string)dt.Rows[0]["MaPhieuDKHP"];
            string money;
            money = dt.Rows[0]["SoTienThu"].ToString();
            int index = money.IndexOf(".");
            money = money.Substring(0, index);
            lTienViewTuition.Text = money;

            string queryHP = "SELECT REPLACE(FORMAT(CAST(SoTienConLai AS DECIMAL(19, 0)), 'N0', 'en-US'), ',', '.') AS SoTienConLai " +
                        "FROM PHIEUDKHP WHERE MaPhieuDKHP = '" + lDkhpViewTuition.Text + "'";
            DataTable dataHP = DataProvider.Instance.ExecuteQuery(queryHP);
            if (dataHP.Rows.Count > 0)
            {
                DataRow row = dataHP.Rows[0];
                textBoxTienConLai.Text = row["SoTienConLai"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy phiếu với mã: " + lDkhpViewTuition.Text);
            }
        }
    }
}
