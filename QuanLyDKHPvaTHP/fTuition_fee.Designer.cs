namespace QuanLyDKHPvaTHP
{
    partial class fTuition_fee
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            pSearchBar = new Panel();
            tbSearch = new TextBox();
            picSearch = new PictureBox();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            Number = new DataGridViewTextBoxColumn();
            lTuitionFeeID = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Moneys = new DataGridViewTextBoxColumn();
            View = new DataGridViewImageColumn();
            pSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pSearchBar
            // 
            pSearchBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pSearchBar.BackColor = Color.White;
            pSearchBar.BorderStyle = BorderStyle.FixedSingle;
            pSearchBar.Controls.Add(tbSearch);
            pSearchBar.Controls.Add(picSearch);
            pSearchBar.Location = new Point(100, 100);
            pSearchBar.Margin = new Padding(4);
            pSearchBar.Name = "pSearchBar";
            pSearchBar.Size = new Size(1400, 65);
            pSearchBar.TabIndex = 14;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbSearch.BorderStyle = BorderStyle.None;
            tbSearch.Font = new Font("Times New Roman", 14.1428576F);
            tbSearch.Location = new Point(63, 13);
            tbSearch.Margin = new Padding(4);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Tìm kiếm";
            tbSearch.Size = new Size(1296, 38);
            tbSearch.TabIndex = 0;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // picSearch
            // 
            picSearch.Image = Properties.Resources.Search;
            picSearch.Location = new Point(15, 12);
            picSearch.Margin = new Padding(4);
            picSearch.Name = "picSearch";
            picSearch.Size = new Size(43, 39);
            picSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            picSearch.TabIndex = 7;
            picSearch.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(21, 44, 112);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Times New Roman", 13.8F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(100, 200);
            btnAdd.Margin = new Padding(8);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(218, 60);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(16, 156, 241);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = Color.Blue;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeight = 70;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Number, lTuitionFeeID, Student, Date, Moneys, View });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(16, 156, 241);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(100, 300);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.White;
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(16, 156, 241);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 60;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(16, 156, 241);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.RowTemplate.Height = 65;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(1400, 673);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Number
            // 
            Number.DataPropertyName = "STT";
            Number.HeaderText = "STT";
            Number.MinimumWidth = 6;
            Number.Name = "Number";
            Number.Width = 125;
            // 
            // lTuitionFeeID
            // 
            lTuitionFeeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lTuitionFeeID.DataPropertyName = "MaPhieuThu";
            lTuitionFeeID.HeaderText = "Mã phiếu thu";
            lTuitionFeeID.MinimumWidth = 6;
            lTuitionFeeID.Name = "lTuitionFeeID";
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "HoTen";
            Student.HeaderText = "Sinh viên";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Date.DataPropertyName = "NgayLap";
            Date.HeaderText = "Ngày thu";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            // 
            // Moneys
            // 
            Moneys.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Moneys.DataPropertyName = "SoTienThu";
            Moneys.HeaderText = "Số tiền thu";
            Moneys.MinimumWidth = 6;
            Moneys.Name = "Moneys";
            // 
            // View
            // 
            View.HeaderText = "";
            View.Image = Properties.Resources.View;
            View.ImageLayout = DataGridViewImageCellLayout.Stretch;
            View.MinimumWidth = 6;
            View.Name = "View";
            View.Width = 60;
            // 
            // fTuition_fee
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 251, 255);
            ClientSize = new Size(1596, 1016);
            Controls.Add(dataGridView1);
            Controls.Add(pSearchBar);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "fTuition_fee";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "fOpen_Objects";
            Shown += fTuitionFee_Shown;
            pSearchBar.ResumeLayout(false);
            pSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pSearchBar;
        private TextBox tbSearch;
        private PictureBox picSearch;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn lTuitionFeeID;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Moneys;
        private DataGridViewImageColumn View;
    }
}