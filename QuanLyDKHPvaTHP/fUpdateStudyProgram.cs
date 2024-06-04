using QuanLyDKHPvaTHP.DAO;
using System.Data;

namespace QuanLyDKHPvaTHP
{
    public partial class fUpdateStudyProgram : Form
    {
        private DataTable data = new DataTable();
        private string majorID;
        public EventHandler ExitFormUpdateStudyProgramRequested;
        public fUpdateStudyProgram(string faculties, string major)
        {
            InitializeComponent();

            lShowFaculties.Text = faculties;
            lShowMajor.Text = major;

            DefaultLoadSubjectList();
            GetMajorID();
            CalculateCredit();
            CalculateSubject();
        }

        void DefaultLoadSubjectList()
        {
            string query = "SELECT HocKy AS [Học kỳ], CTH.MaMH AS [Mã môn], TenMH AS [Tên môn], LM.TenLoaiMon AS [Loại môn], SoTC AS [Số tín chỉ] " +
                "FROM dbo.NGANHHOC AS NH JOIN dbo.CT_NGANH AS CTH ON NH.MaNH = CTH.MaNH JOIN dbo.MONHOC AS MH ON CTH.MaMH = MH.MaMH JOIN dbo.LOAIMON AS LM ON MH.MaLoaiMon = LM.MaLoaiMon " +
                "WHERE NH.TenNH = N'" + lShowMajor.Text + "' " +
                "ORDER BY HocKy";
            LoadSubjectList(query);
        }

        void GetMajorID()
        {
            string query = "SELECT MaNH FROM dbo.NGANHHOC WHERE TenNH = N'" + lShowMajor.Text + "'";
            majorID = (string)DataProvider.Instance.ExecuteScalar(query);
        }

        private void AddRowToDGV(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                data.Rows.Add(row.ItemArray);
            }
        }

        void LoadSubjectList(string query)
        {
            data = DataProvider.Instance.ExecuteQuery(query);
            dtgvUpdateStudyProgram.DataSource = data;

            CalculateCredit();
            CalculateSubject();
        }

        void LoadData()
        {
            dtgvUpdateStudyProgram.DataSource = data;
        }

        private void fUpdateStudyProgram_Shown(object sender, EventArgs e)
        {
            DefaultLoadSubjectList();
        }

        public bool CheckIfExists(string valueToCheck)
        {
            foreach (DataGridViewRow row in dtgvUpdateStudyProgram.Rows)
            {
                if (row.Cells["lSubjectIDHeader"].Value != null && row.Cells["lSubjectIDHeader"].Value.ToString() == valueToCheck)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            fAddSubjectOfUpdateStudyProgram fAddSub = new fAddSubjectOfUpdateStudyProgram(this);
            fAddSub.ShowDialog();
            if (fAddSub.check)
            {
                AddRowToDGV(fAddSub.SubjectTable);
            }
            LoadData();
        }

        private string GenerateNewStudyProgramID(string MaxMaCT_Nganh)
        {
            if (string.IsNullOrEmpty(MaxMaCT_Nganh))
            {
                return "CT000001";
            }

            int currentNumber = int.Parse(MaxMaCT_Nganh.Substring(2));
            int newNumber = currentNumber + 1;
            return $"CT{newNumber:D6}";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string getMaxMaCTNganhQuery = "SELECT MAX(MaCT_Nganh) FROM dbo.CT_NGANH";
            object result = DataProvider.Instance.ExecuteScalar(getMaxMaCTNganhQuery);
            string newMaCTNganh = GenerateNewStudyProgramID(result?.ToString());

            string query = "SELECT COUNT(CTH.MaCT_Nganh) " +
                "FROM dbo.CT_NGANH AS CTH WHERE MaCT_Nganh " +
                "NOT IN (SELECT DSMHMO.MaCT_Nganh FROM dbo.DSMHMO)";
            string count = DataProvider.Instance.ExecuteScalar(query).ToString();

            if (count != "0")
            {
                query = "SELECT CTH.MaCT_Nganh " +
                    "FROM dbo.CT_NGANH AS CTH WHERE MaCT_Nganh " +
                    "NOT IN (SELECT DSMHMO.MaCT_Nganh FROM dbo.DSMHMO)";
                DataTable dta = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow row in dta.Rows)
                {
                    query = "DELETE FROM dbo.CT_NGANH WHERE MaCT_Nganh = '" + row["MaCT_Nganh"] + "'";
                    DataProvider.Instance.ExecuteScalar(query);
                }
            }

            query = "INSERT INTO CT_NGANH(MaCT_Nganh, MaNH, MaMH, HocKy) VALUES ";

            foreach (DataRow row in data.Rows)
            {
                string query2 = "SELECT MaCT_Nganh FROM dbo.CT_NGANH WHERE MaNH = '" + majorID + "' AND MaMH = '" + row["Mã môn"] + "'";
                string macth = (string)DataProvider.Instance.ExecuteScalar(query2);

                query2 = "SELECT COUNT(DSMHMO.MaMo) FROM dbo.DSMHMO WHERE MaCT_Nganh = '" + macth + "'";
                count = DataProvider.Instance.ExecuteScalar(query2).ToString();

                if (count == "0")
                {
                    query += "('" + newMaCTNganh + "', '" + majorID + "', '" + row["Mã môn"] + "', " + row["Học kỳ"] + ")";
                    if (data.Rows.IndexOf(row) == data.Rows.Count - 1)
                    {
                        query += ";";
                    }
                    else
                    {
                        query += ", ";
                    }
                    newMaCTNganh = GenerateNewStudyProgramID(newMaCTNganh);
                }
            }

            if (query == "INSERT INTO CT_NGANH(MaCT_Nganh, MaNH, MaMH, HocKy) VALUES ")
            {
                MessageBox.Show("Lưu dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    int rowAffect = DataProvider.Instance.ExecuteNonQuery(query);
                    if (rowAffect > 0)
                    {
                        MessageBox.Show("Lưu dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Lưu dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            ExitFormUpdateStudyProgramRequested?.Invoke(this, EventArgs.Empty);
        }

        private void CalculateCredit()
        {
            int LT = 0;
            int TH = 0;
            foreach (DataGridViewRow row in dtgvUpdateStudyProgram.Rows)
            {
                if (row.Cells["lCreditHeader"].Value != null)
                {
                    if (row.Cells["lSubjectTypeHeader"].Value.ToString() == "Lý thuyết")
                    {
                        LT += Convert.ToInt32(row.Cells["lCreditHeader"].Value);
                    }
                    else
                    {
                        TH += Convert.ToInt32(row.Cells["lCreditHeader"].Value);
                    }
                }
            }
            lCreditAmountTheory.Text = LT.ToString();
            lCreditAmountPractice.Text = TH.ToString();
        }

        private void CalculateSubject()
        {
            int count = 0;
            foreach (DataGridViewRow row in dtgvUpdateStudyProgram.Rows)
            {
                if (row.Cells["lSubjectTypeHeader"].Value != null && row.Cells["lSubjectTypeHeader"].Value.ToString() == "Lý thuyết")
                {
                    count++;
                }
            }
            lSubAmount.Text = count.ToString();
        }

        public void reloadStuPro()
        {
            DefaultLoadSubjectList();
        }

        private void dtgvUpdateStudyProgram_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            DataGridViewColumn column = new DataGridViewColumn();
            column = dtgvUpdateStudyProgram.Columns[e.ColumnIndex];

            switch (Convert.ToString(column.Name))
            {
                case "View":
                    if (dtgvUpdateStudyProgram.SelectedCells.Count > 0)
                    {
                        int selectedRowIndex = dtgvUpdateStudyProgram.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dtgvUpdateStudyProgram.Rows[selectedRowIndex];
                        string SubjectIDValue = Convert.ToString(selectedRow.Cells["lSubjectIDHeader"].Value);

                        fViewSubjectOfStudyProgram fViewSub = new fViewSubjectOfStudyProgram(SubjectIDValue);
                        fViewSub.ShowDialog();
                        reloadStuPro();
                    }
                    break;
                case "Delete":
                    string query = "SELECT MaCT_Nganh FROM dbo.CT_NGANH WHERE MaNH = '" + majorID + "' AND MaMH = '" + data.Rows[e.RowIndex]["Mã môn"] + "'";
                    string macth = (string)DataProvider.Instance.ExecuteScalar(query);

                    query = "SELECT COUNT(DSMHMO.MaMo) FROM dbo.DSMHMO WHERE MaCT_Nganh = '" + macth + "'";
                    string count = DataProvider.Instance.ExecuteScalar(query).ToString();

                    if (count == "0")
                    {
                        query = "SELECT MaMH " +
                            "FROM dbo.MONHOC as mh JOIN dbo.LOAIMON as lm ON mh.MaLoaiMon = lm.MaLoaiMon " +
                            "WHERE mh.TenMH = N'" + data.Rows[e.RowIndex]["Tên môn"] + "' AND mh.MaMH != '" + data.Rows[e.RowIndex]["Mã môn"] + "'";

                        object mamon = DataProvider.Instance.ExecuteScalar(query);
                        int rowindex = -1;
                        if (mamon is not null)
                        {
                            foreach (DataRow dr in data.Rows)
                            {
                                rowindex++;
                                if (dr["Mã môn"].ToString() == mamon.ToString())
                                {
                                    break;
                                }
                            }
                            data.Rows.RemoveAt(rowindex);
                        }
                        if (rowindex > -1 && rowindex < e.RowIndex)
                        {
                            data.Rows.RemoveAt(e.RowIndex - 1);
                        }
                        else data.Rows.RemoveAt(e.RowIndex);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa môn do môn học đã tồn tại trong danh sách môn học mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                default:
                    break;
            }
        }

        private void dtgvUpdateStudyProgram_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateCredit();
            CalculateSubject();
        }

        private void dtgvUpdateStudyProgram_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculateCredit();
            CalculateSubject();
        }
    }
}