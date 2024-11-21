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
            btnDeleteFormat = new Button();
            btnInsertFormat = new Button();
            panel2 = new Panel();
            dtgvFormat = new DataGridView();
            panel3 = new Panel();
            cboFormat_ScreenID = new ComboBox();
            lblFormat_ScreenName = new Label();
            cboFormat_MovieID = new ComboBox();
            lblFormat_ScreenID = new Label();
            lblFormat_MovieName = new Label();
            lblFormat_MovieID = new Label();
            txtFormat_ScreenName = new TextBox();
            lblFormatID = new Label();
            txtFormat_MovieName = new TextBox();
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
            panel1.Controls.Add(btnDeleteFormat);
            panel1.Controls.Add(btnInsertFormat);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1548, 80);
            panel1.TabIndex = 0;
            // 
            // btnShowFormat
            // 
            btnShowFormat.Location = new Point(328, 5);
            btnShowFormat.Margin = new Padding(4, 5, 4, 5);
            btnShowFormat.Name = "btnShowFormat";
            btnShowFormat.Size = new Size(100, 71);
            btnShowFormat.TabIndex = 11;
            btnShowFormat.Text = "Xem";
            btnShowFormat.UseVisualStyleBackColor = true;
            // 
            // btnUpdateFormat
            // 
            btnUpdateFormat.Location = new Point(220, 5);
            btnUpdateFormat.Margin = new Padding(4, 5, 4, 5);
            btnUpdateFormat.Name = "btnUpdateFormat";
            btnUpdateFormat.Size = new Size(100, 71);
            btnUpdateFormat.TabIndex = 10;
            btnUpdateFormat.Text = "Sửa";
            btnUpdateFormat.UseVisualStyleBackColor = true;
            btnUpdateFormat.Click += btnUpdateFormat_Click;
            // 
            // btnDeleteFormat
            // 
            btnDeleteFormat.Location = new Point(112, 5);
            btnDeleteFormat.Margin = new Padding(4, 5, 4, 5);
            btnDeleteFormat.Name = "btnDeleteFormat";
            btnDeleteFormat.Size = new Size(100, 71);
            btnDeleteFormat.TabIndex = 9;
            btnDeleteFormat.Text = "Xóa";
            btnDeleteFormat.UseVisualStyleBackColor = true;
            // 
            // btnInsertFormat
            // 
            btnInsertFormat.Location = new Point(4, 5);
            btnInsertFormat.Margin = new Padding(4, 5, 4, 5);
            btnInsertFormat.Name = "btnInsertFormat";
            btnInsertFormat.Size = new Size(100, 71);
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
            panel2.Location = new Point(0, 80);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1548, 718);
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
            dtgvFormat.Size = new Size(1011, 718);
            dtgvFormat.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(cboFormat_ScreenID);
            panel3.Controls.Add(lblFormat_ScreenName);
            panel3.Controls.Add(cboFormat_MovieID);
            panel3.Controls.Add(lblFormat_ScreenID);
            panel3.Controls.Add(lblFormat_MovieName);
            panel3.Controls.Add(lblFormat_MovieID);
            panel3.Controls.Add(txtFormat_ScreenName);
            panel3.Controls.Add(lblFormatID);
            panel3.Controls.Add(txtFormat_MovieName);
            panel3.Controls.Add(txtFormatID);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1011, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(537, 718);
            panel3.TabIndex = 0;
            // 
            // cboFormat_ScreenID
            // 
            cboFormat_ScreenID.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormat_ScreenID.FormattingEnabled = true;
            cboFormat_ScreenID.Location = new Point(170, 215);
            cboFormat_ScreenID.Margin = new Padding(3, 4, 3, 4);
            cboFormat_ScreenID.Name = "cboFormat_ScreenID";
            cboFormat_ScreenID.Size = new Size(249, 28);
            cboFormat_ScreenID.TabIndex = 20;
            // 
            // lblFormat_ScreenName
            // 
            lblFormat_ScreenName.AutoSize = true;
            lblFormat_ScreenName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormat_ScreenName.Location = new Point(12, 258);
            lblFormat_ScreenName.Name = "lblFormat_ScreenName";
            lblFormat_ScreenName.Size = new Size(130, 23);
            lblFormat_ScreenName.TabIndex = 15;
            lblFormat_ScreenName.Text = "Tên màn hình:";
            // 
            // cboFormat_MovieID
            // 
            cboFormat_MovieID.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormat_MovieID.FormattingEnabled = true;
            cboFormat_MovieID.Location = new Point(170, 98);
            cboFormat_MovieID.Margin = new Padding(3, 4, 3, 4);
            cboFormat_MovieID.Name = "cboFormat_MovieID";
            cboFormat_MovieID.Size = new Size(249, 28);
            cboFormat_MovieID.TabIndex = 21;
            // 
            // lblFormat_ScreenID
            // 
            lblFormat_ScreenID.AutoSize = true;
            lblFormat_ScreenID.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormat_ScreenID.Location = new Point(12, 216);
            lblFormat_ScreenID.Name = "lblFormat_ScreenID";
            lblFormat_ScreenID.Size = new Size(126, 23);
            lblFormat_ScreenID.TabIndex = 16;
            lblFormat_ScreenID.Text = "Mã màn hình:";
            // 
            // lblFormat_MovieName
            // 
            lblFormat_MovieName.AutoSize = true;
            lblFormat_MovieName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormat_MovieName.Location = new Point(12, 140);
            lblFormat_MovieName.Name = "lblFormat_MovieName";
            lblFormat_MovieName.Size = new Size(94, 23);
            lblFormat_MovieName.TabIndex = 17;
            lblFormat_MovieName.Text = "Tên phim:";
            // 
            // lblFormat_MovieID
            // 
            lblFormat_MovieID.AutoSize = true;
            lblFormat_MovieID.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormat_MovieID.Location = new Point(12, 99);
            lblFormat_MovieID.Name = "lblFormat_MovieID";
            lblFormat_MovieID.Size = new Size(90, 23);
            lblFormat_MovieID.TabIndex = 18;
            lblFormat_MovieID.Text = "Mã phim:";
            // 
            // txtFormat_ScreenName
            // 
            txtFormat_ScreenName.Location = new Point(170, 261);
            txtFormat_ScreenName.Margin = new Padding(3, 4, 3, 4);
            txtFormat_ScreenName.Name = "txtFormat_ScreenName";
            txtFormat_ScreenName.ReadOnly = true;
            txtFormat_ScreenName.Size = new Size(249, 27);
            txtFormat_ScreenName.TabIndex = 12;
            // 
            // lblFormatID
            // 
            lblFormatID.AutoSize = true;
            lblFormatID.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormatID.Location = new Point(12, 21);
            lblFormatID.Name = "lblFormatID";
            lblFormatID.Size = new Size(130, 23);
            lblFormatID.TabIndex = 19;
            lblFormatID.Text = "Mã định dạng:";
            // 
            // txtFormat_MovieName
            // 
            txtFormat_MovieName.Location = new Point(170, 139);
            txtFormat_MovieName.Margin = new Padding(3, 4, 3, 4);
            txtFormat_MovieName.Name = "txtFormat_MovieName";
            txtFormat_MovieName.ReadOnly = true;
            txtFormat_MovieName.Size = new Size(249, 27);
            txtFormat_MovieName.TabIndex = 13;
            // 
            // txtFormatID
            // 
            txtFormatID.Location = new Point(170, 20);
            txtFormatID.Margin = new Padding(3, 4, 3, 4);
            txtFormatID.Name = "txtFormatID";
            txtFormatID.Size = new Size(249, 27);
            txtFormatID.TabIndex = 14;
            // 
            // DinhDangPhimUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DinhDangPhimUC";
            Size = new Size(1548, 798);
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
        private System.Windows.Forms.ComboBox cboFormat_ScreenID;
        private System.Windows.Forms.Label lblFormat_ScreenName;
        private System.Windows.Forms.ComboBox cboFormat_MovieID;
        private System.Windows.Forms.Label lblFormat_ScreenID;
        private System.Windows.Forms.Label lblFormat_MovieName;
        private System.Windows.Forms.Label lblFormat_MovieID;
        private System.Windows.Forms.TextBox txtFormat_ScreenName;
        private System.Windows.Forms.Label lblFormatID;
        private System.Windows.Forms.TextBox txtFormat_MovieName;
        private System.Windows.Forms.TextBox txtFormatID;
        private System.Windows.Forms.DataGridView dtgvFormat;
    }
}
