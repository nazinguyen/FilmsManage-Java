namespace FilmsManage.GUI.UserControls.Data
{
    partial class FoodUC
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
            ptbFood = new PictureBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtSearch = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnThayDoi = new Button();
            label4 = new Label();
            cbbDanhMuc = new ComboBox();
            txtGia = new TextBox();
            label3 = new Label();
            rtxtMota = new RichTextBox();
            label2 = new Label();
            txtTen = new TextBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)ptbFood).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ptbFood
            // 
            ptbFood.BorderStyle = BorderStyle.Fixed3D;
            ptbFood.Location = new Point(130, 3);
            ptbFood.Name = "ptbFood";
            ptbFood.Size = new Size(194, 223);
            ptbFood.SizeMode = PictureBoxSizeMode.Zoom;
            ptbFood.TabIndex = 1;
            ptbFood.TabStop = false;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(8, 661);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(131, 48);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            btnThem.Paint += btnThem_Paint;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(155, 661);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(131, 48);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            btnSua.Paint += btnSua_Paint;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(301, 661);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(131, 48);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            btnXoa.Paint += btnXoa_Paint;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(27, 208);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm";
            txtSearch.Size = new Size(575, 31);
            txtSearch.TabIndex = 5;
            txtSearch.Paint += txtSearch_Paint;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            flowLayoutPanel1.Location = new Point(27, 263);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1038, 812);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThayDoi);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cbbDanhMuc);
            panel1.Controls.Add(txtGia);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(rtxtMota);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTen);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(ptbFood);
            panel1.Location = new Point(1089, 263);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 812);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // btnThayDoi
            // 
            btnThayDoi.Location = new Point(130, 232);
            btnThayDoi.Name = "btnThayDoi";
            btnThayDoi.Size = new Size(194, 48);
            btnThayDoi.TabIndex = 14;
            btnThayDoi.Text = "Đổi ảnh";
            btnThayDoi.UseVisualStyleBackColor = true;
            btnThayDoi.Click += btnThayDoi_Click;
            btnThayDoi.Paint += btnThayDoi_Paint;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 576);
            label4.Name = "label4";
            label4.Size = new Size(118, 31);
            label4.TabIndex = 13;
            label4.Text = "Danh mục";
            // 
            // cbbDanhMuc
            // 
            cbbDanhMuc.FormattingEnabled = true;
            cbbDanhMuc.Location = new Point(181, 577);
            cbbDanhMuc.Name = "cbbDanhMuc";
            cbbDanhMuc.Size = new Size(230, 33);
            cbbDanhMuc.TabIndex = 12;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(181, 520);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(230, 31);
            txtGia.TabIndex = 11;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 519);
            label3.Name = "label3";
            label3.Size = new Size(103, 31);
            label3.TabIndex = 10;
            label3.Text = "Giá";
            // 
            // rtxtMota
            // 
            rtxtMota.Location = new Point(181, 383);
            rtxtMota.Name = "rtxtMota";
            rtxtMota.Size = new Size(230, 113);
            rtxtMota.TabIndex = 9;
            rtxtMota.Text = "";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 383);
            label2.Name = "label2";
            label2.Size = new Size(103, 31);
            label2.TabIndex = 7;
            label2.Text = "Mô tả";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(181, 323);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(230, 31);
            txtTen.TabIndex = 6;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 322);
            label1.Name = "label1";
            label1.Size = new Size(103, 31);
            label1.TabIndex = 5;
            label1.Text = "Tên";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FoodUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtSearch);
            Name = "FoodUC";
            Size = new Size(1617, 1153);
            ((System.ComponentModel.ISupportInitialize)ptbFood).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox ptbFood;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtSearch;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private TextBox txtGia;
        private Label label3;
        private RichTextBox rtxtMota;
        private Label label2;
        private TextBox txtTen;
        private Label label1;
        private Label label4;
        private ComboBox cbbDanhMuc;
        private Button btnThayDoi;
        private OpenFileDialog openFileDialog1;
    }
}
