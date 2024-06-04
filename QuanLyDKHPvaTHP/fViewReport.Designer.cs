namespace QuanLyDKHPvaTHP
{
    partial class fViewReport
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
            dataGridView1 = new DataGridView();
            Number = new DataGridViewTextBoxColumn();
            StudentId = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Registration = new DataGridViewTextBoxColumn();
            ToPay = new DataGridViewTextBoxColumn();
            Remain = new DataGridViewTextBoxColumn();
            lbViewReport = new Label();
            panel1 = new Panel();
            lbNHViewReport = new Label();
            label1 = new Label();
            panel2 = new Panel();
            lbHKViewReport = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12.8571434F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12.8571434F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 70;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Number, StudentId, StudentName, Registration, ToPay, Remain });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12.8571434F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(100, 350);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 12.8571434F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 60;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 12.8571434F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(1400, 566);
            dataGridView1.TabIndex = 16;
            // 
            // Number
            // 
            Number.DataPropertyName = "STT";
            Number.HeaderText = "STT";
            Number.MinimumWidth = 6;
            Number.Name = "Number";
            Number.Width = 125;
            // 
            // StudentId
            // 
            StudentId.DataPropertyName = "MSSV";
            StudentId.FillWeight = 207.317078F;
            StudentId.HeaderText = "MSSV";
            StudentId.MinimumWidth = 6;
            StudentId.Name = "StudentId";
            StudentId.Width = 200;
            // 
            // StudentName
            // 
            StudentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentName.DataPropertyName = "HoTen";
            StudentName.FillWeight = 73.17073F;
            StudentName.HeaderText = "Tên sinh viên";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            // 
            // Registration
            // 
            Registration.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Registration.DataPropertyName = "TongTien";
            Registration.FillWeight = 73.17073F;
            Registration.HeaderText = "Số tiền đăng ký";
            Registration.MinimumWidth = 6;
            Registration.Name = "Registration";
            // 
            // ToPay
            // 
            ToPay.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ToPay.DataPropertyName = "SoTienPhaiDong";
            ToPay.FillWeight = 73.17073F;
            ToPay.HeaderText = "Số tiền phải đóng";
            ToPay.MinimumWidth = 6;
            ToPay.Name = "ToPay";
            // 
            // Remain
            // 
            Remain.DataPropertyName = "SoTienConLai";
            Remain.FillWeight = 73.17073F;
            Remain.HeaderText = "Số tiền còn lại";
            Remain.MinimumWidth = 6;
            Remain.Name = "Remain";
            Remain.Width = 230;
            // 
            // lbViewReport
            // 
            lbViewReport.BackColor = Color.FromArgb(21, 44, 112);
            lbViewReport.Dock = DockStyle.Top;
            lbViewReport.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbViewReport.ForeColor = Color.White;
            lbViewReport.Location = new Point(0, 0);
            lbViewReport.Margin = new Padding(4, 0, 4, 0);
            lbViewReport.Name = "lbViewReport";
            lbViewReport.Size = new Size(1572, 150);
            lbViewReport.TabIndex = 17;
            lbViewReport.Text = "BÁO CÁO SINH VIÊN CHƯA ĐÓNG HỌC PHÍ";
            lbViewReport.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbNHViewReport);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(100, 181);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 154);
            panel1.TabIndex = 18;
            // 
            // lbNHViewReport
            // 
            lbNHViewReport.BackColor = Color.White;
            lbNHViewReport.BorderStyle = BorderStyle.Fixed3D;
            lbNHViewReport.Font = new Font("Times New Roman", 15.000001F);
            lbNHViewReport.Location = new Point(57, 63);
            lbNHViewReport.Margin = new Padding(4, 0, 4, 0);
            lbNHViewReport.Name = "lbNHViewReport";
            lbNHViewReport.Size = new Size(568, 70);
            lbNHViewReport.TabIndex = 1;
            lbNHViewReport.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.000001F);
            label1.ForeColor = Color.FromArgb(16, 156, 241);
            label1.Location = new Point(57, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 41);
            label1.TabIndex = 0;
            label1.Text = "Năm học";
            // 
            // panel2
            // 
            panel2.Controls.Add(lbHKViewReport);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(768, 181);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(660, 154);
            panel2.TabIndex = 19;
            // 
            // lbHKViewReport
            // 
            lbHKViewReport.BackColor = Color.White;
            lbHKViewReport.BorderStyle = BorderStyle.Fixed3D;
            lbHKViewReport.Font = new Font("Times New Roman", 15.000001F);
            lbHKViewReport.Location = new Point(57, 63);
            lbHKViewReport.Margin = new Padding(4, 0, 4, 0);
            lbHKViewReport.Name = "lbHKViewReport";
            lbHKViewReport.Size = new Size(568, 70);
            lbHKViewReport.TabIndex = 1;
            lbHKViewReport.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.000001F);
            label4.ForeColor = Color.FromArgb(16, 156, 241);
            label4.Location = new Point(57, 7);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(122, 41);
            label4.TabIndex = 0;
            label4.Text = "Học kỳ";
            // 
            // fViewReport
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 251, 255);
            ClientSize = new Size(1572, 952);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lbViewReport);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 6, 4, 6);
            Name = "fViewReport";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Label lbViewReport;
        private Panel panel1;
        private Label lbNHViewReport;
        private Label label1;
        private Panel panel2;
        private Label lbHKViewReport;
        private Label label4;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn StudentId;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Registration;
        private DataGridViewTextBoxColumn ToPay;
        private DataGridViewTextBoxColumn Remain;
    }
}