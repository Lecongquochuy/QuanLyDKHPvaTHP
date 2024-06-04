namespace QuanLyDKHPvaTHP
{
    partial class fViewOpenSubject
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
            dataGridView = new DataGridView();
            Number = new DataGridViewTextBoxColumn();
            MaMH = new DataGridViewTextBoxColumn();
            TenMH = new DataGridViewTextBoxColumn();
            TenLoaiMon = new DataGridViewTextBoxColumn();
            SoTC = new DataGridViewTextBoxColumn();
            View = new DataGridViewImageColumn();
            panel1 = new Panel();
            comboSemester = new ComboBox();
            labelInpTenMon = new Label();
            panelInput = new Panel();
            comboSchoolYears = new ComboBox();
            labelInpMaMon = new Label();
            btn_ViewOpenSubjectExist = new Button();
            panel2 = new Panel();
            comboBoxMajor = new ComboBox();
            label1 = new Label();
            panel3 = new Panel();
            comboBoxFaculities = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            panelInput.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(16, 156, 241);
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeight = 70;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Number, MaMH, TenMH, TenLoaiMon, SoTC, View });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(16, 156, 241);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.Black;
            dataGridView.Location = new Point(67, 214);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(16, 156, 241);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 60;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(16, 156, 241);
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.RowTemplate.Height = 65;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowCellErrors = false;
            dataGridView.ShowCellToolTips = false;
            dataGridView.ShowEditingIcon = false;
            dataGridView.ShowRowErrors = false;
            dataGridView.Size = new Size(933, 400);
            dataGridView.TabIndex = 16;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // Number
            // 
            Number.DataPropertyName = "STT";
            Number.HeaderText = "STT";
            Number.MinimumWidth = 6;
            Number.Name = "Number";
            Number.Width = 125;
            // 
            // MaMH
            // 
            MaMH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaMH.DataPropertyName = "MaMH";
            MaMH.HeaderText = "Mã môn";
            MaMH.MinimumWidth = 6;
            MaMH.Name = "MaMH";
            // 
            // TenMH
            // 
            TenMH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenMH.DataPropertyName = "TenMH";
            TenMH.HeaderText = "Tên môn";
            TenMH.MinimumWidth = 9;
            TenMH.Name = "TenMH";
            // 
            // TenLoaiMon
            // 
            TenLoaiMon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenLoaiMon.DataPropertyName = "TenLoaiMon";
            TenLoaiMon.HeaderText = "Loại môn";
            TenLoaiMon.MinimumWidth = 6;
            TenLoaiMon.Name = "TenLoaiMon";
            // 
            // SoTC
            // 
            SoTC.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoTC.DataPropertyName = "SoTC";
            SoTC.HeaderText = "Số tín chỉ";
            SoTC.MinimumWidth = 6;
            SoTC.Name = "SoTC";
            // 
            // View
            // 
            View.Description = "view";
            View.HeaderText = "";
            View.Image = Properties.Resources.View;
            View.ImageLayout = DataGridViewImageCellLayout.Stretch;
            View.MinimumWidth = 30;
            View.Name = "View";
            View.Width = 60;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboSemester);
            panel1.Controls.Add(labelInpTenMon);
            panel1.Location = new Point(457, 11);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 85);
            panel1.TabIndex = 18;
            // 
            // comboSemester
            // 
            comboSemester.Font = new Font("Times New Roman", 15.000001F);
            comboSemester.FormattingEnabled = true;
            comboSemester.Location = new Point(26, 43);
            comboSemester.Name = "comboSemester";
            comboSemester.Size = new Size(343, 37);
            comboSemester.TabIndex = 1;
            comboSemester.SelectedIndexChanged += comboSemester_SelectedIndexChanged;
            // 
            // labelInpTenMon
            // 
            labelInpTenMon.AutoSize = true;
            labelInpTenMon.Font = new Font("Times New Roman", 15.000001F);
            labelInpTenMon.ForeColor = Color.FromArgb(16, 156, 241);
            labelInpTenMon.Location = new Point(20, 11);
            labelInpTenMon.Margin = new Padding(2, 0, 2, 0);
            labelInpTenMon.Name = "labelInpTenMon";
            labelInpTenMon.Size = new Size(90, 29);
            labelInpTenMon.TabIndex = 0;
            labelInpTenMon.Text = "Học kỳ";
            // 
            // panelInput
            // 
            panelInput.Controls.Add(comboSchoolYears);
            panelInput.Controls.Add(labelInpMaMon);
            panelInput.Location = new Point(67, 11);
            panelInput.Margin = new Padding(2);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(387, 85);
            panelInput.TabIndex = 17;
            // 
            // comboSchoolYears
            // 
            comboSchoolYears.Font = new Font("Times New Roman", 15.000001F);
            comboSchoolYears.FormattingEnabled = true;
            comboSchoolYears.Location = new Point(17, 43);
            comboSchoolYears.Name = "comboSchoolYears";
            comboSchoolYears.Size = new Size(343, 37);
            comboSchoolYears.TabIndex = 2;
            comboSchoolYears.SelectedIndexChanged += comboSchoolYears_SelectedIndexChanged;
            // 
            // labelInpMaMon
            // 
            labelInpMaMon.AutoSize = true;
            labelInpMaMon.Font = new Font("Times New Roman", 15.000001F);
            labelInpMaMon.ForeColor = Color.FromArgb(16, 156, 241);
            labelInpMaMon.Location = new Point(17, 11);
            labelInpMaMon.Margin = new Padding(2, 0, 2, 0);
            labelInpMaMon.Name = "labelInpMaMon";
            labelInpMaMon.Size = new Size(109, 29);
            labelInpMaMon.TabIndex = 0;
            labelInpMaMon.Text = "Năm học";
            // 
            // btn_ViewOpenSubjectExist
            // 
            btn_ViewOpenSubjectExist.Anchor = AnchorStyles.Bottom;
            btn_ViewOpenSubjectExist.BackColor = Color.DarkRed;
            btn_ViewOpenSubjectExist.Cursor = Cursors.Hand;
            btn_ViewOpenSubjectExist.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ViewOpenSubjectExist.ForeColor = Color.White;
            btn_ViewOpenSubjectExist.Location = new Point(457, 628);
            btn_ViewOpenSubjectExist.Margin = new Padding(2);
            btn_ViewOpenSubjectExist.Name = "btn_ViewOpenSubjectExist";
            btn_ViewOpenSubjectExist.Size = new Size(215, 47);
            btn_ViewOpenSubjectExist.TabIndex = 19;
            btn_ViewOpenSubjectExist.Text = "Thoát";
            btn_ViewOpenSubjectExist.UseVisualStyleBackColor = false;
            btn_ViewOpenSubjectExist.Click += btn_ViewOpenSubjectExist_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBoxMajor);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(457, 109);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(387, 85);
            panel2.TabIndex = 20;
            // 
            // comboBoxMajor
            // 
            comboBoxMajor.Font = new Font("Times New Roman", 15.000001F);
            comboBoxMajor.FormattingEnabled = true;
            comboBoxMajor.Location = new Point(26, 43);
            comboBoxMajor.Name = "comboBoxMajor";
            comboBoxMajor.Size = new Size(343, 37);
            comboBoxMajor.TabIndex = 1;
            comboBoxMajor.SelectedIndexChanged += comboBoxMajor_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.000001F);
            label1.ForeColor = Color.FromArgb(16, 156, 241);
            label1.Location = new Point(20, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 29);
            label1.TabIndex = 0;
            label1.Text = "Ngành";
            // 
            // panel3
            // 
            panel3.Controls.Add(comboBoxFaculities);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(67, 109);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(387, 85);
            panel3.TabIndex = 19;
            // 
            // comboBoxFaculities
            // 
            comboBoxFaculities.Font = new Font("Times New Roman", 15.000001F);
            comboBoxFaculities.FormattingEnabled = true;
            comboBoxFaculities.Location = new Point(17, 43);
            comboBoxFaculities.Name = "comboBoxFaculities";
            comboBoxFaculities.Size = new Size(343, 37);
            comboBoxFaculities.TabIndex = 2;
            comboBoxFaculities.SelectedIndexChanged += comboBoxFaculities_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.000001F);
            label2.ForeColor = Color.FromArgb(16, 156, 241);
            label2.Location = new Point(17, 11);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 29);
            label2.TabIndex = 0;
            label2.Text = "Khoa";
            // 
            // fViewOpenSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 251, 255);
            ClientSize = new Size(1064, 677);
            Controls.Add(panel2);
            Controls.Add(btn_ViewOpenSubjectExist);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panelInput);
            Controls.Add(dataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "fViewOpenSubject";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "fOpen_Objects";
            Shown += fViewOpenSubject_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView;
        private Panel panel1;
        private Label labelInpTenMon;
        private Panel panelInput;
        private Label labelInpMaMon;
        private ComboBox comboSemester;
        private ComboBox comboSchoolYears;
        private Button btn_ViewOpenSubjectExist;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn MaMH;
        private DataGridViewTextBoxColumn TenMH;
        private DataGridViewTextBoxColumn TenLoaiMon;
        private DataGridViewTextBoxColumn SoTC;
        private DataGridViewImageColumn View;
        private Panel panel2;
        private ComboBox comboBoxMajor;
        private Label label1;
        private Panel panel3;
        private ComboBox comboBoxFaculities;
        private Label label2;
    }
}