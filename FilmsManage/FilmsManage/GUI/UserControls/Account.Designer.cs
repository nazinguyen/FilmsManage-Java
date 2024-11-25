namespace FilmsManage.GUI.Forms
{
    partial class Account
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
            groupBox1 = new GroupBox();
            txtSearchAccount = new TextBox();
            btnSearchAccount = new Button();
            btnResetPass = new Button();
            btnDeleteAccount = new Button();
            btnUpdateAccount = new Button();
            btnInsertAccount = new Button();
            btnShowAccount = new Button();
            grpAccount = new GroupBox();
            nudAccountType = new NumericUpDown();
            cboStaffID_Account = new ComboBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtStaffName_Account = new TextBox();
            lblStaffName_Account = new Label();
            lblAccountType = new Label();
            lblStaffID_Account = new Label();
            dtgvAccount = new DataGridView();
            groupBox1.SuspendLayout();
            grpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAccountType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearchAccount);
            groupBox1.Controls.Add(btnSearchAccount);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1108, 44);
            groupBox1.Margin = new Padding(4, 2, 4, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 2, 4, 2);
            groupBox1.Size = new Size(296, 91);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm theo tên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtSearchAccount
            // 
            txtSearchAccount.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchAccount.Location = new Point(36, 39);
            txtSearchAccount.Margin = new Padding(4, 2, 4, 2);
            txtSearchAccount.Name = "txtSearchAccount";
            txtSearchAccount.Size = new Size(164, 35);
            txtSearchAccount.TabIndex = 18;
            // 
            // btnSearchAccount
            // 
            btnSearchAccount.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchAccount.Image = Properties.Resources.search_icon;
            btnSearchAccount.Location = new Point(210, 39);
            btnSearchAccount.Margin = new Padding(4, 2, 4, 2);
            btnSearchAccount.Name = "btnSearchAccount";
            btnSearchAccount.Size = new Size(34, 40);
            btnSearchAccount.TabIndex = 19;
            btnSearchAccount.UseVisualStyleBackColor = true;
            // 
            // btnResetPass
            // 
            btnResetPass.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnResetPass.Location = new Point(1102, 158);
            btnResetPass.Margin = new Padding(4, 2, 4, 2);
            btnResetPass.Name = "btnResetPass";
            btnResetPass.Size = new Size(303, 56);
            btnResetPass.TabIndex = 32;
            btnResetPass.Text = "Reset mật khẩu";
            btnResetPass.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.BackColor = Color.FromArgb(133, 19, 33);
            btnDeleteAccount.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnDeleteAccount.ForeColor = Color.White;
            btnDeleteAccount.Location = new Point(16, 621);
            btnDeleteAccount.Margin = new Padding(4, 2, 4, 2);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(261, 71);
            btnDeleteAccount.TabIndex = 33;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = false;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.BackColor = Color.FromArgb(133, 19, 33);
            btnUpdateAccount.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnUpdateAccount.ForeColor = Color.White;
            btnUpdateAccount.Location = new Point(16, 505);
            btnUpdateAccount.Margin = new Padding(4, 2, 4, 2);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(261, 71);
            btnUpdateAccount.TabIndex = 34;
            btnUpdateAccount.Text = "Sửa";
            btnUpdateAccount.UseVisualStyleBackColor = false;
            // 
            // btnInsertAccount
            // 
            btnInsertAccount.BackColor = Color.FromArgb(133, 19, 33);
            btnInsertAccount.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnInsertAccount.ForeColor = Color.White;
            btnInsertAccount.Location = new Point(16, 393);
            btnInsertAccount.Margin = new Padding(4, 2, 4, 2);
            btnInsertAccount.Name = "btnInsertAccount";
            btnInsertAccount.Size = new Size(261, 71);
            btnInsertAccount.TabIndex = 35;
            btnInsertAccount.Text = "Thêm";
            btnInsertAccount.UseVisualStyleBackColor = false;
            // 
            // btnShowAccount
            // 
            btnShowAccount.BackColor = Color.FromArgb(133, 19, 33);
            btnShowAccount.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnShowAccount.ForeColor = Color.White;
            btnShowAccount.Location = new Point(16, 272);
            btnShowAccount.Margin = new Padding(4, 2, 4, 2);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Size = new Size(261, 71);
            btnShowAccount.TabIndex = 31;
            btnShowAccount.Text = "Xem";
            btnShowAccount.UseVisualStyleBackColor = false;
            // 
            // grpAccount
            // 
            grpAccount.BackColor = Color.Transparent;
            grpAccount.Controls.Add(nudAccountType);
            grpAccount.Controls.Add(cboStaffID_Account);
            grpAccount.Controls.Add(lblUsername);
            grpAccount.Controls.Add(txtUsername);
            grpAccount.Controls.Add(txtStaffName_Account);
            grpAccount.Controls.Add(lblStaffName_Account);
            grpAccount.Controls.Add(lblAccountType);
            grpAccount.Controls.Add(lblStaffID_Account);
            grpAccount.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpAccount.Location = new Point(24, 27);
            grpAccount.Margin = new Padding(4, 2, 4, 2);
            grpAccount.Name = "grpAccount";
            grpAccount.Padding = new Padding(4, 2, 4, 2);
            grpAccount.Size = new Size(1027, 208);
            grpAccount.TabIndex = 30;
            grpAccount.TabStop = false;
            grpAccount.Text = "Thông tin tài khoản";
            // 
            // nudAccountType
            // 
            nudAccountType.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudAccountType.Location = new Point(671, 55);
            nudAccountType.Margin = new Padding(4, 2, 4, 2);
            nudAccountType.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            nudAccountType.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAccountType.Name = "nudAccountType";
            nudAccountType.Size = new Size(271, 35);
            nudAccountType.TabIndex = 6;
            nudAccountType.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboStaffID_Account
            // 
            cboStaffID_Account.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStaffID_Account.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboStaffID_Account.FormattingEnabled = true;
            cboStaffID_Account.Location = new Point(171, 128);
            cboStaffID_Account.Margin = new Padding(4, 2, 4, 2);
            cboStaffID_Account.Name = "cboStaffID_Account";
            cboStaffID_Account.Size = new Size(279, 35);
            cboStaffID_Account.TabIndex = 5;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(31, 60);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(123, 26);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(171, 56);
            txtUsername.Margin = new Padding(4, 2, 4, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(279, 35);
            txtUsername.TabIndex = 2;
            // 
            // txtStaffName_Account
            // 
            txtStaffName_Account.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffName_Account.Location = new Point(671, 126);
            txtStaffName_Account.Margin = new Padding(4, 2, 4, 2);
            txtStaffName_Account.Name = "txtStaffName_Account";
            txtStaffName_Account.ReadOnly = true;
            txtStaffName_Account.Size = new Size(270, 35);
            txtStaffName_Account.TabIndex = 2;
            // 
            // lblStaffName_Account
            // 
            lblStaffName_Account.AutoSize = true;
            lblStaffName_Account.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffName_Account.Location = new Point(553, 130);
            lblStaffName_Account.Margin = new Padding(4, 0, 4, 0);
            lblStaffName_Account.Name = "lblStaffName_Account";
            lblStaffName_Account.Size = new Size(97, 26);
            lblStaffName_Account.TabIndex = 4;
            lblStaffName_Account.Text = "Tên NV:";
            // 
            // lblAccountType
            // 
            lblAccountType.AutoSize = true;
            lblAccountType.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountType.Location = new Point(553, 59);
            lblAccountType.Margin = new Padding(4, 0, 4, 0);
            lblAccountType.Name = "lblAccountType";
            lblAccountType.Size = new Size(107, 26);
            lblAccountType.TabIndex = 4;
            lblAccountType.Text = "Loại TK:";
            // 
            // lblStaffID_Account
            // 
            lblStaffID_Account.AutoSize = true;
            lblStaffID_Account.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffID_Account.Location = new Point(31, 131);
            lblStaffID_Account.Margin = new Padding(4, 0, 4, 0);
            lblStaffID_Account.Name = "lblStaffID_Account";
            lblStaffID_Account.Size = new Size(93, 26);
            lblStaffID_Account.TabIndex = 4;
            lblStaffID_Account.Text = "Mã NV:";
            // 
            // dtgvAccount
            // 
            dtgvAccount.AllowUserToAddRows = false;
            dtgvAccount.AllowUserToDeleteRows = false;
            dtgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(296, 272);
            dtgvAccount.Margin = new Padding(5, 6, 5, 6);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.ReadOnly = true;
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.Size = new Size(1126, 454);
            dtgvAccount.TabIndex = 29;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(btnResetPass);
            Controls.Add(btnDeleteAccount);
            Controls.Add(btnUpdateAccount);
            Controls.Add(btnInsertAccount);
            Controls.Add(btnShowAccount);
            Controls.Add(grpAccount);
            Controls.Add(dtgvAccount);
            Name = "Account";
            Size = new Size(1440, 747);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpAccount.ResumeLayout(false);
            grpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAccountType).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSearchAccount;
        private Button btnSearchAccount;
        private Button btnResetPass;
        private Button btnDeleteAccount;
        private Button btnUpdateAccount;
        private Button btnInsertAccount;
        private Button btnShowAccount;
        private GroupBox grpAccount;
        private NumericUpDown nudAccountType;
        private ComboBox cboStaffID_Account;
        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtStaffName_Account;
        private Label lblStaffName_Account;
        private Label lblAccountType;
        private Label lblStaffID_Account;
        private DataGridView dtgvAccount;
    }
}
