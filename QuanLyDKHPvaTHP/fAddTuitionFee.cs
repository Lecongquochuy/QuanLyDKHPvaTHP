using QuanLyDKHPvaTHP.DAO;
using System.Data;

namespace QuanLyDKHPvaTHP
{
    public partial class fAddTuitionFee : Form
    {
        private bool flag = true;
        private bool add = true;
        public fAddTuitionFee()
        {
            InitializeComponent();
        }

        private DateTime dateTime = DateTime.Now;

        private void AddTuition()
        {
            if (tboxMoneyTuition.Text == "")
            {
                MessageBox.Show("Không được để trống số tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tboxMoneyTuition.Focus();
            }
            else
            {
                flag = true;
                string query = "SELECT MAX(MaPhieuThu) FROM dbo.PHIEUTHUHP";
                string MaxPT = DataProvider.Instance.ExecuteQuery(query).Rows[0][0].ToString();

                MaxPT = MaxPT.Substring(3);

                int maxPhieuThu = int.Parse(MaxPT);

                query = "set dateformat dmy INSERT INTO PHIEUTHUHP (MaPhieuThu, SoTienThu, NgayLap, MaPhieuDKHP) VALUES ('";

                string maphieuthu;

                if (maxPhieuThu < 9)
                {
                    maphieuthu = "PT00000" + (maxPhieuThu + 1).ToString();
                }
                else if (maxPhieuThu < 99)
                {
                    maphieuthu = "PT0000" + (maxPhieuThu + 1).ToString();
                }
                else if (maxPhieuThu < 999)
                {
                    maphieuthu = "PT000" + (maxPhieuThu + 1).ToString();
                }
                else if (maxPhieuThu < 9999)
                {
                    maphieuthu = "PT00" + (maxPhieuThu + 1).ToString();
                }
                else if (maxPhieuThu < 99999)
                {
                    maphieuthu = "PT0" + (maxPhieuThu + 1).ToString();
                }
                else maphieuthu = "PT" + (maxPhieuThu + 1).ToString();

                query += maphieuthu + "', ";

                query += tboxMoneyTuition.Text + ", '";

                query += dateTime.ToString("dd-MM-yyyy") + "', '";

                query += comboBoxdkhpID.Text + "');";

                try
                {
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
                    MessageBox.Show(ex.Message.Split('\n')[0], "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btn_AddTuition_Click(object sender, EventArgs e)
        {
            AddTuition();
            add = false;
        }

        private void tboxMSSVAddTuition_Validated(object sender, EventArgs e)
        {
            string query = "SELECT HoTen FROM dbo.SINHVIEN WHERE MSSV = '" + tboxMSSVAddTuition.Text + "'";
            object checkMSSV;
            checkMSSV = DataProvider.Instance.ExecuteScalar(query);

            if (checkMSSV is null)
            {
                flag = false;
                MessageBox.Show("Mã số sinh viên không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tboxMSSVAddTuition.Focus();
            }
            else
            {
                query = "set dateformat dmy SELECT MaHKNH FROM dbo.HOCKY_NAMHOC WHERE ThoiHanDongHocPhi = (SELECT MIN(ThoiHanDongHocPhi) " +
                "FROM dbo.HOCKY_NAMHOC WHERE ThoiHanDongHocPhi > '" + dateTime.ToString("dd-MM-yyyy") + "')";
                string maHKNH = (string)DataProvider.Instance.ExecuteQuery(query).Rows[0][0];
                query = "SELECT MaPhieuDKHP FROM dbo.PHIEUDKHP WHERE MSSV = '" + tboxMSSVAddTuition.Text + "' AND MaHKNH = '" + maHKNH + "'";
                object checkDKHP = DataProvider.Instance.ExecuteScalar(query);
                if (checkDKHP is null)
                {
                    flag = false;
                    MessageBox.Show("Sinh viên chưa đăng ký học phần.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tboxMSSVAddTuition.Focus();
                }
                else
                {
                    comboBoxdkhpID.DataSource = DataProvider.Instance.ExecuteQuery(query);
                    comboBoxdkhpID.DisplayMember = "MaPhieuDKHP";
                    comboBoxdkhpID.ValueMember = "MaPhieuDKHP";

                    string queryHP = "SELECT REPLACE(FORMAT(CAST(TongTien AS DECIMAL(19, 0)), 'N0', 'en-US'), ',', '.') AS TongTien, " +
                        "REPLACE(FORMAT(CAST(SoTienDaDong AS DECIMAL(19, 0)), 'N0', 'en-US'), ',', '.') AS SoTienDaDong, " +
                        "REPLACE(FORMAT(CAST(SoTienConLai AS DECIMAL(19, 0)), 'N0', 'en-US'), ',', '.') AS SoTienConLai " +
                        "FROM PHIEUDKHP WHERE MaPhieuDKHP = '" + comboBoxdkhpID.SelectedValue.ToString() + "'";
                    string queryDTUuTien = "SELECT TiLeGiam FROM DTUUTIEN AS DT JOIN SINHVIEN AS SV ON DT.MaDT = SV.MaDT WHERE MSSV = '" + tboxMSSVAddTuition.Text + "'";
                    float tilegiam = Convert.ToSingle(DataProvider.Instance.ExecuteScalar(queryDTUuTien));
                    DataTable dataHP = DataProvider.Instance.ExecuteQuery(queryHP);
                    if (dataHP.Rows.Count > 0)
                    {
                        DataRow row = dataHP.Rows[0];
                        textBoxTienDK.Text = row["TongTien"].ToString();
                        textBoxTienDaDong.Text = row["SoTienDaDong"].ToString();
                        textBoxTienConLai.Text = row["SoTienConLai"].ToString();
                        string total = textBoxTienDK.Text.Replace(".", "");
                        //MessageBox.Show(textBoxTienDK.Text);
                        int tienduocgiam = (int)(int.Parse(total) * tilegiam);
                        textBoxTienDuocGiam.Text = tienduocgiam + "";
                    }
                    else
                    {
                        flag = false;
                        MessageBox.Show("Không tìm thấy phiếu với mã: " + comboBoxdkhpID.SelectedValue.ToString());
                    }
                }
            }
        }

        private void fAddTuitionFee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (add)
            {
                if (flag == true)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            AddTuition();
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
        }

        private void tboxMoneyTuition_Validated(object sender, EventArgs e)
        {
            if (tboxMoneyTuition.Text != "")
            {
                if (int.Parse(tboxMoneyTuition.Text) <= 0)
                {
                    MessageBox.Show("Số tiền thu phải là số dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tboxMoneyTuition.Focus();
                }
                else if (int.Parse(tboxMoneyTuition.Text) > int.Parse(textBoxTienConLai.Text.Replace(".", "")))
                {
                    MessageBox.Show("Số tiền thu không được vượt quá số tiền còn lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tboxMoneyTuition.Focus();
                }
            }

        }
    }
}