namespace FilmsManage.GUI
{
    partial class AccountUC
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
            components = new System.ComponentModel.Container();
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
            toolTipAccountType = new ToolTip(components);
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
            groupBox1.Location = new Point(900, 41);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(209, 73);
            groupBox1.TabIndex = 28;
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
            txtSearchAccount.TextChanged += txtSearchAccount_TextChanged;
            txtSearchAccount.KeyDown += txtSearchAccount_KeyDown;
            // 
            // btnSearchAccount
            // 
            btnSearchAccount.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchAccount.Location = new Point(168, 31);
            btnSearchAccount.Margin = new Padding(3, 2, 3, 2);
            btnSearchAccount.Name = "btnSearchAccount";
            btnSearchAccount.Size = new Size(27, 32);
            btnSearchAccount.TabIndex = 19;
            btnSearchAccount.UseVisualStyleBackColor = true;
            btnSearchAccount.Click += btnSearchAccount_Click;
            // 
            // btnResetPass
            // 
            btnResetPass.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnResetPass.Location = new Point(895, 132);
            btnResetPass.Margin = new Padding(3, 2, 3, 2);
            btnResetPass.Name = "btnResetPass";
            btnResetPass.Size = new Size(214, 45);
            btnResetPass.TabIndex = 24;
            btnResetPass.Text = "Reset mật khẩu";
            btnResetPass.UseVisualStyleBackColor = true;
            btnResetPass.Click += btnResetPass_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.BackColor = Color.FromArgb(133, 19, 33);
            btnDeleteAccount.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnDeleteAccount.ForeColor = Color.White;
            btnDeleteAccount.Location = new Point(33, 495);
            btnDeleteAccount.Margin = new Padding(3, 2, 3, 2);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(209, 57);
            btnDeleteAccount.TabIndex = 25;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = false;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.BackColor = Color.FromArgb(133, 19, 33);
            btnUpdateAccount.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnUpdateAccount.ForeColor = Color.White;
            btnUpdateAccount.Location = new Point(33, 408);
            btnUpdateAccount.Margin = new Padding(3, 2, 3, 2);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(209, 57);
            btnUpdateAccount.TabIndex = 26;
            btnUpdateAccount.Text = "Sửa";
            btnUpdateAccount.UseVisualStyleBackColor = false;
            btnUpdateAccount.Click += btnUpdateAccount_Click;
            // 
            // btnInsertAccount
            // 
            btnInsertAccount.BackColor = Color.FromArgb(133, 19, 33);
            btnInsertAccount.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnInsertAccount.ForeColor = Color.White;
            btnInsertAccount.Location = new Point(33, 317);
            btnInsertAccount.Margin = new Padding(3, 2, 3, 2);
            btnInsertAccount.Name = "btnInsertAccount";
            btnInsertAccount.Size = new Size(209, 57);
            btnInsertAccount.TabIndex = 27;
            btnInsertAccount.Text = "Thêm";
            btnInsertAccount.UseVisualStyleBackColor = false;
            btnInsertAccount.Click += btnInsertAccount_Click;
            // 
            // btnShowAccount
            // 
            btnShowAccount.BackColor = Color.FromArgb(133, 19, 33);
            btnShowAccount.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnShowAccount.ForeColor = Color.White;
            btnShowAccount.Location = new Point(33, 226);
            btnShowAccount.Margin = new Padding(3, 2, 3, 2);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Size = new Size(209, 57);
            btnShowAccount.TabIndex = 23;
            btnShowAccount.Text = "Xem";
            btnShowAccount.UseVisualStyleBackColor = false;
            btnShowAccount.Click += btnShowAccount_Click;
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
            grpAccount.Location = new Point(33, 27);
            grpAccount.Margin = new Padding(3, 2, 3, 2);
            grpAccount.Name = "grpAccount";
            grpAccount.Padding = new Padding(3, 2, 3, 2);
            grpAccount.Size = new Size(794, 166);
            grpAccount.TabIndex = 22;
            grpAccount.TabStop = false;
            grpAccount.Text = "Thông tin tài khoản";
            grpAccount.Enter += grpAccount_Enter;
            // 
            // nudAccountType
            // 
            nudAccountType.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudAccountType.Location = new Point(537, 44);
            nudAccountType.Margin = new Padding(3, 2, 3, 2);
            nudAccountType.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            nudAccountType.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAccountType.Name = "nudAccountType";
            nudAccountType.Size = new Size(217, 30);
            nudAccountType.TabIndex = 6;
            toolTipAccountType.SetToolTip(nudAccountType, "1 : Quản lý\r\n2 : Bán vé");
            nudAccountType.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudAccountType.ValueChanged += nudAccountType_ValueChanged;
            // 
            // cboStaffID_Account
            // 
            cboStaffID_Account.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStaffID_Account.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboStaffID_Account.FormattingEnabled = true;
            cboStaffID_Account.Location = new Point(137, 102);
            cboStaffID_Account.Margin = new Padding(3, 2, 3, 2);
            cboStaffID_Account.Name = "cboStaffID_Account";
            cboStaffID_Account.Size = new Size(224, 30);
            cboStaffID_Account.TabIndex = 5;
            cboStaffID_Account.SelectedIndexChanged += cboStaffID_Account_SelectedIndexChanged;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(24, 49);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(102, 23);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username:";
            lblUsername.Click += lblUsername_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(137, 45);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(224, 30);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtStaffName_Account
            // 
            txtStaffName_Account.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffName_Account.Location = new Point(537, 101);
            txtStaffName_Account.Margin = new Padding(3, 2, 3, 2);
            txtStaffName_Account.Name = "txtStaffName_Account";
            txtStaffName_Account.ReadOnly = true;
            txtStaffName_Account.Size = new Size(217, 30);
            txtStaffName_Account.TabIndex = 2;
            txtStaffName_Account.TextChanged += txtStaffName_Account_TextChanged;
            // 
            // lblStaffName_Account
            // 
            lblStaffName_Account.AutoSize = true;
            lblStaffName_Account.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffName_Account.Location = new Point(442, 105);
            lblStaffName_Account.Name = "lblStaffName_Account";
            lblStaffName_Account.Size = new Size(80, 23);
            lblStaffName_Account.TabIndex = 4;
            lblStaffName_Account.Text = "Tên NV:";
            lblStaffName_Account.Click += lblStaffName_Account_Click;
            // 
            // lblAccountType
            // 
            lblAccountType.AutoSize = true;
            lblAccountType.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountType.Location = new Point(442, 48);
            lblAccountType.Name = "lblAccountType";
            lblAccountType.Size = new Size(87, 23);
            lblAccountType.TabIndex = 4;
            lblAccountType.Text = "Loại TK:";
            lblAccountType.Click += lblAccountType_Click;
            // 
            // lblStaffID_Account
            // 
            lblStaffID_Account.AutoSize = true;
            lblStaffID_Account.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffID_Account.Location = new Point(24, 106);
            lblStaffID_Account.Name = "lblStaffID_Account";
            lblStaffID_Account.Size = new Size(76, 23);
            lblStaffID_Account.TabIndex = 4;
            lblStaffID_Account.Text = "Mã NV:";
            lblStaffID_Account.Click += lblStaffID_Account_Click;
            // 
            // dtgvAccount
            // 
            dtgvAccount.AllowUserToAddRows = false;
            dtgvAccount.AllowUserToDeleteRows = false;
            dtgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(277, 200);
            dtgvAccount.Margin = new Padding(4, 5, 4, 5);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.ReadOnly = true;
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.Size = new Size(901, 363);
            dtgvAccount.TabIndex = 21;
            dtgvAccount.CellContentClick += dtgvAccount_CellContentClick;
            // 
            // toolTipAccountType
            // 
            toolTipAccountType.Popup += toolTipAccountType_Popup;
            // 
            // AccountUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 592);
            Controls.Add(groupBox1);
            Controls.Add(btnResetPass);
            Controls.Add(btnDeleteAccount);
            Controls.Add(btnUpdateAccount);
            Controls.Add(btnInsertAccount);
            Controls.Add(btnShowAccount);
            Controls.Add(grpAccount);
            Controls.Add(dtgvAccount);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AccountUC";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpAccount.ResumeLayout(false);
            grpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAccountType).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchAccount;
        private System.Windows.Forms.Button btnSearchAccount;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnInsertAccount;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.GroupBox grpAccount;
        private System.Windows.Forms.NumericUpDown nudAccountType;
        private System.Windows.Forms.ComboBox cboStaffID_Account;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtStaffName_Account;
        private System.Windows.Forms.Label lblStaffName_Account;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblStaffID_Account;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.ToolTip toolTipAccountType;
    }
}