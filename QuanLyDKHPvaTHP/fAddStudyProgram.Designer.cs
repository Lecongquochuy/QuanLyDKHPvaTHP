namespace QuanLyDKHPvaTHP
{
    partial class fAddStudyProgram
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pTitleAddStudyProgram = new Panel();
            lAddStudyProgram = new Label();
            pTitleInforAddStudyProgram = new Panel();
            lTitleInfoAddStudyProgram = new Label();
            panel4 = new Panel();
            comboFaculties = new ComboBox();
            lFaculties = new Label();
            panel1 = new Panel();
            comboMajor = new ComboBox();
            lMajor = new Label();
            btnAddSubject = new Button();
            btnConfirm = new Button();
            dtgvAddStudyProgram = new DataGridView();
            lSemesterHeader = new DataGridViewTextBoxColumn();
            lSubjectIDHeader = new DataGridViewTextBoxColumn();
            lSubjectNameHeader = new DataGridViewTextBoxColumn();
            lSubjectTypeHeader = new DataGridViewTextBoxColumn();
            lCreditHeader = new DataGridViewTextBoxColumn();
            View = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel2 = new Panel();
            lSubAmount = new Label();
            label1 = new Label();
            panel3 = new Panel();
            lCreditAmountTheory = new Label();
            label3 = new Label();
            lCreditAmountPractice = new Label();
            label4 = new Label();
            panel5 = new Panel();
            pTitleAddStudyProgram.SuspendLayout();
            pTitleInforAddStudyProgram.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAddStudyProgram).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // pTitleAddStudyProgram
            // 
            pTitleAddStudyProgram.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pTitleAddStudyProgram.BackColor = Color.FromArgb(21, 44, 112);
            pTitleAddStudyProgram.Controls.Add(lAddStudyProgram);
            pTitleAddStudyProgram.Location = new Point(0, 0);
            pTitleAddStudyProgram.Name = "pTitleAddStudyProgram";
            pTitleAddStudyProgram.Size = new Size(1598, 110);
            pTitleAddStudyProgram.TabIndex = 1;
            // 
            // lAddStudyProgram
            // 
            lAddStudyProgram.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lAddStudyProgram.Font = new Font("Times New Roman", 30.0000019F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lAddStudyProgram.ForeColor = Color.Transparent;
            lAddStudyProgram.Location = new Point(0, 0);
            lAddStudyProgram.Name = "lAddStudyProgram";
            lAddStudyProgram.Size = new Size(1598, 110);
            lAddStudyProgram.TabIndex = 0;
            lAddStudyProgram.Text = "Thông tin chương trình học";
            lAddStudyProgram.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pTitleInforAddStudyProgram
            // 
            pTitleInforAddStudyProgram.Controls.Add(lTitleInfoAddStudyProgram);
            pTitleInforAddStudyProgram.Font = new Font("Times New Roman", 20.1428585F, FontStyle.Bold);
            pTitleInforAddStudyProgram.ForeColor = Color.DarkBlue;
            pTitleInforAddStudyProgram.Location = new Point(100, 112);
            pTitleInforAddStudyProgram.Name = "pTitleInforAddStudyProgram";
            pTitleInforAddStudyProgram.Size = new Size(788, 98);
            pTitleInforAddStudyProgram.TabIndex = 2;
            // 
            // lTitleInfoAddStudyProgram
            // 
            lTitleInfoAddStudyProgram.AutoSize = true;
            lTitleInfoAddStudyProgram.Font = new Font("Times New Roman", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lTitleInfoAddStudyProgram.ForeColor = Color.FromArgb(21, 44, 112);
            lTitleInfoAddStudyProgram.Location = new Point(80, 24);
            lTitleInfoAddStudyProgram.Name = "lTitleInfoAddStudyProgram";
            lTitleInfoAddStudyProgram.Size = new Size(585, 55);
            lTitleInfoAddStudyProgram.TabIndex = 0;
            lTitleInfoAddStudyProgram.Text = "Thông tin chương trình học";
            lTitleInfoAddStudyProgram.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(comboFaculties);
            panel4.Controls.Add(lFaculties);
            panel4.Location = new Point(100, 218);
            panel4.Name = "panel4";
            panel4.Size = new Size(580, 128);
            panel4.TabIndex = 3;
            // 
            // comboFaculties
            // 
            comboFaculties.Font = new Font("Times New Roman", 15.000001F);
            comboFaculties.ForeColor = Color.Black;
            comboFaculties.FormattingEnabled = true;
            comboFaculties.Location = new Point(28, 64);
            comboFaculties.Name = "comboFaculties";
            comboFaculties.Size = new Size(522, 48);
            comboFaculties.TabIndex = 4;
            comboFaculties.SelectedIndexChanged += comboFaculties_SelectedIndexChanged;
            // 
            // lFaculties
            // 
            lFaculties.AutoSize = true;
            lFaculties.Font = new Font("Times New Roman", 15.000001F);
            lFaculties.ForeColor = Color.FromArgb(16, 156, 241);
            lFaculties.Location = new Point(28, 16);
            lFaculties.Name = "lFaculties";
            lFaculties.Size = new Size(95, 41);
            lFaculties.TabIndex = 0;
            lFaculties.Text = "Khoa";
            // 
            // panel1
            // 
            panel1.Controls.Add(comboMajor);
            panel1.Controls.Add(lMajor);
            panel1.Location = new Point(686, 218);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 128);
            panel1.TabIndex = 5;
            // 
            // comboMajor
            // 
            comboMajor.Font = new Font("Times New Roman", 15.000001F);
            comboMajor.ForeColor = Color.Black;
            comboMajor.FormattingEnabled = true;
            comboMajor.Location = new Point(28, 64);
            comboMajor.Name = "comboMajor";
            comboMajor.Size = new Size(522, 48);
            comboMajor.TabIndex = 4;
            // 
            // lMajor
            // 
            lMajor.AutoSize = true;
            lMajor.Font = new Font("Times New Roman", 15.000001F);
            lMajor.ForeColor = Color.FromArgb(16, 156, 241);
            lMajor.Location = new Point(28, 16);
            lMajor.Name = "lMajor";
            lMajor.Size = new Size(173, 41);
            lMajor.TabIndex = 0;
            lMajor.Text = "Ngành học";
            // 
            // btnAddSubject
            // 
            btnAddSubject.AllowDrop = true;
            btnAddSubject.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddSubject.BackColor = Color.FromArgb(21, 44, 112);
            btnAddSubject.Cursor = Cursors.Hand;
            btnAddSubject.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSubject.ForeColor = Color.White;
            btnAddSubject.Location = new Point(1282, 405);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(218, 60);
            btnAddSubject.TabIndex = 6;
            btnAddSubject.Text = "Thêm môn";
            btnAddSubject.UseVisualStyleBackColor = false;
            btnAddSubject.Click += btnAddSubject_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Bottom;
            btnConfirm.BackColor = Color.FromArgb(21, 44, 112);
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.Font = new Font("Times New Roman", 20.1428585F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(594, 933);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(405, 70);
            btnConfirm.TabIndex = 9;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // dtgvAddStudyProgram
            // 
            dtgvAddStudyProgram.AllowUserToAddRows = false;
            dtgvAddStudyProgram.AllowUserToDeleteRows = false;
            dtgvAddStudyProgram.AllowUserToResizeColumns = false;
            dtgvAddStudyProgram.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(16, 156, 241);
            dtgvAddStudyProgram.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgvAddStudyProgram.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvAddStudyProgram.BackgroundColor = Color.White;
            dtgvAddStudyProgram.BorderStyle = BorderStyle.None;
            dtgvAddStudyProgram.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtgvAddStudyProgram.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgvAddStudyProgram.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgvAddStudyProgram.ColumnHeadersHeight = 51;
            dtgvAddStudyProgram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgvAddStudyProgram.Columns.AddRange(new DataGridViewColumn[] { lSemesterHeader, lSubjectIDHeader, lSubjectNameHeader, lSubjectTypeHeader, lCreditHeader, View, Delete });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(16, 156, 241);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgvAddStudyProgram.DefaultCellStyle = dataGridViewCellStyle3;
            dtgvAddStudyProgram.EnableHeadersVisualStyles = false;
            dtgvAddStudyProgram.GridColor = Color.Black;
            dtgvAddStudyProgram.Location = new Point(100, 496);
            dtgvAddStudyProgram.Margin = new Padding(4, 4, 4, 4);
            dtgvAddStudyProgram.Name = "dtgvAddStudyProgram";
            dtgvAddStudyProgram.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgvAddStudyProgram.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgvAddStudyProgram.RowHeadersVisible = false;
            dtgvAddStudyProgram.RowHeadersWidth = 70;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(16, 156, 241);
            dtgvAddStudyProgram.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dtgvAddStudyProgram.RowTemplate.Height = 65;
            dtgvAddStudyProgram.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvAddStudyProgram.ShowCellErrors = false;
            dtgvAddStudyProgram.ShowCellToolTips = false;
            dtgvAddStudyProgram.ShowEditingIcon = false;
            dtgvAddStudyProgram.ShowRowErrors = false;
            dtgvAddStudyProgram.Size = new Size(1400, 429);
            dtgvAddStudyProgram.TabIndex = 17;
            dtgvAddStudyProgram.CellContentClick += dtgvAddStudyProgram_CellContentClick;
            dtgvAddStudyProgram.RowsAdded += dtgvAddStudyProgram_RowsAdded;
            dtgvAddStudyProgram.RowsRemoved += dtgvAddStudyProgram_RowsRemoved;
            // 
            // lSemesterHeader
            // 
            lSemesterHeader.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lSemesterHeader.DataPropertyName = "Học kỳ";
            lSemesterHeader.HeaderText = "Học kỳ";
            lSemesterHeader.MinimumWidth = 6;
            lSemesterHeader.Name = "lSemesterHeader";
            // 
            // lSubjectIDHeader
            // 
            lSubjectIDHeader.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lSubjectIDHeader.DataPropertyName = "Mã môn";
            lSubjectIDHeader.HeaderText = "Mã môn";
            lSubjectIDHeader.MinimumWidth = 6;
            lSubjectIDHeader.Name = "lSubjectIDHeader";
            // 
            // lSubjectNameHeader
            // 
            lSubjectNameHeader.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lSubjectNameHeader.DataPropertyName = "Tên môn";
            lSubjectNameHeader.HeaderText = "Tên môn";
            lSubjectNameHeader.MinimumWidth = 6;
            lSubjectNameHeader.Name = "lSubjectNameHeader";
            // 
            // lSubjectTypeHeader
            // 
            lSubjectTypeHeader.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lSubjectTypeHeader.DataPropertyName = "Loại môn";
            lSubjectTypeHeader.HeaderText = "Loại môn";
            lSubjectTypeHeader.MinimumWidth = 6;
            lSubjectTypeHeader.Name = "lSubjectTypeHeader";
            // 
            // lCreditHeader
            // 
            lCreditHeader.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lCreditHeader.DataPropertyName = "Số tín chỉ";
            lCreditHeader.HeaderText = "Số tín chỉ";
            lCreditHeader.MinimumWidth = 6;
            lCreditHeader.Name = "lCreditHeader";
            // 
            // View
            // 
            View.HeaderText = "";
            View.Image = Properties.Resources.View;
            View.ImageLayout = DataGridViewImageCellLayout.Stretch;
            View.MinimumWidth = 6;
            View.Name = "View";
            View.Width = 40;
            // 
            // Delete
            // 
            Delete.HeaderText = "";
            Delete.Image = Properties.Resources.Delete;
            Delete.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 40;
            // 
            // panel2
            // 
            panel2.Controls.Add(lSubAmount);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(100, 362);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 128);
            panel2.TabIndex = 5;
            // 
            // lSubAmount
            // 
            lSubAmount.BackColor = Color.White;
            lSubAmount.BorderStyle = BorderStyle.FixedSingle;
            lSubAmount.Font = new Font("Times New Roman", 15.000001F);
            lSubAmount.ForeColor = Color.Black;
            lSubAmount.Location = new Point(28, 64);
            lSubAmount.Margin = new Padding(4, 4, 4, 4);
            lSubAmount.Name = "lSubAmount";
            lSubAmount.Size = new Size(138, 53);
            lSubAmount.TabIndex = 9;
            lSubAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.000001F);
            label1.ForeColor = Color.FromArgb(16, 156, 241);
            label1.Location = new Point(28, 16);
            label1.Name = "label1";
            label1.Size = new Size(126, 41);
            label1.TabIndex = 0;
            label1.Text = "Số môn";
            // 
            // panel3
            // 
            panel3.Controls.Add(lCreditAmountTheory);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(302, 362);
            panel3.Name = "panel3";
            panel3.Size = new Size(380, 128);
            panel3.TabIndex = 10;
            // 
            // lCreditAmountTheory
            // 
            lCreditAmountTheory.BackColor = Color.White;
            lCreditAmountTheory.BorderStyle = BorderStyle.FixedSingle;
            lCreditAmountTheory.Font = new Font("Times New Roman", 15.000001F);
            lCreditAmountTheory.ForeColor = Color.Black;
            lCreditAmountTheory.Location = new Point(28, 64);
            lCreditAmountTheory.Margin = new Padding(4, 4, 4, 4);
            lCreditAmountTheory.Name = "lCreditAmountTheory";
            lCreditAmountTheory.Size = new Size(314, 53);
            lCreditAmountTheory.TabIndex = 9;
            lCreditAmountTheory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.000001F);
            label3.ForeColor = Color.FromArgb(16, 156, 241);
            label3.Location = new Point(28, 16);
            label3.Name = "label3";
            label3.Size = new Size(286, 41);
            label3.TabIndex = 0;
            label3.Text = "Số tín chỉ lý thuyết";
            // 
            // lCreditAmountPractice
            // 
            lCreditAmountPractice.BackColor = Color.White;
            lCreditAmountPractice.BorderStyle = BorderStyle.FixedSingle;
            lCreditAmountPractice.Font = new Font("Times New Roman", 15.000001F);
            lCreditAmountPractice.ForeColor = Color.Black;
            lCreditAmountPractice.Location = new Point(28, 64);
            lCreditAmountPractice.Margin = new Padding(4, 4, 4, 4);
            lCreditAmountPractice.Name = "lCreditAmountPractice";
            lCreditAmountPractice.Size = new Size(314, 53);
            lCreditAmountPractice.TabIndex = 9;
            lCreditAmountPractice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.000001F);
            label4.ForeColor = Color.FromArgb(16, 156, 241);
            label4.Location = new Point(28, 16);
            label4.Name = "label4";
            label4.Size = new Size(303, 41);
            label4.TabIndex = 0;
            label4.Text = "Số tín chỉ thực hành";
            // 
            // panel5
            // 
            panel5.Controls.Add(lCreditAmountPractice);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(687, 362);
            panel5.Name = "panel5";
            panel5.Size = new Size(380, 128);
            panel5.TabIndex = 11;
            // 
            // fAddStudyProgram
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 251, 255);
            ClientSize = new Size(1596, 1016);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dtgvAddStudyProgram);
            Controls.Add(btnConfirm);
            Controls.Add(btnAddSubject);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(pTitleInforAddStudyProgram);
            Controls.Add(pTitleAddStudyProgram);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "fAddStudyProgram";
            Text = "Thêm chương trình học";
            Shown += fAddStudyProgram_Shown;
            pTitleAddStudyProgram.ResumeLayout(false);
            pTitleInforAddStudyProgram.ResumeLayout(false);
            pTitleInforAddStudyProgram.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAddStudyProgram).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pTitleAddStudyProgram;
        private Label lAddStudyProgram;
        private Panel pTitleInforAddStudyProgram;
        private Label lTitleInfoAddStudyProgram;
        private Panel panel4;
        private ComboBox comboFaculties;
        private Label lFaculties;
        private Panel panel1;
        private ComboBox comboMajor;
        private Label lMajor;
        private Button btnAddSubject;
        private Button btnConfirm;
        private DataGridView dtgvAddStudyProgram;
        private DataGridViewTextBoxColumn lSemesterHeader;
        private DataGridViewTextBoxColumn lSubjectIDHeader;
        private DataGridViewTextBoxColumn lSubjectNameHeader;
        private DataGridViewTextBoxColumn lSubjectTypeHeader;
        private DataGridViewTextBoxColumn lCreditHeader;
        private DataGridViewImageColumn View;
        private DataGridViewImageColumn Delete;
        private Panel panel2;
        private Label label1;
        private Label lSubAmount;
        private Panel panel3;
        private Label lCreditAmountTheory;
        private Label label3;
        private Label lCreditAmountPractice;
        private Label label4;
        private Panel panel5;
    }
}