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
            label7 = new Label();
            txtBasePrice = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvShowLichChieu).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.LightSteelBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtBasePrice);
            panel1.Controls.Add(cbbPhongChieu);
            panel1.Controls.Add(cbbPhim);
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
            cbbPhongChieu.Location = new Point(1348, 461);
            cbbPhongChieu.Name = "cbbPhongChieu";
            cbbPhongChieu.Size = new Size(269, 33);
            cbbPhongChieu.TabIndex = 50;
            // 
            // cbbPhim
            // 
            cbbPhim.FormattingEnabled = true;
            cbbPhim.Location = new Point(1348, 407);
            cbbPhim.Name = "cbbPhim";
            cbbPhim.Size = new Size(269, 33);
            cbbPhim.TabIndex = 49;
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
            groupBox2.Location = new Point(1166, 578);
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
            label2.Location = new Point(1174, 463);
            label2.Name = "label2";
            label2.Size = new Size(146, 26);
            label2.TabIndex = 34;
            label2.Text = "Phòng chiếu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1246, 414);
            label4.Name = "label4";
            label4.Size = new Size(74, 26);
            label4.TabIndex = 37;
            label4.Text = "Phim:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1166, 342);
            label1.Name = "label1";
            label1.Size = new Size(160, 26);
            label1.TabIndex = 38;
            label1.Text = "Mã lịch chiếu:";
            // 
            // txtShowtimeID
            // 
            txtShowtimeID.Location = new Point(1348, 340);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(1174, 521);
            label7.Name = "label7";
            label7.Size = new Size(123, 26);
            label7.TabIndex = 52;
            label7.Text = "Giá cơ bản";
            // 
            // txtBasePrice
            // 
            txtBasePrice.Location = new Point(1348, 519);
            txtBasePrice.Margin = new Padding(3, 4, 3, 4);
            txtBasePrice.Name = "txtBasePrice";
            txtBasePrice.Size = new Size(269, 31);
            txtBasePrice.TabIndex = 51;
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
        private ComboBox cbbPhim;
        private DateTimePicker timeEnd;
        private Label label3;
        private ComboBox cbbPhongChieu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnInsertShowtime;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExport;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDeleteShowtime;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdateShowtime;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearchShowtime;
        private Label label7;
        private TextBox txtBasePrice;
    }
}
