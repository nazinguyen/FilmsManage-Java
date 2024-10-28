namespace FilmsManage
{
    partial class LichChieu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            labelX = new Label();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            dtpThoiGian = new DateTimePicker();
            cboFilmName = new ComboBox();
            cboFormatFilm = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            lvLichChieu = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            imageList1 = new ImageList(components);
            timer1 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(labelX);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1027, 72);
            panel2.TabIndex = 9;
            // 
            // labelX
            // 
            labelX.Dock = DockStyle.Fill;
            labelX.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelX.ForeColor = Color.Blue;
            labelX.Location = new Point(0, 0);
            labelX.Margin = new Padding(2, 0, 2, 0);
            labelX.Name = "labelX";
            labelX.Size = new Size(1027, 72);
            labelX.TabIndex = 0;
            labelX.Text = "Lịch Chiếu Phim";
            labelX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 72);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(319, 506);
            panel3.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpThoiGian);
            groupBox1.Controls.Add(cboFilmName);
            groupBox1.Controls.Add(cboFormatFilm);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.FromArgb(192, 0, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(319, 506);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi Tiết:";
            // 
            // dtpThoiGian
            // 
            dtpThoiGian.CustomFormat = "dd/MM/yyyy";
            dtpThoiGian.Format = DateTimePickerFormat.Custom;
            dtpThoiGian.Location = new Point(11, 57);
            dtpThoiGian.Margin = new Padding(2, 3, 2, 3);
            dtpThoiGian.Name = "dtpThoiGian";
            dtpThoiGian.Size = new Size(289, 35);
            dtpThoiGian.TabIndex = 3;
            dtpThoiGian.Value = new DateTime(2018, 4, 15, 10, 8, 45, 0);
            // 
            // cboFilmName
            // 
            cboFilmName.FormattingEnabled = true;
            cboFilmName.Location = new Point(11, 118);
            cboFilmName.Margin = new Padding(2, 3, 2, 3);
            cboFilmName.Name = "cboFilmName";
            cboFilmName.Size = new Size(289, 37);
            cboFilmName.TabIndex = 4;
            // 
            // cboFormatFilm
            // 
            cboFormatFilm.FormattingEnabled = true;
            cboFormatFilm.Location = new Point(11, 182);
            cboFormatFilm.Margin = new Padding(2, 3, 2, 3);
            cboFormatFilm.Name = "cboFormatFilm";
            cboFormatFilm.Size = new Size(289, 37);
            cboFormatFilm.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 90);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(74, 29);
            label6.TabIndex = 4;
            label6.Text = "Phim:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 29);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(124, 29);
            label4.TabIndex = 3;
            label4.Text = "Thời Gian:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 154);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 29);
            label1.TabIndex = 0;
            label1.Text = "Suất Chiếu:";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(319, 72);
            panel4.Margin = new Padding(2, 3, 2, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(708, 506);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(lvLichChieu);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(2, 3, 2, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(708, 506);
            panel5.TabIndex = 15;
            // 
            // lvLichChieu
            // 
            lvLichChieu.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader1, columnHeader3, columnHeader4, columnHeader2 });
            lvLichChieu.Dock = DockStyle.Fill;
            lvLichChieu.FullRowSelect = true;
            lvLichChieu.LargeImageList = imageList1;
            lvLichChieu.Location = new Point(0, 0);
            lvLichChieu.Margin = new Padding(2, 3, 2, 3);
            lvLichChieu.Name = "lvLichChieu";
            lvLichChieu.Size = new Size(708, 506);
            lvLichChieu.SmallImageList = imageList1;
            lvLichChieu.TabIndex = 0;
            lvLichChieu.UseCompatibleStateImageBehavior = false;
            lvLichChieu.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "";
            columnHeader5.Width = 38;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên Phòng Chiếu";
            columnHeader1.Width = 167;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tên Phim";
            columnHeader3.Width = 213;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Giờ Chiếu";
            columnHeader4.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tình Trạng";
            columnHeader2.Width = 150;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 30000;
            // 
            // LichChieu
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1027, 578);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "LichChieu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lịch Chiếu Phim";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.ComboBox cboFilmName;
        private System.Windows.Forms.ComboBox cboFormatFilm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView lvLichChieu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
    }
}