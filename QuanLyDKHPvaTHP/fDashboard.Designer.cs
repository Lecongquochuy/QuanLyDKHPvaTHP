namespace QuanLyDKHPvaTHP
{
    partial class fDashboard
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2 = new Panel();
            panel5 = new Panel();
            btnPrevious = new Button();
            btnNext = new Button();
            lMonthYear = new Label();
            flowLayoutCalendar = new FlowLayoutPanel();
            lSaturday = new Label();
            lTuesday = new Label();
            lWednesday = new Label();
            lThursday = new Label();
            lFriday = new Label();
            lMonday = new Label();
            lSunday = new Label();
            plotView2 = new OxyPlot.WindowsForms.PlotView();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            numberSV = new Label();
            lSV = new Label();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            numberDKHP = new Label();
            lDKHP = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            numberTHP = new Label();
            lTHP = new Label();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(lMonthYear);
            panel2.Controls.Add(flowLayoutCalendar);
            panel2.Controls.Add(lSaturday);
            panel2.Controls.Add(lTuesday);
            panel2.Controls.Add(lWednesday);
            panel2.Controls.Add(lThursday);
            panel2.Controls.Add(lFriday);
            panel2.Controls.Add(lMonday);
            panel2.Controls.Add(lSunday);
            panel2.Location = new Point(63, 223);
            panel2.Name = "panel2";
            panel2.Size = new Size(1092, 771);
            panel2.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.Controls.Add(btnPrevious);
            panel5.Controls.Add(btnNext);
            panel5.Location = new Point(525, 702);
            panel5.Name = "panel5";
            panel5.Size = new Size(545, 50);
            panel5.TabIndex = 23;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPrevious.BackColor = Color.FromArgb(21, 44, 112);
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Times New Roman", 12.8571434F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrevious.ForeColor = Color.White;
            btnPrevious.Location = new Point(41, 3);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(245, 47);
            btnPrevious.TabIndex = 10;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnNext.BackColor = Color.FromArgb(21, 44, 112);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Times New Roman", 12.8571434F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(297, 2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(245, 47);
            btnNext.TabIndex = 11;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // lMonthYear
            // 
            lMonthYear.AutoSize = true;
            lMonthYear.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lMonthYear.ForeColor = Color.Black;
            lMonthYear.Location = new Point(416, 30);
            lMonthYear.Name = "lMonthYear";
            lMonthYear.Size = new Size(234, 48);
            lMonthYear.TabIndex = 22;
            lMonthYear.Text = "Month Year";
            lMonthYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutCalendar
            // 
            flowLayoutCalendar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutCalendar.BackColor = Color.FromArgb(243, 251, 255);
            flowLayoutCalendar.Location = new Point(1, 179);
            flowLayoutCalendar.Name = "flowLayoutCalendar";
            flowLayoutCalendar.Padding = new Padding(8);
            flowLayoutCalendar.Size = new Size(1096, 500);
            flowLayoutCalendar.TabIndex = 21;
            // 
            // lSaturday
            // 
            lSaturday.AutoSize = true;
            lSaturday.Font = new Font("Times New Roman", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lSaturday.ForeColor = Color.Black;
            lSaturday.Location = new Point(936, 110);
            lSaturday.Name = "lSaturday";
            lSaturday.Size = new Size(134, 37);
            lSaturday.TabIndex = 20;
            lSaturday.Text = "Saturday";
            // 
            // lTuesday
            // 
            lTuesday.AutoSize = true;
            lTuesday.Font = new Font("Times New Roman", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lTuesday.ForeColor = Color.Black;
            lTuesday.Location = new Point(312, 110);
            lTuesday.Name = "lTuesday";
            lTuesday.Size = new Size(127, 37);
            lTuesday.TabIndex = 19;
            lTuesday.Text = "Tuesday";
            // 
            // lWednesday
            // 
            lWednesday.AutoSize = true;
            lWednesday.Font = new Font("Times New Roman", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lWednesday.ForeColor = Color.Black;
            lWednesday.Location = new Point(465, 110);
            lWednesday.Name = "lWednesday";
            lWednesday.Size = new Size(164, 37);
            lWednesday.TabIndex = 18;
            lWednesday.Text = "Wednesday";
            // 
            // lThursday
            // 
            lThursday.AutoSize = true;
            lThursday.Font = new Font("Times New Roman", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lThursday.ForeColor = Color.Black;
            lThursday.Location = new Point(650, 110);
            lThursday.Name = "lThursday";
            lThursday.Size = new Size(141, 37);
            lThursday.TabIndex = 17;
            lThursday.Text = "Thursday";
            // 
            // lFriday
            // 
            lFriday.AutoSize = true;
            lFriday.Font = new Font("Times New Roman", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lFriday.ForeColor = Color.Black;
            lFriday.Location = new Point(818, 110);
            lFriday.Name = "lFriday";
            lFriday.Size = new Size(102, 37);
            lFriday.TabIndex = 16;
            lFriday.Text = "Friday";
            // 
            // lMonday
            // 
            lMonday.AutoSize = true;
            lMonday.Font = new Font("Times New Roman", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lMonday.ForeColor = Color.Black;
            lMonday.Location = new Point(156, 110);
            lMonday.Name = "lMonday";
            lMonday.Size = new Size(125, 37);
            lMonday.TabIndex = 15;
            lMonday.Text = "Monday";
            // 
            // lSunday
            // 
            lSunday.AutoSize = true;
            lSunday.Font = new Font("Times New Roman", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lSunday.ForeColor = Color.Black;
            lSunday.Location = new Point(12, 110);
            lSunday.Name = "lSunday";
            lSunday.Size = new Size(115, 37);
            lSunday.TabIndex = 14;
            lSunday.Text = "Sunday";
            // 
            // plotView2
            // 
            plotView2.Anchor = AnchorStyles.None;
            plotView2.BackColor = Color.White;
            plotView2.Font = new Font("Times New Roman", 12.8571434F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plotView2.Location = new Point(1139, 604);
            plotView2.MaximumSize = new Size(500, 500);
            plotView2.Name = "plotView2";
            plotView2.Padding = new Padding(36);
            plotView2.PanCursor = Cursors.Hand;
            plotView2.Size = new Size(400, 400);
            plotView2.TabIndex = 11;
            plotView2.Text = "plotView2";
            plotView2.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView2.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView2.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 2, 0);
            tableLayoutPanel1.Controls.Add(panel1, 4, 0);
            tableLayoutPanel1.Location = new Point(63, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1476, 154);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(numberSV);
            panel3.Controls.Add(lSV);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(436, 148);
            panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.people;
            pictureBox1.Location = new Point(27, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // numberSV
            // 
            numberSV.Anchor = AnchorStyles.None;
            numberSV.Font = new Font("Quadrat-Serial", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberSV.ForeColor = Color.FromArgb(0, 24, 37);
            numberSV.Location = new Point(184, 57);
            numberSV.Name = "numberSV";
            numberSV.Size = new Size(216, 64);
            numberSV.TabIndex = 1;
            numberSV.Text = "00a";
            numberSV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lSV
            // 
            lSV.AutoSize = true;
            lSV.BackColor = Color.White;
            lSV.Font = new Font("Times New Roman", 12.8571434F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lSV.ForeColor = Color.FromArgb(0, 24, 37);
            lSV.Location = new Point(152, 12);
            lSV.Name = "lSV";
            lSV.Size = new Size(126, 34);
            lSV.TabIndex = 0;
            lSV.Text = "Sinh viên";
            lSV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(numberDKHP);
            panel4.Controls.Add(lDKHP);
            panel4.Location = new Point(518, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(436, 148);
            panel4.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(29, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(103, 97);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // numberDKHP
            // 
            numberDKHP.Anchor = AnchorStyles.None;
            numberDKHP.Font = new Font("Quadrat-Serial", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberDKHP.ForeColor = Color.FromArgb(0, 24, 37);
            numberDKHP.Location = new Point(207, 57);
            numberDKHP.Name = "numberDKHP";
            numberDKHP.Size = new Size(186, 64);
            numberDKHP.TabIndex = 1;
            numberDKHP.Text = "00a";
            numberDKHP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lDKHP
            // 
            lDKHP.AutoSize = true;
            lDKHP.BackColor = Color.White;
            lDKHP.Font = new Font("Times New Roman", 12.8571434F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lDKHP.ForeColor = Color.FromArgb(0, 24, 37);
            lDKHP.Location = new Point(160, 11);
            lDKHP.Name = "lDKHP";
            lDKHP.Size = new Size(233, 34);
            lDKHP.TabIndex = 0;
            lDKHP.Text = "Đăng ký học phần";
            lDKHP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(numberTHP);
            panel1.Controls.Add(lTHP);
            panel1.Location = new Point(1033, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 148);
            panel1.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.tuition;
            pictureBox3.Location = new Point(27, 29);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(102, 97);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // numberTHP
            // 
            numberTHP.Anchor = AnchorStyles.None;
            numberTHP.Font = new Font("Quadrat-Serial", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberTHP.ForeColor = Color.FromArgb(0, 24, 37);
            numberTHP.Location = new Point(186, 57);
            numberTHP.Name = "numberTHP";
            numberTHP.Size = new Size(219, 64);
            numberTHP.TabIndex = 1;
            numberTHP.Text = "00a";
            numberTHP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lTHP
            // 
            lTHP.AutoSize = true;
            lTHP.BackColor = Color.White;
            lTHP.Font = new Font("Times New Roman", 12.8571434F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lTHP.ForeColor = Color.FromArgb(0, 24, 37);
            lTHP.Location = new Point(147, 15);
            lTHP.Name = "lTHP";
            lTHP.Size = new Size(243, 34);
            lTHP.TabIndex = 0;
            lTHP.Text = "Chưa đóng học phí";
            lTHP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plotView1
            // 
            plotView1.Anchor = AnchorStyles.None;
            plotView1.BackColor = Color.White;
            plotView1.Font = new Font("Times New Roman", 12.8571434F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plotView1.ForeColor = Color.Black;
            plotView1.Location = new Point(1139, 187);
            plotView1.MaximumSize = new Size(500, 500);
            plotView1.Name = "plotView1";
            plotView1.Padding = new Padding(36);
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(400, 400);
            plotView1.TabIndex = 25;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            plotView1.Click += plotView1_Click;
            // 
            // fDashboard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 251, 255);
            ClientSize = new Size(1596, 1016);
            Controls.Add(plotView1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(plotView2);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fDashboard";
            Text = "fDashboard";
            Load += fDashboard_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel2;
        private Panel panel5;
        private Button btnPrevious;
        private Button btnNext;
        private Label lMonthYear;
        private FlowLayoutPanel flowLayoutCalendar;
        private Label lSaturday;
        private Label lTuesday;
        private Label lWednesday;
        private Label lThursday;
        private Label lMonday;
        private Label lSunday;
        private Label lFriday;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Label numberSV;
        private Label lSV;
        private Panel panel4;
        private Label numberDKHP;
        private Label lDKHP;
        private Panel panel1;
        private Label numberTHP;
        private Label lTHP;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private OxyPlot.WindowsForms.PlotView plotView1;
    }
}