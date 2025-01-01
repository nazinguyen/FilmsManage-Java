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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges37 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges38 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges39 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges40 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges41 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges42 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges43 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges44 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            groupBox1 = new GroupBox();
            txtSearchAccount = new Guna.UI2.WinForms.Guna2TextBox();
            btnSearchAccount = new Button();
            grpAccount = new GroupBox();
            cbbAccountID = new Guna.UI2.WinForms.Guna2ComboBox();
            txtPassWord = new Guna.UI2.WinForms.Guna2TextBox();
            txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            txtAccountName = new Guna.UI2.WinForms.Guna2TextBox();
            txtMaTK = new Guna.UI2.WinForms.Guna2TextBox();
            dtgvAccount = new DataGridView();
            btnReset = new Guna.UI2.WinForms.Guna2Button();
            btnInsertAccount = new Guna.UI2.WinForms.Guna2Button();
            btnExport = new Guna.UI2.WinForms.Guna2Button();
            btnDeleteAccount = new Guna.UI2.WinForms.Guna2Button();
            btnUpdateAccount = new Guna.UI2.WinForms.Guna2Button();
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
            groupBox1.ForeColor = Color.Black;
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
            txtSearchAccount.BorderColor = Color.Black;
            txtSearchAccount.BorderRadius = 6;
            txtSearchAccount.Cursor = Cursors.IBeam;
            txtSearchAccount.CustomizableEdges = customizableEdges23;
            txtSearchAccount.DefaultText = "";
            txtSearchAccount.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchAccount.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchAccount.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchAccount.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchAccount.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchAccount.Font = new Font("Segoe UI", 9F);
            txtSearchAccount.ForeColor = Color.Black;
            txtSearchAccount.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchAccount.Location = new Point(18, 25);
            txtSearchAccount.Margin = new Padding(4, 6, 4, 6);
            txtSearchAccount.Name = "txtSearchAccount";
            txtSearchAccount.PasswordChar = '\0';
            txtSearchAccount.PlaceholderText = "";
            txtSearchAccount.SelectedText = "";
            txtSearchAccount.ShadowDecoration.CustomizableEdges = customizableEdges24;
            txtSearchAccount.Size = new Size(158, 38);
            txtSearchAccount.TabIndex = 14;
            // 
            // btnSearchAccount
            // 
            btnSearchAccount.BackColor = Color.FromArgb(0, 0, 64);
            btnSearchAccount.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchAccount.Image = Resources.search_icon;
            btnSearchAccount.Location = new Point(183, 25);
            btnSearchAccount.Margin = new Padding(3, 2, 3, 2);
            btnSearchAccount.Name = "btnSearchAccount";
            btnSearchAccount.Size = new Size(34, 38);
            btnSearchAccount.TabIndex = 19;
            btnSearchAccount.UseVisualStyleBackColor = false;
            btnSearchAccount.Click += btnSearchAccount_Click;
            // 
            // grpAccount
            // 
            grpAccount.BackColor = Color.White;
            grpAccount.Controls.Add(cbbAccountID);
            grpAccount.Controls.Add(txtPassWord);
            grpAccount.Controls.Add(txtUserName);
            grpAccount.Controls.Add(txtAccountName);
            grpAccount.Controls.Add(txtMaTK);
            grpAccount.FlatStyle = FlatStyle.Popup;
            grpAccount.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpAccount.ForeColor = Color.Black;
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
            cbbAccountID.BorderColor = Color.Black;
            cbbAccountID.BorderRadius = 10;
            cbbAccountID.CustomizableEdges = customizableEdges25;
            cbbAccountID.DrawMode = DrawMode.OwnerDrawFixed;
            cbbAccountID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbAccountID.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbAccountID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbAccountID.Font = new Font("Segoe UI", 10F);
            cbbAccountID.ForeColor = Color.Black;
            cbbAccountID.ItemHeight = 30;
            cbbAccountID.Location = new Point(60, 108);
            cbbAccountID.Name = "cbbAccountID";
            cbbAccountID.ShadowDecoration.CustomizableEdges = customizableEdges26;
            cbbAccountID.Size = new Size(175, 36);
            cbbAccountID.TabIndex = 14;
            // 
            // txtPassWord
            // 
            txtPassWord.Animated = true;
            txtPassWord.BorderColor = Color.Black;
            txtPassWord.BorderRadius = 6;
            txtPassWord.Cursor = Cursors.IBeam;
            txtPassWord.CustomizableEdges = customizableEdges27;
            txtPassWord.DefaultText = "";
            txtPassWord.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassWord.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassWord.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassWord.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassWord.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassWord.Font = new Font("Segoe UI", 9F);
            txtPassWord.ForeColor = Color.Black;
            txtPassWord.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassWord.Location = new Point(619, 44);
            txtPassWord.Margin = new Padding(4, 6, 4, 6);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '\0';
            txtPassWord.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtPassWord.PlaceholderText = "Mật khẩu";
            txtPassWord.SelectedText = "";
            txtPassWord.ShadowDecoration.CustomizableEdges = customizableEdges28;
            txtPassWord.Size = new Size(185, 46);
            txtPassWord.TabIndex = 13;
            // 
            // txtUserName
            // 
            txtUserName.Animated = true;
            txtUserName.BorderColor = Color.Black;
            txtUserName.BorderRadius = 6;
            txtUserName.Cursor = Cursors.IBeam;
            txtUserName.CustomizableEdges = customizableEdges29;
            txtUserName.DefaultText = "";
            txtUserName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUserName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUserName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUserName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUserName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUserName.Font = new Font("Segoe UI", 9F);
            txtUserName.ForeColor = Color.Black;
            txtUserName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUserName.Location = new Point(339, 108);
            txtUserName.Margin = new Padding(4, 6, 4, 6);
            txtUserName.Name = "txtUserName";
            txtUserName.PasswordChar = '\0';
            txtUserName.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtUserName.PlaceholderText = "Tên đăng nhập";
            txtUserName.SelectedText = "";
            txtUserName.ShadowDecoration.CustomizableEdges = customizableEdges30;
            txtUserName.Size = new Size(210, 44);
            txtUserName.TabIndex = 12;
            // 
            // txtAccountName
            // 
            txtAccountName.Animated = true;
            txtAccountName.BorderColor = Color.Black;
            txtAccountName.BorderRadius = 6;
            txtAccountName.Cursor = Cursors.IBeam;
            txtAccountName.CustomizableEdges = customizableEdges31;
            txtAccountName.DefaultText = "";
            txtAccountName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtAccountName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtAccountName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtAccountName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtAccountName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAccountName.Font = new Font("Segoe UI", 9F);
            txtAccountName.ForeColor = Color.Black;
            txtAccountName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAccountName.Location = new Point(339, 44);
            txtAccountName.PlaceholderText = "Tên khách hàng";
            txtAccountName.SelectedText = "";
            txtAccountName.ShadowDecoration.CustomizableEdges = customizableEdges32;
            txtAccountName.Size = new Size(210, 46);
            txtAccountName.TabIndex = 11;
            // 
            // txtMaTK
            // 
            txtMaTK.Animated = true;
            txtMaTK.BorderColor = Color.Black;
            txtMaTK.BorderRadius = 6;
            txtMaTK.Cursor = Cursors.IBeam;
            txtMaTK.CustomizableEdges = customizableEdges33;
            txtMaTK.DefaultText = "";
            txtMaTK.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMaTK.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMaTK.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMaTK.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMaTK.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaTK.Font = new Font("Segoe UI", 9F);
            txtMaTK.ForeColor = Color.Black;
            txtMaTK.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaTK.Location = new Point(60, 44);
            txtMaTK.Margin = new Padding(4, 6, 4, 6);
            txtMaTK.Name = "txtMaTK";
            txtMaTK.PasswordChar = '\0';
            txtMaTK.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtMaTK.PlaceholderText = "Mã tài khoản";
            txtMaTK.SelectedText = "";
            txtMaTK.ShadowDecoration.CustomizableEdges = customizableEdges34;
            txtMaTK.Size = new Size(175, 46);
            txtMaTK.TabIndex = 9;
            // 
            // dtgvAccount
            // 
            dtgvAccount.AllowUserToAddRows = false;
            dtgvAccount.AllowUserToDeleteRows = false;
            dtgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvAccount.BackgroundColor = SystemColors.ActiveCaption;
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(237, 218);
            dtgvAccount.Margin = new Padding(4, 5, 4, 5);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.ReadOnly = true;
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.Size = new Size(886, 351);
            dtgvAccount.TabIndex = 29;
            // 
            // btnReset
            // 
            btnReset.Animated = true;
            btnReset.BackColor = Color.Transparent;
            btnReset.BorderRadius = 10;
            btnReset.CustomizableEdges = customizableEdges35;
            btnReset.FillColor = Color.FromArgb(0, 0, 64);
            btnReset.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.HoverState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.Location = new Point(921, 122);
            btnReset.Margin = new Padding(4, 5, 4, 5);
            btnReset.Name = "btnReset";
            btnReset.ShadowDecoration.CustomizableEdges = customizableEdges36;
            btnReset.Size = new Size(160, 52);
            btnReset.TabIndex = 38;
            btnReset.Text = "Reset";
            btnReset.UseTransparentBackground = true;
            // 
            // btnInsertAccount
            // 
            btnInsertAccount.Animated = true;
            btnInsertAccount.BackColor = Color.Transparent;
            btnInsertAccount.BorderRadius = 10;
            btnInsertAccount.CustomizableEdges = customizableEdges37;
            btnInsertAccount.FillColor = Color.FromArgb(0, 0, 64);
            btnInsertAccount.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnInsertAccount.ForeColor = Color.White;
            btnInsertAccount.HoverState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInsertAccount.Image = (Image)resources.GetObject("btnInsertAccount.Image");
            btnInsertAccount.Location = new Point(19, 218);
            btnInsertAccount.Margin = new Padding(4, 5, 4, 5);
            btnInsertAccount.Name = "btnInsertAccount";
            btnInsertAccount.ShadowDecoration.CustomizableEdges = customizableEdges38;
            btnInsertAccount.Size = new Size(190, 52);
            btnInsertAccount.TabIndex = 39;
            btnInsertAccount.Text = "Thêm";
            btnInsertAccount.UseTransparentBackground = true;
            // 
            // btnExport
            // 
            btnExport.Animated = true;
            btnExport.BackColor = Color.Transparent;
            btnExport.BorderRadius = 10;
            btnExport.CustomizableEdges = customizableEdges39;
            btnExport.FillColor = Color.FromArgb(0, 0, 64);
            btnExport.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.HoverState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExport.Image = (Image)resources.GetObject("btnExport.Image");
            btnExport.Location = new Point(19, 517);
            btnExport.Margin = new Padding(4, 5, 4, 5);
            btnExport.Name = "btnExport";
            btnExport.ShadowDecoration.CustomizableEdges = customizableEdges40;
            btnExport.Size = new Size(190, 52);
            btnExport.TabIndex = 40;
            btnExport.Text = "Xuất File";
            btnExport.UseTransparentBackground = true;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Animated = true;
            btnDeleteAccount.BackColor = Color.Transparent;
            btnDeleteAccount.BorderRadius = 10;
            btnDeleteAccount.CustomizableEdges = customizableEdges41;
            btnDeleteAccount.FillColor = Color.FromArgb(0, 0, 64);
            btnDeleteAccount.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnDeleteAccount.ForeColor = Color.White;
            btnDeleteAccount.HoverState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteAccount.Image = (Image)resources.GetObject("btnDeleteAccount.Image");
            btnDeleteAccount.Location = new Point(19, 417);
            btnDeleteAccount.Margin = new Padding(4, 5, 4, 5);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.ShadowDecoration.CustomizableEdges = customizableEdges42;
            btnDeleteAccount.Size = new Size(190, 52);
            btnDeleteAccount.TabIndex = 41;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseTransparentBackground = true;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.Animated = true;
            btnUpdateAccount.BackColor = Color.Transparent;
            btnUpdateAccount.BorderRadius = 10;
            btnUpdateAccount.CustomizableEdges = customizableEdges43;
            btnUpdateAccount.FillColor = Color.FromArgb(0, 0, 64);
            btnUpdateAccount.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnUpdateAccount.ForeColor = Color.White;
            btnUpdateAccount.HoverState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdateAccount.Image = (Image)resources.GetObject("btnUpdateAccount.Image");
            btnUpdateAccount.Location = new Point(19, 315);
            btnUpdateAccount.Margin = new Padding(4, 5, 4, 5);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.ShadowDecoration.CustomizableEdges = customizableEdges44;
            btnUpdateAccount.Size = new Size(190, 52);
            btnUpdateAccount.TabIndex = 42;
            btnUpdateAccount.Text = "Sửa";
            btnUpdateAccount.UseTransparentBackground = true;
            // 
            // btnReset
            // 
            btnReset.Animated = true;
            btnReset.BackColor = Color.Transparent;
            btnReset.BorderRadius = 10;
            btnReset.FillColor = Color.FromArgb(193, 20, 137);
            btnReset.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.HoverState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReset.Location = new Point(921, 116);
            btnReset.Margin = new Padding(4, 5, 4, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(160, 52);
            btnReset.TabIndex = 38;
            btnReset.Text = "Reset";
            btnReset.UseTransparentBackground = true;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnUpdateAccount);
            Controls.Add(btnDeleteAccount);
            Controls.Add(btnExport);
            Controls.Add(btnInsertAccount);
            Controls.Add(btnReset);
            Controls.Add(groupBox1);
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
        private GroupBox grpAccount;
        private NumericUpDown nudAccountType;
        private DataGridView dtgvAccount;
        private Button button1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaTK;
        private Guna.UI2.WinForms.Guna2TextBox txtPassWord;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountName;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchAccount;
        private Guna.UI2.WinForms.Guna2ComboBox cbbAccountID;
        private Guna.UI2.WinForms.Guna2Button btnInsertAccount;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAccount;
        private Guna.UI2.WinForms.Guna2Button btnUpdateAccount;
    }
}
