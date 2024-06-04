using QuanLyDKHPvaTHP.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDKHPvaTHP
{
    public partial class fUpdateSubject : Form
    {
        private bool flag = false;
        private string MaMH;
        private string loaimonold, tenmonold;
        public fUpdateSubject(string maMH)
        {
            InitializeComponent();
            MaMH = maMH;
            LoadLoaiMonToComboBox();
            LoadSubject(MaMH);
        }
        void LoadSubject(string maMH)
        {
            //MessageBox.Show("1 + ");
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
                loaimonold = tenLoaiMon;
                tenmonold = tenMH;
                loaddata(mamon, tenMH, soTiet, soTC, tenLoaiMon);
                loadSoTC(tenLoaiMon, soTiet);
            }
            else
            {
                flag = false;
                MessageBox.Show("Không tìm thấy môn học với mã: " + maMH);
            }
        }
        public void loadSoTC(string loaimon, int soTiet)
        {
            string query = "SELECT SoTietMotTC FROM LOAIMON WHERE TenLoaiMon = N'" + loaimon + "'";
            int sotiet1tc = (int)DataProvider.Instance.ExecuteScalar(query);
            textBoxSoTC.Text = soTiet / sotiet1tc + "";
        }
        public void loaddata(string mamh, string tenmon, int sotiet, int sotc, string loaimon)
        {
            textBoxMaMon.Text = mamh;
            textBoxTenMon.Text = tenmon;
            textBoxSoTiet.Text = sotiet + "";
            comboLoaiMon.Text = loaimon;
        }
        DataTable GetLoaiMon()
        {
            string query = "SELECT MaLoaiMon, TenLoaiMon FROM dbo.LOAIMON";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        void LoadLoaiMonToComboBox()
        {
            DataTable data = GetLoaiMon();
            comboLoaiMon.DataSource = data;
            comboLoaiMon.DisplayMember = "TenLoaiMon";
            comboLoaiMon.ValueMember = "MaLoaiMon";
        }
        public void loaddataUpdate()
        {
            if (textBoxMaMon.Text == "" || textBoxTenMon.Text == "" || textBoxSoTiet.Text == "" || textBoxSoTC.Text == "" || comboLoaiMon.SelectedValue.ToString() == "")
            {
                flag = false;
                MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string maMH = textBoxMaMon.Text;
                string tenMH = textBoxTenMon.Text;
                int soTiet = int.Parse(textBoxSoTiet.Text);
                int soTC = int.Parse(textBoxSoTC.Text);
                string maLoaiMon = comboLoaiMon.SelectedValue.ToString();
                SaveSubject(maMH, tenMH, soTiet, soTC, maLoaiMon);
            }
        }
        // Phương thức để lưu dữ liệu vào cơ sở dữ liệu
        void SaveSubject(string maMH, string tenMH, int soTiet, int sotc, string maLoaiMon)
        {
            string querycheck = "SELECT COUNT(*) FROM MONHOC WHERE TenMH = N'" + tenMH + "' AND MaLoaiMon = '" + maLoaiMon + "'";
            int check = (int)DataProvider.Instance.ExecuteScalar(querycheck);
            if (check == 0 || (check == 1 && tenMH == tenmonold && loaimonold == comboLoaiMon.Text))
            {
                try
                {
                    string query = "UPDATE dbo.MONHOC " +
                        "SET TenMH = N'" + tenMH + "', SoTiet = " + soTiet + ", MaLoaiMon = N'" + maLoaiMon + "' " +
                        "WHERE MaMH = '" + maMH + "'";
                    int rowAffect = DataProvider.Instance.ExecuteNonQuery(query);
                    if (rowAffect > 0)
                    {
                        MessageBox.Show("Lưu dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                    {
                        flag = false;
                        MessageBox.Show("Lưu dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    flag = false;
                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("Đã có môn học này trong cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message.Split('\n')[0], "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
                MessageBox.Show("Đã có môn học này trong cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnUpdateSub_Click(object sender, EventArgs e)
        {
            loaddataUpdate();
        }

        private void comboLoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(textBoxSoTiet.Text + " - " + comboLoaiMon.Text);
            if (comboLoaiMon.Text != "System.Data.DataRowView")
            {
                int soTiet = int.Parse(textBoxSoTiet.Text);
                string loaimon = comboLoaiMon.Text;
                loadSoTC(loaimon, soTiet);
            }
        }

        private void textBoxSoTiet_TextChanged(object sender, EventArgs e)
        {
            if (comboLoaiMon.Text != "System.Data.DataRowView")
            {
                int soTiet = int.Parse(textBoxSoTiet.Text);
                string loaimon = comboLoaiMon.Text;
                loadSoTC(loaimon, soTiet);
            }
        }

        private void fAddSubject_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flag)
            {
                if (textBoxMaMon.Text != "" && textBoxTenMon.Text != "" && textBoxSoTiet.Text != "" && comboLoaiMon.SelectedValue.ToString() != "")
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        loaddataUpdate();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }
    }
}
