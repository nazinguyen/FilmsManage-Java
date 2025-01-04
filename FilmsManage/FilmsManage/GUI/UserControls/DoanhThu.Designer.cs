namespace FilmsManage.GUI.UserControls
{
    partial class DoanhThu
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
            lblSelectMovie = new Label();
            lblTongDoanhThu = new Label();
            txtDoanhThu = new TextBox();
            lblDenNgay = new Label();
            label1 = new Label();
            dtgvRevenue = new DataGridView();
            MaHD = new DataGridViewTextBoxColumn();
            tenPhim = new DataGridViewTextBoxColumn();
            ngayKc = new DataGridViewTextBoxColumn();
            Soveban = new DataGridViewTextBoxColumn();
            tongDoanhThu = new DataGridViewTextBoxColumn();
            btnReportRevenue = new Button();
            btnShowRevenue = new Button();
            cboSelectMovie = new ComboBox();
            dtmToDate = new DateTimePicker();
            dtmFromDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dtgvRevenue).BeginInit();
            SuspendLayout();
            // 
            // lblSelectMovie
            // 
            lblSelectMovie.AutoSize = true;
            lblSelectMovie.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectMovie.Location = new Point(250, 36);
            lblSelectMovie.Margin = new Padding(4, 0, 4, 0);
            lblSelectMovie.Name = "lblSelectMovie";
            lblSelectMovie.Size = new Size(133, 26);
            lblSelectMovie.TabIndex = 39;
            lblSelectMovie.Text = "Chọn phim:";
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongDoanhThu.Location = new Point(1056, 818);
            lblTongDoanhThu.Margin = new Padding(4, 0, 4, 0);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(181, 26);
            lblTongDoanhThu.TabIndex = 38;
            lblTongDoanhThu.Text = "Tổng doanh thu:";
            // 
            // txtDoanhThu
            // 
            txtDoanhThu.Enabled = false;
            txtDoanhThu.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDoanhThu.Location = new Point(1248, 809);
            txtDoanhThu.Margin = new Padding(4, 5, 4, 5);
            txtDoanhThu.Name = "txtDoanhThu";
            txtDoanhThu.Size = new Size(293, 40);
            txtDoanhThu.TabIndex = 37;
            txtDoanhThu.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            lblDenNgay.Location = new Point(572, 109);
            lblDenNgay.Margin = new Padding(4, 0, 4, 0);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(115, 26);
            lblDenNgay.TabIndex = 36;
            lblDenNgay.Text = "Đến ngày:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label1.Location = new Point(250, 108);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 26);
            label1.TabIndex = 35;
            label1.Text = "Từ ngày:";
            // 
            // dtgvRevenue
            // 
            dtgvRevenue.AllowUserToAddRows = false;
            dtgvRevenue.AllowUserToDeleteRows = false;
            dtgvRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvRevenue.Columns.AddRange(new DataGridViewColumn[] { MaHD, tenPhim, ngayKc, Soveban, tongDoanhThu });
            dtgvRevenue.Location = new Point(179, 188);
            dtgvRevenue.Margin = new Padding(4, 5, 4, 5);
            dtgvRevenue.Name = "dtgvRevenue";
            dtgvRevenue.ReadOnly = true;
            dtgvRevenue.RowHeadersWidth = 62;
            dtgvRevenue.Size = new Size(1291, 577);
            dtgvRevenue.TabIndex = 34;
            // 
            // MaHD
            // 
            MaHD.DataPropertyName = "MaHD";
            MaHD.HeaderText = "Mã Hóa Đơn";
            MaHD.MinimumWidth = 8;
            MaHD.Name = "MaHD";
            MaHD.ReadOnly = true;
            // 
            // tenPhim
            // 
            tenPhim.DataPropertyName = "TenPhim";
            tenPhim.HeaderText = "Tên Phim";
            tenPhim.MinimumWidth = 8;
            tenPhim.Name = "tenPhim";
            tenPhim.ReadOnly = true;
            // 
            // ngayKc
            // 
            ngayKc.DataPropertyName = "NgayKc";
            ngayKc.HeaderText = "Ngày Khởi chiếu";
            ngayKc.MinimumWidth = 8;
            ngayKc.Name = "ngayKc";
            ngayKc.ReadOnly = true;
            // 
            // Soveban
            // 
            Soveban.DataPropertyName = "SoVeBan";
            Soveban.HeaderText = "Số vé bán";
            Soveban.MinimumWidth = 8;
            Soveban.Name = "Soveban";
            Soveban.ReadOnly = true;
            // 
            // tongDoanhThu
            // 
            tongDoanhThu.DataPropertyName = "TongDoanhThu";
            tongDoanhThu.HeaderText = "Tổng doanh thu";
            tongDoanhThu.MinimumWidth = 8;
            tongDoanhThu.Name = "tongDoanhThu";
            tongDoanhThu.ReadOnly = true;
            // 
            // btnReportRevenue
            // 
            btnReportRevenue.AutoSize = true;
            btnReportRevenue.BackColor = Color.FromArgb(133, 19, 33);
            btnReportRevenue.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnReportRevenue.ForeColor = Color.White;
            btnReportRevenue.Location = new Point(1426, 105);
            btnReportRevenue.Margin = new Padding(4, 5, 4, 5);
            btnReportRevenue.Name = "btnReportRevenue";
            btnReportRevenue.Size = new Size(115, 50);
            btnReportRevenue.TabIndex = 32;
            btnReportRevenue.Text = "Báo Cáo";
            btnReportRevenue.UseVisualStyleBackColor = false;
            btnReportRevenue.Click += btnReportRevenue_Click;
            // 
            // btnShowRevenue
            // 
            btnShowRevenue.AutoSize = true;
            btnShowRevenue.BackColor = Color.FromArgb(133, 19, 33);
            btnShowRevenue.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnShowRevenue.ForeColor = Color.White;
            btnShowRevenue.Location = new Point(1194, 105);
            btnShowRevenue.Margin = new Padding(4, 5, 4, 5);
            btnShowRevenue.Name = "btnShowRevenue";
            btnShowRevenue.Size = new Size(149, 50);
            btnShowRevenue.TabIndex = 33;
            btnShowRevenue.Text = "Thống kê";
            btnShowRevenue.UseVisualStyleBackColor = false;
            btnShowRevenue.Click += btnShowRevenue_Click;
            // 
            // cboSelectMovie
            // 
            cboSelectMovie.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSelectMovie.FormattingEnabled = true;
            cboSelectMovie.Location = new Point(408, 39);
            cboSelectMovie.Margin = new Padding(4, 5, 4, 5);
            cboSelectMovie.Name = "cboSelectMovie";
            cboSelectMovie.Size = new Size(452, 33);
            cboSelectMovie.TabIndex = 31;
            // 
            // dtmToDate
            // 
            dtmToDate.Format = DateTimePickerFormat.Custom;
            dtmToDate.Location = new Point(694, 105);
            dtmToDate.Margin = new Padding(4, 5, 4, 5);
            dtmToDate.Name = "dtmToDate";
            dtmToDate.RightToLeft = RightToLeft.No;
            dtmToDate.Size = new Size(166, 31);
            dtmToDate.TabIndex = 29;
            // 
            // dtmFromDate
            // 
            dtmFromDate.Format = DateTimePickerFormat.Custom;
            dtmFromDate.Location = new Point(398, 104);
            dtmFromDate.Margin = new Padding(4, 5, 4, 5);
            dtmFromDate.Name = "dtmFromDate";
            dtmFromDate.RightToLeft = RightToLeft.No;
            dtmFromDate.Size = new Size(166, 31);
            dtmFromDate.TabIndex = 30;
            // 
            // DoanhThu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblSelectMovie);
            Controls.Add(lblTongDoanhThu);
            Controls.Add(txtDoanhThu);
            Controls.Add(lblDenNgay);
            Controls.Add(label1);
            Controls.Add(dtgvRevenue);
            Controls.Add(btnReportRevenue);
            Controls.Add(btnShowRevenue);
            Controls.Add(cboSelectMovie);
            Controls.Add(dtmToDate);
            Controls.Add(dtmFromDate);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DoanhThu";
            Size = new Size(1750, 1016);
            ((System.ComponentModel.ISupportInitialize)dtgvRevenue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSelectMovie;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvRevenue;
        private System.Windows.Forms.Button btnReportRevenue;
        private System.Windows.Forms.Button btnShowRevenue;
        private System.Windows.Forms.ComboBox cboSelectMovie;
        private System.Windows.Forms.DateTimePicker dtmToDate;
        private System.Windows.Forms.DateTimePicker dtmFromDate;
        private DataGridViewTextBoxColumn MaHD;
        private DataGridViewTextBoxColumn tenPhim;
        private DataGridViewTextBoxColumn ngayKc;
        private DataGridViewTextBoxColumn Soveban;
        private DataGridViewTextBoxColumn tongDoanhThu;
    }
}
