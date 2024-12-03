namespace FilmsManage.GUI.UserControls.Data
{
    partial class DinhDangPhimUC
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
            panel1 = new Panel();
            btnShowFormat = new Button();
            btnUpdateFormat = new Button();
            btnInsertFormat = new Button();
            panel2 = new Panel();
            dtgvFormat = new DataGridView();
            panel3 = new Panel();
            cbMaMH = new ComboBox();
            label3 = new Label();
            txtTenMh = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtTenDangPhim = new TextBox();
            lblFormatID = new Label();
            txtFormatID = new TextBox();
            btnExport = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFormat).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(btnShowFormat);
            panel1.Controls.Add(btnUpdateFormat);
            panel1.Controls.Add(btnInsertFormat);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Arial", 12F);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1551, 182);
            panel1.TabIndex = 0;
            // 
            // btnShowFormat
            // 
            btnShowFormat.BackColor = Color.Brown;
            btnShowFormat.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnShowFormat.ForeColor = Color.White;
            btnShowFormat.Location = new Point(59, 301);
            btnShowFormat.Margin = new Padding(4, 5, 4, 5);
            btnShowFormat.Name = "btnShowFormat";
            btnShowFormat.Size = new Size(300, 71);
            btnShowFormat.TabIndex = 11;
            btnShowFormat.Text = "Xem";
            btnShowFormat.UseVisualStyleBackColor = false;
            // 
            // btnUpdateFormat
            // 
            btnUpdateFormat.BackColor = Color.Brown;
            btnUpdateFormat.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnUpdateFormat.ForeColor = Color.White;
            btnUpdateFormat.Location = new Point(59, 181);
            btnUpdateFormat.Margin = new Padding(4, 5, 4, 5);
            btnUpdateFormat.Name = "btnUpdateFormat";
            btnUpdateFormat.Size = new Size(300, 71);
            btnUpdateFormat.TabIndex = 10;
            btnUpdateFormat.Text = "Sửa";
            btnUpdateFormat.UseVisualStyleBackColor = false;
            btnUpdateFormat.Click += btnUpdateFormat_Click;
            // 
            // btnInsertFormat
            // 
            btnInsertFormat.BackColor = Color.Brown;
            btnInsertFormat.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnInsertFormat.ForeColor = Color.White;
            btnInsertFormat.Location = new Point(59, 60);
            btnInsertFormat.Margin = new Padding(4, 5, 4, 5);
            btnInsertFormat.Name = "btnInsertFormat";
            btnInsertFormat.Size = new Size(300, 71);
            btnInsertFormat.TabIndex = 8;
            btnInsertFormat.Text = "Thêm";
            btnInsertFormat.UseVisualStyleBackColor = false;
            btnInsertFormat.Click += btnInsertFormat_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgvFormat);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 182);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1551, 636);
            panel2.TabIndex = 1;
            // 
            // dtgvFormat
            // 
            dtgvFormat.AllowUserToAddRows = false;
            dtgvFormat.AllowUserToDeleteRows = false;
            dtgvFormat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvFormat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFormat.Dock = DockStyle.Fill;
            dtgvFormat.Location = new Point(0, 0);
            dtgvFormat.Margin = new Padding(3, 4, 3, 4);
            dtgvFormat.Name = "dtgvFormat";
            dtgvFormat.ReadOnly = true;
            dtgvFormat.RowHeadersWidth = 51;
            dtgvFormat.Size = new Size(1014, 636);
            dtgvFormat.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnShowFormat);
            panel3.Controls.Add(btnUpdateFormat);
            panel3.Controls.Add(btnInsertFormat);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1014, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(537, 636);
            panel3.TabIndex = 0;
            // 
            // cbMaMH
            // 
            cbMaMH.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaMH.Font = new Font("Arial", 12F);
            cbMaMH.FormattingEnabled = true;
            cbMaMH.Location = new Point(713, 41);
            cbMaMH.Margin = new Padding(3, 2, 3, 2);
            cbMaMH.Name = "cbMaMH";
            cbMaMH.Size = new Size(244, 31);
            cbMaMH.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(554, 120);
            label3.Name = "label3";
            label3.Size = new Size(147, 24);
            label3.TabIndex = 26;
            label3.Text = "Tên màn hình:";
            // 
            // txtTenMh
            // 
            txtTenMh.Font = new Font("Arial", 12F);
            txtTenMh.Location = new Point(713, 114);
            txtTenMh.Name = "txtTenMh";
            txtTenMh.Size = new Size(244, 30);
            txtTenMh.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(554, 46);
            label2.Name = "label2";
            label2.Size = new Size(139, 24);
            label2.TabIndex = 24;
            label2.Text = "Mã màn hình:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(36, 114);
            label1.Name = "label1";
            label1.Size = new Size(158, 24);
            label1.TabIndex = 23;
            label1.Text = "Tên dạng phim:";
            // 
            // txtTenDangPhim
            // 
            txtTenDangPhim.Font = new Font("Arial", 12F);
            txtTenDangPhim.Location = new Point(195, 114);
            txtTenDangPhim.Name = "txtTenDangPhim";
            txtTenDangPhim.Size = new Size(244, 30);
            txtTenDangPhim.TabIndex = 22;
            // 
            // lblFormatID
            // 
            lblFormatID.AutoSize = true;
            lblFormatID.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblFormatID.Location = new Point(37, 41);
            lblFormatID.Name = "lblFormatID";
            lblFormatID.Size = new Size(145, 24);
            lblFormatID.TabIndex = 19;
            lblFormatID.Text = "Mã định dạng:";
            // 
            // txtFormatID
            // 
            txtFormatID.Font = new Font("Arial", 12F);
            txtFormatID.Location = new Point(195, 40);
            txtFormatID.Margin = new Padding(3, 4, 3, 4);
            txtFormatID.Name = "txtFormatID";
            txtFormatID.Size = new Size(249, 30);
            txtFormatID.TabIndex = 14;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(411, 110);
            btnExport.Margin = new Padding(4, 5, 4, 5);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(100, 71);
            btnExport.TabIndex = 12;
            btnExport.Text = "Xuất File ";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // DinhDangPhimUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DinhDangPhimUC";
            Size = new Size(1551, 672);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFormat).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowFormat;
        private System.Windows.Forms.Button btnUpdateFormat;
        private System.Windows.Forms.Button btnDeleteFormat;
        private System.Windows.Forms.Button btnInsertFormat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblFormatID;
        private System.Windows.Forms.TextBox txtFormatID;
        private System.Windows.Forms.DataGridView dtgvFormat;
        private Label label1;
        private TextBox txtTenDangPhim;
        private Label label2;
        private Label label3;
        private TextBox txtTenMh;
        private ComboBox cbMaMH;
        private Button btnExport;
    }
}
