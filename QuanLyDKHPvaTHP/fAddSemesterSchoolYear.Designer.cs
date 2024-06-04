namespace QuanLyDKHPvaTHP
{
    partial class fAddSemesterSchoolYear
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTitleaddSubject = new Panel();
            labelAddSSY = new Label();
            panelContentAddSubject = new Panel();
            pInfoAddsub = new Panel();
            panel2 = new Panel();
            dTPickerAddTHDHP = new DateTimePicker();
            labelInpTHDHP = new Label();
            btn_AddSSY = new Button();
            panel1 = new Panel();
            cbBoxAddHocKy = new ComboBox();
            labelInpHocKy = new Label();
            panelInput = new Panel();
            cbBoxAddNamHoc = new ComboBox();
            labelInpNamHoc = new Label();
            panelTitleaddSubject.SuspendLayout();
            panelContentAddSubject.SuspendLayout();
            pInfoAddsub.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panelInput.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitleaddSubject
            // 
            panelTitleaddSubject.BackColor = Color.FromArgb(21, 44, 112);
            panelTitleaddSubject.Controls.Add(labelAddSSY);
            panelTitleaddSubject.Location = new Point(-2, 4);
            panelTitleaddSubject.Margin = new Padding(3, 4, 3, 4);
            panelTitleaddSubject.Name = "panelTitleaddSubject";
            panelTitleaddSubject.Size = new Size(1620, 108);
            panelTitleaddSubject.TabIndex = 0;
            // 
            // labelAddSSY
            // 
            labelAddSSY.Dock = DockStyle.Top;
            labelAddSSY.Font = new Font("Times New Roman", 30.0000019F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAddSSY.ForeColor = Color.Transparent;
            labelAddSSY.Location = new Point(0, 0);
            labelAddSSY.Name = "labelAddSSY";
            labelAddSSY.Size = new Size(1620, 108);
            labelAddSSY.TabIndex = 0;
            labelAddSSY.Text = "Thông tin học kỳ - năm học";
            labelAddSSY.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContentAddSubject
            // 
            panelContentAddSubject.BackColor = Color.White;
            panelContentAddSubject.Controls.Add(pInfoAddsub);
            panelContentAddSubject.Location = new Point(2, 116);
            panelContentAddSubject.Margin = new Padding(3, 4, 3, 4);
            panelContentAddSubject.Name = "panelContentAddSubject";
            panelContentAddSubject.Size = new Size(1620, 429);
            panelContentAddSubject.TabIndex = 1;
            // 
            // pInfoAddsub
            // 
            pInfoAddsub.Controls.Add(panel2);
            pInfoAddsub.Controls.Add(btn_AddSSY);
            pInfoAddsub.Controls.Add(panel1);
            pInfoAddsub.Controls.Add(panelInput);
            pInfoAddsub.Location = new Point(63, 42);
            pInfoAddsub.Margin = new Padding(3, 4, 3, 4);
            pInfoAddsub.Name = "pInfoAddsub";
            pInfoAddsub.Size = new Size(1498, 298);
            pInfoAddsub.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dTPickerAddTHDHP);
            panel2.Controls.Add(labelInpTHDHP);
            panel2.Location = new Point(146, 156);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 128);
            panel2.TabIndex = 2;
            // 
            // dTPickerAddTHDHP
            // 
            dTPickerAddTHDHP.Font = new Font("Times New Roman", 15.000001F);
            dTPickerAddTHDHP.Location = new Point(31, 64);
            dTPickerAddTHDHP.Margin = new Padding(5, 6, 5, 6);
            dTPickerAddTHDHP.Name = "dTPickerAddTHDHP";
            dTPickerAddTHDHP.Size = new Size(520, 48);
            dTPickerAddTHDHP.TabIndex = 4;
            // 
            // labelInpTHDHP
            // 
            labelInpTHDHP.AutoSize = true;
            labelInpTHDHP.Font = new Font("Times New Roman", 15.000001F);
            labelInpTHDHP.ForeColor = Color.FromArgb(16, 156, 241);
            labelInpTHDHP.Location = new Point(27, 16);
            labelInpTHDHP.Name = "labelInpTHDHP";
            labelInpTHDHP.Size = new Size(339, 41);
            labelInpTHDHP.TabIndex = 0;
            labelInpTHDHP.Text = "Thời hạn đóng học phí";
            // 
            // btn_AddSSY
            // 
            btn_AddSSY.BackColor = Color.FromArgb(21, 44, 112);
            btn_AddSSY.Cursor = Cursors.Hand;
            btn_AddSSY.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddSSY.ForeColor = Color.White;
            btn_AddSSY.Location = new Point(813, 198);
            btn_AddSSY.Margin = new Padding(3, 4, 3, 4);
            btn_AddSSY.Name = "btn_AddSSY";
            btn_AddSSY.Size = new Size(521, 80);
            btn_AddSSY.TabIndex = 3;
            btn_AddSSY.Text = "Thêm";
            btn_AddSSY.UseVisualStyleBackColor = false;
            btn_AddSSY.Click += btn_AddSSY_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbBoxAddHocKy);
            panel1.Controls.Add(labelInpHocKy);
            panel1.Location = new Point(782, 20);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 128);
            panel1.TabIndex = 2;
            // 
            // cbBoxAddHocKy
            // 
            cbBoxAddHocKy.Font = new Font("Times New Roman", 15.000001F);
            cbBoxAddHocKy.FormattingEnabled = true;
            cbBoxAddHocKy.Location = new Point(31, 64);
            cbBoxAddHocKy.Margin = new Padding(5, 6, 5, 6);
            cbBoxAddHocKy.Name = "cbBoxAddHocKy";
            cbBoxAddHocKy.Size = new Size(520, 48);
            cbBoxAddHocKy.TabIndex = 3;
            // 
            // labelInpHocKy
            // 
            labelInpHocKy.AutoSize = true;
            labelInpHocKy.Font = new Font("Times New Roman", 15.000001F);
            labelInpHocKy.ForeColor = Color.FromArgb(16, 156, 241);
            labelInpHocKy.Location = new Point(27, 16);
            labelInpHocKy.Name = "labelInpHocKy";
            labelInpHocKy.Size = new Size(122, 41);
            labelInpHocKy.TabIndex = 0;
            labelInpHocKy.Text = "Học kỳ";
            // 
            // panelInput
            // 
            panelInput.Controls.Add(cbBoxAddNamHoc);
            panelInput.Controls.Add(labelInpNamHoc);
            panelInput.Location = new Point(146, 20);
            panelInput.Margin = new Padding(3, 4, 3, 4);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(579, 128);
            panelInput.TabIndex = 0;
            // 
            // cbBoxAddNamHoc
            // 
            cbBoxAddNamHoc.Font = new Font("Times New Roman", 15.000001F);
            cbBoxAddNamHoc.FormattingEnabled = true;
            cbBoxAddNamHoc.Location = new Point(31, 64);
            cbBoxAddNamHoc.Margin = new Padding(5, 6, 5, 6);
            cbBoxAddNamHoc.Name = "cbBoxAddNamHoc";
            cbBoxAddNamHoc.Size = new Size(520, 48);
            cbBoxAddNamHoc.TabIndex = 2;
            // 
            // labelInpNamHoc
            // 
            labelInpNamHoc.AutoSize = true;
            labelInpNamHoc.Font = new Font("Times New Roman", 15.000001F);
            labelInpNamHoc.ForeColor = Color.FromArgb(16, 156, 241);
            labelInpNamHoc.Location = new Point(27, 16);
            labelInpNamHoc.Name = "labelInpNamHoc";
            labelInpNamHoc.Size = new Size(148, 41);
            labelInpNamHoc.TabIndex = 0;
            labelInpNamHoc.Text = "Năm học";
            // 
            // fAddSemesterSchoolYear
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1620, 546);
            Controls.Add(panelContentAddSubject);
            Controls.Add(panelTitleaddSubject);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fAddSemesterSchoolYear";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm môn học";
            panelTitleaddSubject.ResumeLayout(false);
            panelContentAddSubject.ResumeLayout(false);
            pInfoAddsub.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleaddSubject;
        private Label labelAddSSY;
        private Panel panelContentAddSubject;
        private Panel pInfoAddsub;
        private Panel panelInput;
        private Label labelInpNamHoc;
        private Button btn_AddSSY;
        private Panel panel1;
        private Label labelInpHocKy;
        private Panel panel2;
        private Label labelInpTHDHP;
        private DateTimePicker dTPickerAddTHDHP;
        private ComboBox cbBoxAddHocKy;
        private ComboBox cbBoxAddNamHoc;
    }
}