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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFormat).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnShowFormat);
            panel1.Controls.Add(btnUpdateFormat);
            panel1.Controls.Add(btnInsertFormat);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1935, 336);
            panel1.TabIndex = 0;
            // 
            // btnShowFormat
            // 
            btnShowFormat.Location = new Point(354, 236);
            btnShowFormat.Margin = new Padding(5, 6, 5, 6);
            btnShowFormat.Name = "btnShowFormat";
            btnShowFormat.Size = new Size(125, 89);
            btnShowFormat.TabIndex = 11;
            btnShowFormat.Text = "Xem";
            btnShowFormat.UseVisualStyleBackColor = true;
            // 
            // btnUpdateFormat
            // 
            btnUpdateFormat.Location = new Point(187, 236);
            btnUpdateFormat.Margin = new Padding(5, 6, 5, 6);
            btnUpdateFormat.Name = "btnUpdateFormat";
            btnUpdateFormat.Size = new Size(125, 89);
            btnUpdateFormat.TabIndex = 10;
            btnUpdateFormat.Text = "Sửa";
            btnUpdateFormat.UseVisualStyleBackColor = true;
            btnUpdateFormat.Click += btnUpdateFormat_Click;
            // 
            // btnInsertFormat
            // 
            btnInsertFormat.Location = new Point(31, 236);
            btnInsertFormat.Margin = new Padding(5, 6, 5, 6);
            btnInsertFormat.Name = "btnInsertFormat";
            btnInsertFormat.Size = new Size(125, 89);
            btnInsertFormat.TabIndex = 8;
            btnInsertFormat.Text = "Thêm";
            btnInsertFormat.UseVisualStyleBackColor = true;
            btnInsertFormat.Click += btnInsertFormat_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgvFormat);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 336);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1935, 662);
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
            dtgvFormat.Margin = new Padding(4, 5, 4, 5);
            dtgvFormat.Name = "dtgvFormat";
            dtgvFormat.ReadOnly = true;
            dtgvFormat.RowHeadersWidth = 51;
            dtgvFormat.Size = new Size(1264, 662);
            dtgvFormat.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(cbMaMH);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtTenMh);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtTenDangPhim);
            panel3.Controls.Add(lblFormatID);
            panel3.Controls.Add(txtFormatID);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1264, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(671, 662);
            panel3.TabIndex = 0;
            // 
            // cbMaMH
            // 
            cbMaMH.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaMH.FormattingEnabled = true;
            cbMaMH.Location = new Point(219, 149);
            cbMaMH.Margin = new Padding(4, 2, 4, 2);
            cbMaMH.Name = "cbMaMH";
            cbMaMH.Size = new Size(266, 33);
            cbMaMH.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 225);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(161, 26);
            label3.TabIndex = 26;
            label3.Text = "Tên màn hình:";
            // 
            // txtTenMh
            // 
            txtTenMh.Location = new Point(219, 225);
            txtTenMh.Margin = new Padding(4);
            txtTenMh.Name = "txtTenMh";
            txtTenMh.Size = new Size(304, 31);
            txtTenMh.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 151);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 26);
            label2.TabIndex = 24;
            label2.Text = "Mã màn hình:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 79);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 26);
            label1.TabIndex = 23;
            label1.Text = "Tên dạng phim:";
            // 
            // txtTenDangPhim
            // 
            txtTenDangPhim.Location = new Point(219, 79);
            txtTenDangPhim.Margin = new Padding(4);
            txtTenDangPhim.Name = "txtTenDangPhim";
            txtTenDangPhim.Size = new Size(304, 31);
            txtTenDangPhim.TabIndex = 22;
            // 
            // lblFormatID
            // 
            lblFormatID.AutoSize = true;
            lblFormatID.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormatID.Location = new Point(20, 26);
            lblFormatID.Margin = new Padding(4, 0, 4, 0);
            lblFormatID.Name = "lblFormatID";
            lblFormatID.Size = new Size(163, 26);
            lblFormatID.TabIndex = 19;
            lblFormatID.Text = "Mã định dạng:";
            // 
            // txtFormatID
            // 
            txtFormatID.Location = new Point(219, 24);
            txtFormatID.Margin = new Padding(4, 5, 4, 5);
            txtFormatID.Name = "txtFormatID";
            txtFormatID.Size = new Size(310, 31);
            txtFormatID.TabIndex = 14;
            // 
            // DinhDangPhimUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DinhDangPhimUC";
            Size = new Size(1935, 998);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFormat).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
    }
}
