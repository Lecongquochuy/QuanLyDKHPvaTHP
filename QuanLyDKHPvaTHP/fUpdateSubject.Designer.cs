namespace QuanLyDKHPvaTHP
{
    partial class fUpdateSubject
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
            labelInpMaMon = new Label();
            panelInput = new Panel();
            textBoxMaMon = new Label();
            textBoxTenMon = new TextBox();
            labelInpTenMon = new Label();
            panel1 = new Panel();
            textBoxSoTiet = new TextBox();
            labelInpSoTiet = new Label();
            panel2 = new Panel();
            labelInpSTC = new Label();
            panel3 = new Panel();
            textBoxSoTC = new TextBox();
            comboLoaiMon = new ComboBox();
            labelLoaiMon = new Label();
            panel4 = new Panel();
            pInfoUpdatesub = new Panel();
            btnUpdateSub = new Button();
            panelContentUpdateSubject = new Panel();
            labelUpdateSubject = new Label();
            panelTitleaddSubject = new Panel();
            panelInput.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            pInfoUpdatesub.SuspendLayout();
            panelContentUpdateSubject.SuspendLayout();
            panelTitleaddSubject.SuspendLayout();
            SuspendLayout();
            // 
            // labelInpMaMon
            // 
            labelInpMaMon.AutoSize = true;
            labelInpMaMon.Font = new Font("Times New Roman", 15.000001F);
            labelInpMaMon.ForeColor = Color.FromArgb(16, 156, 241);
            labelInpMaMon.Location = new Point(28, 16);
            labelInpMaMon.Name = "labelInpMaMon";
            labelInpMaMon.Size = new Size(197, 41);
            labelInpMaMon.TabIndex = 0;
            labelInpMaMon.Text = "Mã môn học";
            // 
            // panelInput
            // 
            panelInput.Controls.Add(textBoxMaMon);
            panelInput.Controls.Add(labelInpMaMon);
            panelInput.Location = new Point(145, 20);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(580, 128);
            panelInput.TabIndex = 0;
            // 
            // textBoxMaMon
            // 
            textBoxMaMon.BackColor = SystemColors.ButtonFace;
            textBoxMaMon.BorderStyle = BorderStyle.FixedSingle;
            textBoxMaMon.Enabled = false;
            textBoxMaMon.Font = new Font("Times New Roman", 15.000001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMaMon.ForeColor = Color.Black;
            textBoxMaMon.Location = new Point(30, 64);
            textBoxMaMon.Name = "textBoxMaMon";
            textBoxMaMon.Size = new Size(520, 48);
            textBoxMaMon.TabIndex = 1;
            textBoxMaMon.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxTenMon
            // 
            textBoxTenMon.Font = new Font("Times New Roman", 15.000001F);
            textBoxTenMon.Location = new Point(30, 64);
            textBoxTenMon.Name = "textBoxTenMon";
            textBoxTenMon.Size = new Size(520, 48);
            textBoxTenMon.TabIndex = 1;
            // 
            // labelInpTenMon
            // 
            labelInpTenMon.AutoSize = true;
            labelInpTenMon.Font = new Font("Times New Roman", 15.000001F);
            labelInpTenMon.ForeColor = Color.FromArgb(16, 156, 241);
            labelInpTenMon.Location = new Point(28, 16);
            labelInpTenMon.Name = "labelInpTenMon";
            labelInpTenMon.Size = new Size(202, 41);
            labelInpTenMon.TabIndex = 0;
            labelInpTenMon.Text = "Tên môn học";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxTenMon);
            panel1.Controls.Add(labelInpTenMon);
            panel1.Location = new Point(781, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 128);
            panel1.TabIndex = 2;
            // 
            // textBoxSoTiet
            // 
            textBoxSoTiet.Font = new Font("Times New Roman", 15.000001F);
            textBoxSoTiet.Location = new Point(30, 64);
            textBoxSoTiet.Name = "textBoxSoTiet";
            textBoxSoTiet.Size = new Size(520, 48);
            textBoxSoTiet.TabIndex = 1;
            textBoxSoTiet.TextChanged += textBoxSoTiet_TextChanged;
            // 
            // labelInpSoTiet
            // 
            labelInpSoTiet.AutoSize = true;
            labelInpSoTiet.Font = new Font("Times New Roman", 15.000001F);
            labelInpSoTiet.ForeColor = Color.FromArgb(16, 156, 241);
            labelInpSoTiet.Location = new Point(28, 16);
            labelInpSoTiet.Name = "labelInpSoTiet";
            labelInpSoTiet.Size = new Size(110, 41);
            labelInpSoTiet.TabIndex = 0;
            labelInpSoTiet.Text = "Số tiết";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxSoTiet);
            panel2.Controls.Add(labelInpSoTiet);
            panel2.Location = new Point(145, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 128);
            panel2.TabIndex = 2;
            // 
            // labelInpSTC
            // 
            labelInpSTC.AutoSize = true;
            labelInpSTC.Font = new Font("Times New Roman", 15.000001F);
            labelInpSTC.ForeColor = Color.FromArgb(16, 156, 241);
            labelInpSTC.Location = new Point(28, 16);
            labelInpSTC.Name = "labelInpSTC";
            labelInpSTC.Size = new Size(153, 41);
            labelInpSTC.TabIndex = 0;
            labelInpSTC.Text = "Số tín chỉ";
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxSoTC);
            panel3.Controls.Add(labelInpSTC);
            panel3.Location = new Point(781, 154);
            panel3.Name = "panel3";
            panel3.Size = new Size(580, 128);
            panel3.TabIndex = 2;
            // 
            // textBoxSoTC
            // 
            textBoxSoTC.BackColor = SystemColors.ButtonFace;
            textBoxSoTC.Enabled = false;
            textBoxSoTC.Font = new Font("Times New Roman", 15.000001F);
            textBoxSoTC.Location = new Point(28, 64);
            textBoxSoTC.Name = "textBoxSoTC";
            textBoxSoTC.Size = new Size(520, 48);
            textBoxSoTC.TabIndex = 2;
            // 
            // comboLoaiMon
            // 
            comboLoaiMon.Font = new Font("Times New Roman", 15.000001F);
            comboLoaiMon.FormattingEnabled = true;
            comboLoaiMon.Location = new Point(28, 65);
            comboLoaiMon.Name = "comboLoaiMon";
            comboLoaiMon.Size = new Size(522, 48);
            comboLoaiMon.TabIndex = 4;
            comboLoaiMon.SelectedIndexChanged += comboLoaiMon_SelectedIndexChanged;
            // 
            // labelLoaiMon
            // 
            labelLoaiMon.AutoSize = true;
            labelLoaiMon.Font = new Font("Times New Roman", 15.000001F);
            labelLoaiMon.ForeColor = Color.FromArgb(16, 156, 241);
            labelLoaiMon.Location = new Point(28, 16);
            labelLoaiMon.Name = "labelLoaiMon";
            labelLoaiMon.Size = new Size(153, 41);
            labelLoaiMon.TabIndex = 0;
            labelLoaiMon.Text = "Loại môn";
            // 
            // panel4
            // 
            panel4.Controls.Add(comboLoaiMon);
            panel4.Controls.Add(labelLoaiMon);
            panel4.Location = new Point(145, 288);
            panel4.Name = "panel4";
            panel4.Size = new Size(580, 128);
            panel4.TabIndex = 2;
            // 
            // pInfoUpdatesub
            // 
            pInfoUpdatesub.Controls.Add(btnUpdateSub);
            pInfoUpdatesub.Controls.Add(panel4);
            pInfoUpdatesub.Controls.Add(panel3);
            pInfoUpdatesub.Controls.Add(panel2);
            pInfoUpdatesub.Controls.Add(panel1);
            pInfoUpdatesub.Controls.Add(panelInput);
            pInfoUpdatesub.Location = new Point(59, 52);
            pInfoUpdatesub.Name = "pInfoUpdatesub";
            pInfoUpdatesub.Size = new Size(1498, 482);
            pInfoUpdatesub.TabIndex = 1;
            // 
            // btnUpdateSub
            // 
            btnUpdateSub.BackColor = Color.FromArgb(21, 44, 112);
            btnUpdateSub.Cursor = Cursors.Hand;
            btnUpdateSub.Font = new Font("Times New Roman", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateSub.ForeColor = Color.White;
            btnUpdateSub.Location = new Point(811, 326);
            btnUpdateSub.Name = "btnUpdateSub";
            btnUpdateSub.Size = new Size(520, 80);
            btnUpdateSub.TabIndex = 3;
            btnUpdateSub.Text = "Lưu";
            btnUpdateSub.UseVisualStyleBackColor = false;
            btnUpdateSub.Click += btnUpdateSub_Click;
            // 
            // panelContentUpdateSubject
            // 
            panelContentUpdateSubject.BackColor = Color.White;
            panelContentUpdateSubject.Controls.Add(pInfoUpdatesub);
            panelContentUpdateSubject.Location = new Point(2, 113);
            panelContentUpdateSubject.Name = "panelContentUpdateSubject";
            panelContentUpdateSubject.Size = new Size(1620, 549);
            panelContentUpdateSubject.TabIndex = 3;
            // 
            // labelUpdateSubject
            // 
            labelUpdateSubject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelUpdateSubject.AutoSize = true;
            labelUpdateSubject.Font = new Font("Times New Roman", 30.0000019F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUpdateSubject.ForeColor = Color.Transparent;
            labelUpdateSubject.Location = new Point(531, 18);
            labelUpdateSubject.Name = "labelUpdateSubject";
            labelUpdateSubject.Size = new Size(609, 81);
            labelUpdateSubject.TabIndex = 0;
            labelUpdateSubject.Text = "Thông tin môn học";
            labelUpdateSubject.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTitleaddSubject
            // 
            panelTitleaddSubject.BackColor = Color.FromArgb(21, 44, 112);
            panelTitleaddSubject.Controls.Add(labelUpdateSubject);
            panelTitleaddSubject.Location = new Point(-1, 2);
            panelTitleaddSubject.Name = "panelTitleaddSubject";
            panelTitleaddSubject.Size = new Size(1620, 109);
            panelTitleaddSubject.TabIndex = 2;
            // 
            // fUpdateSubject
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1620, 659);
            Controls.Add(panelContentUpdateSubject);
            Controls.Add(panelTitleaddSubject);
            Name = "fUpdateSubject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fUpdateSubject";
            FormClosing += fAddSubject_FormClosing;
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
            pInfoUpdatesub.ResumeLayout(false);
            panelContentUpdateSubject.ResumeLayout(false);
            panelTitleaddSubject.ResumeLayout(false);
            panelTitleaddSubject.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label labelInpMaMon;
        private Panel panelInput;
        private TextBox textBoxTenMon;
        private Label labelInpTenMon;
        private Panel panel1;
        private TextBox textBoxSoTiet;
        private Label labelInpSoTiet;
        private Panel panel2;
        private Label labelInpSTC;
        private Panel panel3;
        private ComboBox comboLoaiMon;
        private Label labelLoaiMon;
        private Button btn_UpdateSub;
        private Panel panel4;
        private Panel pInfoUpdatesub;
        private Panel panelContentUpdateSubject;
        private Label labelUpdateSubject;
        private Panel panelTitleaddSubject;
        private Button btnUpdateSub;
        private Label textBoxMaMon;
        private TextBox textBoxSoTC;
    }
}