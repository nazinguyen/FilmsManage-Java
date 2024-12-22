namespace FilmsManage.GUI.Forms
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			panel2 = new Panel();
			pnAdmin = new Panel();
			panel3 = new Panel();
			lblTime = new Bunifu.UI.WinForms.BunifuLabel();
			userNameAlias = new Bunifu.UI.WinForms.BunifuLabel();
			btnAccountUC = new Button();
			btnCustomerUC = new Button();
			btnStaffUC = new Button();
			btnDataUC = new Button();
			btnRevenueUC = new Button();
			TimerClock = new System.Windows.Forms.Timer(components);
			btnLogout = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// panel2
			// 
			panel2.Controls.Add(pnAdmin);
			panel2.Controls.Add(panel3);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 0);
			panel2.Margin = new Padding(3, 2, 3, 2);
			panel2.Name = "panel2";
			panel2.Size = new Size(1924, 1050);
			panel2.TabIndex = 2;
			// 
			// pnAdmin
			// 
			pnAdmin.Dock = DockStyle.Fill;
			pnAdmin.Location = new Point(0, 178);
			pnAdmin.Margin = new Padding(3, 2, 3, 2);
			pnAdmin.Name = "pnAdmin";
			pnAdmin.Size = new Size(1924, 872);
			pnAdmin.TabIndex = 2;
			pnAdmin.Paint += pnAdmin_Paint;
			// 
			// panel3
			// 
			panel3.BackColor = Color.Silver;
			panel3.Controls.Add(btnLogout);
			panel3.Controls.Add(lblTime);
			panel3.Controls.Add(userNameAlias);
			panel3.Controls.Add(btnAccountUC);
			panel3.Controls.Add(btnCustomerUC);
			panel3.Controls.Add(btnStaffUC);
			panel3.Controls.Add(btnDataUC);
			panel3.Controls.Add(btnRevenueUC);
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point(0, 0);
			panel3.Margin = new Padding(3, 2, 3, 2);
			panel3.Name = "panel3";
			panel3.Size = new Size(1924, 178);
			panel3.TabIndex = 1;
			// 
			// lblTime
			// 
			lblTime.AllowParentOverrides = false;
			lblTime.AutoEllipsis = false;
			lblTime.CursorType = Cursors.Default;
			lblTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTime.Location = new Point(1787, 12);
			lblTime.Name = "lblTime";
			lblTime.RightToLeft = RightToLeft.No;
			lblTime.Size = new Size(107, 28);
			lblTime.TabIndex = 2;
			lblTime.Text = "8:54:00 PM";
			lblTime.TextAlignment = ContentAlignment.TopLeft;
			lblTime.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// userNameAlias
			// 
			userNameAlias.AllowParentOverrides = false;
			userNameAlias.AutoEllipsis = false;
			userNameAlias.CursorType = Cursors.Default;
			userNameAlias.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
			userNameAlias.Location = new Point(1642, 37);
			userNameAlias.Name = "userNameAlias";
			userNameAlias.RightToLeft = RightToLeft.No;
			userNameAlias.Size = new Size(270, 38);
			userNameAlias.TabIndex = 1;
			userNameAlias.Text = "Chào mừng, Admin";
			userNameAlias.TextAlignment = ContentAlignment.TopLeft;
			userNameAlias.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// btnAccountUC
			// 
			btnAccountUC.BackColor = Color.Goldenrod;
			btnAccountUC.FlatAppearance.CheckedBackColor = Color.Black;
			btnAccountUC.FlatAppearance.MouseDownBackColor = Color.Black;
			btnAccountUC.FlatAppearance.MouseOverBackColor = Color.Black;
			btnAccountUC.FlatStyle = FlatStyle.Flat;
			btnAccountUC.Font = new Font("Century Gothic", 11.25F);
			btnAccountUC.ForeColor = SystemColors.Control;
			btnAccountUC.ImageAlign = ContentAlignment.TopLeft;
			btnAccountUC.Location = new Point(939, 28);
			btnAccountUC.Margin = new Padding(3, 2, 3, 2);
			btnAccountUC.Name = "btnAccountUC";
			btnAccountUC.Size = new Size(193, 124);
			btnAccountUC.TabIndex = 0;
			btnAccountUC.Text = "Tài Khoản";
			btnAccountUC.TextAlign = ContentAlignment.BottomLeft;
			btnAccountUC.UseVisualStyleBackColor = false;
			btnAccountUC.Click += btnAccountUC_Click;
			// 
			// btnCustomerUC
			// 
			btnCustomerUC.BackColor = Color.RoyalBlue;
			btnCustomerUC.FlatAppearance.CheckedBackColor = Color.Black;
			btnCustomerUC.FlatAppearance.MouseDownBackColor = Color.Black;
			btnCustomerUC.FlatAppearance.MouseOverBackColor = Color.Black;
			btnCustomerUC.FlatStyle = FlatStyle.Flat;
			btnCustomerUC.Font = new Font("Century Gothic", 11.25F);
			btnCustomerUC.ForeColor = SystemColors.Control;
			btnCustomerUC.ImageAlign = ContentAlignment.TopLeft;
			btnCustomerUC.Location = new Point(723, 28);
			btnCustomerUC.Margin = new Padding(3, 2, 3, 2);
			btnCustomerUC.Name = "btnCustomerUC";
			btnCustomerUC.Size = new Size(193, 124);
			btnCustomerUC.TabIndex = 0;
			btnCustomerUC.Text = "Khách Hàng";
			btnCustomerUC.TextAlign = ContentAlignment.BottomLeft;
			btnCustomerUC.UseVisualStyleBackColor = false;
			btnCustomerUC.Click += btnCustomerUC_Click;
			// 
			// btnStaffUC
			// 
			btnStaffUC.BackColor = Color.Red;
			btnStaffUC.FlatAppearance.CheckedBackColor = Color.Black;
			btnStaffUC.FlatAppearance.MouseDownBackColor = Color.Black;
			btnStaffUC.FlatAppearance.MouseOverBackColor = Color.Black;
			btnStaffUC.FlatStyle = FlatStyle.Flat;
			btnStaffUC.Font = new Font("Century Gothic", 11.25F);
			btnStaffUC.ForeColor = SystemColors.Control;
			btnStaffUC.ImageAlign = ContentAlignment.TopLeft;
			btnStaffUC.Location = new Point(507, 28);
			btnStaffUC.Margin = new Padding(3, 2, 3, 2);
			btnStaffUC.Name = "btnStaffUC";
			btnStaffUC.Size = new Size(193, 124);
			btnStaffUC.TabIndex = 0;
			btnStaffUC.Text = "Nhân Viên";
			btnStaffUC.TextAlign = ContentAlignment.BottomLeft;
			btnStaffUC.UseVisualStyleBackColor = false;
			btnStaffUC.Click += btnStaffUC_Click;
			// 
			// btnDataUC
			// 
			btnDataUC.BackColor = Color.ForestGreen;
			btnDataUC.FlatAppearance.CheckedBackColor = Color.Black;
			btnDataUC.FlatAppearance.MouseDownBackColor = Color.Black;
			btnDataUC.FlatAppearance.MouseOverBackColor = Color.Black;
			btnDataUC.FlatStyle = FlatStyle.Flat;
			btnDataUC.Font = new Font("Century Gothic", 11.25F);
			btnDataUC.ForeColor = SystemColors.Control;
			btnDataUC.ImageAlign = ContentAlignment.TopLeft;
			btnDataUC.Location = new Point(283, 28);
			btnDataUC.Margin = new Padding(3, 2, 3, 2);
			btnDataUC.Name = "btnDataUC";
			btnDataUC.Size = new Size(193, 124);
			btnDataUC.TabIndex = 0;
			btnDataUC.Text = "Dữ Liệu";
			btnDataUC.TextAlign = ContentAlignment.BottomLeft;
			btnDataUC.UseVisualStyleBackColor = false;
			btnDataUC.Click += btnDataUC_Click;
			// 
			// btnRevenueUC
			// 
			btnRevenueUC.BackColor = Color.DarkViolet;
			btnRevenueUC.FlatAppearance.CheckedBackColor = Color.Black;
			btnRevenueUC.FlatAppearance.MouseDownBackColor = Color.Black;
			btnRevenueUC.FlatAppearance.MouseOverBackColor = Color.Black;
			btnRevenueUC.FlatStyle = FlatStyle.Flat;
			btnRevenueUC.Font = new Font("Century Gothic", 11.25F);
			btnRevenueUC.ForeColor = SystemColors.Control;
			btnRevenueUC.ImageAlign = ContentAlignment.TopLeft;
			btnRevenueUC.Location = new Point(67, 28);
			btnRevenueUC.Margin = new Padding(3, 2, 3, 2);
			btnRevenueUC.Name = "btnRevenueUC";
			btnRevenueUC.Size = new Size(193, 124);
			btnRevenueUC.TabIndex = 0;
			btnRevenueUC.Text = "Doanh Thu";
			btnRevenueUC.TextAlign = ContentAlignment.BottomLeft;
			btnRevenueUC.UseVisualStyleBackColor = false;
			btnRevenueUC.Click += btnRevenueUC_Click;
			// 
			// TimerClock
			// 
			TimerClock.Enabled = true;
			TimerClock.Interval = 1000;
			TimerClock.Tick += TimerClock_Tick;
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
			btnLogout.Location = new Point(1808, 124);
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
			btnLogout.TabIndex = 8;
			btnLogout.TextAlign = ContentAlignment.MiddleCenter;
			btnLogout.TextAlignment = HorizontalAlignment.Center;
			btnLogout.TextMarginLeft = 0;
			btnLogout.TextPadding = new Padding(0);
			btnLogout.UseDefaultRadiusAndThickness = true;
			btnLogout.Click += btnLogout_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1924, 1050);
			Controls.Add(panel2);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(3, 2, 3, 2);
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Admin";
			FormClosed += MainForm_FormClosed;
			Load += MainForm_Load;
			panel2.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAccountUC;
        private System.Windows.Forms.Button btnCustomerUC;
        private System.Windows.Forms.Button btnStaffUC;
        private System.Windows.Forms.Button btnDataUC;
        private System.Windows.Forms.Button btnRevenueUC;
        private System.Windows.Forms.Panel pnAdmin;
		private Bunifu.UI.WinForms.BunifuLabel userNameAlias;
		private Bunifu.UI.WinForms.BunifuLabel lblTime;
		private System.Windows.Forms.Timer TimerClock;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogout;
	}
}