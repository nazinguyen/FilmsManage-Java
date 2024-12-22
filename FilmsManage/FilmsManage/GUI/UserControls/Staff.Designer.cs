namespace FilmsManage.GUI.UserControls
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            txtStaffName = new TextBox();
            lblStaffID = new Label();
            txtStaffId = new TextBox();
            txtStaffEmail = new TextBox();
            lblStaffINumber = new Label();
            lblStaffBirth = new Label();
            txtStaffPass = new TextBox();
            lblStaffPhone = new Label();
            txtSearchStaff = new TextBox();
            txtStaffPhone = new TextBox();
            lblStaffEmail = new Label();
            grpStaff = new GroupBox();
            txtTenQuyen = new TextBox();
            lblStaffRole = new Label();
            cbbMaQuyen = new ComboBox();
            lblStaffName = new Label();
            btnSearchStaff = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            dtgvStaff = new DataGridView();
            lblTimKiem = new Label();
            btnShowStaff = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnAddStaff = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnUpdateStaff = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnDeleteStaff = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnExport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            grpStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStaff).BeginInit();
            SuspendLayout();
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffName.Location = new Point(187, 111);
            txtStaffName.Margin = new Padding(3, 4, 3, 4);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(237, 35);
            txtStaffName.TabIndex = 2;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffID.Location = new Point(30, 61);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(93, 26);
            lblStaffID.TabIndex = 4;
            lblStaffID.Text = "Mã NV:";
            // 
            // txtStaffId
            // 
            txtStaffId.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffId.Location = new Point(187, 50);
            txtStaffId.Margin = new Padding(3, 4, 3, 4);
            txtStaffId.Name = "txtStaffId";
            txtStaffId.ReadOnly = true;
            txtStaffId.Size = new Size(237, 35);
            txtStaffId.TabIndex = 2;
            // 
            // txtStaffEmail
            // 
            txtStaffEmail.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffEmail.Location = new Point(651, 109);
            txtStaffEmail.Margin = new Padding(3, 4, 3, 4);
            txtStaffEmail.Name = "txtStaffEmail";
            txtStaffEmail.Size = new Size(237, 35);
            txtStaffEmail.TabIndex = 2;
            // 
            // lblStaffINumber
            // 
            lblStaffINumber.AutoSize = true;
            lblStaffINumber.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffINumber.Location = new Point(941, 114);
            lblStaffINumber.Name = "lblStaffINumber";
            lblStaffINumber.Size = new Size(135, 26);
            lblStaffINumber.TabIndex = 4;
            lblStaffINumber.Text = "Mã Quyền :";
            // 
            // lblStaffBirth
            // 
            lblStaffBirth.AutoSize = true;
            lblStaffBirth.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffBirth.Location = new Point(30, 169);
            lblStaffBirth.Name = "lblStaffBirth";
            lblStaffBirth.Size = new Size(81, 26);
            lblStaffBirth.TabIndex = 4;
            lblStaffBirth.Text = "Số ĐT:";
            // 
            // txtStaffPass
            // 
            txtStaffPass.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffPass.Location = new Point(651, 169);
            txtStaffPass.Margin = new Padding(3, 4, 3, 4);
            txtStaffPass.Name = "txtStaffPass";
            txtStaffPass.PasswordChar = '*';
            txtStaffPass.Size = new Size(237, 35);
            txtStaffPass.TabIndex = 2;
            // 
            // lblStaffPhone
            // 
            lblStaffPhone.AutoSize = true;
            lblStaffPhone.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffPhone.Location = new Point(510, 178);
            lblStaffPhone.Name = "lblStaffPhone";
            lblStaffPhone.Size = new Size(126, 26);
            lblStaffPhone.TabIndex = 4;
            lblStaffPhone.Text = "Mật khẩu :";
            // 
            // txtSearchStaff
            // 
            txtSearchStaff.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtSearchStaff.Location = new Point(1035, 273);
            txtSearchStaff.Margin = new Padding(3, 4, 3, 4);
            txtSearchStaff.Name = "txtSearchStaff";
            txtSearchStaff.Size = new Size(164, 37);
            txtSearchStaff.TabIndex = 21;
            // 
            // txtStaffPhone
            // 
            txtStaffPhone.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffPhone.Location = new Point(187, 165);
            txtStaffPhone.Margin = new Padding(3, 4, 3, 4);
            txtStaffPhone.Name = "txtStaffPhone";
            txtStaffPhone.Size = new Size(237, 35);
            txtStaffPhone.TabIndex = 2;
            // 
            // lblStaffEmail
            // 
            lblStaffEmail.AutoSize = true;
            lblStaffEmail.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffEmail.Location = new Point(510, 120);
            lblStaffEmail.Name = "lblStaffEmail";
            lblStaffEmail.Size = new Size(81, 26);
            lblStaffEmail.TabIndex = 4;
            lblStaffEmail.Text = "Email:";
            // 
            // grpStaff
            // 
            grpStaff.BackColor = Color.Transparent;
            grpStaff.Controls.Add(txtTenQuyen);
            grpStaff.Controls.Add(lblStaffRole);
            grpStaff.Controls.Add(cbbMaQuyen);
            grpStaff.Controls.Add(lblStaffID);
            grpStaff.Controls.Add(txtStaffId);
            grpStaff.Controls.Add(txtStaffEmail);
            grpStaff.Controls.Add(lblStaffINumber);
            grpStaff.Controls.Add(txtStaffName);
            grpStaff.Controls.Add(lblStaffBirth);
            grpStaff.Controls.Add(txtStaffPass);
            grpStaff.Controls.Add(lblStaffPhone);
            grpStaff.Controls.Add(txtStaffPhone);
            grpStaff.Controls.Add(lblStaffEmail);
            grpStaff.Controls.Add(lblStaffName);
            grpStaff.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpStaff.Location = new Point(78, 22);
            grpStaff.Margin = new Padding(3, 4, 3, 4);
            grpStaff.Name = "grpStaff";
            grpStaff.Padding = new Padding(3, 4, 3, 4);
            grpStaff.Size = new Size(1339, 228);
            grpStaff.TabIndex = 23;
            grpStaff.TabStop = false;
            grpStaff.Text = "Thông tin nhân viên";
            // 
            // txtTenQuyen
            // 
            txtTenQuyen.Location = new Point(1080, 178);
            txtTenQuyen.Name = "txtTenQuyen";
            txtTenQuyen.Size = new Size(234, 35);
            txtTenQuyen.TabIndex = 7;
            // 
            // lblStaffRole
            // 
            lblStaffRole.AutoSize = true;
            lblStaffRole.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblStaffRole.Location = new Point(941, 178);
            lblStaffRole.Name = "lblStaffRole";
            lblStaffRole.Size = new Size(133, 26);
            lblStaffRole.TabIndex = 6;
            lblStaffRole.Text = "Tên quyền: ";
            // 
            // cbbMaQuyen
            // 
            cbbMaQuyen.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            cbbMaQuyen.FormattingEnabled = true;
            cbbMaQuyen.Location = new Point(1080, 109);
            cbbMaQuyen.Name = "cbbMaQuyen";
            cbbMaQuyen.Size = new Size(237, 34);
            cbbMaQuyen.TabIndex = 5;
            cbbMaQuyen.SelectedIndexChanged += cbbMaQuyen_SelectedIndexChanged_1;
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffName.Location = new Point(30, 118);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(97, 26);
            lblStaffName.TabIndex = 4;
            lblStaffName.Text = "Tên NV:";
            // 
            // btnSearchStaff
            // 
            btnSearchStaff.AllowAnimations = true;
            btnSearchStaff.AllowMouseEffects = true;
            btnSearchStaff.AllowToggling = false;
            btnSearchStaff.AnimationSpeed = 200;
            btnSearchStaff.AutoGenerateColors = false;
            btnSearchStaff.AutoRoundBorders = false;
            btnSearchStaff.AutoSizeLeftIcon = true;
            btnSearchStaff.AutoSizeRightIcon = true;
            btnSearchStaff.BackColor = Color.Transparent;
            btnSearchStaff.BackColor1 = Color.FromArgb(51, 122, 183);
            btnSearchStaff.BackgroundImage = (Image)resources.GetObject("btnSearchStaff.BackgroundImage");
            btnSearchStaff.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            btnSearchStaff.ButtonText = "";
            btnSearchStaff.ButtonTextMarginLeft = 0;
            btnSearchStaff.ColorContrastOnClick = 45;
            btnSearchStaff.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btnSearchStaff.CustomizableEdges = borderEdges1;
            btnSearchStaff.DialogResult = DialogResult.None;
            btnSearchStaff.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnSearchStaff.DisabledFillColor = Color.Empty;
            btnSearchStaff.DisabledForecolor = Color.Empty;
            btnSearchStaff.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            btnSearchStaff.Font = new Font("Segoe UI", 9F);
            btnSearchStaff.ForeColor = Color.White;
            btnSearchStaff.IconLeft = Properties.Resources.search_icon;
            btnSearchStaff.IconLeftAlign = ContentAlignment.MiddleCenter;
            btnSearchStaff.IconLeftCursor = Cursors.Default;
            btnSearchStaff.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnSearchStaff.IconMarginLeft = 11;
            btnSearchStaff.IconPadding = 10;
            btnSearchStaff.IconRight = null;
            btnSearchStaff.IconRightAlign = ContentAlignment.MiddleRight;
            btnSearchStaff.IconRightCursor = Cursors.Default;
            btnSearchStaff.IconRightPadding = new Padding(3, 3, 7, 3);
            btnSearchStaff.IconSize = 25;
            btnSearchStaff.IdleBorderColor = Color.Empty;
            btnSearchStaff.IdleBorderRadius = 0;
            btnSearchStaff.IdleBorderThickness = 0;
            btnSearchStaff.IdleFillColor = Color.Empty;
            btnSearchStaff.IdleIconLeftImage = Properties.Resources.search_icon;
            btnSearchStaff.IdleIconRightImage = null;
            btnSearchStaff.IndicateFocus = false;
            btnSearchStaff.Location = new Point(1250, 257);
            btnSearchStaff.Name = "btnSearchStaff";
            btnSearchStaff.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnSearchStaff.OnDisabledState.BorderRadius = 30;
            btnSearchStaff.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            btnSearchStaff.OnDisabledState.BorderThickness = 1;
            btnSearchStaff.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnSearchStaff.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnSearchStaff.OnDisabledState.IconLeftImage = null;
            btnSearchStaff.OnDisabledState.IconRightImage = null;
            btnSearchStaff.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnSearchStaff.onHoverState.BorderRadius = 30;
            btnSearchStaff.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnSearchStaff.onHoverState.BorderThickness = 1;
            btnSearchStaff.onHoverState.FillColor = Color.OrangeRed;
            btnSearchStaff.onHoverState.ForeColor = Color.White;
            btnSearchStaff.onHoverState.IconLeftImage = null;
            btnSearchStaff.onHoverState.IconRightImage = null;
            btnSearchStaff.OnIdleState.BorderColor = Color.DodgerBlue;
            btnSearchStaff.OnIdleState.BorderRadius = 30;
            btnSearchStaff.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            btnSearchStaff.OnIdleState.BorderThickness = 1;
            btnSearchStaff.OnIdleState.FillColor = Color.DodgerBlue;
            btnSearchStaff.OnIdleState.ForeColor = Color.White;
            btnSearchStaff.OnIdleState.IconLeftImage = Properties.Resources.search_icon;
            btnSearchStaff.OnIdleState.IconRightImage = null;
            btnSearchStaff.OnPressedState.BorderColor = Color.Gold;
            btnSearchStaff.OnPressedState.BorderRadius = 30;
            btnSearchStaff.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnSearchStaff.OnPressedState.BorderThickness = 1;
            btnSearchStaff.OnPressedState.FillColor = Color.Gold;
            btnSearchStaff.OnPressedState.ForeColor = Color.White;
            btnSearchStaff.OnPressedState.IconLeftImage = null;
            btnSearchStaff.OnPressedState.IconRightImage = null;
            btnSearchStaff.Size = new Size(131, 56);
            btnSearchStaff.TabIndex = 8;
            btnSearchStaff.TextAlign = ContentAlignment.MiddleCenter;
            btnSearchStaff.TextAlignment = HorizontalAlignment.Center;
            btnSearchStaff.TextMarginLeft = 0;
            btnSearchStaff.TextPadding = new Padding(0);
            btnSearchStaff.UseDefaultRadiusAndThickness = true;
            btnSearchStaff.Click += btnSearchStaff_Click_1;
            // 
            // dtgvStaff
            // 
            dtgvStaff.AllowUserToAddRows = false;
            dtgvStaff.AllowUserToDeleteRows = false;
            dtgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStaff.Location = new Point(276, 333);
            dtgvStaff.Margin = new Padding(4, 6, 4, 6);
            dtgvStaff.Name = "dtgvStaff";
            dtgvStaff.ReadOnly = true;
            dtgvStaff.RowHeadersWidth = 62;
            dtgvStaff.Size = new Size(1141, 392);
            dtgvStaff.TabIndex = 16;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblTimKiem.Location = new Point(870, 279);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(136, 27);
            lblTimKiem.TabIndex = 24;
            lblTimKiem.Text = "Tìm theo tên";
            // 
            // btnShowStaff
            // 
            btnShowStaff.AllowAnimations = true;
            btnShowStaff.AllowMouseEffects = true;
            btnShowStaff.AllowToggling = false;
            btnShowStaff.AnimationSpeed = 200;
            btnShowStaff.AutoGenerateColors = false;
            btnShowStaff.AutoRoundBorders = false;
            btnShowStaff.AutoSizeLeftIcon = true;
            btnShowStaff.AutoSizeRightIcon = true;
            btnShowStaff.BackColor = Color.Transparent;
            btnShowStaff.BackColor1 = Color.FromArgb(51, 122, 183);
            btnShowStaff.BackgroundImage = (Image)resources.GetObject("btnShowStaff.BackgroundImage");
            btnShowStaff.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowStaff.ButtonText = "Xem";
            btnShowStaff.ButtonTextMarginLeft = 0;
            btnShowStaff.ColorContrastOnClick = 45;
            btnShowStaff.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            btnShowStaff.CustomizableEdges = borderEdges2;
            btnShowStaff.DialogResult = DialogResult.None;
            btnShowStaff.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnShowStaff.DisabledFillColor = Color.Empty;
            btnShowStaff.DisabledForecolor = Color.Empty;
            btnShowStaff.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            btnShowStaff.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnShowStaff.ForeColor = Color.White;
            btnShowStaff.IconLeft = null;
            btnShowStaff.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnShowStaff.IconLeftCursor = Cursors.Default;
            btnShowStaff.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnShowStaff.IconMarginLeft = 11;
            btnShowStaff.IconPadding = 10;
            btnShowStaff.IconRight = null;
            btnShowStaff.IconRightAlign = ContentAlignment.MiddleRight;
            btnShowStaff.IconRightCursor = Cursors.Default;
            btnShowStaff.IconRightPadding = new Padding(3, 3, 7, 3);
            btnShowStaff.IconSize = 25;
            btnShowStaff.IdleBorderColor = Color.Empty;
            btnShowStaff.IdleBorderRadius = 0;
            btnShowStaff.IdleBorderThickness = 0;
            btnShowStaff.IdleFillColor = Color.Empty;
            btnShowStaff.IdleIconLeftImage = null;
            btnShowStaff.IdleIconRightImage = null;
            btnShowStaff.IndicateFocus = false;
            btnShowStaff.Location = new Point(78, 333);
            btnShowStaff.Name = "btnShowStaff";
            btnShowStaff.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnShowStaff.OnDisabledState.BorderRadius = 30;
            btnShowStaff.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowStaff.OnDisabledState.BorderThickness = 2;
            btnShowStaff.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnShowStaff.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnShowStaff.OnDisabledState.IconLeftImage = null;
            btnShowStaff.OnDisabledState.IconRightImage = null;
            btnShowStaff.onHoverState.BorderColor = Color.FromArgb(119, 33, 19);
            btnShowStaff.onHoverState.BorderRadius = 30;
            btnShowStaff.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowStaff.onHoverState.BorderThickness = 2;
            btnShowStaff.onHoverState.FillColor = Color.DodgerBlue;
            btnShowStaff.onHoverState.ForeColor = Color.White;
            btnShowStaff.onHoverState.IconLeftImage = null;
            btnShowStaff.onHoverState.IconRightImage = null;
            btnShowStaff.OnIdleState.BorderColor = Color.DarkViolet;
            btnShowStaff.OnIdleState.BorderRadius = 30;
            btnShowStaff.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowStaff.OnIdleState.BorderThickness = 2;
            btnShowStaff.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnShowStaff.OnIdleState.ForeColor = Color.White;
            btnShowStaff.OnIdleState.IconLeftImage = null;
            btnShowStaff.OnIdleState.IconRightImage = null;
            btnShowStaff.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnShowStaff.OnPressedState.BorderRadius = 30;
            btnShowStaff.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowStaff.OnPressedState.BorderThickness = 2;
            btnShowStaff.OnPressedState.FillColor = Color.Gold;
            btnShowStaff.OnPressedState.ForeColor = Color.White;
            btnShowStaff.OnPressedState.IconLeftImage = null;
            btnShowStaff.OnPressedState.IconRightImage = null;
            btnShowStaff.Size = new Size(171, 58);
            btnShowStaff.TabIndex = 26;
            btnShowStaff.TextAlign = ContentAlignment.MiddleCenter;
            btnShowStaff.TextAlignment = HorizontalAlignment.Center;
            btnShowStaff.TextMarginLeft = 0;
            btnShowStaff.TextPadding = new Padding(0);
            btnShowStaff.UseDefaultRadiusAndThickness = true;
            // 
            // btnAddStaff
            // 
            btnAddStaff.AllowAnimations = true;
            btnAddStaff.AllowMouseEffects = true;
            btnAddStaff.AllowToggling = false;
            btnAddStaff.AnimationSpeed = 200;
            btnAddStaff.AutoGenerateColors = false;
            btnAddStaff.AutoRoundBorders = false;
            btnAddStaff.AutoSizeLeftIcon = true;
            btnAddStaff.AutoSizeRightIcon = true;
            btnAddStaff.BackColor = Color.Transparent;
            btnAddStaff.BackColor1 = Color.FromArgb(51, 122, 183);
            btnAddStaff.BackgroundImage = (Image)resources.GetObject("btnAddStaff.BackgroundImage");
            btnAddStaff.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAddStaff.ButtonText = "Thêm";
            btnAddStaff.ButtonTextMarginLeft = 0;
            btnAddStaff.ColorContrastOnClick = 45;
            btnAddStaff.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            btnAddStaff.CustomizableEdges = borderEdges3;
            btnAddStaff.DialogResult = DialogResult.None;
            btnAddStaff.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnAddStaff.DisabledFillColor = Color.Empty;
            btnAddStaff.DisabledForecolor = Color.Empty;
            btnAddStaff.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnAddStaff.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnAddStaff.ForeColor = Color.White;
            btnAddStaff.IconLeft = null;
            btnAddStaff.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnAddStaff.IconLeftCursor = Cursors.Default;
            btnAddStaff.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnAddStaff.IconMarginLeft = 11;
            btnAddStaff.IconPadding = 10;
            btnAddStaff.IconRight = null;
            btnAddStaff.IconRightAlign = ContentAlignment.MiddleRight;
            btnAddStaff.IconRightCursor = Cursors.Default;
            btnAddStaff.IconRightPadding = new Padding(3, 3, 7, 3);
            btnAddStaff.IconSize = 25;
            btnAddStaff.IdleBorderColor = Color.Empty;
            btnAddStaff.IdleBorderRadius = 0;
            btnAddStaff.IdleBorderThickness = 0;
            btnAddStaff.IdleFillColor = Color.Empty;
            btnAddStaff.IdleIconLeftImage = null;
            btnAddStaff.IdleIconRightImage = null;
            btnAddStaff.IndicateFocus = false;
            btnAddStaff.Location = new Point(78, 408);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnAddStaff.OnDisabledState.BorderRadius = 30;
            btnAddStaff.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAddStaff.OnDisabledState.BorderThickness = 1;
            btnAddStaff.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnAddStaff.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnAddStaff.OnDisabledState.IconLeftImage = null;
            btnAddStaff.OnDisabledState.IconRightImage = null;
            btnAddStaff.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnAddStaff.onHoverState.BorderRadius = 30;
            btnAddStaff.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAddStaff.onHoverState.BorderThickness = 1;
            btnAddStaff.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnAddStaff.onHoverState.ForeColor = Color.White;
            btnAddStaff.onHoverState.IconLeftImage = null;
            btnAddStaff.onHoverState.IconRightImage = null;
            btnAddStaff.OnIdleState.BorderColor = Color.DodgerBlue;
            btnAddStaff.OnIdleState.BorderRadius = 30;
            btnAddStaff.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAddStaff.OnIdleState.BorderThickness = 1;
            btnAddStaff.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnAddStaff.OnIdleState.ForeColor = Color.White;
            btnAddStaff.OnIdleState.IconLeftImage = null;
            btnAddStaff.OnIdleState.IconRightImage = null;
            btnAddStaff.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnAddStaff.OnPressedState.BorderRadius = 30;
            btnAddStaff.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAddStaff.OnPressedState.BorderThickness = 1;
            btnAddStaff.OnPressedState.FillColor = Color.Gold;
            btnAddStaff.OnPressedState.ForeColor = Color.White;
            btnAddStaff.OnPressedState.IconLeftImage = null;
            btnAddStaff.OnPressedState.IconRightImage = null;
            btnAddStaff.Size = new Size(168, 58);
            btnAddStaff.TabIndex = 27;
            btnAddStaff.TextAlign = ContentAlignment.MiddleCenter;
            btnAddStaff.TextAlignment = HorizontalAlignment.Center;
            btnAddStaff.TextMarginLeft = 0;
            btnAddStaff.TextPadding = new Padding(0);
            btnAddStaff.UseDefaultRadiusAndThickness = true;
            btnAddStaff.Click += btnAddStaff_Click_1;
            // 
            // btnUpdateStaff
            // 
            btnUpdateStaff.AllowAnimations = true;
            btnUpdateStaff.AllowMouseEffects = true;
            btnUpdateStaff.AllowToggling = false;
            btnUpdateStaff.AnimationSpeed = 200;
            btnUpdateStaff.AutoGenerateColors = false;
            btnUpdateStaff.AutoRoundBorders = false;
            btnUpdateStaff.AutoSizeLeftIcon = true;
            btnUpdateStaff.AutoSizeRightIcon = true;
            btnUpdateStaff.BackColor = Color.Transparent;
            btnUpdateStaff.BackColor1 = Color.FromArgb(51, 122, 183);
            btnUpdateStaff.BackgroundImage = (Image)resources.GetObject("btnUpdateStaff.BackgroundImage");
            btnUpdateStaff.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateStaff.ButtonText = "Sửa";
            btnUpdateStaff.ButtonTextMarginLeft = 0;
            btnUpdateStaff.ColorContrastOnClick = 45;
            btnUpdateStaff.ColorContrastOnHover = 45;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            btnUpdateStaff.CustomizableEdges = borderEdges4;
            btnUpdateStaff.DialogResult = DialogResult.None;
            btnUpdateStaff.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnUpdateStaff.DisabledFillColor = Color.Empty;
            btnUpdateStaff.DisabledForecolor = Color.Empty;
            btnUpdateStaff.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnUpdateStaff.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnUpdateStaff.ForeColor = Color.White;
            btnUpdateStaff.IconLeft = null;
            btnUpdateStaff.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnUpdateStaff.IconLeftCursor = Cursors.Default;
            btnUpdateStaff.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnUpdateStaff.IconMarginLeft = 11;
            btnUpdateStaff.IconPadding = 10;
            btnUpdateStaff.IconRight = null;
            btnUpdateStaff.IconRightAlign = ContentAlignment.MiddleRight;
            btnUpdateStaff.IconRightCursor = Cursors.Default;
            btnUpdateStaff.IconRightPadding = new Padding(3, 3, 7, 3);
            btnUpdateStaff.IconSize = 25;
            btnUpdateStaff.IdleBorderColor = Color.Empty;
            btnUpdateStaff.IdleBorderRadius = 0;
            btnUpdateStaff.IdleBorderThickness = 0;
            btnUpdateStaff.IdleFillColor = Color.Empty;
            btnUpdateStaff.IdleIconLeftImage = null;
            btnUpdateStaff.IdleIconRightImage = null;
            btnUpdateStaff.IndicateFocus = false;
            btnUpdateStaff.Location = new Point(78, 488);
            btnUpdateStaff.Name = "btnUpdateStaff";
            btnUpdateStaff.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnUpdateStaff.OnDisabledState.BorderRadius = 30;
            btnUpdateStaff.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateStaff.OnDisabledState.BorderThickness = 1;
            btnUpdateStaff.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnUpdateStaff.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnUpdateStaff.OnDisabledState.IconLeftImage = null;
            btnUpdateStaff.OnDisabledState.IconRightImage = null;
            btnUpdateStaff.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnUpdateStaff.onHoverState.BorderRadius = 30;
            btnUpdateStaff.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateStaff.onHoverState.BorderThickness = 1;
            btnUpdateStaff.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnUpdateStaff.onHoverState.ForeColor = Color.White;
            btnUpdateStaff.onHoverState.IconLeftImage = null;
            btnUpdateStaff.onHoverState.IconRightImage = null;
            btnUpdateStaff.OnIdleState.BorderColor = Color.DodgerBlue;
            btnUpdateStaff.OnIdleState.BorderRadius = 30;
            btnUpdateStaff.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateStaff.OnIdleState.BorderThickness = 1;
            btnUpdateStaff.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnUpdateStaff.OnIdleState.ForeColor = Color.White;
            btnUpdateStaff.OnIdleState.IconLeftImage = null;
            btnUpdateStaff.OnIdleState.IconRightImage = null;
            btnUpdateStaff.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnUpdateStaff.OnPressedState.BorderRadius = 30;
            btnUpdateStaff.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateStaff.OnPressedState.BorderThickness = 1;
            btnUpdateStaff.OnPressedState.FillColor = Color.Gold;
            btnUpdateStaff.OnPressedState.ForeColor = Color.White;
            btnUpdateStaff.OnPressedState.IconLeftImage = null;
            btnUpdateStaff.OnPressedState.IconRightImage = null;
            btnUpdateStaff.Size = new Size(168, 54);
            btnUpdateStaff.TabIndex = 28;
            btnUpdateStaff.TextAlign = ContentAlignment.MiddleCenter;
            btnUpdateStaff.TextAlignment = HorizontalAlignment.Center;
            btnUpdateStaff.TextMarginLeft = 0;
            btnUpdateStaff.TextPadding = new Padding(0);
            btnUpdateStaff.UseDefaultRadiusAndThickness = true;
            btnUpdateStaff.Click += btnUpdateStaff_Click_1;
            // 
            // btnDeleteStaff
            // 
            btnDeleteStaff.AllowAnimations = true;
            btnDeleteStaff.AllowMouseEffects = true;
            btnDeleteStaff.AllowToggling = false;
            btnDeleteStaff.AnimationSpeed = 200;
            btnDeleteStaff.AutoGenerateColors = false;
            btnDeleteStaff.AutoRoundBorders = false;
            btnDeleteStaff.AutoSizeLeftIcon = true;
            btnDeleteStaff.AutoSizeRightIcon = true;
            btnDeleteStaff.BackColor = Color.Transparent;
            btnDeleteStaff.BackColor1 = Color.FromArgb(51, 122, 183);
            btnDeleteStaff.BackgroundImage = (Image)resources.GetObject("btnDeleteStaff.BackgroundImage");
            btnDeleteStaff.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteStaff.ButtonText = "Xóa";
            btnDeleteStaff.ButtonTextMarginLeft = 0;
            btnDeleteStaff.ColorContrastOnClick = 45;
            btnDeleteStaff.ColorContrastOnHover = 45;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            btnDeleteStaff.CustomizableEdges = borderEdges5;
            btnDeleteStaff.DialogResult = DialogResult.None;
            btnDeleteStaff.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnDeleteStaff.DisabledFillColor = Color.Empty;
            btnDeleteStaff.DisabledForecolor = Color.Empty;
            btnDeleteStaff.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnDeleteStaff.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnDeleteStaff.ForeColor = Color.White;
            btnDeleteStaff.IconLeft = null;
            btnDeleteStaff.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnDeleteStaff.IconLeftCursor = Cursors.Default;
            btnDeleteStaff.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnDeleteStaff.IconMarginLeft = 11;
            btnDeleteStaff.IconPadding = 10;
            btnDeleteStaff.IconRight = null;
            btnDeleteStaff.IconRightAlign = ContentAlignment.MiddleRight;
            btnDeleteStaff.IconRightCursor = Cursors.Default;
            btnDeleteStaff.IconRightPadding = new Padding(3, 3, 7, 3);
            btnDeleteStaff.IconSize = 25;
            btnDeleteStaff.IdleBorderColor = Color.Empty;
            btnDeleteStaff.IdleBorderRadius = 0;
            btnDeleteStaff.IdleBorderThickness = 0;
            btnDeleteStaff.IdleFillColor = Color.Empty;
            btnDeleteStaff.IdleIconLeftImage = null;
            btnDeleteStaff.IdleIconRightImage = null;
            btnDeleteStaff.IndicateFocus = false;
            btnDeleteStaff.Location = new Point(78, 569);
            btnDeleteStaff.Name = "btnDeleteStaff";
            btnDeleteStaff.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnDeleteStaff.OnDisabledState.BorderRadius = 30;
            btnDeleteStaff.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteStaff.OnDisabledState.BorderThickness = 1;
            btnDeleteStaff.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnDeleteStaff.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnDeleteStaff.OnDisabledState.IconLeftImage = null;
            btnDeleteStaff.OnDisabledState.IconRightImage = null;
            btnDeleteStaff.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnDeleteStaff.onHoverState.BorderRadius = 30;
            btnDeleteStaff.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteStaff.onHoverState.BorderThickness = 1;
            btnDeleteStaff.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnDeleteStaff.onHoverState.ForeColor = Color.White;
            btnDeleteStaff.onHoverState.IconLeftImage = null;
            btnDeleteStaff.onHoverState.IconRightImage = null;
            btnDeleteStaff.OnIdleState.BorderColor = Color.DodgerBlue;
            btnDeleteStaff.OnIdleState.BorderRadius = 30;
            btnDeleteStaff.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteStaff.OnIdleState.BorderThickness = 1;
            btnDeleteStaff.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnDeleteStaff.OnIdleState.ForeColor = Color.White;
            btnDeleteStaff.OnIdleState.IconLeftImage = null;
            btnDeleteStaff.OnIdleState.IconRightImage = null;
            btnDeleteStaff.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnDeleteStaff.OnPressedState.BorderRadius = 30;
            btnDeleteStaff.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteStaff.OnPressedState.BorderThickness = 1;
            btnDeleteStaff.OnPressedState.FillColor = Color.Gold;
            btnDeleteStaff.OnPressedState.ForeColor = Color.White;
            btnDeleteStaff.OnPressedState.IconLeftImage = null;
            btnDeleteStaff.OnPressedState.IconRightImage = null;
            btnDeleteStaff.Size = new Size(168, 58);
            btnDeleteStaff.TabIndex = 29;
            btnDeleteStaff.TextAlign = ContentAlignment.MiddleCenter;
            btnDeleteStaff.TextAlignment = HorizontalAlignment.Center;
            btnDeleteStaff.TextMarginLeft = 0;
            btnDeleteStaff.TextPadding = new Padding(0);
            btnDeleteStaff.UseDefaultRadiusAndThickness = true;
            btnDeleteStaff.Click += btnDeleteStaff_Click_1;
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
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            btnExport.CustomizableEdges = borderEdges6;
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
            btnExport.Location = new Point(78, 654);
            btnExport.Name = "btnExport";
            btnExport.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnExport.OnDisabledState.BorderRadius = 30;
            btnExport.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnExport.OnDisabledState.BorderThickness = 1;
            btnExport.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnExport.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnExport.OnDisabledState.IconLeftImage = null;
            btnExport.OnDisabledState.IconRightImage = null;
            btnExport.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnExport.onHoverState.BorderRadius = 30;
            btnExport.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnExport.onHoverState.BorderThickness = 1;
            btnExport.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnExport.onHoverState.ForeColor = Color.White;
            btnExport.onHoverState.IconLeftImage = null;
            btnExport.onHoverState.IconRightImage = null;
            btnExport.OnIdleState.BorderColor = Color.DodgerBlue;
            btnExport.OnIdleState.BorderRadius = 30;
            btnExport.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnExport.OnIdleState.BorderThickness = 1;
            btnExport.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnExport.OnIdleState.ForeColor = Color.White;
            btnExport.OnIdleState.IconLeftImage = null;
            btnExport.OnIdleState.IconRightImage = null;
            btnExport.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnExport.OnPressedState.BorderRadius = 30;
            btnExport.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnExport.OnPressedState.BorderThickness = 1;
            btnExport.OnPressedState.FillColor = Color.Gold;
            btnExport.OnPressedState.ForeColor = Color.White;
            btnExport.OnPressedState.IconLeftImage = null;
            btnExport.OnPressedState.IconRightImage = null;
            btnExport.Size = new Size(168, 58);
            btnExport.TabIndex = 30;
            btnExport.TextAlign = ContentAlignment.MiddleCenter;
            btnExport.TextAlignment = HorizontalAlignment.Center;
            btnExport.TextMarginLeft = 0;
            btnExport.TextPadding = new Padding(0);
            btnExport.UseDefaultRadiusAndThickness = true;
            btnExport.Click += btnExport_Click_1;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnExport);
            Controls.Add(btnDeleteStaff);
            Controls.Add(btnUpdateStaff);
            Controls.Add(btnAddStaff);
            Controls.Add(btnShowStaff);
            Controls.Add(btnSearchStaff);
            Controls.Add(lblTimKiem);
            Controls.Add(txtSearchStaff);
            Controls.Add(grpStaff);
            Controls.Add(dtgvStaff);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Staff";
            Size = new Size(1440, 747);
            grpStaff.ResumeLayout(false);
            grpStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.TextBox txtStaffEmail;
        private System.Windows.Forms.Label lblStaffINumber;
        private System.Windows.Forms.Label lblStaffBirth;
        private System.Windows.Forms.TextBox txtStaffPass;
        private System.Windows.Forms.Label lblStaffPhone;
        private System.Windows.Forms.TextBox txtSearchStaff;
        private System.Windows.Forms.TextBox txtStaffBirth;
        private System.Windows.Forms.Label lblStaffEmail;
        private System.Windows.Forms.GroupBox grpStaff;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.DataGridView dtgvStaff;
        private Label lblTimKiem;
        private TextBox txtStaffPhone;
        private ComboBox cbbMaQuyen;
        private Label lblStaffRole;
        private TextBox txtTenQuyen;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSearchStaff;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnShowStaff;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddStaff;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdateStaff;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDeleteStaff;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExport;
    }
}
