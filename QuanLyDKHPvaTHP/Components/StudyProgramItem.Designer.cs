namespace QuanLyDKHPvaTHP.Components
{
    partial class StudyProgramItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lStudyProgramKhoa = new Label();
            picStudyProgramDelete = new PictureBox();
            picStudyProgramUpdate = new PictureBox();
            picStudyProgramView = new PictureBox();
            lStudyProgramNganh = new Label();
            lStudyProgramNumder = new Label();
            tableStudyProgramItem = new TableLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picStudyProgramDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStudyProgramUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStudyProgramView).BeginInit();
            tableStudyProgramItem.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lStudyProgramKhoa
            // 
            lStudyProgramKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lStudyProgramKhoa.BackColor = Color.White;
            lStudyProgramKhoa.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lStudyProgramKhoa.ForeColor = Color.Black;
            lStudyProgramKhoa.Location = new Point(688, 0);
            lStudyProgramKhoa.Margin = new Padding(4, 0, 4, 0);
            lStudyProgramKhoa.Name = "lStudyProgramKhoa";
            lStudyProgramKhoa.Size = new Size(600, 65);
            lStudyProgramKhoa.TabIndex = 8;
            lStudyProgramKhoa.Text = "Khoa";
            lStudyProgramKhoa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picStudyProgramDelete
            // 
            picStudyProgramDelete.Image = Properties.Resources.Delete;
            picStudyProgramDelete.Location = new Point(161, 3);
            picStudyProgramDelete.Margin = new Padding(8);
            picStudyProgramDelete.Name = "picStudyProgramDelete";
            picStudyProgramDelete.Size = new Size(50, 50);
            picStudyProgramDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            picStudyProgramDelete.TabIndex = 7;
            picStudyProgramDelete.TabStop = false;
            picStudyProgramDelete.UseWaitCursor = true;
            picStudyProgramDelete.Click += picStudyProgramDelete_Click;
            // 
            // picStudyProgramUpdate
            // 
            picStudyProgramUpdate.Image = Properties.Resources.Update;
            picStudyProgramUpdate.Location = new Point(90, 3);
            picStudyProgramUpdate.Margin = new Padding(8);
            picStudyProgramUpdate.Name = "picStudyProgramUpdate";
            picStudyProgramUpdate.Size = new Size(50, 50);
            picStudyProgramUpdate.SizeMode = PictureBoxSizeMode.StretchImage;
            picStudyProgramUpdate.TabIndex = 6;
            picStudyProgramUpdate.TabStop = false;
            picStudyProgramUpdate.UseWaitCursor = true;
            picStudyProgramUpdate.Click += picStudyProgramUpdate_Click;
            // 
            // picStudyProgramView
            // 
            picStudyProgramView.Image = Properties.Resources.View;
            picStudyProgramView.Location = new Point(13, 3);
            picStudyProgramView.Margin = new Padding(8);
            picStudyProgramView.Name = "picStudyProgramView";
            picStudyProgramView.Size = new Size(50, 50);
            picStudyProgramView.SizeMode = PictureBoxSizeMode.StretchImage;
            picStudyProgramView.TabIndex = 5;
            picStudyProgramView.TabStop = false;
            picStudyProgramView.UseWaitCursor = true;
            picStudyProgramView.Click += picStudyProgramView_Click;
            // 
            // lStudyProgramNganh
            // 
            lStudyProgramNganh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lStudyProgramNganh.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lStudyProgramNganh.ForeColor = Color.Black;
            lStudyProgramNganh.Location = new Point(232, 0);
            lStudyProgramNganh.Margin = new Padding(4, 0, 4, 0);
            lStudyProgramNganh.Name = "lStudyProgramNganh";
            lStudyProgramNganh.Size = new Size(448, 65);
            lStudyProgramNganh.TabIndex = 1;
            lStudyProgramNganh.Text = "Ngành";
            lStudyProgramNganh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lStudyProgramNumder
            // 
            lStudyProgramNumder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lStudyProgramNumder.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lStudyProgramNumder.ForeColor = Color.Black;
            lStudyProgramNumder.Location = new Point(4, 0);
            lStudyProgramNumder.Margin = new Padding(4, 0, 4, 0);
            lStudyProgramNumder.Name = "lStudyProgramNumder";
            lStudyProgramNumder.Size = new Size(220, 65);
            lStudyProgramNumder.TabIndex = 0;
            lStudyProgramNumder.Text = "STT";
            lStudyProgramNumder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableStudyProgramItem
            // 
            tableStudyProgramItem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableStudyProgramItem.AutoSize = true;
            tableStudyProgramItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableStudyProgramItem.BackColor = Color.White;
            tableStudyProgramItem.ColumnCount = 4;
            tableStudyProgramItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableStudyProgramItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableStudyProgramItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableStudyProgramItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableStudyProgramItem.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableStudyProgramItem.Controls.Add(lStudyProgramNumder, 0, 0);
            tableStudyProgramItem.Controls.Add(lStudyProgramNganh, 1, 0);
            tableStudyProgramItem.Controls.Add(panel1, 3, 0);
            tableStudyProgramItem.Controls.Add(lStudyProgramKhoa, 2, 0);
            tableStudyProgramItem.ForeColor = Color.Black;
            tableStudyProgramItem.Location = new Point(0, 0);
            tableStudyProgramItem.Name = "tableStudyProgramItem";
            tableStudyProgramItem.RowCount = 1;
            tableStudyProgramItem.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableStudyProgramItem.Size = new Size(1520, 65);
            tableStudyProgramItem.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(picStudyProgramUpdate);
            panel1.Controls.Add(picStudyProgramDelete);
            panel1.Controls.Add(picStudyProgramView);
            panel1.Location = new Point(1295, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 59);
            panel1.TabIndex = 8;
            panel1.UseWaitCursor = true;
            // 
            // StudyProgramItem
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableStudyProgramItem);
            Margin = new Padding(4);
            Name = "StudyProgramItem";
            Size = new Size(1515, 65);
            ((System.ComponentModel.ISupportInitialize)picStudyProgramDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStudyProgramUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStudyProgramView).EndInit();
            tableStudyProgramItem.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lStudyProgramNumder;
        private Label lStudyProgramNganh;
        private PictureBox picStudyProgramView;
        private PictureBox picStudyProgramUpdate;
        private PictureBox picStudyProgramDelete;
        private Label lStudyProgramKhoa;
        private TableLayoutPanel tableStudyProgramItem;
        private Panel panel1;
    }
}
