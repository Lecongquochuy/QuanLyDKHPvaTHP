namespace QuanLyDKHPvaTHP
{
    partial class fAddSubject
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTitleaddSubject = new Panel();
            labelAddSubject = new Label();
            panelContentAddSubject = new Panel();
            pInfoAddsub = new Panel();
            btn_AddSub = new Button();
            panel4 = new Panel();
            comboLoaiMon = new ComboBox();
            labelLoaiMon = new Label();
            panel3 = new Panel();
            textBoxSoTC = new TextBox();
            labelInpSTC = new Label();
            panel2 = new Panel();
            textBoxSoTiet = new TextBox();
            labelInpSoTiet = new Label();
            panel1 = new Panel();
            textBoxTenMon = new TextBox();
            labelInpTenMon = new Label();
            panelInput = new Panel();
            textBoxMaMon = new TextBox();
            labelInpMaMon = new Label();
            pTitleInforAddSub = new Panel();
            laTitleInfoAddsub = new Label();
            panelTitleaddSubject.SuspendLayout();
            panelContentAddSubject.SuspendLayout();
            pInfoAddsub.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panelInput.SuspendLayout();
            pTitleInforAddSub.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitleaddSubject
            // 
            panelTitleaddSubject.BackColor = Color.FromArgb(21, 44, 112);
            panelTitleaddSubject.Controls.Add(labelAddSubject);
            panelTitleaddSubject.Location = new Point(-1, 4);
            panelTitleaddSubject.Name = "panelTitleaddSubject";
            panelTitleaddSubject.Size = new Size(1620, 109);
            panelTitleaddSubject.TabIndex = 0;
            // 
            // labelAddSubject
            // 
            labelAddSubject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAddSubject.AutoSize = true;
            labelAddSubject.Font = new Font("Times New Roman", 30.0000019F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAddSubject.ForeColor = Color.Transparent;
            labelAddSubject.Location = new Point(566, 15);
            labelAddSubject.Name = "labelAddSubject";
            labelAddSubject.Size = new Size(488, 81);
            labelAddSubject.TabIndex = 0;
            labelAddSubject.Text = "Thêm môn học";
            labelAddSubject.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContentAddSubject
            // 
            panelContentAddSubject.BackColor = Color.White;
            panelContentAddSubject.Controls.Add(pInfoAddsub);
            panelContentAddSubject.Controls.Add(pTitleInforAddSub);
            panelContentAddSubject.Location = new Point(2, 115);
            panelContentAddSubject.Name = "panelContentAddSubject";
            panelContentAddSubject.Size = new Size(1620, 690);
            panelContentAddSubject.TabIndex = 1;
            // 
            // pInfoAddsub
            // 
            pInfoAddsub.Controls.Add(btn_AddSub);
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
            // btn_AddSub
            // 
            btn_AddSub.BackColor = Color.FromArgb(21, 44, 112);
            btn_AddSub.Cursor = Cursors.Hand;
            btn_AddSub.Font = new Font("Times New Roman", 20.1428585F, FontStyle.Bold);
            btn_AddSub.ForeColor = Color.White;
            btn_AddSub.Location = new Point(809, 323);
            btn_AddSub.Name = "btn_AddSub";
            btn_AddSub.Size = new Size(522, 80);
            btn_AddSub.TabIndex = 3;
            btn_AddSub.Text = "Thêm môn";
            btn_AddSub.UseVisualStyleBackColor = false;
            btn_AddSub.Click += btn_AddSub_Click;
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
            // comboLoaiMon
            // 
            comboLoaiMon.FormattingEnabled = true;
            comboLoaiMon.Location = new Point(28, 65);
            comboLoaiMon.Name = "comboLoaiMon";
            comboLoaiMon.Size = new Size(522, 38);
            comboLoaiMon.TabIndex = 4;
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
            textBoxSoTC.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSoTC.Location = new Point(30, 64);
            textBoxSoTC.Name = "textBoxSoTC";
            textBoxSoTC.Size = new Size(520, 40);
            textBoxSoTC.TabIndex = 1;
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
            // panel2
            // 
            panel2.Controls.Add(textBoxSoTiet);
            panel2.Controls.Add(labelInpSoTiet);
            panel2.Location = new Point(145, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 128);
            panel2.TabIndex = 2;
            // 
            // textBoxSoTiet
            // 
            textBoxSoTiet.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSoTiet.Location = new Point(30, 64);
            textBoxSoTiet.Name = "textBoxSoTiet";
            textBoxSoTiet.Size = new Size(520, 40);
            textBoxSoTiet.TabIndex = 1;
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
            // panel1
            // 
            panel1.Controls.Add(textBoxTenMon);
            panel1.Controls.Add(labelInpTenMon);
            panel1.Location = new Point(781, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 128);
            panel1.TabIndex = 2;
            // 
            // textBoxTenMon
            // 
            textBoxTenMon.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTenMon.Location = new Point(30, 64);
            textBoxTenMon.Name = "textBoxTenMon";
            textBoxTenMon.Size = new Size(520, 40);
            textBoxTenMon.TabIndex = 1;
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
            textBoxMaMon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxMaMon.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMaMon.Location = new Point(30, 64);
            textBoxMaMon.Margin = new Padding(12);
            textBoxMaMon.Name = "textBoxMaMon";
            textBoxMaMon.Size = new Size(520, 40);
            textBoxMaMon.TabIndex = 1;
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
            // fAddSubject
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1620, 804);
            Controls.Add(panelContentAddSubject);
            Controls.Add(panelTitleaddSubject);
            Name = "fAddSubject";
            Text = "Thêm môn học";
            panelTitleaddSubject.ResumeLayout(false);
            panelTitleaddSubject.PerformLayout();
            panelContentAddSubject.ResumeLayout(false);
            pInfoAddsub.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            pTitleInforAddSub.ResumeLayout(false);
            pTitleInforAddSub.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleaddSubject;
        private Label labelAddSubject;
        private Panel panelContentAddSubject;
        private Panel pTitleInforAddSub;
        private Label laTitleInfoAddsub;
        private Panel pInfoAddsub;
        private Panel panelInput;
        private TextBox textBoxMaMon;
        private Label labelInpMaMon;
        private Button btn_AddSub;
        private Panel panel4;
        private Label labelLoaiMon;
        private Panel panel3;
        private TextBox textBoxSoTC;
        private Label labelInpSTC;
        private Panel panel2;
        private TextBox textBoxSoTiet;
        private Label labelInpSoTiet;
        private Panel panel1;
        private TextBox textBoxTenMon;
        private Label labelInpTenMon;
        private ComboBox comboLoaiMon;
    }
}
