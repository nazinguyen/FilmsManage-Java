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
            panel1 = new Panel();
            cbbPhongChieu = new ComboBox();
            cbbPhim = new ComboBox();
            txtSearchShowtime = new TextBox();
            btnUpdateShowtime = new Button();
            btnDeleteShowtime = new Button();
            btnInsertShowtime = new Button();
            dtgvShowLichChieu = new DataGridView();
            groupBox2 = new GroupBox();
            timeEnd = new DateTimePicker();
            label3 = new Label();
            timeStart = new DateTimePicker();
            label6 = new Label();
            dateStart = new DateTimePicker();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            txtShowtimeID = new TextBox();
            toolTipCinema = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvShowLichChieu).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(cbbPhongChieu);
            panel1.Controls.Add(cbbPhim);
            panel1.Controls.Add(txtSearchShowtime);
            panel1.Controls.Add(btnUpdateShowtime);
            panel1.Controls.Add(btnDeleteShowtime);
            panel1.Controls.Add(btnInsertShowtime);
            panel1.Controls.Add(dtgvShowLichChieu);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtShowtimeID);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1935, 996);
            panel1.TabIndex = 11;
            // 
            // cbbPhongChieu
            // 
            cbbPhongChieu.FormattingEnabled = true;
            cbbPhongChieu.Location = new Point(1348, 473);
            cbbPhongChieu.Name = "cbbPhongChieu";
            cbbPhongChieu.Size = new Size(269, 33);
            cbbPhongChieu.TabIndex = 50;
            // 
            // cbbPhim
            // 
            cbbPhim.FormattingEnabled = true;
            cbbPhim.Location = new Point(1348, 419);
            cbbPhim.Name = "cbbPhim";
            cbbPhim.Size = new Size(269, 33);
            cbbPhim.TabIndex = 49;
            // 
            // txtSearchShowtime
            // 
            txtSearchShowtime.BackColor = SystemColors.ControlLightLight;
            txtSearchShowtime.BorderStyle = BorderStyle.FixedSingle;
            txtSearchShowtime.Location = new Point(736, 263);
            txtSearchShowtime.Margin = new Padding(3, 4, 3, 4);
            txtSearchShowtime.Multiline = true;
            txtSearchShowtime.Name = "txtSearchShowtime";
            txtSearchShowtime.Size = new Size(417, 41);
            txtSearchShowtime.TabIndex = 47;
            txtSearchShowtime.Text = "Tìm theo tên phim...";
            txtSearchShowtime.TextChanged += txtSearchShowtime_TextChanged;
            // 
            // btnUpdateShowtime
            // 
            btnUpdateShowtime.Location = new Point(293, 234);
            btnUpdateShowtime.Margin = new Padding(5, 6, 5, 6);
            btnUpdateShowtime.Name = "btnUpdateShowtime";
            btnUpdateShowtime.Size = new Size(125, 88);
            btnUpdateShowtime.TabIndex = 45;
            btnUpdateShowtime.Text = "Sửa";
            btnUpdateShowtime.UseVisualStyleBackColor = true;
            btnUpdateShowtime.Click += btnUpdateShowtime_Click;
            // 
            // btnDeleteShowtime
            // 
            btnDeleteShowtime.Location = new Point(158, 234);
            btnDeleteShowtime.Margin = new Padding(5, 6, 5, 6);
            btnDeleteShowtime.Name = "btnDeleteShowtime";
            btnDeleteShowtime.Size = new Size(125, 88);
            btnDeleteShowtime.TabIndex = 44;
            btnDeleteShowtime.Text = "Xóa";
            btnDeleteShowtime.UseVisualStyleBackColor = true;
            btnDeleteShowtime.Click += btnDeleteShowtime_Click;
            // 
            // btnInsertShowtime
            // 
            btnInsertShowtime.Location = new Point(23, 234);
            btnInsertShowtime.Margin = new Padding(5, 6, 5, 6);
            btnInsertShowtime.Name = "btnInsertShowtime";
            btnInsertShowtime.Size = new Size(125, 88);
            btnInsertShowtime.TabIndex = 43;
            btnInsertShowtime.Text = "Thêm";
            btnInsertShowtime.UseVisualStyleBackColor = true;
            btnInsertShowtime.Click += btnInsertShowtime_Click_1;
            // 
            // dtgvShowLichChieu
            // 
            dtgvShowLichChieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvShowLichChieu.Location = new Point(0, 340);
            dtgvShowLichChieu.Name = "dtgvShowLichChieu";
            dtgvShowLichChieu.RowHeadersWidth = 62;
            dtgvShowLichChieu.Size = new Size(1153, 656);
            dtgvShowLichChieu.TabIndex = 42;
            dtgvShowLichChieu.CellClick += dtgvShowLichChieu_CellClick;
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
            groupBox2.Location = new Point(1168, 558);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(478, 235);
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
            timeEnd.Location = new Point(180, 147);
            timeEnd.Margin = new Padding(3, 4, 3, 4);
            timeEnd.Name = "timeEnd";
            timeEnd.ShowUpDown = true;
            timeEnd.Size = new Size(269, 35);
            timeEnd.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 153);
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
            timeStart.Location = new Point(183, 87);
            timeStart.Margin = new Padding(3, 4, 3, 4);
            timeStart.Name = "timeStart";
            timeStart.ShowUpDown = true;
            timeStart.Size = new Size(269, 35);
            timeStart.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 93);
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
            dateStart.Location = new Point(183, 31);
            dateStart.Margin = new Padding(3, 4, 3, 4);
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
            label5.Name = "label5";
            label5.Size = new Size(134, 26);
            label5.TabIndex = 12;
            label5.Text = "Ngày chiếu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1174, 475);
            label2.Name = "label2";
            label2.Size = new Size(146, 26);
            label2.TabIndex = 34;
            label2.Text = "Phòng chiếu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1246, 426);
            label4.Name = "label4";
            label4.Size = new Size(74, 26);
            label4.TabIndex = 37;
            label4.Text = "Phim:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1166, 354);
            label1.Name = "label1";
            label1.Size = new Size(160, 26);
            label1.TabIndex = 38;
            label1.Text = "Mã lịch chiếu:";
            // 
            // txtShowtimeID
            // 
            txtShowtimeID.Location = new Point(1348, 352);
            txtShowtimeID.Margin = new Padding(3, 4, 3, 4);
            txtShowtimeID.Name = "txtShowtimeID";
            txtShowtimeID.Size = new Size(269, 31);
            txtShowtimeID.TabIndex = 32;
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "LichChieuUC";
            Size = new Size(1935, 996);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvShowLichChieu).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private Label label2;
        private Label label4;
        private Label label1;
        private TextBox txtShowtimeID;
        private TextBox txtSearchShowtime;
        private Button btnUpdateShowtime;
        private Button btnDeleteShowtime;
        private Button btnInsertShowtime;
        private ComboBox cbbPhim;
        private DateTimePicker timeEnd;
        private Label label3;
        private ComboBox cbbPhongChieu;
    }
}
