namespace QuanLyDKHPvaTHP
{
    partial class fAddFaculties
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
            labelAddFaculties = new Label();
            pInfoAddsub = new Panel();
            panel1 = new Panel();
            labelAddMaKhoa = new Label();
            label1 = new Label();
            btn_AddFaculties = new Button();
            panelInput = new Panel();
            textBoxAddKhoa = new TextBox();
            labelInpTinh = new Label();
            panelContentAddSubject = new Panel();
            panelTitleaddSubject.SuspendLayout();
            pInfoAddsub.SuspendLayout();
            panel1.SuspendLayout();
            panelInput.SuspendLayout();
            panelContentAddSubject.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitleaddSubject
            // 
            panelTitleaddSubject.BackColor = Color.FromArgb(21, 44, 112);
            panelTitleaddSubject.Controls.Add(labelAddFaculties);
            panelTitleaddSubject.Location = new Point(-2, 4);
            panelTitleaddSubject.Margin = new Padding(3, 4, 3, 4);
            panelTitleaddSubject.Name = "panelTitleaddSubject";
            panelTitleaddSubject.Size = new Size(1620, 108);
            panelTitleaddSubject.TabIndex = 0;
            // 
            // labelAddFaculties
            // 
            labelAddFaculties.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAddFaculties.AutoSize = true;
            labelAddFaculties.Font = new Font("Times New Roman", 30.0000019F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAddFaculties.ForeColor = Color.Transparent;
            labelAddFaculties.Location = new Point(566, 16);
            labelAddFaculties.Name = "labelAddFaculties";
            labelAddFaculties.Size = new Size(501, 81);
            labelAddFaculties.TabIndex = 0;
            labelAddFaculties.Text = "Thông tin khoa";
            labelAddFaculties.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pInfoAddsub
            // 
            pInfoAddsub.Controls.Add(panel1);
            pInfoAddsub.Controls.Add(btn_AddFaculties);
            pInfoAddsub.Controls.Add(panelInput);
            pInfoAddsub.ForeColor = Color.FromArgb(0, 0, 0, 16);
            pInfoAddsub.Location = new Point(58, 36);
            pInfoAddsub.Margin = new Padding(3, 4, 3, 4);
            pInfoAddsub.Name = "pInfoAddsub";
            pInfoAddsub.Size = new Size(1498, 310);
            pInfoAddsub.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelAddMaKhoa);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(111, 28);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 128);
            panel1.TabIndex = 2;
            // 
            // labelAddMaKhoa
            // 
            labelAddMaKhoa.BackColor = SystemColors.ButtonFace;
            labelAddMaKhoa.BorderStyle = BorderStyle.FixedSingle;
            labelAddMaKhoa.FlatStyle = FlatStyle.System;
            labelAddMaKhoa.Font = new Font("Times New Roman", 15.000001F);
            labelAddMaKhoa.Location = new Point(32, 64);
            labelAddMaKhoa.Margin = new Padding(4, 0, 4, 0);
            labelAddMaKhoa.Name = "labelAddMaKhoa";
            labelAddMaKhoa.Size = new Size(516, 53);
            labelAddMaKhoa.TabIndex = 2;
            labelAddMaKhoa.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.000001F);
            label1.ForeColor = Color.FromArgb(16, 156, 241);
            label1.Location = new Point(27, 16);
            label1.Name = "label1";
            label1.Size = new Size(145, 41);
            label1.TabIndex = 0;
            label1.Text = "Mã khoa";
            // 
            // btn_AddFaculties
            // 
            btn_AddFaculties.BackColor = Color.FromArgb(21, 44, 112);
            btn_AddFaculties.Cursor = Cursors.Hand;
            btn_AddFaculties.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddFaculties.ForeColor = Color.White;
            btn_AddFaculties.Location = new Point(844, 198);
            btn_AddFaculties.Margin = new Padding(3, 4, 3, 4);
            btn_AddFaculties.Name = "btn_AddFaculties";
            btn_AddFaculties.Size = new Size(520, 80);
            btn_AddFaculties.TabIndex = 3;
            btn_AddFaculties.Text = "Thêm";
            btn_AddFaculties.UseVisualStyleBackColor = false;
            btn_AddFaculties.Click += btn_AddFaculties_Click;
            // 
            // panelInput
            // 
            panelInput.Controls.Add(textBoxAddKhoa);
            panelInput.Controls.Add(labelInpTinh);
            panelInput.Location = new Point(813, 28);
            panelInput.Margin = new Padding(3, 4, 3, 4);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(579, 128);
            panelInput.TabIndex = 0;
            // 
            // textBoxAddKhoa
            // 
            textBoxAddKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAddKhoa.Font = new Font("Times New Roman", 15.000001F);
            textBoxAddKhoa.ForeColor = SystemColors.WindowText;
            textBoxAddKhoa.Location = new Point(32, 64);
            textBoxAddKhoa.Margin = new Padding(12, 12, 12, 12);
            textBoxAddKhoa.Name = "textBoxAddKhoa";
            textBoxAddKhoa.Size = new Size(520, 48);
            textBoxAddKhoa.TabIndex = 1;
            // 
            // labelInpTinh
            // 
            labelInpTinh.AutoSize = true;
            labelInpTinh.Font = new Font("Times New Roman", 15.000001F);
            labelInpTinh.ForeColor = Color.FromArgb(16, 156, 241);
            labelInpTinh.Location = new Point(27, 16);
            labelInpTinh.Name = "labelInpTinh";
            labelInpTinh.Size = new Size(150, 41);
            labelInpTinh.TabIndex = 0;
            labelInpTinh.Text = "Tên khoa";
            // 
            // panelContentAddSubject
            // 
            panelContentAddSubject.BackColor = Color.White;
            panelContentAddSubject.Controls.Add(pInfoAddsub);
            panelContentAddSubject.Location = new Point(2, 116);
            panelContentAddSubject.Margin = new Padding(3, 4, 3, 4);
            panelContentAddSubject.Name = "panelContentAddSubject";
            panelContentAddSubject.Size = new Size(1620, 344);
            panelContentAddSubject.TabIndex = 1;
            // 
            // fAddFaculties
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1620, 470);
            Controls.Add(panelContentAddSubject);
            Controls.Add(panelTitleaddSubject);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fAddFaculties";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += fAddFaculties_FormClosing;
            panelTitleaddSubject.ResumeLayout(false);
            panelTitleaddSubject.PerformLayout();
            pInfoAddsub.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            panelContentAddSubject.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleaddSubject;
        private Label labelAddFaculties;
        private Panel pTitleInforAddSub;
        private Label laTitleInfoAddPri;
        private Panel pInfoAddsub;
        private Button btn_AddFaculties;
        private Panel panelInput;
        private TextBox textBoxAddKhoa;
        private Label labelInpTinh;
        private Panel panelContentAddSubject;
        private Panel panel1;
        private Label label1;
        private Label labelAddMaKhoa;
    }
}