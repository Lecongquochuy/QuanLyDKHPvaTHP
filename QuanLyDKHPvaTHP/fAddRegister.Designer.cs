namespace QuanLyDKHPvaTHP
{
    partial class fAddRegister
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            pTitleInforAddStudyProgram = new Panel();
            lInfo = new Label();
            panel4 = new Panel();
            txbStudentID = new TextBox();
            lStudentID = new Label();
            panel1 = new Panel();
            lbSchoolYear = new Label();
            lSchoolYear = new Label();
            btnConfirm = new Button();
            dgvOpenSubject = new DataGridView();
            CheckBox = new DataGridViewCheckBoxColumn();
            MaMH = new DataGridViewTextBoxColumn();
            TenMH = new DataGridViewTextBoxColumn();
            TenLoaiMon = new DataGridViewTextBoxColumn();
            SoTC = new DataGridViewTextBoxColumn();
            SoTiet = new DataGridViewTextBoxColumn();
            MaMo = new DataGridViewTextBoxColumn();
            MaLoaiMon = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            dtpDateCreate = new DateTimePicker();
            lDateCreate = new Label();
            panel3 = new Panel();
            lbSemester = new Label();
            lSemester = new Label();
            panel5 = new Panel();
            lbSubAmount = new Label();
            label2 = new Label();
            panel6 = new Panel();
            lbCreditAmount = new Label();
            label4 = new Label();
            panel7 = new Panel();
            lbMoneySum = new Label();
            label5 = new Label();
            btnDelete = new Button();
            tctAddSubject = new TabControl();
            tpOpenSubject = new TabPage();
            pSearchBar = new Panel();
            tbSearch = new TextBox();
            picSearch = new PictureBox();
            btnAdd = new Button();
            tpSelectedSubject = new TabPage();
            dgvSelectedSubject = new DataGridView();
            CheckBox_Selected = new DataGridViewCheckBoxColumn();
            MaMH_Selected = new DataGridViewTextBoxColumn();
            TenMH_Selected = new DataGridViewTextBoxColumn();
            TenLoaiMon_Selected = new DataGridViewTextBoxColumn();
            SoTC_Selected = new DataGridViewTextBoxColumn();
            SoTiet_Selected = new DataGridViewTextBoxColumn();
            MaMo_Selected = new DataGridViewTextBoxColumn();
            MaLoaiMon_Selected = new DataGridViewTextBoxColumn();
            pTitleInforAddStudyProgram.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOpenSubject).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            tctAddSubject.SuspendLayout();
            tpOpenSubject.SuspendLayout();
            pSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSearch).BeginInit();
            tpSelectedSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSelectedSubject).BeginInit();
            SuspendLayout();
            // 
            // pTitleInforAddStudyProgram
            // 
            pTitleInforAddStudyProgram.Controls.Add(lInfo);
            pTitleInforAddStudyProgram.Font = new Font("Times New Roman", 20.1428585F, FontStyle.Bold);
            pTitleInforAddStudyProgram.ForeColor = Color.DarkBlue;
            pTitleInforAddStudyProgram.Location = new Point(80, 8);
            pTitleInforAddStudyProgram.Name = "pTitleInforAddStudyProgram";
            pTitleInforAddStudyProgram.Size = new Size(788, 88);
            pTitleInforAddStudyProgram.TabIndex = 2;
            // 
            // lInfo
            // 
            lInfo.AutoSize = true;
            lInfo.Font = new Font("Times New Roman", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lInfo.ForeColor = Color.FromArgb(21, 44, 112);
            lInfo.Location = new Point(80, 24);
            lInfo.Name = "lInfo";
            lInfo.Size = new Size(524, 55);
            lInfo.TabIndex = 0;
            lInfo.Text = "Thông tin phiếu đăng ký";
            lInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(txbStudentID);
            panel4.Controls.Add(lStudentID);
            panel4.Location = new Point(80, 102);
            panel4.Name = "panel4";
            panel4.Size = new Size(381, 128);
            panel4.TabIndex = 3;
            // 
            // txbStudentID
            // 
            txbStudentID.Font = new Font("Times New Roman", 15.000001F);
            txbStudentID.Location = new Point(28, 66);
            txbStudentID.Margin = new Padding(4);
            txbStudentID.Name = "txbStudentID";
            txbStudentID.Size = new Size(322, 48);
            txbStudentID.TabIndex = 18;
            txbStudentID.Validated += txbStudentID_Validated;
            // 
            // lStudentID
            // 
            lStudentID.AutoSize = true;
            lStudentID.Font = new Font("Times New Roman", 15.000001F);
            lStudentID.ForeColor = Color.FromArgb(16, 156, 241);
            lStudentID.Location = new Point(28, 16);
            lStudentID.Name = "lStudentID";
            lStudentID.Size = new Size(240, 41);
            lStudentID.TabIndex = 0;
            lStudentID.Text = "Mã số sinh viên";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbSchoolYear);
            panel1.Controls.Add(lSchoolYear);
            panel1.Location = new Point(681, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 128);
            panel1.TabIndex = 5;
            // 
            // lbSchoolYear
            // 
            lbSchoolYear.BackColor = Color.White;
            lbSchoolYear.BorderStyle = BorderStyle.FixedSingle;
            lbSchoolYear.Font = new Font("Times New Roman", 15.000001F);
            lbSchoolYear.ForeColor = Color.Black;
            lbSchoolYear.Location = new Point(28, 66);
            lbSchoolYear.Margin = new Padding(4);
            lbSchoolYear.Name = "lbSchoolYear";
            lbSchoolYear.Size = new Size(182, 53);
            lbSchoolYear.TabIndex = 7;
            lbSchoolYear.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lSchoolYear
            // 
            lSchoolYear.AutoSize = true;
            lSchoolYear.Font = new Font("Times New Roman", 15.000001F);
            lSchoolYear.ForeColor = Color.FromArgb(16, 156, 241);
            lSchoolYear.Location = new Point(28, 16);
            lSchoolYear.Name = "lSchoolYear";
            lSchoolYear.Size = new Size(148, 41);
            lSchoolYear.TabIndex = 0;
            lSchoolYear.Text = "Năm học";
            // 
            // btnConfirm
            // 
            btnConfirm.AllowDrop = true;
            btnConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfirm.BackColor = Color.FromArgb(21, 44, 112);
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(1308, 306);
            btnConfirm.Margin = new Padding(0);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(186, 60);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // dgvOpenSubject
            // 
            dgvOpenSubject.AllowUserToAddRows = false;
            dgvOpenSubject.AllowUserToDeleteRows = false;
            dgvOpenSubject.AllowUserToResizeColumns = false;
            dgvOpenSubject.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = Color.White;
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(16, 156, 241);
            dgvOpenSubject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dgvOpenSubject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOpenSubject.BackgroundColor = Color.White;
            dgvOpenSubject.BorderStyle = BorderStyle.None;
            dgvOpenSubject.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvOpenSubject.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.White;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvOpenSubject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvOpenSubject.ColumnHeadersHeight = 70;
            dgvOpenSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOpenSubject.Columns.AddRange(new DataGridViewColumn[] { CheckBox, MaMH, TenMH, TenLoaiMon, SoTC, SoTiet, MaMo, MaLoaiMon });
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.White;
            dataGridViewCellStyle13.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = Color.White;
            dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(16, 156, 241);
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dgvOpenSubject.DefaultCellStyle = dataGridViewCellStyle13;
            dgvOpenSubject.EnableHeadersVisualStyles = false;
            dgvOpenSubject.GridColor = Color.Black;
            dgvOpenSubject.Location = new Point(4, 80);
            dgvOpenSubject.Margin = new Padding(4);
            dgvOpenSubject.Name = "dgvOpenSubject";
            dgvOpenSubject.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Control;
            dataGridViewCellStyle14.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = Color.White;
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgvOpenSubject.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgvOpenSubject.RowHeadersVisible = false;
            dgvOpenSubject.RowHeadersWidth = 60;
            dataGridViewCellStyle15.BackColor = Color.White;
            dataGridViewCellStyle15.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle15.ForeColor = Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = Color.White;
            dataGridViewCellStyle15.SelectionForeColor = Color.FromArgb(16, 156, 241);
            dgvOpenSubject.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dgvOpenSubject.RowTemplate.Height = 65;
            dgvOpenSubject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOpenSubject.ShowCellErrors = false;
            dgvOpenSubject.ShowCellToolTips = false;
            dgvOpenSubject.ShowEditingIcon = false;
            dgvOpenSubject.ShowRowErrors = false;
            dgvOpenSubject.Size = new Size(1394, 342);
            dgvOpenSubject.TabIndex = 17;
            // 
            // CheckBox
            // 
            CheckBox.DataPropertyName = "CheckBox";
            CheckBox.FillWeight = 14.9625931F;
            CheckBox.HeaderText = "";
            CheckBox.MinimumWidth = 6;
            CheckBox.Name = "CheckBox";
            CheckBox.Width = 50;
            // 
            // MaMH
            // 
            MaMH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaMH.DataPropertyName = "MaMH";
            MaMH.FillWeight = 138.064758F;
            MaMH.HeaderText = "Mã môn";
            MaMH.MinimumWidth = 6;
            MaMH.Name = "MaMH";
            // 
            // TenMH
            // 
            TenMH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenMH.DataPropertyName = "TenMH";
            TenMH.FillWeight = 128.229675F;
            TenMH.HeaderText = "Tên môn";
            TenMH.MinimumWidth = 6;
            TenMH.Name = "TenMH";
            // 
            // TenLoaiMon
            // 
            TenLoaiMon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenLoaiMon.DataPropertyName = "TenLoaiMon";
            TenLoaiMon.FillWeight = 120.5517F;
            TenLoaiMon.HeaderText = "Loại môn";
            TenLoaiMon.MinimumWidth = 6;
            TenLoaiMon.Name = "TenLoaiMon";
            // 
            // SoTC
            // 
            SoTC.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoTC.DataPropertyName = "SoTC";
            SoTC.FillWeight = 114.981415F;
            SoTC.HeaderText = "Số tín chỉ";
            SoTC.MinimumWidth = 6;
            SoTC.Name = "SoTC";
            // 
            // SoTiet
            // 
            SoTiet.DataPropertyName = "SoTiet";
            SoTiet.FillWeight = 83.2098846F;
            SoTiet.HeaderText = "Số tiết";
            SoTiet.MinimumWidth = 6;
            SoTiet.Name = "SoTiet";
            SoTiet.Width = 125;
            // 
            // MaMo
            // 
            MaMo.DataPropertyName = "MaMo";
            MaMo.HeaderText = "Mã mở";
            MaMo.MinimumWidth = 6;
            MaMo.Name = "MaMo";
            MaMo.Visible = false;
            MaMo.Width = 125;
            // 
            // MaLoaiMon
            // 
            MaLoaiMon.DataPropertyName = "MaLoaiMon";
            MaLoaiMon.HeaderText = "Mã loại môn";
            MaLoaiMon.MinimumWidth = 6;
            MaLoaiMon.Name = "MaLoaiMon";
            MaLoaiMon.Visible = false;
            MaLoaiMon.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtpDateCreate);
            panel2.Controls.Add(lDateCreate);
            panel2.Location = new Point(921, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(573, 128);
            panel2.TabIndex = 7;
            // 
            // dtpDateCreate
            // 
            dtpDateCreate.Enabled = false;
            dtpDateCreate.Font = new Font("Times New Roman", 15.000001F);
            dtpDateCreate.Location = new Point(28, 66);
            dtpDateCreate.Margin = new Padding(4);
            dtpDateCreate.Name = "dtpDateCreate";
            dtpDateCreate.Size = new Size(524, 48);
            dtpDateCreate.TabIndex = 1;
            // 
            // lDateCreate
            // 
            lDateCreate.AutoSize = true;
            lDateCreate.Font = new Font("Times New Roman", 15.000001F);
            lDateCreate.ForeColor = Color.FromArgb(16, 156, 241);
            lDateCreate.Location = new Point(28, 16);
            lDateCreate.Name = "lDateCreate";
            lDateCreate.Size = new Size(147, 41);
            lDateCreate.TabIndex = 0;
            lDateCreate.Text = "Ngày lập";
            // 
            // panel3
            // 
            panel3.Controls.Add(lbSemester);
            panel3.Controls.Add(lSemester);
            panel3.Location = new Point(459, 102);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 128);
            panel3.TabIndex = 6;
            // 
            // lbSemester
            // 
            lbSemester.BackColor = Color.White;
            lbSemester.BorderStyle = BorderStyle.FixedSingle;
            lbSemester.Font = new Font("Times New Roman", 15.000001F);
            lbSemester.ForeColor = Color.Black;
            lbSemester.Location = new Point(28, 66);
            lbSemester.Margin = new Padding(4);
            lbSemester.Name = "lbSemester";
            lbSemester.Size = new Size(164, 53);
            lbSemester.TabIndex = 8;
            lbSemester.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lSemester
            // 
            lSemester.AutoSize = true;
            lSemester.Font = new Font("Times New Roman", 15.000001F);
            lSemester.ForeColor = Color.FromArgb(16, 156, 241);
            lSemester.Location = new Point(28, 16);
            lSemester.Name = "lSemester";
            lSemester.Size = new Size(122, 41);
            lSemester.TabIndex = 0;
            lSemester.Text = "Học kỳ";
            // 
            // panel5
            // 
            panel5.Controls.Add(lbSubAmount);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(80, 246);
            panel5.Name = "panel5";
            panel5.Size = new Size(202, 128);
            panel5.TabIndex = 9;
            // 
            // lbSubAmount
            // 
            lbSubAmount.BackColor = Color.White;
            lbSubAmount.BorderStyle = BorderStyle.FixedSingle;
            lbSubAmount.Font = new Font("Times New Roman", 15.000001F);
            lbSubAmount.ForeColor = Color.Black;
            lbSubAmount.Location = new Point(28, 66);
            lbSubAmount.Margin = new Padding(4);
            lbSubAmount.Name = "lbSubAmount";
            lbSubAmount.Size = new Size(138, 53);
            lbSubAmount.TabIndex = 8;
            lbSubAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.000001F);
            label2.ForeColor = Color.FromArgb(16, 156, 241);
            label2.Location = new Point(28, 16);
            label2.Name = "label2";
            label2.Size = new Size(126, 41);
            label2.TabIndex = 0;
            label2.Text = "Số môn";
            // 
            // panel6
            // 
            panel6.Controls.Add(lbCreditAmount);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(280, 246);
            panel6.Name = "panel6";
            panel6.Size = new Size(225, 128);
            panel6.TabIndex = 10;
            // 
            // lbCreditAmount
            // 
            lbCreditAmount.BackColor = Color.White;
            lbCreditAmount.BorderStyle = BorderStyle.FixedSingle;
            lbCreditAmount.Font = new Font("Times New Roman", 15.000001F);
            lbCreditAmount.ForeColor = Color.Black;
            lbCreditAmount.Location = new Point(28, 66);
            lbCreditAmount.Margin = new Padding(4);
            lbCreditAmount.Name = "lbCreditAmount";
            lbCreditAmount.Size = new Size(167, 53);
            lbCreditAmount.TabIndex = 8;
            lbCreditAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.000001F);
            label4.ForeColor = Color.FromArgb(16, 156, 241);
            label4.Location = new Point(28, 16);
            label4.Name = "label4";
            label4.Size = new Size(153, 41);
            label4.TabIndex = 0;
            label4.Text = "Số tín chỉ";
            // 
            // panel7
            // 
            panel7.Controls.Add(lbMoneySum);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(504, 246);
            panel7.Name = "panel7";
            panel7.Size = new Size(291, 128);
            panel7.TabIndex = 11;
            // 
            // lbMoneySum
            // 
            lbMoneySum.BackColor = Color.White;
            lbMoneySum.BorderStyle = BorderStyle.FixedSingle;
            lbMoneySum.Font = new Font("Times New Roman", 15.000001F);
            lbMoneySum.ForeColor = Color.Black;
            lbMoneySum.Location = new Point(28, 66);
            lbMoneySum.Margin = new Padding(4);
            lbMoneySum.Name = "lbMoneySum";
            lbMoneySum.Size = new Size(232, 53);
            lbMoneySum.TabIndex = 8;
            lbMoneySum.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.000001F);
            label5.ForeColor = Color.FromArgb(16, 156, 241);
            label5.Location = new Point(28, 16);
            label5.Name = "label5";
            label5.Size = new Size(151, 41);
            label5.TabIndex = 0;
            label5.Text = "Tổng tiền";
            // 
            // btnDelete
            // 
            btnDelete.AllowDrop = true;
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(21, 44, 112);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1212, 426);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(186, 60);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // tctAddSubject
            // 
            tctAddSubject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tctAddSubject.Controls.Add(tpOpenSubject);
            tctAddSubject.Controls.Add(tpSelectedSubject);
            tctAddSubject.Font = new Font("Times New Roman", 15.000001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tctAddSubject.ItemSize = new Size(210, 60);
            tctAddSubject.Location = new Point(80, 411);
            tctAddSubject.Margin = new Padding(4);
            tctAddSubject.Name = "tctAddSubject";
            tctAddSubject.SelectedIndex = 0;
            tctAddSubject.Size = new Size(1414, 568);
            tctAddSubject.TabIndex = 19;
            tctAddSubject.DrawItem += tctAddSubject_DrawItem;
            // 
            // tpOpenSubject
            // 
            tpOpenSubject.BackColor = Color.FromArgb(241, 251, 255);
            tpOpenSubject.Controls.Add(pSearchBar);
            tpOpenSubject.Controls.Add(btnAdd);
            tpOpenSubject.Controls.Add(dgvOpenSubject);
            tpOpenSubject.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tpOpenSubject.ForeColor = Color.Black;
            tpOpenSubject.Location = new Point(4, 64);
            tpOpenSubject.Margin = new Padding(4);
            tpOpenSubject.Name = "tpOpenSubject";
            tpOpenSubject.Padding = new Padding(4);
            tpOpenSubject.Size = new Size(1406, 500);
            tpOpenSubject.TabIndex = 0;
            tpOpenSubject.Text = "Môn học mở";
            // 
            // pSearchBar
            // 
            pSearchBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pSearchBar.BackColor = Color.White;
            pSearchBar.BorderStyle = BorderStyle.FixedSingle;
            pSearchBar.Controls.Add(tbSearch);
            pSearchBar.Controls.Add(picSearch);
            pSearchBar.Location = new Point(4, 4);
            pSearchBar.Margin = new Padding(4);
            pSearchBar.Name = "pSearchBar";
            pSearchBar.Size = new Size(1392, 65);
            pSearchBar.TabIndex = 21;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbSearch.BorderStyle = BorderStyle.None;
            tbSearch.Font = new Font("Times New Roman", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(64, 12);
            tbSearch.Margin = new Padding(4);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Tìm kiếm";
            tbSearch.Size = new Size(1320, 38);
            tbSearch.TabIndex = 0;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // picSearch
            // 
            picSearch.Image = Properties.Resources.Search;
            picSearch.Location = new Point(15, 12);
            picSearch.Margin = new Padding(4);
            picSearch.Name = "picSearch";
            picSearch.Size = new Size(44, 39);
            picSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            picSearch.TabIndex = 7;
            picSearch.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.AllowDrop = true;
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(21, 44, 112);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1212, 426);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(186, 60);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // tpSelectedSubject
            // 
            tpSelectedSubject.BackColor = Color.FromArgb(241, 251, 255);
            tpSelectedSubject.Controls.Add(dgvSelectedSubject);
            tpSelectedSubject.Controls.Add(btnDelete);
            tpSelectedSubject.Location = new Point(4, 64);
            tpSelectedSubject.Margin = new Padding(4);
            tpSelectedSubject.Name = "tpSelectedSubject";
            tpSelectedSubject.Padding = new Padding(4);
            tpSelectedSubject.Size = new Size(1406, 500);
            tpSelectedSubject.TabIndex = 1;
            tpSelectedSubject.Text = "Môn đã chọn";
            // 
            // dgvSelectedSubject
            // 
            dgvSelectedSubject.AllowUserToAddRows = false;
            dgvSelectedSubject.AllowUserToDeleteRows = false;
            dgvSelectedSubject.AllowUserToResizeColumns = false;
            dgvSelectedSubject.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = Color.White;
            dataGridViewCellStyle16.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle16.ForeColor = Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = Color.White;
            dataGridViewCellStyle16.SelectionForeColor = Color.FromArgb(16, 156, 241);
            dgvSelectedSubject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dgvSelectedSubject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSelectedSubject.BackgroundColor = Color.White;
            dgvSelectedSubject.BorderStyle = BorderStyle.None;
            dgvSelectedSubject.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvSelectedSubject.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = Color.White;
            dataGridViewCellStyle17.Font = new Font("Times New Roman", 15.000001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle17.ForeColor = Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = Color.White;
            dataGridViewCellStyle17.SelectionForeColor = Color.Black;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dgvSelectedSubject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dgvSelectedSubject.ColumnHeadersHeight = 70;
            dgvSelectedSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSelectedSubject.Columns.AddRange(new DataGridViewColumn[] { CheckBox_Selected, MaMH_Selected, TenMH_Selected, TenLoaiMon_Selected, SoTC_Selected, SoTiet_Selected, MaMo_Selected, MaLoaiMon_Selected });
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = Color.White;
            dataGridViewCellStyle18.Font = new Font("Times New Roman", 15.000001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle18.ForeColor = Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = Color.White;
            dataGridViewCellStyle18.SelectionForeColor = Color.FromArgb(16, 156, 241);
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            dgvSelectedSubject.DefaultCellStyle = dataGridViewCellStyle18;
            dgvSelectedSubject.EnableHeadersVisualStyles = false;
            dgvSelectedSubject.GridColor = Color.Black;
            dgvSelectedSubject.Location = new Point(4, 4);
            dgvSelectedSubject.Margin = new Padding(4);
            dgvSelectedSubject.Name = "dgvSelectedSubject";
            dgvSelectedSubject.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = SystemColors.Control;
            dataGridViewCellStyle19.Font = new Font("Times New Roman", 15.000001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle19.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = Color.White;
            dataGridViewCellStyle19.SelectionForeColor = Color.Black;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dgvSelectedSubject.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dgvSelectedSubject.RowHeadersVisible = false;
            dgvSelectedSubject.RowHeadersWidth = 60;
            dataGridViewCellStyle20.BackColor = Color.White;
            dataGridViewCellStyle20.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle20.ForeColor = Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = Color.White;
            dataGridViewCellStyle20.SelectionForeColor = Color.FromArgb(16, 156, 241);
            dgvSelectedSubject.RowsDefaultCellStyle = dataGridViewCellStyle20;
            dgvSelectedSubject.RowTemplate.Height = 65;
            dgvSelectedSubject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSelectedSubject.ShowCellErrors = false;
            dgvSelectedSubject.ShowCellToolTips = false;
            dgvSelectedSubject.ShowEditingIcon = false;
            dgvSelectedSubject.ShowRowErrors = false;
            dgvSelectedSubject.Size = new Size(1394, 417);
            dgvSelectedSubject.TabIndex = 19;
            dgvSelectedSubject.RowsAdded += dgvSelectedSubject_RowsAdded;
            dgvSelectedSubject.RowsRemoved += dgvSelectedSubject_RowsRemoved;
            // 
            // CheckBox_Selected
            // 
            CheckBox_Selected.DataPropertyName = "CheckBox_Selected";
            CheckBox_Selected.FillWeight = 14.9625931F;
            CheckBox_Selected.HeaderText = "";
            CheckBox_Selected.MinimumWidth = 6;
            CheckBox_Selected.Name = "CheckBox_Selected";
            CheckBox_Selected.Width = 50;
            // 
            // MaMH_Selected
            // 
            MaMH_Selected.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaMH_Selected.DataPropertyName = "MaMH";
            MaMH_Selected.FillWeight = 138.064758F;
            MaMH_Selected.HeaderText = "Mã môn";
            MaMH_Selected.MinimumWidth = 6;
            MaMH_Selected.Name = "MaMH_Selected";
            // 
            // TenMH_Selected
            // 
            TenMH_Selected.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenMH_Selected.DataPropertyName = "TenMH";
            TenMH_Selected.FillWeight = 128.229675F;
            TenMH_Selected.HeaderText = "Tên môn";
            TenMH_Selected.MinimumWidth = 6;
            TenMH_Selected.Name = "TenMH_Selected";
            // 
            // TenLoaiMon_Selected
            // 
            TenLoaiMon_Selected.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenLoaiMon_Selected.DataPropertyName = "TenLoaiMon";
            TenLoaiMon_Selected.FillWeight = 120.5517F;
            TenLoaiMon_Selected.HeaderText = "Loại môn";
            TenLoaiMon_Selected.MinimumWidth = 6;
            TenLoaiMon_Selected.Name = "TenLoaiMon_Selected";
            // 
            // SoTC_Selected
            // 
            SoTC_Selected.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoTC_Selected.DataPropertyName = "SoTC";
            SoTC_Selected.FillWeight = 114.981415F;
            SoTC_Selected.HeaderText = "Số tín chỉ";
            SoTC_Selected.MinimumWidth = 6;
            SoTC_Selected.Name = "SoTC_Selected";
            // 
            // SoTiet_Selected
            // 
            SoTiet_Selected.DataPropertyName = "SoTiet";
            SoTiet_Selected.FillWeight = 83.2098846F;
            SoTiet_Selected.HeaderText = "Số tiết";
            SoTiet_Selected.MinimumWidth = 6;
            SoTiet_Selected.Name = "SoTiet_Selected";
            SoTiet_Selected.Width = 125;
            // 
            // MaMo_Selected
            // 
            MaMo_Selected.DataPropertyName = "MaMo";
            MaMo_Selected.HeaderText = "Mã mở";
            MaMo_Selected.MinimumWidth = 6;
            MaMo_Selected.Name = "MaMo_Selected";
            MaMo_Selected.Visible = false;
            MaMo_Selected.Width = 125;
            // 
            // MaLoaiMon_Selected
            // 
            MaLoaiMon_Selected.DataPropertyName = "MaLoaiMon";
            MaLoaiMon_Selected.HeaderText = "Mã loại môn";
            MaLoaiMon_Selected.MinimumWidth = 6;
            MaLoaiMon_Selected.Name = "MaLoaiMon_Selected";
            MaLoaiMon_Selected.Visible = false;
            MaLoaiMon_Selected.Width = 125;
            // 
            // fAddRegister
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 251, 255);
            ClientSize = new Size(1596, 1016);
            Controls.Add(tctAddSubject);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(btnConfirm);
            Controls.Add(panel1);
            Controls.Add(pTitleInforAddStudyProgram);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "fAddRegister";
            Text = "Thêm chương trình học";
            Load += fAddRegister_Load;
            Shown += fAddRegister_Shown;
            pTitleInforAddStudyProgram.ResumeLayout(false);
            pTitleInforAddStudyProgram.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOpenSubject).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            tctAddSubject.ResumeLayout(false);
            tpOpenSubject.ResumeLayout(false);
            pSearchBar.ResumeLayout(false);
            pSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSearch).EndInit();
            tpSelectedSubject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSelectedSubject).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pTitleInforAddStudyProgram;
        private Label lInfo;
        private Panel panel4;
        private Label lStudentID;
        private Panel panel1;
        private Label lSchoolYear;
        private Button btnConfirm;
        private DataGridView dgvOpenSubject;
        private Panel panel2;
        private Label lDateCreate;
        private Panel panel3;
        private Label lSemester;
        private TextBox txbStudentID;
        private DateTimePicker dtpDateCreate;
        private Label lbSchoolYear;
        private Label lbSemester;
        private Panel panel5;
        private Label lbSubAmount;
        private Label label2;
        private Panel panel6;
        private Label lbCreditAmount;
        private Label label4;
        private Panel panel7;
        private Label lbMoneySum;
        private Label label5;
        private Button btnDelete;
        private TabControl tctAddSubject;
        private TabPage tpOpenSubject;
        private TabPage tpSelectedSubject;
        private Button btnAdd;
        private DataGridView dgvSelectedSubject;
        private Panel pSearchBar;
        private TextBox tbSearch;
        private PictureBox picSearch;
        private DataGridViewCheckBoxColumn CheckBox;
        private DataGridViewTextBoxColumn MaMH;
        private DataGridViewTextBoxColumn TenMH;
        private DataGridViewTextBoxColumn TenLoaiMon;
        private DataGridViewTextBoxColumn SoTC;
        private DataGridViewTextBoxColumn SoTiet;
        private DataGridViewTextBoxColumn MaMo;
        private DataGridViewTextBoxColumn MaLoaiMon;
        private DataGridViewCheckBoxColumn CheckBox_Selected;
        private DataGridViewTextBoxColumn MaMH_Selected;
        private DataGridViewTextBoxColumn TenMH_Selected;
        private DataGridViewTextBoxColumn TenLoaiMon_Selected;
        private DataGridViewTextBoxColumn SoTC_Selected;
        private DataGridViewTextBoxColumn SoTiet_Selected;
        private DataGridViewTextBoxColumn MaMo_Selected;
        private DataGridViewTextBoxColumn MaLoaiMon_Selected;
    }
}