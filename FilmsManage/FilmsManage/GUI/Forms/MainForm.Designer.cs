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
            panel2 = new Panel();
            pnAdmin = new Panel();
            panel3 = new Panel();
            btnAccountUC = new Button();
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
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 1050);
            panel2.TabIndex = 2;
            // 
            // pnAdmin
            // 
            pnAdmin.Dock = DockStyle.Fill;
            pnAdmin.Location = new Point(0, 182);
            pnAdmin.Margin = new Padding(3, 2, 3, 2);
            pnAdmin.Name = "pnAdmin";
            pnAdmin.Size = new Size(1924, 868);
            pnAdmin.TabIndex = 2;
            pnAdmin.Paint += pnAdmin_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(btnAccountUC);
            panel3.Controls.Add(btnCustomerUC);
            panel3.Controls.Add(btnStaffUC);
            panel3.Controls.Add(btnDataUC);
            panel3.Controls.Add(btnRevenueUC);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1924, 182);
            panel3.TabIndex = 1;
            // 
            // btnAccountUC
            // 
            btnAccountUC.BackColor = Color.Goldenrod;
            btnAccountUC.FlatAppearance.CheckedBackColor = Color.Black;
            btnAccountUC.FlatAppearance.MouseDownBackColor = Color.Black;
            btnAccountUC.FlatAppearance.MouseOverBackColor = Color.Black;
            btnAccountUC.FlatStyle = FlatStyle.Flat;
            btnAccountUC.Font = new Font("Century Gothic", 11.25F);
            btnAccountUC.ForeColor = SystemColors.Control;
            btnAccountUC.ImageAlign = ContentAlignment.TopLeft;
            btnAccountUC.Location = new Point(939, 28);
            btnAccountUC.Margin = new Padding(3, 2, 3, 2);
            btnAccountUC.Name = "btnAccountUC";
            btnAccountUC.Size = new Size(193, 124);
            btnAccountUC.TabIndex = 0;
            btnAccountUC.Text = "Tài Khoản";
            btnAccountUC.TextAlign = ContentAlignment.BottomLeft;
            btnAccountUC.UseVisualStyleBackColor = false;
            btnAccountUC.Click += btnAccountUC_Click;
            // 
            // btnCustomerUC
            // 
            btnCustomerUC.BackColor = Color.RoyalBlue;
            btnCustomerUC.FlatAppearance.CheckedBackColor = Color.Black;
            btnCustomerUC.FlatAppearance.MouseDownBackColor = Color.Black;
            btnCustomerUC.FlatAppearance.MouseOverBackColor = Color.Black;
            btnCustomerUC.FlatStyle = FlatStyle.Flat;
            btnCustomerUC.Font = new Font("Century Gothic", 11.25F);
            btnCustomerUC.ForeColor = SystemColors.Control;
            btnCustomerUC.ImageAlign = ContentAlignment.TopLeft;
            btnCustomerUC.Location = new Point(723, 28);
            btnCustomerUC.Margin = new Padding(3, 2, 3, 2);
            btnCustomerUC.Name = "btnCustomerUC";
            btnCustomerUC.Size = new Size(193, 124);
            btnCustomerUC.TabIndex = 0;
            btnCustomerUC.Text = "Khách Hàng";
            btnCustomerUC.TextAlign = ContentAlignment.BottomLeft;
            btnCustomerUC.UseVisualStyleBackColor = false;
            btnCustomerUC.Click += btnCustomerUC_Click;
            // 
            // btnStaffUC
            // 
            btnStaffUC.BackColor = Color.Red;
            btnStaffUC.FlatAppearance.CheckedBackColor = Color.Black;
            btnStaffUC.FlatAppearance.MouseDownBackColor = Color.Black;
            btnStaffUC.FlatAppearance.MouseOverBackColor = Color.Black;
            btnStaffUC.FlatStyle = FlatStyle.Flat;
            btnStaffUC.Font = new Font("Century Gothic", 11.25F);
            btnStaffUC.ForeColor = SystemColors.Control;
            btnStaffUC.ImageAlign = ContentAlignment.TopLeft;
            btnStaffUC.Location = new Point(507, 28);
            btnStaffUC.Margin = new Padding(3, 2, 3, 2);
            btnStaffUC.Name = "btnStaffUC";
            btnStaffUC.Size = new Size(193, 124);
            btnStaffUC.TabIndex = 0;
            btnStaffUC.Text = "Nhân Viên";
            btnStaffUC.TextAlign = ContentAlignment.BottomLeft;
            btnStaffUC.UseVisualStyleBackColor = false;
            btnStaffUC.Click += btnStaffUC_Click;
            // 
            // btnDataUC
            // 
            btnDataUC.BackColor = Color.ForestGreen;
            btnDataUC.FlatAppearance.CheckedBackColor = Color.Black;
            btnDataUC.FlatAppearance.MouseDownBackColor = Color.Black;
            btnDataUC.FlatAppearance.MouseOverBackColor = Color.Black;
            btnDataUC.FlatStyle = FlatStyle.Flat;
            btnDataUC.Font = new Font("Century Gothic", 11.25F);
            btnDataUC.ForeColor = SystemColors.Control;
            btnDataUC.ImageAlign = ContentAlignment.TopLeft;
            btnDataUC.Location = new Point(283, 28);
            btnDataUC.Margin = new Padding(3, 2, 3, 2);
            btnDataUC.Name = "btnDataUC";
            btnDataUC.Size = new Size(193, 124);
            btnDataUC.TabIndex = 0;
            btnDataUC.Text = "Dữ Liệu";
            btnDataUC.TextAlign = ContentAlignment.BottomLeft;
            btnDataUC.UseVisualStyleBackColor = false;
            btnDataUC.Click += btnDataUC_Click;
            // 
            // btnRevenueUC
            // 
            btnRevenueUC.BackColor = Color.DarkViolet;
            btnRevenueUC.FlatAppearance.CheckedBackColor = Color.Black;
            btnRevenueUC.FlatAppearance.MouseDownBackColor = Color.Black;
            btnRevenueUC.FlatAppearance.MouseOverBackColor = Color.Black;
            btnRevenueUC.FlatStyle = FlatStyle.Flat;
            btnRevenueUC.Font = new Font("Century Gothic", 11.25F);
            btnRevenueUC.ForeColor = SystemColors.Control;
            btnRevenueUC.ImageAlign = ContentAlignment.TopLeft;
            btnRevenueUC.Location = new Point(67, 28);
            btnRevenueUC.Margin = new Padding(3, 2, 3, 2);
            btnRevenueUC.Name = "btnRevenueUC";
            btnRevenueUC.Size = new Size(193, 124);
            btnRevenueUC.TabIndex = 0;
            btnRevenueUC.Text = "Doanh Thu";
            btnRevenueUC.TextAlign = ContentAlignment.BottomLeft;
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
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
    }
}