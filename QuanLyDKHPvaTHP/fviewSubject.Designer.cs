namespace QuanLyDKHPvaTHP
{
    partial class fViewSubject
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
            laTitleInfoAddsub = new Label();
            txtMaMon = new TextBox();
            labelInpMaMon = new Label();
            panelInput = new Panel();
            txtTenMon = new TextBox();
            labelInpTenMon = new Label();
            panel1 = new Panel();
            txtSoTiet = new TextBox();
            labelInpSoTiet = new Label();
            txtSoTC = new TextBox();
            panel2 = new Panel();
            labelInpSTC = new Label();
            panel3 = new Panel();
            labelLoaiMon = new Label();
            panel4 = new Panel();
            pInfoAddsub = new Panel();
            panelContentAddSubject = new Panel();
            pTitleInforAddSub = new Panel();
            labelViewSubject = new Label();
            panelTitleaddSubject = new Panel();
            txtLoaiMon = new TextBox();
            panelInput.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            pInfoAddsub.SuspendLayout();
            panelContentAddSubject.SuspendLayout();
            pTitleInforAddSub.SuspendLayout();
            panelTitleaddSubject.SuspendLayout();
            SuspendLayout();
            // 
            // laTitleInfoAddsub
            // 
            laTitleInfoAddsub.AutoSize = true;
            laTitleInfoAddsub.Font = new Font("Times New Roman", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            laTitleInfoAddsub.ForeColor = Color.FromArgb(21, 44, 112);
            laTitleInfoAddsub.Location = new Point(80, 24);
            laTitleInfoAddsub.Name = "laTitleInfoAddsub";
            laTitleInfoAddsub.Size = new Size(409, 55);
            laTitleInfoAddsub.TabIndex = 0;
            laTitleInfoAddsub.Text = "Thông tin môn học";
            laTitleInfoAddsub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMaMon
            // 
            txtMaMon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMaMon.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaMon.Location = new Point(30, 64);
            txtMaMon.Margin = new Padding(12);
            txtMaMon.Name = "txtMaMon";
            txtMaMon.Size = new Size(520, 40);
            txtMaMon.TabIndex = 1;
            // 
            // labelInpMaMon
            // 
            labelInpMaMon.AutoSize = true;
            labelInpMaMon.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInpMaMon.Location = new Point(28, 16);
            labelInpMaMon.Name = "labelInpMaMon";
            labelInpMaMon.Size = new Size(154, 33);
            labelInpMaMon.TabIndex = 0;
            labelInpMaMon.Text = "Mã môn học";
            // 
            // panelInput
            // 
            panelInput.Controls.Add(txtMaMon);
            panelInput.Controls.Add(labelInpMaMon);
            panelInput.Location = new Point(145, 20);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(580, 128);
            panelInput.TabIndex = 0;
            // 
            // txtTenMon
            // 
            txtTenMon.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenMon.Location = new Point(30, 64);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(520, 40);
            txtTenMon.TabIndex = 1;
            // 
            // labelInpTenMon
            // 
            labelInpTenMon.AutoSize = true;
            labelInpTenMon.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInpTenMon.Location = new Point(28, 16);
            labelInpTenMon.Name = "labelInpTenMon";
            labelInpTenMon.Size = new Size(159, 33);
            labelInpTenMon.TabIndex = 0;
            labelInpTenMon.Text = "Tên môn học";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTenMon);
            panel1.Controls.Add(labelInpTenMon);
            panel1.Location = new Point(781, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 128);
            panel1.TabIndex = 2;
            // 
            // txtSoTiet
            // 
            txtSoTiet.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoTiet.Location = new Point(30, 64);
            txtSoTiet.Name = "txtSoTiet";
            txtSoTiet.Size = new Size(520, 40);
            txtSoTiet.TabIndex = 1;
            // 
            // labelInpSoTiet
            // 
            labelInpSoTiet.AutoSize = true;
            labelInpSoTiet.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInpSoTiet.Location = new Point(28, 16);
            labelInpSoTiet.Name = "labelInpSoTiet";
            labelInpSoTiet.Size = new Size(88, 33);
            labelInpSoTiet.TabIndex = 0;
            labelInpSoTiet.Text = "Số tiết";
            // 
            // txtSoTC
            // 
            txtSoTC.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoTC.Location = new Point(30, 64);
            txtSoTC.Name = "txtSoTC";
            txtSoTC.Size = new Size(520, 40);
            txtSoTC.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtSoTiet);
            panel2.Controls.Add(labelInpSoTiet);
            panel2.Location = new Point(145, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 128);
            panel2.TabIndex = 2;
            // 
            // labelInpSTC
            // 
            labelInpSTC.AutoSize = true;
            labelInpSTC.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInpSTC.Location = new Point(28, 16);
            labelInpSTC.Name = "labelInpSTC";
            labelInpSTC.Size = new Size(123, 33);
            labelInpSTC.TabIndex = 0;
            labelInpSTC.Text = "Số tín chỉ";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtSoTC);
            panel3.Controls.Add(labelInpSTC);
            panel3.Location = new Point(781, 154);
            panel3.Name = "panel3";
            panel3.Size = new Size(580, 128);
            panel3.TabIndex = 2;
            // 
            // labelLoaiMon
            // 
            labelLoaiMon.AutoSize = true;
            labelLoaiMon.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLoaiMon.Location = new Point(28, 16);
            labelLoaiMon.Name = "labelLoaiMon";
            labelLoaiMon.Size = new Size(120, 33);
            labelLoaiMon.TabIndex = 0;
            labelLoaiMon.Text = "Loại môn";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtLoaiMon);
            panel4.Controls.Add(labelLoaiMon);
            panel4.Location = new Point(145, 288);
            panel4.Name = "panel4";
            panel4.Size = new Size(580, 128);
            panel4.TabIndex = 2;
            // 
            // pInfoAddsub
            // 
            pInfoAddsub.Controls.Add(panel4);
            pInfoAddsub.Controls.Add(panel3);
            pInfoAddsub.Controls.Add(panel2);
            pInfoAddsub.Controls.Add(panel1);
            pInfoAddsub.Controls.Add(panelInput);
            pInfoAddsub.Location = new Point(59, 165);
            pInfoAddsub.Name = "pInfoAddsub";
            pInfoAddsub.Size = new Size(1498, 440);
            pInfoAddsub.TabIndex = 1;
            // 
            // panelContentAddSubject
            // 
            panelContentAddSubject.BackColor = Color.White;
            panelContentAddSubject.Controls.Add(pInfoAddsub);
            panelContentAddSubject.Controls.Add(pTitleInforAddSub);
            panelContentAddSubject.Location = new Point(2, 113);
            panelContentAddSubject.Name = "panelContentAddSubject";
            panelContentAddSubject.Size = new Size(1620, 690);
            panelContentAddSubject.TabIndex = 3;
            // 
            // pTitleInforAddSub
            // 
            pTitleInforAddSub.Controls.Add(laTitleInfoAddsub);
            pTitleInforAddSub.Font = new Font("Times New Roman", 20.1428585F, FontStyle.Bold);
            pTitleInforAddSub.ForeColor = Color.DarkBlue;
            pTitleInforAddSub.Location = new Point(59, 39);
            pTitleInforAddSub.Name = "pTitleInforAddSub";
            pTitleInforAddSub.Size = new Size(1498, 110);
            pTitleInforAddSub.TabIndex = 0;
            // 
            // labelViewSubject
            // 
            labelViewSubject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelViewSubject.AutoSize = true;
            labelViewSubject.Font = new Font("Times New Roman", 30.0000019F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelViewSubject.ForeColor = Color.Transparent;
            labelViewSubject.Location = new Point(506, 15);
            labelViewSubject.Name = "labelViewSubject";
            labelViewSubject.Size = new Size(609, 81);
            labelViewSubject.TabIndex = 0;
            labelViewSubject.Text = "Thông tin môn học";
            labelViewSubject.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTitleaddSubject
            // 
            panelTitleaddSubject.BackColor = Color.FromArgb(21, 44, 112);
            panelTitleaddSubject.Controls.Add(labelViewSubject);
            panelTitleaddSubject.Location = new Point(-1, 2);
            panelTitleaddSubject.Name = "panelTitleaddSubject";
            panelTitleaddSubject.Size = new Size(1620, 109);
            panelTitleaddSubject.TabIndex = 2;
            // 
            // txtLoaiMon
            // 
            txtLoaiMon.Location = new Point(30, 74);
            txtLoaiMon.Name = "txtLoaiMon";
            txtLoaiMon.Size = new Size(520, 35);
            txtLoaiMon.TabIndex = 1;
            // 
            // fViewSubject
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1620, 804);
            Controls.Add(panelContentAddSubject);
            Controls.Add(panelTitleaddSubject);
            Name = "fViewSubject";
            Text = "Thông tin môn học";
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            pInfoAddsub.ResumeLayout(false);
            panelContentAddSubject.ResumeLayout(false);
            pTitleInforAddSub.ResumeLayout(false);
            pTitleInforAddSub.PerformLayout();
            panelTitleaddSubject.ResumeLayout(false);
            panelTitleaddSubject.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label laTitleInfoAddsub;
        private TextBox txtMaMon;
        private Label labelInpMaMon;
        private Panel panelInput;
        private TextBox txtTenMon;
        private Label labelInpTenMon;
        private Panel panel1;
        private TextBox txtSoTiet;
        private Label labelInpSoTiet;
        private TextBox txtSoTC;
        private Panel panel2;
        private Label labelInpSTC;
        private Panel panel3;
        private Label labelLoaiMon;
        private Panel panel4;
        private Panel pInfoAddsub;
        private Panel panelContentAddSubject;
        private Panel pTitleInforAddSub;
        private Label labelViewSubject;
        private Panel panelTitleaddSubject;
        private TextBox txtLoaiMon;
    }
}