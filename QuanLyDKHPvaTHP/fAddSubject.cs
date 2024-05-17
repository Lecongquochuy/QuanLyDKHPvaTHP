namespace QuanLyDKHPvaTHP
{
    public partial class fAddSubject : Form
    {
        public fAddSubject()
        {
            InitializeComponent();
        }

        private void btn_AddSub_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm môn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
