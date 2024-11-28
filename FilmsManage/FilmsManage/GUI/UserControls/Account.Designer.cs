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
            btnSearchAccount.Click += btnSearchAccount_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnReset.Location = new Point(1102, 158);
            btnReset.Margin = new Padding(4, 2, 4, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(303, 56);
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
            btnDeleteAccount.Location = new Point(16, 621);
            btnDeleteAccount.Margin = new Padding(4, 2, 4, 2);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(261, 71);
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
            btnUpdateAccount.Location = new Point(16, 505);
            btnUpdateAccount.Margin = new Padding(4, 2, 4, 2);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(261, 71);
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
            btnInsertAccount.Location = new Point(16, 393);
            btnInsertAccount.Margin = new Padding(4, 2, 4, 2);
            btnInsertAccount.Name = "btnInsertAccount";
            btnInsertAccount.Size = new Size(261, 71);
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
            grpAccount.Location = new Point(24, 27);
            grpAccount.Margin = new Padding(4, 2, 4, 2);
            grpAccount.Name = "grpAccount";
            grpAccount.Padding = new Padding(4, 2, 4, 2);
            grpAccount.Size = new Size(1027, 208);
            grpAccount.TabIndex = 30;
            grpAccount.TabStop = false;
            grpAccount.Text = "Thông tin tài khoản";
            // 
            // txtPassWord
            // 
            txtPassWord.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txtPassWord.Location = new Point(731, 142);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(253, 35);
            txtPassWord.TabIndex = 8;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblPassword.Location = new Point(547, 146);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(126, 26);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Mật khẩu :";
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(731, 21);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.ReadOnly = true;
            txtAccountName.Size = new Size(253, 35);
            txtAccountName.TabIndex = 6;
            // 
            // cbbAccountID
            // 
            cbbAccountID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbAccountID.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbAccountID.FormattingEnabled = true;
            cbbAccountID.Location = new Point(207, 128);
            cbbAccountID.Margin = new Padding(4, 2, 4, 2);
            cbbAccountID.Name = "cbbAccountID";
            cbbAccountID.Size = new Size(243, 35);
            cbbAccountID.TabIndex = 5;
            cbbAccountID.SelectedIndexChanged += cbbAccountID_SelectedIndexChanged;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(31, 60);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(157, 26);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Mã tài khoản:";
            // 
            // txtMaTK
            // 
            txtMaTK.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaTK.Location = new Point(207, 56);
            txtMaTK.Margin = new Padding(4, 2, 4, 2);
            txtMaTK.Name = "txtMaTK";
            txtMaTK.ReadOnly = true;
            txtMaTK.Size = new Size(243, 35);
            txtMaTK.TabIndex = 2;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(731, 83);
            txtUserName.Margin = new Padding(4, 2, 4, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(256, 35);
            txtUserName.TabIndex = 2;
            // 
            // lblStaffName_Account
            // 
            lblStaffName_Account.AutoSize = true;
            lblStaffName_Account.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffName_Account.Location = new Point(547, 92);
            lblStaffName_Account.Margin = new Padding(4, 0, 4, 0);
            lblStaffName_Account.Name = "lblStaffName_Account";
            lblStaffName_Account.Size = new Size(176, 26);
            lblStaffName_Account.TabIndex = 4;
            lblStaffName_Account.Text = "Tên Đăng nhập:";
            // 
            // lblAccountType
            // 
            lblAccountType.AutoSize = true;
            lblAccountType.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountType.Location = new Point(547, 30);
            lblAccountType.Margin = new Padding(4, 0, 4, 0);
            lblAccountType.Name = "lblAccountType";
            lblAccountType.Size = new Size(103, 26);
            lblAccountType.TabIndex = 4;
            lblAccountType.Text = "Tên KH:";
            // 
            // lblAccountID
            // 
            lblAccountID.AutoSize = true;
            lblAccountID.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountID.Location = new Point(31, 131);
            lblAccountID.Margin = new Padding(4, 0, 4, 0);
            lblAccountID.Name = "lblAccountID";
            lblAccountID.Size = new Size(99, 26);
            lblAccountID.TabIndex = 4;
            lblAccountID.Text = "Mã KH:";
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
            Controls.Add(btnReset);
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
    }
}
