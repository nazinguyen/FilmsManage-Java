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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            lblTime = new Label();
            lblInformation = new Label();
            panel5 = new Panel();
            panel7 = new Panel();
            groupBox2 = new GroupBox();
            pnCustomer = new Panel();
            label7 = new Label();
            label6 = new Label();
            numericFreeTickets = new NumericUpDown();
            btnFreeTicket = new Button();
            lblPlusPoint = new Label();
            label4 = new Label();
            lblCustomerName = new Label();
            lblPoint = new Label();
            label11 = new Label();
            chkCustomer = new CheckBox();
            grpLoaiVe = new GroupBox();
            label12 = new Label();
            rdoStudent = new RadioButton();
            lblTicketPrice = new Label();
            rdoAdult = new RadioButton();
            rdoChild = new RadioButton();
            panel6 = new Panel();
            btnCancel = new Button();
            lblTotal = new Label();
            btnPayment = new Button();
            label5 = new Label();
            lblPayment = new Label();
            label8 = new Label();
            label9 = new Label();
            lblDiscount = new Label();
            picFilm = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            groupBox2.SuspendLayout();
            pnCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericFreeTickets).BeginInit();
            grpLoaiVe.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFilm).BeginInit();
            SuspendLayout();
            // 
            // flpSeat
            // 
            flpSeat.Anchor = AnchorStyles.Top;
            flpSeat.FlowDirection = FlowDirection.RightToLeft;
            flpSeat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flpSeat.Location = new Point(82, 154);
            flpSeat.Name = "flpSeat";
            flpSeat.Size = new Size(800, 400);
            flpSeat.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(30, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(883, 50);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlDark;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(881, 48);
            label1.TabIndex = 0;
            label1.Text = "Màn Chiếu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(943, 419);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 92);
            panel2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Enabled = false;
            button1.Location = new Point(22, 52);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.Enabled = false;
            button4.Location = new Point(22, 16);
            button4.Name = "button4";
            button4.Size = new Size(30, 30);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 55);
            label2.Name = "label2";
            label2.Size = new Size(95, 29);
            label2.TabIndex = 6;
            label2.Text = "Đã Mua";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 16);
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
            panel4.Size = new Size(1202, 72);
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
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 589);
            panel5.Name = "panel5";
            panel5.Size = new Size(1202, 202);
            panel5.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(groupBox2);
            panel7.Controls.Add(grpLoaiVe);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(780, 200);
            panel7.TabIndex = 17;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pnCustomer);
            groupBox2.Controls.Add(chkCustomer);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(343, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(435, 198);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thành Viên:";
            // 
            // pnCustomer
            // 
            pnCustomer.Controls.Add(label7);
            pnCustomer.Controls.Add(label6);
            pnCustomer.Controls.Add(numericFreeTickets);
            pnCustomer.Controls.Add(btnFreeTicket);
            pnCustomer.Controls.Add(lblPlusPoint);
            pnCustomer.Controls.Add(label4);
            pnCustomer.Controls.Add(lblCustomerName);
            pnCustomer.Controls.Add(lblPoint);
            pnCustomer.Controls.Add(label11);
            pnCustomer.Location = new Point(6, 54);
            pnCustomer.Name = "pnCustomer";
            pnCustomer.Size = new Size(387, 141);
            pnCustomer.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 2);
            label7.Name = "label7";
            label7.Size = new Size(198, 29);
            label7.TabIndex = 25;
            label7.Text = "Tên Khách Hàng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 109);
            label6.Name = "label6";
            label6.Size = new Size(185, 29);
            label6.TabIndex = 24;
            label6.Text = "Đổi vé miễn phí:";
            // 
            // numericFreeTickets
            // 
            numericFreeTickets.Location = new Point(177, 107);
            numericFreeTickets.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericFreeTickets.Name = "numericFreeTickets";
            numericFreeTickets.Size = new Size(73, 35);
            numericFreeTickets.TabIndex = 23;
            numericFreeTickets.TextAlign = HorizontalAlignment.Right;
            numericFreeTickets.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnFreeTicket
            // 
            btnFreeTicket.Location = new Point(256, 104);
            btnFreeTicket.Name = "btnFreeTicket";
            btnFreeTicket.Size = new Size(114, 35);
            btnFreeTicket.TabIndex = 22;
            btnFreeTicket.Text = "Đổi Vé";
            btnFreeTicket.UseVisualStyleBackColor = true;
            // 
            // lblPlusPoint
            // 
            lblPlusPoint.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPlusPoint.BackColor = Color.White;
            lblPlusPoint.BorderStyle = BorderStyle.Fixed3D;
            lblPlusPoint.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlusPoint.ForeColor = Color.Red;
            lblPlusPoint.Location = new Point(177, 68);
            lblPlusPoint.Name = "lblPlusPoint";
            lblPlusPoint.Size = new Size(193, 30);
            lblPlusPoint.TabIndex = 21;
            lblPlusPoint.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 68);
            label4.Name = "label4";
            label4.Size = new Size(209, 29);
            label4.TabIndex = 20;
            label4.Text = "Điểm Cộng Thêm:";
            // 
            // lblCustomerName
            // 
            lblCustomerName.Location = new Point(172, 2);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(193, 25);
            lblCustomerName.TabIndex = 19;
            // 
            // lblPoint
            // 
            lblPoint.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPoint.BackColor = Color.White;
            lblPoint.BorderStyle = BorderStyle.Fixed3D;
            lblPoint.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPoint.ForeColor = Color.Red;
            lblPoint.Location = new Point(177, 33);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(193, 30);
            lblPoint.TabIndex = 17;
            lblPoint.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(4, 33);
            label11.Name = "label11";
            label11.Size = new Size(172, 29);
            label11.TabIndex = 16;
            label11.Text = "Điểm Tích Lũy:";
            // 
            // chkCustomer
            // 
            chkCustomer.AutoSize = true;
            chkCustomer.Location = new Point(6, 29);
            chkCustomer.Name = "chkCustomer";
            chkCustomer.Size = new Size(297, 33);
            chkCustomer.TabIndex = 0;
            chkCustomer.Text = "Khách Hàng Thành Viên";
            chkCustomer.UseVisualStyleBackColor = true;
            // 
            // grpLoaiVe
            // 
            grpLoaiVe.Controls.Add(label12);
            grpLoaiVe.Controls.Add(rdoStudent);
            grpLoaiVe.Controls.Add(lblTicketPrice);
            grpLoaiVe.Controls.Add(rdoAdult);
            grpLoaiVe.Controls.Add(rdoChild);
            grpLoaiVe.Dock = DockStyle.Left;
            grpLoaiVe.Location = new Point(0, 0);
            grpLoaiVe.Name = "grpLoaiVe";
            grpLoaiVe.Size = new Size(343, 198);
            grpLoaiVe.TabIndex = 17;
            grpLoaiVe.TabStop = false;
            grpLoaiVe.Text = "Loại Vé:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 136);
            label12.Name = "label12";
            label12.Size = new Size(91, 29);
            label12.TabIndex = 10;
            label12.Text = "Giá Vé:";
            // 
            // rdoStudent
            // 
            rdoStudent.AutoSize = true;
            rdoStudent.Location = new Point(156, 43);
            rdoStudent.Name = "rdoStudent";
            rdoStudent.Size = new Size(140, 33);
            rdoStudent.TabIndex = 5;
            rdoStudent.TabStop = true;
            rdoStudent.Text = "Sinh Viên";
            rdoStudent.UseVisualStyleBackColor = true;
            // 
            // lblTicketPrice
            // 
            lblTicketPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTicketPrice.BackColor = Color.White;
            lblTicketPrice.BorderStyle = BorderStyle.Fixed3D;
            lblTicketPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicketPrice.ForeColor = Color.Red;
            lblTicketPrice.Location = new Point(90, 133);
            lblTicketPrice.Name = "lblTicketPrice";
            lblTicketPrice.Size = new Size(247, 30);
            lblTicketPrice.TabIndex = 9;
            lblTicketPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rdoAdult
            // 
            rdoAdult.AutoSize = true;
            rdoAdult.Location = new Point(28, 43);
            rdoAdult.Name = "rdoAdult";
            rdoAdult.Size = new Size(149, 33);
            rdoAdult.TabIndex = 4;
            rdoAdult.TabStop = true;
            rdoAdult.Text = "Người Lớn";
            rdoAdult.UseVisualStyleBackColor = true;
            // 
            // rdoChild
            // 
            rdoChild.AutoSize = true;
            rdoChild.Location = new Point(28, 87);
            rdoChild.Name = "rdoChild";
            rdoChild.Size = new Size(267, 33);
            rdoChild.TabIndex = 3;
            rdoChild.TabStop = true;
            rdoChild.Text = "Trẻ Em (Dưới 12 tuổi)";
            rdoChild.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(btnCancel);
            panel6.Controls.Add(lblTotal);
            panel6.Controls.Add(btnPayment);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(lblPayment);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(lblDiscount);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(780, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(420, 200);
            panel6.TabIndex = 14;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.Location = new Point(304, 148);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 39);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.BackColor = Color.White;
            lblTotal.BorderStyle = BorderStyle.Fixed3D;
            lblTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Red;
            lblTotal.Location = new Point(154, 9);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(254, 30);
            lblTotal.TabIndex = 9;
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(154, 148);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(133, 35);
            btnPayment.TabIndex = 11;
            btnPayment.Text = "Thanh Toán";
            btnPayment.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(5, 54);
            label5.Name = "label5";
            label5.Size = new Size(153, 29);
            label5.TabIndex = 8;
            label5.Text = "Số tiền giảm:";
            // 
            // lblPayment
            // 
            lblPayment.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPayment.BackColor = Color.White;
            lblPayment.BorderStyle = BorderStyle.Fixed3D;
            lblPayment.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPayment.ForeColor = Color.Red;
            lblPayment.Location = new Point(154, 93);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(254, 30);
            lblPayment.TabIndex = 10;
            lblPayment.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(5, 12);
            label8.Name = "label8";
            label8.Size = new Size(131, 29);
            label8.TabIndex = 7;
            label8.Text = "Tổng Tiền:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(5, 96);
            label9.Name = "label9";
            label9.Size = new Size(171, 29);
            label9.TabIndex = 8;
            label9.Text = "Số tiền cần trả:";
            // 
            // lblDiscount
            // 
            lblDiscount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDiscount.BackColor = Color.White;
            lblDiscount.BorderStyle = BorderStyle.Fixed3D;
            lblDiscount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscount.ForeColor = Color.Red;
            lblDiscount.Location = new Point(154, 51);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(254, 30);
            lblDiscount.TabIndex = 10;
            lblDiscount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // picFilm
            // 
            picFilm.BorderStyle = BorderStyle.FixedSingle;
            picFilm.Location = new Point(943, 154);
            picFilm.Name = "picFilm";
            picFilm.Size = new Size(211, 259);
            picFilm.SizeMode = PictureBoxSizeMode.StretchImage;
            picFilm.TabIndex = 7;
            picFilm.TabStop = false;
            // 
            // BanVe
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1202, 791);
            Controls.Add(picFilm);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flpSeat);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "BanVe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán Vé";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            pnCustomer.ResumeLayout(false);
            pnCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericFreeTickets).EndInit();
            grpLoaiVe.ResumeLayout(false);
            grpLoaiVe.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFilm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSeat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox grpLoaiVe;
        private System.Windows.Forms.RadioButton rdoStudent;
        private System.Windows.Forms.RadioButton rdoAdult;
        private System.Windows.Forms.RadioButton rdoChild;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTicketPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox picFilm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkCustomer;
        private System.Windows.Forms.Panel pnCustomer;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPlusPoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFreeTicket;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericFreeTickets;
        private System.Windows.Forms.Label label7;
    }
}