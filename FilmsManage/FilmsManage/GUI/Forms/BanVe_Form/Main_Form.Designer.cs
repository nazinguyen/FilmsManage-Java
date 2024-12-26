namespace FilmsManage.GUI.Forms.BanVe_Form
{
    partial class Main_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            panel1 = new Panel();
            button3 = new Button();
            btnLogout = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            lblTime = new Bunifu.UI.WinForms.BunifuLabel();
            userNameAlias = new Bunifu.UI.WinForms.BunifuLabel();
            button2 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            pnlLogo = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            pnlContent = new Panel();
            panel4 = new Panel();
            TimerLock = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(userNameAlias);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pnlLogo);
            panel1.Controls.Add(pnlContent);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 993);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(11, 605);
            button3.Name = "button3";
            button3.Size = new Size(163, 58);
            button3.TabIndex = 8;
            button3.Text = "Khách hàng";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            button3.Paint += button3_Paint;
            // 
            // btnLogout
            // 
            btnLogout.AllowAnimations = true;
            btnLogout.AllowMouseEffects = true;
            btnLogout.AllowToggling = false;
            btnLogout.AnimationSpeed = 200;
            btnLogout.AutoGenerateColors = false;
            btnLogout.AutoRoundBorders = false;
            btnLogout.AutoSizeLeftIcon = true;
            btnLogout.AutoSizeRightIcon = true;
            btnLogout.BackColor = Color.Transparent;
            btnLogout.BackColor1 = Color.FromArgb(51, 122, 183);
            btnLogout.BackgroundImage = (Image)resources.GetObject("btnLogout.BackgroundImage");
            btnLogout.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnLogout.ButtonText = "Thoát";
            btnLogout.ButtonTextMarginLeft = 0;
            btnLogout.ColorContrastOnClick = 45;
            btnLogout.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btnLogout.CustomizableEdges = borderEdges1;
            btnLogout.DialogResult = DialogResult.None;
            btnLogout.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnLogout.DisabledFillColor = Color.Empty;
            btnLogout.DisabledForecolor = Color.Empty;
            btnLogout.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnLogout.Font = new Font("Segoe UI", 9F);
            btnLogout.ForeColor = Color.White;
            btnLogout.IconLeft = null;
            btnLogout.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnLogout.IconLeftCursor = Cursors.Default;
            btnLogout.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnLogout.IconMarginLeft = 11;
            btnLogout.IconPadding = 10;
            btnLogout.IconRight = null;
            btnLogout.IconRightAlign = ContentAlignment.MiddleRight;
            btnLogout.IconRightCursor = Cursors.Default;
            btnLogout.IconRightPadding = new Padding(3, 3, 7, 3);
            btnLogout.IconSize = 25;
            btnLogout.IdleBorderColor = Color.Empty;
            btnLogout.IdleBorderRadius = 0;
            btnLogout.IdleBorderThickness = 0;
            btnLogout.IdleFillColor = Color.Empty;
            btnLogout.IdleIconLeftImage = null;
            btnLogout.IdleIconRightImage = null;
            btnLogout.IndicateFocus = false;
            btnLogout.Location = new Point(24, 943);
            btnLogout.Name = "btnLogout";
            btnLogout.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnLogout.OnDisabledState.BorderRadius = 1;
            btnLogout.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnLogout.OnDisabledState.BorderThickness = 1;
            btnLogout.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnLogout.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnLogout.OnDisabledState.IconLeftImage = null;
            btnLogout.OnDisabledState.IconRightImage = null;
            btnLogout.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnLogout.onHoverState.BorderRadius = 1;
            btnLogout.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnLogout.onHoverState.BorderThickness = 1;
            btnLogout.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnLogout.onHoverState.ForeColor = Color.White;
            btnLogout.onHoverState.IconLeftImage = null;
            btnLogout.onHoverState.IconRightImage = null;
            btnLogout.OnIdleState.BorderColor = Color.DodgerBlue;
            btnLogout.OnIdleState.BorderRadius = 1;
            btnLogout.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnLogout.OnIdleState.BorderThickness = 1;
            btnLogout.OnIdleState.FillColor = Color.Crimson;
            btnLogout.OnIdleState.ForeColor = Color.White;
            btnLogout.OnIdleState.IconLeftImage = null;
            btnLogout.OnIdleState.IconRightImage = null;
            btnLogout.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnLogout.OnPressedState.BorderRadius = 1;
            btnLogout.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnLogout.OnPressedState.BorderThickness = 1;
            btnLogout.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            btnLogout.OnPressedState.ForeColor = Color.White;
            btnLogout.OnPressedState.IconLeftImage = null;
            btnLogout.OnPressedState.IconRightImage = null;
            btnLogout.Size = new Size(104, 39);
            btnLogout.TabIndex = 7;
            btnLogout.TextAlign = ContentAlignment.MiddleCenter;
            btnLogout.TextAlignment = HorizontalAlignment.Center;
            btnLogout.TextMarginLeft = 0;
            btnLogout.TextPadding = new Padding(0);
            btnLogout.UseDefaultRadiusAndThickness = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblTime
            // 
            lblTime.AllowParentOverrides = false;
            lblTime.AutoEllipsis = false;
            lblTime.CursorType = Cursors.Default;
            lblTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.ForeColor = SystemColors.Window;
            lblTime.Location = new Point(3, 280);
            lblTime.Name = "lblTime";
            lblTime.RightToLeft = RightToLeft.No;
            lblTime.Size = new Size(129, 32);
            lblTime.TabIndex = 6;
            lblTime.Text = "8:54:00 PM";
            lblTime.TextAlignment = ContentAlignment.TopLeft;
            lblTime.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // userNameAlias
            // 
            userNameAlias.AllowParentOverrides = false;
            userNameAlias.AutoEllipsis = false;
            userNameAlias.CursorType = Cursors.Default;
            userNameAlias.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userNameAlias.ForeColor = SystemColors.ButtonHighlight;
            userNameAlias.Location = new Point(3, 232);
            userNameAlias.Name = "userNameAlias";
            userNameAlias.RightToLeft = RightToLeft.No;
            userNameAlias.Size = new Size(185, 27);
            userNameAlias.TabIndex = 5;
            userNameAlias.Text = "Xin chào, Đăng";
            userNameAlias.TextAlignment = ContentAlignment.TopLeft;
            userNameAlias.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(11, 420);
            button2.Name = "button2";
            button2.Size = new Size(163, 58);
            button2.TabIndex = 4;
            button2.Text = "Bán vé";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.Paint += button2_Paint;
            // 
            // panel2
            // 
            panel2.Location = new Point(218, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1224, 842);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(11, 506);
            button1.Name = "button1";
            button1.Size = new Size(163, 58);
            button1.TabIndex = 3;
            button1.Text = "Đồ ăn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.Paint += button1_Paint;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(pictureBox1);
            pnlLogo.Controls.Add(panel3);
            pnlLogo.Location = new Point(21, 26);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(163, 150);
            pnlLogo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Location = new Point(166, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(1269, 785);
            panel3.TabIndex = 1;
            // 
            // pnlContent
            // 
            pnlContent.Location = new Point(215, 3);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1220, 842);
            pnlContent.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Location = new Point(216, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1590, 993);
            panel4.TabIndex = 1;
            // 
            // TimerLock
            // 
            TimerLock.Enabled = true;
            TimerLock.Interval = 1000;
            TimerLock.Tick += TimerLock_Tick;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1805, 1020);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "Main_Form";
            Text = "Main_Form";
            Load += Main_Form_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlLogo;
        private Panel pnlContent;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        public Panel panel4;
        private Button button2;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
		private Bunifu.UI.WinForms.BunifuLabel userNameAlias;
		private Bunifu.UI.WinForms.BunifuLabel lblTime;
		private System.Windows.Forms.Timer TimerLock;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogout;
        private Button button3;
    }
}