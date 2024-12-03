namespace FilmsManage.GUI.UserControls
{
    partial class Staff
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
            txtStaffName = new TextBox();
            btnAddStaff = new Button();
            lblStaffID = new Label();
            txtStaffId = new TextBox();
            txtStaffEmail = new TextBox();
            lblStaffINumber = new Label();
            lblStaffBirth = new Label();
            txtStaffPass = new TextBox();
            lblStaffPhone = new Label();
            btnSearchStaff = new Button();
            txtSearchStaff = new TextBox();
            btnDeleteStaff = new Button();
            btnUpdateStaff = new Button();
            txtStaffPhone = new TextBox();
            lblStaffEmail = new Label();
            grpStaff = new GroupBox();
            txtTenQuyen = new TextBox();
            lblStaffRole = new Label();
            cbbMaQuyen = new ComboBox();
            lblStaffName = new Label();
            btnShowStaff = new Button();
            dtgvStaff = new DataGridView();
            lblTimKiem = new Label();
            grpStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStaff).BeginInit();
            SuspendLayout();
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffName.Location = new Point(187, 111);
            txtStaffName.Margin = new Padding(3, 4, 3, 4);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(237, 35);
            txtStaffName.TabIndex = 2;
            // 
            // btnAddStaff
            // 
            btnAddStaff.BackColor = Color.FromArgb(133, 19, 33);
            btnAddStaff.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnAddStaff.ForeColor = Color.White;
            btnAddStaff.Location = new Point(78, 429);
            btnAddStaff.Margin = new Padding(3, 4, 3, 4);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Size = new Size(171, 58);
            btnAddStaff.TabIndex = 20;
            btnAddStaff.Text = "Thêm";
            btnAddStaff.UseVisualStyleBackColor = false;
            btnAddStaff.Click += btnAddStaff_Click;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffID.Location = new Point(30, 61);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(93, 26);
            lblStaffID.TabIndex = 4;
            lblStaffID.Text = "Mã NV:";
            // 
            // txtStaffId
            // 
            txtStaffId.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffId.Location = new Point(187, 50);
            txtStaffId.Margin = new Padding(3, 4, 3, 4);
            txtStaffId.Name = "txtStaffId";
            txtStaffId.ReadOnly = true;
            txtStaffId.Size = new Size(237, 35);
            txtStaffId.TabIndex = 2;
            // 
            // txtStaffEmail
            // 
            txtStaffEmail.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffEmail.Location = new Point(651, 109);
            txtStaffEmail.Margin = new Padding(3, 4, 3, 4);
            txtStaffEmail.Name = "txtStaffEmail";
            txtStaffEmail.Size = new Size(237, 35);
            txtStaffEmail.TabIndex = 2;
            // 
            // lblStaffINumber
            // 
            lblStaffINumber.AutoSize = true;
            lblStaffINumber.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffINumber.Location = new Point(941, 114);
            lblStaffINumber.Name = "lblStaffINumber";
            lblStaffINumber.Size = new Size(135, 26);
            lblStaffINumber.TabIndex = 4;
            lblStaffINumber.Text = "Mã Quyền :";
            // 
            // lblStaffBirth
            // 
            lblStaffBirth.AutoSize = true;
            lblStaffBirth.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffBirth.Location = new Point(30, 169);
            lblStaffBirth.Name = "lblStaffBirth";
            lblStaffBirth.Size = new Size(81, 26);
            lblStaffBirth.TabIndex = 4;
            lblStaffBirth.Text = "Số ĐT:";
            // 
            // txtStaffPass
            // 
            txtStaffPass.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffPass.Location = new Point(651, 169);
            txtStaffPass.Margin = new Padding(3, 4, 3, 4);
            txtStaffPass.Name = "txtStaffPass";
            txtStaffPass.Size = new Size(237, 35);
            txtStaffPass.TabIndex = 2;
            // 
            // lblStaffPhone
            // 
            lblStaffPhone.AutoSize = true;
            lblStaffPhone.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffPhone.Location = new Point(510, 178);
            lblStaffPhone.Name = "lblStaffPhone";
            lblStaffPhone.Size = new Size(126, 26);
            lblStaffPhone.TabIndex = 4;
            lblStaffPhone.Text = "Mật khẩu :";
            // 
            // btnSearchStaff
            // 
            btnSearchStaff.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchStaff.Image = Properties.Resources.search_icon;
            btnSearchStaff.Location = new Point(1248, 272);
            btnSearchStaff.Margin = new Padding(3, 4, 3, 4);
            btnSearchStaff.Name = "btnSearchStaff";
            btnSearchStaff.Size = new Size(70, 40);
            btnSearchStaff.TabIndex = 22;
            btnSearchStaff.UseVisualStyleBackColor = true;
            btnSearchStaff.Click += btnSearchStaff_Click;
            // 
            // txtSearchStaff
            // 
            txtSearchStaff.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtSearchStaff.Location = new Point(1035, 273);
            txtSearchStaff.Margin = new Padding(3, 4, 3, 4);
            txtSearchStaff.Name = "txtSearchStaff";
            txtSearchStaff.Size = new Size(164, 37);
            txtSearchStaff.TabIndex = 21;
            // 
            // btnDeleteStaff
            // 
            btnDeleteStaff.BackColor = Color.FromArgb(133, 19, 33);
            btnDeleteStaff.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnDeleteStaff.ForeColor = Color.White;
            btnDeleteStaff.Location = new Point(78, 632);
            btnDeleteStaff.Margin = new Padding(3, 4, 3, 4);
            btnDeleteStaff.Name = "btnDeleteStaff";
            btnDeleteStaff.Size = new Size(171, 60);
            btnDeleteStaff.TabIndex = 18;
            btnDeleteStaff.Text = "Xóa";
            btnDeleteStaff.UseVisualStyleBackColor = false;
            btnDeleteStaff.Click += btnDeleteStaff_Click;
            // 
            // btnUpdateStaff
            // 
            btnUpdateStaff.BackColor = Color.FromArgb(133, 19, 33);
            btnUpdateStaff.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnUpdateStaff.ForeColor = Color.White;
            btnUpdateStaff.Location = new Point(78, 530);
            btnUpdateStaff.Margin = new Padding(3, 4, 3, 4);
            btnUpdateStaff.Name = "btnUpdateStaff";
            btnUpdateStaff.Size = new Size(171, 64);
            btnUpdateStaff.TabIndex = 19;
            btnUpdateStaff.Text = "Sửa";
            btnUpdateStaff.UseVisualStyleBackColor = false;
            btnUpdateStaff.Click += btnUpdateStaff_Click;
            // 
            // txtStaffPhone
            // 
            txtStaffPhone.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffPhone.Location = new Point(187, 165);
            txtStaffPhone.Margin = new Padding(3, 4, 3, 4);
            txtStaffPhone.Name = "txtStaffPhone";
            txtStaffPhone.Size = new Size(237, 35);
            txtStaffPhone.TabIndex = 2;
            // 
            // lblStaffEmail
            // 
            lblStaffEmail.AutoSize = true;
            lblStaffEmail.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffEmail.Location = new Point(510, 120);
            lblStaffEmail.Name = "lblStaffEmail";
            lblStaffEmail.Size = new Size(81, 26);
            lblStaffEmail.TabIndex = 4;
            lblStaffEmail.Text = "Email:";
            // 
            // grpStaff
            // 
            grpStaff.BackColor = Color.Transparent;
            grpStaff.Controls.Add(txtTenQuyen);
            grpStaff.Controls.Add(lblStaffRole);
            grpStaff.Controls.Add(cbbMaQuyen);
            grpStaff.Controls.Add(lblStaffID);
            grpStaff.Controls.Add(txtStaffId);
            grpStaff.Controls.Add(txtStaffEmail);
            grpStaff.Controls.Add(lblStaffINumber);
            grpStaff.Controls.Add(txtStaffName);
            grpStaff.Controls.Add(lblStaffBirth);
            grpStaff.Controls.Add(txtStaffPass);
            grpStaff.Controls.Add(lblStaffPhone);
            grpStaff.Controls.Add(txtStaffPhone);
            grpStaff.Controls.Add(lblStaffEmail);
            grpStaff.Controls.Add(lblStaffName);
            grpStaff.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpStaff.Location = new Point(78, 22);
            grpStaff.Margin = new Padding(3, 4, 3, 4);
            grpStaff.Name = "grpStaff";
            grpStaff.Padding = new Padding(3, 4, 3, 4);
            grpStaff.Size = new Size(1339, 228);
            grpStaff.TabIndex = 23;
            grpStaff.TabStop = false;
            grpStaff.Text = "Thông tin nhân viên";
            // 
            // txtTenQuyen
            // 
            txtTenQuyen.Location = new Point(1080, 178);
            txtTenQuyen.Name = "txtTenQuyen";
            txtTenQuyen.Size = new Size(234, 35);
            txtTenQuyen.TabIndex = 7;
            // 
            // lblStaffRole
            // 
            lblStaffRole.AutoSize = true;
            lblStaffRole.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblStaffRole.Location = new Point(941, 178);
            lblStaffRole.Name = "lblStaffRole";
            lblStaffRole.Size = new Size(133, 26);
            lblStaffRole.TabIndex = 6;
            lblStaffRole.Text = "Tên quyền: ";
            // 
            // cbbMaQuyen
            // 
            cbbMaQuyen.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            cbbMaQuyen.FormattingEnabled = true;
            cbbMaQuyen.Location = new Point(1080, 109);
            cbbMaQuyen.Name = "cbbMaQuyen";
            cbbMaQuyen.Size = new Size(237, 34);
            cbbMaQuyen.TabIndex = 5;
            cbbMaQuyen.SelectedIndexChanged += cbbMaQuyen_SelectedIndexChanged_1;
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffName.Location = new Point(30, 118);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(97, 26);
            lblStaffName.TabIndex = 4;
            lblStaffName.Text = "Tên NV:";
            // 
            // btnShowStaff
            // 
            btnShowStaff.BackColor = Color.FromArgb(133, 19, 33);
            btnShowStaff.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnShowStaff.ForeColor = Color.White;
            btnShowStaff.Location = new Point(78, 333);
            btnShowStaff.Margin = new Padding(3, 4, 3, 4);
            btnShowStaff.Name = "btnShowStaff";
            btnShowStaff.Size = new Size(171, 64);
            btnShowStaff.TabIndex = 17;
            btnShowStaff.Text = "Xem";
            btnShowStaff.UseVisualStyleBackColor = false;
            btnShowStaff.Click += btnShowStaff_Click;
            // 
            // dtgvStaff
            // 
            dtgvStaff.AllowUserToAddRows = false;
            dtgvStaff.AllowUserToDeleteRows = false;
            dtgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStaff.Location = new Point(276, 333);
            dtgvStaff.Margin = new Padding(4, 6, 4, 6);
            dtgvStaff.Name = "dtgvStaff";
            dtgvStaff.ReadOnly = true;
            dtgvStaff.RowHeadersWidth = 62;
            dtgvStaff.Size = new Size(1141, 392);
            dtgvStaff.TabIndex = 16;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblTimKiem.Location = new Point(870, 279);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(136, 27);
            lblTimKiem.TabIndex = 24;
            lblTimKiem.Text = "Tìm theo tên";
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTimKiem);
            Controls.Add(btnAddStaff);
            Controls.Add(btnSearchStaff);
            Controls.Add(txtSearchStaff);
            Controls.Add(btnDeleteStaff);
            Controls.Add(btnUpdateStaff);
            Controls.Add(grpStaff);
            Controls.Add(btnShowStaff);
            Controls.Add(dtgvStaff);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Staff";
            Size = new Size(1440, 747);
            grpStaff.ResumeLayout(false);
            grpStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.TextBox txtStaffEmail;
        private System.Windows.Forms.Label lblStaffINumber;
        private System.Windows.Forms.Label lblStaffBirth;
        private System.Windows.Forms.TextBox txtStaffPass;
        private System.Windows.Forms.Label lblStaffPhone;
        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.TextBox txtSearchStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.TextBox txtStaffBirth;
        private System.Windows.Forms.Label lblStaffEmail;
        private System.Windows.Forms.GroupBox grpStaff;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Button btnShowStaff;
        private System.Windows.Forms.DataGridView dtgvStaff;
        private Label lblTimKiem;
        private TextBox txtStaffPhone;
        private ComboBox cbbMaQuyen;
        private Label lblStaffRole;
        private TextBox txtTenQuyen;
    }
}
