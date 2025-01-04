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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichChieuUC));
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            grpAccount = new GroupBox();
            txtBasePrice = new Guna.UI2.WinForms.Guna2TextBox();
            groupBox1 = new GroupBox();
            btnInsertShowtime = new Guna.UI2.WinForms.Guna2Button();
            btnExport = new Guna.UI2.WinForms.Guna2Button();
            btnUpdateShowtime = new Guna.UI2.WinForms.Guna2Button();
            btnDeleteShowtime = new Guna.UI2.WinForms.Guna2Button();
            cbbPhongChieu = new Guna.UI2.WinForms.Guna2ComboBox();
            cbbPhim = new Guna.UI2.WinForms.Guna2ComboBox();
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
            panel1.SuspendLayout();
            grpAccount.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvShowLichChieu).BeginInit();
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
            panel1.Margin = new Padding(2, 4, 2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1935, 996);
            panel1.TabIndex = 11;
            // 
            // grpAccount
            // 
            grpAccount.BackColor = Color.White;
            grpAccount.Controls.Add(txtBasePrice);
            grpAccount.Controls.Add(groupBox1);
            grpAccount.Controls.Add(cbbPhongChieu);
            grpAccount.Controls.Add(cbbPhim);
            grpAccount.Controls.Add(txtShowtimeID);
            grpAccount.Controls.Add(groupBox2);
            grpAccount.FlatStyle = FlatStyle.Popup;
            grpAccount.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpAccount.ForeColor = Color.Black;
            grpAccount.Location = new Point(4, 117);
            grpAccount.Margin = new Padding(4, 2, 4, 2);
            grpAccount.Name = "grpAccount";
            grpAccount.Padding = new Padding(4, 2, 4, 2);
            grpAccount.Size = new Size(1656, 325);
            grpAccount.TabIndex = 57;
            grpAccount.TabStop = false;
            grpAccount.Text = "Thông tin lịch chiếu";
            // 
            // txtBasePrice
            // 
            txtBasePrice.Animated = true;
            txtBasePrice.BorderColor = Color.Black;
            txtBasePrice.BorderRadius = 6;
            txtBasePrice.Cursor = Cursors.IBeam;
            txtBasePrice.CustomizableEdges = customizableEdges1;
            txtBasePrice.DefaultText = "";
            txtBasePrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBasePrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBasePrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBasePrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBasePrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBasePrice.Font = new Font("Segoe UI", 9F);
            txtBasePrice.ForeColor = Color.Black;
            txtBasePrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBasePrice.Location = new Point(877, 57);
            txtBasePrice.Margin = new Padding(5, 8, 5, 8);
            txtBasePrice.Name = "txtBasePrice";
            txtBasePrice.PasswordChar = '\0';
            txtBasePrice.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtBasePrice.PlaceholderText = "Giá gốc";
            txtBasePrice.SelectedText = "";
            txtBasePrice.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtBasePrice.Size = new Size(219, 36);
            txtBasePrice.TabIndex = 63;
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
            groupBox1.Location = new Point(630, 121);
            groupBox1.Margin = new Padding(4, 2, 4, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 2, 4, 2);
            groupBox1.Size = new Size(925, 189);
            groupBox1.TabIndex = 62;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btnInsertShowtime
            // 
            btnInsertShowtime.Animated = true;
            btnInsertShowtime.BackColor = Color.Transparent;
            btnInsertShowtime.BorderRadius = 10;
            btnInsertShowtime.CustomizableEdges = customizableEdges3;
            btnInsertShowtime.FillColor = Color.FromArgb(0, 0, 64);
            btnInsertShowtime.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnInsertShowtime.ForeColor = Color.White;
            btnInsertShowtime.HoverState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInsertShowtime.Image = (Image)resources.GetObject("btnInsertShowtime.Image");
            btnInsertShowtime.Location = new Point(19, 72);
            btnInsertShowtime.Margin = new Padding(5, 6, 5, 6);
            btnInsertShowtime.Name = "btnInsertShowtime";
            btnInsertShowtime.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnInsertShowtime.Size = new Size(204, 65);
            btnInsertShowtime.TabIndex = 58;
            btnInsertShowtime.Text = "Thêm";
            btnInsertShowtime.UseTransparentBackground = true;
            btnInsertShowtime.Click += btnInsertShowtime_Click_1;
            // 
            // btnExport
            // 
            btnExport.Animated = true;
            btnExport.BackColor = Color.Transparent;
            btnExport.BorderRadius = 10;
            btnExport.CustomizableEdges = customizableEdges5;
            btnExport.FillColor = Color.FromArgb(0, 0, 64);
            btnExport.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.HoverState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExport.Image = (Image)resources.GetObject("btnExport.Image");
            btnExport.Location = new Point(664, 71);
            btnExport.Margin = new Padding(5, 6, 5, 6);
            btnExport.Name = "btnExport";
            btnExport.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnExport.Size = new Size(194, 65);
            btnExport.TabIndex = 59;
            btnExport.Text = "Xuất File";
            btnExport.UseTransparentBackground = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnUpdateShowtime
            // 
            btnUpdateShowtime.Animated = true;
            btnUpdateShowtime.BackColor = Color.Transparent;
            btnUpdateShowtime.BorderRadius = 10;
            btnUpdateShowtime.CustomizableEdges = customizableEdges7;
            btnUpdateShowtime.FillColor = Color.FromArgb(0, 0, 64);
            btnUpdateShowtime.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnUpdateShowtime.ForeColor = Color.White;
            btnUpdateShowtime.HoverState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdateShowtime.Image = (Image)resources.GetObject("btnUpdateShowtime.Image");
            btnUpdateShowtime.Location = new Point(247, 71);
            btnUpdateShowtime.Margin = new Padding(5, 6, 5, 6);
            btnUpdateShowtime.Name = "btnUpdateShowtime";
            btnUpdateShowtime.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnUpdateShowtime.Size = new Size(188, 65);
            btnUpdateShowtime.TabIndex = 61;
            btnUpdateShowtime.Text = "Sửa";
            btnUpdateShowtime.UseTransparentBackground = true;
            btnUpdateShowtime.Click += btnUpdateShowtime_Click;
            // 
            // btnDeleteShowtime
            // 
            btnDeleteShowtime.Animated = true;
            btnDeleteShowtime.BackColor = Color.Transparent;
            btnDeleteShowtime.BorderRadius = 10;
            btnDeleteShowtime.CustomizableEdges = customizableEdges9;
            btnDeleteShowtime.FillColor = Color.FromArgb(0, 0, 64);
            btnDeleteShowtime.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnDeleteShowtime.ForeColor = Color.White;
            btnDeleteShowtime.HoverState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteShowtime.Image = (Image)resources.GetObject("btnDeleteShowtime.Image");
            btnDeleteShowtime.Location = new Point(464, 72);
            btnDeleteShowtime.Margin = new Padding(5, 6, 5, 6);
            btnDeleteShowtime.Name = "btnDeleteShowtime";
            btnDeleteShowtime.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnDeleteShowtime.Size = new Size(175, 65);
            btnDeleteShowtime.TabIndex = 60;
            btnDeleteShowtime.Text = "Xóa";
            btnDeleteShowtime.UseTransparentBackground = true;
            btnDeleteShowtime.Click += btnDeleteShowtime_Click;
            // 
            // cbbPhongChieu
            // 
            cbbPhongChieu.BackColor = Color.Transparent;
            cbbPhongChieu.BorderColor = Color.Black;
            cbbPhongChieu.BorderRadius = 10;
            cbbPhongChieu.CustomizableEdges = customizableEdges11;
            cbbPhongChieu.DrawMode = DrawMode.OwnerDrawFixed;
            cbbPhongChieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbPhongChieu.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbPhongChieu.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbPhongChieu.Font = new Font("Segoe UI", 10F);
            cbbPhongChieu.ForeColor = Color.Gray;
            cbbPhongChieu.ItemHeight = 30;
            cbbPhongChieu.Items.AddRange(new object[] { "Select" });
            cbbPhongChieu.Location = new Point(620, 57);
            cbbPhongChieu.Margin = new Padding(4);
            cbbPhongChieu.Name = "cbbPhongChieu";
            cbbPhongChieu.ShadowDecoration.CustomizableEdges = customizableEdges12;
            cbbPhongChieu.Size = new Size(218, 36);
            cbbPhongChieu.TabIndex = 15;
            // 
            // cbbPhim
            // 
            cbbPhim.BackColor = Color.Transparent;
            cbbPhim.BorderColor = Color.Black;
            cbbPhim.BorderRadius = 10;
            cbbPhim.CustomizableEdges = customizableEdges13;
            cbbPhim.DrawMode = DrawMode.OwnerDrawFixed;
            cbbPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbPhim.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbPhim.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbPhim.Font = new Font("Segoe UI", 10F);
            cbbPhim.ForeColor = Color.Gray;
            cbbPhim.ItemHeight = 30;
            cbbPhim.Items.AddRange(new object[] { "Select", "Select" });
            cbbPhim.Location = new Point(344, 57);
            cbbPhim.Margin = new Padding(4);
            cbbPhim.Name = "cbbPhim";
            cbbPhim.ShadowDecoration.CustomizableEdges = customizableEdges14;
            cbbPhim.Size = new Size(218, 36);
            cbbPhim.TabIndex = 14;
            // 
            // txtShowtimeID
            // 
            txtShowtimeID.Animated = true;
            txtShowtimeID.BorderColor = Color.Black;
            txtShowtimeID.BorderRadius = 6;
            txtShowtimeID.Cursor = Cursors.IBeam;
            txtShowtimeID.CustomizableEdges = customizableEdges15;
            txtShowtimeID.DefaultText = "";
            txtShowtimeID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtShowtimeID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtShowtimeID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtShowtimeID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtShowtimeID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtShowtimeID.Font = new Font("Segoe UI", 9F);
            txtShowtimeID.ForeColor = Color.Black;
            txtShowtimeID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtShowtimeID.Location = new Point(77, 57);
            txtShowtimeID.Margin = new Padding(5, 8, 5, 8);
            txtShowtimeID.Name = "txtShowtimeID";
            txtShowtimeID.PasswordChar = '\0';
            txtShowtimeID.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtShowtimeID.PlaceholderText = "Mã lịch chiếu";
            txtShowtimeID.SelectedText = "";
            txtShowtimeID.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtShowtimeID.Size = new Size(219, 36);
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
            groupBox2.Location = new Point(77, 105);
            groupBox2.Margin = new Padding(2, 4, 2, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 4, 2, 4);
            groupBox2.Size = new Size(504, 205);
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
            timeEnd.Location = new Point(180, 148);
            timeEnd.Margin = new Padding(2, 4, 2, 4);
            timeEnd.Name = "timeEnd";
            timeEnd.ShowUpDown = true;
            timeEnd.Size = new Size(269, 35);
            timeEnd.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 152);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 26);
            label3.TabIndex = 15;
            label3.Text = "Giờ kết thúc:";
            // 
            // timeStart
            // 
            timeStart.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeStart.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeStart.Format = DateTimePickerFormat.Time;
            timeStart.Location = new Point(182, 88);
            timeStart.Margin = new Padding(2, 4, 2, 4);
            timeStart.Name = "timeStart";
            timeStart.ShowUpDown = true;
            timeStart.Size = new Size(269, 35);
            timeStart.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 92);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(141, 26);
            label6.TabIndex = 12;
            label6.Text = "Giờ bắt đầu:";
            // 
            // dateStart
            // 
            dateStart.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateStart.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateStart.Format = DateTimePickerFormat.Short;
            dateStart.Location = new Point(182, 31);
            dateStart.Margin = new Padding(2, 4, 2, 4);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(269, 35);
            dateStart.TabIndex = 14;
            dateStart.ValueChanged += dateStart_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 40);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(134, 26);
            label5.TabIndex = 12;
            label5.Text = "Ngày chiếu:";
            // 
            // dtgvShowLichChieu
            // 
            dtgvShowLichChieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvShowLichChieu.Location = new Point(0, 458);
            dtgvShowLichChieu.Margin = new Padding(2);
            dtgvShowLichChieu.Name = "dtgvShowLichChieu";
            dtgvShowLichChieu.RowHeadersWidth = 62;
            dtgvShowLichChieu.Size = new Size(1660, 532);
            dtgvShowLichChieu.TabIndex = 42;
            dtgvShowLichChieu.CellClick += dtgvShowLichChieu_CellClick;
            // 
            // toolTipCinema
            // 
            toolTipCinema.AutoPopDelay = 5000;
            toolTipCinema.InitialDelay = 100;
            toolTipCinema.ReshowDelay = 100;
            // 
            // LichChieuUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2, 4, 2, 4);
            Name = "LichChieuUC";
            Size = new Size(1935, 996);
            panel1.ResumeLayout(false);
            grpAccount.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvShowLichChieu).EndInit();
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
        private Guna.UI2.WinForms.Guna2TextBox txtBasePrice;
    }
}
