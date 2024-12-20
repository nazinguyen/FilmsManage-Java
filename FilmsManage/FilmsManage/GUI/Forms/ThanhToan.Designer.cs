namespace FilmsManage.GUI.Forms
{
    partial class ThanhToan
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
			panel1 = new Panel();
			panel6 = new Panel();
			txtHoTen = new TextBox();
			panel5 = new Panel();
			txtDienThoai = new TextBox();
			btnQuayLai = new Button();
			btnThanhToan = new Button();
			label12 = new Label();
			label5 = new Label();
			cbKH = new CheckBox();
			label1 = new Label();
			panel2 = new Panel();
			label2 = new Label();
			panel3 = new Panel();
			panel4 = new Panel();
			lblTongTien = new Label();
			label14 = new Label();
			lblGheThuong = new Label();
			label11 = new Label();
			lblGheVIP = new Label();
			label10 = new Label();
			lblViTri = new Label();
			label9 = new Label();
			lblPhongChieu = new Label();
			label8 = new Label();
			lblGioChieu = new Label();
			label7 = new Label();
			lblNgayChieu = new Label();
			label6 = new Label();
			lblPhim = new Label();
			label4 = new Label();
			label3 = new Label();
			panel1.SuspendLayout();
			panel6.SuspendLayout();
			panel5.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			panel4.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(panel6);
			panel1.Controls.Add(panel5);
			panel1.Controls.Add(btnQuayLai);
			panel1.Controls.Add(btnThanhToan);
			panel1.Controls.Add(label12);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(cbKH);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(216, 195);
			panel1.Name = "panel1";
			panel1.Size = new Size(513, 537);
			panel1.TabIndex = 1;
			panel1.Paint += panel1_Paint;
			// 
			// panel6
			// 
			panel6.Controls.Add(txtHoTen);
			panel6.Location = new Point(174, 200);
			panel6.Name = "panel6";
			panel6.Size = new Size(300, 56);
			panel6.TabIndex = 26;
			panel6.Paint += panel6_Paint;
			// 
			// txtHoTen
			// 
			txtHoTen.BorderStyle = BorderStyle.None;
			txtHoTen.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtHoTen.Location = new Point(3, 18);
			txtHoTen.Multiline = true;
			txtHoTen.Name = "txtHoTen";
			txtHoTen.ReadOnly = true;
			txtHoTen.Size = new Size(231, 35);
			txtHoTen.TabIndex = 17;
			// 
			// panel5
			// 
			panel5.Controls.Add(txtDienThoai);
			panel5.Location = new Point(174, 123);
			panel5.Name = "panel5";
			panel5.Size = new Size(300, 56);
			panel5.TabIndex = 25;
			panel5.Paint += panel5_Paint;
			// 
			// txtDienThoai
			// 
			txtDienThoai.BorderStyle = BorderStyle.None;
			txtDienThoai.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtDienThoai.Location = new Point(3, 18);
			txtDienThoai.Multiline = true;
			txtDienThoai.Name = "txtDienThoai";
			txtDienThoai.PlaceholderText = "+84";
			txtDienThoai.Size = new Size(231, 35);
			txtDienThoai.TabIndex = 17;
			txtDienThoai.Leave += txtDienThoai_Leave;
			// 
			// btnQuayLai
			// 
			btnQuayLai.BackColor = Color.Red;
			btnQuayLai.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnQuayLai.Location = new Point(298, 453);
			btnQuayLai.Name = "btnQuayLai";
			btnQuayLai.Size = new Size(130, 44);
			btnQuayLai.TabIndex = 24;
			btnQuayLai.Text = "Quay lại";
			btnQuayLai.UseVisualStyleBackColor = false;
			// 
			// btnThanhToan
			// 
			btnThanhToan.BackColor = Color.Fuchsia;
			btnThanhToan.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnThanhToan.Location = new Point(126, 453);
			btnThanhToan.Name = "btnThanhToan";
			btnThanhToan.Size = new Size(130, 44);
			btnThanhToan.TabIndex = 22;
			btnThanhToan.Text = "Thanh toán";
			btnThanhToan.UseVisualStyleBackColor = false;
			btnThanhToan.Click += btnThanhToan_Click;
			// 
			// label12
			// 
			label12.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label12.Location = new Point(19, 218);
			label12.Name = "label12";
			label12.Size = new Size(127, 38);
			label12.TabIndex = 18;
			label12.Text = "Họ và tên";
			// 
			// label5
			// 
			label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(19, 142);
			label5.Name = "label5";
			label5.Size = new Size(127, 38);
			label5.TabIndex = 16;
			label5.Text = "Điện thoại";
			// 
			// cbKH
			// 
			cbKH.AutoSize = true;
			cbKH.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
			cbKH.Location = new Point(19, 85);
			cbKH.Name = "cbKH";
			cbKH.Size = new Size(169, 32);
			cbKH.TabIndex = 1;
			cbKH.Text = "Khách vãng lai";
			cbKH.UseVisualStyleBackColor = true;
			cbKH.CheckedChanged += cbKH_CheckedChanged;
			// 
			// label1
			// 
			label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ImageAlign = ContentAlignment.BottomCenter;
			label1.Location = new Point(19, 15);
			label1.Name = "label1";
			label1.Size = new Size(473, 67);
			label1.TabIndex = 0;
			label1.Text = "Thông tin khách hàng";
			label1.Paint += label1_Paint;
			// 
			// panel2
			// 
			panel2.BackColor = SystemColors.ButtonHighlight;
			panel2.BorderStyle = BorderStyle.FixedSingle;
			panel2.Controls.Add(label2);
			panel2.Location = new Point(216, 111);
			panel2.Name = "panel2";
			panel2.Size = new Size(513, 68);
			panel2.TabIndex = 2;
			// 
			// label2
			// 
			label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(-1, -1);
			label2.Name = "label2";
			label2.Size = new Size(513, 67);
			label2.TabIndex = 1;
			label2.Text = "THANH TOÁN HÓA ĐƠN";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			panel3.BackColor = SystemColors.ButtonHighlight;
			panel3.Controls.Add(panel4);
			panel3.Controls.Add(lblGheThuong);
			panel3.Controls.Add(label11);
			panel3.Controls.Add(lblGheVIP);
			panel3.Controls.Add(label10);
			panel3.Controls.Add(lblViTri);
			panel3.Controls.Add(label9);
			panel3.Controls.Add(lblPhongChieu);
			panel3.Controls.Add(label8);
			panel3.Controls.Add(lblGioChieu);
			panel3.Controls.Add(label7);
			panel3.Controls.Add(lblNgayChieu);
			panel3.Controls.Add(label6);
			panel3.Controls.Add(lblPhim);
			panel3.Controls.Add(label4);
			panel3.Controls.Add(label3);
			panel3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
			panel3.Location = new Point(752, 111);
			panel3.Name = "panel3";
			panel3.Size = new Size(522, 621);
			panel3.TabIndex = 2;
			panel3.Paint += panel3_Paint;
			// 
			// panel4
			// 
			panel4.Controls.Add(lblTongTien);
			panel4.Controls.Add(label14);
			panel4.Location = new Point(19, 528);
			panel4.Name = "panel4";
			panel4.Size = new Size(487, 53);
			panel4.TabIndex = 15;
			panel4.Paint += panel4_Paint;
			// 
			// lblTongTien
			// 
			lblTongTien.Location = new Point(280, 9);
			lblTongTien.Name = "lblTongTien";
			lblTongTien.Size = new Size(204, 30);
			lblTongTien.TabIndex = 1;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(3, 9);
			label14.Name = "label14";
			label14.Size = new Size(109, 30);
			label14.TabIndex = 0;
			label14.Text = "Tổng tiền";
			// 
			// lblGheThuong
			// 
			lblGheThuong.Location = new Point(281, 450);
			lblGheThuong.Name = "lblGheThuong";
			lblGheThuong.Size = new Size(225, 38);
			lblGheThuong.TabIndex = 14;
			// 
			// label11
			// 
			label11.Location = new Point(19, 450);
			label11.Name = "label11";
			label11.Size = new Size(140, 38);
			label11.TabIndex = 13;
			label11.Text = "Ghế thường";
			// 
			// lblGheVIP
			// 
			lblGheVIP.Location = new Point(281, 398);
			lblGheVIP.Name = "lblGheVIP";
			lblGheVIP.Size = new Size(225, 38);
			lblGheVIP.TabIndex = 12;
			// 
			// label10
			// 
			label10.Location = new Point(19, 398);
			label10.Name = "label10";
			label10.Size = new Size(140, 38);
			label10.TabIndex = 11;
			label10.Text = "Ghế VIP";
			// 
			// lblViTri
			// 
			lblViTri.Location = new Point(281, 342);
			lblViTri.Name = "lblViTri";
			lblViTri.Size = new Size(225, 38);
			lblViTri.TabIndex = 10;
			// 
			// label9
			// 
			label9.Location = new Point(19, 342);
			label9.Name = "label9";
			label9.Size = new Size(140, 38);
			label9.TabIndex = 9;
			label9.Text = "Vị trí ghế";
			// 
			// lblPhongChieu
			// 
			lblPhongChieu.Location = new Point(281, 284);
			lblPhongChieu.Name = "lblPhongChieu";
			lblPhongChieu.Size = new Size(225, 38);
			lblPhongChieu.TabIndex = 8;
			// 
			// label8
			// 
			label8.Location = new Point(19, 284);
			label8.Name = "label8";
			label8.Size = new Size(140, 38);
			label8.TabIndex = 7;
			label8.Text = "Phòng chiếu";
			// 
			// lblGioChieu
			// 
			lblGioChieu.Location = new Point(281, 225);
			lblGioChieu.Name = "lblGioChieu";
			lblGioChieu.Size = new Size(225, 38);
			lblGioChieu.TabIndex = 6;
			// 
			// label7
			// 
			label7.Location = new Point(19, 225);
			label7.Name = "label7";
			label7.Size = new Size(127, 38);
			label7.TabIndex = 5;
			label7.Text = "Giờ chiếu";
			// 
			// lblNgayChieu
			// 
			lblNgayChieu.Location = new Point(281, 169);
			lblNgayChieu.Name = "lblNgayChieu";
			lblNgayChieu.Size = new Size(225, 38);
			lblNgayChieu.TabIndex = 4;
			// 
			// label6
			// 
			label6.Location = new Point(19, 169);
			label6.Name = "label6";
			label6.Size = new Size(127, 38);
			label6.TabIndex = 3;
			label6.Text = "Ngày chiếu";
			// 
			// lblPhim
			// 
			lblPhim.Location = new Point(281, 113);
			lblPhim.Name = "lblPhim";
			lblPhim.Size = new Size(225, 38);
			lblPhim.TabIndex = 2;
			// 
			// label4
			// 
			label4.Location = new Point(19, 113);
			label4.Name = "label4";
			label4.Size = new Size(88, 38);
			label4.TabIndex = 1;
			label4.Text = "Phim";
			// 
			// label3
			// 
			label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(19, 12);
			label3.Name = "label3";
			label3.Size = new Size(473, 67);
			label3.TabIndex = 0;
			label3.Text = "Phim";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			label3.Paint += label3_Paint;
			// 
			// ThanhToan
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			ClientSize = new Size(1479, 799);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "ThanhToan";
			Text = "ThanhToan";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel6.ResumeLayout(false);
			panel6.PerformLayout();
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			panel2.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Label lblGioChieu;
        private Label label7;
        private Label lblNgayChieu;
        private Label label6;
        private Label lblPhim;
        private Label label4;
        private Label lblGheThuong;
        private Label label11;
        private Label lblGheVIP;
        private Label label10;
        private Label lblViTri;
        private Label label9;
        private Label lblPhongChieu;
        private Label label8;
        private Panel panel4;
        private CheckBox cbKH;
        private TextBox txtDienThoai;
        private Label label5;
        private Button button2;
        private Button btnThanhToan;
        private TextBox textBox2;
        private Label label13;
        private Label label12;
        private Button btnQuayLai;
        private Label lblTongTien;
        private Label label14;
        private Panel panel5;
        private Panel panel6;
        private TextBox txtHoTen;
    }
}