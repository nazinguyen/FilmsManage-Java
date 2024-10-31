

namespace FilmsManage.GUI.Forms
{
    partial class CustomerUC
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
            txtSearchCus = new TextBox();
            btnDeleteCustomer = new Button();
            btnUpdateCustomer = new Button();
            btnAddCustomer = new Button();
            grpCustomer = new GroupBox();
            nudPoint = new NumericUpDown();
            lblCusID = new Label();
            txtCusID = new TextBox();
            txtCusAddress = new TextBox();
            lblCusINumber = new Label();
            txtCusName = new TextBox();
            lblCusBirth = new Label();
            txtCusPhone = new TextBox();
            lblCusPhone = new Label();
            lblCusPoint = new Label();
            txtCusBirth = new TextBox();
            lblCusAddress = new Label();
            txtCusINumber = new TextBox();
            lblCusName = new Label();
            btnShowCustomer = new Button();
            btnSearchCus = new Button();
            dtgvCustomer = new DataGridView();
            grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPoint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // txtSearchCus
            // 
            txtSearchCus.Location = new Point(33, 211);
            txtSearchCus.Name = "txtSearchCus";
            txtSearchCus.Size = new Size(162, 27);
            txtSearchCus.TabIndex = 20;
            txtSearchCus.KeyDown += txtSearchCus_KeyDown;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.BackColor = Color.FromArgb(133, 19, 33);
            btnDeleteCustomer.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnDeleteCustomer.ForeColor = Color.White;
            btnDeleteCustomer.Location = new Point(33, 520);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(209, 56);
            btnDeleteCustomer.TabIndex = 17;
            btnDeleteCustomer.Text = "Xóa";
            btnDeleteCustomer.UseVisualStyleBackColor = false;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.BackColor = Color.FromArgb(133, 19, 33);
            btnUpdateCustomer.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnUpdateCustomer.ForeColor = Color.White;
            btnUpdateCustomer.Location = new Point(33, 442);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(209, 55);
            btnUpdateCustomer.TabIndex = 18;
            btnUpdateCustomer.Text = "Sửa";
            btnUpdateCustomer.UseVisualStyleBackColor = false;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.FromArgb(133, 19, 33);
            btnAddCustomer.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnAddCustomer.ForeColor = Color.White;
            btnAddCustomer.Location = new Point(33, 359);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(209, 57);
            btnAddCustomer.TabIndex = 19;
            btnAddCustomer.Text = "Thêm";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // grpCustomer
            // 
            grpCustomer.BackColor = Color.Transparent;
            grpCustomer.Controls.Add(nudPoint);
            grpCustomer.Controls.Add(lblCusID);
            grpCustomer.Controls.Add(txtCusID);
            grpCustomer.Controls.Add(txtCusAddress);
            grpCustomer.Controls.Add(lblCusINumber);
            grpCustomer.Controls.Add(txtCusName);
            grpCustomer.Controls.Add(lblCusBirth);
            grpCustomer.Controls.Add(txtCusPhone);
            grpCustomer.Controls.Add(lblCusPhone);
            grpCustomer.Controls.Add(lblCusPoint);
            grpCustomer.Controls.Add(txtCusBirth);
            grpCustomer.Controls.Add(lblCusAddress);
            grpCustomer.Controls.Add(txtCusINumber);
            grpCustomer.Controls.Add(lblCusName);
            grpCustomer.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpCustomer.Location = new Point(86, 9);
            grpCustomer.Name = "grpCustomer";
            grpCustomer.Size = new Size(1133, 182);
            grpCustomer.TabIndex = 16;
            grpCustomer.TabStop = false;
            grpCustomer.Text = "Thông tin khách hàng";
            // 
            // nudPoint
            // 
            nudPoint.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudPoint.Location = new Point(974, 45);
            nudPoint.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudPoint.Name = "nudPoint";
            nudPoint.Size = new Size(75, 30);
            nudPoint.TabIndex = 5;
            nudPoint.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCusID
            // 
            lblCusID.AutoSize = true;
            lblCusID.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusID.Location = new Point(125, 49);
            lblCusID.Name = "lblCusID";
            lblCusID.Size = new Size(79, 23);
            lblCusID.TabIndex = 4;
            lblCusID.Text = "Mã KH:";
            // 
            // txtCusID
            // 
            txtCusID.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusID.Location = new Point(234, 46);
            txtCusID.Name = "txtCusID";
            txtCusID.Size = new Size(191, 30);
            txtCusID.TabIndex = 2;
            // 
            // txtCusAddress
            // 
            txtCusAddress.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusAddress.Location = new Point(604, 45);
            txtCusAddress.Name = "txtCusAddress";
            txtCusAddress.Size = new Size(191, 30);
            txtCusAddress.TabIndex = 2;
            // 
            // lblCusINumber
            // 
            lblCusINumber.AutoSize = true;
            lblCusINumber.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusINumber.Location = new Point(510, 135);
            lblCusINumber.Name = "lblCusINumber";
            lblCusINumber.Size = new Size(77, 23);
            lblCusINumber.TabIndex = 4;
            lblCusINumber.Text = "CMND:";
            // 
            // txtCusName
            // 
            txtCusName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusName.Location = new Point(234, 89);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(191, 30);
            txtCusName.TabIndex = 2;
            // 
            // lblCusBirth
            // 
            lblCusBirth.AutoSize = true;
            lblCusBirth.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusBirth.Location = new Point(125, 135);
            lblCusBirth.Name = "lblCusBirth";
            lblCusBirth.Size = new Size(99, 23);
            lblCusBirth.TabIndex = 4;
            lblCusBirth.Text = "Ngày sinh:";
            // 
            // txtCusPhone
            // 
            txtCusPhone.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusPhone.Location = new Point(604, 89);
            txtCusPhone.Name = "txtCusPhone";
            txtCusPhone.Size = new Size(191, 30);
            txtCusPhone.TabIndex = 2;
            // 
            // lblCusPhone
            // 
            lblCusPhone.AutoSize = true;
            lblCusPhone.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusPhone.Location = new Point(510, 94);
            lblCusPhone.Name = "lblCusPhone";
            lblCusPhone.Size = new Size(69, 23);
            lblCusPhone.TabIndex = 4;
            lblCusPhone.Text = "Số ĐT:";
            // 
            // lblCusPoint
            // 
            lblCusPoint.AutoSize = true;
            lblCusPoint.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusPoint.Location = new Point(840, 45);
            lblCusPoint.Name = "lblCusPoint";
            lblCusPoint.Size = new Size(128, 23);
            lblCusPoint.TabIndex = 4;
            lblCusPoint.Text = "Điểm tích lũy:";
            // 
            // txtCusBirth
            // 
            txtCusBirth.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusBirth.Location = new Point(234, 135);
            txtCusBirth.Name = "txtCusBirth";
            txtCusBirth.Size = new Size(191, 30);
            txtCusBirth.TabIndex = 2;
            // 
            // lblCusAddress
            // 
            lblCusAddress.AutoSize = true;
            lblCusAddress.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusAddress.Location = new Point(510, 49);
            lblCusAddress.Name = "lblCusAddress";
            lblCusAddress.Size = new Size(75, 23);
            lblCusAddress.TabIndex = 4;
            lblCusAddress.Text = "Địa chỉ:";
            // 
            // txtCusINumber
            // 
            txtCusINumber.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusINumber.Location = new Point(604, 135);
            txtCusINumber.Name = "txtCusINumber";
            txtCusINumber.Size = new Size(191, 30);
            txtCusINumber.TabIndex = 2;
            // 
            // lblCusName
            // 
            lblCusName.AutoSize = true;
            lblCusName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusName.Location = new Point(125, 94);
            lblCusName.Name = "lblCusName";
            lblCusName.Size = new Size(73, 23);
            lblCusName.TabIndex = 4;
            lblCusName.Text = "Họ tên:";
            // 
            // btnShowCustomer
            // 
            btnShowCustomer.AccessibleRole = AccessibleRole.ScrollBar;
            btnShowCustomer.BackColor = Color.FromArgb(133, 19, 33);
            btnShowCustomer.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnShowCustomer.ForeColor = Color.White;
            btnShowCustomer.ImageAlign = ContentAlignment.TopCenter;
            btnShowCustomer.Location = new Point(33, 278);
            btnShowCustomer.Name = "btnShowCustomer";
            btnShowCustomer.Size = new Size(209, 57);
            btnShowCustomer.TabIndex = 15;
            btnShowCustomer.Text = "Xem";
            btnShowCustomer.UseVisualStyleBackColor = false;
            btnShowCustomer.Click += btnShowCustomer_Click;
            // 
            // btnSearchCus
            // 
            btnSearchCus.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchCus.Location = new Point(215, 211);
            btnSearchCus.Name = "btnSearchCus";
            btnSearchCus.Size = new Size(27, 32);
            btnSearchCus.TabIndex = 21;
            btnSearchCus.UseVisualStyleBackColor = true;
            btnSearchCus.Click += btnSearchCus_Click;
            // 
            // dtgvCustomer
            // 
            dtgvCustomer.AllowUserToAddRows = false;
            dtgvCustomer.AllowUserToDeleteRows = false;
            dtgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCustomer.Location = new Point(318, 211);
            dtgvCustomer.Name = "dtgvCustomer";
            dtgvCustomer.ReadOnly = true;
            dtgvCustomer.RowHeadersWidth = 51;
            dtgvCustomer.RowTemplate.Height = 24;
            dtgvCustomer.Size = new Size(901, 363);
            dtgvCustomer.TabIndex = 14;
            // 
            // CustomerUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 621);
            ControlBox = false;
            Controls.Add(btnSearchCus);
            Controls.Add(txtSearchCus);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnUpdateCustomer);
            Controls.Add(btnAddCustomer);
            Controls.Add(grpCustomer);
            Controls.Add(btnShowCustomer);
            Controls.Add(dtgvCustomer);
            Name = "CustomerUC";
            grpCustomer.ResumeLayout(false);
            grpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPoint).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Button btnSearchCus;
        private System.Windows.Forms.TextBox txtSearchCus;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.NumericUpDown nudPoint;
        private System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.TextBox txtCusAddress;
        private System.Windows.Forms.Label lblCusINumber;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label lblCusBirth;
        private System.Windows.Forms.TextBox txtCusPhone;
        private System.Windows.Forms.Label lblCusPhone;
        private System.Windows.Forms.Label lblCusPoint;
        private System.Windows.Forms.TextBox txtCusBirth;
        private System.Windows.Forms.Label lblCusAddress;
        private System.Windows.Forms.TextBox txtCusINumber;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.Button btnShowCustomer;
        private DataGridView dtgvCustomer;
    }
}