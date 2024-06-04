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
    public partial class QuanLyDKHPvaThuHP : Form
    {
        public int ID;
        private string SchoolYear;
        private string Semester;
        private string Faculties;
        private string Major;
        private string RegisterID;
        fStudyProgram fStudyProgram;
        fOpenSubject fOpenSubject;
        fRegisterCourse fRegisterCourse;
        public QuanLyDKHPvaThuHP(int id)
        {
            InitializeComponent();
            defaultShow();
            ID = id;
            fOpenSubject = new fOpenSubject(ID);
            fStudyProgram = new fStudyProgram(ID);
            fRegisterCourse = new fRegisterCourse(ID);
            loadUser(ID);
        }

        public void loadUser(int id)
        {
            string query = "SELECT DisplayName FROM ACCOUNT WHERE Id = " + id;
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            btnUser.Text = dataTable.Rows[0][0].ToString();
        }
        public void loadForm(object Form)
        {
            if (this.pMainContent.Controls.Count > 0)
                this.pMainContent.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pMainContent.Controls.Add(f);
            this.pMainContent.Tag = f;
            f.Show();
        }
        void defaultShow()
        {
            loadForm(new fDashboard());
            btn_dashboard.BackColor = Color.FromArgb(0, 70, 107);
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            loadForm(new fProfile(this));
            btnUser.BackColor = Color.FromArgb(0, 70, 107);
            btn_dashboard.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_ChuongTrinhHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonhocMo.BackColor = Color.FromArgb(0, 48, 73);
            btn_SinhVien.BackColor = Color.FromArgb(0, 48, 73);
            btn_DKHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_ThuHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_BaoCao.BackColor = Color.FromArgb(0, 48, 73);
            btn_DTUuTien.BackColor = Color.FromArgb(0, 48, 73);
            btn_HocKiNamHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_LoaiMon.BackColor = Color.FromArgb(0, 48, 73);
            btn_Tinh.BackColor = Color.FromArgb(0, 48, 73);
            btn_Huyen.BackColor = Color.FromArgb(0, 48, 73);
            btn_Khoa.BackColor = Color.FromArgb(0, 48, 73);
            btn_Nganh.BackColor = Color.FromArgb(0, 48, 73);

        }
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            loadForm(new fDashboard());
            btn_dashboard.BackColor = Color.FromArgb(0, 70, 107);
            btn_MonHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_ChuongTrinhHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonhocMo.BackColor = Color.FromArgb(0, 48, 73);
            btn_SinhVien.BackColor = Color.FromArgb(0, 48, 73);
            btn_DKHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_ThuHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_BaoCao.BackColor = Color.FromArgb(0, 48, 73);
            btn_DTUuTien.BackColor = Color.FromArgb(0, 48, 73);

            btn_HocKiNamHoc.BackColor = Color.FromArgb(0, 48, 73);
            btnUser.BackColor = Color.FromArgb(0, 48, 73);
            btn_LoaiMon.BackColor = Color.FromArgb(0, 48, 73);
            btn_Tinh.BackColor = Color.FromArgb(0, 48, 73);
            btn_Huyen.BackColor = Color.FromArgb(0, 48, 73);
            btn_Khoa.BackColor = Color.FromArgb(0, 48, 73);
            btn_Nganh.BackColor = Color.FromArgb(0, 48, 73);
        }

        private void btn_SinhVien_Click(object sender, EventArgs e)
        {
            loadForm(new fStudent(ID));
            btn_dashboard.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_ChuongTrinhHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonhocMo.BackColor = Color.FromArgb(0, 48, 73);
            btn_SinhVien.BackColor = Color.FromArgb(0, 70, 107);
            btn_DKHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_ThuHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_BaoCao.BackColor = Color.FromArgb(0, 48, 73);
            btn_DTUuTien.BackColor = Color.FromArgb(0, 48, 73);

            btn_HocKiNamHoc.BackColor = Color.FromArgb(0, 48, 73);
            btnUser.BackColor = Color.FromArgb(0, 48, 73);
            btn_LoaiMon.BackColor = Color.FromArgb(0, 48, 73);
            btn_Tinh.BackColor = Color.FromArgb(0, 48, 73);
            btn_Huyen.BackColor = Color.FromArgb(0, 48, 73);
            btn_Khoa.BackColor = Color.FromArgb(0, 48, 73);
            btn_Nganh.BackColor = Color.FromArgb(0, 48, 73);
        }

        private void QuanLyDKHPvaThuHP_Load(object sender, EventArgs e)
        {

        }

        private void pMainContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_MonhocMo_Click(object sender, EventArgs e)
        {
            Formsubject_ReloadOpenSubjectRequested(sender, e);
            loadForm(fOpenSubject);
            btn_dashboard.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_ChuongTrinhHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonhocMo.BackColor = Color.FromArgb(0, 70, 107);
            btn_SinhVien.BackColor = Color.FromArgb(0, 48, 73);
            btn_DKHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_ThuHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_BaoCao.BackColor = Color.FromArgb(0, 48, 73);
            btn_DTUuTien.BackColor = Color.FromArgb(0, 48, 73);

            btn_HocKiNamHoc.BackColor = Color.FromArgb(0, 48, 73);
            btnUser.BackColor = Color.FromArgb(0, 48, 73);
            btn_LoaiMon.BackColor = Color.FromArgb(0, 48, 73);
            btn_Tinh.BackColor = Color.FromArgb(0, 48, 73);
            btn_Huyen.BackColor = Color.FromArgb(0, 48, 73);
            btn_Khoa.BackColor = Color.FromArgb(0, 48, 73);
            btn_Nganh.BackColor = Color.FromArgb(0, 48, 73);
        }

        private void btn_MonHoc_Click(object sender, EventArgs e)
        {
            loadForm(new fSubject(ID));
            btn_dashboard.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonHoc.BackColor = Color.FromArgb(0, 70, 107);
            btn_ChuongTrinhHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonhocMo.BackColor = Color.FromArgb(0, 48, 73);
            btn_SinhVien.BackColor = Color.FromArgb(0, 48, 73);
            btn_DKHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_ThuHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_BaoCao.BackColor = Color.FromArgb(0, 48, 73);
            btn_DTUuTien.BackColor = Color.FromArgb(0, 48, 73);

            btn_HocKiNamHoc.BackColor = Color.FromArgb(0, 48, 73);
            btnUser.BackColor = Color.FromArgb(0, 48, 73);
            btn_LoaiMon.BackColor = Color.FromArgb(0, 48, 73);
            btn_Tinh.BackColor = Color.FromArgb(0, 48, 73);
            btn_Huyen.BackColor = Color.FromArgb(0, 48, 73);
            btn_Khoa.BackColor = Color.FromArgb(0, 48, 73);
            btn_Nganh.BackColor = Color.FromArgb(0, 48, 73);
        }

        private void btn_HocKiNamHoc_Click(object sender, EventArgs e)
        {
            loadForm(new fSemesterSchoolYear(ID));
            btn_dashboard.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_ChuongTrinhHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonhocMo.BackColor = Color.FromArgb(0, 48, 73);
            btn_SinhVien.BackColor = Color.FromArgb(0, 48, 73);
            btn_DKHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_ThuHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_BaoCao.BackColor = Color.FromArgb(0, 48, 73);
            btn_DTUuTien.BackColor = Color.FromArgb(0, 48, 73);

            btn_HocKiNamHoc.BackColor = Color.FromArgb(0, 70, 107);
            btnUser.BackColor = Color.FromArgb(0, 48, 73);
            btn_LoaiMon.BackColor = Color.FromArgb(0, 48, 73);
            btn_Tinh.BackColor = Color.FromArgb(0, 48, 73);
            btn_Huyen.BackColor = Color.FromArgb(0, 48, 73);
            btn_Khoa.BackColor = Color.FromArgb(0, 48, 73);
            btn_Nganh.BackColor = Color.FromArgb(0, 48, 73);
        }

        private void btn_DTUuTien_Click(object sender, EventArgs e)
        {
            loadForm(new fPriority(ID));
            btn_dashboard.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_ChuongTrinhHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonhocMo.BackColor = Color.FromArgb(0, 48, 73);
            btn_SinhVien.BackColor = Color.FromArgb(0, 48, 73);
            btn_DKHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_ThuHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_BaoCao.BackColor = Color.FromArgb(0, 48, 73);
            btn_DTUuTien.BackColor = Color.FromArgb(0, 70, 107);

            btn_HocKiNamHoc.BackColor = Color.FromArgb(0, 48, 73);
            btnUser.BackColor = Color.FromArgb(0, 48, 73);
            btn_LoaiMon.BackColor = Color.FromArgb(0, 48, 73);
            btn_Tinh.BackColor = Color.FromArgb(0, 48, 73);
            btn_Huyen.BackColor = Color.FromArgb(0, 48, 73);
            btn_Khoa.BackColor = Color.FromArgb(0, 48, 73);
            btn_Nganh.BackColor = Color.FromArgb(0, 48, 73);
        }

        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            loadForm(new fReport());
            btn_dashboard.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_ChuongTrinhHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonhocMo.BackColor = Color.FromArgb(0, 48, 73);
            btn_SinhVien.BackColor = Color.FromArgb(0, 48, 73);
            btn_DKHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_ThuHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_BaoCao.BackColor = Color.FromArgb(0, 70, 107);
            btn_DTUuTien.BackColor = Color.FromArgb(0, 48, 73);

            btn_HocKiNamHoc.BackColor = Color.FromArgb(0, 48, 73);
            btnUser.BackColor = Color.FromArgb(0, 48, 73);
            btn_LoaiMon.BackColor = Color.FromArgb(0, 48, 73);
            btn_Tinh.BackColor = Color.FromArgb(0, 48, 73);
            btn_Huyen.BackColor = Color.FromArgb(0, 48, 73);
            btn_Khoa.BackColor = Color.FromArgb(0, 48, 73);
            btn_Nganh.BackColor = Color.FromArgb(0, 48, 73);
        }

        private void btn_ThuHP_Click(object sender, EventArgs e)
        {
            loadForm(new fTuition_fee(ID));
            btn_dashboard.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_ChuongTrinhHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonhocMo.BackColor = Color.FromArgb(0, 48, 73);
            btn_SinhVien.BackColor = Color.FromArgb(0, 48, 73);
            btn_DKHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_ThuHP.BackColor = Color.FromArgb(0, 70, 107);
            btn_BaoCao.BackColor = Color.FromArgb(0, 48, 73);
            btn_DTUuTien.BackColor = Color.FromArgb(0, 48, 73);

            btn_HocKiNamHoc.BackColor = Color.FromArgb(0, 48, 73);
            btnUser.BackColor = Color.FromArgb(0, 48, 73);
            btn_LoaiMon.BackColor = Color.FromArgb(0, 48, 73);
            btn_Tinh.BackColor = Color.FromArgb(0, 48, 73);
            btn_Huyen.BackColor = Color.FromArgb(0, 48, 73);
            btn_Khoa.BackColor = Color.FromArgb(0, 48, 73);
            btn_Nganh.BackColor = Color.FromArgb(0, 48, 73);
        }

        private void btn_DKHP_Click(object sender, EventArgs e)
        {
            fRegisterCourse.ShowFormRegisterUpdateRequested += GetRegisterID;
            fRegisterCourse.ShowFormRegisterViewRequested += GetRegisterID;
            fRegisterCourse.ShowFormRegisterAddRequested += FormRegister_ShowFormAddRegisterRequested;
            fRegisterCourse.ShowFormRegisterUpdateRequested += FormRegister_ShowFormUpdateRegisterRequested;
            fRegisterCourse.ShowFormRegisterViewRequested += FormRegister_ShowFormViewRegisterRequested;
            loadForm(fRegisterCourse);
            btn_dashboard.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_ChuongTrinhHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonhocMo.BackColor = Color.FromArgb(0, 48, 73);
            btn_SinhVien.BackColor = Color.FromArgb(0, 48, 73);
            btn_DKHP.BackColor = Color.FromArgb(0, 70, 107);
            btn_ThuHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_BaoCao.BackColor = Color.FromArgb(0, 48, 73);
            btn_DTUuTien.BackColor = Color.FromArgb(0, 48, 73);
            btn_HocKiNamHoc.BackColor = Color.FromArgb(0, 48, 73);
            btnUser.BackColor = Color.FromArgb(0, 48, 73);
            btn_LoaiMon.BackColor = Color.FromArgb(0, 48, 73);
            btn_Tinh.BackColor = Color.FromArgb(0, 48, 73);
            btn_Huyen.BackColor = Color.FromArgb(0, 48, 73);
            btn_Khoa.BackColor = Color.FromArgb(0, 48, 73);
            btn_Nganh.BackColor = Color.FromArgb(0, 48, 73);
        }

        private void btn_ChuongTrinhHoc_Click(object sender, EventArgs e)
        {
            fStudyProgram.ShowFormStudyProgramUpdateRequested += GetFacultiesAndMajor;
            fStudyProgram.ShowFormStudyProgramViewRequested += GetFacultiesAndMajor;
            fStudyProgram.ShowFormStudyProgramAddRequested += FormStudyProgram_ShowFormAddStudyProgramRequested;
            fStudyProgram.ShowFormStudyProgramUpdateRequested += FormStudyProgram_ShowFormUpdateStudyProgramRequested;
            fStudyProgram.ShowFormStudyProgramViewRequested += FormStudyProgram_ShowFormViewStudyProgramRequested;
            loadForm(fStudyProgram);
            btn_dashboard.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_ChuongTrinhHoc.BackColor = Color.FromArgb(0, 70, 107);
            btn_MonhocMo.BackColor = Color.FromArgb(0, 48, 73);
            btn_SinhVien.BackColor = Color.FromArgb(0, 48, 73);
            btn_DKHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_ThuHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_BaoCao.BackColor = Color.FromArgb(0, 48, 73);
            btn_DTUuTien.BackColor = Color.FromArgb(0, 48, 73);
            btn_HocKiNamHoc.BackColor = Color.FromArgb(0, 48, 73);
            btnUser.BackColor = Color.FromArgb(0, 48, 73);
            btn_LoaiMon.BackColor = Color.FromArgb(0, 48, 73);
            btn_Tinh.BackColor = Color.FromArgb(0, 48, 73);
            btn_Huyen.BackColor = Color.FromArgb(0, 48, 73);
            btn_Khoa.BackColor = Color.FromArgb(0, 48, 73);
            btn_Nganh.BackColor = Color.FromArgb(0, 48, 73);
        }
        private void btn_LoaiMon_Click(object sender, EventArgs e)
        {
            loadForm(new fSubjectType(ID));
            btnUser.BackColor = Color.FromArgb(0, 48, 73);
            btn_dashboard.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_ChuongTrinhHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonhocMo.BackColor = Color.FromArgb(0, 48, 73);
            btn_SinhVien.BackColor = Color.FromArgb(0, 48, 73);
            btn_DKHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_ThuHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_BaoCao.BackColor = Color.FromArgb(0, 48, 73);
            btn_DTUuTien.BackColor = Color.FromArgb(0, 48, 73);
            btn_HocKiNamHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_LoaiMon.BackColor = Color.FromArgb(0, 70, 107);
            btn_Tinh.BackColor = Color.FromArgb(0, 48, 73);
            btn_Huyen.BackColor = Color.FromArgb(0, 48, 73);
            btn_Khoa.BackColor = Color.FromArgb(0, 48, 73);
            btn_Nganh.BackColor = Color.FromArgb(0, 48, 73);
        }
        private void btn_Khoa_Click(object sender, EventArgs e)
        {
            loadForm(new fFaculties(ID));
            btnUser.BackColor = Color.FromArgb(0, 48, 73);
            btn_dashboard.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_ChuongTrinhHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonhocMo.BackColor = Color.FromArgb(0, 48, 73);
            btn_SinhVien.BackColor = Color.FromArgb(0, 48, 73);
            btn_DKHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_ThuHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_BaoCao.BackColor = Color.FromArgb(0, 48, 73);
            btn_DTUuTien.BackColor = Color.FromArgb(0, 48, 73);
            btn_HocKiNamHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_LoaiMon.BackColor = Color.FromArgb(0, 48, 73);
            btn_Tinh.BackColor = Color.FromArgb(0, 48, 73);
            btn_Huyen.BackColor = Color.FromArgb(0, 48, 73);
            btn_Khoa.BackColor = Color.FromArgb(0, 70, 107);
            btn_Nganh.BackColor = Color.FromArgb(0, 48, 73);
        }

        private void btn_Nganh_Click(object sender, EventArgs e)
        {
            loadForm(new fMajor(ID));
            btnUser.BackColor = Color.FromArgb(0, 48, 73);
            btn_dashboard.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_ChuongTrinhHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonhocMo.BackColor = Color.FromArgb(0, 48, 73);
            btn_SinhVien.BackColor = Color.FromArgb(0, 48, 73);
            btn_DKHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_ThuHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_BaoCao.BackColor = Color.FromArgb(0, 48, 73);
            btn_DTUuTien.BackColor = Color.FromArgb(0, 48, 73);
            btn_HocKiNamHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_LoaiMon.BackColor = Color.FromArgb(0, 48, 73);
            btn_Tinh.BackColor = Color.FromArgb(0, 48, 73);
            btn_Huyen.BackColor = Color.FromArgb(0, 48, 73);
            btn_Khoa.BackColor = Color.FromArgb(0, 48, 73);
            btn_Nganh.BackColor = Color.FromArgb(0, 70, 107);
        }

        private void btn_Tinh_Click(object sender, EventArgs e)
        {
            loadForm(new fProvince(ID));
            btnUser.BackColor = Color.FromArgb(0, 48, 73);
            btn_dashboard.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_ChuongTrinhHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonhocMo.BackColor = Color.FromArgb(0, 48, 73);
            btn_SinhVien.BackColor = Color.FromArgb(0, 48, 73);
            btn_DKHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_ThuHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_BaoCao.BackColor = Color.FromArgb(0, 48, 73);
            btn_DTUuTien.BackColor = Color.FromArgb(0, 48, 73);
            btn_HocKiNamHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_LoaiMon.BackColor = Color.FromArgb(0, 48, 73);
            btn_Tinh.BackColor = Color.FromArgb(0, 70, 107);
            btn_Huyen.BackColor = Color.FromArgb(0, 48, 73);
            btn_Khoa.BackColor = Color.FromArgb(0, 48, 73);
            btn_Nganh.BackColor = Color.FromArgb(0, 48, 73);
        }

        private void btn_Huyen_Click(object sender, EventArgs e)
        {
            loadForm(new fDistrict(ID));
            btnUser.BackColor = Color.FromArgb(0, 48, 73);
            btn_dashboard.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_ChuongTrinhHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_MonhocMo.BackColor = Color.FromArgb(0, 48, 73);
            btn_SinhVien.BackColor = Color.FromArgb(0, 48, 73);
            btn_DKHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_ThuHP.BackColor = Color.FromArgb(0, 48, 73);
            btn_BaoCao.BackColor = Color.FromArgb(0, 48, 73);
            btn_DTUuTien.BackColor = Color.FromArgb(0, 48, 73);
            btn_HocKiNamHoc.BackColor = Color.FromArgb(0, 48, 73);
            btn_LoaiMon.BackColor = Color.FromArgb(0, 48, 73);
            btn_Tinh.BackColor = Color.FromArgb(0, 48, 73);
            btn_Huyen.BackColor = Color.FromArgb(0, 70, 107);
            btn_Khoa.BackColor = Color.FromArgb(0, 48, 73);
            btn_Nganh.BackColor = Color.FromArgb(0, 48, 73);
        }
        // Ham lien quan
        private void Formsubject_ShowFormAddOpenSubjectRequested(object sender, EventArgs e)
        {
            fAddOpenSubject fAddOpenSubject = new fAddOpenSubject();
            loadForm(fAddOpenSubject);
            fAddOpenSubject.ExistFormAddOpenSubjectRequested += Formsubject_ReloadOpenSubjectRequested;
            fOpenSubject.DefaultLoadOpenSubjectList();
        }

        private void Formsubject_ExistFormAddOpenSubjectRequested(object sender, EventArgs e)
        {
            fOpenSubject = new fOpenSubject(ID);
            loadForm(fOpenSubject);
        }

        private void Formsubject_ShowFormViewOpenSubjectRequested(object sender, EventArgs e)
        {
            fViewOpenSubject fViewOpenSubject = new fViewOpenSubject(SchoolYear, Semester);
            loadForm(fViewOpenSubject);
            fViewOpenSubject.ExistFormViewOpenSubjectRequested += Formsubject_ReloadOpenSubjectRequested;
        }
        private void Formsubject_ShowFormUpdateOpenSubjectRequested(object sender, EventArgs e)
        {
            fUpdateOpenSubject fUpdateOpenSubject = new fUpdateOpenSubject(SchoolYear, Semester);
            loadForm(fUpdateOpenSubject);
            fUpdateOpenSubject.ExistFormUpdateOpenSubjectRequested += Formsubject_ReloadOpenSubjectRequested;
        }
        private void Formsubject_ReloadOpenSubjectRequested(object sender, EventArgs e)
        {
            fOpenSubject = new fOpenSubject(ID);
            fOpenSubject.ShowFormUpdateOpenSubjectRequested += GetSchoolYearANDSemester;
            fOpenSubject.ShowFormUpdateOpenSubjectRequested += Formsubject_ShowFormUpdateOpenSubjectRequested;
            fOpenSubject.ShowFormViewOpenSubjectRequested += GetSchoolYearANDSemester;
            fOpenSubject.ShowFormViewOpenSubjectRequested += Formsubject_ShowFormViewOpenSubjectRequested;
            fOpenSubject.ShowFormAddOpenSubjectRequested += Formsubject_ShowFormAddOpenSubjectRequested;
            loadForm(fOpenSubject);
        }

        private void GetSchoolYearANDSemester(object sender, EventArgs e)
        {
            SchoolYear = fOpenSubject.NamHoc;
            Semester = fOpenSubject.HocKy;
        }

        private void FormStudyProgram_ShowFormAddStudyProgramRequested(object sender, EventArgs e)
        {
            fAddStudyProgram fAddStuPro = new fAddStudyProgram();
            loadForm(fAddStuPro);
            fAddStuPro.ExitFormAddStudyProgramRequested += Formsubject_ReloadStudyProgramRequested;
        }

        private void Formsubject_ExitFormAddStudyProgramRequested(object sender, EventArgs e)
        {
            fStudyProgram = new fStudyProgram(ID);
            loadForm(fStudyProgram);
        }

        private void FormStudyProgram_ShowFormUpdateStudyProgramRequested(object sender, EventArgs e)
        {
            fUpdateStudyProgram fUpdateStuPro = new fUpdateStudyProgram(Faculties, Major);
            loadForm(fUpdateStuPro);
            fUpdateStuPro.ExitFormUpdateStudyProgramRequested += Formsubject_ReloadStudyProgramRequested;
        }

        private void Formsubject_ExitFormUpdateStudyProgramRequested(object sender, EventArgs e)
        {
            fStudyProgram = new fStudyProgram(ID);
            loadForm(fStudyProgram);
        }

        private void FormStudyProgram_ShowFormViewStudyProgramRequested(object sender, EventArgs e)
        {
            fViewStudyProgram fViewStuPro = new fViewStudyProgram(Faculties, Major);
            loadForm(fViewStuPro);
            fViewStuPro.ExitFormViewStudyProgramRequested += Formsubject_ReloadStudyProgramRequested;
        }

        private void Formsubject_ExitFormViewStudyProgramRequested(object sender, EventArgs e)
        {
            fStudyProgram = new fStudyProgram(ID);
            loadForm(fStudyProgram);
        }

        private void Formsubject_ReloadStudyProgramRequested(object sender, EventArgs e)
        {
            fStudyProgram = new fStudyProgram(ID);
            fStudyProgram.ShowFormStudyProgramViewRequested += GetFacultiesAndMajor;
            fStudyProgram.ShowFormStudyProgramViewRequested += FormStudyProgram_ShowFormViewStudyProgramRequested;
            fStudyProgram.ShowFormStudyProgramUpdateRequested += GetFacultiesAndMajor;
            fStudyProgram.ShowFormStudyProgramUpdateRequested += FormStudyProgram_ShowFormUpdateStudyProgramRequested;
            fStudyProgram.ShowFormStudyProgramAddRequested += FormStudyProgram_ShowFormAddStudyProgramRequested;
            loadForm(fStudyProgram);
        }

        private void GetFacultiesAndMajor(object sender, EventArgs e)
        {
            Faculties = fStudyProgram.FacultiesValue;
            Major = fStudyProgram.MajorValue;
        }

        private void FormRegister_ShowFormAddRegisterRequested(object sender, EventArgs e)
        {
            fAddRegister fAddRegis = new fAddRegister();
            loadForm(fAddRegis);
            fAddRegis.ExitFormAddRegisterRequested += Formsubject_ReloadRegisterRequested;
        }

        private void Formsubject_ExitFormAddRegisterRequested(object sender, EventArgs e)
        {
            fRegisterCourse = new fRegisterCourse(ID);
            loadForm(fRegisterCourse);
        }

        private void FormRegister_ShowFormUpdateRegisterRequested(object sender, EventArgs e)
        {
            fUpdateRegister fUpdateRegis = new fUpdateRegister(RegisterID);
            loadForm(fUpdateRegis);
            fUpdateRegis.ExitFormUpdateRegisterRequested += Formsubject_ReloadRegisterRequested;
        }

        private void Formsubject_ExitFormUpdateRegisterRequested(object sender, EventArgs e)
        {
            fRegisterCourse = new fRegisterCourse(ID);
            loadForm(fRegisterCourse);
        }

        private void FormRegister_ShowFormViewRegisterRequested(object sender, EventArgs e)
        {
            fViewRegister fViewRegis = new fViewRegister(RegisterID);
            loadForm(fViewRegis);
            fViewRegis.ExitFormViewRegisterRequested += Formsubject_ReloadRegisterRequested;
        }

        private void Formsubject_ExitFormViewRegisterRequested(object sender, EventArgs e)
        {
            fRegisterCourse = new fRegisterCourse(ID);
            loadForm(fRegisterCourse);
        }

        private void Formsubject_ReloadRegisterRequested(object sender, EventArgs e)
        {
            fRegisterCourse = new fRegisterCourse(ID);
            fRegisterCourse.ShowFormRegisterViewRequested += GetRegisterID;
            fRegisterCourse.ShowFormRegisterViewRequested += FormRegister_ShowFormViewRegisterRequested;
            fRegisterCourse.ShowFormRegisterUpdateRequested += GetRegisterID;
            fRegisterCourse.ShowFormRegisterUpdateRequested += FormRegister_ShowFormUpdateRegisterRequested;
            fRegisterCourse.ShowFormRegisterAddRequested += FormRegister_ShowFormAddRegisterRequested;
            loadForm(fRegisterCourse);
        }

        private void GetRegisterID(object sender, EventArgs e)
        {
            RegisterID = fRegisterCourse.maPhieu;
        }
        
    }
}
