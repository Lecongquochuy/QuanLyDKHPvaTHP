using QuanLyDKHPvaTHP.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuanLyDKHPvaTHP
{
    public partial class fTuition_fee : Form
    {
        public fTuition_fee(int id)
        {
            InitializeComponent();
            Authorization(id);
        }
        private void Authorization(int id)
        {
            string query = "SELECT Type FROM dbo.ACCOUNT WHERE ID = " + id;
            int role = (int)DataProvider.Instance.ExecuteScalar(query);
            if (role == 1)
            {
                btnAdd.Visible = false;
            }
        }

        void DefaultLoadTuitionFeeList()
        {
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MaPhieuThu) AS STT, MaPhieuThu, HoTen, FORMAT(hphi.NgayLap, 'dd/MM/yyyy') as NgayLap, SoTienThu " +
                "FROM dbo.PHIEUDKHP as dkhp JOIN dbo.PHIEUTHUHP as hphi ON dkhp.MaPhieuDKHP = hphi.MaPhieuDKHP JOIN dbo.SINHVIEN as sv ON dkhp.MSSV = sv.MSSV";

            LoadTuitionFeeList(query);
        }

        void LoadTuitionFeeList(string query)
        {
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }


        private void fTuitionFee_Shown(object sender, EventArgs e)
        {
            DefaultLoadTuitionFeeList();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string srch = tbSearch.Text;
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MaPhieuThu) AS STT, MaPhieuThu, HoTen, FORMAT(hphi.NgayLap, 'dd/MM/yyyy') as NgayLap, SoTienThu " +
                "FROM dbo.PHIEUDKHP as dkhp JOIN dbo.PHIEUTHUHP as hphi ON dkhp.MaPhieuDKHP = hphi.MaPhieuDKHP JOIN dbo.SINHVIEN as sv ON dkhp.MSSV = sv.MSSV " +
                "WHERE MaPhieuThu LIKE '%" + srch + "%' OR HoTen LIKE N'%" + srch + "%'";

            LoadTuitionFeeList(query);
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
                    fViewTuitionFee fViewTuitionFee = new fViewTuitionFee((string)row.Cells["lTuitionFeeID"].Value);
                    fViewTuitionFee.Show();
                    break;
                default:
                    break;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddTuitionFee fAddTuitionFee = new fAddTuitionFee();
            fAddTuitionFee.ShowDialog();
            DefaultLoadTuitionFeeList();
        }


    }
}
