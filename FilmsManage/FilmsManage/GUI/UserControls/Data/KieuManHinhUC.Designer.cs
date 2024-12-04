namespace FilmsManage.GUI.UserControls.Data
{
    partial class KieuManHinhUC
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
            btnShowScreenType = new Button();
            btnUpdateScreenType = new Button();
            btnDeleteScreenType = new Button();
            btnInsertScreenType = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            panel20 = new Panel();
            txtScreenTypeName = new TextBox();
            lblScreenTypeName = new Label();
            panel21 = new Panel();
            txtScreenTypeID = new TextBox();
            lblScreenTypeID = new Label();
            panel3 = new Panel();
            dtgvScreenType = new DataGridView();
            btnExport = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel20.SuspendLayout();
            panel21.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvScreenType).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(btnShowScreenType);
            panel1.Controls.Add(btnUpdateScreenType);
            panel1.Controls.Add(btnDeleteScreenType);
            panel1.Controls.Add(btnInsertScreenType);
            panel1.Dock = DockStyle.Top;
            panel1.ImeMode = ImeMode.Disable;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1539, 271);
            panel1.TabIndex = 2;
            // 
            // btnShowScreenType
            // 
            btnShowScreenType.Location = new Point(377, 191);
            btnShowScreenType.Margin = new Padding(4, 5, 4, 5);
            btnShowScreenType.Name = "btnShowScreenType";
            btnShowScreenType.Size = new Size(100, 71);
            btnShowScreenType.TabIndex = 7;
            btnShowScreenType.Text = "Xem";
            btnShowScreenType.UseVisualStyleBackColor = true;
            // 
            // btnUpdateScreenType
            // 
            btnUpdateScreenType.Location = new Point(256, 190);
            btnUpdateScreenType.Margin = new Padding(4, 5, 4, 5);
            btnUpdateScreenType.Name = "btnUpdateScreenType";
            btnUpdateScreenType.Size = new Size(100, 71);
            btnUpdateScreenType.TabIndex = 6;
            btnUpdateScreenType.Text = "Sửa";
            btnUpdateScreenType.UseVisualStyleBackColor = true;
            btnUpdateScreenType.Click += btnUpdateScreenType_Click;
            // 
            // btnDeleteScreenType
            // 
            btnDeleteScreenType.Location = new Point(138, 190);
            btnDeleteScreenType.Margin = new Padding(4, 5, 4, 5);
            btnDeleteScreenType.Name = "btnDeleteScreenType";
            btnDeleteScreenType.Size = new Size(100, 71);
            btnDeleteScreenType.TabIndex = 5;
            btnDeleteScreenType.Text = "Xóa";
            btnDeleteScreenType.UseVisualStyleBackColor = true;
            btnDeleteScreenType.Click += btnDeleteScreenType_Click;
            // 
            // btnInsertScreenType
            // 
            btnInsertScreenType.Location = new Point(0, 190);
            btnInsertScreenType.Margin = new Padding(4, 5, 4, 5);
            btnInsertScreenType.Name = "btnInsertScreenType";
            btnInsertScreenType.Size = new Size(100, 71);
            btnInsertScreenType.TabIndex = 4;
            btnInsertScreenType.Text = "Thêm";
            btnInsertScreenType.UseVisualStyleBackColor = true;
            btnInsertScreenType.Click += btnInsertScreenType_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 271);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1539, 423);
            panel2.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel20);
            panel4.Controls.Add(panel21);
            panel4.Dock = DockStyle.Fill;
            panel4.ImeMode = ImeMode.Disable;
            panel4.Location = new Point(779, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(760, 423);
            panel4.TabIndex = 1;
            // 
            // panel20
            // 
            panel20.Controls.Add(txtScreenTypeName);
            panel20.Controls.Add(lblScreenTypeName);
            panel20.Location = new Point(44, 104);
            panel20.Margin = new Padding(4, 5, 4, 5);
            panel20.Name = "panel20";
            panel20.Size = new Size(391, 68);
            panel20.TabIndex = 4;
            // 
            // txtScreenTypeName
            // 
            txtScreenTypeName.Location = new Point(180, 14);
            txtScreenTypeName.Margin = new Padding(4, 5, 4, 5);
            txtScreenTypeName.Name = "txtScreenTypeName";
            txtScreenTypeName.Size = new Size(192, 27);
            txtScreenTypeName.TabIndex = 1;
            // 
            // lblScreenTypeName
            // 
            lblScreenTypeName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblScreenTypeName.Location = new Point(4, 14);
            lblScreenTypeName.Margin = new Padding(4, 0, 4, 0);
            lblScreenTypeName.Name = "lblScreenTypeName";
            lblScreenTypeName.Size = new Size(147, 24);
            lblScreenTypeName.TabIndex = 0;
            lblScreenTypeName.Text = "Tên màn hình:";
            // 
            // panel21
            // 
            panel21.Controls.Add(txtScreenTypeID);
            panel21.Controls.Add(lblScreenTypeID);
            panel21.Location = new Point(44, 28);
            panel21.Margin = new Padding(4, 5, 4, 5);
            panel21.Name = "panel21";
            panel21.Size = new Size(391, 68);
            panel21.TabIndex = 3;
            // 
            // txtScreenTypeID
            // 
            txtScreenTypeID.Location = new Point(180, 11);
            txtScreenTypeID.Margin = new Padding(4, 5, 4, 5);
            txtScreenTypeID.Name = "txtScreenTypeID";
            txtScreenTypeID.Size = new Size(192, 27);
            txtScreenTypeID.TabIndex = 1;
            // 
            // lblScreenTypeID
            // 
            lblScreenTypeID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblScreenTypeID.Location = new Point(4, 14);
            lblScreenTypeID.Margin = new Padding(4, 0, 4, 0);
            lblScreenTypeID.Name = "lblScreenTypeID";
            lblScreenTypeID.Size = new Size(178, 24);
            lblScreenTypeID.TabIndex = 0;
            lblScreenTypeID.Text = "Mã màn hình:";
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgvScreenType);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(779, 423);
            panel3.TabIndex = 0;
            // 
            // dtgvScreenType
            // 
            dtgvScreenType.AllowUserToAddRows = false;
            dtgvScreenType.AllowUserToDeleteRows = false;
            dtgvScreenType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvScreenType.BorderStyle = BorderStyle.None;
            dtgvScreenType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvScreenType.Dock = DockStyle.Fill;
            dtgvScreenType.ImeMode = ImeMode.Disable;
            dtgvScreenType.Location = new Point(0, 0);
            dtgvScreenType.Margin = new Padding(4, 5, 4, 5);
            dtgvScreenType.Name = "dtgvScreenType";
            dtgvScreenType.ReadOnly = true;
            dtgvScreenType.RowHeadersWidth = 51;
            dtgvScreenType.Size = new Size(779, 423);
            dtgvScreenType.TabIndex = 1;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(506, 190);
            btnExport.Margin = new Padding(4, 5, 4, 5);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(100, 71);
            btnExport.TabIndex = 8;
            btnExport.Text = "Xuất File";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // KieuManHinhUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "KieuManHinhUC";
            Size = new Size(1539, 694);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvScreenType).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowScreenType;
        private System.Windows.Forms.Button btnUpdateScreenType;
        private System.Windows.Forms.Button btnDeleteScreenType;
        private System.Windows.Forms.Button btnInsertScreenType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvScreenType;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TextBox txtScreenTypeName;
        private System.Windows.Forms.Label lblScreenTypeName;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.TextBox txtScreenTypeID;
        private System.Windows.Forms.Label lblScreenTypeID;
        private Button btnExport;
    }
}