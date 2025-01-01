namespace FilmsManage.GUI.UserControls.Data
{
    partial class LichChieuUC
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichChieuUC));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            grpAccount = new GroupBox();
            btnExport = new Guna.UI2.WinForms.Guna2Button();
            btnDeleteShowtime = new Guna.UI2.WinForms.Guna2Button();
            btnUpdateShowtime = new Guna.UI2.WinForms.Guna2Button();
            cbbPhongChieu = new Guna.UI2.WinForms.Guna2ComboBox();
            txtSearchShowtime = new Bunifu.UI.WinForms.BunifuTextBox();
            cbbPhim = new Guna.UI2.WinForms.Guna2ComboBox();
            btnInsertShowtime = new Guna.UI2.WinForms.Guna2Button();
            txtShowtimeID = new Guna.UI2.WinForms.Guna2TextBox();
            groupBox2 = new GroupBox();
            timeEnd = new DateTimePicker();
            label3 = new Label();
            timeStart = new DateTimePicker();
            label6 = new Label();
            dateStart = new DateTimePicker();
            label5 = new Label();
            dtgvShowLichChieu = new DataGridView();
            toolTipCinema = new ToolTip(components);
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            grpAccount.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvShowLichChieu).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(grpAccount);
            panel1.Controls.Add(dtgvShowLichChieu);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1548, 797);
            panel1.TabIndex = 11;
            // 
            // grpAccount
            // 
            grpAccount.BackColor = Color.White;
            grpAccount.Controls.Add(groupBox1);
            grpAccount.Controls.Add(cbbPhongChieu);
            grpAccount.Controls.Add(txtSearchShowtime);
            grpAccount.Controls.Add(cbbPhim);
            grpAccount.Controls.Add(txtShowtimeID);
            grpAccount.Controls.Add(groupBox2);
            grpAccount.FlatStyle = FlatStyle.Popup;
            grpAccount.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpAccount.ForeColor = Color.Black;
            grpAccount.Location = new Point(29, 22);
            grpAccount.Margin = new Padding(3, 2, 3, 2);
            grpAccount.Name = "grpAccount";
            grpAccount.Padding = new Padding(3, 2, 3, 2);
            grpAccount.Size = new Size(1498, 299);
            grpAccount.TabIndex = 57;
            grpAccount.TabStop = false;
            grpAccount.Text = "Thông tin lịch chiếu";
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
            btnExport.Location = new Point(726, 57);
            btnExport.Margin = new Padding(4, 5, 4, 5);
            btnExport.Name = "btnExport";
            btnExport.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnExport.Size = new Size(191, 52);
            btnExport.TabIndex = 59;
            btnExport.Text = "Xuất File";
            btnExport.UseTransparentBackground = true;
            // 
            // btnDeleteShowtime
            // 
            btnDeleteShowtime.Animated = true;
            btnDeleteShowtime.BackColor = Color.Transparent;
            btnDeleteShowtime.BorderRadius = 10;
            btnDeleteShowtime.CustomizableEdges = customizableEdges7;
            btnDeleteShowtime.FillColor = Color.FromArgb(0, 0, 64);
            btnDeleteShowtime.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnDeleteShowtime.ForeColor = Color.White;
            btnDeleteShowtime.HoverState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteShowtime.Image = (Image)resources.GetObject("btnDeleteShowtime.Image");
            btnDeleteShowtime.Location = new Point(490, 57);
            btnDeleteShowtime.Margin = new Padding(4, 5, 4, 5);
            btnDeleteShowtime.Name = "btnDeleteShowtime";
            btnDeleteShowtime.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnDeleteShowtime.Size = new Size(191, 52);
            btnDeleteShowtime.TabIndex = 60;
            btnDeleteShowtime.Text = "Xóa";
            btnDeleteShowtime.UseTransparentBackground = true;
            // 
            // btnUpdateShowtime
            // 
            btnUpdateShowtime.Animated = true;
            btnUpdateShowtime.BackColor = Color.Transparent;
            btnUpdateShowtime.BorderRadius = 10;
            btnUpdateShowtime.CustomizableEdges = customizableEdges5;
            btnUpdateShowtime.FillColor = Color.FromArgb(0, 0, 64);
            btnUpdateShowtime.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnUpdateShowtime.ForeColor = Color.White;
            btnUpdateShowtime.HoverState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdateShowtime.Image = (Image)resources.GetObject("btnUpdateShowtime.Image");
            btnUpdateShowtime.Location = new Point(246, 57);
            btnUpdateShowtime.Margin = new Padding(4, 5, 4, 5);
            btnUpdateShowtime.Name = "btnUpdateShowtime";
            btnUpdateShowtime.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnUpdateShowtime.Size = new Size(191, 52);
            btnUpdateShowtime.TabIndex = 61;
            btnUpdateShowtime.Text = "Sửa";
            btnUpdateShowtime.UseTransparentBackground = true;
            // 
            // cbbPhongChieu
            // 
            cbbPhongChieu.BackColor = Color.Transparent;
            cbbPhongChieu.BorderColor = Color.Black;
            cbbPhongChieu.BorderRadius = 10;
            cbbPhongChieu.CustomizableEdges = customizableEdges9;
            cbbPhongChieu.DrawMode = DrawMode.OwnerDrawFixed;
            cbbPhongChieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbPhongChieu.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbPhongChieu.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbPhongChieu.Font = new Font("Segoe UI", 10F);
            cbbPhongChieu.ForeColor = Color.Gray;
            cbbPhongChieu.ItemHeight = 30;
            cbbPhongChieu.Items.AddRange(new object[] { "Select" });
            cbbPhongChieu.Location = new Point(566, 44);
            cbbPhongChieu.Name = "cbbPhongChieu";
            cbbPhongChieu.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cbbPhongChieu.Size = new Size(175, 36);
            cbbPhongChieu.TabIndex = 15;
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
            txtSearchShowtime.BorderThickness = 3;
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
            txtSearchShowtime.Location = new Point(1260, 73);
            txtSearchShowtime.Margin = new Padding(2);
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
            txtSearchShowtime.Padding = new Padding(2);
            txtSearchShowtime.PasswordChar = '\0';
            txtSearchShowtime.PlaceholderForeColor = Color.Silver;
            txtSearchShowtime.PlaceholderText = "Tìm theo tên phim";
            txtSearchShowtime.ReadOnly = false;
            txtSearchShowtime.ScrollBars = ScrollBars.None;
            txtSearchShowtime.SelectedText = "";
            txtSearchShowtime.SelectionLength = 0;
            txtSearchShowtime.SelectionStart = 0;
            txtSearchShowtime.ShortcutsEnabled = true;
            txtSearchShowtime.Size = new Size(191, 56);
            txtSearchShowtime.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtSearchShowtime.TabIndex = 56;
            txtSearchShowtime.TextAlign = HorizontalAlignment.Left;
            txtSearchShowtime.TextMarginBottom = 0;
            txtSearchShowtime.TextMarginLeft = 3;
            txtSearchShowtime.TextMarginTop = 1;
            txtSearchShowtime.TextPlaceholder = "Tìm theo tên phim";
            txtSearchShowtime.UseSystemPasswordChar = false;
            txtSearchShowtime.WordWrap = true;
            txtSearchShowtime.TextChanged += txtSearchShowtime_TextChanged_1;
            // 
            // cbbPhim
            // 
            cbbPhim.BackColor = Color.Transparent;
            cbbPhim.BorderColor = Color.Black;
            cbbPhim.BorderRadius = 10;
            cbbPhim.CustomizableEdges = customizableEdges11;
            cbbPhim.DrawMode = DrawMode.OwnerDrawFixed;
            cbbPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbPhim.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbPhim.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbPhim.Font = new Font("Segoe UI", 10F);
            cbbPhim.ForeColor = Color.Gray;
            cbbPhim.ItemHeight = 30;
            cbbPhim.Items.AddRange(new object[] { "Select", "Select" });
            cbbPhim.Location = new Point(301, 44);
            cbbPhim.Name = "cbbPhim";
            cbbPhim.ShadowDecoration.CustomizableEdges = customizableEdges12;
            cbbPhim.Size = new Size(175, 36);
            cbbPhim.TabIndex = 14;
            // 
            // btnInsertShowtime
            // 
            btnInsertShowtime.Animated = true;
            btnInsertShowtime.BackColor = Color.Transparent;
            btnInsertShowtime.BorderRadius = 10;
            btnInsertShowtime.CustomizableEdges = customizableEdges1;
            btnInsertShowtime.FillColor = Color.FromArgb(0, 0, 64);
            btnInsertShowtime.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnInsertShowtime.ForeColor = Color.White;
            btnInsertShowtime.HoverState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInsertShowtime.Image = (Image)resources.GetObject("btnInsertShowtime.Image");
            btnInsertShowtime.Location = new Point(7, 57);
            btnInsertShowtime.Margin = new Padding(4, 5, 4, 5);
            btnInsertShowtime.Name = "btnInsertShowtime";
            btnInsertShowtime.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnInsertShowtime.Size = new Size(191, 52);
            btnInsertShowtime.TabIndex = 58;
            btnInsertShowtime.Text = "Thêm";
            btnInsertShowtime.UseTransparentBackground = true;
            // 
            // txtShowtimeID
            // 
            txtShowtimeID.Animated = true;
            txtShowtimeID.BorderColor = Color.Black;
            txtShowtimeID.BorderRadius = 6;
            txtShowtimeID.Cursor = Cursors.IBeam;
            txtShowtimeID.CustomizableEdges = customizableEdges13;
            txtShowtimeID.DefaultText = "";
            txtShowtimeID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtShowtimeID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtShowtimeID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtShowtimeID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtShowtimeID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtShowtimeID.Font = new Font("Segoe UI", 9F);
            txtShowtimeID.ForeColor = Color.Black;
            txtShowtimeID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtShowtimeID.Location = new Point(60, 44);
            txtShowtimeID.Margin = new Padding(4, 6, 4, 6);
            txtShowtimeID.Name = "txtShowtimeID";
            txtShowtimeID.PasswordChar = '\0';
            txtShowtimeID.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtShowtimeID.PlaceholderText = "Mã lịch chiếu";
            txtShowtimeID.SelectedText = "";
            txtShowtimeID.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtShowtimeID.Size = new Size(175, 46);
            txtShowtimeID.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(timeEnd);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(timeStart);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(dateStart);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(60, 120);
            groupBox2.Margin = new Padding(2, 3, 2, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 3, 2, 3);
            groupBox2.Size = new Size(403, 164);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thời gian chiếu";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // timeEnd
            // 
            timeEnd.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeEnd.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeEnd.Format = DateTimePickerFormat.Time;
            timeEnd.Location = new Point(144, 118);
            timeEnd.Margin = new Padding(2, 3, 2, 3);
            timeEnd.Name = "timeEnd";
            timeEnd.ShowUpDown = true;
            timeEnd.Size = new Size(216, 30);
            timeEnd.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 122);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 23);
            label3.TabIndex = 15;
            label3.Text = "Giờ kết thúc:";
            // 
            // timeStart
            // 
            timeStart.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeStart.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeStart.Format = DateTimePickerFormat.Time;
            timeStart.Location = new Point(146, 70);
            timeStart.Margin = new Padding(2, 3, 2, 3);
            timeStart.Name = "timeStart";
            timeStart.ShowUpDown = true;
            timeStart.Size = new Size(216, 30);
            timeStart.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 74);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(116, 23);
            label6.TabIndex = 12;
            label6.Text = "Giờ bắt đầu:";
            // 
            // dateStart
            // 
            dateStart.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateStart.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateStart.Format = DateTimePickerFormat.Short;
            dateStart.Location = new Point(146, 25);
            dateStart.Margin = new Padding(2, 3, 2, 3);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(216, 30);
            dateStart.TabIndex = 14;
            dateStart.ValueChanged += dateStart_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 32);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 23);
            label5.TabIndex = 12;
            label5.Text = "Ngày chiếu:";
            // 
            // dtgvShowLichChieu
            // 
            dtgvShowLichChieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvShowLichChieu.Location = new Point(29, 340);
            dtgvShowLichChieu.Margin = new Padding(2);
            dtgvShowLichChieu.Name = "dtgvShowLichChieu";
            dtgvShowLichChieu.RowHeadersWidth = 62;
            dtgvShowLichChieu.Size = new Size(1498, 426);
            dtgvShowLichChieu.TabIndex = 42;
            dtgvShowLichChieu.CellClick += dtgvShowLichChieu_CellClick;
            // 
            // toolTipCinema
            // 
            toolTipCinema.AutoPopDelay = 5000;
            toolTipCinema.InitialDelay = 100;
            toolTipCinema.ReshowDelay = 100;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnInsertShowtime);
            groupBox1.Controls.Add(btnExport);
            groupBox1.Controls.Add(btnUpdateShowtime);
            groupBox1.Controls.Add(btnDeleteShowtime);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(502, 133);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(954, 151);
            groupBox1.TabIndex = 62;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // LichChieuUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "LichChieuUC";
            Size = new Size(1548, 797);
            panel1.ResumeLayout(false);
            grpAccount.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvShowLichChieu).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTipCinema;
        private DataGridView dtgvShowLichChieu;
        private GroupBox groupBox2;
        private DateTimePicker timeStart;
        private Label label6;
        private DateTimePicker dateStart;
        private Label label5;
        private DateTimePicker timeEnd;
        private Label label3;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearchShowtime;
        private GroupBox grpAccount;
        private Guna.UI2.WinForms.Guna2ComboBox cbbPhim;
        private Guna.UI2.WinForms.Guna2TextBox txtShowtimeID;
        private Guna.UI2.WinForms.Guna2ComboBox cbbPhongChieu;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private Guna.UI2.WinForms.Guna2Button btnDeleteShowtime;
        private Guna.UI2.WinForms.Guna2Button btnUpdateShowtime;
        private Guna.UI2.WinForms.Guna2Button btnInsertShowtime;
        private GroupBox groupBox1;
    }
}
