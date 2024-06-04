using QuanLyDKHPvaTHP.DAO;
using System.Collections.Generic;
using System.Data;
using System.Windows.Controls;
using System.Windows.Forms;

namespace QuanLyDKHPvaTHP
{
    public partial class fUpdateRegister : Form
    {
        private DataTable data = new DataTable();
        private string MaPhieuDK;
        public EventHandler ExitFormUpdateRegisterRequested;
        private string str;
        private string maHKNH;
        private string maNGANH;
        private string studentID;
        private float tilegiam;
        private int gialt, giath;
        public fUpdateRegister(string maPhieuDK)
        {
            InitializeComponent();

            MaPhieuDK = maPhieuDK;


            LoadRegisterInfo();
            CalculateCredit();
            CalculateSubject();
            CalculateMoney();

        }
        void GetTiLeGiam()
        {
            string query = "SELECT TiLeGiam FROM dbo.SINHVIEN SV JOIN dbo.DTUUTIEN AS DT ON SV.MaDT = DT.MaDT " +
                "WHERE MSSV = '" + studentID + "' ";
            object tlg = DataProvider.Instance.ExecuteScalar(query);
            tilegiam = Convert.ToSingle(tlg);
        }

        void GetMoneyPerCredit()
        {
            string query = "SELECT SoTienMotTC " +
                "FROM dbo.LOAIMON " +
                "WHERE MaLoaiMon = 'LM1'";
            object giaLT = DataProvider.Instance.ExecuteScalar(query);
            gialt = Convert.ToInt32(giaLT);

            query = "SELECT SoTienMotTC " +
                "FROM dbo.LOAIMON " +
                "WHERE MaLoaiMon = 'LM2'";
            object giaTH = DataProvider.Instance.ExecuteScalar(query);
            giath = Convert.ToInt32(giaTH);
        }

        private void CalculateCredit()
        {
            int total = 0;
            foreach (DataGridViewRow row in dgvSelectedSubject.Rows)
            {
                if (row.Cells["SoTC_Selected"].Value != null)
                {
                    total += Convert.ToInt32(row.Cells["SoTC_Selected"].Value);
                }
            }
            lbCreditAmount.Text = total.ToString();
        }

        private void CalculateSubject()
        {
            int count = 0;
            foreach (DataGridViewRow row in dgvSelectedSubject.Rows)
            {
                if (row.Cells["TenLoaiMon_Selected"].Value != null && row.Cells["TenLoaiMon_Selected"].Value.ToString() == "Lý thuyết")
                {
                    count++;
                }
            }
            lbSubAmount.Text = count.ToString();
        }

        private void CalculateMoney()
        {
            GetTiLeGiam();
            GetMoneyPerCredit();
            int LT = 0;
            int TH = 0;
            foreach (DataGridViewRow row in dgvSelectedSubject.Rows)
            {
                if (row.Cells["SoTC_Selected"].Value != null)
                {
                    if (row.Cells["TenLoaiMon_Selected"].Value.ToString() == "Lý thuyết")
                    {
                        LT += Convert.ToInt32(row.Cells["SoTC_Selected"].Value);
                    }
                    else
                    {
                        TH += Convert.ToInt32(row.Cells["SoTC_Selected"].Value);
                    }
                }
            }
            lbMoneySum.Text = ((1 - tilegiam) * (LT * gialt + TH * giath)).ToString();
        }


        private void fUpdateRegister_Shown(object sender, EventArgs e)
        {

        }

        private void LoadNganhHoc()
        {
            string query = "SELECT MaNH FROM dbo.SINHVIEN WHERE MSSV = '" + studentID + "'";
            object maNganh = DataProvider.Instance.ExecuteScalar(query);
            maNGANH = maNganh.ToString();
        }

        private void LoadOpenSubject()
        {
            string query = "SELECT MH.MaMH, TenMH, TenLoaiMon, SoTC, SoTiet, MaMo, MH.MaLoaiMon " +
                   "FROM dbo.CT_NGANH AS CTH " +
                   "JOIN dbo.DSMHMO AS MHMO ON CTH.MaCT_Nganh = MHMO.MaCT_Nganh " +
                   "JOIN dbo.MONHOC AS MH ON CTH.MaMH = MH.MaMH " +
                   "JOIN dbo.LOAIMON AS LM ON MH.MaLoaiMon = LM.MaLoaiMon " +
                   "WHERE CTH.MaNH = '" + maNGANH + "' AND MHMO.MaHKNH = '" + maHKNH + "' " +
                   "AND MaMo NOT IN (SELECT MaMo FROM CT_DKHP WHERE MaPhieuDKHP = '" + MaPhieuDK + "')";

            dgvOpenSubject.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }
        private void LoadRegisterSubject()
        {
            string query = "SELECT MH.MaMH, TenMH, TenLoaiMon, SoTC, SoTiet, CTPDK.MaMo, MH.MaLoaiMon " +
               "FROM dbo.CT_DKHP AS CTPDK " +
               "JOIN dbo.DSMHMO AS MHMO ON CTPDK.MaMo = MHMO.MaMo " +
               "JOIN dbo.CT_NGANH AS CTH ON MHMO.MaCT_Nganh = CTH.MaCT_Nganh " +
               "JOIN dbo.MONHOC AS MH ON CTH.MaMH = MH.MaMH " +
               "JOIN dbo.LOAIMON AS LM ON MH.MaLoaiMon = LM.MaLoaiMon " +
               "WHERE CTPDK.MaPhieuDKHP = '" + MaPhieuDK + "'";

            dgvSelectedSubject.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void LoadRegisterInfo()
        {
            string query = "SELECT DKHP.MSSV, HKNH.NamHoc, HKNH.HocKy, HKNH.MaHKNH, FORMAT(DKHP.NgayLap, 'dd/MM/yyyy') AS NgayLap " +
                "FROM dbo.PHIEUDKHP AS DKHP JOIN dbo.HOCKY_NAMHOC AS HKNH ON DKHP.MaHKNH = HKNH.MaHKNH " +
                "WHERE DKHP.MaPhieuDKHP = '" + MaPhieuDK + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            lbRegisterID.Text = MaPhieuDK;
            lbStudentID.Text = (string)data.Rows[0]["MSSV"];
            studentID = lbStudentID.Text;
            lbSchoolYear.Text = data.Rows[0]["NamHoc"].ToString();
            lbSemester.Text = data.Rows[0]["HocKy"].ToString();
            maHKNH = data.Rows[0]["MaHKNH"].ToString();
            lbDateCreate.Text = data.Rows[0]["NgayLap"].ToString();

            LoadNganhHoc();
            LoadOpenSubject();
            LoadRegisterSubject();

        }

        public bool CheckIfExists(string valueToCheck)
        {
            foreach (DataGridViewRow row in dgvOpenSubject.Rows)
            {
                if (row.Cells["MaMH"].Value != null && row.Cells["MaMH"].Value.ToString() == valueToCheck)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM dbo.CT_DKHP WHERE MaPhieuDKHP = '" + MaPhieuDK + "'";
            DataProvider.Instance.ExecuteNonQuery(query);

            query = "";
            if (dgvSelectedSubject.Rows.Count == 0)
            {
                string queryDelete = "DELETE FROM dbo.PHIEUDKHP WHERE MaPhieuDKHP = '" + MaPhieuDK + "'";
                DataProvider.Instance.ExecuteNonQuery(queryDelete);
                MessageBox.Show("Phiếu không còn môn học nào, xóa phiếu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ExitFormUpdateRegisterRequested?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                foreach (DataGridViewRow row in dgvSelectedSubject.Rows)
                {
                    string queryTemp = "INSERT INTO CT_DKHP(MaPhieuDKHP, MaMo) VALUES ";
                    query += queryTemp + "('" + MaPhieuDK + "', '" + row.Cells["MaMo_Selected"].Value + "'); ";
                }
                try
                {
                    int rowAffect = DataProvider.Instance.ExecuteNonQuery(query);
                    if (rowAffect > 0)
                    {
                        MessageBox.Show("Lưu dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string queryError = "DELETE FROM dbo.PHIEUDKHP WHERE MaPhieuDKHP = '" + MaPhieuDK + "'";
                        DataProvider.Instance.ExecuteNonQuery(queryError);
                        MessageBox.Show("Lưu dữ liệu thất bại, vui lòng tạo lại phiếu mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            ExitFormUpdateRegisterRequested?.Invoke(this, EventArgs.Empty);
        }





        private void tctAddSubject_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush textBrush;

            // Lấy TabPage đang được vẽ hiện tại
            TabPage tabPage = tctAddSubject.TabPages[e.Index];

            // Lấy hình chữ nhật đại diện cho khu vực tab đang được vẽ
            Rectangle tabBounds = tctAddSubject.GetTabRect(e.Index);

            // Chọn màu nền tùy theo tab có được chọn hay không
            /*            if (e.Index == tctAddSubject.SelectedIndex)
            */
            if (e.State == DrawItemState.Selected)

            {
                // Tab đang được chọn
                textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.Blue, e.Bounds);
            }
            else
            {
                // Tab không được chọn
                textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.LightGray, e.Bounds);
            }
            Font tabFont = new Font("Times New Roman", 16.0f);
            StringFormat stringFlags = new StringFormat();
            stringFlags.Alignment = StringAlignment.Center;
            stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(tctAddSubject.TabPages[e.Index].Text, tabFont, textBrush, e.Bounds, stringFlags);
        }
        private void fUpdateRegister_Load(object sender, EventArgs e)
        {
            tctAddSubject.DrawMode = TabDrawMode.OwnerDrawFixed;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsToAdd = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in dgvOpenSubject.Rows.Cast<DataGridViewRow>()
                .Where(r => Convert.ToBoolean(r.Cells["CheckBox"].Value)))
            {
                string tenMH = row.Cells["TenMH"].Value.ToString();
                rowsToAdd.Add(row);

                // Tìm các môn học có cùng TenMH nhưng khác MaLoaiMon
                foreach (DataGridViewRow r in dgvOpenSubject.Rows)
                {
                    if (r.Cells["TenMH"].Value.ToString() == tenMH &&
                        r.Cells["MaLoaiMon"].Value.ToString() != row.Cells["MaLoaiMon"].Value.ToString())
                    {
                        rowsToAdd.Add(r);
                    }
                }
            }

            DataTable dtSelectedSubject = (DataTable)dgvSelectedSubject.DataSource;

            foreach (DataGridViewRow row in rowsToAdd.Distinct().ToList())
            {
                DataRow newRow = dtSelectedSubject.NewRow();
                for (int i = 0; i < row.Cells.Count - 1; i++)
                {
                    newRow[i] = row.Cells[i + 1].Value;
                }
                dtSelectedSubject.Rows.Add(newRow);
                dgvOpenSubject.Rows.Remove(row);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsToDelete = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in dgvSelectedSubject.Rows.Cast<DataGridViewRow>()
                .Where(r => Convert.ToBoolean(r.Cells["CheckBox_Selected"].Value)))
            {
                string tenMH = row.Cells["TenMH_Selected"].Value.ToString();
                rowsToDelete.Add(row);

                // Tìm các môn học có cùng TenMH nhưng khác MaLoaiMon
                foreach (DataGridViewRow r in dgvSelectedSubject.Rows)
                {
                    if (r.Cells["TenMH_Selected"].Value.ToString() == tenMH &&
                        r.Cells["MaLoaiMon_Selected"].Value.ToString() != row.Cells["MaLoaiMon_Selected"].Value.ToString())
                    {
                        rowsToDelete.Add(r);
                    }
                }
            }

            DataTable dtOpenSubject = (DataTable)dgvOpenSubject.DataSource;

            foreach (DataGridViewRow row in rowsToDelete.Distinct().ToList())
            {
                DataRow newRow = dtOpenSubject.NewRow();
                for (int i = 0; i < row.Cells.Count - 1; i++)
                {
                    newRow[i] = row.Cells[i + 1].Value;
                }
                dtOpenSubject.Rows.Add(newRow);
                dgvSelectedSubject.Rows.Remove(row);
            }
        }
        private void dgvSelectedSubject_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateCredit();
            CalculateSubject();
            CalculateMoney();
        }

        private void dgvSelectedSubject_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculateCredit();
            CalculateSubject();
            CalculateMoney();
        }
    }
}