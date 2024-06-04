namespace QuanLyDKHPvaTHP
{
    partial class fAddProvince
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
            labelAddProvince = new Label();
            pInfoAddsub = new Panel();
            panel1 = new Panel();
            labelAddMaTinh = new Label();
            label1 = new Label();
            btn_AddProvince = new Button();
            panelInput = new Panel();
            textBoxAddTinh = new TextBox();
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
            panelTitleaddSubject.Controls.Add(labelAddProvince);
            panelTitleaddSubject.Location = new Point(-2, 4);
            panelTitleaddSubject.Margin = new Padding(3, 4, 3, 4);
            panelTitleaddSubject.Name = "panelTitleaddSubject";
            panelTitleaddSubject.Size = new Size(1620, 108);
            panelTitleaddSubject.TabIndex = 0;
            // 
            // labelAddProvince
            // 
            labelAddProvince.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAddProvince.AutoSize = true;
            labelAddProvince.Font = new Font("Times New Roman", 30.0000019F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAddProvince.ForeColor = Color.Transparent;
            labelAddProvince.Location = new Point(566, 16);
            labelAddProvince.Name = "labelAddProvince";
            labelAddProvince.Size = new Size(473, 81);
            labelAddProvince.TabIndex = 0;
            labelAddProvince.Text = "Thông tin tỉnh";
            labelAddProvince.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pInfoAddsub
            // 
            pInfoAddsub.Controls.Add(panel1);
            pInfoAddsub.Controls.Add(btn_AddProvince);
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
            panel1.Controls.Add(labelAddMaTinh);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(111, 28);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 128);
            panel1.TabIndex = 2;
            // 
            // labelAddMaTinh
            // 
            labelAddMaTinh.BackColor = SystemColors.ButtonFace;
            labelAddMaTinh.BorderStyle = BorderStyle.FixedSingle;
            labelAddMaTinh.FlatStyle = FlatStyle.System;
            labelAddMaTinh.Font = new Font("Times New Roman", 15.000001F);
            labelAddMaTinh.Location = new Point(32, 64);
            labelAddMaTinh.Margin = new Padding(4, 0, 4, 0);
            labelAddMaTinh.Name = "labelAddMaTinh";
            labelAddMaTinh.Size = new Size(516, 53);
            labelAddMaTinh.TabIndex = 2;
            labelAddMaTinh.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.000001F);
            label1.ForeColor = Color.FromArgb(16, 156, 241);
            label1.Location = new Point(27, 16);
            label1.Name = "label1";
            label1.Size = new Size(128, 41);
            label1.TabIndex = 0;
            label1.Text = "Mã tỉnh";
            // 
            // btn_AddProvince
            // 
            btn_AddProvince.BackColor = Color.FromArgb(21, 44, 112);
            btn_AddProvince.Cursor = Cursors.Hand;
            btn_AddProvince.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddProvince.ForeColor = Color.White;
            btn_AddProvince.Location = new Point(813, 198);
            btn_AddProvince.Margin = new Padding(3, 4, 3, 4);
            btn_AddProvince.Name = "btn_AddProvince";
            btn_AddProvince.Size = new Size(520, 80);
            btn_AddProvince.TabIndex = 3;
            btn_AddProvince.Text = "Thêm";
            btn_AddProvince.UseVisualStyleBackColor = false;
            btn_AddProvince.Click += btn_AddProvince_Click;
            // 
            // panelInput
            // 
            panelInput.Controls.Add(textBoxAddTinh);
            panelInput.Controls.Add(labelInpTinh);
            panelInput.Location = new Point(813, 28);
            panelInput.Margin = new Padding(3, 4, 3, 4);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(579, 128);
            panelInput.TabIndex = 0;
            // 
            // textBoxAddTinh
            // 
            textBoxAddTinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAddTinh.Font = new Font("Times New Roman", 15.000001F);
            textBoxAddTinh.ForeColor = SystemColors.WindowText;
            textBoxAddTinh.Location = new Point(32, 64);
            textBoxAddTinh.Margin = new Padding(12, 12, 12, 12);
            textBoxAddTinh.Name = "textBoxAddTinh";
            textBoxAddTinh.Size = new Size(520, 48);
            textBoxAddTinh.TabIndex = 1;
            // 
            // labelInpTinh
            // 
            labelInpTinh.AutoSize = true;
            labelInpTinh.Font = new Font("Times New Roman", 15.000001F);
            labelInpTinh.ForeColor = Color.FromArgb(16, 156, 241);
            labelInpTinh.Location = new Point(27, 16);
            labelInpTinh.Name = "labelInpTinh";
            labelInpTinh.Size = new Size(133, 41);
            labelInpTinh.TabIndex = 0;
            labelInpTinh.Text = "Tên tỉnh";
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
            // fAddProvince
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1620, 470);
            Controls.Add(panelContentAddSubject);
            Controls.Add(panelTitleaddSubject);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fAddProvince";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += fAddProvince_FormClosing;
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
        private Label labelAddProvince;
        private Panel pTitleInforAddSub;
        private Label laTitleInfoAddPri;
        private Panel pInfoAddsub;
        private Button btn_AddProvince;
        private Panel panelInput;
        private TextBox textBoxAddTinh;
        private Label labelInpTinh;
        private Panel panelContentAddSubject;
        private Panel panel1;
        private Label label1;
        private Label labelAddMaTinh;
    }
}