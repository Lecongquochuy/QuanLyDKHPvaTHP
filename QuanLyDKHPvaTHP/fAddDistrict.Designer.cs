namespace QuanLyDKHPvaTHP
{
    partial class fAddDistrict
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
            panel3 = new Panel();
            ckBoxAddVSVX = new CheckBox();
            panel2 = new Panel();
            cbBoxAddTinh = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            labelAddMaHuyen = new Label();
            label1 = new Label();
            btn_AddDistrict = new Button();
            panelInput = new Panel();
            textBoxAddHuyen = new TextBox();
            labelInpTinh = new Label();
            panelContentAddSubject = new Panel();
            panelTitleaddSubject.SuspendLayout();
            pInfoAddsub.SuspendLayout();
            panel3.SuspendLayout();
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
            labelAddDistrict.Location = new Point(566, 16);
            labelAddDistrict.Name = "labelAddDistrict";
            labelAddDistrict.Size = new Size(536, 81);
            labelAddDistrict.TabIndex = 0;
            labelAddDistrict.Text = "Thông tin huyện";
            labelAddDistrict.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pInfoAddsub
            // 
            pInfoAddsub.Controls.Add(panel3);
            pInfoAddsub.Controls.Add(panel2);
            pInfoAddsub.Controls.Add(panel1);
            pInfoAddsub.Controls.Add(btn_AddDistrict);
            pInfoAddsub.Controls.Add(panelInput);
            pInfoAddsub.ForeColor = Color.FromArgb(0, 0, 0, 16);
            pInfoAddsub.Location = new Point(58, 36);
            pInfoAddsub.Margin = new Padding(3, 4, 3, 4);
            pInfoAddsub.Name = "pInfoAddsub";
            pInfoAddsub.Size = new Size(1498, 506);
            pInfoAddsub.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(ckBoxAddVSVX);
            panel3.Location = new Point(813, 224);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(579, 128);
            panel3.TabIndex = 3;
            // 
            // ckBoxAddVSVX
            // 
            ckBoxAddVSVX.AutoSize = true;
            ckBoxAddVSVX.Font = new Font("Times New Roman", 15.000001F);
            ckBoxAddVSVX.ForeColor = Color.FromArgb(16, 156, 241);
            ckBoxAddVSVX.Location = new Point(32, 64);
            ckBoxAddVSVX.Margin = new Padding(4, 4, 4, 4);
            ckBoxAddVSVX.Name = "ckBoxAddVSVX";
            ckBoxAddVSVX.Size = new Size(299, 45);
            ckBoxAddVSVX.TabIndex = 4;
            ckBoxAddVSVX.Text = "Vùng sâu vùng xa";
            ckBoxAddVSVX.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbBoxAddTinh);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(813, 28);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 128);
            panel2.TabIndex = 2;
            // 
            // cbBoxAddTinh
            // 
            cbBoxAddTinh.Font = new Font("Times New Roman", 15.000001F);
            cbBoxAddTinh.FormattingEnabled = true;
            cbBoxAddTinh.Location = new Point(32, 64);
            cbBoxAddTinh.Margin = new Padding(4, 4, 4, 4);
            cbBoxAddTinh.Name = "cbBoxAddTinh";
            cbBoxAddTinh.Size = new Size(516, 48);
            cbBoxAddTinh.TabIndex = 2;
            cbBoxAddTinh.SelectedIndexChanged += cbBoxAddTinh_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.000001F);
            label2.ForeColor = Color.FromArgb(16, 156, 241);
            label2.Location = new Point(27, 16);
            label2.Name = "label2";
            label2.Size = new Size(133, 41);
            label2.TabIndex = 0;
            label2.Text = "Tên tỉnh";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelAddMaHuyen);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(111, 28);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 128);
            panel1.TabIndex = 2;
            // 
            // labelAddMaHuyen
            // 
            labelAddMaHuyen.BackColor = SystemColors.ButtonFace;
            labelAddMaHuyen.BorderStyle = BorderStyle.FixedSingle;
            labelAddMaHuyen.FlatStyle = FlatStyle.System;
            labelAddMaHuyen.Font = new Font("Times New Roman", 15.000001F);
            labelAddMaHuyen.Location = new Point(32, 64);
            labelAddMaHuyen.Margin = new Padding(4, 0, 4, 0);
            labelAddMaHuyen.Name = "labelAddMaHuyen";
            labelAddMaHuyen.Size = new Size(516, 53);
            labelAddMaHuyen.TabIndex = 2;
            labelAddMaHuyen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.000001F);
            label1.ForeColor = Color.FromArgb(16, 156, 241);
            label1.Location = new Point(27, 16);
            label1.Name = "label1";
            label1.Size = new Size(167, 41);
            label1.TabIndex = 0;
            label1.Text = "Mã Huyện";
            // 
            // btn_AddDistrict
            // 
            btn_AddDistrict.BackColor = Color.FromArgb(21, 44, 112);
            btn_AddDistrict.Cursor = Cursors.Hand;
            btn_AddDistrict.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddDistrict.ForeColor = Color.White;
            btn_AddDistrict.Location = new Point(846, 404);
            btn_AddDistrict.Margin = new Padding(3, 4, 3, 4);
            btn_AddDistrict.Name = "btn_AddDistrict";
            btn_AddDistrict.Size = new Size(520, 80);
            btn_AddDistrict.TabIndex = 3;
            btn_AddDistrict.Text = "Thêm";
            btn_AddDistrict.UseVisualStyleBackColor = false;
            btn_AddDistrict.Click += btn_AddDistrict_Click;
            // 
            // panelInput
            // 
            panelInput.Controls.Add(textBoxAddHuyen);
            panelInput.Controls.Add(labelInpTinh);
            panelInput.Location = new Point(111, 224);
            panelInput.Margin = new Padding(3, 4, 3, 4);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(579, 128);
            panelInput.TabIndex = 0;
            // 
            // textBoxAddHuyen
            // 
            textBoxAddHuyen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAddHuyen.Font = new Font("Times New Roman", 15.000001F);
            textBoxAddHuyen.ForeColor = SystemColors.WindowText;
            textBoxAddHuyen.Location = new Point(32, 64);
            textBoxAddHuyen.Margin = new Padding(12, 12, 12, 12);
            textBoxAddHuyen.Name = "textBoxAddHuyen";
            textBoxAddHuyen.Size = new Size(520, 48);
            textBoxAddHuyen.TabIndex = 1;
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
            labelInpTinh.Text = "Tên huyện";
            // 
            // panelContentAddSubject
            // 
            panelContentAddSubject.BackColor = Color.White;
            panelContentAddSubject.Controls.Add(pInfoAddsub);
            panelContentAddSubject.Location = new Point(2, 116);
            panelContentAddSubject.Margin = new Padding(3, 4, 3, 4);
            panelContentAddSubject.Name = "panelContentAddSubject";
            panelContentAddSubject.Size = new Size(1620, 566);
            panelContentAddSubject.TabIndex = 1;
            // 
            // fAddDistrict
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1620, 675);
            Controls.Add(panelContentAddSubject);
            Controls.Add(panelTitleaddSubject);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fAddDistrict";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += fAddDistrict_FormClosing;
            panelTitleaddSubject.ResumeLayout(false);
            panelTitleaddSubject.PerformLayout();
            pInfoAddsub.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Button btn_AddDistrict;
        private Panel panelInput;
        private TextBox textBoxAddHuyen;
        private Label labelInpTinh;
        private Panel panelContentAddSubject;
        private Panel panel1;
        private Label label1;
        private Label labelAddMaHuyen;
        private Panel panel3;
        private Panel panel2;
        private ComboBox cbBoxAddTinh;
        private Label label2;
        private CheckBox ckBoxAddVSVX;
    }
}