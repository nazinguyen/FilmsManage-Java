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
            panel54 = new Panel();
            btnSearchShowtime = new Button();
            txtSearchShowtime = new TextBox();
            btnShowShowtime = new Button();
            btnUpdateShowtime = new Button();
            btnDeleteShowtime = new Button();
            btnInsertShowtime = new Button();
            panel1 = new Panel();
            toolTipCinema = new ToolTip(components);
            groupBox2 = new GroupBox();
            dtmShowtimeTime = new DateTimePicker();
            label6 = new Label();
            dtmShowtimeDate = new DateTimePicker();
            label5 = new Label();
            cboFormatID_Showtime = new ComboBox();
            label3 = new Label();
            cboCinemaID_Showtime = new ComboBox();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            label4 = new Label();
            label1 = new Label();
            txtScreenTypeName_Showtime = new TextBox();
            txtMovieName_Showtime = new TextBox();
            txtTicketPrice_Showtime = new TextBox();
            txtShowtimeID = new TextBox();
            dtgvShowLichChieu = new DataGridView();
            panel54.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvShowLichChieu).BeginInit();
            SuspendLayout();
            // 
            // panel54
            // 
            panel54.Controls.Add(btnSearchShowtime);
            panel54.Controls.Add(txtSearchShowtime);
            panel54.Controls.Add(btnShowShowtime);
            panel54.Controls.Add(btnUpdateShowtime);
            panel54.Controls.Add(btnDeleteShowtime);
            panel54.Controls.Add(btnInsertShowtime);
            panel54.Dock = DockStyle.Top;
            panel54.Location = new Point(0, 0);
            panel54.Margin = new Padding(5, 6, 5, 6);
            panel54.Name = "panel54";
            panel54.Size = new Size(1935, 105);
            panel54.TabIndex = 10;
            // 
            // btnSearchShowtime
            // 
            btnSearchShowtime.Location = new Point(1169, 22);
            btnSearchShowtime.Margin = new Padding(3, 4, 3, 4);
            btnSearchShowtime.Name = "btnSearchShowtime";
            btnSearchShowtime.Size = new Size(33, 42);
            btnSearchShowtime.TabIndex = 7;
            btnSearchShowtime.UseVisualStyleBackColor = true;
            // 
            // txtSearchShowtime
            // 
            txtSearchShowtime.Location = new Point(733, 22);
            txtSearchShowtime.Margin = new Padding(3, 4, 3, 4);
            txtSearchShowtime.Multiline = true;
            txtSearchShowtime.Name = "txtSearchShowtime";
            txtSearchShowtime.Size = new Size(417, 41);
            txtSearchShowtime.TabIndex = 6;
            txtSearchShowtime.Text = "Tìm theo tên phim...";
            // 
            // btnShowShowtime
            // 
            btnShowShowtime.Location = new Point(410, 6);
            btnShowShowtime.Margin = new Padding(5, 6, 5, 6);
            btnShowShowtime.Name = "btnShowShowtime";
            btnShowShowtime.Size = new Size(125, 88);
            btnShowShowtime.TabIndex = 3;
            btnShowShowtime.Text = "Xem";
            btnShowShowtime.UseVisualStyleBackColor = true;
            // 
            // btnUpdateShowtime
            // 
            btnUpdateShowtime.Location = new Point(275, 6);
            btnUpdateShowtime.Margin = new Padding(5, 6, 5, 6);
            btnUpdateShowtime.Name = "btnUpdateShowtime";
            btnUpdateShowtime.Size = new Size(125, 88);
            btnUpdateShowtime.TabIndex = 2;
            btnUpdateShowtime.Text = "Sửa";
            btnUpdateShowtime.UseVisualStyleBackColor = true;
            // 
            // btnDeleteShowtime
            // 
            btnDeleteShowtime.Location = new Point(140, 6);
            btnDeleteShowtime.Margin = new Padding(5, 6, 5, 6);
            btnDeleteShowtime.Name = "btnDeleteShowtime";
            btnDeleteShowtime.Size = new Size(125, 88);
            btnDeleteShowtime.TabIndex = 1;
            btnDeleteShowtime.Text = "Xóa";
            btnDeleteShowtime.UseVisualStyleBackColor = true;
            // 
            // btnInsertShowtime
            // 
            btnInsertShowtime.Location = new Point(5, 6);
            btnInsertShowtime.Margin = new Padding(5, 6, 5, 6);
            btnInsertShowtime.Name = "btnInsertShowtime";
            btnInsertShowtime.Size = new Size(125, 88);
            btnInsertShowtime.TabIndex = 0;
            btnInsertShowtime.Text = "Thêm";
            btnInsertShowtime.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(dtgvShowLichChieu);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(cboFormatID_Showtime);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cboCinemaID_Showtime);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtScreenTypeName_Showtime);
            panel1.Controls.Add(txtMovieName_Showtime);
            panel1.Controls.Add(txtTicketPrice_Showtime);
            panel1.Controls.Add(txtShowtimeID);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 105);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1935, 891);
            panel1.TabIndex = 11;
            // 
            // toolTipCinema
            // 
            toolTipCinema.AutoPopDelay = 5000;
            toolTipCinema.InitialDelay = 100;
            toolTipCinema.ReshowDelay = 100;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtmShowtimeTime);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(dtmShowtimeDate);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(1451, 390);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(478, 154);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thời gian chiếu";
            // 
            // dtmShowtimeTime
            // 
            dtmShowtimeTime.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtmShowtimeTime.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtmShowtimeTime.Format = DateTimePickerFormat.Time;
            dtmShowtimeTime.Location = new Point(183, 87);
            dtmShowtimeTime.Margin = new Padding(3, 4, 3, 4);
            dtmShowtimeTime.Name = "dtmShowtimeTime";
            dtmShowtimeTime.ShowUpDown = true;
            dtmShowtimeTime.Size = new Size(269, 35);
            dtmShowtimeTime.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(37, 97);
            label6.Name = "label6";
            label6.Size = new Size(58, 26);
            label6.TabIndex = 12;
            label6.Text = "Giờ:";
            // 
            // dtmShowtimeDate
            // 
            dtmShowtimeDate.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtmShowtimeDate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtmShowtimeDate.Format = DateTimePickerFormat.Short;
            dtmShowtimeDate.Location = new Point(183, 31);
            dtmShowtimeDate.Margin = new Padding(3, 4, 3, 4);
            dtmShowtimeDate.Name = "dtmShowtimeDate";
            dtmShowtimeDate.Size = new Size(269, 35);
            dtmShowtimeDate.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 39);
            label5.Name = "label5";
            label5.Size = new Size(73, 26);
            label5.TabIndex = 12;
            label5.Text = "Ngày:";
            // 
            // cboFormatID_Showtime
            // 
            cboFormatID_Showtime.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormatID_Showtime.FormattingEnabled = true;
            cboFormatID_Showtime.Location = new Point(1636, 124);
            cboFormatID_Showtime.Margin = new Padding(3, 4, 3, 4);
            cboFormatID_Showtime.Name = "cboFormatID_Showtime";
            cboFormatID_Showtime.Size = new Size(269, 33);
            cboFormatID_Showtime.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1454, 126);
            label3.Name = "label3";
            label3.Size = new Size(163, 26);
            label3.TabIndex = 33;
            label3.Text = "Mã định dạng:";
            // 
            // cboCinemaID_Showtime
            // 
            cboCinemaID_Showtime.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCinemaID_Showtime.FormattingEnabled = true;
            cboCinemaID_Showtime.Location = new Point(1636, 313);
            cboCinemaID_Showtime.Margin = new Padding(3, 4, 3, 4);
            cboCinemaID_Showtime.Name = "cboCinemaID_Showtime";
            cboCinemaID_Showtime.Size = new Size(269, 33);
            cboCinemaID_Showtime.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1454, 315);
            label2.Name = "label2";
            label2.Size = new Size(146, 26);
            label2.TabIndex = 34;
            label2.Text = "Phòng chiếu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(1454, 590);
            label7.Name = "label7";
            label7.Size = new Size(85, 26);
            label7.TabIndex = 35;
            label7.Text = "Giá vé:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1454, 230);
            label8.Name = "label8";
            label8.Size = new Size(120, 26);
            label8.TabIndex = 36;
            label8.Text = "Màn hình:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1454, 180);
            label4.Name = "label4";
            label4.Size = new Size(74, 26);
            label4.TabIndex = 37;
            label4.Text = "Phim:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1454, 32);
            label1.Name = "label1";
            label1.Size = new Size(160, 26);
            label1.TabIndex = 38;
            label1.Text = "Mã lịch chiếu:";
            // 
            // txtScreenTypeName_Showtime
            // 
            txtScreenTypeName_Showtime.Location = new Point(1636, 224);
            txtScreenTypeName_Showtime.Margin = new Padding(3, 4, 3, 4);
            txtScreenTypeName_Showtime.Name = "txtScreenTypeName_Showtime";
            txtScreenTypeName_Showtime.ReadOnly = true;
            txtScreenTypeName_Showtime.Size = new Size(269, 31);
            txtScreenTypeName_Showtime.TabIndex = 29;
            // 
            // txtMovieName_Showtime
            // 
            txtMovieName_Showtime.Location = new Point(1636, 174);
            txtMovieName_Showtime.Margin = new Padding(3, 4, 3, 4);
            txtMovieName_Showtime.Name = "txtMovieName_Showtime";
            txtMovieName_Showtime.ReadOnly = true;
            txtMovieName_Showtime.Size = new Size(269, 31);
            txtMovieName_Showtime.TabIndex = 30;
            // 
            // txtTicketPrice_Showtime
            // 
            txtTicketPrice_Showtime.Location = new Point(1636, 594);
            txtTicketPrice_Showtime.Margin = new Padding(3, 4, 3, 4);
            txtTicketPrice_Showtime.Name = "txtTicketPrice_Showtime";
            txtTicketPrice_Showtime.Size = new Size(269, 31);
            txtTicketPrice_Showtime.TabIndex = 31;
            // 
            // txtShowtimeID
            // 
            txtShowtimeID.Location = new Point(1636, 32);
            txtShowtimeID.Margin = new Padding(3, 4, 3, 4);
            txtShowtimeID.Name = "txtShowtimeID";
            txtShowtimeID.Size = new Size(269, 31);
            txtShowtimeID.TabIndex = 32;
            // 
            // dtgvShowLichChieu
            // 
            dtgvShowLichChieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvShowLichChieu.Location = new Point(3, 3);
            dtgvShowLichChieu.Name = "dtgvShowLichChieu";
            dtgvShowLichChieu.RowHeadersWidth = 62;
            dtgvShowLichChieu.Size = new Size(1400, 656);
            dtgvShowLichChieu.TabIndex = 42;
            // 
            // LichChieuUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel54);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LichChieuUC";
            Size = new Size(1935, 996);
            panel54.ResumeLayout(false);
            panel54.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvShowLichChieu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel54;
        private System.Windows.Forms.Button btnSearchShowtime;
        private System.Windows.Forms.TextBox txtSearchShowtime;
        private System.Windows.Forms.Button btnShowShowtime;
        private System.Windows.Forms.Button btnUpdateShowtime;
        private System.Windows.Forms.Button btnDeleteShowtime;
        private System.Windows.Forms.Button btnInsertShowtime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTipCinema;
        private DataGridView dtgvShowLichChieu;
        private GroupBox groupBox2;
        private DateTimePicker dtmShowtimeTime;
        private Label label6;
        private DateTimePicker dtmShowtimeDate;
        private Label label5;
        private ComboBox cboFormatID_Showtime;
        private Label label3;
        private ComboBox cboCinemaID_Showtime;
        private Label label2;
        private Label label7;
        private Label label8;
        private Label label4;
        private Label label1;
        private TextBox txtScreenTypeName_Showtime;
        private TextBox txtMovieName_Showtime;
        private TextBox txtTicketPrice_Showtime;
        private TextBox txtShowtimeID;
    }
}
