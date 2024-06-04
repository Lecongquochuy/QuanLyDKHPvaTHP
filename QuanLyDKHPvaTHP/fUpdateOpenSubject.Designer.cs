namespace QuanLyDKHPvaTHP
{
    partial class fUpdateOpenSubject
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
            btnAdd = new Button();
            dataGridView = new DataGridView();
            Number = new DataGridViewTextBoxColumn();
            MaMH = new DataGridViewTextBoxColumn();
            TenMH = new DataGridViewTextBoxColumn();
            TenLoaiMon = new DataGridViewTextBoxColumn();
            SoTC = new DataGridViewTextBoxColumn();
            View = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            btn_Confirm = new Button();
            panel2 = new Panel();
            comboBoxMajor = new ComboBox();
            label1 = new Label();
            panel3 = new Panel();
            comboBoxFaculities = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            labelUOSHocKy = new Label();
            labelInpTenMon = new Label();
            panelInput = new Panel();
            labelUOSNamHoc = new Label();
            labelInpMaMon = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panelInput.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(21, 44, 112);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Times New Roman", 13.8F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(67, 201);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(164, 40);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Thêm môn học";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAddSubject_Click;
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Number, MaMH, TenMH, TenLoaiMon, SoTC, View, Delete });
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
            dataGridView.Location = new Point(67, 249);
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
            dataGridView.Size = new Size(933, 372);
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
            // Delete
            // 
            Delete.Description = "delete";
            Delete.HeaderText = "";
            Delete.Image = Properties.Resources.Delete;
            Delete.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Delete.MinimumWidth = 30;
            Delete.Name = "Delete";
            Delete.Width = 60;
            // 
            // btn_Confirm
            // 
            btn_Confirm.Anchor = AnchorStyles.Bottom;
            btn_Confirm.BackColor = Color.FromArgb(21, 44, 112);
            btn_Confirm.Cursor = Cursors.Hand;
            btn_Confirm.Font = new Font("Times New Roman", 15.000001F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Confirm.ForeColor = Color.White;
            btn_Confirm.Location = new Point(406, 626);
            btn_Confirm.Margin = new Padding(2);
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.Size = new Size(265, 43);
            btn_Confirm.TabIndex = 19;
            btn_Confirm.Text = "Xác nhận";
            btn_Confirm.UseVisualStyleBackColor = false;
            btn_Confirm.Click += btn_Confirm_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBoxMajor);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(457, 101);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(387, 85);
            panel2.TabIndex = 24;
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
            panel3.Location = new Point(67, 101);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(387, 85);
            panel3.TabIndex = 23;
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
            // panel1
            // 
            panel1.Controls.Add(labelUOSHocKy);
            panel1.Controls.Add(labelInpTenMon);
            panel1.Location = new Point(457, 11);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 85);
            panel1.TabIndex = 22;
            // 
            // labelUOSHocKy
            // 
            labelUOSHocKy.BackColor = Color.White;
            labelUOSHocKy.BorderStyle = BorderStyle.FixedSingle;
            labelUOSHocKy.Font = new Font("Times New Roman", 15.000001F);
            labelUOSHocKy.ForeColor = Color.Black;
            labelUOSHocKy.Location = new Point(26, 44);
            labelUOSHocKy.Name = "labelUOSHocKy";
            labelUOSHocKy.Size = new Size(343, 35);
            labelUOSHocKy.TabIndex = 2;
            labelUOSHocKy.Text = "label4";
            labelUOSHocKy.TextAlign = ContentAlignment.MiddleLeft;
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
            panelInput.Controls.Add(labelUOSNamHoc);
            panelInput.Controls.Add(labelInpMaMon);
            panelInput.Location = new Point(67, 11);
            panelInput.Margin = new Padding(2);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(387, 85);
            panelInput.TabIndex = 21;
            // 
            // labelUOSNamHoc
            // 
            labelUOSNamHoc.BackColor = Color.White;
            labelUOSNamHoc.BorderStyle = BorderStyle.FixedSingle;
            labelUOSNamHoc.Font = new Font("Times New Roman", 15.000001F);
            labelUOSNamHoc.ForeColor = Color.Black;
            labelUOSNamHoc.Location = new Point(17, 44);
            labelUOSNamHoc.Name = "labelUOSNamHoc";
            labelUOSNamHoc.Size = new Size(343, 35);
            labelUOSNamHoc.TabIndex = 1;
            labelUOSNamHoc.Text = "label3";
            labelUOSNamHoc.TextAlign = ContentAlignment.MiddleLeft;
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
            // fUpdateOpenSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 251, 255);
            ClientSize = new Size(1064, 677);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panelInput);
            Controls.Add(btn_Confirm);
            Controls.Add(dataGridView);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "fUpdateOpenSubject";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "fOpen_Objects";
            Shown += fAddOpenSubject_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private DataGridView dataGridView;
        private Button btn_Confirm;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn MaMH;
        private DataGridViewTextBoxColumn TenMH;
        private DataGridViewTextBoxColumn TenLoaiMon;
        private DataGridViewTextBoxColumn SoTC;
        private DataGridViewImageColumn View;
        private DataGridViewImageColumn Delete;
        private Panel panel2;
        private ComboBox comboBoxMajor;
        private Label label1;
        private Panel panel3;
        private ComboBox comboBoxFaculities;
        private Label label2;
        private Panel panel1;
        private Label labelInpTenMon;
        private Panel panelInput;
        private Label labelInpMaMon;
        private Label labelUOSNamHoc;
        private Label labelUOSHocKy;
    }
}