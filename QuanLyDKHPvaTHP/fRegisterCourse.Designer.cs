namespace QuanLyDKHPvaTHP
{
    partial class fRegisterCourse
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
            pSearchBar = new Panel();
            tbSearch = new TextBox();
            picSearch = new PictureBox();
            btnAdd = new Button();
            Delete = new DataGridViewImageColumn();
            Update = new DataGridViewImageColumn();
            View = new DataGridViewImageColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            HocKy = new DataGridViewTextBoxColumn();
            NamHoc = new DataGridViewTextBoxColumn();
            MSSV = new DataGridViewTextBoxColumn();
            MaPhieuDKHP = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            dataGridView = new DataGridView();
            pSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // pSearchBar
            // 
            pSearchBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pSearchBar.BackColor = Color.White;
            pSearchBar.BorderStyle = BorderStyle.FixedSingle;
            pSearchBar.Controls.Add(tbSearch);
            pSearchBar.Controls.Add(picSearch);
            pSearchBar.Location = new Point(67, 67);
            pSearchBar.Name = "pSearchBar";
            pSearchBar.Size = new Size(934, 44);
            pSearchBar.TabIndex = 14;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbSearch.BorderStyle = BorderStyle.None;
            tbSearch.Font = new Font("Times New Roman", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(43, 9);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Tìm kiếm";
            tbSearch.Size = new Size(883, 28);
            tbSearch.TabIndex = 0;
            tbSearch.TextChanged += txtSearchRegisterCourse_TextChanged;
            // 
            // picSearch
            // 
            picSearch.Image = Properties.Resources.Search;
            picSearch.Location = new Point(10, 8);
            picSearch.Name = "picSearch";
            picSearch.Size = new Size(29, 26);
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
            btnAdd.Location = new Point(67, 133);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 40);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
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
            // Update
            // 
            Update.Description = "update";
            Update.HeaderText = "";
            Update.Image = Properties.Resources.Update;
            Update.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Update.MinimumWidth = 30;
            Update.Name = "Update";
            Update.Width = 60;
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
            // NgayLap
            // 
            NgayLap.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgayLap.DataPropertyName = "NgayLap";
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.MinimumWidth = 9;
            NgayLap.Name = "NgayLap";
            // 
            // HocKy
            // 
            HocKy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HocKy.DataPropertyName = "HocKy";
            HocKy.HeaderText = "Học kỳ";
            HocKy.MinimumWidth = 6;
            HocKy.Name = "HocKy";
            // 
            // NamHoc
            // 
            NamHoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NamHoc.DataPropertyName = "NamHoc";
            NamHoc.HeaderText = "Năm học";
            NamHoc.MinimumWidth = 6;
            NamHoc.Name = "NamHoc";
            // 
            // MSSV
            // 
            MSSV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MSSV.DataPropertyName = "MSSV";
            MSSV.HeaderText = "MSSV";
            MSSV.MinimumWidth = 9;
            MSSV.Name = "MSSV";
            // 
            // MaPhieuDKHP
            // 
            MaPhieuDKHP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaPhieuDKHP.DataPropertyName = "MaPhieuDKHP";
            MaPhieuDKHP.HeaderText = "Mã phiếu";
            MaPhieuDKHP.MinimumWidth = 6;
            MaPhieuDKHP.Name = "MaPhieuDKHP";
            // 
            // Number
            // 
            Number.DataPropertyName = "STT";
            Number.HeaderText = "STT";
            Number.MinimumWidth = 6;
            Number.Name = "Number";
            Number.Width = 125;
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Number, MaPhieuDKHP, MSSV, NamHoc, HocKy, NgayLap, View, Update, Delete });
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
            dataGridView.Location = new Point(67, 200);
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
            dataGridView.Size = new Size(933, 449);
            dataGridView.TabIndex = 16;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // fRegisterCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 251, 255);
            ClientSize = new Size(1064, 677);
            Controls.Add(dataGridView);
            Controls.Add(pSearchBar);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "fRegisterCourse";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "fOpen_Objects";
            Load += fRegisterCourse_Load;
            pSearchBar.ResumeLayout(false);
            pSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pSearchBar;
        private TextBox tbSearch;
        private PictureBox picSearch;
        private Button btnAdd;
        private DataGridViewImageColumn Delete;
        private DataGridViewImageColumn Update;
        private DataGridViewImageColumn View;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn HocKy;
        private DataGridViewTextBoxColumn NamHoc;
        private DataGridViewTextBoxColumn MSSV;
        private DataGridViewTextBoxColumn MaPhieuDKHP;
        private DataGridViewTextBoxColumn Number;
        private DataGridView dataGridView;
    }
}