namespace FilmsManage.GUI.UserControls.Data
{
    partial class KieuManHinhUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KieuManHinhUC));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            panel1 = new Panel();
            btnExport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnShowScreenType = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnDeleteScreenType = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnUpdateScreenType = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnInsertScreenType = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            panel2 = new Panel();
            panel4 = new Panel();
            panel20 = new Panel();
            txtScreenTypeName = new TextBox();
            lblScreenTypeName = new Label();
            panel21 = new Panel();
            txtScreenTypeID = new TextBox();
            lblScreenTypeID = new Label();
            panel3 = new Panel();
            dtgvScreenType = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel20.SuspendLayout();
            panel21.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvScreenType).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(btnShowScreenType);
            panel1.Controls.Add(btnDeleteScreenType);
            panel1.Controls.Add(btnUpdateScreenType);
            panel1.Controls.Add(btnInsertScreenType);
            panel1.Dock = DockStyle.Top;
            panel1.ImeMode = ImeMode.Disable;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 339);
            panel1.TabIndex = 2;
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
            btnExport.Location = new Point(800, 238);
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
            btnExport.Size = new Size(174, 88);
            btnExport.TabIndex = 13;
            btnExport.TextAlign = ContentAlignment.MiddleCenter;
            btnExport.TextAlignment = HorizontalAlignment.Center;
            btnExport.TextMarginLeft = 0;
            btnExport.TextPadding = new Padding(0);
            btnExport.UseDefaultRadiusAndThickness = true;
            btnExport.Click += btnExport_Click_1;
            // 
            // btnShowScreenType
            // 
            btnShowScreenType.AllowAnimations = true;
            btnShowScreenType.AllowMouseEffects = true;
            btnShowScreenType.AllowToggling = false;
            btnShowScreenType.AnimationSpeed = 200;
            btnShowScreenType.AutoGenerateColors = false;
            btnShowScreenType.AutoRoundBorders = false;
            btnShowScreenType.AutoSizeLeftIcon = true;
            btnShowScreenType.AutoSizeRightIcon = true;
            btnShowScreenType.BackColor = Color.Transparent;
            btnShowScreenType.BackColor1 = Color.FromArgb(51, 122, 183);
            btnShowScreenType.BackgroundImage = (Image)resources.GetObject("btnShowScreenType.BackgroundImage");
            btnShowScreenType.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowScreenType.ButtonText = "Xem";
            btnShowScreenType.ButtonTextMarginLeft = 0;
            btnShowScreenType.ColorContrastOnClick = 45;
            btnShowScreenType.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            btnShowScreenType.CustomizableEdges = borderEdges2;
            btnShowScreenType.DialogResult = DialogResult.None;
            btnShowScreenType.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnShowScreenType.DisabledFillColor = Color.Empty;
            btnShowScreenType.DisabledForecolor = Color.Empty;
            btnShowScreenType.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnShowScreenType.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnShowScreenType.ForeColor = Color.White;
            btnShowScreenType.IconLeft = null;
            btnShowScreenType.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnShowScreenType.IconLeftCursor = Cursors.Default;
            btnShowScreenType.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnShowScreenType.IconMarginLeft = 11;
            btnShowScreenType.IconPadding = 10;
            btnShowScreenType.IconRight = null;
            btnShowScreenType.IconRightAlign = ContentAlignment.MiddleRight;
            btnShowScreenType.IconRightCursor = Cursors.Default;
            btnShowScreenType.IconRightPadding = new Padding(3, 3, 7, 3);
            btnShowScreenType.IconSize = 25;
            btnShowScreenType.IdleBorderColor = Color.Empty;
            btnShowScreenType.IdleBorderRadius = 0;
            btnShowScreenType.IdleBorderThickness = 0;
            btnShowScreenType.IdleFillColor = Color.Empty;
            btnShowScreenType.IdleIconLeftImage = null;
            btnShowScreenType.IdleIconRightImage = null;
            btnShowScreenType.IndicateFocus = false;
            btnShowScreenType.Location = new Point(596, 238);
            btnShowScreenType.Name = "btnShowScreenType";
            btnShowScreenType.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnShowScreenType.OnDisabledState.BorderRadius = 30;
            btnShowScreenType.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowScreenType.OnDisabledState.BorderThickness = 2;
            btnShowScreenType.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnShowScreenType.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnShowScreenType.OnDisabledState.IconLeftImage = null;
            btnShowScreenType.OnDisabledState.IconRightImage = null;
            btnShowScreenType.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnShowScreenType.onHoverState.BorderRadius = 30;
            btnShowScreenType.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowScreenType.onHoverState.BorderThickness = 2;
            btnShowScreenType.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnShowScreenType.onHoverState.ForeColor = Color.White;
            btnShowScreenType.onHoverState.IconLeftImage = null;
            btnShowScreenType.onHoverState.IconRightImage = null;
            btnShowScreenType.OnIdleState.BorderColor = Color.DodgerBlue;
            btnShowScreenType.OnIdleState.BorderRadius = 30;
            btnShowScreenType.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowScreenType.OnIdleState.BorderThickness = 2;
            btnShowScreenType.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnShowScreenType.OnIdleState.ForeColor = Color.White;
            btnShowScreenType.OnIdleState.IconLeftImage = null;
            btnShowScreenType.OnIdleState.IconRightImage = null;
            btnShowScreenType.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnShowScreenType.OnPressedState.BorderRadius = 30;
            btnShowScreenType.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowScreenType.OnPressedState.BorderThickness = 2;
            btnShowScreenType.OnPressedState.FillColor = Color.Gold;
            btnShowScreenType.OnPressedState.ForeColor = Color.White;
            btnShowScreenType.OnPressedState.IconLeftImage = null;
            btnShowScreenType.OnPressedState.IconRightImage = null;
            btnShowScreenType.Size = new Size(133, 88);
            btnShowScreenType.TabIndex = 12;
            btnShowScreenType.TextAlign = ContentAlignment.MiddleCenter;
            btnShowScreenType.TextAlignment = HorizontalAlignment.Center;
            btnShowScreenType.TextMarginLeft = 0;
            btnShowScreenType.TextPadding = new Padding(0);
            btnShowScreenType.UseDefaultRadiusAndThickness = true;
            // 
            // btnDeleteScreenType
            // 
            btnDeleteScreenType.AllowAnimations = true;
            btnDeleteScreenType.AllowMouseEffects = true;
            btnDeleteScreenType.AllowToggling = false;
            btnDeleteScreenType.AnimationSpeed = 200;
            btnDeleteScreenType.AutoGenerateColors = false;
            btnDeleteScreenType.AutoRoundBorders = false;
            btnDeleteScreenType.AutoSizeLeftIcon = true;
            btnDeleteScreenType.AutoSizeRightIcon = true;
            btnDeleteScreenType.BackColor = Color.Transparent;
            btnDeleteScreenType.BackColor1 = Color.FromArgb(51, 122, 183);
            btnDeleteScreenType.BackgroundImage = (Image)resources.GetObject("btnDeleteScreenType.BackgroundImage");
            btnDeleteScreenType.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteScreenType.ButtonText = "Xóa";
            btnDeleteScreenType.ButtonTextMarginLeft = 0;
            btnDeleteScreenType.ColorContrastOnClick = 45;
            btnDeleteScreenType.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            btnDeleteScreenType.CustomizableEdges = borderEdges3;
            btnDeleteScreenType.DialogResult = DialogResult.None;
            btnDeleteScreenType.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnDeleteScreenType.DisabledFillColor = Color.Empty;
            btnDeleteScreenType.DisabledForecolor = Color.Empty;
            btnDeleteScreenType.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnDeleteScreenType.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnDeleteScreenType.ForeColor = Color.White;
            btnDeleteScreenType.IconLeft = null;
            btnDeleteScreenType.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnDeleteScreenType.IconLeftCursor = Cursors.Default;
            btnDeleteScreenType.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnDeleteScreenType.IconMarginLeft = 11;
            btnDeleteScreenType.IconPadding = 10;
            btnDeleteScreenType.IconRight = null;
            btnDeleteScreenType.IconRightAlign = ContentAlignment.MiddleRight;
            btnDeleteScreenType.IconRightCursor = Cursors.Default;
            btnDeleteScreenType.IconRightPadding = new Padding(3, 3, 7, 3);
            btnDeleteScreenType.IconSize = 25;
            btnDeleteScreenType.IdleBorderColor = Color.Empty;
            btnDeleteScreenType.IdleBorderRadius = 0;
            btnDeleteScreenType.IdleBorderThickness = 0;
            btnDeleteScreenType.IdleFillColor = Color.Empty;
            btnDeleteScreenType.IdleIconLeftImage = null;
            btnDeleteScreenType.IdleIconRightImage = null;
            btnDeleteScreenType.IndicateFocus = false;
            btnDeleteScreenType.Location = new Point(403, 238);
            btnDeleteScreenType.Name = "btnDeleteScreenType";
            btnDeleteScreenType.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnDeleteScreenType.OnDisabledState.BorderRadius = 30;
            btnDeleteScreenType.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteScreenType.OnDisabledState.BorderThickness = 2;
            btnDeleteScreenType.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnDeleteScreenType.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnDeleteScreenType.OnDisabledState.IconLeftImage = null;
            btnDeleteScreenType.OnDisabledState.IconRightImage = null;
            btnDeleteScreenType.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnDeleteScreenType.onHoverState.BorderRadius = 30;
            btnDeleteScreenType.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteScreenType.onHoverState.BorderThickness = 2;
            btnDeleteScreenType.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnDeleteScreenType.onHoverState.ForeColor = Color.White;
            btnDeleteScreenType.onHoverState.IconLeftImage = null;
            btnDeleteScreenType.onHoverState.IconRightImage = null;
            btnDeleteScreenType.OnIdleState.BorderColor = Color.DodgerBlue;
            btnDeleteScreenType.OnIdleState.BorderRadius = 30;
            btnDeleteScreenType.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteScreenType.OnIdleState.BorderThickness = 2;
            btnDeleteScreenType.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnDeleteScreenType.OnIdleState.ForeColor = Color.White;
            btnDeleteScreenType.OnIdleState.IconLeftImage = null;
            btnDeleteScreenType.OnIdleState.IconRightImage = null;
            btnDeleteScreenType.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnDeleteScreenType.OnPressedState.BorderRadius = 30;
            btnDeleteScreenType.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteScreenType.OnPressedState.BorderThickness = 2;
            btnDeleteScreenType.OnPressedState.FillColor = Color.Gold;
            btnDeleteScreenType.OnPressedState.ForeColor = Color.White;
            btnDeleteScreenType.OnPressedState.IconLeftImage = null;
            btnDeleteScreenType.OnPressedState.IconRightImage = null;
            btnDeleteScreenType.Size = new Size(142, 88);
            btnDeleteScreenType.TabIndex = 11;
            btnDeleteScreenType.TextAlign = ContentAlignment.MiddleCenter;
            btnDeleteScreenType.TextAlignment = HorizontalAlignment.Center;
            btnDeleteScreenType.TextMarginLeft = 0;
            btnDeleteScreenType.TextPadding = new Padding(0);
            btnDeleteScreenType.UseDefaultRadiusAndThickness = true;
            btnDeleteScreenType.Click += btnDeleteScreenType_Click_1;
            // 
            // btnUpdateScreenType
            // 
            btnUpdateScreenType.AllowAnimations = true;
            btnUpdateScreenType.AllowMouseEffects = true;
            btnUpdateScreenType.AllowToggling = false;
            btnUpdateScreenType.AnimationSpeed = 200;
            btnUpdateScreenType.AutoGenerateColors = false;
            btnUpdateScreenType.AutoRoundBorders = false;
            btnUpdateScreenType.AutoSizeLeftIcon = true;
            btnUpdateScreenType.AutoSizeRightIcon = true;
            btnUpdateScreenType.BackColor = Color.Transparent;
            btnUpdateScreenType.BackColor1 = Color.FromArgb(51, 122, 183);
            btnUpdateScreenType.BackgroundImage = (Image)resources.GetObject("btnUpdateScreenType.BackgroundImage");
            btnUpdateScreenType.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateScreenType.ButtonText = "Sửa";
            btnUpdateScreenType.ButtonTextMarginLeft = 0;
            btnUpdateScreenType.ColorContrastOnClick = 45;
            btnUpdateScreenType.ColorContrastOnHover = 45;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            btnUpdateScreenType.CustomizableEdges = borderEdges4;
            btnUpdateScreenType.DialogResult = DialogResult.None;
            btnUpdateScreenType.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnUpdateScreenType.DisabledFillColor = Color.Empty;
            btnUpdateScreenType.DisabledForecolor = Color.Empty;
            btnUpdateScreenType.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnUpdateScreenType.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnUpdateScreenType.ForeColor = Color.White;
            btnUpdateScreenType.IconLeft = null;
            btnUpdateScreenType.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnUpdateScreenType.IconLeftCursor = Cursors.Default;
            btnUpdateScreenType.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnUpdateScreenType.IconMarginLeft = 11;
            btnUpdateScreenType.IconPadding = 10;
            btnUpdateScreenType.IconRight = null;
            btnUpdateScreenType.IconRightAlign = ContentAlignment.MiddleRight;
            btnUpdateScreenType.IconRightCursor = Cursors.Default;
            btnUpdateScreenType.IconRightPadding = new Padding(3, 3, 7, 3);
            btnUpdateScreenType.IconSize = 25;
            btnUpdateScreenType.IdleBorderColor = Color.Empty;
            btnUpdateScreenType.IdleBorderRadius = 0;
            btnUpdateScreenType.IdleBorderThickness = 0;
            btnUpdateScreenType.IdleFillColor = Color.Empty;
            btnUpdateScreenType.IdleIconLeftImage = null;
            btnUpdateScreenType.IdleIconRightImage = null;
            btnUpdateScreenType.IndicateFocus = false;
            btnUpdateScreenType.Location = new Point(207, 238);
            btnUpdateScreenType.Name = "btnUpdateScreenType";
            btnUpdateScreenType.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnUpdateScreenType.OnDisabledState.BorderRadius = 30;
            btnUpdateScreenType.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateScreenType.OnDisabledState.BorderThickness = 2;
            btnUpdateScreenType.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnUpdateScreenType.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnUpdateScreenType.OnDisabledState.IconLeftImage = null;
            btnUpdateScreenType.OnDisabledState.IconRightImage = null;
            btnUpdateScreenType.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnUpdateScreenType.onHoverState.BorderRadius = 30;
            btnUpdateScreenType.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateScreenType.onHoverState.BorderThickness = 2;
            btnUpdateScreenType.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnUpdateScreenType.onHoverState.ForeColor = Color.White;
            btnUpdateScreenType.onHoverState.IconLeftImage = null;
            btnUpdateScreenType.onHoverState.IconRightImage = null;
            btnUpdateScreenType.OnIdleState.BorderColor = Color.DodgerBlue;
            btnUpdateScreenType.OnIdleState.BorderRadius = 30;
            btnUpdateScreenType.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateScreenType.OnIdleState.BorderThickness = 2;
            btnUpdateScreenType.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnUpdateScreenType.OnIdleState.ForeColor = Color.White;
            btnUpdateScreenType.OnIdleState.IconLeftImage = null;
            btnUpdateScreenType.OnIdleState.IconRightImage = null;
            btnUpdateScreenType.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnUpdateScreenType.OnPressedState.BorderRadius = 30;
            btnUpdateScreenType.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateScreenType.OnPressedState.BorderThickness = 2;
            btnUpdateScreenType.OnPressedState.FillColor = Color.Gold;
            btnUpdateScreenType.OnPressedState.ForeColor = Color.White;
            btnUpdateScreenType.OnPressedState.IconLeftImage = null;
            btnUpdateScreenType.OnPressedState.IconRightImage = null;
            btnUpdateScreenType.Size = new Size(133, 88);
            btnUpdateScreenType.TabIndex = 10;
            btnUpdateScreenType.TextAlign = ContentAlignment.MiddleCenter;
            btnUpdateScreenType.TextAlignment = HorizontalAlignment.Center;
            btnUpdateScreenType.TextMarginLeft = 0;
            btnUpdateScreenType.TextPadding = new Padding(0);
            btnUpdateScreenType.UseDefaultRadiusAndThickness = true;
            btnUpdateScreenType.Click += btnUpdateScreenType_Click_1;
            // 
            // btnInsertScreenType
            // 
            btnInsertScreenType.AllowAnimations = true;
            btnInsertScreenType.AllowMouseEffects = true;
            btnInsertScreenType.AllowToggling = false;
            btnInsertScreenType.AnimationSpeed = 200;
            btnInsertScreenType.AutoGenerateColors = false;
            btnInsertScreenType.AutoRoundBorders = false;
            btnInsertScreenType.AutoSizeLeftIcon = true;
            btnInsertScreenType.AutoSizeRightIcon = true;
            btnInsertScreenType.BackColor = Color.Transparent;
            btnInsertScreenType.BackColor1 = Color.FromArgb(51, 122, 183);
            btnInsertScreenType.BackgroundImage = (Image)resources.GetObject("btnInsertScreenType.BackgroundImage");
            btnInsertScreenType.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertScreenType.ButtonText = "Thêm";
            btnInsertScreenType.ButtonTextMarginLeft = 0;
            btnInsertScreenType.ColorContrastOnClick = 45;
            btnInsertScreenType.ColorContrastOnHover = 45;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            btnInsertScreenType.CustomizableEdges = borderEdges5;
            btnInsertScreenType.DialogResult = DialogResult.None;
            btnInsertScreenType.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnInsertScreenType.DisabledFillColor = Color.Empty;
            btnInsertScreenType.DisabledForecolor = Color.Empty;
            btnInsertScreenType.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnInsertScreenType.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnInsertScreenType.ForeColor = Color.White;
            btnInsertScreenType.IconLeft = null;
            btnInsertScreenType.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnInsertScreenType.IconLeftCursor = Cursors.Default;
            btnInsertScreenType.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnInsertScreenType.IconMarginLeft = 11;
            btnInsertScreenType.IconPadding = 10;
            btnInsertScreenType.IconRight = null;
            btnInsertScreenType.IconRightAlign = ContentAlignment.MiddleRight;
            btnInsertScreenType.IconRightCursor = Cursors.Default;
            btnInsertScreenType.IconRightPadding = new Padding(3, 3, 7, 3);
            btnInsertScreenType.IconSize = 25;
            btnInsertScreenType.IdleBorderColor = Color.Empty;
            btnInsertScreenType.IdleBorderRadius = 0;
            btnInsertScreenType.IdleBorderThickness = 0;
            btnInsertScreenType.IdleFillColor = Color.Empty;
            btnInsertScreenType.IdleIconLeftImage = null;
            btnInsertScreenType.IdleIconRightImage = null;
            btnInsertScreenType.IndicateFocus = false;
            btnInsertScreenType.Location = new Point(3, 239);
            btnInsertScreenType.Name = "btnInsertScreenType";
            btnInsertScreenType.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnInsertScreenType.OnDisabledState.BorderRadius = 30;
            btnInsertScreenType.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertScreenType.OnDisabledState.BorderThickness = 2;
            btnInsertScreenType.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnInsertScreenType.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnInsertScreenType.OnDisabledState.IconLeftImage = null;
            btnInsertScreenType.OnDisabledState.IconRightImage = null;
            btnInsertScreenType.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnInsertScreenType.onHoverState.BorderRadius = 30;
            btnInsertScreenType.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertScreenType.onHoverState.BorderThickness = 2;
            btnInsertScreenType.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnInsertScreenType.onHoverState.ForeColor = Color.White;
            btnInsertScreenType.onHoverState.IconLeftImage = null;
            btnInsertScreenType.onHoverState.IconRightImage = null;
            btnInsertScreenType.OnIdleState.BorderColor = Color.DodgerBlue;
            btnInsertScreenType.OnIdleState.BorderRadius = 30;
            btnInsertScreenType.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertScreenType.OnIdleState.BorderThickness = 2;
            btnInsertScreenType.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnInsertScreenType.OnIdleState.ForeColor = Color.White;
            btnInsertScreenType.OnIdleState.IconLeftImage = null;
            btnInsertScreenType.OnIdleState.IconRightImage = null;
            btnInsertScreenType.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnInsertScreenType.OnPressedState.BorderRadius = 30;
            btnInsertScreenType.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertScreenType.OnPressedState.BorderThickness = 2;
            btnInsertScreenType.OnPressedState.FillColor = Color.Gold;
            btnInsertScreenType.OnPressedState.ForeColor = Color.White;
            btnInsertScreenType.OnPressedState.IconLeftImage = null;
            btnInsertScreenType.OnPressedState.IconRightImage = null;
            btnInsertScreenType.Size = new Size(158, 88);
            btnInsertScreenType.TabIndex = 9;
            btnInsertScreenType.TextAlign = ContentAlignment.MiddleCenter;
            btnInsertScreenType.TextAlignment = HorizontalAlignment.Center;
            btnInsertScreenType.TextMarginLeft = 0;
            btnInsertScreenType.TextPadding = new Padding(0);
            btnInsertScreenType.UseDefaultRadiusAndThickness = true;
            btnInsertScreenType.Click += btnInsertScreenType_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 339);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 529);
            panel2.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientActiveCaption;
            panel4.Controls.Add(panel20);
            panel4.Controls.Add(panel21);
            panel4.Dock = DockStyle.Fill;
            panel4.ImeMode = ImeMode.Disable;
            panel4.Location = new Point(974, 0);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(950, 529);
            panel4.TabIndex = 1;
            // 
            // panel20
            // 
            panel20.Controls.Add(txtScreenTypeName);
            panel20.Controls.Add(lblScreenTypeName);
            panel20.Location = new Point(55, 130);
            panel20.Margin = new Padding(5, 6, 5, 6);
            panel20.Name = "panel20";
            panel20.Size = new Size(489, 85);
            panel20.TabIndex = 4;
            // 
            // txtScreenTypeName
            // 
            txtScreenTypeName.Location = new Point(225, 18);
            txtScreenTypeName.Margin = new Padding(5, 6, 5, 6);
            txtScreenTypeName.Name = "txtScreenTypeName";
            txtScreenTypeName.Size = new Size(239, 31);
            txtScreenTypeName.TabIndex = 1;
            // 
            // lblScreenTypeName
            // 
            lblScreenTypeName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblScreenTypeName.Location = new Point(5, 18);
            lblScreenTypeName.Margin = new Padding(5, 0, 5, 0);
            lblScreenTypeName.Name = "lblScreenTypeName";
            lblScreenTypeName.Size = new Size(184, 30);
            lblScreenTypeName.TabIndex = 0;
            lblScreenTypeName.Text = "Tên màn hình:";
            // 
            // panel21
            // 
            panel21.Controls.Add(txtScreenTypeID);
            panel21.Controls.Add(lblScreenTypeID);
            panel21.Location = new Point(55, 35);
            panel21.Margin = new Padding(5, 6, 5, 6);
            panel21.Name = "panel21";
            panel21.Size = new Size(489, 85);
            panel21.TabIndex = 3;
            // 
            // txtScreenTypeID
            // 
            txtScreenTypeID.Location = new Point(225, 14);
            txtScreenTypeID.Margin = new Padding(5, 6, 5, 6);
            txtScreenTypeID.Name = "txtScreenTypeID";
            txtScreenTypeID.Size = new Size(239, 31);
            txtScreenTypeID.TabIndex = 1;
            // 
            // lblScreenTypeID
            // 
            lblScreenTypeID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblScreenTypeID.Location = new Point(5, 18);
            lblScreenTypeID.Margin = new Padding(5, 0, 5, 0);
            lblScreenTypeID.Name = "lblScreenTypeID";
            lblScreenTypeID.Size = new Size(222, 30);
            lblScreenTypeID.TabIndex = 0;
            lblScreenTypeID.Text = "Mã màn hình:";
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgvScreenType);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(974, 529);
            panel3.TabIndex = 0;
            // 
            // dtgvScreenType
            // 
            dtgvScreenType.AllowUserToAddRows = false;
            dtgvScreenType.AllowUserToDeleteRows = false;
            dtgvScreenType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvScreenType.BorderStyle = BorderStyle.None;
            dtgvScreenType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvScreenType.Dock = DockStyle.Fill;
            dtgvScreenType.ImeMode = ImeMode.Disable;
            dtgvScreenType.Location = new Point(0, 0);
            dtgvScreenType.Margin = new Padding(5, 6, 5, 6);
            dtgvScreenType.Name = "dtgvScreenType";
            dtgvScreenType.ReadOnly = true;
            dtgvScreenType.RowHeadersWidth = 51;
            dtgvScreenType.Size = new Size(974, 529);
            dtgvScreenType.TabIndex = 1;
            // 
            // KieuManHinhUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "KieuManHinhUC";
            Size = new Size(1924, 868);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvScreenType).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvScreenType;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TextBox txtScreenTypeName;
        private System.Windows.Forms.Label lblScreenTypeName;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.TextBox txtScreenTypeID;
        private System.Windows.Forms.Label lblScreenTypeID;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnInsertScreenType;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExport;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnShowScreenType;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDeleteScreenType;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdateScreenType;
    }
}