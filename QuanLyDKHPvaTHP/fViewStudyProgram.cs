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
    public partial class fViewStudyProgram : Form
    {
        public event EventHandler ExitFormViewStudyProgramRequested;
        public fViewStudyProgram(string faculties, string major)
        {
            InitializeComponent();

            lShowFaculties.Text = faculties;
            lShowMajor.Text = major;

            DefaultLoadSubjectList();
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

        private void CalculateCredit()
        {
            int LT = 0;
            int TH = 0;
            foreach (DataGridViewRow row in dtgvViewStudyProgram.Rows)
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
            foreach (DataGridViewRow row in dtgvViewStudyProgram.Rows)
            {
                if (row.Cells["lSubjectTypeHeader"].Value != null && row.Cells["lSubjectTypeHeader"].Value.ToString() == "Lý thuyết")
                {
                    count++;
                }
            }
            lSubAmount.Text = count.ToString();
        }

        void LoadSubjectList(string query)
        {
            dtgvViewStudyProgram.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void fViewStudyProgram_Shown(object sender, EventArgs e)
        {
            DefaultLoadSubjectList();
        }

        private void dtgvViewStudyProgram_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            DataGridViewColumn column = new DataGridViewColumn();
            column = dtgvViewStudyProgram.Columns[e.ColumnIndex];

            if (Convert.ToString(column.Name) == "View")
            {
                if (dtgvViewStudyProgram.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dtgvViewStudyProgram.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dtgvViewStudyProgram.Rows[selectedRowIndex];
                    string SubjectIDValue = Convert.ToString(selectedRow.Cells["lSubjectIDHeader"].Value);

                    fViewSubjectOfStudyProgram fViewSub = new fViewSubjectOfStudyProgram(SubjectIDValue);
                    fViewSub.Show();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitFormViewStudyProgramRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}