using FilmsManage.Properties;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            groupBox1 = new GroupBox();
            txtSearchAccount = new Guna.UI2.WinForms.Guna2TextBox();
            btnSearchAccount = new Button();
            btnDeleteAccount = new Button();
            btnUpdateAccount = new Button();
            btnInsertAccount = new Button();
            grpAccount = new GroupBox();
            cbbAccountID = new Guna.UI2.WinForms.Guna2ComboBox();
            txtPassWord = new Guna.UI2.WinForms.Guna2TextBox();
            txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            txtAccountName = new Guna.UI2.WinForms.Guna2TextBox();
            txtMaTK = new Guna.UI2.WinForms.Guna2TextBox();
            dtgvAccount = new DataGridView();
            btnExport = new Button();
            btnReset = new Guna.UI2.WinForms.Guna2Button();
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
            groupBox1.ForeColor = Color.White;
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
            txtSearchAccount.Animated = true;
            txtSearchAccount.BorderColor = Color.FromArgb(234, 153, 149);
            txtSearchAccount.BorderRadius = 6;
            txtSearchAccount.Cursor = Cursors.IBeam;
            txtSearchAccount.CustomizableEdges = customizableEdges1;
            txtSearchAccount.DefaultText = "";
            txtSearchAccount.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchAccount.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchAccount.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchAccount.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchAccount.FillColor = Color.FromArgb(0, 9, 43);
            txtSearchAccount.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchAccount.Font = new Font("Segoe UI", 9F);
            txtSearchAccount.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchAccount.Location = new Point(18, 25);
            txtSearchAccount.Margin = new Padding(4, 6, 4, 6);
            txtSearchAccount.Name = "txtSearchAccount";
            txtSearchAccount.PasswordChar = '\0';
            txtSearchAccount.PlaceholderText = "";
            txtSearchAccount.SelectedText = "";
            txtSearchAccount.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearchAccount.Size = new Size(133, 38);
            txtSearchAccount.TabIndex = 14;
            // 
            // btnSearchAccount
            // 
            btnSearchAccount.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchAccount.Image = Resources.search_icon;
            btnSearchAccount.Location = new Point(168, 31);
            btnSearchAccount.Margin = new Padding(3, 2, 3, 2);
            btnSearchAccount.Name = "btnSearchAccount";
            btnSearchAccount.Size = new Size(27, 32);
            btnSearchAccount.TabIndex = 19;
            btnSearchAccount.UseVisualStyleBackColor = true;
            btnSearchAccount.Click += btnSearchAccount_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.BackColor = Color.FromArgb(133, 19, 33);
            btnDeleteAccount.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnDeleteAccount.ForeColor = Color.White;
            btnDeleteAccount.Location = new Point(19, 394);
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
            btnUpdateAccount.Location = new Point(19, 315);
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
            btnInsertAccount.Location = new Point(19, 245);
            btnInsertAccount.Margin = new Padding(3, 2, 3, 2);
            btnInsertAccount.Name = "btnInsertAccount";
            btnInsertAccount.Size = new Size(209, 57);
            btnInsertAccount.TabIndex = 35;
            btnInsertAccount.Text = "Thêm";
            btnInsertAccount.UseVisualStyleBackColor = false;
            btnInsertAccount.Click += btnInsertAccount_Click;
            // 
            // grpAccount
            // 
            grpAccount.BackColor = Color.FromArgb(0, 9, 43);
            grpAccount.Controls.Add(cbbAccountID);
            grpAccount.Controls.Add(txtPassWord);
            grpAccount.Controls.Add(txtUserName);
            grpAccount.Controls.Add(txtAccountName);
            grpAccount.Controls.Add(txtMaTK);
            grpAccount.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpAccount.ForeColor = Color.White;
            grpAccount.Location = new Point(19, 22);
            grpAccount.Margin = new Padding(3, 2, 3, 2);
            grpAccount.Name = "grpAccount";
            grpAccount.Padding = new Padding(3, 2, 3, 2);
            grpAccount.Size = new Size(849, 175);
            grpAccount.TabIndex = 30;
            grpAccount.TabStop = false;
            grpAccount.Text = "Thông tin tài khoản";
            // 
            // cbbAccountID
            // 
            cbbAccountID.BackColor = Color.Transparent;
            cbbAccountID.BorderColor = Color.FromArgb(234, 153, 149);
            cbbAccountID.BorderRadius = 10;
            cbbAccountID.CustomizableEdges = customizableEdges3;
            cbbAccountID.DrawMode = DrawMode.OwnerDrawFixed;
            cbbAccountID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbAccountID.FillColor = Color.FromArgb(0, 9, 43);
            cbbAccountID.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbAccountID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbAccountID.Font = new Font("Segoe UI", 10F);
            cbbAccountID.ForeColor = Color.FromArgb(68, 88, 112);
            cbbAccountID.ItemHeight = 30;
            cbbAccountID.Location = new Point(60, 108);
            cbbAccountID.Name = "cbbAccountID";
            cbbAccountID.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbbAccountID.Size = new Size(175, 36);
            cbbAccountID.TabIndex = 14;
            // 
            // txtPassWord
            // 
            txtPassWord.Animated = true;
            txtPassWord.BorderColor = Color.FromArgb(234, 153, 149);
            txtPassWord.BorderRadius = 6;
            txtPassWord.Cursor = Cursors.IBeam;
            txtPassWord.CustomizableEdges = customizableEdges5;
            txtPassWord.DefaultText = "";
            txtPassWord.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassWord.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassWord.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassWord.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassWord.FillColor = Color.FromArgb(0, 9, 43);
            txtPassWord.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassWord.Font = new Font("Segoe UI", 9F);
            txtPassWord.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassWord.Location = new Point(619, 44);
            txtPassWord.Margin = new Padding(4, 6, 4, 6);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '\0';
            txtPassWord.PlaceholderText = "Mật khẩu";
            txtPassWord.SelectedText = "";
            txtPassWord.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPassWord.Size = new Size(185, 46);
            txtPassWord.TabIndex = 13;
            // 
            // txtUserName
            // 
            txtUserName.Animated = true;
            txtUserName.BorderColor = Color.FromArgb(234, 153, 149);
            txtUserName.BorderRadius = 6;
            txtUserName.Cursor = Cursors.IBeam;
            txtUserName.CustomizableEdges = customizableEdges7;
            txtUserName.DefaultText = "";
            txtUserName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUserName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUserName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUserName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUserName.FillColor = Color.FromArgb(0, 9, 43);
            txtUserName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUserName.Font = new Font("Segoe UI", 9F);
            txtUserName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUserName.Location = new Point(339, 108);
            txtUserName.Margin = new Padding(4, 6, 4, 6);
            txtUserName.Name = "txtUserName";
            txtUserName.PasswordChar = '\0';
            txtUserName.PlaceholderText = "Tên đăng nhập";
            txtUserName.SelectedText = "";
            txtUserName.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtUserName.Size = new Size(210, 44);
            txtUserName.TabIndex = 12;
            // 
            // txtAccountName
            // 
            txtAccountName.Animated = true;
            txtAccountName.BorderColor = Color.FromArgb(234, 153, 149);
            txtAccountName.BorderRadius = 6;
            txtAccountName.Cursor = Cursors.IBeam;
            txtAccountName.CustomizableEdges = customizableEdges9;
            txtAccountName.DefaultText = "";
            txtAccountName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtAccountName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtAccountName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtAccountName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtAccountName.FillColor = Color.FromArgb(0, 9, 43);
            txtAccountName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAccountName.Font = new Font("Segoe UI", 9F);
            txtAccountName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAccountName.Location = new Point(339, 44);
            txtAccountName.Margin = new Padding(4, 6, 4, 6);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.PasswordChar = '\0';
            txtAccountName.PlaceholderText = "Tên khách hàng";
            txtAccountName.SelectedText = "";
            txtAccountName.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtAccountName.Size = new Size(210, 46);
            txtAccountName.TabIndex = 11;
            // 
            // txtMaTK
            // 
            txtMaTK.Animated = true;
            txtMaTK.BorderColor = Color.FromArgb(234, 153, 149);
            txtMaTK.BorderRadius = 6;
            txtMaTK.Cursor = Cursors.IBeam;
            txtMaTK.CustomizableEdges = customizableEdges11;
            txtMaTK.DefaultText = "";
            txtMaTK.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMaTK.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMaTK.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMaTK.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMaTK.FillColor = Color.FromArgb(0, 9, 43);
            txtMaTK.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaTK.Font = new Font("Segoe UI", 9F);
            txtMaTK.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaTK.Location = new Point(60, 44);
            txtMaTK.Margin = new Padding(4, 6, 4, 6);
            txtMaTK.Name = "txtMaTK";
            txtMaTK.PasswordChar = '\0';
            txtMaTK.PlaceholderText = "Mã tài khoản";
            txtMaTK.SelectedText = "";
            txtMaTK.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtMaTK.Size = new Size(175, 46);
            txtMaTK.TabIndex = 9;
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
            dtgvAccount.Size = new Size(901, 351);
            dtgvAccount.TabIndex = 29;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(133, 19, 33);
            btnExport.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(19, 467);
            btnExport.Margin = new Padding(3, 2, 3, 2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(209, 57);
            btnExport.TabIndex = 37;
            btnExport.Text = "Xuất File";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnReset
            // 
            btnReset.Animated = true;
            btnReset.BackColor = Color.Transparent;
            btnReset.BorderRadius = 10;
            btnReset.CustomizableEdges = customizableEdges13;
            btnReset.FillColor = Color.FromArgb(193, 20, 137);
            btnReset.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.HoverState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReset.Location = new Point(921, 116);
            btnReset.Margin = new Padding(4, 5, 4, 5);
            btnReset.Name = "btnReset";
            btnReset.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnReset.Size = new Size(160, 52);
            btnReset.TabIndex = 38;
            btnReset.Text = "Reset";
            btnReset.UseTransparentBackground = true;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 9, 43);
            Controls.Add(btnReset);
            Controls.Add(btnExport);
            Controls.Add(groupBox1);
            Controls.Add(btnDeleteAccount);
            Controls.Add(btnUpdateAccount);
            Controls.Add(btnInsertAccount);
            Controls.Add(grpAccount);
            Controls.Add(dtgvAccount);
            Margin = new Padding(2);
            Name = "Account";
            Size = new Size(1152, 598);
            groupBox1.ResumeLayout(false);
            grpAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSearchAccount;
        private Button btnDeleteAccount;
        private Button btnUpdateAccount;
        private Button btnInsertAccount;
        private GroupBox grpAccount;
        private NumericUpDown nudAccountType;
        private DataGridView dtgvAccount;
        private Button button1;
        private Button btnExport;
        private Guna.UI2.WinForms.Guna2TextBox txtMaTK;
        private Guna.UI2.WinForms.Guna2TextBox txtPassWord;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountName;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchAccount;
        private Guna.UI2.WinForms.Guna2ComboBox cbbAccountID;
    }
}
