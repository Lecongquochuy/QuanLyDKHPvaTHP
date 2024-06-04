namespace QuanLyDKHPvaTHP.Components
{
    partial class SubjectItem
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
            lSubjectName = new Label();
            picSubjectDelete = new PictureBox();
            picSubjectUpdate = new PictureBox();
            picSubjectView = new PictureBox();
            lSubjectType = new Label();
            lSubjectID = new Label();
            lSubjectNumder = new Label();
            tableSubjectItem = new TableLayoutPanel();
            lSubjectSoTC = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picSubjectDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSubjectUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSubjectView).BeginInit();
            tableSubjectItem.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lSubjectName
            // 
            lSubjectName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lSubjectName.ForeColor = Color.Black;
            lSubjectName.Location = new Point(381, 0);
            lSubjectName.Margin = new Padding(4, 0, 4, 0);
            lSubjectName.Name = "lSubjectName";
            lSubjectName.Size = new Size(445, 65);
            lSubjectName.TabIndex = 8;
            lSubjectName.Text = "Tên môn";
            lSubjectName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picSubjectDelete
            // 
            picSubjectDelete.Image = Properties.Resources.Delete;
            picSubjectDelete.Location = new Point(161, 3);
            picSubjectDelete.Margin = new Padding(8);
            picSubjectDelete.Name = "picSubjectDelete";
            picSubjectDelete.Size = new Size(50, 50);
            picSubjectDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            picSubjectDelete.TabIndex = 7;
            picSubjectDelete.TabStop = false;
            picSubjectDelete.Click += picSubjectDelete_Click;
            // 
            // picSubjectUpdate
            // 
            picSubjectUpdate.Image = Properties.Resources.Update;
            picSubjectUpdate.Location = new Point(90, 3);
            picSubjectUpdate.Margin = new Padding(8);
            picSubjectUpdate.Name = "picSubjectUpdate";
            picSubjectUpdate.Size = new Size(50, 50);
            picSubjectUpdate.SizeMode = PictureBoxSizeMode.StretchImage;
            picSubjectUpdate.TabIndex = 6;
            picSubjectUpdate.TabStop = false;
            picSubjectUpdate.Click += picSubjectUpdate_Click;
            // 
            // picSubjectView
            // 
            picSubjectView.Image = Properties.Resources.View;
            picSubjectView.Location = new Point(13, 3);
            picSubjectView.Margin = new Padding(8);
            picSubjectView.Name = "picSubjectView";
            picSubjectView.Size = new Size(50, 50);
            picSubjectView.SizeMode = PictureBoxSizeMode.StretchImage;
            picSubjectView.TabIndex = 5;
            picSubjectView.TabStop = false;
            picSubjectView.Click += picSubjectView_Click;
            // 
            // lSubjectType
            // 
            lSubjectType.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lSubjectType.ForeColor = Color.Black;
            lSubjectType.Location = new Point(834, 0);
            lSubjectType.Margin = new Padding(4, 0, 4, 0);
            lSubjectType.Name = "lSubjectType";
            lSubjectType.Size = new Size(218, 65);
            lSubjectType.TabIndex = 3;
            lSubjectType.Text = "Loại môn";
            lSubjectType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lSubjectID
            // 
            lSubjectID.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lSubjectID.ForeColor = Color.Black;
            lSubjectID.Location = new Point(155, 0);
            lSubjectID.Margin = new Padding(4, 0, 4, 0);
            lSubjectID.Name = "lSubjectID";
            lSubjectID.Size = new Size(218, 65);
            lSubjectID.TabIndex = 1;
            lSubjectID.Text = "Mã môn";
            lSubjectID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lSubjectNumder
            // 
            lSubjectNumder.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lSubjectNumder.ForeColor = Color.Black;
            lSubjectNumder.Location = new Point(4, 0);
            lSubjectNumder.Margin = new Padding(4, 0, 4, 0);
            lSubjectNumder.Name = "lSubjectNumder";
            lSubjectNumder.Size = new Size(143, 65);
            lSubjectNumder.TabIndex = 0;
            lSubjectNumder.Text = "STT";
            lSubjectNumder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableSubjectItem
            // 
            tableSubjectItem.ColumnCount = 6;
            tableSubjectItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableSubjectItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableSubjectItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableSubjectItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableSubjectItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableSubjectItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableSubjectItem.Controls.Add(lSubjectSoTC, 4, 0);
            tableSubjectItem.Controls.Add(lSubjectNumder, 0, 0);
            tableSubjectItem.Controls.Add(lSubjectName, 2, 0);
            tableSubjectItem.Controls.Add(lSubjectID, 1, 0);
            tableSubjectItem.Controls.Add(lSubjectType, 3, 0);
            tableSubjectItem.Controls.Add(panel1, 5, 0);
            tableSubjectItem.Dock = DockStyle.Fill;
            tableSubjectItem.ForeColor = Color.Black;
            tableSubjectItem.Location = new Point(0, 0);
            tableSubjectItem.Name = "tableSubjectItem";
            tableSubjectItem.RowCount = 1;
            tableSubjectItem.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableSubjectItem.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableSubjectItem.Size = new Size(1510, 65);
            tableSubjectItem.TabIndex = 1;
            // 
            // lSubjectSoTC
            // 
            lSubjectSoTC.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lSubjectSoTC.ForeColor = Color.Black;
            lSubjectSoTC.Location = new Point(1060, 0);
            lSubjectSoTC.Margin = new Padding(4, 0, 4, 0);
            lSubjectSoTC.Name = "lSubjectSoTC";
            lSubjectSoTC.Size = new Size(218, 65);
            lSubjectSoTC.TabIndex = 9;
            lSubjectSoTC.Text = "0";
            lSubjectSoTC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(picSubjectUpdate);
            panel1.Controls.Add(picSubjectDelete);
            panel1.Controls.Add(picSubjectView);
            panel1.Location = new Point(1285, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 59);
            panel1.TabIndex = 8;
            // 
            // SubjectItem
            // 
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(tableSubjectItem);
            Margin = new Padding(4);
            Name = "SubjectItem";
            Size = new Size(1510, 65);
            ((System.ComponentModel.ISupportInitialize)picSubjectDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSubjectUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSubjectView).EndInit();
            tableSubjectItem.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lSubjectNumder;
        private Label lSubjectID;
        private Label lSubjectType;
        private PictureBox picSubjectView;
        private PictureBox picSubjectUpdate;
        private PictureBox picSubjectDelete;
        private Label lSubjectName;
        private TableLayoutPanel tableSubjectItem;
        private Label lSubjectSoTC;
        private Panel panel1;
    }
}
