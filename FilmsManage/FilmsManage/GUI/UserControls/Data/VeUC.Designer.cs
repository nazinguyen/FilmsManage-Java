namespace FilmsManage.GUI.UserControls.Data
{
    partial class VeUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeUC));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            lsvAllListShowTimes = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            dtgvVe = new DataGridView();
            btnExport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnAddTicketsByShowTime = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnShowTimeNotCreateTickets = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnAllListShowTimes = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            txtSearchShowtime = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)dtgvVe).BeginInit();
            SuspendLayout();
            // 
            // lsvAllListShowTimes
            // 
            lsvAllListShowTimes.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvAllListShowTimes.FullRowSelect = true;
            lsvAllListShowTimes.GridLines = true;
            lsvAllListShowTimes.Location = new Point(0, 304);
            lsvAllListShowTimes.Margin = new Padding(4, 5, 4, 5);
            lsvAllListShowTimes.Name = "lsvAllListShowTimes";
            lsvAllListShowTimes.Size = new Size(828, 732);
            lsvAllListShowTimes.TabIndex = 9;
            lsvAllListShowTimes.UseCompatibleStateImageBehavior = false;
            lsvAllListShowTimes.View = View.Details;
            lsvAllListShowTimes.SelectedIndexChanged += lsvAllListShowTimes_SelectedIndexChanged;
            lsvAllListShowTimes.MouseClick += lsvAllListShowTimes_MouseClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên phòng chiếu";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên phim";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Thời gian";
            columnHeader3.Width = 400;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Trạng thái";
            columnHeader4.Width = 150;
            // 
            // dtgvVe
            // 
            dtgvVe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvVe.Location = new Point(832, 304);
            dtgvVe.Name = "dtgvVe";
            dtgvVe.RowHeadersWidth = 62;
            dtgvVe.Size = new Size(831, 732);
            dtgvVe.TabIndex = 10;
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
            btnExport.Font = new Font("Segoe UI", 9F);
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
            btnExport.Location = new Point(756, 175);
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
            btnExport.OnIdleState.FillColor = Color.Firebrick;
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
            btnExport.Size = new Size(193, 89);
            btnExport.TabIndex = 49;
            btnExport.TextAlign = ContentAlignment.MiddleCenter;
            btnExport.TextAlignment = HorizontalAlignment.Center;
            btnExport.TextMarginLeft = 0;
            btnExport.TextPadding = new Padding(0);
            btnExport.UseDefaultRadiusAndThickness = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnAddTicketsByShowTime
            // 
            btnAddTicketsByShowTime.AllowAnimations = true;
            btnAddTicketsByShowTime.AllowMouseEffects = true;
            btnAddTicketsByShowTime.AllowToggling = false;
            btnAddTicketsByShowTime.AnimationSpeed = 200;
            btnAddTicketsByShowTime.AutoGenerateColors = false;
            btnAddTicketsByShowTime.AutoRoundBorders = false;
            btnAddTicketsByShowTime.AutoSizeLeftIcon = true;
            btnAddTicketsByShowTime.AutoSizeRightIcon = true;
            btnAddTicketsByShowTime.BackColor = Color.Transparent;
            btnAddTicketsByShowTime.BackColor1 = Color.FromArgb(51, 122, 183);
            btnAddTicketsByShowTime.BackgroundImage = (Image)resources.GetObject("btnAddTicketsByShowTime.BackgroundImage");
            btnAddTicketsByShowTime.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAddTicketsByShowTime.ButtonText = "Tự động thêm vé \r\ntheo lịch chiếu";
            btnAddTicketsByShowTime.ButtonTextMarginLeft = 0;
            btnAddTicketsByShowTime.ColorContrastOnClick = 45;
            btnAddTicketsByShowTime.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            btnAddTicketsByShowTime.CustomizableEdges = borderEdges2;
            btnAddTicketsByShowTime.DialogResult = DialogResult.None;
            btnAddTicketsByShowTime.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnAddTicketsByShowTime.DisabledFillColor = Color.Empty;
            btnAddTicketsByShowTime.DisabledForecolor = Color.Empty;
            btnAddTicketsByShowTime.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            btnAddTicketsByShowTime.Font = new Font("Segoe UI", 9F);
            btnAddTicketsByShowTime.ForeColor = Color.White;
            btnAddTicketsByShowTime.IconLeft = null;
            btnAddTicketsByShowTime.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnAddTicketsByShowTime.IconLeftCursor = Cursors.Default;
            btnAddTicketsByShowTime.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnAddTicketsByShowTime.IconMarginLeft = 11;
            btnAddTicketsByShowTime.IconPadding = 10;
            btnAddTicketsByShowTime.IconRight = null;
            btnAddTicketsByShowTime.IconRightAlign = ContentAlignment.MiddleRight;
            btnAddTicketsByShowTime.IconRightCursor = Cursors.Default;
            btnAddTicketsByShowTime.IconRightPadding = new Padding(3, 3, 7, 3);
            btnAddTicketsByShowTime.IconSize = 25;
            btnAddTicketsByShowTime.IdleBorderColor = Color.Empty;
            btnAddTicketsByShowTime.IdleBorderRadius = 0;
            btnAddTicketsByShowTime.IdleBorderThickness = 0;
            btnAddTicketsByShowTime.IdleFillColor = Color.Empty;
            btnAddTicketsByShowTime.IdleIconLeftImage = null;
            btnAddTicketsByShowTime.IdleIconRightImage = null;
            btnAddTicketsByShowTime.IndicateFocus = false;
            btnAddTicketsByShowTime.Location = new Point(25, 175);
            btnAddTicketsByShowTime.Name = "btnAddTicketsByShowTime";
            btnAddTicketsByShowTime.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnAddTicketsByShowTime.OnDisabledState.BorderRadius = 30;
            btnAddTicketsByShowTime.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAddTicketsByShowTime.OnDisabledState.BorderThickness = 2;
            btnAddTicketsByShowTime.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnAddTicketsByShowTime.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnAddTicketsByShowTime.OnDisabledState.IconLeftImage = null;
            btnAddTicketsByShowTime.OnDisabledState.IconRightImage = null;
            btnAddTicketsByShowTime.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnAddTicketsByShowTime.onHoverState.BorderRadius = 30;
            btnAddTicketsByShowTime.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAddTicketsByShowTime.onHoverState.BorderThickness = 2;
            btnAddTicketsByShowTime.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnAddTicketsByShowTime.onHoverState.ForeColor = Color.White;
            btnAddTicketsByShowTime.onHoverState.IconLeftImage = null;
            btnAddTicketsByShowTime.onHoverState.IconRightImage = null;
            btnAddTicketsByShowTime.OnIdleState.BorderColor = Color.DodgerBlue;
            btnAddTicketsByShowTime.OnIdleState.BorderRadius = 30;
            btnAddTicketsByShowTime.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAddTicketsByShowTime.OnIdleState.BorderThickness = 2;
            btnAddTicketsByShowTime.OnIdleState.FillColor = Color.Firebrick;
            btnAddTicketsByShowTime.OnIdleState.ForeColor = Color.White;
            btnAddTicketsByShowTime.OnIdleState.IconLeftImage = null;
            btnAddTicketsByShowTime.OnIdleState.IconRightImage = null;
            btnAddTicketsByShowTime.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnAddTicketsByShowTime.OnPressedState.BorderRadius = 30;
            btnAddTicketsByShowTime.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAddTicketsByShowTime.OnPressedState.BorderThickness = 2;
            btnAddTicketsByShowTime.OnPressedState.FillColor = Color.Gold;
            btnAddTicketsByShowTime.OnPressedState.ForeColor = Color.White;
            btnAddTicketsByShowTime.OnPressedState.IconLeftImage = null;
            btnAddTicketsByShowTime.OnPressedState.IconRightImage = null;
            btnAddTicketsByShowTime.Size = new Size(194, 89);
            btnAddTicketsByShowTime.TabIndex = 50;
            btnAddTicketsByShowTime.TextAlign = ContentAlignment.MiddleCenter;
            btnAddTicketsByShowTime.TextAlignment = HorizontalAlignment.Center;
            btnAddTicketsByShowTime.TextMarginLeft = 0;
            btnAddTicketsByShowTime.TextPadding = new Padding(0, 0, 100, 0);
            btnAddTicketsByShowTime.UseDefaultRadiusAndThickness = true;
            btnAddTicketsByShowTime.Click += btnAddTicketsByShowTime_Click_1;
            // 
            // btnShowTimeNotCreateTickets
            // 
            btnShowTimeNotCreateTickets.AllowAnimations = true;
            btnShowTimeNotCreateTickets.AllowMouseEffects = true;
            btnShowTimeNotCreateTickets.AllowToggling = false;
            btnShowTimeNotCreateTickets.AnimationSpeed = 200;
            btnShowTimeNotCreateTickets.AutoGenerateColors = false;
            btnShowTimeNotCreateTickets.AutoRoundBorders = false;
            btnShowTimeNotCreateTickets.AutoSizeLeftIcon = true;
            btnShowTimeNotCreateTickets.AutoSizeRightIcon = true;
            btnShowTimeNotCreateTickets.BackColor = Color.Transparent;
            btnShowTimeNotCreateTickets.BackColor1 = Color.FromArgb(51, 122, 183);
            btnShowTimeNotCreateTickets.BackgroundImage = (Image)resources.GetObject("btnShowTimeNotCreateTickets.BackgroundImage");
            btnShowTimeNotCreateTickets.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowTimeNotCreateTickets.ButtonText = "Xem lịch chiếu\r\n chưa được tạo\r\n vé";
            btnShowTimeNotCreateTickets.ButtonTextMarginLeft = 0;
            btnShowTimeNotCreateTickets.ColorContrastOnClick = 45;
            btnShowTimeNotCreateTickets.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            btnShowTimeNotCreateTickets.CustomizableEdges = borderEdges3;
            btnShowTimeNotCreateTickets.DialogResult = DialogResult.None;
            btnShowTimeNotCreateTickets.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnShowTimeNotCreateTickets.DisabledFillColor = Color.Empty;
            btnShowTimeNotCreateTickets.DisabledForecolor = Color.Empty;
            btnShowTimeNotCreateTickets.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            btnShowTimeNotCreateTickets.Font = new Font("Segoe UI", 9F);
            btnShowTimeNotCreateTickets.ForeColor = Color.White;
            btnShowTimeNotCreateTickets.IconLeft = null;
            btnShowTimeNotCreateTickets.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnShowTimeNotCreateTickets.IconLeftCursor = Cursors.Default;
            btnShowTimeNotCreateTickets.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnShowTimeNotCreateTickets.IconMarginLeft = 11;
            btnShowTimeNotCreateTickets.IconPadding = 10;
            btnShowTimeNotCreateTickets.IconRight = null;
            btnShowTimeNotCreateTickets.IconRightAlign = ContentAlignment.MiddleRight;
            btnShowTimeNotCreateTickets.IconRightCursor = Cursors.Default;
            btnShowTimeNotCreateTickets.IconRightPadding = new Padding(3, 3, 7, 3);
            btnShowTimeNotCreateTickets.IconSize = 25;
            btnShowTimeNotCreateTickets.IdleBorderColor = Color.Empty;
            btnShowTimeNotCreateTickets.IdleBorderRadius = 0;
            btnShowTimeNotCreateTickets.IdleBorderThickness = 0;
            btnShowTimeNotCreateTickets.IdleFillColor = Color.Empty;
            btnShowTimeNotCreateTickets.IdleIconLeftImage = null;
            btnShowTimeNotCreateTickets.IdleIconRightImage = null;
            btnShowTimeNotCreateTickets.IndicateFocus = false;
            btnShowTimeNotCreateTickets.Location = new Point(270, 175);
            btnShowTimeNotCreateTickets.Name = "btnShowTimeNotCreateTickets";
            btnShowTimeNotCreateTickets.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnShowTimeNotCreateTickets.OnDisabledState.BorderRadius = 30;
            btnShowTimeNotCreateTickets.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowTimeNotCreateTickets.OnDisabledState.BorderThickness = 2;
            btnShowTimeNotCreateTickets.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnShowTimeNotCreateTickets.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnShowTimeNotCreateTickets.OnDisabledState.IconLeftImage = null;
            btnShowTimeNotCreateTickets.OnDisabledState.IconRightImage = null;
            btnShowTimeNotCreateTickets.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnShowTimeNotCreateTickets.onHoverState.BorderRadius = 30;
            btnShowTimeNotCreateTickets.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowTimeNotCreateTickets.onHoverState.BorderThickness = 2;
            btnShowTimeNotCreateTickets.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnShowTimeNotCreateTickets.onHoverState.ForeColor = Color.White;
            btnShowTimeNotCreateTickets.onHoverState.IconLeftImage = null;
            btnShowTimeNotCreateTickets.onHoverState.IconRightImage = null;
            btnShowTimeNotCreateTickets.OnIdleState.BorderColor = Color.DodgerBlue;
            btnShowTimeNotCreateTickets.OnIdleState.BorderRadius = 30;
            btnShowTimeNotCreateTickets.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowTimeNotCreateTickets.OnIdleState.BorderThickness = 2;
            btnShowTimeNotCreateTickets.OnIdleState.FillColor = Color.Firebrick;
            btnShowTimeNotCreateTickets.OnIdleState.ForeColor = Color.White;
            btnShowTimeNotCreateTickets.OnIdleState.IconLeftImage = null;
            btnShowTimeNotCreateTickets.OnIdleState.IconRightImage = null;
            btnShowTimeNotCreateTickets.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnShowTimeNotCreateTickets.OnPressedState.BorderRadius = 30;
            btnShowTimeNotCreateTickets.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnShowTimeNotCreateTickets.OnPressedState.BorderThickness = 2;
            btnShowTimeNotCreateTickets.OnPressedState.FillColor = Color.Gold;
            btnShowTimeNotCreateTickets.OnPressedState.ForeColor = Color.White;
            btnShowTimeNotCreateTickets.OnPressedState.IconLeftImage = null;
            btnShowTimeNotCreateTickets.OnPressedState.IconRightImage = null;
            btnShowTimeNotCreateTickets.Size = new Size(194, 89);
            btnShowTimeNotCreateTickets.TabIndex = 51;
            btnShowTimeNotCreateTickets.TextAlign = ContentAlignment.MiddleCenter;
            btnShowTimeNotCreateTickets.TextAlignment = HorizontalAlignment.Center;
            btnShowTimeNotCreateTickets.TextMarginLeft = 0;
            btnShowTimeNotCreateTickets.TextPadding = new Padding(0, 0, 100, 0);
            btnShowTimeNotCreateTickets.UseDefaultRadiusAndThickness = true;
            btnShowTimeNotCreateTickets.Click += btnShowTimeNotCreateTickets_Click;
            // 
            // btnAllListShowTimes
            // 
            btnAllListShowTimes.AllowAnimations = true;
            btnAllListShowTimes.AllowMouseEffects = true;
            btnAllListShowTimes.AllowToggling = false;
            btnAllListShowTimes.AnimationSpeed = 200;
            btnAllListShowTimes.AutoGenerateColors = false;
            btnAllListShowTimes.AutoRoundBorders = false;
            btnAllListShowTimes.AutoSizeLeftIcon = true;
            btnAllListShowTimes.AutoSizeRightIcon = true;
            btnAllListShowTimes.BackColor = Color.Transparent;
            btnAllListShowTimes.BackColor1 = Color.FromArgb(51, 122, 183);
            btnAllListShowTimes.BackgroundImage = (Image)resources.GetObject("btnAllListShowTimes.BackgroundImage");
            btnAllListShowTimes.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAllListShowTimes.ButtonText = "Xem tất cả lịch chiếu";
            btnAllListShowTimes.ButtonTextMarginLeft = 0;
            btnAllListShowTimes.ColorContrastOnClick = 45;
            btnAllListShowTimes.ColorContrastOnHover = 45;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            btnAllListShowTimes.CustomizableEdges = borderEdges4;
            btnAllListShowTimes.DialogResult = DialogResult.None;
            btnAllListShowTimes.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnAllListShowTimes.DisabledFillColor = Color.Empty;
            btnAllListShowTimes.DisabledForecolor = Color.Empty;
            btnAllListShowTimes.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            btnAllListShowTimes.Font = new Font("Segoe UI", 9F);
            btnAllListShowTimes.ForeColor = Color.White;
            btnAllListShowTimes.IconLeft = null;
            btnAllListShowTimes.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnAllListShowTimes.IconLeftCursor = Cursors.Default;
            btnAllListShowTimes.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnAllListShowTimes.IconMarginLeft = 11;
            btnAllListShowTimes.IconPadding = 10;
            btnAllListShowTimes.IconRight = null;
            btnAllListShowTimes.IconRightAlign = ContentAlignment.MiddleRight;
            btnAllListShowTimes.IconRightCursor = Cursors.Default;
            btnAllListShowTimes.IconRightPadding = new Padding(3, 3, 7, 3);
            btnAllListShowTimes.IconSize = 25;
            btnAllListShowTimes.IdleBorderColor = Color.Empty;
            btnAllListShowTimes.IdleBorderRadius = 0;
            btnAllListShowTimes.IdleBorderThickness = 0;
            btnAllListShowTimes.IdleFillColor = Color.Empty;
            btnAllListShowTimes.IdleIconLeftImage = null;
            btnAllListShowTimes.IdleIconRightImage = null;
            btnAllListShowTimes.IndicateFocus = false;
            btnAllListShowTimes.Location = new Point(524, 175);
            btnAllListShowTimes.Name = "btnAllListShowTimes";
            btnAllListShowTimes.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnAllListShowTimes.OnDisabledState.BorderRadius = 30;
            btnAllListShowTimes.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAllListShowTimes.OnDisabledState.BorderThickness = 2;
            btnAllListShowTimes.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnAllListShowTimes.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnAllListShowTimes.OnDisabledState.IconLeftImage = null;
            btnAllListShowTimes.OnDisabledState.IconRightImage = null;
            btnAllListShowTimes.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnAllListShowTimes.onHoverState.BorderRadius = 30;
            btnAllListShowTimes.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAllListShowTimes.onHoverState.BorderThickness = 2;
            btnAllListShowTimes.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnAllListShowTimes.onHoverState.ForeColor = Color.White;
            btnAllListShowTimes.onHoverState.IconLeftImage = null;
            btnAllListShowTimes.onHoverState.IconRightImage = null;
            btnAllListShowTimes.OnIdleState.BorderColor = Color.DodgerBlue;
            btnAllListShowTimes.OnIdleState.BorderRadius = 30;
            btnAllListShowTimes.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAllListShowTimes.OnIdleState.BorderThickness = 2;
            btnAllListShowTimes.OnIdleState.FillColor = Color.Firebrick;
            btnAllListShowTimes.OnIdleState.ForeColor = Color.White;
            btnAllListShowTimes.OnIdleState.IconLeftImage = null;
            btnAllListShowTimes.OnIdleState.IconRightImage = null;
            btnAllListShowTimes.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnAllListShowTimes.OnPressedState.BorderRadius = 30;
            btnAllListShowTimes.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAllListShowTimes.OnPressedState.BorderThickness = 2;
            btnAllListShowTimes.OnPressedState.FillColor = Color.Gold;
            btnAllListShowTimes.OnPressedState.ForeColor = Color.White;
            btnAllListShowTimes.OnPressedState.IconLeftImage = null;
            btnAllListShowTimes.OnPressedState.IconRightImage = null;
            btnAllListShowTimes.Size = new Size(194, 89);
            btnAllListShowTimes.TabIndex = 52;
            btnAllListShowTimes.TextAlign = ContentAlignment.MiddleCenter;
            btnAllListShowTimes.TextAlignment = HorizontalAlignment.Center;
            btnAllListShowTimes.TextMarginLeft = 0;
            btnAllListShowTimes.TextPadding = new Padding(0, 0, 100, 0);
            btnAllListShowTimes.UseDefaultRadiusAndThickness = true;
            btnAllListShowTimes.Click += btnAllListShowTimes_Click_1;
            // 
            // txtSearchShowtime
            // 
            txtSearchShowtime.AcceptsReturn = false;
            txtSearchShowtime.AcceptsTab = false;
            txtSearchShowtime.AnimationSpeed = 200;
            txtSearchShowtime.AutoCompleteMode = AutoCompleteMode.None;
            txtSearchShowtime.AutoCompleteSource = AutoCompleteSource.None;
            txtSearchShowtime.AutoSizeHeight = true;
            txtSearchShowtime.BackColor = Color.Transparent;
            txtSearchShowtime.BackgroundImage = (Image)resources.GetObject("txtSearchShowtime.BackgroundImage");
            txtSearchShowtime.BorderColorActive = Color.DodgerBlue;
            txtSearchShowtime.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtSearchShowtime.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtSearchShowtime.BorderColorIdle = Color.Silver;
            txtSearchShowtime.BorderRadius = 20;
            txtSearchShowtime.BorderThickness = 4;
            txtSearchShowtime.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtSearchShowtime.CharacterCasing = CharacterCasing.Normal;
            txtSearchShowtime.DefaultFont = new Font("Segoe UI", 9.25F);
            txtSearchShowtime.DefaultText = "";
            txtSearchShowtime.FillColor = Color.White;
            txtSearchShowtime.HideSelection = true;
            txtSearchShowtime.IconLeft = null;
            txtSearchShowtime.IconLeftCursor = Cursors.IBeam;
            txtSearchShowtime.IconPadding = 10;
            txtSearchShowtime.IconRight = null;
            txtSearchShowtime.IconRightCursor = Cursors.IBeam;
            txtSearchShowtime.Location = new Point(993, 194);
            txtSearchShowtime.MaxLength = 32767;
            txtSearchShowtime.MinimumSize = new Size(1, 1);
            txtSearchShowtime.Modified = false;
            txtSearchShowtime.Multiline = false;
            txtSearchShowtime.Name = "txtSearchShowtime";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            txtSearchShowtime.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            txtSearchShowtime.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            txtSearchShowtime.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            txtSearchShowtime.OnIdleState = stateProperties4;
            txtSearchShowtime.Padding = new Padding(3);
            txtSearchShowtime.PasswordChar = '\0';
            txtSearchShowtime.PlaceholderForeColor = Color.Silver;
            txtSearchShowtime.PlaceholderText = "Nhập thông tin tìm kiếm";
            txtSearchShowtime.ReadOnly = false;
            txtSearchShowtime.ScrollBars = ScrollBars.None;
            txtSearchShowtime.SelectedText = "";
            txtSearchShowtime.SelectionLength = 0;
            txtSearchShowtime.SelectionStart = 0;
            txtSearchShowtime.ShortcutsEnabled = true;
            txtSearchShowtime.Size = new Size(390, 70);
            txtSearchShowtime.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtSearchShowtime.TabIndex = 57;
            txtSearchShowtime.TextAlign = HorizontalAlignment.Left;
            txtSearchShowtime.TextMarginBottom = 0;
            txtSearchShowtime.TextMarginLeft = 3;
            txtSearchShowtime.TextMarginTop = 1;
            txtSearchShowtime.TextPlaceholder = "Nhập thông tin tìm kiếm";
            txtSearchShowtime.UseSystemPasswordChar = false;
            txtSearchShowtime.WordWrap = true;
            txtSearchShowtime.TextChanged += txtSearchShowtime_TextChanged_1;
            // 
            // VeUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtSearchShowtime);
            Controls.Add(btnAllListShowTimes);
            Controls.Add(btnShowTimeNotCreateTickets);
            Controls.Add(btnAddTicketsByShowTime);
            Controls.Add(btnExport);
            Controls.Add(dtgvVe);
            Controls.Add(lsvAllListShowTimes);
            Margin = new Padding(4, 5, 4, 5);
            Name = "VeUC";
            Size = new Size(1663, 1067);
            ((System.ComponentModel.ISupportInitialize)dtgvVe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel61;
        private System.Windows.Forms.Button btnShowAllTicketsBoughtByShowTime;
        private System.Windows.Forms.Button btnDeleteTicketsByShowTime;
        private DataGridView dtgvTicket;
        private Panel panel1;
        private ListView lsvAllListShowTimes;
        private DataGridView dataGridView1;
        private DataGridView dtgvVe;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExport;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddTicketsByShowTime;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnShowTimeNotCreateTickets;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAllListShowTimes;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearchShowtime;
    }
}
