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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DinhDangPhimUC));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            btnDeleteGenre = new Guna.UI2.WinForms.Guna2Button();
            btnExport = new Guna.UI2.WinForms.Guna2Button();
            btnUpdateGenre = new Guna.UI2.WinForms.Guna2Button();
            btnInsertGenre = new Guna.UI2.WinForms.Guna2Button();
            grpAccount = new GroupBox();
            cbMaMH = new Guna.UI2.WinForms.Guna2ComboBox();
            txtFormatID = new Guna.UI2.WinForms.Guna2TextBox();
            txtTenDangPhim = new Guna.UI2.WinForms.Guna2TextBox();
            panel2 = new Panel();
            dtgvFormat = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            grpAccount.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFormat).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(grpAccount);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1935, 370);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnDeleteGenre);
            groupBox1.Controls.Add(btnExport);
            groupBox1.Controls.Add(btnUpdateGenre);
            groupBox1.Controls.Add(btnInsertGenre);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(32, 257);
            groupBox1.Margin = new Padding(4, 2, 4, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 2, 4, 2);
            groupBox1.Size = new Size(1856, 96);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btnDeleteGenre
            // 
            btnDeleteGenre.Animated = true;
            btnDeleteGenre.BackColor = Color.Transparent;
            btnDeleteGenre.BorderRadius = 10;
            btnDeleteGenre.CustomizableEdges = customizableEdges1;
            btnDeleteGenre.FillColor = Color.FromArgb(0, 0, 64);
            btnDeleteGenre.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnDeleteGenre.ForeColor = Color.White;
            btnDeleteGenre.HoverState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteGenre.Image = (Image)resources.GetObject("btnDeleteGenre.Image");
            btnDeleteGenre.Location = new Point(591, 34);
            btnDeleteGenre.Margin = new Padding(5, 6, 5, 6);
            btnDeleteGenre.Name = "btnDeleteGenre";
            btnDeleteGenre.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDeleteGenre.Size = new Size(202, 54);
            btnDeleteGenre.TabIndex = 49;
            btnDeleteGenre.Text = "Xóa";
            btnDeleteGenre.UseTransparentBackground = true;
            btnDeleteGenre.Click += btnDeleteGenre_Click;
            // 
            // btnExport
            // 
            btnExport.Animated = true;
            btnExport.BackColor = Color.Transparent;
            btnExport.BorderRadius = 10;
            btnExport.CustomizableEdges = customizableEdges3;
            btnExport.FillColor = Color.FromArgb(0, 0, 64);
            btnExport.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.HoverState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExport.Image = (Image)resources.GetObject("btnExport.Image");
            btnExport.Location = new Point(820, 34);
            btnExport.Margin = new Padding(5, 6, 5, 6);
            btnExport.Name = "btnExport";
            btnExport.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnExport.Size = new Size(202, 54);
            btnExport.TabIndex = 48;
            btnExport.Text = "Xuất File";
            btnExport.UseTransparentBackground = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnUpdateGenre
            // 
            btnUpdateGenre.Animated = true;
            btnUpdateGenre.BackColor = Color.Transparent;
            btnUpdateGenre.BorderRadius = 10;
            btnUpdateGenre.CustomizableEdges = customizableEdges5;
            btnUpdateGenre.FillColor = Color.FromArgb(0, 0, 64);
            btnUpdateGenre.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnUpdateGenre.ForeColor = Color.White;
            btnUpdateGenre.HoverState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdateGenre.Image = (Image)resources.GetObject("btnUpdateGenre.Image");
            btnUpdateGenre.Location = new Point(345, 34);
            btnUpdateGenre.Margin = new Padding(5, 6, 5, 6);
            btnUpdateGenre.Name = "btnUpdateGenre";
            btnUpdateGenre.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnUpdateGenre.Size = new Size(202, 54);
            btnUpdateGenre.TabIndex = 50;
            btnUpdateGenre.Text = "Sửa";
            btnUpdateGenre.UseTransparentBackground = true;
            btnUpdateGenre.Click += btnUpdateGenre_Click;
            // 
            // btnInsertGenre
            // 
            btnInsertGenre.Animated = true;
            btnInsertGenre.BackColor = Color.Transparent;
            btnInsertGenre.BorderRadius = 10;
            btnInsertGenre.CustomizableEdges = customizableEdges7;
            btnInsertGenre.FillColor = Color.FromArgb(0, 0, 64);
            btnInsertGenre.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnInsertGenre.ForeColor = Color.White;
            btnInsertGenre.HoverState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInsertGenre.Image = (Image)resources.GetObject("btnInsertGenre.Image");
            btnInsertGenre.Location = new Point(104, 34);
            btnInsertGenre.Margin = new Padding(5, 6, 5, 6);
            btnInsertGenre.Name = "btnInsertGenre";
            btnInsertGenre.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnInsertGenre.Size = new Size(202, 54);
            btnInsertGenre.TabIndex = 47;
            btnInsertGenre.Text = "Thêm";
            btnInsertGenre.UseTransparentBackground = true;
            btnInsertGenre.Click += btnInsertGenre_Click;
            // 
            // grpAccount
            // 
            grpAccount.BackColor = Color.White;
            grpAccount.Controls.Add(cbMaMH);
            grpAccount.Controls.Add(txtFormatID);
            grpAccount.Controls.Add(txtTenDangPhim);
            grpAccount.FlatStyle = FlatStyle.Popup;
            grpAccount.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpAccount.ForeColor = Color.Black;
            grpAccount.Location = new Point(32, 122);
            grpAccount.Margin = new Padding(4, 2, 4, 2);
            grpAccount.Name = "grpAccount";
            grpAccount.Padding = new Padding(4, 2, 4, 2);
            grpAccount.Size = new Size(1856, 122);
            grpAccount.TabIndex = 32;
            grpAccount.TabStop = false;
            grpAccount.Text = "Thông tin định dạng";
            // 
            // cbMaMH
            // 
            cbMaMH.BackColor = Color.Transparent;
            cbMaMH.BorderColor = Color.Black;
            cbMaMH.BorderRadius = 10;
            cbMaMH.CustomizableEdges = customizableEdges9;
            cbMaMH.DrawMode = DrawMode.OwnerDrawFixed;
            cbMaMH.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaMH.FocusedColor = Color.FromArgb(94, 148, 255);
            cbMaMH.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbMaMH.Font = new Font("Segoe UI", 10F);
            cbMaMH.ForeColor = Color.Black;
            cbMaMH.ItemHeight = 30;
            cbMaMH.Location = new Point(870, 62);
            cbMaMH.Margin = new Padding(4);
            cbMaMH.Name = "cbMaMH";
            cbMaMH.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cbMaMH.Size = new Size(253, 36);
            cbMaMH.TabIndex = 15;
            // 
            // txtFormatID
            // 
            txtFormatID.Animated = true;
            txtFormatID.BorderColor = Color.Black;
            txtFormatID.BorderRadius = 6;
            txtFormatID.Cursor = Cursors.IBeam;
            txtFormatID.CustomizableEdges = customizableEdges11;
            txtFormatID.DefaultText = "";
            txtFormatID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtFormatID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtFormatID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtFormatID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtFormatID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFormatID.Font = new Font("Segoe UI", 9F);
            txtFormatID.ForeColor = Color.Black;
            txtFormatID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFormatID.Location = new Point(72, 50);
            txtFormatID.Margin = new Padding(5, 8, 5, 8);
            txtFormatID.Name = "txtFormatID";
            txtFormatID.PasswordChar = '\0';
            txtFormatID.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtFormatID.PlaceholderText = "Mã định dạng";
            txtFormatID.SelectedText = "";
            txtFormatID.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtFormatID.Size = new Size(251, 48);
            txtFormatID.TabIndex = 32;
            // 
            // txtTenDangPhim
            // 
            txtTenDangPhim.Animated = true;
            txtTenDangPhim.BorderColor = Color.Black;
            txtTenDangPhim.BorderRadius = 6;
            txtTenDangPhim.Cursor = Cursors.IBeam;
            txtTenDangPhim.CustomizableEdges = customizableEdges13;
            txtTenDangPhim.DefaultText = "";
            txtTenDangPhim.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTenDangPhim.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTenDangPhim.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTenDangPhim.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTenDangPhim.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenDangPhim.Font = new Font("Segoe UI", 9F);
            txtTenDangPhim.ForeColor = Color.Black;
            txtTenDangPhim.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenDangPhim.Location = new Point(462, 50);
            txtTenDangPhim.Margin = new Padding(5, 8, 5, 8);
            txtTenDangPhim.Name = "txtTenDangPhim";
            txtTenDangPhim.PasswordChar = '\0';
            txtTenDangPhim.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtTenDangPhim.PlaceholderText = "Tên dạng phim";
            txtTenDangPhim.SelectedText = "";
            txtTenDangPhim.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtTenDangPhim.Size = new Size(251, 48);
            txtTenDangPhim.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgvFormat);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 370);
            panel2.Margin = new Padding(5, 6, 5, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1935, 628);
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
            dtgvFormat.Size = new Size(1935, 628);
            dtgvFormat.TabIndex = 9;
            dtgvFormat.CellContentClick += dtgvFormat_CellContentClick;
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
            groupBox1.ResumeLayout(false);
            grpAccount.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFormat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteFormat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvFormat;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnInsertFormat;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnShowFormat;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdateFormat;
        private GroupBox grpAccount;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaMH;
        private Guna.UI2.WinForms.Guna2TextBox txtTenMh;
        private Guna.UI2.WinForms.Guna2TextBox txtFormatID;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDangPhim;
        private GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnDeleteGenre;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private Guna.UI2.WinForms.Guna2Button btnUpdateGenre;
        private Guna.UI2.WinForms.Guna2Button btnInsertGenre;
    }
}