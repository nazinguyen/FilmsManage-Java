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
            panel33 = new Panel();
            btnShowCinema = new Button();
            btnUpdateCinema = new Button();
            btnDeleteCinema = new Button();
            btnInsertCinema = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            lblCinemaID = new Label();
            txtCinemaID = new TextBox();
            panel32 = new Panel();
            lblCinemaName = new Label();
            txtCinemaName = new TextBox();
            panel31 = new Panel();
            lblCinemaSeats = new Label();
            txtCinemaSeats = new TextBox();
            panel8 = new Panel();
            lblCinemaStatus = new Label();
            txtCinemaStatus = new TextBox();
            panel9 = new Panel();
            lblNumberOfRows = new Label();
            txtNumberOfRows = new TextBox();
            panel12 = new Panel();
            lblSeatsPerRow = new Label();
            txtSeatsPerRow = new TextBox();
            panel15 = new Panel();
            lblScreenType = new Label();
            cboCinemaScreenType = new ComboBox();
            panel6 = new Panel();
            dtgvCinema = new DataGridView();
            panel33.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel32.SuspendLayout();
            panel31.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel12.SuspendLayout();
            panel15.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCinema).BeginInit();
            SuspendLayout();
            // 
            // panel33
            // 
            panel33.Controls.Add(btnShowCinema);
            panel33.Controls.Add(btnUpdateCinema);
            panel33.Controls.Add(btnDeleteCinema);
            panel33.Controls.Add(btnInsertCinema);
            panel33.Dock = DockStyle.Top;
            panel33.Location = new Point(0, 0);
            panel33.Margin = new Padding(4, 5, 4, 5);
            panel33.Name = "panel33";
            panel33.Size = new Size(1451, 144);
            panel33.TabIndex = 10;
            // 
            // btnShowCinema
            // 
            btnShowCinema.Location = new Point(362, 39);
            btnShowCinema.Margin = new Padding(4, 5, 4, 5);
            btnShowCinema.Name = "btnShowCinema";
            btnShowCinema.Size = new Size(100, 71);
            btnShowCinema.TabIndex = 3;
            btnShowCinema.Text = "Xem";
            btnShowCinema.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCinema
            // 
            btnUpdateCinema.Location = new Point(254, 39);
            btnUpdateCinema.Margin = new Padding(4, 5, 4, 5);
            btnUpdateCinema.Name = "btnUpdateCinema";
            btnUpdateCinema.Size = new Size(100, 71);
            btnUpdateCinema.TabIndex = 2;
            btnUpdateCinema.Text = "Sửa";
            btnUpdateCinema.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCinema
            // 
            btnDeleteCinema.Location = new Point(146, 39);
            btnDeleteCinema.Margin = new Padding(4, 5, 4, 5);
            btnDeleteCinema.Name = "btnDeleteCinema";
            btnDeleteCinema.Size = new Size(100, 71);
            btnDeleteCinema.TabIndex = 1;
            btnDeleteCinema.Text = "Xóa";
            btnDeleteCinema.UseVisualStyleBackColor = true;
            // 
            // btnInsertCinema
            // 
            btnInsertCinema.Location = new Point(38, 39);
            btnInsertCinema.Margin = new Padding(4, 5, 4, 5);
            btnInsertCinema.Name = "btnInsertCinema";
            btnInsertCinema.Size = new Size(100, 71);
            btnInsertCinema.TabIndex = 0;
            btnInsertCinema.Text = "Thêm";
            btnInsertCinema.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel15);
            panel2.Controls.Add(panel12);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel31);
            panel2.Controls.Add(panel32);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1007, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 654);
            panel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvCinema);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 144);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1451, 654);
            panel1.TabIndex = 11;
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
            // txtCinemaID
            // 
            txtCinemaID.Location = new Point(176, 20);
            txtCinemaID.Margin = new Padding(4, 5, 4, 5);
            txtCinemaID.Name = "txtCinemaID";
            txtCinemaID.Size = new Size(216, 27);
            txtCinemaID.TabIndex = 1;
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
            // txtCinemaName
            // 
            txtCinemaName.Location = new Point(176, 18);
            txtCinemaName.Margin = new Padding(4, 5, 4, 5);
            txtCinemaName.Name = "txtCinemaName";
            txtCinemaName.Size = new Size(214, 27);
            txtCinemaName.TabIndex = 1;
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
            // txtCinemaSeats
            // 
            txtCinemaSeats.Location = new Point(176, 18);
            txtCinemaSeats.Margin = new Padding(4, 5, 4, 5);
            txtCinemaSeats.Name = "txtCinemaSeats";
            txtCinemaSeats.Size = new Size(214, 27);
            txtCinemaSeats.TabIndex = 1;
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
            // lblCinemaStatus
            // 
            lblCinemaStatus.AutoSize = true;
            lblCinemaStatus.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblCinemaStatus.Location = new Point(4, 14);
            lblCinemaStatus.Margin = new Padding(4, 0, 4, 0);
            lblCinemaStatus.Name = "lblCinemaStatus";
            lblCinemaStatus.Size = new Size(116, 24);
            lblCinemaStatus.TabIndex = 0;
            lblCinemaStatus.Text = "Tình trạng:";
            // 
            // txtCinemaStatus
            // 
            txtCinemaStatus.Location = new Point(176, 18);
            txtCinemaStatus.Margin = new Padding(4, 5, 4, 5);
            txtCinemaStatus.Name = "txtCinemaStatus";
            txtCinemaStatus.Size = new Size(214, 27);
            txtCinemaStatus.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Controls.Add(txtCinemaStatus);
            panel9.Controls.Add(lblCinemaStatus);
            panel9.Location = new Point(17, 314);
            panel9.Margin = new Padding(4, 5, 4, 5);
            panel9.Name = "panel9";
            panel9.Size = new Size(412, 68);
            panel9.TabIndex = 7;
            // 
            // lblNumberOfRows
            // 
            lblNumberOfRows.AutoSize = true;
            lblNumberOfRows.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblNumberOfRows.Location = new Point(4, 14);
            lblNumberOfRows.Margin = new Padding(4, 0, 4, 0);
            lblNumberOfRows.Name = "lblNumberOfRows";
            lblNumberOfRows.Size = new Size(136, 24);
            lblNumberOfRows.TabIndex = 0;
            lblNumberOfRows.Text = "Số hàng ghế:";
            // 
            // txtNumberOfRows
            // 
            txtNumberOfRows.Location = new Point(176, 18);
            txtNumberOfRows.Margin = new Padding(4, 5, 4, 5);
            txtNumberOfRows.Name = "txtNumberOfRows";
            txtNumberOfRows.Size = new Size(214, 27);
            txtNumberOfRows.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.Controls.Add(txtNumberOfRows);
            panel12.Controls.Add(lblNumberOfRows);
            panel12.Location = new Point(17, 391);
            panel12.Margin = new Padding(4, 5, 4, 5);
            panel12.Name = "panel12";
            panel12.Size = new Size(412, 68);
            panel12.TabIndex = 6;
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
            // txtSeatsPerRow
            // 
            txtSeatsPerRow.Location = new Point(176, 14);
            txtSeatsPerRow.Margin = new Padding(4, 5, 4, 5);
            txtSeatsPerRow.Name = "txtSeatsPerRow";
            txtSeatsPerRow.Size = new Size(214, 27);
            txtSeatsPerRow.TabIndex = 1;
            // 
            // panel15
            // 
            panel15.Controls.Add(txtSeatsPerRow);
            panel15.Controls.Add(lblSeatsPerRow);
            panel15.Location = new Point(17, 469);
            panel15.Margin = new Padding(4, 5, 4, 5);
            panel15.Name = "panel15";
            panel15.Size = new Size(412, 68);
            panel15.TabIndex = 5;
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
            dtgvCinema.Size = new Size(1007, 654);
            dtgvCinema.TabIndex = 1;
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
            panel33.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel32.ResumeLayout(false);
            panel32.PerformLayout();
            panel31.ResumeLayout(false);
            panel31.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCinema).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Button btnShowCinema;
        private System.Windows.Forms.Button btnUpdateCinema;
        private System.Windows.Forms.Button btnDeleteCinema;
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
        private Label lblNumberOfRows;
        private Panel panel9;
        private TextBox txtCinemaStatus;
        private Label lblCinemaStatus;
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
    }
}
