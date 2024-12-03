namespace FilmsManage.GUI.UserControls.Data
{
    partial class CinemaUC
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
            btnShowCinema = new Button();
            btnUpdateCinema = new Button();
            btnInsertCinema = new Button();
            panel2 = new Panel();
            panel6 = new Panel();
            cboCinemaScreenType = new ComboBox();
            lblScreenType = new Label();
            panel15 = new Panel();
            txtSeatsPerRow = new TextBox();
            lblSeatsPerRow = new Label();
            panel12 = new Panel();
            txtNumberOfRows = new TextBox();
            panel8 = new Panel();
            txtCinemaSeats = new TextBox();
            lblCinemaSeats = new Label();
            panel31 = new Panel();
            txtCinemaName = new TextBox();
            lblCinemaName = new Label();
            panel32 = new Panel();
            txtCinemaID = new TextBox();
            lblCinemaID = new Label();
            panel1 = new Panel();
            dtgvCinema = new DataGridView();
            panel33 = new Panel();
            btnExport = new Button();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel15.SuspendLayout();
            panel12.SuspendLayout();
            panel8.SuspendLayout();
            panel31.SuspendLayout();
            panel32.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCinema).BeginInit();
            panel33.SuspendLayout();
            SuspendLayout();
            // 
            // btnShowCinema
            // 
            btnShowCinema.Location = new Point(240, 204);
            btnShowCinema.Margin = new Padding(4, 5, 4, 5);
            btnShowCinema.Name = "btnShowCinema";
            btnShowCinema.Size = new Size(100, 71);
            btnShowCinema.TabIndex = 3;
            btnShowCinema.Text = "Xem";
            btnShowCinema.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCinema
            // 
            btnUpdateCinema.Location = new Point(121, 204);
            btnUpdateCinema.Margin = new Padding(4, 5, 4, 5);
            btnUpdateCinema.Name = "btnUpdateCinema";
            btnUpdateCinema.Size = new Size(100, 71);
            btnUpdateCinema.TabIndex = 2;
            btnUpdateCinema.Text = "Sửa";
            btnUpdateCinema.UseVisualStyleBackColor = true;
            btnUpdateCinema.Click += btnUpdateCinema_Click;
            // 
            // btnInsertCinema
            // 
            btnInsertCinema.Location = new Point(4, 204);
            btnInsertCinema.Margin = new Padding(4, 5, 4, 5);
            btnInsertCinema.Name = "btnInsertCinema";
            btnInsertCinema.Size = new Size(100, 71);
            btnInsertCinema.TabIndex = 0;
            btnInsertCinema.Text = "Thêm";
            btnInsertCinema.UseVisualStyleBackColor = true;
            btnInsertCinema.Click += btnInsertCinema_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel15);
            panel2.Controls.Add(panel12);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel31);
            panel2.Controls.Add(panel32);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1007, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 518);
            panel2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(cboCinemaScreenType);
            panel6.Controls.Add(lblScreenType);
            panel6.Location = new Point(17, 159);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(412, 68);
            panel6.TabIndex = 4;
            // 
            // cboCinemaScreenType
            // 
            cboCinemaScreenType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCinemaScreenType.FormattingEnabled = true;
            cboCinemaScreenType.Location = new Point(176, 14);
            cboCinemaScreenType.Margin = new Padding(3, 2, 3, 2);
            cboCinemaScreenType.Name = "cboCinemaScreenType";
            cboCinemaScreenType.Size = new Size(214, 28);
            cboCinemaScreenType.TabIndex = 1;
            // 
            // lblScreenType
            // 
            lblScreenType.AutoSize = true;
            lblScreenType.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblScreenType.Location = new Point(4, 14);
            lblScreenType.Margin = new Padding(4, 0, 4, 0);
            lblScreenType.Name = "lblScreenType";
            lblScreenType.Size = new Size(105, 24);
            lblScreenType.TabIndex = 0;
            lblScreenType.Text = "Màn hình:";
            // 
            // panel15
            // 
            panel15.Controls.Add(txtSeatsPerRow);
            panel15.Controls.Add(lblSeatsPerRow);
            panel15.Location = new Point(17, 316);
            panel15.Margin = new Padding(4, 5, 4, 5);
            panel15.Name = "panel15";
            panel15.Size = new Size(412, 68);
            panel15.TabIndex = 5;
            // 
            // txtSeatsPerRow
            // 
            txtSeatsPerRow.Location = new Point(176, 14);
            txtSeatsPerRow.Margin = new Padding(4, 5, 4, 5);
            txtSeatsPerRow.Name = "txtSeatsPerRow";
            txtSeatsPerRow.Size = new Size(214, 27);
            txtSeatsPerRow.TabIndex = 1;
            // 
            // lblSeatsPerRow
            // 
            lblSeatsPerRow.AutoSize = true;
            lblSeatsPerRow.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblSeatsPerRow.Location = new Point(4, 14);
            lblSeatsPerRow.Margin = new Padding(4, 0, 4, 0);
            lblSeatsPerRow.Name = "lblSeatsPerRow";
            lblSeatsPerRow.Size = new Size(149, 24);
            lblSeatsPerRow.TabIndex = 0;
            lblSeatsPerRow.Text = "Ghế mỗi hàng:";
            // 
            // panel12
            // 
            panel12.Controls.Add(txtNumberOfRows);
            panel12.Location = new Point(17, 394);
            panel12.Margin = new Padding(4, 5, 4, 5);
            panel12.Name = "panel12";
            panel12.Size = new Size(412, 68);
            panel12.TabIndex = 6;
            // 
            // txtNumberOfRows
            // 
            txtNumberOfRows.Location = new Point(176, 18);
            txtNumberOfRows.Margin = new Padding(4, 5, 4, 5);
            txtNumberOfRows.Name = "txtNumberOfRows";
            txtNumberOfRows.Size = new Size(214, 27);
            txtNumberOfRows.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(txtCinemaSeats);
            panel8.Controls.Add(lblCinemaSeats);
            panel8.Location = new Point(17, 238);
            panel8.Margin = new Padding(4, 5, 4, 5);
            panel8.Name = "panel8";
            panel8.Size = new Size(412, 68);
            panel8.TabIndex = 8;
            // 
            // txtCinemaSeats
            // 
            txtCinemaSeats.Location = new Point(176, 18);
            txtCinemaSeats.Margin = new Padding(4, 5, 4, 5);
            txtCinemaSeats.Name = "txtCinemaSeats";
            txtCinemaSeats.Size = new Size(214, 27);
            txtCinemaSeats.TabIndex = 1;
            // 
            // lblCinemaSeats
            // 
            lblCinemaSeats.AutoSize = true;
            lblCinemaSeats.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblCinemaSeats.Location = new Point(4, 14);
            lblCinemaSeats.Margin = new Padding(4, 0, 4, 0);
            lblCinemaSeats.Name = "lblCinemaSeats";
            lblCinemaSeats.Size = new Size(130, 24);
            lblCinemaSeats.TabIndex = 0;
            lblCinemaSeats.Text = "Số chỗ ngồi:";
            // 
            // panel31
            // 
            panel31.Controls.Add(txtCinemaName);
            panel31.Controls.Add(lblCinemaName);
            panel31.Location = new Point(17, 81);
            panel31.Margin = new Padding(4, 5, 4, 5);
            panel31.Name = "panel31";
            panel31.Size = new Size(412, 68);
            panel31.TabIndex = 9;
            // 
            // txtCinemaName
            // 
            txtCinemaName.Location = new Point(176, 18);
            txtCinemaName.Margin = new Padding(4, 5, 4, 5);
            txtCinemaName.Name = "txtCinemaName";
            txtCinemaName.Size = new Size(214, 27);
            txtCinemaName.TabIndex = 1;
            // 
            // lblCinemaName
            // 
            lblCinemaName.AutoSize = true;
            lblCinemaName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblCinemaName.Location = new Point(4, 14);
            lblCinemaName.Margin = new Padding(4, 0, 4, 0);
            lblCinemaName.Name = "lblCinemaName";
            lblCinemaName.Size = new Size(119, 24);
            lblCinemaName.TabIndex = 0;
            lblCinemaName.Text = "Tên phòng:";
            // 
            // panel32
            // 
            panel32.Controls.Add(txtCinemaID);
            panel32.Controls.Add(lblCinemaID);
            panel32.Location = new Point(17, 5);
            panel32.Margin = new Padding(4, 5, 4, 5);
            panel32.Name = "panel32";
            panel32.Size = new Size(412, 68);
            panel32.TabIndex = 3;
            // 
            // txtCinemaID
            // 
            txtCinemaID.Location = new Point(176, 20);
            txtCinemaID.Margin = new Padding(4, 5, 4, 5);
            txtCinemaID.Name = "txtCinemaID";
            txtCinemaID.Size = new Size(216, 27);
            txtCinemaID.TabIndex = 1;
            // 
            // lblCinemaID
            // 
            lblCinemaID.AutoSize = true;
            lblCinemaID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblCinemaID.Location = new Point(4, 18);
            lblCinemaID.Margin = new Padding(4, 0, 4, 0);
            lblCinemaID.Name = "lblCinemaID";
            lblCinemaID.Size = new Size(111, 24);
            lblCinemaID.TabIndex = 0;
            lblCinemaID.Text = "Mã phòng:";
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvCinema);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 280);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1451, 518);
            panel1.TabIndex = 11;
            // 
            // dtgvCinema
            // 
            dtgvCinema.AllowUserToAddRows = false;
            dtgvCinema.AllowUserToDeleteRows = false;
            dtgvCinema.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCinema.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCinema.Dock = DockStyle.Fill;
            dtgvCinema.Location = new Point(0, 0);
            dtgvCinema.Margin = new Padding(4, 5, 4, 5);
            dtgvCinema.Name = "dtgvCinema";
            dtgvCinema.ReadOnly = true;
            dtgvCinema.RowHeadersWidth = 51;
            dtgvCinema.Size = new Size(1007, 518);
            dtgvCinema.TabIndex = 1;
            // 
            // panel33
            // 
            panel33.Controls.Add(btnExport);
            panel33.Controls.Add(btnShowCinema);
            panel33.Controls.Add(btnUpdateCinema);
            panel33.Controls.Add(btnInsertCinema);
            panel33.Dock = DockStyle.Top;
            panel33.Location = new Point(0, 0);
            panel33.Margin = new Padding(4, 5, 4, 5);
            panel33.Name = "panel33";
            panel33.Size = new Size(1451, 280);
            panel33.TabIndex = 10;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(362, 204);
            btnExport.Margin = new Padding(4, 5, 4, 5);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(100, 71);
            btnExport.TabIndex = 4;
            btnExport.Text = "Xuất File";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // CinemaUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel33);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CinemaUC";
            Size = new Size(1451, 798);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel31.ResumeLayout(false);
            panel31.PerformLayout();
            panel32.ResumeLayout(false);
            panel32.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCinema).EndInit();
            panel33.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Button btnShowCinema;
        private System.Windows.Forms.Button btnUpdateCinema;
        private System.Windows.Forms.Button btnInsertCinema;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Panel panel6;
        private ComboBox cboCinemaScreenType;
        private Label lblScreenType;
        private Panel panel15;
        private TextBox txtSeatsPerRow;
        private Label lblSeatsPerRow;
        private Panel panel12;
        private TextBox txtNumberOfRows;
        private Panel panel8;
        private TextBox txtCinemaSeats;
        private Label lblCinemaSeats;
        private Panel panel31;
        private TextBox txtCinemaName;
        private Label lblCinemaName;
        private Panel panel32;
        private TextBox txtCinemaID;
        private Label lblCinemaID;
        private DataGridView dtgvCinema;
        private Button btnExport;
    }
}