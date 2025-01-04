namespace FilmsManage.GUI.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel2 = new Panel();
            pnAdmin = new Panel();
            panel3 = new Panel();
            button3 = new Button();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            button2 = new Button();
            button1 = new Button();
            btnCustomerUC = new Button();
            btnStaffUC = new Button();
            btnDataUC = new Button();
            btnRevenueUC = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(pnAdmin);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 1050);
            panel2.TabIndex = 2;
            // 
            // pnAdmin
            // 
            pnAdmin.Dock = DockStyle.Fill;
            pnAdmin.Location = new Point(0, 133);
            pnAdmin.Margin = new Padding(2);
            pnAdmin.Name = "pnAdmin";
            pnAdmin.Size = new Size(1924, 917);
            pnAdmin.TabIndex = 2;
            pnAdmin.Paint += pnAdmin_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(41, 39, 40);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(guna2HtmlLabel2);
            panel3.Controls.Add(lblName);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(btnCustomerUC);
            panel3.Controls.Add(btnStaffUC);
            panel3.Controls.Add(btnDataUC);
            panel3.Controls.Add(btnRevenueUC);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1924, 133);
            panel3.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(41, 39, 40);
            button3.FlatAppearance.CheckedBackColor = Color.FromArgb(41, 39, 40);
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 39, 40);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 39, 40);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 11.25F);
            button3.ForeColor = Color.FromArgb(41, 39, 40);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(14, 9);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(84, 78);
            button3.TabIndex = 1;
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Microsoft Sans Serif", 11.25F);
            guna2HtmlLabel2.ForeColor = Color.White;
            guna2HtmlLabel2.Location = new Point(104, 78);
            guna2HtmlLabel2.Margin = new Padding(4);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(74, 31);
            guna2HtmlLabel2.TabIndex = 7;
            guna2HtmlLabel2.Text = "Online";
            // 
            // lblName
            // 
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(104, 29);
            lblName.Margin = new Padding(4);
            lblName.Name = "lblName";
            lblName.Size = new Size(3, 2);
            lblName.TabIndex = 6;
            lblName.Text = null;
            lblName.Click += guna2HtmlLabel1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(41, 39, 40);
            button2.FlatAppearance.CheckedBackColor = Color.FromArgb(41, 39, 40);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 39, 40);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 39, 40);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 11.25F);
            button2.ForeColor = Color.FromArgb(41, 39, 40);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(62, 66);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(120, 56);
            button2.TabIndex = 5;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(41, 39, 40);
            button1.FlatAppearance.CheckedBackColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = Color.Black;
            button1.FlatAppearance.MouseOverBackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 11.25F);
            button1.ForeColor = SystemColors.Control;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(1374, 20);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(241, 99);
            button1.TabIndex = 1;
            button1.Text = "Đăng Xuất";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnCustomerUC
            // 
            btnCustomerUC.BackColor = Color.FromArgb(41, 39, 40);
            btnCustomerUC.FlatAppearance.CheckedBackColor = Color.Black;
            btnCustomerUC.FlatAppearance.MouseDownBackColor = Color.Black;
            btnCustomerUC.FlatAppearance.MouseOverBackColor = Color.Black;
            btnCustomerUC.FlatStyle = FlatStyle.Flat;
            btnCustomerUC.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnCustomerUC.ForeColor = SystemColors.Control;
            btnCustomerUC.Image = (Image)resources.GetObject("btnCustomerUC.Image");
            btnCustomerUC.ImageAlign = ContentAlignment.TopCenter;
            btnCustomerUC.Location = new Point(1085, 20);
            btnCustomerUC.Margin = new Padding(2);
            btnCustomerUC.Name = "btnCustomerUC";
            btnCustomerUC.Size = new Size(241, 99);
            btnCustomerUC.TabIndex = 0;
            btnCustomerUC.Text = "Khách Hàng";
            btnCustomerUC.TextAlign = ContentAlignment.BottomCenter;
            btnCustomerUC.UseVisualStyleBackColor = false;
            btnCustomerUC.Click += btnCustomerUC_Click;
            // 
            // btnStaffUC
            // 
            btnStaffUC.BackColor = Color.FromArgb(41, 39, 40);
            btnStaffUC.FlatAppearance.CheckedBackColor = Color.Black;
            btnStaffUC.FlatAppearance.MouseDownBackColor = Color.Black;
            btnStaffUC.FlatAppearance.MouseOverBackColor = Color.Black;
            btnStaffUC.FlatStyle = FlatStyle.Flat;
            btnStaffUC.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnStaffUC.ForeColor = SystemColors.Control;
            btnStaffUC.Image = (Image)resources.GetObject("btnStaffUC.Image");
            btnStaffUC.ImageAlign = ContentAlignment.TopCenter;
            btnStaffUC.Location = new Point(801, 20);
            btnStaffUC.Margin = new Padding(2);
            btnStaffUC.Name = "btnStaffUC";
            btnStaffUC.Size = new Size(241, 99);
            btnStaffUC.TabIndex = 0;
            btnStaffUC.Text = "Nhân Viên";
            btnStaffUC.TextAlign = ContentAlignment.BottomCenter;
            btnStaffUC.UseVisualStyleBackColor = false;
            btnStaffUC.Click += btnStaffUC_Click;
            // 
            // btnDataUC
            // 
            btnDataUC.BackColor = Color.FromArgb(41, 39, 40);
            btnDataUC.FlatAppearance.CheckedBackColor = Color.Black;
            btnDataUC.FlatAppearance.MouseDownBackColor = Color.Black;
            btnDataUC.FlatAppearance.MouseOverBackColor = Color.Black;
            btnDataUC.FlatStyle = FlatStyle.Flat;
            btnDataUC.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnDataUC.ForeColor = SystemColors.Control;
            btnDataUC.Image = (Image)resources.GetObject("btnDataUC.Image");
            btnDataUC.ImageAlign = ContentAlignment.TopCenter;
            btnDataUC.Location = new Point(519, 20);
            btnDataUC.Margin = new Padding(2);
            btnDataUC.Name = "btnDataUC";
            btnDataUC.Size = new Size(241, 99);
            btnDataUC.TabIndex = 0;
            btnDataUC.Text = "Dữ Liệu";
            btnDataUC.TextAlign = ContentAlignment.BottomCenter;
            btnDataUC.UseVisualStyleBackColor = false;
            btnDataUC.Click += btnDataUC_Click;
            // 
            // btnRevenueUC
            // 
            btnRevenueUC.BackColor = Color.FromArgb(41, 39, 40);
            btnRevenueUC.FlatAppearance.CheckedBackColor = Color.Black;
            btnRevenueUC.FlatAppearance.MouseDownBackColor = Color.Black;
            btnRevenueUC.FlatAppearance.MouseOverBackColor = Color.Black;
            btnRevenueUC.FlatStyle = FlatStyle.Flat;
            btnRevenueUC.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnRevenueUC.ForeColor = SystemColors.Control;
            btnRevenueUC.Image = (Image)resources.GetObject("btnRevenueUC.Image");
            btnRevenueUC.ImageAlign = ContentAlignment.TopCenter;
            btnRevenueUC.Location = new Point(231, 20);
            btnRevenueUC.Margin = new Padding(2);
            btnRevenueUC.Name = "btnRevenueUC";
            btnRevenueUC.Size = new Size(241, 99);
            btnRevenueUC.TabIndex = 0;
            btnRevenueUC.Text = "Doanh Thu";
            btnRevenueUC.TextAlign = ContentAlignment.BottomCenter;
            btnRevenueUC.UseVisualStyleBackColor = false;
            btnRevenueUC.Click += btnRevenueUC_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            FormClosed += MainForm_FormClosed;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAccountUC;
        private System.Windows.Forms.Button btnCustomerUC;
        private System.Windows.Forms.Button btnStaffUC;
        private System.Windows.Forms.Button btnDataUC;
        private System.Windows.Forms.Button btnRevenueUC;
        private System.Windows.Forms.Panel pnAdmin;
        private Button button1;
        private Button button2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Button button3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
    }
}