namespace FilmsManage.GUI.Forms.BanVe_Form
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            pnlLogo = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            pnlContent = new Panel();
            panel4 = new Panel();
            TimerLock = new System.Windows.Forms.Timer(components);
            button4 = new Button();
            panel1.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pnlLogo);
            panel1.Controls.Add(pnlContent);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 993);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(3, 591);
            button3.Name = "button3";
            button3.Size = new Size(203, 58);
            button3.TabIndex = 8;
            button3.Text = "Khách hàng";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            button3.Paint += button3_Paint;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(3, 420);
            button2.Name = "button2";
            button2.Size = new Size(203, 58);
            button2.TabIndex = 4;
            button2.Text = "Bán vé";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.Paint += button2_Paint;
            // 
            // panel2
            // 
            panel2.Location = new Point(218, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1224, 842);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 504);
            button1.Name = "button1";
            button1.Size = new Size(203, 58);
            button1.TabIndex = 3;
            button1.Text = "Đồ ăn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.Paint += button1_Paint;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(pictureBox1);
            pnlLogo.Controls.Add(panel3);
            pnlLogo.Location = new Point(21, 26);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(163, 150);
            pnlLogo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Location = new Point(166, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(1269, 785);
            panel3.TabIndex = 1;
            // 
            // pnlContent
            // 
            pnlContent.Location = new Point(215, 3);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1220, 842);
            pnlContent.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Location = new Point(216, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1590, 993);
            panel4.TabIndex = 1;
            // 
            // TimerLock
            // 
            TimerLock.Enabled = true;
            TimerLock.Interval = 1000;
            TimerLock.Tick += TimerLock_Tick;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(0, 677);
            button4.Name = "button4";
            button4.Size = new Size(203, 58);
            button4.TabIndex = 9;
            button4.Text = "Đăng xuất";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1805, 1020);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "Main_Form";
            Text = "Main_Form";
            Load += Main_Form_Load_1;
            panel1.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlLogo;
        private Panel pnlContent;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        public Panel panel4;
        private Button button2;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
		private Bunifu.UI.WinForms.BunifuLabel userNameAlias;
		private Bunifu.UI.WinForms.BunifuLabel lblTime;
		private System.Windows.Forms.Timer TimerLock;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogout;
        private Button button3;
        private Button button4;
    }
}