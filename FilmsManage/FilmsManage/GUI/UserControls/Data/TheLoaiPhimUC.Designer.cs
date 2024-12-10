namespace FilmsManage.GUI.UserControls.Data
{
    partial class TheLoaiPhimUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheLoaiPhimUC));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            panel40 = new Panel();
            btnExport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnUpdateGenre = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnDeleteGenre = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnInsertGenre = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            panel1 = new Panel();
            dtgvGenre = new DataGridView();
            panel2 = new Panel();
            dtgvPhim = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            chiTiếtPhimToolStripMenuItem = new ToolStripMenuItem();
            panel38 = new Panel();
            txtGenreName = new TextBox();
            lblGenreName = new Label();
            panel39 = new Panel();
            txtGenreID = new TextBox();
            lblGenreID = new Label();
            panel40.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvGenre).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPhim).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel38.SuspendLayout();
            panel39.SuspendLayout();
            SuspendLayout();
            // 
            // panel40
            // 
            panel40.BackColor = Color.LightSteelBlue;
            panel40.Controls.Add(btnExport);
            panel40.Controls.Add(btnUpdateGenre);
            panel40.Controls.Add(btnDeleteGenre);
            panel40.Controls.Add(btnInsertGenre);
            panel40.Dock = DockStyle.Top;
            panel40.Location = new Point(0, 0);
            panel40.Margin = new Padding(5, 6, 5, 6);
            panel40.Name = "panel40";
            panel40.Size = new Size(1935, 360);
            panel40.TabIndex = 10;
            panel40.Paint += panel40_Paint;
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
            btnExport.Location = new Point(659, 211);
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
            btnExport.Size = new Size(169, 94);
            btnExport.TabIndex = 7;
            btnExport.TextAlign = ContentAlignment.MiddleCenter;
            btnExport.TextAlignment = HorizontalAlignment.Center;
            btnExport.TextMarginLeft = 0;
            btnExport.TextPadding = new Padding(0);
            btnExport.UseDefaultRadiusAndThickness = true;
            btnExport.Click += btnExport_Click_1;
            // 
            // btnUpdateGenre
            // 
            btnUpdateGenre.AllowAnimations = true;
            btnUpdateGenre.AllowMouseEffects = true;
            btnUpdateGenre.AllowToggling = false;
            btnUpdateGenre.AnimationSpeed = 200;
            btnUpdateGenre.AutoGenerateColors = false;
            btnUpdateGenre.AutoRoundBorders = false;
            btnUpdateGenre.AutoSizeLeftIcon = true;
            btnUpdateGenre.AutoSizeRightIcon = true;
            btnUpdateGenre.BackColor = Color.Transparent;
            btnUpdateGenre.BackColor1 = Color.FromArgb(51, 122, 183);
            btnUpdateGenre.BackgroundImage = (Image)resources.GetObject("btnUpdateGenre.BackgroundImage");
            btnUpdateGenre.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateGenre.ButtonText = "Sửa";
            btnUpdateGenre.ButtonTextMarginLeft = 0;
            btnUpdateGenre.ColorContrastOnClick = 45;
            btnUpdateGenre.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            btnUpdateGenre.CustomizableEdges = borderEdges2;
            btnUpdateGenre.DialogResult = DialogResult.None;
            btnUpdateGenre.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnUpdateGenre.DisabledFillColor = Color.Empty;
            btnUpdateGenre.DisabledForecolor = Color.Empty;
            btnUpdateGenre.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnUpdateGenre.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnUpdateGenre.ForeColor = Color.White;
            btnUpdateGenre.IconLeft = null;
            btnUpdateGenre.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnUpdateGenre.IconLeftCursor = Cursors.Default;
            btnUpdateGenre.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnUpdateGenre.IconMarginLeft = 11;
            btnUpdateGenre.IconPadding = 10;
            btnUpdateGenre.IconRight = null;
            btnUpdateGenre.IconRightAlign = ContentAlignment.MiddleRight;
            btnUpdateGenre.IconRightCursor = Cursors.Default;
            btnUpdateGenre.IconRightPadding = new Padding(3, 3, 7, 3);
            btnUpdateGenre.IconSize = 25;
            btnUpdateGenre.IdleBorderColor = Color.Empty;
            btnUpdateGenre.IdleBorderRadius = 0;
            btnUpdateGenre.IdleBorderThickness = 0;
            btnUpdateGenre.IdleFillColor = Color.Empty;
            btnUpdateGenre.IdleIconLeftImage = null;
            btnUpdateGenre.IdleIconRightImage = null;
            btnUpdateGenre.IndicateFocus = false;
            btnUpdateGenre.Location = new Point(462, 211);
            btnUpdateGenre.Name = "btnUpdateGenre";
            btnUpdateGenre.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnUpdateGenre.OnDisabledState.BorderRadius = 30;
            btnUpdateGenre.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateGenre.OnDisabledState.BorderThickness = 2;
            btnUpdateGenre.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnUpdateGenre.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnUpdateGenre.OnDisabledState.IconLeftImage = null;
            btnUpdateGenre.OnDisabledState.IconRightImage = null;
            btnUpdateGenre.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnUpdateGenre.onHoverState.BorderRadius = 30;
            btnUpdateGenre.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateGenre.onHoverState.BorderThickness = 2;
            btnUpdateGenre.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnUpdateGenre.onHoverState.ForeColor = Color.White;
            btnUpdateGenre.onHoverState.IconLeftImage = null;
            btnUpdateGenre.onHoverState.IconRightImage = null;
            btnUpdateGenre.OnIdleState.BorderColor = Color.DodgerBlue;
            btnUpdateGenre.OnIdleState.BorderRadius = 30;
            btnUpdateGenre.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateGenre.OnIdleState.BorderThickness = 2;
            btnUpdateGenre.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnUpdateGenre.OnIdleState.ForeColor = Color.White;
            btnUpdateGenre.OnIdleState.IconLeftImage = null;
            btnUpdateGenre.OnIdleState.IconRightImage = null;
            btnUpdateGenre.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnUpdateGenre.OnPressedState.BorderRadius = 30;
            btnUpdateGenre.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateGenre.OnPressedState.BorderThickness = 2;
            btnUpdateGenre.OnPressedState.FillColor = Color.Gold;
            btnUpdateGenre.OnPressedState.ForeColor = Color.White;
            btnUpdateGenre.OnPressedState.IconLeftImage = null;
            btnUpdateGenre.OnPressedState.IconRightImage = null;
            btnUpdateGenre.Size = new Size(138, 94);
            btnUpdateGenre.TabIndex = 6;
            btnUpdateGenre.TextAlign = ContentAlignment.MiddleCenter;
            btnUpdateGenre.TextAlignment = HorizontalAlignment.Center;
            btnUpdateGenre.TextMarginLeft = 0;
            btnUpdateGenre.TextPadding = new Padding(0);
            btnUpdateGenre.UseDefaultRadiusAndThickness = true;
            btnUpdateGenre.Click += btnUpdateGenre_Click_1;
            // 
            // btnDeleteGenre
            // 
            btnDeleteGenre.AllowAnimations = true;
            btnDeleteGenre.AllowMouseEffects = true;
            btnDeleteGenre.AllowToggling = false;
            btnDeleteGenre.AnimationSpeed = 200;
            btnDeleteGenre.AutoGenerateColors = false;
            btnDeleteGenre.AutoRoundBorders = false;
            btnDeleteGenre.AutoSizeLeftIcon = true;
            btnDeleteGenre.AutoSizeRightIcon = true;
            btnDeleteGenre.BackColor = Color.Transparent;
            btnDeleteGenre.BackColor1 = Color.FromArgb(51, 122, 183);
            btnDeleteGenre.BackgroundImage = (Image)resources.GetObject("btnDeleteGenre.BackgroundImage");
            btnDeleteGenre.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteGenre.ButtonText = "Xóa";
            btnDeleteGenre.ButtonTextMarginLeft = 0;
            btnDeleteGenre.ColorContrastOnClick = 45;
            btnDeleteGenre.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            btnDeleteGenre.CustomizableEdges = borderEdges3;
            btnDeleteGenre.DialogResult = DialogResult.None;
            btnDeleteGenre.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnDeleteGenre.DisabledFillColor = Color.Empty;
            btnDeleteGenre.DisabledForecolor = Color.Empty;
            btnDeleteGenre.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnDeleteGenre.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnDeleteGenre.ForeColor = Color.White;
            btnDeleteGenre.IconLeft = null;
            btnDeleteGenre.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnDeleteGenre.IconLeftCursor = Cursors.Default;
            btnDeleteGenre.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnDeleteGenre.IconMarginLeft = 11;
            btnDeleteGenre.IconPadding = 10;
            btnDeleteGenre.IconRight = null;
            btnDeleteGenre.IconRightAlign = ContentAlignment.MiddleRight;
            btnDeleteGenre.IconRightCursor = Cursors.Default;
            btnDeleteGenre.IconRightPadding = new Padding(3, 3, 7, 3);
            btnDeleteGenre.IconSize = 25;
            btnDeleteGenre.IdleBorderColor = Color.Empty;
            btnDeleteGenre.IdleBorderRadius = 0;
            btnDeleteGenre.IdleBorderThickness = 0;
            btnDeleteGenre.IdleFillColor = Color.Empty;
            btnDeleteGenre.IdleIconLeftImage = null;
            btnDeleteGenre.IdleIconRightImage = null;
            btnDeleteGenre.IndicateFocus = false;
            btnDeleteGenre.Location = new Point(252, 211);
            btnDeleteGenre.Name = "btnDeleteGenre";
            btnDeleteGenre.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnDeleteGenre.OnDisabledState.BorderRadius = 30;
            btnDeleteGenre.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteGenre.OnDisabledState.BorderThickness = 2;
            btnDeleteGenre.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnDeleteGenre.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnDeleteGenre.OnDisabledState.IconLeftImage = null;
            btnDeleteGenre.OnDisabledState.IconRightImage = null;
            btnDeleteGenre.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnDeleteGenre.onHoverState.BorderRadius = 30;
            btnDeleteGenre.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteGenre.onHoverState.BorderThickness = 2;
            btnDeleteGenre.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnDeleteGenre.onHoverState.ForeColor = Color.White;
            btnDeleteGenre.onHoverState.IconLeftImage = null;
            btnDeleteGenre.onHoverState.IconRightImage = null;
            btnDeleteGenre.OnIdleState.BorderColor = Color.DodgerBlue;
            btnDeleteGenre.OnIdleState.BorderRadius = 30;
            btnDeleteGenre.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteGenre.OnIdleState.BorderThickness = 2;
            btnDeleteGenre.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnDeleteGenre.OnIdleState.ForeColor = Color.White;
            btnDeleteGenre.OnIdleState.IconLeftImage = null;
            btnDeleteGenre.OnIdleState.IconRightImage = null;
            btnDeleteGenre.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnDeleteGenre.OnPressedState.BorderRadius = 30;
            btnDeleteGenre.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteGenre.OnPressedState.BorderThickness = 2;
            btnDeleteGenre.OnPressedState.FillColor = Color.Gold;
            btnDeleteGenre.OnPressedState.ForeColor = Color.White;
            btnDeleteGenre.OnPressedState.IconLeftImage = null;
            btnDeleteGenre.OnPressedState.IconRightImage = null;
            btnDeleteGenre.Size = new Size(138, 94);
            btnDeleteGenre.TabIndex = 5;
            btnDeleteGenre.TextAlign = ContentAlignment.MiddleCenter;
            btnDeleteGenre.TextAlignment = HorizontalAlignment.Center;
            btnDeleteGenre.TextMarginLeft = 0;
            btnDeleteGenre.TextPadding = new Padding(0);
            btnDeleteGenre.UseDefaultRadiusAndThickness = true;
            btnDeleteGenre.Click += btnDeleteGenre_Click_1;
            // 
            // btnInsertGenre
            // 
            btnInsertGenre.AllowAnimations = true;
            btnInsertGenre.AllowMouseEffects = true;
            btnInsertGenre.AllowToggling = false;
            btnInsertGenre.AnimationSpeed = 200;
            btnInsertGenre.AutoGenerateColors = false;
            btnInsertGenre.AutoRoundBorders = false;
            btnInsertGenre.AutoSizeLeftIcon = true;
            btnInsertGenre.AutoSizeRightIcon = true;
            btnInsertGenre.BackColor = Color.Transparent;
            btnInsertGenre.BackColor1 = Color.FromArgb(51, 122, 183);
            btnInsertGenre.BackgroundImage = (Image)resources.GetObject("btnInsertGenre.BackgroundImage");
            btnInsertGenre.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertGenre.ButtonText = "Thêm";
            btnInsertGenre.ButtonTextMarginLeft = 0;
            btnInsertGenre.ColorContrastOnClick = 45;
            btnInsertGenre.ColorContrastOnHover = 45;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            btnInsertGenre.CustomizableEdges = borderEdges4;
            btnInsertGenre.DialogResult = DialogResult.None;
            btnInsertGenre.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnInsertGenre.DisabledFillColor = Color.Empty;
            btnInsertGenre.DisabledForecolor = Color.Empty;
            btnInsertGenre.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnInsertGenre.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnInsertGenre.ForeColor = Color.White;
            btnInsertGenre.IconLeft = null;
            btnInsertGenre.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnInsertGenre.IconLeftCursor = Cursors.Default;
            btnInsertGenre.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnInsertGenre.IconMarginLeft = 11;
            btnInsertGenre.IconPadding = 10;
            btnInsertGenre.IconRight = null;
            btnInsertGenre.IconRightAlign = ContentAlignment.MiddleRight;
            btnInsertGenre.IconRightCursor = Cursors.Default;
            btnInsertGenre.IconRightPadding = new Padding(3, 3, 7, 3);
            btnInsertGenre.IconSize = 25;
            btnInsertGenre.IdleBorderColor = Color.Empty;
            btnInsertGenre.IdleBorderRadius = 0;
            btnInsertGenre.IdleBorderThickness = 0;
            btnInsertGenre.IdleFillColor = Color.Empty;
            btnInsertGenre.IdleIconLeftImage = null;
            btnInsertGenre.IdleIconRightImage = null;
            btnInsertGenre.IndicateFocus = false;
            btnInsertGenre.Location = new Point(49, 211);
            btnInsertGenre.Name = "btnInsertGenre";
            btnInsertGenre.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnInsertGenre.OnDisabledState.BorderRadius = 30;
            btnInsertGenre.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertGenre.OnDisabledState.BorderThickness = 2;
            btnInsertGenre.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnInsertGenre.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnInsertGenre.OnDisabledState.IconLeftImage = null;
            btnInsertGenre.OnDisabledState.IconRightImage = null;
            btnInsertGenre.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnInsertGenre.onHoverState.BorderRadius = 30;
            btnInsertGenre.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertGenre.onHoverState.BorderThickness = 2;
            btnInsertGenre.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnInsertGenre.onHoverState.ForeColor = Color.White;
            btnInsertGenre.onHoverState.IconLeftImage = null;
            btnInsertGenre.onHoverState.IconRightImage = null;
            btnInsertGenre.OnIdleState.BorderColor = Color.DodgerBlue;
            btnInsertGenre.OnIdleState.BorderRadius = 30;
            btnInsertGenre.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertGenre.OnIdleState.BorderThickness = 2;
            btnInsertGenre.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnInsertGenre.OnIdleState.ForeColor = Color.White;
            btnInsertGenre.OnIdleState.IconLeftImage = null;
            btnInsertGenre.OnIdleState.IconRightImage = null;
            btnInsertGenre.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnInsertGenre.OnPressedState.BorderRadius = 30;
            btnInsertGenre.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnInsertGenre.OnPressedState.BorderThickness = 2;
            btnInsertGenre.OnPressedState.FillColor = Color.Gold;
            btnInsertGenre.OnPressedState.ForeColor = Color.White;
            btnInsertGenre.OnPressedState.IconLeftImage = null;
            btnInsertGenre.OnPressedState.IconRightImage = null;
            btnInsertGenre.Size = new Size(138, 94);
            btnInsertGenre.TabIndex = 4;
            btnInsertGenre.TextAlign = ContentAlignment.MiddleCenter;
            btnInsertGenre.TextAlignment = HorizontalAlignment.Center;
            btnInsertGenre.TextMarginLeft = 0;
            btnInsertGenre.TextPadding = new Padding(0);
            btnInsertGenre.UseDefaultRadiusAndThickness = true;
            btnInsertGenre.Click += btnInsertGenre_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvGenre);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 360);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1935, 638);
            panel1.TabIndex = 11;
            // 
            // dtgvGenre
            // 
            dtgvGenre.AllowUserToAddRows = false;
            dtgvGenre.AllowUserToDeleteRows = false;
            dtgvGenre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvGenre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvGenre.Dock = DockStyle.Fill;
            dtgvGenre.Location = new Point(0, 0);
            dtgvGenre.Margin = new Padding(5, 6, 5, 6);
            dtgvGenre.Name = "dtgvGenre";
            dtgvGenre.ReadOnly = true;
            dtgvGenre.RowHeadersWidth = 62;
            dtgvGenre.Size = new Size(1100, 638);
            dtgvGenre.TabIndex = 1;
            dtgvGenre.CellClick += dtgvGenre_CellClick;
            dtgvGenre.CellContentClick += dtgvGenre_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(dtgvPhim);
            panel2.Controls.Add(panel38);
            panel2.Controls.Add(panel39);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1100, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(835, 638);
            panel2.TabIndex = 0;
            // 
            // dtgvPhim
            // 
            dtgvPhim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPhim.ContextMenuStrip = contextMenuStrip1;
            dtgvPhim.Location = new Point(21, 238);
            dtgvPhim.Margin = new Padding(4);
            dtgvPhim.Name = "dtgvPhim";
            dtgvPhim.RowHeadersWidth = 62;
            dtgvPhim.Size = new Size(710, 396);
            dtgvPhim.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { chiTiếtPhimToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(186, 36);
            // 
            // chiTiếtPhimToolStripMenuItem
            // 
            chiTiếtPhimToolStripMenuItem.Name = "chiTiếtPhimToolStripMenuItem";
            chiTiếtPhimToolStripMenuItem.Size = new Size(185, 32);
            chiTiếtPhimToolStripMenuItem.Text = "Chi tiết phim";
            chiTiếtPhimToolStripMenuItem.Click += chiTiếtPhimToolStripMenuItem_Click;
            // 
            // panel38
            // 
            panel38.Controls.Add(txtGenreName);
            panel38.Controls.Add(lblGenreName);
            panel38.Location = new Point(5, 108);
            panel38.Margin = new Padding(5, 6, 5, 6);
            panel38.Name = "panel38";
            panel38.Size = new Size(658, 84);
            panel38.TabIndex = 4;
            // 
            // txtGenreName
            // 
            txtGenreName.Location = new Point(209, 16);
            txtGenreName.Margin = new Padding(5, 6, 5, 6);
            txtGenreName.Name = "txtGenreName";
            txtGenreName.Size = new Size(410, 31);
            txtGenreName.TabIndex = 1;
            // 
            // lblGenreName
            // 
            lblGenreName.AutoSize = true;
            lblGenreName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblGenreName.Location = new Point(5, 18);
            lblGenreName.Margin = new Padding(5, 0, 5, 0);
            lblGenreName.Name = "lblGenreName";
            lblGenreName.Size = new Size(162, 29);
            lblGenreName.TabIndex = 0;
            lblGenreName.Text = "Tên thể loại :";
            // 
            // panel39
            // 
            panel39.Controls.Add(txtGenreID);
            panel39.Controls.Add(lblGenreID);
            panel39.Location = new Point(5, 12);
            panel39.Margin = new Padding(5, 6, 5, 6);
            panel39.Name = "panel39";
            panel39.Size = new Size(658, 84);
            panel39.TabIndex = 3;
            // 
            // txtGenreID
            // 
            txtGenreID.Location = new Point(209, 31);
            txtGenreID.Margin = new Padding(5, 6, 5, 6);
            txtGenreID.Name = "txtGenreID";
            txtGenreID.Size = new Size(410, 31);
            txtGenreID.TabIndex = 1;
            txtGenreID.TextChanged += txtGenreID_TextChanged;
            // 
            // lblGenreID
            // 
            lblGenreID.AutoSize = true;
            lblGenreID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblGenreID.Location = new Point(5, 31);
            lblGenreID.Margin = new Padding(5, 0, 5, 0);
            lblGenreID.Name = "lblGenreID";
            lblGenreID.Size = new Size(153, 29);
            lblGenreID.TabIndex = 0;
            lblGenreID.Text = "Mã thể loại :";
            // 
            // TheLoaiPhimUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel40);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TheLoaiPhimUC";
            Size = new Size(1935, 998);
            panel40.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvGenre).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvPhim).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel38.ResumeLayout(false);
            panel38.PerformLayout();
            panel39.ResumeLayout(false);
            panel39.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel38;
        private System.Windows.Forms.TextBox txtGenreName;
        private System.Windows.Forms.Label lblGenreName;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.TextBox txtGenreID;
        private System.Windows.Forms.Label lblGenreID;
        private System.Windows.Forms.DataGridView dtgvGenre;
        private DataGridView dtgvPhim;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem chiTiếtPhimToolStripMenuItem;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnInsertGenre;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExport;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdateGenre;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDeleteGenre;
    }
}
