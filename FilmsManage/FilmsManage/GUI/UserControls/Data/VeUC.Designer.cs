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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lsvAllListShowTimes = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            dtgvVe = new DataGridView();
            txtSearchShowtime = new Bunifu.UI.WinForms.BunifuTextBox();
            groupBox1 = new GroupBox();
            btnAllListShowTimes = new Guna.UI2.WinForms.Guna2Button();
            btnExport = new Guna.UI2.WinForms.Guna2Button();
            btnShowTimeNotCreateTickets = new Guna.UI2.WinForms.Guna2Button();
            btnAddTicketsByShowTime = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dtgvVe).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lsvAllListShowTimes
            // 
            lsvAllListShowTimes.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvAllListShowTimes.FullRowSelect = true;
            lsvAllListShowTimes.GridLines = true;
            lsvAllListShowTimes.Location = new Point(0, 243);
            lsvAllListShowTimes.Margin = new Padding(3, 4, 3, 4);
            lsvAllListShowTimes.Name = "lsvAllListShowTimes";
            lsvAllListShowTimes.Size = new Size(663, 586);
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
            dtgvVe.Location = new Point(666, 243);
            dtgvVe.Margin = new Padding(2, 2, 2, 2);
            dtgvVe.Name = "dtgvVe";
            dtgvVe.RowHeadersWidth = 62;
            dtgvVe.Size = new Size(665, 586);
            dtgvVe.TabIndex = 10;
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
            txtSearchShowtime.Location = new Point(22, 123);
            txtSearchShowtime.Margin = new Padding(2, 2, 2, 2);
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
            txtSearchShowtime.Padding = new Padding(2, 2, 2, 2);
            txtSearchShowtime.PasswordChar = '\0';
            txtSearchShowtime.PlaceholderForeColor = Color.Silver;
            txtSearchShowtime.PlaceholderText = "Nhập thông tin tìm kiếm";
            txtSearchShowtime.ReadOnly = false;
            txtSearchShowtime.ScrollBars = ScrollBars.None;
            txtSearchShowtime.SelectedText = "";
            txtSearchShowtime.SelectionLength = 0;
            txtSearchShowtime.SelectionStart = 0;
            txtSearchShowtime.ShortcutsEnabled = true;
            txtSearchShowtime.Size = new Size(321, 64);
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
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnAllListShowTimes);
            groupBox1.Controls.Add(txtSearchShowtime);
            groupBox1.Controls.Add(btnExport);
            groupBox1.Controls.Add(btnShowTimeNotCreateTickets);
            groupBox1.Controls.Add(btnAddTicketsByShowTime);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(20, 21);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1288, 202);
            groupBox1.TabIndex = 58;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btnAllListShowTimes
            // 
            btnAllListShowTimes.Animated = true;
            btnAllListShowTimes.BackColor = Color.Transparent;
            btnAllListShowTimes.BorderRadius = 10;
            btnAllListShowTimes.CustomizableEdges = customizableEdges1;
            btnAllListShowTimes.FillColor = Color.FromArgb(0, 0, 64);
            btnAllListShowTimes.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAllListShowTimes.ForeColor = Color.White;
            btnAllListShowTimes.HoverState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAllListShowTimes.Image = (Image)resources.GetObject("btnAllListShowTimes.Image");
            btnAllListShowTimes.Location = new Point(743, 30);
            btnAllListShowTimes.Margin = new Padding(4, 5, 4, 5);
            btnAllListShowTimes.Name = "btnAllListShowTimes";
            btnAllListShowTimes.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAllListShowTimes.Size = new Size(240, 67);
            btnAllListShowTimes.TabIndex = 45;
            btnAllListShowTimes.Text = "Xem tất cả lịch chiếu";
            btnAllListShowTimes.UseTransparentBackground = true;
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
            btnExport.Location = new Point(1047, 30);
            btnExport.Margin = new Padding(4, 5, 4, 5);
            btnExport.Name = "btnExport";
            btnExport.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnExport.Size = new Size(197, 67);
            btnExport.TabIndex = 44;
            btnExport.Text = "Xuất File";
            btnExport.UseTransparentBackground = true;
            // 
            // btnShowTimeNotCreateTickets
            // 
            btnShowTimeNotCreateTickets.Animated = true;
            btnShowTimeNotCreateTickets.BackColor = Color.Transparent;
            btnShowTimeNotCreateTickets.BorderRadius = 10;
            btnShowTimeNotCreateTickets.CustomizableEdges = customizableEdges5;
            btnShowTimeNotCreateTickets.FillColor = Color.FromArgb(0, 0, 64);
            btnShowTimeNotCreateTickets.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnShowTimeNotCreateTickets.ForeColor = Color.White;
            btnShowTimeNotCreateTickets.HoverState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnShowTimeNotCreateTickets.Image = (Image)resources.GetObject("btnShowTimeNotCreateTickets.Image");
            btnShowTimeNotCreateTickets.ImageAlign = HorizontalAlignment.Left;
            btnShowTimeNotCreateTickets.Location = new Point(298, 30);
            btnShowTimeNotCreateTickets.Margin = new Padding(4, 5, 4, 5);
            btnShowTimeNotCreateTickets.Name = "btnShowTimeNotCreateTickets";
            btnShowTimeNotCreateTickets.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnShowTimeNotCreateTickets.Size = new Size(386, 67);
            btnShowTimeNotCreateTickets.TabIndex = 46;
            btnShowTimeNotCreateTickets.Text = "Xem lịch chiếu chưa được tạo";
            btnShowTimeNotCreateTickets.UseTransparentBackground = true;
            // 
            // btnAddTicketsByShowTime
            // 
            btnAddTicketsByShowTime.Animated = true;
            btnAddTicketsByShowTime.BackColor = Color.Transparent;
            btnAddTicketsByShowTime.BorderRadius = 10;
            btnAddTicketsByShowTime.CustomizableEdges = customizableEdges7;
            btnAddTicketsByShowTime.FillColor = Color.FromArgb(0, 0, 64);
            btnAddTicketsByShowTime.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAddTicketsByShowTime.ForeColor = Color.White;
            btnAddTicketsByShowTime.HoverState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddTicketsByShowTime.Image = (Image)resources.GetObject("btnAddTicketsByShowTime.Image");
            btnAddTicketsByShowTime.Location = new Point(22, 30);
            btnAddTicketsByShowTime.Margin = new Padding(4, 5, 4, 5);
            btnAddTicketsByShowTime.Name = "btnAddTicketsByShowTime";
            btnAddTicketsByShowTime.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAddTicketsByShowTime.Size = new Size(218, 67);
            btnAddTicketsByShowTime.TabIndex = 43;
            btnAddTicketsByShowTime.Text = "Tự động thêm vé ";
            btnAddTicketsByShowTime.UseTransparentBackground = true;
            // 
            // VeUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(dtgvVe);
            Controls.Add(lsvAllListShowTimes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "VeUC";
            Size = new Size(1330, 854);
            ((System.ComponentModel.ISupportInitialize)dtgvVe).EndInit();
            groupBox1.ResumeLayout(false);
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
        private Bunifu.UI.WinForms.BunifuTextBox txtSearchShowtime;
        private GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnAllListShowTimes;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private Guna.UI2.WinForms.Guna2Button btnShowTimeNotCreateTickets;
        private Guna.UI2.WinForms.Guna2Button btnAddTicketsByShowTime;
    }
}
