namespace QuanLyDKHPvaTHP.Components
{
    partial class ucDay
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
            panelday = new Panel();
            lableDay = new Label();
            panelday.SuspendLayout();
            SuspendLayout();
            // 
            // panelday
            // 
            panelday.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelday.BackColor = Color.White;
            panelday.Controls.Add(lableDay);
            panelday.Cursor = Cursors.Hand;
            panelday.ForeColor = Color.Black;
            panelday.Location = new Point(1, 1);
            panelday.Name = "panelday";
            panelday.Size = new Size(143, 68);
            panelday.TabIndex = 0;
            // 
            // lableDay
            // 
            lableDay.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lableDay.Location = new Point(10, 10);
            lableDay.Name = "lableDay";
            lableDay.Size = new Size(123, 48);
            lableDay.TabIndex = 0;
            lableDay.Text = "00";
            lableDay.TextAlign = ContentAlignment.TopRight;
            // 
            // ucDay
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelday);
            Name = "ucDay";
            Padding = new Padding(1);
            Size = new Size(145, 70);
            panelday.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelday;
        private Label lableDay;
    }
}
