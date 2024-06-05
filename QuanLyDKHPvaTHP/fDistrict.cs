﻿using PdfSharp.Charting;
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
    public partial class fDistrict : Form
    {
        public fDistrict(int id)
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
                dataGridView1.Columns["Delete"].Visible = false;
                btnAdd.Visible = false;
            }
        }
        void DefaultLoadList()
        {
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MaHuyen) AS STT, MaHuyen, TenHuyen, TenTinh, VungSauVungXa " +
                "FROM dbo.HUYEN JOIN dbo.TINH ON HUYEN.MaTinh = TINH.MaTinh";
            LoadList(query);
        }

        void LoadList(string query)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            dataTable.Columns.Add("NewVSVX", typeof(int));
            foreach (DataRow row in dataTable.Rows)
            {
                if (Convert.ToInt32(row["VungSauVungXa"]) == 0)
                {
                    row["NewVSVX"] = 0;
                }
                if (Convert.ToInt32(row["VungSauVungXa"]) == 1)
                {
                    row["NewVSVX"] = 1;
                }
            }
            dataTable.Columns.Remove("VungSauVungXa");
            dataTable.Columns["NewVSVX"].ColumnName = "VungSauVungXa";
            dataGridView1.DataSource = dataTable;
            // Tạo một đối tượng Padding mới với các giá trị padding mong muốn
            Padding cellPadding = new Padding(5, 5, 5, 5); // Lề trên, lề phải, lề dưới, lề trái

            // Lặp qua từng cột trong DataGridView và đặt Padding cho mỗi cell style của cột
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Padding = cellPadding;
            }
        }

        private void fDistrict_Load(object sender, EventArgs e)
        {
            DefaultLoadList();
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
                    string maHuyen = Convert.ToString(row.Cells["DistrictId"].Value);
                    string tenHuyen = Convert.ToString(row.Cells["DistrictName"].Value);
                    string tenTinh = Convert.ToString(row.Cells["ProvinceName"].Value);
                    string vsvx = Convert.ToString(row.Cells["RemoteArea"].Value);
                    fUpdateDistrict f = new fUpdateDistrict(maHuyen, tenHuyen, tenTinh, vsvx);
                    f.ShowDialog();
                    Reload();
                    break;
                case "Delete":
                    row = dataGridView1.Rows[e.RowIndex];
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xoá chứ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            maHuyen = Convert.ToString(row.Cells["DistrictId"].Value);
                            string deleteQuery = "DELETE FROM HUYEN WHERE MaHuyen =  '" + maHuyen + "'";
                            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(deleteQuery);

                            if (rowsAffected == 0)
                            {
                                MessageBox.Show("Có lỗi xảy ra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            string keyword = "The conflict occurred in database \"QLDKHP\", table \"dbo.SINHVIEN\", column 'MaHuyen'";
                            if (ex.Message.Contains(keyword))
                            {
                                MessageBox.Show("Không thể xóa huyện này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(ex.Message.Split('\n')[0], "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        Reload();
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddDistrict f = new fAddDistrict();
            f.ShowDialog();
            Reload();
        }

        private void Reload()
        {
            string srch = tbSearch.Text;
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MaHuyen) AS STT, MaHuyen, TenHuyen, TenTinh, VungSauVungXa " +
                "FROM dbo.HUYEN JOIN dbo.TINH ON HUYEN.MaTinh = TINH.MaTinh " +
                "WHERE MaHuyen LIKE '%" + srch + "%' OR TenHuyen LIKE N'%" + srch + "%' OR TenTinh LIKE N'%" + srch + "%' OR VungSauVungXa LIKE '%" + srch + "%'";
            LoadList(query);
        }
    }
}