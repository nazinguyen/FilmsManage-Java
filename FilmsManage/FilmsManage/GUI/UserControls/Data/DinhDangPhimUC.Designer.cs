namespace FilmsManage.GUI.UserControls.Data
{
    partial class DinhDangPhimUC
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DinhDangPhimUC));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            panel1 = new Panel();
            panel2 = new Panel();
            dtgvFormat = new DataGridView();
            panel3 = new Panel();
            cbMaMH = new ComboBox();
            label3 = new Label();
            txtTenMh = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtTenDangPhim = new TextBox();
            lblFormatID = new Label();
            txtFormatID = new TextBox();
            btnShowFormat = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnInsertFormat = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnUpdateFormat = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnExport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFormat).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(btnUpdateFormat);
            panel1.Controls.Add(btnInsertFormat);
            panel1.Controls.Add(btnShowFormat);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1935, 420);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgvFormat);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 420);
            panel2.Margin = new Padding(5, 6, 5, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1935, 578);
            panel2.TabIndex = 1;
            // 
            // dtgvFormat
            // 
            dtgvFormat.AllowUserToAddRows = false;
            dtgvFormat.AllowUserToDeleteRows = false;
            dtgvFormat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvFormat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFormat.Dock = DockStyle.Fill;
            dtgvFormat.Location = new Point(0, 0);
            dtgvFormat.Margin = new Padding(4, 5, 4, 5);
            dtgvFormat.Name = "dtgvFormat";
            dtgvFormat.ReadOnly = true;
            dtgvFormat.RowHeadersWidth = 51;
            dtgvFormat.Size = new Size(1096, 578);
            dtgvFormat.TabIndex = 9;
            dtgvFormat.CellContentClick += dtgvFormat_CellContentClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(cbMaMH);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtTenMh);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtTenDangPhim);
            panel3.Controls.Add(lblFormatID);
            panel3.Controls.Add(txtFormatID);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1096, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(839, 578);
            panel3.TabIndex = 0;
            // 
            // cbMaMH
            // 
            cbMaMH.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaMH.FormattingEnabled = true;
            cbMaMH.Location = new Point(219, 149);
            cbMaMH.Margin = new Padding(4, 2, 4, 2);
            cbMaMH.Name = "cbMaMH";
            cbMaMH.Size = new Size(310, 33);
            cbMaMH.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 225);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(161, 26);
            label3.TabIndex = 26;
            label3.Text = "Tên màn hình:";
            // 
            // txtTenMh
            // 
            txtTenMh.Location = new Point(219, 220);
            txtTenMh.Margin = new Padding(5);
            txtTenMh.Name = "txtTenMh";
            txtTenMh.Size = new Size(304, 31);
            txtTenMh.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 151);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 26);
            label2.TabIndex = 24;
            label2.Text = "Mã màn hình:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 79);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 26);
            label1.TabIndex = 23;
            label1.Text = "Tên dạng phim:";
            // 
            // txtTenDangPhim
            // 
            txtTenDangPhim.Location = new Point(219, 74);
            txtTenDangPhim.Margin = new Padding(5);
            txtTenDangPhim.Name = "txtTenDangPhim";
            txtTenDangPhim.Size = new Size(310, 31);
            txtTenDangPhim.TabIndex = 22;
            // 
            // lblFormatID
            // 
            lblFormatID.AutoSize = true;
            lblFormatID.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormatID.Location = new Point(20, 26);
            lblFormatID.Margin = new Padding(4, 0, 4, 0);
            lblFormatID.Name = "lblFormatID";
            lblFormatID.Size = new Size(163, 26);
            lblFormatID.TabIndex = 19;
            lblFormatID.Text = "Mã định dạng:";
            // 
            // txtFormatID
            // 
            txtFormatID.Location = new Point(219, 24);
            txtFormatID.Margin = new Padding(4, 5, 4, 5);
            txtFormatID.Name = "txtFormatID";
            txtFormatID.Size = new Size(310, 31);
            txtFormatID.TabIndex = 14;
            // 
            // btnShowFormat
            // 
            btnShowFormat.AllowAnimations = true;
            btnShowFormat.AllowMouseEffects = true;
            btnShowFormat.AllowToggling = false;
            btnShowFormat.AnimationSpeed = 200;
            btnShowFormat.AutoGenerateColors = false;
            btnShowFormat.AutoRoundBorders = false;
            btnShowFormat.AutoSizeLeftIcon = true;
            btnShowFormat.AutoSizeRightIcon = true;
            btnShowFormat.BackColor = Color.Transparent;
            btnShowFormat.BackColor1 = Color.FromArgb(51, 122, 183);
            btnShowFormat.BackgroundImage = (Image)resources.GetObject("btnShowFormat.BackgroundImage");
            btnShowFormat.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowFormat.ButtonText = "Xem";
            btnShowFormat.ButtonTextMarginLeft = 0;
            btnShowFormat.ColorContrastOnClick = 45;
            btnShowFormat.ColorContrastOnHover = 45;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            btnShowFormat.CustomizableEdges = borderEdges4;
            btnShowFormat.DialogResult = DialogResult.None;
            btnShowFormat.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnShowFormat.DisabledFillColor = Color.Empty;
            btnShowFormat.DisabledForecolor = Color.Empty;
            btnShowFormat.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnShowFormat.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnShowFormat.ForeColor = Color.White;
            btnShowFormat.IconLeft = null;
            btnShowFormat.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnShowFormat.IconLeftCursor = Cursors.Default;
            btnShowFormat.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnShowFormat.IconMarginLeft = 11;
            btnShowFormat.IconPadding = 10;
            btnShowFormat.IconRight = null;
            btnShowFormat.IconRightAlign = ContentAlignment.MiddleRight;
            btnShowFormat.IconRightCursor = Cursors.Default;
            btnShowFormat.IconRightPadding = new Padding(3, 3, 7, 3);
            btnShowFormat.IconSize = 25;
            btnShowFormat.IdleBorderColor = Color.Empty;
            btnShowFormat.IdleBorderRadius = 0;
            btnShowFormat.IdleBorderThickness = 0;
            btnShowFormat.IdleFillColor = Color.Empty;
            btnShowFormat.IdleIconLeftImage = null;
            btnShowFormat.IdleIconRightImage = null;
            btnShowFormat.IndicateFocus = false;
            btnShowFormat.Location = new Point(43, 306);
            btnShowFormat.Name = "btnShowFormat";
            btnShowFormat.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnShowFormat.OnDisabledState.BorderRadius = 30;
            btnShowFormat.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowFormat.OnDisabledState.BorderThickness = 2;
            btnShowFormat.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnShowFormat.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnShowFormat.OnDisabledState.IconLeftImage = null;
            btnShowFormat.OnDisabledState.IconRightImage = null;
            btnShowFormat.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnShowFormat.onHoverState.BorderRadius = 30;
            btnShowFormat.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowFormat.onHoverState.BorderThickness = 2;
            btnShowFormat.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnShowFormat.onHoverState.ForeColor = Color.White;
            btnShowFormat.onHoverState.IconLeftImage = null;
            btnShowFormat.onHoverState.IconRightImage = null;
            btnShowFormat.OnIdleState.BorderColor = Color.DodgerBlue;
            btnShowFormat.OnIdleState.BorderRadius = 30;
            btnShowFormat.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowFormat.OnIdleState.BorderThickness = 2;
            btnShowFormat.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnShowFormat.OnIdleState.ForeColor = Color.White;
            btnShowFormat.OnIdleState.IconLeftImage = null;
            btnShowFormat.OnIdleState.IconRightImage = null;
            btnShowFormat.OnPressedState.BorderColor = Color.DodgerBlue;
            btnShowFormat.OnPressedState.BorderRadius = 30;
            btnShowFormat.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowFormat.OnPressedState.BorderThickness = 2;
            btnShowFormat.OnPressedState.FillColor = Color.Gold;
            btnShowFormat.OnPressedState.ForeColor = Color.White;
            btnShowFormat.OnPressedState.IconLeftImage = null;
            btnShowFormat.OnPressedState.IconRightImage = null;
            btnShowFormat.Size = new Size(155, 68);
            btnShowFormat.TabIndex = 0;
            btnShowFormat.TextAlign = ContentAlignment.MiddleCenter;
            btnShowFormat.TextAlignment = HorizontalAlignment.Center;
            btnShowFormat.TextMarginLeft = 0;
            btnShowFormat.TextPadding = new Padding(0);
            btnShowFormat.UseDefaultRadiusAndThickness = true;
            btnShowFormat.Click += btnShowFormat_Click;
            // 
            // btnInsertFormat
            // 
            btnInsertFormat.AllowAnimations = true;
            btnInsertFormat.AllowMouseEffects = true;
            btnInsertFormat.AllowToggling = false;
            btnInsertFormat.AnimationSpeed = 200;
            btnInsertFormat.AutoGenerateColors = false;
            btnInsertFormat.AutoRoundBorders = false;
            btnInsertFormat.AutoSizeLeftIcon = true;
            btnInsertFormat.AutoSizeRightIcon = true;
            btnInsertFormat.BackColor = Color.Transparent;
            btnInsertFormat.BackColor1 = Color.FromArgb(51, 122, 183);
            btnInsertFormat.BackgroundImage = (Image)resources.GetObject("btnInsertFormat.BackgroundImage");
            btnInsertFormat.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertFormat.ButtonText = "Thêm";
            btnInsertFormat.ButtonTextMarginLeft = 0;
            btnInsertFormat.ColorContrastOnClick = 45;
            btnInsertFormat.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            btnInsertFormat.CustomizableEdges = borderEdges3;
            btnInsertFormat.DialogResult = DialogResult.None;
            btnInsertFormat.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnInsertFormat.DisabledFillColor = Color.Empty;
            btnInsertFormat.DisabledForecolor = Color.Empty;
            btnInsertFormat.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnInsertFormat.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnInsertFormat.ForeColor = Color.White;
            btnInsertFormat.IconLeft = null;
            btnInsertFormat.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnInsertFormat.IconLeftCursor = Cursors.Default;
            btnInsertFormat.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnInsertFormat.IconMarginLeft = 11;
            btnInsertFormat.IconPadding = 10;
            btnInsertFormat.IconRight = null;
            btnInsertFormat.IconRightAlign = ContentAlignment.MiddleRight;
            btnInsertFormat.IconRightCursor = Cursors.Default;
            btnInsertFormat.IconRightPadding = new Padding(3, 3, 7, 3);
            btnInsertFormat.IconSize = 25;
            btnInsertFormat.IdleBorderColor = Color.Empty;
            btnInsertFormat.IdleBorderRadius = 0;
            btnInsertFormat.IdleBorderThickness = 0;
            btnInsertFormat.IdleFillColor = Color.Empty;
            btnInsertFormat.IdleIconLeftImage = null;
            btnInsertFormat.IdleIconRightImage = null;
            btnInsertFormat.IndicateFocus = false;
            btnInsertFormat.Location = new Point(287, 306);
            btnInsertFormat.Name = "btnInsertFormat";
            btnInsertFormat.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnInsertFormat.OnDisabledState.BorderRadius = 30;
            btnInsertFormat.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertFormat.OnDisabledState.BorderThickness = 2;
            btnInsertFormat.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnInsertFormat.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnInsertFormat.OnDisabledState.IconLeftImage = null;
            btnInsertFormat.OnDisabledState.IconRightImage = null;
            btnInsertFormat.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnInsertFormat.onHoverState.BorderRadius = 30;
            btnInsertFormat.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertFormat.onHoverState.BorderThickness = 2;
            btnInsertFormat.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnInsertFormat.onHoverState.ForeColor = Color.White;
            btnInsertFormat.onHoverState.IconLeftImage = null;
            btnInsertFormat.onHoverState.IconRightImage = null;
            btnInsertFormat.OnIdleState.BorderColor = Color.DodgerBlue;
            btnInsertFormat.OnIdleState.BorderRadius = 30;
            btnInsertFormat.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertFormat.OnIdleState.BorderThickness = 2;
            btnInsertFormat.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnInsertFormat.OnIdleState.ForeColor = Color.White;
            btnInsertFormat.OnIdleState.IconLeftImage = null;
            btnInsertFormat.OnIdleState.IconRightImage = null;
            btnInsertFormat.OnPressedState.BorderColor = Color.DodgerBlue;
            btnInsertFormat.OnPressedState.BorderRadius = 30;
            btnInsertFormat.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertFormat.OnPressedState.BorderThickness = 2;
            btnInsertFormat.OnPressedState.FillColor = Color.Gold;
            btnInsertFormat.OnPressedState.ForeColor = Color.White;
            btnInsertFormat.OnPressedState.IconLeftImage = null;
            btnInsertFormat.OnPressedState.IconRightImage = null;
            btnInsertFormat.Size = new Size(155, 68);
            btnInsertFormat.TabIndex = 1;
            btnInsertFormat.TextAlign = ContentAlignment.MiddleCenter;
            btnInsertFormat.TextAlignment = HorizontalAlignment.Center;
            btnInsertFormat.TextMarginLeft = 0;
            btnInsertFormat.TextPadding = new Padding(0);
            btnInsertFormat.UseDefaultRadiusAndThickness = true;
            btnInsertFormat.Click += btnInsertFormat_Click;
            // 
            // btnUpdateFormat
            // 
            btnUpdateFormat.AllowAnimations = true;
            btnUpdateFormat.AllowMouseEffects = true;
            btnUpdateFormat.AllowToggling = false;
            btnUpdateFormat.AnimationSpeed = 200;
            btnUpdateFormat.AutoGenerateColors = false;
            btnUpdateFormat.AutoRoundBorders = false;
            btnUpdateFormat.AutoSizeLeftIcon = true;
            btnUpdateFormat.AutoSizeRightIcon = true;
            btnUpdateFormat.BackColor = Color.Transparent;
            btnUpdateFormat.BackColor1 = Color.FromArgb(51, 122, 183);
            btnUpdateFormat.BackgroundImage = (Image)resources.GetObject("btnUpdateFormat.BackgroundImage");
            btnUpdateFormat.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateFormat.ButtonText = "Sửa";
            btnUpdateFormat.ButtonTextMarginLeft = 0;
            btnUpdateFormat.ColorContrastOnClick = 45;
            btnUpdateFormat.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            btnUpdateFormat.CustomizableEdges = borderEdges2;
            btnUpdateFormat.DialogResult = DialogResult.None;
            btnUpdateFormat.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnUpdateFormat.DisabledFillColor = Color.Empty;
            btnUpdateFormat.DisabledForecolor = Color.Empty;
            btnUpdateFormat.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnUpdateFormat.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnUpdateFormat.ForeColor = Color.White;
            btnUpdateFormat.IconLeft = null;
            btnUpdateFormat.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnUpdateFormat.IconLeftCursor = Cursors.Default;
            btnUpdateFormat.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnUpdateFormat.IconMarginLeft = 11;
            btnUpdateFormat.IconPadding = 10;
            btnUpdateFormat.IconRight = null;
            btnUpdateFormat.IconRightAlign = ContentAlignment.MiddleRight;
            btnUpdateFormat.IconRightCursor = Cursors.Default;
            btnUpdateFormat.IconRightPadding = new Padding(3, 3, 7, 3);
            btnUpdateFormat.IconSize = 25;
            btnUpdateFormat.IdleBorderColor = Color.Empty;
            btnUpdateFormat.IdleBorderRadius = 0;
            btnUpdateFormat.IdleBorderThickness = 0;
            btnUpdateFormat.IdleFillColor = Color.Empty;
            btnUpdateFormat.IdleIconLeftImage = null;
            btnUpdateFormat.IdleIconRightImage = null;
            btnUpdateFormat.IndicateFocus = false;
            btnUpdateFormat.Location = new Point(532, 306);
            btnUpdateFormat.Name = "btnUpdateFormat";
            btnUpdateFormat.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnUpdateFormat.OnDisabledState.BorderRadius = 30;
            btnUpdateFormat.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateFormat.OnDisabledState.BorderThickness = 2;
            btnUpdateFormat.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnUpdateFormat.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnUpdateFormat.OnDisabledState.IconLeftImage = null;
            btnUpdateFormat.OnDisabledState.IconRightImage = null;
            btnUpdateFormat.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnUpdateFormat.onHoverState.BorderRadius = 30;
            btnUpdateFormat.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateFormat.onHoverState.BorderThickness = 2;
            btnUpdateFormat.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnUpdateFormat.onHoverState.ForeColor = Color.White;
            btnUpdateFormat.onHoverState.IconLeftImage = null;
            btnUpdateFormat.onHoverState.IconRightImage = null;
            btnUpdateFormat.OnIdleState.BorderColor = Color.DodgerBlue;
            btnUpdateFormat.OnIdleState.BorderRadius = 30;
            btnUpdateFormat.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateFormat.OnIdleState.BorderThickness = 2;
            btnUpdateFormat.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnUpdateFormat.OnIdleState.ForeColor = Color.White;
            btnUpdateFormat.OnIdleState.IconLeftImage = null;
            btnUpdateFormat.OnIdleState.IconRightImage = null;
            btnUpdateFormat.OnPressedState.BorderColor = Color.DodgerBlue;
            btnUpdateFormat.OnPressedState.BorderRadius = 30;
            btnUpdateFormat.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateFormat.OnPressedState.BorderThickness = 2;
            btnUpdateFormat.OnPressedState.FillColor = Color.Gold;
            btnUpdateFormat.OnPressedState.ForeColor = Color.White;
            btnUpdateFormat.OnPressedState.IconLeftImage = null;
            btnUpdateFormat.OnPressedState.IconRightImage = null;
            btnUpdateFormat.Size = new Size(155, 68);
            btnUpdateFormat.TabIndex = 2;
            btnUpdateFormat.TextAlign = ContentAlignment.MiddleCenter;
            btnUpdateFormat.TextAlignment = HorizontalAlignment.Center;
            btnUpdateFormat.TextMarginLeft = 0;
            btnUpdateFormat.TextPadding = new Padding(0);
            btnUpdateFormat.UseDefaultRadiusAndThickness = true;
            btnUpdateFormat.Click += btnUpdateFormat_Click;
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btnExport.CustomizableEdges = borderEdges1;
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
            btnExport.Location = new Point(785, 306);
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
            btnExport.OnPressedState.BorderColor = Color.DodgerBlue;
            btnExport.OnPressedState.BorderRadius = 30;
            btnExport.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnExport.OnPressedState.BorderThickness = 2;
            btnExport.OnPressedState.FillColor = Color.Gold;
            btnExport.OnPressedState.ForeColor = Color.White;
            btnExport.OnPressedState.IconLeftImage = null;
            btnExport.OnPressedState.IconRightImage = null;
            btnExport.Size = new Size(155, 68);
            btnExport.TabIndex = 3;
            btnExport.TextAlign = ContentAlignment.MiddleCenter;
            btnExport.TextAlignment = HorizontalAlignment.Center;
            btnExport.TextMarginLeft = 0;
            btnExport.TextPadding = new Padding(0);
            btnExport.UseDefaultRadiusAndThickness = true;
            btnExport.Click += btnExport_Click;
            // 
            // DinhDangPhimUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DinhDangPhimUC";
            Size = new Size(1935, 998);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFormat).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }


		#endregion

		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteFormat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblFormatID;
        private System.Windows.Forms.TextBox txtFormatID;
        private System.Windows.Forms.DataGridView dtgvFormat;
        private Label label1;
        private TextBox txtTenDangPhim;
        private Label label2;
        private Label label3;
        private TextBox txtTenMh;
        private ComboBox cbMaMH;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnShowFormat;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExport;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdateFormat;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnInsertFormat;
    }

}