namespace FilmsManage.GUI.UserControls.Data
{
    partial class CinemaUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CinemaUC));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            panel2 = new Panel();
            panel6 = new Panel();
            cboCinemaScreenType = new ComboBox();
            lblScreenType = new Label();
            panel15 = new Panel();
            txtSeatsPerRow = new TextBox();
            lblSeatsPerRow = new Label();
            panel12 = new Panel();
            txtNumberOfRows = new TextBox();
            panel8 = new Panel();
            txtCinemaSeats = new TextBox();
            lblCinemaSeats = new Label();
            panel31 = new Panel();
            txtCinemaName = new TextBox();
            lblCinemaName = new Label();
            panel32 = new Panel();
            txtCinemaID = new TextBox();
            lblCinemaID = new Label();
            panel1 = new Panel();
            dtgvCinema = new DataGridView();
            panel33 = new Panel();
            btnExport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnShowCinema = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnUpdateCinema = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnInsertCinema = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel15.SuspendLayout();
            panel12.SuspendLayout();
            panel8.SuspendLayout();
            panel31.SuspendLayout();
            panel32.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCinema).BeginInit();
            panel33.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel15);
            panel2.Controls.Add(panel12);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel31);
            panel2.Controls.Add(panel32);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1259, 0);
            panel2.Margin = new Padding(4, 2, 4, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 648);
            panel2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(cboCinemaScreenType);
            panel6.Controls.Add(lblScreenType);
            panel6.Location = new Point(21, 199);
            panel6.Margin = new Padding(5, 6, 5, 6);
            panel6.Name = "panel6";
            panel6.Size = new Size(515, 85);
            panel6.TabIndex = 4;
            // 
            // cboCinemaScreenType
            // 
            cboCinemaScreenType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCinemaScreenType.FormattingEnabled = true;
            cboCinemaScreenType.Location = new Point(220, 18);
            cboCinemaScreenType.Margin = new Padding(4, 2, 4, 2);
            cboCinemaScreenType.Name = "cboCinemaScreenType";
            cboCinemaScreenType.Size = new Size(266, 33);
            cboCinemaScreenType.TabIndex = 1;
            // 
            // lblScreenType
            // 
            lblScreenType.AutoSize = true;
            lblScreenType.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblScreenType.Location = new Point(5, 18);
            lblScreenType.Margin = new Padding(5, 0, 5, 0);
            lblScreenType.Name = "lblScreenType";
            lblScreenType.Size = new Size(128, 29);
            lblScreenType.TabIndex = 0;
            lblScreenType.Text = "Màn hình:";
            // 
            // panel15
            // 
            panel15.Controls.Add(txtSeatsPerRow);
            panel15.Controls.Add(lblSeatsPerRow);
            panel15.Location = new Point(21, 395);
            panel15.Margin = new Padding(5, 6, 5, 6);
            panel15.Name = "panel15";
            panel15.Size = new Size(515, 85);
            panel15.TabIndex = 5;
            // 
            // txtSeatsPerRow
            // 
            txtSeatsPerRow.Location = new Point(220, 18);
            txtSeatsPerRow.Margin = new Padding(5, 6, 5, 6);
            txtSeatsPerRow.Name = "txtSeatsPerRow";
            txtSeatsPerRow.Size = new Size(266, 31);
            txtSeatsPerRow.TabIndex = 1;
            // 
            // lblSeatsPerRow
            // 
            lblSeatsPerRow.AutoSize = true;
            lblSeatsPerRow.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblSeatsPerRow.Location = new Point(5, 18);
            lblSeatsPerRow.Margin = new Padding(5, 0, 5, 0);
            lblSeatsPerRow.Name = "lblSeatsPerRow";
            lblSeatsPerRow.Size = new Size(182, 29);
            lblSeatsPerRow.TabIndex = 0;
            lblSeatsPerRow.Text = "Ghế mỗi hàng:";
            // 
            // panel12
            // 
            panel12.Controls.Add(txtNumberOfRows);
            panel12.Location = new Point(21, 492);
            panel12.Margin = new Padding(5, 6, 5, 6);
            panel12.Name = "panel12";
            panel12.Size = new Size(515, 85);
            panel12.TabIndex = 6;
            // 
            // txtNumberOfRows
            // 
            txtNumberOfRows.Location = new Point(220, 22);
            txtNumberOfRows.Margin = new Padding(5, 6, 5, 6);
            txtNumberOfRows.Name = "txtNumberOfRows";
            txtNumberOfRows.Size = new Size(266, 31);
            txtNumberOfRows.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(txtCinemaSeats);
            panel8.Controls.Add(lblCinemaSeats);
            panel8.Location = new Point(21, 298);
            panel8.Margin = new Padding(5, 6, 5, 6);
            panel8.Name = "panel8";
            panel8.Size = new Size(515, 85);
            panel8.TabIndex = 8;
            // 
            // txtCinemaSeats
            // 
            txtCinemaSeats.Location = new Point(220, 22);
            txtCinemaSeats.Margin = new Padding(5, 6, 5, 6);
            txtCinemaSeats.Name = "txtCinemaSeats";
            txtCinemaSeats.Size = new Size(266, 31);
            txtCinemaSeats.TabIndex = 1;
            // 
            // lblCinemaSeats
            // 
            lblCinemaSeats.AutoSize = true;
            lblCinemaSeats.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblCinemaSeats.Location = new Point(5, 18);
            lblCinemaSeats.Margin = new Padding(5, 0, 5, 0);
            lblCinemaSeats.Name = "lblCinemaSeats";
            lblCinemaSeats.Size = new Size(160, 29);
            lblCinemaSeats.TabIndex = 0;
            lblCinemaSeats.Text = "Số chỗ ngồi:";
            // 
            // panel31
            // 
            panel31.Controls.Add(txtCinemaName);
            panel31.Controls.Add(lblCinemaName);
            panel31.Location = new Point(21, 101);
            panel31.Margin = new Padding(5, 6, 5, 6);
            panel31.Name = "panel31";
            panel31.Size = new Size(515, 85);
            panel31.TabIndex = 9;
            // 
            // txtCinemaName
            // 
            txtCinemaName.Location = new Point(220, 22);
            txtCinemaName.Margin = new Padding(5, 6, 5, 6);
            txtCinemaName.Name = "txtCinemaName";
            txtCinemaName.Size = new Size(266, 31);
            txtCinemaName.TabIndex = 1;
            // 
            // lblCinemaName
            // 
            lblCinemaName.AutoSize = true;
            lblCinemaName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblCinemaName.Location = new Point(5, 18);
            lblCinemaName.Margin = new Padding(5, 0, 5, 0);
            lblCinemaName.Name = "lblCinemaName";
            lblCinemaName.Size = new Size(145, 29);
            lblCinemaName.TabIndex = 0;
            lblCinemaName.Text = "Tên phòng:";
            // 
            // panel32
            // 
            panel32.Controls.Add(txtCinemaID);
            panel32.Controls.Add(lblCinemaID);
            panel32.Location = new Point(21, 6);
            panel32.Margin = new Padding(5, 6, 5, 6);
            panel32.Name = "panel32";
            panel32.Size = new Size(515, 85);
            panel32.TabIndex = 3;
            // 
            // txtCinemaID
            // 
            txtCinemaID.Location = new Point(220, 25);
            txtCinemaID.Margin = new Padding(5, 6, 5, 6);
            txtCinemaID.Name = "txtCinemaID";
            txtCinemaID.Size = new Size(269, 31);
            txtCinemaID.TabIndex = 1;
            // 
            // lblCinemaID
            // 
            lblCinemaID.AutoSize = true;
            lblCinemaID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblCinemaID.Location = new Point(5, 22);
            lblCinemaID.Margin = new Padding(5, 0, 5, 0);
            lblCinemaID.Name = "lblCinemaID";
            lblCinemaID.Size = new Size(136, 29);
            lblCinemaID.TabIndex = 0;
            lblCinemaID.Text = "Mã phòng:";
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvCinema);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 350);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1814, 648); 
            panel1.TabIndex = 11;
            // 
            // dtgvCinema
            // 
            dtgvCinema.AllowUserToAddRows = false;
            dtgvCinema.AllowUserToDeleteRows = false;
            dtgvCinema.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCinema.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCinema.Dock = DockStyle.Fill;
            dtgvCinema.Location = new Point(0, 0);
            dtgvCinema.Margin = new Padding(5, 6, 5, 6);
            dtgvCinema.Name = "dtgvCinema";
            dtgvCinema.ReadOnly = true;
            dtgvCinema.RowHeadersWidth = 51;
            dtgvCinema.Size = new Size(1259, 648);
            dtgvCinema.TabIndex = 1;
            // 
            // panel33
            // 
            panel33.Controls.Add(btnExport);
            panel33.Controls.Add(btnShowCinema);
            panel33.Controls.Add(btnUpdateCinema);
            panel33.Controls.Add(btnInsertCinema);
            panel33.Dock = DockStyle.Top;
            panel33.Location = new Point(0, 0);
            panel33.Margin = new Padding(5, 6, 5, 6);
            panel33.Name = "panel33";
            panel33.Size = new Size(1814, 350);
            panel33.TabIndex = 10;
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
            btnExport.Location = new Point(651, 223);
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
            btnExport.Size = new Size(135, 85);
            btnExport.TabIndex = 8;
            btnExport.TextAlign = ContentAlignment.MiddleCenter;
            btnExport.TextAlignment = HorizontalAlignment.Center;
            btnExport.TextMarginLeft = 0;
            btnExport.TextPadding = new Padding(0);
            btnExport.UseDefaultRadiusAndThickness = true;
            // 
            // btnShowCinema
            // 
            btnShowCinema.AllowAnimations = true;
            btnShowCinema.AllowMouseEffects = true;
            btnShowCinema.AllowToggling = false;
            btnShowCinema.AnimationSpeed = 200;
            btnShowCinema.AutoGenerateColors = false;
            btnShowCinema.AutoRoundBorders = false;
            btnShowCinema.AutoSizeLeftIcon = true;
            btnShowCinema.AutoSizeRightIcon = true;
            btnShowCinema.BackColor = Color.Transparent;
            btnShowCinema.BackColor1 = Color.FromArgb(51, 122, 183);
            btnShowCinema.BackgroundImage = (Image)resources.GetObject("btnShowCinema.BackgroundImage");
            btnShowCinema.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowCinema.ButtonText = "Xem";
            btnShowCinema.ButtonTextMarginLeft = 0;
            btnShowCinema.ColorContrastOnClick = 45;
            btnShowCinema.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            btnShowCinema.CustomizableEdges = borderEdges2;
            btnShowCinema.DialogResult = DialogResult.None;
            btnShowCinema.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnShowCinema.DisabledFillColor = Color.Empty;
            btnShowCinema.DisabledForecolor = Color.Empty;
            btnShowCinema.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnShowCinema.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnShowCinema.ForeColor = Color.White;
            btnShowCinema.IconLeft = null;
            btnShowCinema.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnShowCinema.IconLeftCursor = Cursors.Default;
            btnShowCinema.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnShowCinema.IconMarginLeft = 11;
            btnShowCinema.IconPadding = 10;
            btnShowCinema.IconRight = null;
            btnShowCinema.IconRightAlign = ContentAlignment.MiddleRight;
            btnShowCinema.IconRightCursor = Cursors.Default;
            btnShowCinema.IconRightPadding = new Padding(3, 3, 7, 3);
            btnShowCinema.IconSize = 25;
            btnShowCinema.IdleBorderColor = Color.Empty;
            btnShowCinema.IdleBorderRadius = 0;
            btnShowCinema.IdleBorderThickness = 0;
            btnShowCinema.IdleFillColor = Color.Empty;
            btnShowCinema.IdleIconLeftImage = null;
            btnShowCinema.IdleIconRightImage = null;
            btnShowCinema.IndicateFocus = false;
            btnShowCinema.Location = new Point(440, 223);
            btnShowCinema.Name = "btnShowCinema";
            btnShowCinema.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnShowCinema.OnDisabledState.BorderRadius = 30;
            btnShowCinema.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowCinema.OnDisabledState.BorderThickness = 2;
            btnShowCinema.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnShowCinema.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnShowCinema.OnDisabledState.IconLeftImage = null;
            btnShowCinema.OnDisabledState.IconRightImage = null;
            btnShowCinema.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnShowCinema.onHoverState.BorderRadius = 30;
            btnShowCinema.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowCinema.onHoverState.BorderThickness = 2;
            btnShowCinema.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnShowCinema.onHoverState.ForeColor = Color.White;
            btnShowCinema.onHoverState.IconLeftImage = null;
            btnShowCinema.onHoverState.IconRightImage = null;
            btnShowCinema.OnIdleState.BorderColor = Color.DodgerBlue;
            btnShowCinema.OnIdleState.BorderRadius = 30;
            btnShowCinema.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowCinema.OnIdleState.BorderThickness = 2;
            btnShowCinema.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnShowCinema.OnIdleState.ForeColor = Color.White;
            btnShowCinema.OnIdleState.IconLeftImage = null;
            btnShowCinema.OnIdleState.IconRightImage = null;
            btnShowCinema.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnShowCinema.OnPressedState.BorderRadius = 30;
            btnShowCinema.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowCinema.OnPressedState.BorderThickness = 2;
            btnShowCinema.OnPressedState.FillColor = Color.Gold;
            btnShowCinema.OnPressedState.ForeColor = Color.White;
            btnShowCinema.OnPressedState.IconLeftImage = null;
            btnShowCinema.OnPressedState.IconRightImage = null;
            btnShowCinema.Size = new Size(137, 85);
            btnShowCinema.TabIndex = 7;
            btnShowCinema.TextAlign = ContentAlignment.MiddleCenter;
            btnShowCinema.TextAlignment = HorizontalAlignment.Center;
            btnShowCinema.TextMarginLeft = 0;
            btnShowCinema.TextPadding = new Padding(0);
            btnShowCinema.UseDefaultRadiusAndThickness = true;
            // 
            // btnUpdateCinema
            // 
            btnUpdateCinema.AllowAnimations = true;
            btnUpdateCinema.AllowMouseEffects = true;
            btnUpdateCinema.AllowToggling = false;
            btnUpdateCinema.AnimationSpeed = 200;
            btnUpdateCinema.AutoGenerateColors = false;
            btnUpdateCinema.AutoRoundBorders = false;
            btnUpdateCinema.AutoSizeLeftIcon = true;
            btnUpdateCinema.AutoSizeRightIcon = true;
            btnUpdateCinema.BackColor = Color.Transparent;
            btnUpdateCinema.BackColor1 = Color.FromArgb(51, 122, 183);
            btnUpdateCinema.BackgroundImage = (Image)resources.GetObject("btnUpdateCinema.BackgroundImage");
            btnUpdateCinema.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateCinema.ButtonText = "Sửa";
            btnUpdateCinema.ButtonTextMarginLeft = 0;
            btnUpdateCinema.ColorContrastOnClick = 45;
            btnUpdateCinema.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            btnUpdateCinema.CustomizableEdges = borderEdges3;
            btnUpdateCinema.DialogResult = DialogResult.None;
            btnUpdateCinema.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnUpdateCinema.DisabledFillColor = Color.Empty;
            btnUpdateCinema.DisabledForecolor = Color.Empty;
            btnUpdateCinema.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnUpdateCinema.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnUpdateCinema.ForeColor = Color.White;
            btnUpdateCinema.IconLeft = null;
            btnUpdateCinema.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnUpdateCinema.IconLeftCursor = Cursors.Default;
            btnUpdateCinema.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnUpdateCinema.IconMarginLeft = 11;
            btnUpdateCinema.IconPadding = 10;
            btnUpdateCinema.IconRight = null;
            btnUpdateCinema.IconRightAlign = ContentAlignment.MiddleRight;
            btnUpdateCinema.IconRightCursor = Cursors.Default;
            btnUpdateCinema.IconRightPadding = new Padding(3, 3, 7, 3);
            btnUpdateCinema.IconSize = 25;
            btnUpdateCinema.IdleBorderColor = Color.Empty;
            btnUpdateCinema.IdleBorderRadius = 0;
            btnUpdateCinema.IdleBorderThickness = 0;
            btnUpdateCinema.IdleFillColor = Color.Empty;
            btnUpdateCinema.IdleIconLeftImage = null;
            btnUpdateCinema.IdleIconRightImage = null;
            btnUpdateCinema.IndicateFocus = false;
            btnUpdateCinema.Location = new Point(220, 223);
            btnUpdateCinema.Name = "btnUpdateCinema";
            btnUpdateCinema.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnUpdateCinema.OnDisabledState.BorderRadius = 30;
            btnUpdateCinema.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateCinema.OnDisabledState.BorderThickness = 2;
            btnUpdateCinema.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnUpdateCinema.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnUpdateCinema.OnDisabledState.IconLeftImage = null;
            btnUpdateCinema.OnDisabledState.IconRightImage = null;
            btnUpdateCinema.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnUpdateCinema.onHoverState.BorderRadius = 30;
            btnUpdateCinema.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateCinema.onHoverState.BorderThickness = 2;
            btnUpdateCinema.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnUpdateCinema.onHoverState.ForeColor = Color.White;
            btnUpdateCinema.onHoverState.IconLeftImage = null;
            btnUpdateCinema.onHoverState.IconRightImage = null;
            btnUpdateCinema.OnIdleState.BorderColor = Color.DodgerBlue;
            btnUpdateCinema.OnIdleState.BorderRadius = 30;
            btnUpdateCinema.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateCinema.OnIdleState.BorderThickness = 2;
            btnUpdateCinema.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnUpdateCinema.OnIdleState.ForeColor = Color.White;
            btnUpdateCinema.OnIdleState.IconLeftImage = null;
            btnUpdateCinema.OnIdleState.IconRightImage = null;
            btnUpdateCinema.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnUpdateCinema.OnPressedState.BorderRadius = 30;
            btnUpdateCinema.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateCinema.OnPressedState.BorderThickness = 2;
            btnUpdateCinema.OnPressedState.FillColor = Color.Gold;
            btnUpdateCinema.OnPressedState.ForeColor = Color.White;
            btnUpdateCinema.OnPressedState.IconLeftImage = null;
            btnUpdateCinema.OnPressedState.IconRightImage = null;
            btnUpdateCinema.Size = new Size(138, 85);
            btnUpdateCinema.TabIndex = 6;
            btnUpdateCinema.TextAlign = ContentAlignment.MiddleCenter;
            btnUpdateCinema.TextAlignment = HorizontalAlignment.Center;
            btnUpdateCinema.TextMarginLeft = 0;
            btnUpdateCinema.TextPadding = new Padding(0);
            btnUpdateCinema.UseDefaultRadiusAndThickness = true;
            btnUpdateCinema.Click += btnUpdateCinema_Click_1;
            // 
            // btnInsertCinema
            // 
            btnInsertCinema.AllowAnimations = true;
            btnInsertCinema.AllowMouseEffects = true;
            btnInsertCinema.AllowToggling = false;
            btnInsertCinema.AnimationSpeed = 200;
            btnInsertCinema.AutoGenerateColors = false;
            btnInsertCinema.AutoRoundBorders = false;
            btnInsertCinema.AutoSizeLeftIcon = true;
            btnInsertCinema.AutoSizeRightIcon = true;
            btnInsertCinema.BackColor = Color.Transparent;
            btnInsertCinema.BackColor1 = Color.FromArgb(51, 122, 183);
            btnInsertCinema.BackgroundImage = (Image)resources.GetObject("btnInsertCinema.BackgroundImage");
            btnInsertCinema.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertCinema.ButtonText = "Thêm";
            btnInsertCinema.ButtonTextMarginLeft = 0;
            btnInsertCinema.ColorContrastOnClick = 45;
            btnInsertCinema.ColorContrastOnHover = 45;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            btnInsertCinema.CustomizableEdges = borderEdges4;
            btnInsertCinema.DialogResult = DialogResult.None;
            btnInsertCinema.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnInsertCinema.DisabledFillColor = Color.Empty;
            btnInsertCinema.DisabledForecolor = Color.Empty;
            btnInsertCinema.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnInsertCinema.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnInsertCinema.ForeColor = Color.White;
            btnInsertCinema.IconLeft = null;
            btnInsertCinema.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnInsertCinema.IconLeftCursor = Cursors.Default;
            btnInsertCinema.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnInsertCinema.IconMarginLeft = 11;
            btnInsertCinema.IconPadding = 10;
            btnInsertCinema.IconRight = null;
            btnInsertCinema.IconRightAlign = ContentAlignment.MiddleRight;
            btnInsertCinema.IconRightCursor = Cursors.Default;
            btnInsertCinema.IconRightPadding = new Padding(3, 3, 7, 3);
            btnInsertCinema.IconSize = 25;
            btnInsertCinema.IdleBorderColor = Color.Empty;
            btnInsertCinema.IdleBorderRadius = 0;
            btnInsertCinema.IdleBorderThickness = 0;
            btnInsertCinema.IdleFillColor = Color.Empty;
            btnInsertCinema.IdleIconLeftImage = null;
            btnInsertCinema.IdleIconRightImage = null;
            btnInsertCinema.IndicateFocus = false;
            btnInsertCinema.Location = new Point(20, 223);
            btnInsertCinema.Name = "btnInsertCinema";
            btnInsertCinema.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnInsertCinema.OnDisabledState.BorderRadius = 30;
            btnInsertCinema.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertCinema.OnDisabledState.BorderThickness = 2;
            btnInsertCinema.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnInsertCinema.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnInsertCinema.OnDisabledState.IconLeftImage = null;
            btnInsertCinema.OnDisabledState.IconRightImage = null;
            btnInsertCinema.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnInsertCinema.onHoverState.BorderRadius = 30;
            btnInsertCinema.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertCinema.onHoverState.BorderThickness = 2;
            btnInsertCinema.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnInsertCinema.onHoverState.ForeColor = Color.White;
            btnInsertCinema.onHoverState.IconLeftImage = null;
            btnInsertCinema.onHoverState.IconRightImage = null;
            btnInsertCinema.OnIdleState.BorderColor = Color.DodgerBlue;
            btnInsertCinema.OnIdleState.BorderRadius = 30;
            btnInsertCinema.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertCinema.OnIdleState.BorderThickness = 2;
            btnInsertCinema.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnInsertCinema.OnIdleState.ForeColor = Color.White;
            btnInsertCinema.OnIdleState.IconLeftImage = null;
            btnInsertCinema.OnIdleState.IconRightImage = null;
            btnInsertCinema.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnInsertCinema.OnPressedState.BorderRadius = 30;
            btnInsertCinema.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertCinema.OnPressedState.BorderThickness = 2;
            btnInsertCinema.OnPressedState.FillColor = Color.Gold;
            btnInsertCinema.OnPressedState.ForeColor = Color.White;
            btnInsertCinema.OnPressedState.IconLeftImage = null;
            btnInsertCinema.OnPressedState.IconRightImage = null;
            btnInsertCinema.Size = new Size(141, 85);
            btnInsertCinema.TabIndex = 5;
            btnInsertCinema.TextAlign = ContentAlignment.MiddleCenter;
            btnInsertCinema.TextAlignment = HorizontalAlignment.Center;
            btnInsertCinema.TextMarginLeft = 0;
            btnInsertCinema.TextPadding = new Padding(0);
            btnInsertCinema.UseDefaultRadiusAndThickness = true;
            btnInsertCinema.Click += btnInsertCinema_Click_1;
            // 
            // CinemaUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel33);
            Margin = new Padding(4, 2, 4, 2);
            Name = "CinemaUC";
            Size = new Size(1814, 998);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel31.ResumeLayout(false);
            panel31.PerformLayout();
            panel32.ResumeLayout(false);
            panel32.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCinema).EndInit();
            panel33.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Panel panel6;
        private ComboBox cboCinemaScreenType;
        private Label lblScreenType;
        private Panel panel15;
        private TextBox txtSeatsPerRow;
        private Label lblSeatsPerRow;
        private Panel panel12;
        private TextBox txtNumberOfRows;
        private Panel panel8;
        private TextBox txtCinemaSeats;
        private Label lblCinemaSeats;
        private Panel panel31;
        private TextBox txtCinemaName;
        private Label lblCinemaName;
        private Panel panel32;
        private TextBox txtCinemaID;
        private Label lblCinemaID;
        private DataGridView dtgvCinema;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdateCinema;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnInsertCinema;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExport;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnShowCinema;
    }
}