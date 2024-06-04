namespace QuanLyDKHPvaTHP
{
    partial class fAddMajor
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
            labelAddDistrict = new Label();
            pInfoAddsub = new Panel();
            panel2 = new Panel();
            cbBoxAddKhoa = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            labelAddMaNganh = new Label();
            label1 = new Label();
            btn_AddMajor = new Button();
            panelInput = new Panel();
            textBoxAddNganh = new TextBox();
            labelInpTinh = new Label();
            panelContentAddSubject = new Panel();
            panelTitleaddSubject.SuspendLayout();
            pInfoAddsub.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panelInput.SuspendLayout();
            panelContentAddSubject.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitleaddSubject
            // 
            panelTitleaddSubject.BackColor = Color.FromArgb(21, 44, 112);
            panelTitleaddSubject.Controls.Add(labelAddDistrict);
            panelTitleaddSubject.Location = new Point(-2, 4);
            panelTitleaddSubject.Margin = new Padding(3, 4, 3, 4);
            panelTitleaddSubject.Name = "panelTitleaddSubject";
            panelTitleaddSubject.Size = new Size(1620, 108);
            panelTitleaddSubject.TabIndex = 0;
            // 
            // labelAddDistrict
            // 
            labelAddDistrict.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAddDistrict.AutoSize = true;
            labelAddDistrict.Font = new Font("Times New Roman", 30.0000019F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAddDistrict.ForeColor = Color.Transparent;
            labelAddDistrict.Location = new Point(494, 16);
            labelAddDistrict.Name = "labelAddDistrict";
            labelAddDistrict.Size = new Size(664, 81);
            labelAddDistrict.TabIndex = 0;
            labelAddDistrict.Text = "Thông tin ngành học";
            labelAddDistrict.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pInfoAddsub
            // 
            pInfoAddsub.Controls.Add(panel2);
            pInfoAddsub.Controls.Add(panel1);
            pInfoAddsub.Controls.Add(btn_AddMajor);
            pInfoAddsub.Controls.Add(panelInput);
            pInfoAddsub.ForeColor = Color.FromArgb(0, 0, 0, 16);
            pInfoAddsub.Location = new Point(58, 36);
            pInfoAddsub.Margin = new Padding(3, 4, 3, 4);
            pInfoAddsub.Name = "pInfoAddsub";
            pInfoAddsub.Size = new Size(1498, 387);
            pInfoAddsub.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbBoxAddKhoa);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(813, 28);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 128);
            panel2.TabIndex = 2;
            // 
            // cbBoxAddKhoa
            // 
            cbBoxAddKhoa.Font = new Font("Times New Roman", 15.000001F);
            cbBoxAddKhoa.FormattingEnabled = true;
            cbBoxAddKhoa.Location = new Point(32, 64);
            cbBoxAddKhoa.Margin = new Padding(4, 4, 4, 4);
            cbBoxAddKhoa.Name = "cbBoxAddKhoa";
            cbBoxAddKhoa.Size = new Size(516, 48);
            cbBoxAddKhoa.TabIndex = 2;
            cbBoxAddKhoa.SelectedIndexChanged += cbBoxAddTinh_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.000001F);
            label2.ForeColor = Color.FromArgb(16, 156, 241);
            label2.Location = new Point(27, 16);
            label2.Name = "label2";
            label2.Size = new Size(150, 41);
            label2.TabIndex = 0;
            label2.Text = "Tên khoa";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelAddMaNganh);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(111, 28);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 128);
            panel1.TabIndex = 2;
            // 
            // labelAddMaNganh
            // 
            labelAddMaNganh.BackColor = SystemColors.ButtonFace;
            labelAddMaNganh.BorderStyle = BorderStyle.FixedSingle;
            labelAddMaNganh.FlatStyle = FlatStyle.System;
            labelAddMaNganh.Font = new Font("Times New Roman", 15.000001F);
            labelAddMaNganh.Location = new Point(32, 64);
            labelAddMaNganh.Margin = new Padding(4, 0, 4, 0);
            labelAddMaNganh.Name = "labelAddMaNganh";
            labelAddMaNganh.Size = new Size(516, 53);
            labelAddMaNganh.TabIndex = 2;
            labelAddMaNganh.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.000001F);
            label1.ForeColor = Color.FromArgb(16, 156, 241);
            label1.Location = new Point(27, 16);
            label1.Name = "label1";
            label1.Size = new Size(159, 41);
            label1.TabIndex = 0;
            label1.Text = "Mã ngành";
            // 
            // btn_AddMajor
            // 
            btn_AddMajor.BackColor = Color.FromArgb(21, 44, 112);
            btn_AddMajor.Cursor = Cursors.Hand;
            btn_AddMajor.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddMajor.ForeColor = Color.White;
            btn_AddMajor.Location = new Point(846, 273);
            btn_AddMajor.Margin = new Padding(3, 4, 3, 4);
            btn_AddMajor.Name = "btn_AddMajor";
            btn_AddMajor.Size = new Size(520, 80);
            btn_AddMajor.TabIndex = 3;
            btn_AddMajor.Text = "Thêm";
            btn_AddMajor.UseVisualStyleBackColor = false;
            btn_AddMajor.Click += btn_AddMajor_Click;
            // 
            // panelInput
            // 
            panelInput.Controls.Add(textBoxAddNganh);
            panelInput.Controls.Add(labelInpTinh);
            panelInput.Location = new Point(111, 224);
            panelInput.Margin = new Padding(3, 4, 3, 4);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(579, 128);
            panelInput.TabIndex = 0;
            // 
            // textBoxAddNganh
            // 
            textBoxAddNganh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAddNganh.Font = new Font("Times New Roman", 15.000001F);
            textBoxAddNganh.ForeColor = SystemColors.WindowText;
            textBoxAddNganh.Location = new Point(32, 64);
            textBoxAddNganh.Margin = new Padding(12, 12, 12, 12);
            textBoxAddNganh.Name = "textBoxAddNganh";
            textBoxAddNganh.Size = new Size(520, 48);
            textBoxAddNganh.TabIndex = 1;
            // 
            // labelInpTinh
            // 
            labelInpTinh.AutoSize = true;
            labelInpTinh.Font = new Font("Times New Roman", 15.000001F);
            labelInpTinh.ForeColor = Color.FromArgb(16, 156, 241);
            labelInpTinh.Location = new Point(27, 16);
            labelInpTinh.Name = "labelInpTinh";
            labelInpTinh.Size = new Size(164, 41);
            labelInpTinh.TabIndex = 0;
            labelInpTinh.Text = "Tên ngành";
            // 
            // panelContentAddSubject
            // 
            panelContentAddSubject.BackColor = Color.White;
            panelContentAddSubject.Controls.Add(pInfoAddsub);
            panelContentAddSubject.Location = new Point(2, 116);
            panelContentAddSubject.Margin = new Padding(3, 4, 3, 4);
            panelContentAddSubject.Name = "panelContentAddSubject";
            panelContentAddSubject.Size = new Size(1620, 426);
            panelContentAddSubject.TabIndex = 1;
            // 
            // fAddMajor
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1620, 538);
            Controls.Add(panelContentAddSubject);
            Controls.Add(panelTitleaddSubject);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fAddMajor";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += fAddMajor_FormClosing;
            panelTitleaddSubject.ResumeLayout(false);
            panelTitleaddSubject.PerformLayout();
            pInfoAddsub.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            panelContentAddSubject.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleaddSubject;
        private Label labelAddDistrict;
        private Panel pTitleInforAddSub;
        private Label laTitleInfoAddPri;
        private Panel pInfoAddsub;
        private Button btn_AddMajor;
        private Panel panelInput;
        private TextBox textBoxAddNganh;
        private Label labelInpTinh;
        private Panel panelContentAddSubject;
        private Panel panel1;
        private Label label1;
        private Label labelAddMaNganh;
        private Panel panel2;
        private ComboBox cbBoxAddKhoa;
        private Label label2;
    }
}