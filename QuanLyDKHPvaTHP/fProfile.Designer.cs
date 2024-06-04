namespace QuanLyDKHPvaTHP
{
    partial class fProfile
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
            lbDisplayName = new Label();
            btnHomePage = new Button();
            btnLogOut = new Button();
            txbDisplayName = new TextBox();
            panel5 = new Panel();
            label4 = new Label();
            txbEmail = new TextBox();
            panel4 = new Panel();
            pbShowPassword = new PictureBox();
            label3 = new Label();
            txbPassword = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            txbUserName = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            btnSave = new Button();
            pBUserP = new PictureBox();
            label5 = new Label();
            lbAccount = new Label();
            btnAddUser = new Button();
            number = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            TenTK = new DataGridViewTextBoxColumn();
            LoaiTK = new DataGridViewTextBoxColumn();
            Update = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1 = new Panel();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbShowPassword).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBUserP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbDisplayName
            // 
            lbDisplayName.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDisplayName.ForeColor = Color.Black;
            lbDisplayName.Location = new Point(55, 526);
            lbDisplayName.Margin = new Padding(5, 0, 5, 0);
            lbDisplayName.Name = "lbDisplayName";
            lbDisplayName.Size = new Size(452, 63);
            lbDisplayName.TabIndex = 1;
            lbDisplayName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHomePage
            // 
            btnHomePage.AutoSize = true;
            btnHomePage.BackColor = Color.White;
            btnHomePage.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHomePage.ForeColor = Color.Transparent;
            btnHomePage.Image = Properties.Resources.home;
            btnHomePage.Location = new Point(115, 639);
            btnHomePage.Margin = new Padding(5, 6, 5, 6);
            btnHomePage.Name = "btnHomePage";
            btnHomePage.Size = new Size(146, 88);
            btnHomePage.TabIndex = 2;
            btnHomePage.UseVisualStyleBackColor = false;
            btnHomePage.Click += btnHomePage_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.AutoSize = true;
            btnLogOut.BackColor = Color.White;
            btnLogOut.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.Transparent;
            btnLogOut.Image = Properties.Resources.logout;
            btnLogOut.Location = new Point(271, 639);
            btnLogOut.Margin = new Padding(5, 6, 5, 6);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(132, 88);
            btnLogOut.TabIndex = 3;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // txbDisplayName
            // 
            txbDisplayName.BackColor = Color.White;
            txbDisplayName.Font = new Font("Times New Roman", 15.000001F);
            txbDisplayName.Location = new Point(267, 21);
            txbDisplayName.Margin = new Padding(5, 6, 5, 6);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(475, 48);
            txbDisplayName.TabIndex = 4;
            txbDisplayName.TextChanged += txb_TextChange;
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Controls.Add(txbEmail);
            panel5.Location = new Point(563, 287);
            panel5.Margin = new Padding(5, 6, 5, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(765, 84);
            panel5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.000001F);
            label4.ForeColor = Color.FromArgb(16, 156, 241);
            label4.Location = new Point(43, 31);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 41);
            label4.TabIndex = 5;
            label4.Text = "Email:";
            // 
            // txbEmail
            // 
            txbEmail.BackColor = Color.White;
            txbEmail.Font = new Font("Times New Roman", 15.000001F);
            txbEmail.Location = new Point(267, 24);
            txbEmail.Margin = new Padding(5, 6, 5, 6);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(475, 48);
            txbEmail.TabIndex = 4;
            txbEmail.TextChanged += txb_TextChange;
            // 
            // panel4
            // 
            panel4.Controls.Add(pbShowPassword);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(txbPassword);
            panel4.Location = new Point(563, 383);
            panel4.Margin = new Padding(5, 6, 5, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(765, 79);
            panel4.TabIndex = 7;
            // 
            // pbShowPassword
            // 
            pbShowPassword.BackColor = Color.White;
            pbShowPassword.Image = Properties.Resources.show;
            pbShowPassword.Location = new Point(698, 20);
            pbShowPassword.Margin = new Padding(5, 6, 5, 6);
            pbShowPassword.Name = "pbShowPassword";
            pbShowPassword.Size = new Size(41, 36);
            pbShowPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pbShowPassword.TabIndex = 6;
            pbShowPassword.TabStop = false;
            pbShowPassword.Click += pbShowPassword_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.000001F);
            label3.ForeColor = Color.FromArgb(16, 156, 241);
            label3.Location = new Point(41, 22);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(163, 41);
            label3.TabIndex = 5;
            label3.Text = "Mật khẩu:";
            // 
            // txbPassword
            // 
            txbPassword.BackColor = Color.White;
            txbPassword.Font = new Font("Times New Roman", 15.000001F);
            txbPassword.Location = new Point(267, 15);
            txbPassword.Margin = new Padding(5, 6, 5, 6);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(475, 48);
            txbPassword.TabIndex = 4;
            txbPassword.UseSystemPasswordChar = true;
            txbPassword.TextChanged += txb_TextChange;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txbUserName);
            panel3.Location = new Point(563, 188);
            panel3.Margin = new Padding(5, 6, 5, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(765, 87);
            panel3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.000001F);
            label2.ForeColor = Color.FromArgb(16, 156, 241);
            label2.Location = new Point(41, 32);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(219, 41);
            label2.TabIndex = 5;
            label2.Text = "Tên tài khoản:";
            // 
            // txbUserName
            // 
            txbUserName.BackColor = Color.White;
            txbUserName.Font = new Font("Times New Roman", 15.000001F);
            txbUserName.Location = new Point(267, 25);
            txbUserName.Margin = new Padding(5, 6, 5, 6);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(475, 48);
            txbUserName.TabIndex = 4;
            txbUserName.TextChanged += txb_TextChange;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txbDisplayName);
            panel2.Location = new Point(563, 93);
            panel2.Margin = new Padding(5, 6, 5, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(765, 83);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.000001F);
            label1.ForeColor = Color.FromArgb(16, 156, 241);
            label1.Location = new Point(43, 28);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 41);
            label1.TabIndex = 5;
            label1.Text = "Tên hiển thị:";
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.BackColor = Color.Silver;
            btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Transparent;
            btnSave.Location = new Point(1358, 103);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 58);
            btnSave.TabIndex = 6;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pBUserP
            // 
            pBUserP.Image = Properties.Resources.user_profile;
            pBUserP.Location = new Point(115, 167);
            pBUserP.Margin = new Padding(5, 6, 5, 6);
            pBUserP.Name = "pBUserP";
            pBUserP.Size = new Size(288, 304);
            pBUserP.SizeMode = PictureBoxSizeMode.StretchImage;
            pBUserP.TabIndex = 0;
            pBUserP.TabStop = false;
            pBUserP.Click += btnUpdateP_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.000001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(563, 25);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(278, 41);
            label5.TabIndex = 6;
            label5.Text = "Thông tin cá nhân:";
            // 
            // lbAccount
            // 
            lbAccount.AutoSize = true;
            lbAccount.Font = new Font("Times New Roman", 15.000001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAccount.ForeColor = Color.MidnightBlue;
            lbAccount.Location = new Point(563, 495);
            lbAccount.Margin = new Padding(5, 0, 5, 0);
            lbAccount.Name = "lbAccount";
            lbAccount.Size = new Size(213, 41);
            lbAccount.TabIndex = 10;
            lbAccount.Text = "Các tài khoản";
            // 
            // btnAddUser
            // 
            btnAddUser.AutoSize = true;
            btnAddUser.BackColor = Color.White;
            btnAddUser.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = Color.Transparent;
            btnAddUser.Image = Properties.Resources.plus;
            btnAddUser.Location = new Point(1407, 558);
            btnAddUser.Margin = new Padding(5, 6, 5, 6);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(70, 70);
            btnAddUser.TabIndex = 12;
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // number
            // 
            number.DataPropertyName = "STT";
            number.HeaderText = "STT";
            number.MinimumWidth = 9;
            number.Name = "number";
            number.Width = 175;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(16, 156, 241);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 70;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, TenTK, LoaiTK, Update, Delete });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(16, 156, 241);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(563, 558);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(16, 156, 241);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 60;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(16, 156, 241);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 65;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(823, 395);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 175;
            // 
            // TenTK
            // 
            TenTK.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenTK.DataPropertyName = "DisplayName";
            TenTK.HeaderText = "Tên tài khoản";
            TenTK.MinimumWidth = 6;
            TenTK.Name = "TenTK";
            // 
            // LoaiTK
            // 
            LoaiTK.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LoaiTK.DataPropertyName = "Type";
            LoaiTK.HeaderText = "Loại tài khoản";
            LoaiTK.MinimumWidth = 6;
            LoaiTK.Name = "LoaiTK";
            // 
            // Update
            // 
            Update.HeaderText = "";
            Update.Image = Properties.Resources.Update;
            Update.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Update.MinimumWidth = 6;
            Update.Name = "Update";
            Update.Width = 50;
            // 
            // Delete
            // 
            Delete.HeaderText = "";
            Delete.Image = Properties.Resources.Delete;
            Delete.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 50;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnAddUser);
            panel1.Controls.Add(lbAccount);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnHomePage);
            panel1.Controls.Add(lbDisplayName);
            panel1.Controls.Add(pBUserP);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(8, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1579, 967);
            panel1.TabIndex = 18;
            // 
            // fProfile
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1596, 1016);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "fProfile";
            Text = "Profile";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbShowPassword).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBUserP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbDisplayName;
        private Button btnHomePage;
        private Button btnLogOut;
        private TextBox txbDisplayName;
        private Panel panel4;
        private Label label3;
        private TextBox txbPassword;
        private Panel panel3;
        private Label label2;
        private TextBox txbUserName;
        private Panel panel2;
        private Label label1;
        private Button btnSave;
        private Panel panel5;
        private Label label4;
        private TextBox txbEmail;
        private PictureBox pBUserP;
        private PictureBox pbShowPassword;
        private Button button1;
        private Label label5;
        private Label lbAccount;
        private Button btnAddUser;
        private DataGridViewTextBoxColumn number;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn TenTK;
        private DataGridViewTextBoxColumn LoaiTK;
        private DataGridViewImageColumn Update;
        private DataGridViewImageColumn Delete;
        private Panel panel1;
    }
}