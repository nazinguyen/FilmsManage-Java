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
            btnReset = new Button();
            btnDeleteAccount = new Button();
            btnUpdateAccount = new Button();
            btnInsertAccount = new Button();
            btnShowAccount = new Button();
            grpAccount = new GroupBox();
            txtPassWord = new TextBox();
            lblPassword = new Label();
            txtAccountName = new TextBox();
            cbbAccountID = new ComboBox();
            lblUsername = new Label();
            txtMaTK = new TextBox();
            txtUserName = new TextBox();
            lblStaffName_Account = new Label();
            lblAccountType = new Label();
            lblAccountID = new Label();
            dtgvAccount = new DataGridView();
            btnExport = new Button();
            groupBox1.SuspendLayout();
            grpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearchAccount);
            groupBox1.Controls.Add(btnSearchAccount);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(886, 35);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(237, 73);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm theo tên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtSearchAccount
            // 
            txtSearchAccount.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchAccount.Location = new Point(29, 31);
            txtSearchAccount.Margin = new Padding(3, 2, 3, 2);
            txtSearchAccount.Name = "txtSearchAccount";
            txtSearchAccount.Size = new Size(132, 30);
            txtSearchAccount.TabIndex = 18;
            // 
            // btnSearchAccount
            // 
            btnSearchAccount.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchAccount.Image = Properties.Resources.search_icon;
            btnSearchAccount.Location = new Point(168, 31);
            btnSearchAccount.Margin = new Padding(3, 2, 3, 2);
            btnSearchAccount.Name = "btnSearchAccount";
            btnSearchAccount.Size = new Size(27, 32);
            btnSearchAccount.TabIndex = 19;
            btnSearchAccount.UseVisualStyleBackColor = true;
            btnSearchAccount.Click += btnSearchAccount_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnReset.Location = new Point(882, 126);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(242, 45);
            btnReset.TabIndex = 32;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.BackColor = Color.FromArgb(133, 19, 33);
            btnDeleteAccount.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnDeleteAccount.ForeColor = Color.White;
            btnDeleteAccount.Location = new Point(13, 439);
            btnDeleteAccount.Margin = new Padding(3, 2, 3, 2);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(209, 57);
            btnDeleteAccount.TabIndex = 33;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = false;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.BackColor = Color.FromArgb(133, 19, 33);
            btnUpdateAccount.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnUpdateAccount.ForeColor = Color.White;
            btnUpdateAccount.Location = new Point(13, 360);
            btnUpdateAccount.Margin = new Padding(3, 2, 3, 2);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(209, 57);
            btnUpdateAccount.TabIndex = 34;
            btnUpdateAccount.Text = "Sửa";
            btnUpdateAccount.UseVisualStyleBackColor = false;
            btnUpdateAccount.Click += btnUpdateAccount_Click;
            // 
            // btnInsertAccount
            // 
            btnInsertAccount.BackColor = Color.FromArgb(133, 19, 33);
            btnInsertAccount.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnInsertAccount.ForeColor = Color.White;
            btnInsertAccount.Location = new Point(13, 290);
            btnInsertAccount.Margin = new Padding(3, 2, 3, 2);
            btnInsertAccount.Name = "btnInsertAccount";
            btnInsertAccount.Size = new Size(209, 57);
            btnInsertAccount.TabIndex = 35;
            btnInsertAccount.Text = "Thêm";
            btnInsertAccount.UseVisualStyleBackColor = false;
            btnInsertAccount.Click += btnInsertAccount_Click;
            // 
            // btnShowAccount
            // 
            btnShowAccount.BackColor = Color.FromArgb(133, 19, 33);
            btnShowAccount.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnShowAccount.ForeColor = Color.White;
            btnShowAccount.Location = new Point(13, 218);
            btnShowAccount.Margin = new Padding(3, 2, 3, 2);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Size = new Size(209, 57);
            btnShowAccount.TabIndex = 31;
            btnShowAccount.Text = "Xem";
            btnShowAccount.UseVisualStyleBackColor = false;
            // 
            // grpAccount
            // 
            grpAccount.BackColor = Color.Transparent;
            grpAccount.Controls.Add(txtPassWord);
            grpAccount.Controls.Add(lblPassword);
            grpAccount.Controls.Add(txtAccountName);
            grpAccount.Controls.Add(cbbAccountID);
            grpAccount.Controls.Add(lblUsername);
            grpAccount.Controls.Add(txtMaTK);
            grpAccount.Controls.Add(txtUserName);
            grpAccount.Controls.Add(lblStaffName_Account);
            grpAccount.Controls.Add(lblAccountType);
            grpAccount.Controls.Add(lblAccountID);
            grpAccount.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpAccount.Location = new Point(19, 22);
            grpAccount.Margin = new Padding(3, 2, 3, 2);
            grpAccount.Name = "grpAccount";
            grpAccount.Padding = new Padding(3, 2, 3, 2);
            grpAccount.Size = new Size(822, 166);
            grpAccount.TabIndex = 30;
            grpAccount.TabStop = false;
            grpAccount.Text = "Thông tin tài khoản";
            // 
            // txtPassWord
            // 
            txtPassWord.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txtPassWord.Location = new Point(585, 114);
            txtPassWord.Margin = new Padding(2);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(203, 30);
            txtPassWord.TabIndex = 8;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblPassword.Location = new Point(438, 117);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(103, 23);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Mật khẩu :";
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(585, 17);
            txtAccountName.Margin = new Padding(2);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.ReadOnly = true;
            txtAccountName.Size = new Size(203, 30);
            txtAccountName.TabIndex = 6;
            // 
            // cbbAccountID
            // 
            cbbAccountID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbAccountID.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbAccountID.FormattingEnabled = true;
            cbbAccountID.Location = new Point(166, 102);
            cbbAccountID.Margin = new Padding(3, 2, 3, 2);
            cbbAccountID.Name = "cbbAccountID";
            cbbAccountID.Size = new Size(195, 30);
            cbbAccountID.TabIndex = 5;
            cbbAccountID.SelectedIndexChanged += cbbAccountID_SelectedIndexChanged;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(25, 48);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(128, 23);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Mã tài khoản:";
            // 
            // txtMaTK
            // 
            txtMaTK.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaTK.Location = new Point(166, 45);
            txtMaTK.Margin = new Padding(3, 2, 3, 2);
            txtMaTK.Name = "txtMaTK";
            txtMaTK.ReadOnly = true;
            txtMaTK.Size = new Size(195, 30);
            txtMaTK.TabIndex = 2;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(585, 66);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(206, 30);
            txtUserName.TabIndex = 2;
            // 
            // lblStaffName_Account
            // 
            lblStaffName_Account.AutoSize = true;
            lblStaffName_Account.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffName_Account.Location = new Point(438, 74);
            lblStaffName_Account.Name = "lblStaffName_Account";
            lblStaffName_Account.Size = new Size(143, 23);
            lblStaffName_Account.TabIndex = 4;
            lblStaffName_Account.Text = "Tên Đăng nhập:";
            // 
            // lblAccountType
            // 
            lblAccountType.AutoSize = true;
            lblAccountType.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountType.Location = new Point(438, 24);
            lblAccountType.Name = "lblAccountType";
            lblAccountType.Size = new Size(83, 23);
            lblAccountType.TabIndex = 4;
            lblAccountType.Text = "Tên KH:";
            // 
            // lblAccountID
            // 
            lblAccountID.AutoSize = true;
            lblAccountID.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountID.Location = new Point(25, 105);
            lblAccountID.Name = "lblAccountID";
            lblAccountID.Size = new Size(79, 23);
            lblAccountID.TabIndex = 4;
            lblAccountID.Text = "Mã KH:";
            // 
            // dtgvAccount
            // 
            dtgvAccount.AllowUserToAddRows = false;
            dtgvAccount.AllowUserToDeleteRows = false;
            dtgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(237, 218);
            dtgvAccount.Margin = new Padding(4, 5, 4, 5);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.ReadOnly = true;
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.Size = new Size(901, 363);
            dtgvAccount.TabIndex = 29;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(133, 19, 33);
            btnExport.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(13, 512);
            btnExport.Margin = new Padding(3, 2, 3, 2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(209, 57);
            btnExport.TabIndex = 37;
            btnExport.Text = "Xuất File";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnExport);
            Controls.Add(groupBox1);
            Controls.Add(btnReset);
            Controls.Add(btnDeleteAccount);
            Controls.Add(btnUpdateAccount);
            Controls.Add(btnInsertAccount);
            Controls.Add(btnShowAccount);
            Controls.Add(grpAccount);
            Controls.Add(dtgvAccount);
            Margin = new Padding(2);
            Name = "Account";
            Size = new Size(1152, 598);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpAccount.ResumeLayout(false);
            grpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSearchAccount;
        private Button btnSearchAccount;
        private Button btnReset;
        private Button btnDeleteAccount;
        private Button btnUpdateAccount;
        private Button btnInsertAccount;
        private Button btnShowAccount;
        private GroupBox grpAccount;
        private NumericUpDown nudAccountType;
        private ComboBox cbbAccountID;
        private Label lblUsername;
        private TextBox txtMaTK;
        private TextBox txtUserName;
        private Label lblStaffName_Account;
        private Label lblAccountType;
        private Label lblAccountID;
        private DataGridView dtgvAccount;
        private TextBox txtAccountName;
        private TextBox txtPassWord;
        private Label lblPassword;
        private Button button1;
        private Button btnExport;
    }
}
