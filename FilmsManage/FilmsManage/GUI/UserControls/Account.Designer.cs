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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            groupBox1 = new GroupBox();
            txtSearchAccount = new TextBox();
            btnSearchAccount = new Button();
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
            btnReset = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnInsertAccount = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnUpdateAccount = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnDeleteAccount = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnExport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnShowAccount = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            grpAccount.Location = new Point(24, 28);
            grpAccount.Margin = new Padding(4, 2, 4, 2);
            grpAccount.Name = "grpAccount";
            grpAccount.Padding = new Padding(4, 2, 4, 2);
            grpAccount.Size = new Size(1028, 208);
            grpAccount.TabIndex = 30;
            grpAccount.TabStop = false;
            grpAccount.Text = "Thông tin tài khoản";
            // 
            // txtPassWord
            // 
            txtPassWord.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txtPassWord.Location = new Point(731, 142);
            txtPassWord.Margin = new Padding(2);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.Size = new Size(253, 35);
            txtPassWord.TabIndex = 8;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblPassword.Location = new Point(548, 146);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(126, 26);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Mật khẩu :";
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(731, 21);
            txtAccountName.Margin = new Padding(2);
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
            cbbAccountID.Location = new Point(208, 128);
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
            txtMaTK.Location = new Point(208, 56);
            txtMaTK.Margin = new Padding(4, 2, 4, 2);
            txtMaTK.Name = "txtMaTK";
            txtMaTK.ReadOnly = true;
            txtMaTK.Size = new Size(243, 35);
            txtMaTK.TabIndex = 2;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(731, 82);
            txtUserName.Margin = new Padding(4, 2, 4, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(256, 35);
            txtUserName.TabIndex = 2;
            // 
            // lblStaffName_Account
            // 
            lblStaffName_Account.AutoSize = true;
            lblStaffName_Account.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffName_Account.Location = new Point(548, 92);
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
            lblAccountType.Location = new Point(548, 30);
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
            // btnReset
            // 
            btnReset.AllowAnimations = true;
            btnReset.AllowMouseEffects = true;
            btnReset.AllowToggling = false;
            btnReset.AnimationSpeed = 200;
            btnReset.AutoGenerateColors = false;
            btnReset.AutoRoundBorders = false;
            btnReset.AutoSizeLeftIcon = true;
            btnReset.AutoSizeRightIcon = true;
            btnReset.BackColor = Color.Transparent;
            btnReset.BackColor1 = Color.FromArgb(51, 122, 183);
            btnReset.BackgroundImage = (Image)resources.GetObject("btnReset.BackgroundImage");
            btnReset.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnReset.ButtonText = "Reset";
            btnReset.ButtonTextMarginLeft = 0;
            btnReset.ColorContrastOnClick = 45;
            btnReset.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btnReset.CustomizableEdges = borderEdges1;
            btnReset.DialogResult = DialogResult.None;
            btnReset.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnReset.DisabledFillColor = Color.Empty;
            btnReset.DisabledForecolor = Color.Empty;
            btnReset.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnReset.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.IconLeft = null;
            btnReset.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnReset.IconLeftCursor = Cursors.Default;
            btnReset.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnReset.IconMarginLeft = 11;
            btnReset.IconPadding = 10;
            btnReset.IconRight = null;
            btnReset.IconRightAlign = ContentAlignment.MiddleRight;
            btnReset.IconRightCursor = Cursors.Default;
            btnReset.IconRightPadding = new Padding(3, 3, 7, 3);
            btnReset.IconSize = 25;
            btnReset.IdleBorderColor = Color.Empty;
            btnReset.IdleBorderRadius = 0;
            btnReset.IdleBorderThickness = 0;
            btnReset.IdleFillColor = Color.Empty;
            btnReset.IdleIconLeftImage = null;
            btnReset.IdleIconRightImage = null;
            btnReset.IndicateFocus = false;
            btnReset.Location = new Point(1108, 159);
            btnReset.Margin = new Padding(4);
            btnReset.Name = "btnReset";
            btnReset.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnReset.OnDisabledState.BorderRadius = 30;
            btnReset.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnReset.OnDisabledState.BorderThickness = 2;
            btnReset.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnReset.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnReset.OnDisabledState.IconLeftImage = null;
            btnReset.OnDisabledState.IconRightImage = null;
            btnReset.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnReset.onHoverState.BorderRadius = 30;
            btnReset.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnReset.onHoverState.BorderThickness = 2;
            btnReset.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnReset.onHoverState.ForeColor = Color.White;
            btnReset.onHoverState.IconLeftImage = null;
            btnReset.onHoverState.IconRightImage = null;
            btnReset.OnIdleState.BorderColor = Color.FromArgb(30, 150, 255);
            btnReset.OnIdleState.BorderRadius = 30;
            btnReset.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnReset.OnIdleState.BorderThickness = 2;
            btnReset.OnIdleState.FillColor = Color.FromArgb(119, 39, 19);
            btnReset.OnIdleState.ForeColor = Color.White;
            btnReset.OnIdleState.IconLeftImage = null;
            btnReset.OnIdleState.IconRightImage = null;
            btnReset.OnPressedState.BorderColor = Color.FromArgb(30, 150, 255);
            btnReset.OnPressedState.BorderRadius = 30;
            btnReset.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnReset.OnPressedState.BorderThickness = 2;
            btnReset.OnPressedState.FillColor = Color.Gold;
            btnReset.OnPressedState.ForeColor = Color.White;
            btnReset.OnPressedState.IconLeftImage = null;
            btnReset.OnPressedState.IconRightImage = null;
            btnReset.Size = new Size(296, 72);
            btnReset.TabIndex = 38;
            btnReset.TextAlign = ContentAlignment.MiddleCenter;
            btnReset.TextAlignment = HorizontalAlignment.Center;
            btnReset.TextMarginLeft = 0;
            btnReset.TextPadding = new Padding(0);
            btnReset.UseDefaultRadiusAndThickness = true;
            btnReset.Click += btnReset_Click_1;
            // 
            // btnInsertAccount
            // 
            btnInsertAccount.AllowAnimations = true;
            btnInsertAccount.AllowMouseEffects = true;
            btnInsertAccount.AllowToggling = false;
            btnInsertAccount.AnimationSpeed = 200;
            btnInsertAccount.AutoGenerateColors = false;
            btnInsertAccount.AutoRoundBorders = false;
            btnInsertAccount.AutoSizeLeftIcon = true;
            btnInsertAccount.AutoSizeRightIcon = true;
            btnInsertAccount.BackColor = Color.Transparent;
            btnInsertAccount.BackColor1 = Color.FromArgb(51, 122, 183);
            btnInsertAccount.BackgroundImage = (Image)resources.GetObject("btnInsertAccount.BackgroundImage");
            btnInsertAccount.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertAccount.ButtonText = "Thêm";
            btnInsertAccount.ButtonTextMarginLeft = 0;
            btnInsertAccount.ColorContrastOnClick = 45;
            btnInsertAccount.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            btnInsertAccount.CustomizableEdges = borderEdges2;
            btnInsertAccount.DialogResult = DialogResult.None;
            btnInsertAccount.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnInsertAccount.DisabledFillColor = Color.Empty;
            btnInsertAccount.DisabledForecolor = Color.Empty;
            btnInsertAccount.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnInsertAccount.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnInsertAccount.ForeColor = Color.White;
            btnInsertAccount.IconLeft = null;
            btnInsertAccount.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnInsertAccount.IconLeftCursor = Cursors.Default;
            btnInsertAccount.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnInsertAccount.IconMarginLeft = 11;
            btnInsertAccount.IconPadding = 10;
            btnInsertAccount.IconRight = null;
            btnInsertAccount.IconRightAlign = ContentAlignment.MiddleRight;
            btnInsertAccount.IconRightCursor = Cursors.Default;
            btnInsertAccount.IconRightPadding = new Padding(3, 3, 7, 3);
            btnInsertAccount.IconSize = 25;
            btnInsertAccount.IdleBorderColor = Color.Empty;
            btnInsertAccount.IdleBorderRadius = 0;
            btnInsertAccount.IdleBorderThickness = 0;
            btnInsertAccount.IdleFillColor = Color.Empty;
            btnInsertAccount.IdleIconLeftImage = null;
            btnInsertAccount.IdleIconRightImage = null;
            btnInsertAccount.IndicateFocus = false;
            btnInsertAccount.Location = new Point(16, 366);
            btnInsertAccount.Name = "btnInsertAccount";
            btnInsertAccount.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnInsertAccount.OnDisabledState.BorderRadius = 30;
            btnInsertAccount.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertAccount.OnDisabledState.BorderThickness = 2;
            btnInsertAccount.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnInsertAccount.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnInsertAccount.OnDisabledState.IconLeftImage = null;
            btnInsertAccount.OnDisabledState.IconRightImage = null;
            btnInsertAccount.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnInsertAccount.onHoverState.BorderRadius = 30;
            btnInsertAccount.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertAccount.onHoverState.BorderThickness = 2;
            btnInsertAccount.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnInsertAccount.onHoverState.ForeColor = Color.White;
            btnInsertAccount.onHoverState.IconLeftImage = null;
            btnInsertAccount.onHoverState.IconRightImage = null;
            btnInsertAccount.OnIdleState.BorderColor = Color.DodgerBlue;
            btnInsertAccount.OnIdleState.BorderRadius = 30;
            btnInsertAccount.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertAccount.OnIdleState.BorderThickness = 2;
            btnInsertAccount.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnInsertAccount.OnIdleState.ForeColor = Color.White;
            btnInsertAccount.OnIdleState.IconLeftImage = null;
            btnInsertAccount.OnIdleState.IconRightImage = null;
            btnInsertAccount.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnInsertAccount.OnPressedState.BorderRadius = 30;
            btnInsertAccount.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertAccount.OnPressedState.BorderThickness = 2;
            btnInsertAccount.OnPressedState.FillColor = Color.Gold;
            btnInsertAccount.OnPressedState.ForeColor = Color.White;
            btnInsertAccount.OnPressedState.IconLeftImage = null;
            btnInsertAccount.OnPressedState.IconRightImage = null;
            btnInsertAccount.Size = new Size(261, 64);
            btnInsertAccount.TabIndex = 39;
            btnInsertAccount.TextAlign = ContentAlignment.MiddleCenter;
            btnInsertAccount.TextAlignment = HorizontalAlignment.Center;
            btnInsertAccount.TextMarginLeft = 0;
            btnInsertAccount.TextPadding = new Padding(0);
            btnInsertAccount.UseDefaultRadiusAndThickness = true;
            btnInsertAccount.Click += btnInsertAccount_Click_1;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.AllowAnimations = true;
            btnUpdateAccount.AllowMouseEffects = true;
            btnUpdateAccount.AllowToggling = false;
            btnUpdateAccount.AnimationSpeed = 200;
            btnUpdateAccount.AutoGenerateColors = false;
            btnUpdateAccount.AutoRoundBorders = false;
            btnUpdateAccount.AutoSizeLeftIcon = true;
            btnUpdateAccount.AutoSizeRightIcon = true;
            btnUpdateAccount.BackColor = Color.Transparent;
            btnUpdateAccount.BackColor1 = Color.FromArgb(51, 122, 183);
            btnUpdateAccount.BackgroundImage = (Image)resources.GetObject("btnUpdateAccount.BackgroundImage");
            btnUpdateAccount.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateAccount.ButtonText = "Sửa";
            btnUpdateAccount.ButtonTextMarginLeft = 0;
            btnUpdateAccount.ColorContrastOnClick = 45;
            btnUpdateAccount.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            btnUpdateAccount.CustomizableEdges = borderEdges3;
            btnUpdateAccount.DialogResult = DialogResult.None;
            btnUpdateAccount.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnUpdateAccount.DisabledFillColor = Color.Empty;
            btnUpdateAccount.DisabledForecolor = Color.Empty;
            btnUpdateAccount.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnUpdateAccount.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnUpdateAccount.ForeColor = Color.White;
            btnUpdateAccount.IconLeft = null;
            btnUpdateAccount.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnUpdateAccount.IconLeftCursor = Cursors.Default;
            btnUpdateAccount.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnUpdateAccount.IconMarginLeft = 11;
            btnUpdateAccount.IconPadding = 10;
            btnUpdateAccount.IconRight = null;
            btnUpdateAccount.IconRightAlign = ContentAlignment.MiddleRight;
            btnUpdateAccount.IconRightCursor = Cursors.Default;
            btnUpdateAccount.IconRightPadding = new Padding(3, 3, 7, 3);
            btnUpdateAccount.IconSize = 25;
            btnUpdateAccount.IdleBorderColor = Color.Empty;
            btnUpdateAccount.IdleBorderRadius = 0;
            btnUpdateAccount.IdleBorderThickness = 0;
            btnUpdateAccount.IdleFillColor = Color.Empty;
            btnUpdateAccount.IdleIconLeftImage = null;
            btnUpdateAccount.IdleIconRightImage = null;
            btnUpdateAccount.IndicateFocus = false;
            btnUpdateAccount.Location = new Point(16, 453);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnUpdateAccount.OnDisabledState.BorderRadius = 30;
            btnUpdateAccount.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateAccount.OnDisabledState.BorderThickness = 2;
            btnUpdateAccount.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnUpdateAccount.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnUpdateAccount.OnDisabledState.IconLeftImage = null;
            btnUpdateAccount.OnDisabledState.IconRightImage = null;
            btnUpdateAccount.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnUpdateAccount.onHoverState.BorderRadius = 30;
            btnUpdateAccount.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateAccount.onHoverState.BorderThickness = 2;
            btnUpdateAccount.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnUpdateAccount.onHoverState.ForeColor = Color.White;
            btnUpdateAccount.onHoverState.IconLeftImage = null;
            btnUpdateAccount.onHoverState.IconRightImage = null;
            btnUpdateAccount.OnIdleState.BorderColor = Color.DodgerBlue;
            btnUpdateAccount.OnIdleState.BorderRadius = 30;
            btnUpdateAccount.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateAccount.OnIdleState.BorderThickness = 2;
            btnUpdateAccount.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnUpdateAccount.OnIdleState.ForeColor = Color.White;
            btnUpdateAccount.OnIdleState.IconLeftImage = null;
            btnUpdateAccount.OnIdleState.IconRightImage = null;
            btnUpdateAccount.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnUpdateAccount.OnPressedState.BorderRadius = 30;
            btnUpdateAccount.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateAccount.OnPressedState.BorderThickness = 2;
            btnUpdateAccount.OnPressedState.FillColor = Color.Gold;
            btnUpdateAccount.OnPressedState.ForeColor = Color.White;
            btnUpdateAccount.OnPressedState.IconLeftImage = null;
            btnUpdateAccount.OnPressedState.IconRightImage = null;
            btnUpdateAccount.Size = new Size(261, 64);
            btnUpdateAccount.TabIndex = 40;
            btnUpdateAccount.TextAlign = ContentAlignment.MiddleCenter;
            btnUpdateAccount.TextAlignment = HorizontalAlignment.Center;
            btnUpdateAccount.TextMarginLeft = 0;
            btnUpdateAccount.TextPadding = new Padding(0);
            btnUpdateAccount.UseDefaultRadiusAndThickness = true;
            btnUpdateAccount.Click += btnUpdateAccount_Click_1;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.AllowAnimations = true;
            btnDeleteAccount.AllowMouseEffects = true;
            btnDeleteAccount.AllowToggling = false;
            btnDeleteAccount.AnimationSpeed = 200;
            btnDeleteAccount.AutoGenerateColors = false;
            btnDeleteAccount.AutoRoundBorders = false;
            btnDeleteAccount.AutoSizeLeftIcon = true;
            btnDeleteAccount.AutoSizeRightIcon = true;
            btnDeleteAccount.BackColor = Color.Transparent;
            btnDeleteAccount.BackColor1 = Color.FromArgb(51, 122, 183);
            btnDeleteAccount.BackgroundImage = (Image)resources.GetObject("btnDeleteAccount.BackgroundImage");
            btnDeleteAccount.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteAccount.ButtonText = "Xóa";
            btnDeleteAccount.ButtonTextMarginLeft = 0;
            btnDeleteAccount.ColorContrastOnClick = 45;
            btnDeleteAccount.ColorContrastOnHover = 45;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            btnDeleteAccount.CustomizableEdges = borderEdges4;
            btnDeleteAccount.DialogResult = DialogResult.None;
            btnDeleteAccount.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnDeleteAccount.DisabledFillColor = Color.Empty;
            btnDeleteAccount.DisabledForecolor = Color.Empty;
            btnDeleteAccount.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnDeleteAccount.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnDeleteAccount.ForeColor = Color.White;
            btnDeleteAccount.IconLeft = null;
            btnDeleteAccount.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnDeleteAccount.IconLeftCursor = Cursors.Default;
            btnDeleteAccount.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnDeleteAccount.IconMarginLeft = 11;
            btnDeleteAccount.IconPadding = 10;
            btnDeleteAccount.IconRight = null;
            btnDeleteAccount.IconRightAlign = ContentAlignment.MiddleRight;
            btnDeleteAccount.IconRightCursor = Cursors.Default;
            btnDeleteAccount.IconRightPadding = new Padding(3, 3, 7, 3);
            btnDeleteAccount.IconSize = 25;
            btnDeleteAccount.IdleBorderColor = Color.Empty;
            btnDeleteAccount.IdleBorderRadius = 0;
            btnDeleteAccount.IdleBorderThickness = 0;
            btnDeleteAccount.IdleFillColor = Color.Empty;
            btnDeleteAccount.IdleIconLeftImage = null;
            btnDeleteAccount.IdleIconRightImage = null;
            btnDeleteAccount.IndicateFocus = false;
            btnDeleteAccount.Location = new Point(16, 550);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnDeleteAccount.OnDisabledState.BorderRadius = 30;
            btnDeleteAccount.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteAccount.OnDisabledState.BorderThickness = 2;
            btnDeleteAccount.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnDeleteAccount.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnDeleteAccount.OnDisabledState.IconLeftImage = null;
            btnDeleteAccount.OnDisabledState.IconRightImage = null;
            btnDeleteAccount.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnDeleteAccount.onHoverState.BorderRadius = 30;
            btnDeleteAccount.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteAccount.onHoverState.BorderThickness = 2;
            btnDeleteAccount.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnDeleteAccount.onHoverState.ForeColor = Color.White;
            btnDeleteAccount.onHoverState.IconLeftImage = null;
            btnDeleteAccount.onHoverState.IconRightImage = null;
            btnDeleteAccount.OnIdleState.BorderColor = Color.DodgerBlue;
            btnDeleteAccount.OnIdleState.BorderRadius = 30;
            btnDeleteAccount.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteAccount.OnIdleState.BorderThickness = 2;
            btnDeleteAccount.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnDeleteAccount.OnIdleState.ForeColor = Color.White;
            btnDeleteAccount.OnIdleState.IconLeftImage = null;
            btnDeleteAccount.OnIdleState.IconRightImage = null;
            btnDeleteAccount.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnDeleteAccount.OnPressedState.BorderRadius = 30;
            btnDeleteAccount.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteAccount.OnPressedState.BorderThickness = 2;
            btnDeleteAccount.OnPressedState.FillColor = Color.Gold;
            btnDeleteAccount.OnPressedState.ForeColor = Color.White;
            btnDeleteAccount.OnPressedState.IconLeftImage = null;
            btnDeleteAccount.OnPressedState.IconRightImage = null;
            btnDeleteAccount.Size = new Size(261, 64);
            btnDeleteAccount.TabIndex = 41;
            btnDeleteAccount.TextAlign = ContentAlignment.MiddleCenter;
            btnDeleteAccount.TextAlignment = HorizontalAlignment.Center;
            btnDeleteAccount.TextMarginLeft = 0;
            btnDeleteAccount.TextPadding = new Padding(0);
            btnDeleteAccount.UseDefaultRadiusAndThickness = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click_1;
            // 
            // btnExport
            // 
            btnExport.AllowAnimations = true;
            btnExport.AllowMouseEffects = true;
            btnExport.AllowToggling = false;
            btnExport.AnimationSpeed = 200;
            btnExport.AutoGenerateColors = false;
            btnExport.AutoRoundBorders = false;
            btnExport.AutoSizeLeftIcon = true;
            btnExport.AutoSizeRightIcon = true;
            btnExport.BackColor = Color.Transparent;
            btnExport.BackColor1 = Color.FromArgb(51, 122, 183);
            btnExport.BackgroundImage = (Image)resources.GetObject("btnExport.BackgroundImage");
            btnExport.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnExport.ButtonText = "Xuất File";
            btnExport.ButtonTextMarginLeft = 0;
            btnExport.ColorContrastOnClick = 45;
            btnExport.ColorContrastOnHover = 45;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            btnExport.CustomizableEdges = borderEdges5;
            btnExport.DialogResult = DialogResult.None;
            btnExport.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnExport.DisabledFillColor = Color.Empty;
            btnExport.DisabledForecolor = Color.Empty;
            btnExport.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnExport.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.IconLeft = null;
            btnExport.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnExport.IconLeftCursor = Cursors.Default;
            btnExport.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnExport.IconMarginLeft = 11;
            btnExport.IconPadding = 10;
            btnExport.IconRight = null;
            btnExport.IconRightAlign = ContentAlignment.MiddleRight;
            btnExport.IconRightCursor = Cursors.Default;
            btnExport.IconRightPadding = new Padding(3, 3, 7, 3);
            btnExport.IconSize = 25;
            btnExport.IdleBorderColor = Color.Empty;
            btnExport.IdleBorderRadius = 0;
            btnExport.IdleBorderThickness = 0;
            btnExport.IdleFillColor = Color.Empty;
            btnExport.IdleIconLeftImage = null;
            btnExport.IdleIconRightImage = null;
            btnExport.IndicateFocus = false;
            btnExport.Location = new Point(16, 645);
            btnExport.Name = "btnExport";
            btnExport.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnExport.OnDisabledState.BorderRadius = 30;
            btnExport.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnExport.OnDisabledState.BorderThickness = 2;
            btnExport.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnExport.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnExport.OnDisabledState.IconLeftImage = null;
            btnExport.OnDisabledState.IconRightImage = null;
            btnExport.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnExport.onHoverState.BorderRadius = 30;
            btnExport.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnExport.onHoverState.BorderThickness = 2;
            btnExport.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnExport.onHoverState.ForeColor = Color.White;
            btnExport.onHoverState.IconLeftImage = null;
            btnExport.onHoverState.IconRightImage = null;
            btnExport.OnIdleState.BorderColor = Color.DodgerBlue;
            btnExport.OnIdleState.BorderRadius = 30;
            btnExport.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnExport.OnIdleState.BorderThickness = 2;
            btnExport.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnExport.OnIdleState.ForeColor = Color.White;
            btnExport.OnIdleState.IconLeftImage = null;
            btnExport.OnIdleState.IconRightImage = null;
            btnExport.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnExport.OnPressedState.BorderRadius = 30;
            btnExport.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnExport.OnPressedState.BorderThickness = 2;
            btnExport.OnPressedState.FillColor = Color.Gold;
            btnExport.OnPressedState.ForeColor = Color.White;
            btnExport.OnPressedState.IconLeftImage = null;
            btnExport.OnPressedState.IconRightImage = null;
            btnExport.Size = new Size(261, 64);
            btnExport.TabIndex = 42;
            btnExport.TextAlign = ContentAlignment.MiddleCenter;
            btnExport.TextAlignment = HorizontalAlignment.Center;
            btnExport.TextMarginLeft = 0;
            btnExport.TextPadding = new Padding(0);
            btnExport.UseDefaultRadiusAndThickness = true;
            btnExport.Click += btnExport_Click_1;
            // 
            // btnShowAccount
            // 
            btnShowAccount.AllowAnimations = true;
            btnShowAccount.AllowMouseEffects = true;
            btnShowAccount.AllowToggling = false;
            btnShowAccount.AnimationSpeed = 200;
            btnShowAccount.AutoGenerateColors = false;
            btnShowAccount.AutoRoundBorders = false;
            btnShowAccount.AutoSizeLeftIcon = true;
            btnShowAccount.AutoSizeRightIcon = true;
            btnShowAccount.BackColor = Color.Transparent;
            btnShowAccount.BackColor1 = Color.FromArgb(51, 122, 183);
            btnShowAccount.BackgroundImage = (Image)resources.GetObject("btnShowAccount.BackgroundImage");
            btnShowAccount.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowAccount.ButtonText = "Xem";
            btnShowAccount.ButtonTextMarginLeft = 0;
            btnShowAccount.ColorContrastOnClick = 45;
            btnShowAccount.ColorContrastOnHover = 45;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            btnShowAccount.CustomizableEdges = borderEdges6;
            btnShowAccount.DialogResult = DialogResult.None;
            btnShowAccount.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnShowAccount.DisabledFillColor = Color.Empty;
            btnShowAccount.DisabledForecolor = Color.Empty;
            btnShowAccount.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnShowAccount.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnShowAccount.ForeColor = Color.White;
            btnShowAccount.IconLeft = null;
            btnShowAccount.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnShowAccount.IconLeftCursor = Cursors.Default;
            btnShowAccount.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnShowAccount.IconMarginLeft = 11;
            btnShowAccount.IconPadding = 10;
            btnShowAccount.IconRight = null;
            btnShowAccount.IconRightAlign = ContentAlignment.MiddleRight;
            btnShowAccount.IconRightCursor = Cursors.Default;
            btnShowAccount.IconRightPadding = new Padding(3, 3, 7, 3);
            btnShowAccount.IconSize = 25;
            btnShowAccount.IdleBorderColor = Color.Empty;
            btnShowAccount.IdleBorderRadius = 0;
            btnShowAccount.IdleBorderThickness = 0;
            btnShowAccount.IdleFillColor = Color.Empty;
            btnShowAccount.IdleIconLeftImage = null;
            btnShowAccount.IdleIconRightImage = null;
            btnShowAccount.IndicateFocus = false;
            btnShowAccount.Location = new Point(16, 272);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnShowAccount.OnDisabledState.BorderRadius = 30;
            btnShowAccount.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowAccount.OnDisabledState.BorderThickness = 2;
            btnShowAccount.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnShowAccount.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnShowAccount.OnDisabledState.IconLeftImage = null;
            btnShowAccount.OnDisabledState.IconRightImage = null;
            btnShowAccount.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnShowAccount.onHoverState.BorderRadius = 30;
            btnShowAccount.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowAccount.onHoverState.BorderThickness = 2;
            btnShowAccount.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnShowAccount.onHoverState.ForeColor = Color.White;
            btnShowAccount.onHoverState.IconLeftImage = null;
            btnShowAccount.onHoverState.IconRightImage = null;
            btnShowAccount.OnIdleState.BorderColor = Color.DodgerBlue;
            btnShowAccount.OnIdleState.BorderRadius = 30;
            btnShowAccount.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowAccount.OnIdleState.BorderThickness = 2;
            btnShowAccount.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnShowAccount.OnIdleState.ForeColor = Color.White;
            btnShowAccount.OnIdleState.IconLeftImage = null;
            btnShowAccount.OnIdleState.IconRightImage = null;
            btnShowAccount.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnShowAccount.OnPressedState.BorderRadius = 30;
            btnShowAccount.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowAccount.OnPressedState.BorderThickness = 2;
            btnShowAccount.OnPressedState.FillColor = Color.Gold;
            btnShowAccount.OnPressedState.ForeColor = Color.White;
            btnShowAccount.OnPressedState.IconLeftImage = null;
            btnShowAccount.OnPressedState.IconRightImage = null;
            btnShowAccount.Size = new Size(261, 64);
            btnShowAccount.TabIndex = 43;
            btnShowAccount.TextAlign = ContentAlignment.MiddleCenter;
            btnShowAccount.TextAlignment = HorizontalAlignment.Center;
            btnShowAccount.TextMarginLeft = 0;
            btnShowAccount.TextPadding = new Padding(0);
            btnShowAccount.UseDefaultRadiusAndThickness = true;
            btnShowAccount.Click += btnShowAccount_Click;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnShowAccount);
            Controls.Add(btnExport);
            Controls.Add(btnDeleteAccount);
            Controls.Add(btnUpdateAccount);
            Controls.Add(btnInsertAccount);
            Controls.Add(btnReset);
            Controls.Add(groupBox1);
            Controls.Add(grpAccount);
            Controls.Add(dtgvAccount);
            Margin = new Padding(2);
            Name = "Account";
            Size = new Size(1440, 748);
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReset;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnInsertAccount;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdateAccount;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDeleteAccount;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExport;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnShowAccount;
    }
}
