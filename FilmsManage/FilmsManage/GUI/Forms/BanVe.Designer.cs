namespace FilmsManage
{
    partial class BanVe
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
            flpSeat = new FlowLayoutPanel();
            button1 = new Button();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            lblTime = new Label();
            lblInformation = new Label();
            button2 = new Button();
            label1 = new Label();
            lblPhongChieu = new Label();
            label7 = new Label();
            lblVeChon = new Label();
            label11 = new Label();
            lblTongTien = new Label();
            label13 = new Label();
            lblXuatChieu = new Label();
            label9 = new Label();
            lblPhim = new Label();
            label5 = new Label();
            picFilm = new PictureBox();
            panel1 = new Panel();
            label6 = new Label();
            btnTiepTuc = new Button();
            btnHuy = new Button();
            button5 = new Button();
            label8 = new Label();
            button3 = new Button();
            label4 = new Label();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFilm).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flpSeat
            // 
            flpSeat.Anchor = AnchorStyles.Top;
            flpSeat.AutoScroll = true;
            flpSeat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flpSeat.Location = new Point(79, 154);
            flpSeat.Name = "flpSeat";
            flpSeat.Size = new Size(810, 700);
            flpSeat.TabIndex = 0;
            flpSeat.Paint += flpSeat_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Enabled = false;
            button1.Location = new Point(520, 857);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.Enabled = false;
            button4.Location = new Point(144, 856);
            button4.Name = "button4";
            button4.Size = new Size(30, 30);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(556, 857);
            label2.Name = "label2";
            label2.Size = new Size(95, 29);
            label2.TabIndex = 6;
            label2.Text = "Đã Mua";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 857);
            label3.Name = "label3";
            label3.Size = new Size(128, 29);
            label3.TabIndex = 5;
            label3.Text = "Đang chọn";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 255, 192);
            panel4.Controls.Add(lblTime);
            panel4.Controls.Add(lblInformation);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1428, 72);
            panel4.TabIndex = 5;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(12, 44);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(69, 29);
            lblTime.TabIndex = 2;
            lblTime.Text = "Time";
            // 
            // lblInformation
            // 
            lblInformation.AutoSize = true;
            lblInformation.Location = new Point(12, 9);
            lblInformation.Name = "lblInformation";
            lblInformation.Size = new Size(132, 29);
            lblInformation.TabIndex = 1;
            lblInformation.Text = "Information";
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(57, 78);
            button2.Name = "button2";
            button2.Size = new Size(854, 52);
            button2.TabIndex = 8;
            button2.Text = "Màn hình";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1196, 95);
            label1.Name = "label1";
            label1.Size = new Size(90, 29);
            label1.TabIndex = 9;
            label1.Text = "Lối vào";
            // 
            // lblPhongChieu
            // 
            lblPhongChieu.Location = new Point(191, 421);
            lblPhongChieu.Name = "lblPhongChieu";
            lblPhongChieu.Size = new Size(251, 38);
            lblPhongChieu.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 421);
            label7.Name = "label7";
            label7.Size = new Size(147, 29);
            label7.TabIndex = 18;
            label7.Text = "Phòng chiếu";
            // 
            // lblVeChon
            // 
            lblVeChon.Location = new Point(191, 474);
            lblVeChon.Name = "lblVeChon";
            lblVeChon.Size = new Size(251, 38);
            lblVeChon.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 474);
            label11.Name = "label11";
            label11.Size = new Size(132, 29);
            label11.TabIndex = 20;
            label11.Text = "Số vé chọn";
            // 
            // lblTongTien
            // 
            lblTongTien.Location = new Point(191, 579);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(251, 38);
            lblTongTien.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 588);
            label13.Name = "label13";
            label13.Size = new Size(129, 29);
            label13.TabIndex = 22;
            label13.Text = "Tổng cộng";
            // 
            // lblXuatChieu
            // 
            lblXuatChieu.Location = new Point(191, 373);
            lblXuatChieu.Name = "lblXuatChieu";
            lblXuatChieu.Size = new Size(251, 38);
            lblXuatChieu.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 373);
            label9.Name = "label9";
            label9.Size = new Size(126, 29);
            label9.TabIndex = 16;
            label9.Text = "Xuất chiếu";
            // 
            // lblPhim
            // 
            lblPhim.Location = new Point(191, 328);
            lblPhim.Name = "lblPhim";
            lblPhim.Size = new Size(251, 38);
            lblPhim.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 328);
            label5.Name = "label5";
            label5.Size = new Size(68, 29);
            label5.TabIndex = 12;
            label5.Text = "Phim";
            // 
            // picFilm
            // 
            picFilm.BorderStyle = BorderStyle.FixedSingle;
            picFilm.Location = new Point(113, 32);
            picFilm.Name = "picFilm";
            picFilm.Size = new Size(211, 259);
            picFilm.SizeMode = PictureBoxSizeMode.StretchImage;
            picFilm.TabIndex = 7;
            picFilm.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblTongTien);
            panel1.Controls.Add(picFilm);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblVeChon);
            panel1.Controls.Add(lblPhim);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(lblPhongChieu);
            panel1.Controls.Add(lblXuatChieu);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(961, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 657);
            panel1.TabIndex = 25;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(-68, 544);
            label6.Name = "label6";
            label6.Size = new Size(68, 29);
            label6.TabIndex = 12;
            label6.Text = "Phim";
            // 
            // btnTiepTuc
            // 
            btnTiepTuc.BackColor = Color.FromArgb(255, 128, 255);
            btnTiepTuc.Location = new Point(977, 845);
            btnTiepTuc.Name = "btnTiepTuc";
            btnTiepTuc.Size = new Size(197, 53);
            btnTiepTuc.TabIndex = 26;
            btnTiepTuc.Text = "Tiếp tục";
            btnTiepTuc.UseVisualStyleBackColor = false;
            btnTiepTuc.Click += btnTiepTuc_Click_1;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(255, 128, 0);
            btnHuy.Location = new Point(1207, 845);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(197, 53);
            btnHuy.TabIndex = 27;
            btnHuy.Text = "Quay lại";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Blue;
            button5.Enabled = false;
            button5.Location = new Point(144, 913);
            button5.Name = "button5";
            button5.Size = new Size(30, 30);
            button5.TabIndex = 29;
            button5.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(192, 914);
            label8.Name = "label8";
            label8.Size = new Size(137, 29);
            label8.TabIndex = 28;
            label8.Text = "Ghế thường";
            // 
            // button3
            // 
            button3.BackColor = Color.FloralWhite;
            button3.Enabled = false;
            button3.Location = new Point(520, 913);
            button3.Name = "button3";
            button3.Size = new Size(30, 30);
            button3.TabIndex = 10;
            button3.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(556, 913);
            label4.Name = "label4";
            label4.Size = new Size(101, 29);
            label4.TabIndex = 11;
            label4.Text = "Ghế VIP";
            // 
            // BanVe
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1428, 1050);
            Controls.Add(button5);
            Controls.Add(label8);
            Controls.Add(btnHuy);
            Controls.Add(btnTiepTuc);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(panel4);
            Controls.Add(flpSeat);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "BanVe";
            Text = "Bán Vé";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFilm).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSeat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblInformation;
        private Button button2;
        private Label label1;
        private Label lblPhongChieu;
        private Label label7;
        private Label lblVeChon;
        private Label label11;
        private Label lblTongTien;
        private Label label13;
        private Label lblXuatChieu;
        private Label label9;
        private Label lblPhim;
        private Label label5;
        private PictureBox picFilm;
        private Panel panel1;
        private Label label6;
        private Button btnTiepTuc;
        private Button btnHuy;
        private Button button5;
        private Label label8;
        private Button button3;
        private Label label4;
    }
}