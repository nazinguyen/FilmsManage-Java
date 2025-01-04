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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheLoaiPhimUC));
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
            panel40 = new Panel();
            groupBox1 = new GroupBox();
            btnDeleteGenre = new Guna.UI2.WinForms.Guna2Button();
            btnExport = new Guna.UI2.WinForms.Guna2Button();
            btnUpdateGenre = new Guna.UI2.WinForms.Guna2Button();
            btnInsertGenre = new Guna.UI2.WinForms.Guna2Button();
            grpAccount = new GroupBox();
            txtGenreID = new Guna.UI2.WinForms.Guna2TextBox();
            txtGenreName = new Guna.UI2.WinForms.Guna2TextBox();
            panel1 = new Panel();
            dtgvGenre = new DataGridView();
            panel2 = new Panel();
            dtgvPhim = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            chiTiếtPhimToolStripMenuItem = new ToolStripMenuItem();
            panel40.SuspendLayout();
            groupBox1.SuspendLayout();
            grpAccount.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvGenre).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPhim).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel40
            // 
            panel40.BackColor = Color.White;
            panel40.Controls.Add(groupBox1);
            panel40.Controls.Add(grpAccount);
            panel40.Dock = DockStyle.Top;
            panel40.Location = new Point(0, 0);
            panel40.Margin = new Padding(5, 6, 5, 6);
            panel40.Name = "panel40";
            panel40.Size = new Size(1935, 360);
            panel40.TabIndex = 10;
            panel40.Paint += panel40_Paint;
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
            groupBox1.Location = new Point(56, 235);
            groupBox1.Margin = new Padding(4, 2, 4, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 2, 4, 2);
            groupBox1.Size = new Size(1828, 117);
            groupBox1.TabIndex = 36;
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
            btnDeleteGenre.Location = new Point(796, 38);
            btnDeleteGenre.Margin = new Padding(5, 6, 5, 6);
            btnDeleteGenre.Name = "btnDeleteGenre";
            btnDeleteGenre.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDeleteGenre.Size = new Size(238, 65);
            btnDeleteGenre.TabIndex = 45;
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
            btnExport.Location = new Point(1145, 38);
            btnExport.Margin = new Padding(5, 6, 5, 6);
            btnExport.Name = "btnExport";
            btnExport.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnExport.Size = new Size(238, 65);
            btnExport.TabIndex = 44;
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
            btnUpdateGenre.Location = new Point(440, 38);
            btnUpdateGenre.Margin = new Padding(5, 6, 5, 6);
            btnUpdateGenre.Name = "btnUpdateGenre";
            btnUpdateGenre.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnUpdateGenre.Size = new Size(238, 65);
            btnUpdateGenre.TabIndex = 46;
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
            btnInsertGenre.Location = new Point(82, 38);
            btnInsertGenre.Margin = new Padding(5, 6, 5, 6);
            btnInsertGenre.Name = "btnInsertGenre";
            btnInsertGenre.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnInsertGenre.Size = new Size(238, 65);
            btnInsertGenre.TabIndex = 43;
            btnInsertGenre.Text = "Thêm";
            btnInsertGenre.UseTransparentBackground = true;
            btnInsertGenre.Click += btnInsertGenre_Click;
            // 
            // grpAccount
            // 
            grpAccount.BackColor = Color.White;
            grpAccount.Controls.Add(txtGenreID);
            grpAccount.Controls.Add(txtGenreName);
            grpAccount.FlatStyle = FlatStyle.Popup;
            grpAccount.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpAccount.ForeColor = Color.Black;
            grpAccount.Location = new Point(56, 107);
            grpAccount.Margin = new Padding(4, 2, 4, 2);
            grpAccount.Name = "grpAccount";
            grpAccount.Padding = new Padding(4, 2, 4, 2);
            grpAccount.Size = new Size(1828, 124);
            grpAccount.TabIndex = 35;
            grpAccount.TabStop = false;
            grpAccount.Text = "Thông tin màn hình";
            // 
            // txtGenreID
            // 
            txtGenreID.Animated = true;
            txtGenreID.BorderColor = Color.Black;
            txtGenreID.BorderRadius = 6;
            txtGenreID.Cursor = Cursors.IBeam;
            txtGenreID.CustomizableEdges = customizableEdges9;
            txtGenreID.DefaultText = "";
            txtGenreID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtGenreID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtGenreID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtGenreID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtGenreID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtGenreID.Font = new Font("Segoe UI", 9F);
            txtGenreID.ForeColor = Color.Black;
            txtGenreID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtGenreID.Location = new Point(82, 49);
            txtGenreID.Margin = new Padding(5, 8, 5, 8);
            txtGenreID.Name = "txtGenreID";
            txtGenreID.PasswordChar = '\0';
            txtGenreID.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtGenreID.PlaceholderText = "Mã thể loại";
            txtGenreID.SelectedText = "";
            txtGenreID.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtGenreID.Size = new Size(251, 50);
            txtGenreID.TabIndex = 32;
            // 
            // txtGenreName
            // 
            txtGenreName.Animated = true;
            txtGenreName.BorderColor = Color.Black;
            txtGenreName.BorderRadius = 6;
            txtGenreName.Cursor = Cursors.IBeam;
            txtGenreName.CustomizableEdges = customizableEdges11;
            txtGenreName.DefaultText = "";
            txtGenreName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtGenreName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtGenreName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtGenreName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtGenreName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtGenreName.Font = new Font("Segoe UI", 9F);
            txtGenreName.ForeColor = Color.Black;
            txtGenreName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtGenreName.Location = new Point(440, 50);
            txtGenreName.Margin = new Padding(5, 8, 5, 8);
            txtGenreName.Name = "txtGenreName";
            txtGenreName.PasswordChar = '\0';
            txtGenreName.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtGenreName.PlaceholderText = "Tên thể loại";
            txtGenreName.SelectedText = "";
            txtGenreName.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtGenreName.Size = new Size(251, 49);
            txtGenreName.TabIndex = 10;
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
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dtgvPhim);
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
            dtgvPhim.Location = new Point(9, 4);
            dtgvPhim.Margin = new Padding(4);
            dtgvPhim.Name = "dtgvPhim";
            dtgvPhim.RowHeadersWidth = 62;
            dtgvPhim.Size = new Size(806, 638);
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
            groupBox1.ResumeLayout(false);
            grpAccount.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvGenre).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvPhim).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvGenre;
        private DataGridView dtgvPhim;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem chiTiếtPhimToolStripMenuItem;
        private GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnDeleteGenre;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private Guna.UI2.WinForms.Guna2Button btnUpdateGenre;
        private Guna.UI2.WinForms.Guna2Button btnInsertGenre;
        private GroupBox grpAccount;
        private Guna.UI2.WinForms.Guna2TextBox txtGenreID;
        private Guna.UI2.WinForms.Guna2TextBox txtGenreName;
    }
}
