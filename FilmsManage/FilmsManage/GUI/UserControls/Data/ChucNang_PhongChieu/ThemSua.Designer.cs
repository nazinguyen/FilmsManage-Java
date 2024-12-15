namespace FilmsManage.GUI.UserControls.Data.ChucNang_PhongChieu
{
    partial class ThemSua
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
            cboCinemaScreenType = new ComboBox();
            lblScreenType = new Label();
            txtSeatsPerRow = new TextBox();
            lblSeatsPerRow = new Label();
            panel8 = new Panel();
            txtCinemaSeats = new TextBox();
            lblCinemaSeats = new Label();
            panel31 = new Panel();
            txtCinemaName = new TextBox();
            lblCinemaName = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnHuy = new Button();
            panel8.SuspendLayout();
            panel31.SuspendLayout();
            SuspendLayout();
            // 
            // cboCinemaScreenType
            // 
            cboCinemaScreenType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCinemaScreenType.FormattingEnabled = true;
            cboCinemaScreenType.Location = new Point(410, 240);
            cboCinemaScreenType.Margin = new Padding(4, 2, 4, 2);
            cboCinemaScreenType.Name = "cboCinemaScreenType";
            cboCinemaScreenType.Size = new Size(266, 33);
            cboCinemaScreenType.TabIndex = 1;
            // 
            // lblScreenType
            // 
            lblScreenType.AutoSize = true;
            lblScreenType.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblScreenType.Location = new Point(195, 244);
            lblScreenType.Margin = new Padding(5, 0, 5, 0);
            lblScreenType.Name = "lblScreenType";
            lblScreenType.Size = new Size(128, 29);
            lblScreenType.TabIndex = 0;
            lblScreenType.Text = "Màn hình:";
            // 
            // txtSeatsPerRow
            // 
            txtSeatsPerRow.Location = new Point(1042, 238);
            txtSeatsPerRow.Margin = new Padding(5, 6, 5, 6);
            txtSeatsPerRow.Name = "txtSeatsPerRow";
            txtSeatsPerRow.Size = new Size(266, 31);
            txtSeatsPerRow.TabIndex = 1;
            // 
            // lblSeatsPerRow
            // 
            lblSeatsPerRow.AutoSize = true;
            lblSeatsPerRow.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblSeatsPerRow.Location = new Point(822, 240);
            lblSeatsPerRow.Margin = new Padding(5, 0, 5, 0);
            lblSeatsPerRow.Name = "lblSeatsPerRow";
            lblSeatsPerRow.Size = new Size(182, 29);
            lblSeatsPerRow.TabIndex = 0;
            lblSeatsPerRow.Text = "Ghế mỗi hàng:";
            // 
            // panel8
            // 
            panel8.Controls.Add(txtCinemaSeats);
            panel8.Controls.Add(lblCinemaSeats);
            panel8.Location = new Point(822, 76);
            panel8.Margin = new Padding(5, 6, 5, 6);
            panel8.Name = "panel8";
            panel8.Size = new Size(515, 85);
            panel8.TabIndex = 13;
            // 
            // txtCinemaSeats
            // 
            txtCinemaSeats.Location = new Point(220, 22);
            txtCinemaSeats.Margin = new Padding(5, 6, 5, 6);
            txtCinemaSeats.Name = "txtCinemaSeats";
            txtCinemaSeats.Size = new Size(266, 31);
            txtCinemaSeats.TabIndex = 1;
            // 
            // lblCinemaSeats
            // 
            lblCinemaSeats.AutoSize = true;
            lblCinemaSeats.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblCinemaSeats.Location = new Point(5, 18);
            lblCinemaSeats.Margin = new Padding(5, 0, 5, 0);
            lblCinemaSeats.Name = "lblCinemaSeats";
            lblCinemaSeats.Size = new Size(160, 29);
            lblCinemaSeats.TabIndex = 0;
            lblCinemaSeats.Text = "Số chỗ ngồi:";
            // 
            // panel31
            // 
            panel31.Controls.Add(txtCinemaName);
            panel31.Controls.Add(lblCinemaName);
            panel31.Location = new Point(190, 76);
            panel31.Margin = new Padding(5, 6, 5, 6);
            panel31.Name = "panel31";
            panel31.Size = new Size(515, 85);
            panel31.TabIndex = 14;
            // 
            // txtCinemaName
            // 
            txtCinemaName.Location = new Point(220, 22);
            txtCinemaName.Margin = new Padding(5, 6, 5, 6);
            txtCinemaName.Name = "txtCinemaName";
            txtCinemaName.Size = new Size(266, 31);
            txtCinemaName.TabIndex = 1;
            // 
            // lblCinemaName
            // 
            lblCinemaName.AutoSize = true;
            lblCinemaName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblCinemaName.Location = new Point(5, 18);
            lblCinemaName.Margin = new Padding(5, 0, 5, 0);
            lblCinemaName.Name = "lblCinemaName";
            lblCinemaName.Size = new Size(145, 29);
            lblCinemaName.TabIndex = 0;
            lblCinemaName.Text = "Tên phòng:";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(828, 474);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(378, 54);
            btnThem.TabIndex = 141;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(826, 474);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(378, 54);
            btnSua.TabIndex = 140;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(351, 474);
            btnHuy.Margin = new Padding(2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(378, 54);
            btnHuy.TabIndex = 139;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // ThemSua
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtSeatsPerRow);
            Controls.Add(cboCinemaScreenType);
            Controls.Add(lblSeatsPerRow);
            Controls.Add(lblScreenType);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnHuy);
            Controls.Add(panel8);
            Controls.Add(panel31);
            Margin = new Padding(4);
            Name = "ThemSua";
            Size = new Size(1542, 888);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel31.ResumeLayout(false);
            panel31.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cboCinemaScreenType;
        private Label lblScreenType;
        private TextBox txtSeatsPerRow;
        private Label lblSeatsPerRow;
        private Panel panel8;
        private TextBox txtCinemaSeats;
        private Label lblCinemaSeats;
        private Panel panel31;
        private TextBox txtCinemaName;
        private Label lblCinemaName;
        private Button btnThem;
        private Button btnSua;
        private Button btnHuy;
    }
}
