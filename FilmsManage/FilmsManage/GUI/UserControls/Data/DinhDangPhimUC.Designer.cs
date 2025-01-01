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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            grpAccount = new GroupBox();
            cbMaMH = new Guna.UI2.WinForms.Guna2ComboBox();
            txtTenMh = new Guna.UI2.WinForms.Guna2TextBox();
            txtFormatID = new Guna.UI2.WinForms.Guna2TextBox();
            txtTenDangPhim = new Guna.UI2.WinForms.Guna2TextBox();
            panel2 = new Panel();
            dtgvFormat = new DataGridView();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1548, 296);
            panel1.TabIndex = 0;
            // 
            // grpAccount
            // 
            grpAccount.BackColor = Color.White;
            grpAccount.Controls.Add(cbMaMH);
            grpAccount.Controls.Add(txtTenMh);
            grpAccount.Controls.Add(txtFormatID);
            grpAccount.Controls.Add(txtTenDangPhim);
            grpAccount.FlatStyle = FlatStyle.Popup;
            grpAccount.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpAccount.ForeColor = Color.Black;
            grpAccount.Location = new Point(30, 38);
            grpAccount.Margin = new Padding(3, 2, 3, 2);
            grpAccount.Name = "grpAccount";
            grpAccount.Padding = new Padding(3, 2, 3, 2);
            grpAccount.Size = new Size(1485, 126);
            grpAccount.TabIndex = 32;
            grpAccount.TabStop = false;
            grpAccount.Text = "Thông tin định dạng";
            // 
            // cbMaMH
            // 
            cbMaMH.BackColor = Color.Transparent;
            cbMaMH.BorderColor = Color.Black;
            cbMaMH.BorderRadius = 10;
            cbMaMH.CustomizableEdges = customizableEdges1;
            cbMaMH.DrawMode = DrawMode.OwnerDrawFixed;
            cbMaMH.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaMH.FocusedColor = Color.FromArgb(94, 148, 255);
            cbMaMH.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbMaMH.Font = new Font("Segoe UI", 10F);
            cbMaMH.ForeColor = Color.Black;
            cbMaMH.ItemHeight = 30;
            cbMaMH.Location = new Point(701, 40);
            cbMaMH.Name = "cbMaMH";
            cbMaMH.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbMaMH.Size = new Size(203, 36);
            cbMaMH.TabIndex = 15;
            // 
            // txtTenMh
            // 
            txtTenMh.Animated = true;
            txtTenMh.BorderColor = Color.Black;
            txtTenMh.BorderRadius = 6;
            txtTenMh.Cursor = Cursors.IBeam;
            txtTenMh.CustomizableEdges = customizableEdges3;
            txtTenMh.DefaultText = "";
            txtTenMh.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTenMh.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTenMh.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTenMh.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTenMh.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenMh.Font = new Font("Segoe UI", 9F);
            txtTenMh.ForeColor = Color.Black;
            txtTenMh.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenMh.Location = new Point(1038, 40);
            txtTenMh.Margin = new Padding(4, 6, 4, 6);
            txtTenMh.Name = "txtTenMh";
            txtTenMh.PasswordChar = '\0';
            txtTenMh.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtTenMh.PlaceholderText = "Tên màn hình";
            txtTenMh.SelectedText = "";
            txtTenMh.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtTenMh.Size = new Size(203, 56);
            txtTenMh.TabIndex = 35;
            // 
            // txtFormatID
            // 
            txtFormatID.Animated = true;
            txtFormatID.BorderColor = Color.Black;
            txtFormatID.BorderRadius = 6;
            txtFormatID.Cursor = Cursors.IBeam;
            txtFormatID.CustomizableEdges = customizableEdges5;
            txtFormatID.DefaultText = "";
            txtFormatID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtFormatID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtFormatID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtFormatID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtFormatID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFormatID.Font = new Font("Segoe UI", 9F);
            txtFormatID.ForeColor = Color.Black;
            txtFormatID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFormatID.Location = new Point(58, 40);
            txtFormatID.Margin = new Padding(4, 6, 4, 6);
            txtFormatID.Name = "txtFormatID";
            txtFormatID.PasswordChar = '\0';
            txtFormatID.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtFormatID.PlaceholderText = "Mã định dạng";
            txtFormatID.SelectedText = "";
            txtFormatID.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtFormatID.Size = new Size(201, 56);
            txtFormatID.TabIndex = 32;
            // 
            // txtTenDangPhim
            // 
            txtTenDangPhim.Animated = true;
            txtTenDangPhim.BorderColor = Color.Black;
            txtTenDangPhim.BorderRadius = 6;
            txtTenDangPhim.Cursor = Cursors.IBeam;
            txtTenDangPhim.CustomizableEdges = customizableEdges7;
            txtTenDangPhim.DefaultText = "";
            txtTenDangPhim.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTenDangPhim.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTenDangPhim.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTenDangPhim.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTenDangPhim.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenDangPhim.Font = new Font("Segoe UI", 9F);
            txtTenDangPhim.ForeColor = Color.Black;
            txtTenDangPhim.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenDangPhim.Location = new Point(370, 40);
            txtTenDangPhim.Margin = new Padding(4, 6, 4, 6);
            txtTenDangPhim.Name = "txtTenDangPhim";
            txtTenDangPhim.PasswordChar = '\0';
            txtTenDangPhim.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtTenDangPhim.PlaceholderText = "Tên dạng phim";
            txtTenDangPhim.SelectedText = "";
            txtTenDangPhim.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtTenDangPhim.Size = new Size(201, 55);
            txtTenDangPhim.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgvFormat);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 296);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1548, 502);
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
            dtgvFormat.Margin = new Padding(3, 4, 3, 4);
            dtgvFormat.Name = "dtgvFormat";
            dtgvFormat.ReadOnly = true;
            dtgvFormat.RowHeadersWidth = 51;
            dtgvFormat.Size = new Size(1548, 502);
            dtgvFormat.TabIndex = 9;
            dtgvFormat.CellContentClick += dtgvFormat_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(30, 168);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1485, 106);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // DinhDangPhimUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DinhDangPhimUC";
            Size = new Size(1548, 798);
            panel1.ResumeLayout(false);
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
    }
}