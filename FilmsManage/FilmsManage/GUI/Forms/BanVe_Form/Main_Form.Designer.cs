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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            panel1 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            pnlLogo = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            pnlContent = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pnlLogo);
            panel1.Controls.Add(pnlContent);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 993);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(0, 159);
            button2.Name = "button2";
            button2.Size = new Size(163, 58);
            button2.TabIndex = 4;
            button2.Text = "Bán vé";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.Paint += button2_Paint;
            // 
            // panel2
            // 
            panel2.Location = new Point(166, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1276, 842);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 223);
            button1.Name = "button1";
            button1.Size = new Size(163, 58);
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
            pnlLogo.Location = new Point(0, 3);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(163, 150);
            pnlLogo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 157);
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
            pnlContent.Location = new Point(169, 3);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1266, 842);
            pnlContent.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Location = new Point(167, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1639, 993);
            panel4.TabIndex = 1;
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
    }
}