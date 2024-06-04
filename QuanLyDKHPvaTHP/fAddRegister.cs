using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;
using QuanLyDKHPvaTHP.DAO;

namespace QuanLyDKHPvaTHP
{
    public partial class fAddRegister : Form
    {
        /*        private DataTable data = new DataTable();
        */
        public EventHandler ExitFormAddRegisterRequested;
        private DateTime currentDate = DateTime.Now;
        private string str;
        private string maHKNH;
        private string maNGANH;
        private string studentID;
        private float tilegiam;
        private int gialt, giath;

        public fAddRegister()
        {
            InitializeComponent();
            /*            data.Columns.Add("MaMH", typeof(string));
                        data.Columns.Add("TenMH", typeof(string));
                        data.Columns.Add("TenLoaiMon", typeof(string));
                        data.Columns.Add("SoTC", typeof(string));
                        data.Columns.Add("SoTiet", typeof(string));
            */
            CalculateCredit();
            CalculateSubject();
            CalculateMoney();
        }

        void LoadSchoolYear()
        {
            string query = "SET DATEFORMAT DMY SELECT distinct NamHoc " +
                "FROM dbo.HOCKY_NAMHOC " +
                "WHERE ThoiHanDongHocPhi = (SELECT MIN(ThoiHanDongHocPhi) " +
                "FROM dbo.HOCKY_NAMHOC WHERE ThoiHanDongHocPhi >= '" + (currentDate.ToString("dd-MM-yyyy")) + "')";
            object NamHoc = DataProvider.Instance.ExecuteScalar(query);
            lbSchoolYear.Text = NamHoc.ToString();
        }

        void LoadSemester(string years)
        {
            string query = "SET DATEFORMAT DMY SELECT HocKy FROM dbo.HOCKY_NAMHOC AS HKy " +
                "WHERE NamHoc = " + years + " AND ThoiHanDongHocPhi = (SELECT MIN(ThoiHanDongHocPhi) " +
                "FROM dbo.HOCKY_NAMHOC WHERE ThoiHanDongHocPhi >= '" + (currentDate.ToString("dd-MM-yyyy")) + "')";
            object HocKy = DataProvider.Instance.ExecuteScalar(query);
            lbSemester.Text = HocKy.ToString();
            query = "SET DATEFORMAT DMY SELECT MaHKNH FROM dbo.HOCKY_NAMHOC AS HKy " +
                "WHERE NamHoc = " + years + " AND ThoiHanDongHocPhi = (SELECT MIN(ThoiHanDongHocPhi) " +
                "FROM dbo.HOCKY_NAMHOC WHERE ThoiHanDongHocPhi >= '" + (currentDate.ToString("dd-MM-yyyy")) + "')";
            HocKy = DataProvider.Instance.ExecuteScalar(query);
            maHKNH = HocKy.ToString();
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

        private void fAddRegister_Shown(object sender, EventArgs e)
        {
            LoadSchoolYear();
            str = lbSchoolYear.Text;
            if (str != "")
                LoadSemester(str);

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

        private void LoadOpenSubjects()
        {
            /*            string query = "SELECT MH.MaMH, TenMH, TenLoaiMon, SoTC, SoTiet, MaMo, MH.MaLoaiMon " +
                            "FROM dbo.SINHVIEN AS SV JOIN NGANHHOC AS NH ON SV.MaNH = NH.MaNH " +
                            "JOIN dbo.CT_NGANH AS CTH ON NH.MaNH = CTH.MaNH " +
                            "JOIN dbo.MONHOC AS MH ON CTH.MaMH = MH.MaMH " +
                            "JOIN dbo.LOAIMON AS LM ON MH.MaLoaiMon = LM.MaLoaiMon " +
                            "JOIN dbo.DSMHMO AS MHMO ON CTH.MaCT_Nganh = MHMO.MaCT_Nganh " +
                            "JOIN dbo.HOCKY_NAMHOC AS HKNH ON MHMO.MaHKNH = HKNH.MaHKNH " +
                            "WHERE SV.MSSV = '" + studentID + "'AND MHMO.MaHKNH = '" + maHKNH + "' " +
                            "AND ((HKNH.HocKy % 2 = 1 AND CTH.HocKy % 2 = 1)  " +
                            "OR (HKNH.HocKy % 2 = 0 AND CTH.HocKy % 2 = 0))";
            */
            string query = "SELECT MH.MaMH, TenMH, TenLoaiMon, SoTC, SoTiet, MaMo, MH.MaLoaiMon " +
                "FROM dbo.CT_NGANH AS CTH " +
                "JOIN dbo.DSMHMO AS MHMO ON CTH.MaCT_Nganh = MHMO.MaCT_Nganh " +
                "JOIN dbo.MONHOC AS MH ON CTH.MaMH = MH.MaMH " +
                "JOIN dbo.LOAIMON AS LM ON MH.MaLoaiMon = LM.MaLoaiMon " +
                "WHERE CTH.MaNH = '" + maNGANH + "' AND MHMO.MaHKNH = '" + maHKNH + "'";
            dgvOpenSubject.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private string GenerateNewRegisterID()
        {
            string query = "SELECT TOP 1 MaPhieuDKHP FROM PHIEUDKHP ORDER BY MaPhieuDKHP DESC";
            object result = DataProvider.Instance.ExecuteScalar(query);

            if (result != null)
            {
                int lastNumber = int.Parse(result.ToString().Substring(2));
                int newNumber = lastNumber + 1;
                return "DK" + newNumber.ToString("D6");
            }
            else
            {
                return "DK000001"; // Nếu không có phiếu nào trong cơ sở dữ liệu, bắt đầu từ DK000001
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dtpDateCreate.Value;

            if (txbStudentID.Text == "")
            {
                MessageBox.Show("Mã số sinh viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dgvSelectedSubject.Rows.Count == 0)
                {
                    MessageBox.Show("Không có môn học nào được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ExitFormAddRegisterRequested?.Invoke(this, EventArgs.Empty);
                    return;
                }
                string query = "";

                string maphieuDKHP = GenerateNewRegisterID();
                string queryAddRegister = "SET DATEFORMAT DMY INSERT INTO PHIEUDKHP (MaPhieuDKHP, NgayLap, MSSV, MaHKNH) " +
                    "VALUES ('" + maphieuDKHP + "', '" + dateTime.ToString("dd/MM/yyyy") + "', '" + txbStudentID.Text + "', '" + maHKNH + "')";
                try
                {
                    int insertDKHP = DataProvider.Instance.ExecuteNonQuery(queryAddRegister);
                    foreach (DataGridViewRow row in dgvSelectedSubject.Rows)
                    {
                        string queryTemp = "INSERT INTO CT_DKHP(MaPhieuDKHP, MaMo) VALUES ";
                        query += queryTemp + "('" + maphieuDKHP + "', '" + row.Cells["MaMo_Selected"].Value + "'); ";
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
                            string queryError = "DELETE FROM dbo.PHIEUDKHP WHERE MaPhieuDKHP = '" + maphieuDKHP + "'";
                            DataProvider.Instance.ExecuteNonQuery(queryError);
                            MessageBox.Show("Lưu dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.Split('\n')[0], "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ExitFormAddRegisterRequested?.Invoke(this, EventArgs.Empty);
                }

            }

            ExitFormAddRegisterRequested?.Invoke(this, EventArgs.Empty);
        }



        private bool CheckStudentID(string mssv)
        {
            string query = "SELECT COUNT(*) FROM SINHVIEN WHERE MSSV = @mssv";
            int count = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { mssv });
            return count > 0;
        }

        private void txbStudentID_Validated(object sender, EventArgs e)
        {
            studentID = txbStudentID.Text;
            if (!CheckStudentID(studentID))
            {
                MessageBox.Show("Mã số sinh viên không tồn tại trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "SELECT MaNH FROM dbo.SINHVIEN WHERE MSSV = '" + studentID + "'";
                object maNganh = DataProvider.Instance.ExecuteScalar(query);
                maNGANH = maNganh.ToString();
                LoadOpenSubjects();
            }
        }

        private void tctAddSubject_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush textBrush;

            // Lấy TabPage đang được vẽ hiện tại
            TabPage tabPage = tctAddSubject.TabPages[e.Index];

            // Lấy hình chữ nhật đại diện cho khu vực tab đang được vẽ
            Rectangle tabBounds = tctAddSubject.GetTabRect(e.Index);

            // Chọn màu nền cho tab
            if (e.State == DrawItemState.Selected)
            {
                // Màu khi tab được chọn
                textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.DarkBlue, e.Bounds);
            }
            else
            {
                // Màu khi tab không được chọn
                textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.LightGray, e.Bounds);
            }

            // Vẽ text trên tab
            Font tabFont = new Font("Times New Roman", 16.0f);
            StringFormat stringFlags = new StringFormat();
            stringFlags.Alignment = StringAlignment.Center;
            stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(tctAddSubject.TabPages[e.Index].Text, tabFont, textBrush, e.Bounds, stringFlags);
            /*            g.DrawString(tabPage.Text, tabFont, textBrush, tabBounds, new StringFormat(stringFlags));
            */
        }

        private void fAddRegister_Load(object sender, EventArgs e)
        {
            tctAddSubject.DrawMode = TabDrawMode.OwnerDrawFixed;
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            (dgvOpenSubject.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("MaMH LIKE '%{0}%' OR TenMH LIKE '%{0}%'", tbSearch.Text);

            /*            // Tạo DataView từ nguồn dữ liệu của DataGridView
                        DataView dataView = ((DataTable)dgvOpenSubject.DataSource).DefaultView;

                        // Đặt bộ lọc dựa trên cột "Tên_Môn_Học"
                        dataView.RowFilter = $"MaMH LIKE '%{tbSearch.Text}%' OR TenMH LIKE '%{tbSearch.Text}%'";

                        // Gán DataView cho DataGridView
                        dgvOpenSubject.DataSource = dataView;
            */
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

            foreach (DataGridViewRow row in rowsToAdd.Distinct().ToList())
            {
                DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    newRow.Cells[i].Value = row.Cells[i].Value;
                    newRow.Cells[0].Value = false;
                }
                dgvSelectedSubject.Rows.Add(newRow);
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