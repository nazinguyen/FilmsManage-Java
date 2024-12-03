namespace FilmsManage.GUI.UserControls.Data.ChucNang_Phim
{
    partial class Them_Sua
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
            pnlLoaiPhim = new Panel();
            btnUpLoadPictureFilm = new Button();
            picFilm = new PictureBox();
            dtmMovieEnd = new DateTimePicker();
            dtmMovieStart = new DateTimePicker();
            txtMovieDirector = new TextBox();
            txtDoTuoi = new TextBox();
            txtMovieLength = new TextBox();
            lblMovieEndDate = new Label();
            lblMovieStartDate = new Label();
            lblMovieLength = new Label();
            txtMovieDesc = new TextBox();
            lblMovieYear = new Label();
            lblMovieGenre = new Label();
            lblMovieDirector = new Label();
            lblMovieProductor = new Label();
            lblMovieDesc = new Label();
            txtMovieName = new TextBox();
            lblMovieName = new Label();
            txtMovieID = new TextBox();
            lblMovieID = new Label();
            btnHuy = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            txtGhiChu = new TextBox();
            label2 = new Label();
            txtNoiDung = new TextBox();
            ccbDangPhim = new ComboBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)picFilm).BeginInit();
            SuspendLayout();
            // 
            // pnlLoaiPhim
            // 
            pnlLoaiPhim.AutoScroll = true;
            pnlLoaiPhim.Location = new Point(167, 426);
            pnlLoaiPhim.Margin = new Padding(2);
            pnlLoaiPhim.Name = "pnlLoaiPhim";
            pnlLoaiPhim.Size = new Size(281, 157);
            pnlLoaiPhim.TabIndex = 129;
            // 
            // btnUpLoadPictureFilm
            // 
            btnUpLoadPictureFilm.Location = new Point(1019, 458);
            btnUpLoadPictureFilm.Margin = new Padding(3, 2, 3, 2);
            btnUpLoadPictureFilm.Name = "btnUpLoadPictureFilm";
            btnUpLoadPictureFilm.Size = new Size(132, 28);
            btnUpLoadPictureFilm.TabIndex = 128;
            btnUpLoadPictureFilm.Text = "Chọn hình ảnh";
            btnUpLoadPictureFilm.UseVisualStyleBackColor = true;
            btnUpLoadPictureFilm.Click += btnUpLoadPictureFilm_Click;
            // 
            // picFilm
            // 
            picFilm.BorderStyle = BorderStyle.FixedSingle;
            picFilm.Location = new Point(993, 198);
            picFilm.Margin = new Padding(3, 2, 3, 2);
            picFilm.Name = "picFilm";
            picFilm.Size = new Size(189, 240);
            picFilm.SizeMode = PictureBoxSizeMode.StretchImage;
            picFilm.TabIndex = 127;
            picFilm.TabStop = false;
            // 
            // dtmMovieEnd
            // 
            dtmMovieEnd.Format = DateTimePickerFormat.Short;
            dtmMovieEnd.Location = new Point(703, 281);
            dtmMovieEnd.Margin = new Padding(3, 2, 3, 2);
            dtmMovieEnd.Name = "dtmMovieEnd";
            dtmMovieEnd.Size = new Size(204, 27);
            dtmMovieEnd.TabIndex = 126;
            // 
            // dtmMovieStart
            // 
            dtmMovieStart.Format = DateTimePickerFormat.Short;
            dtmMovieStart.Location = new Point(703, 237);
            dtmMovieStart.Margin = new Padding(3, 2, 3, 2);
            dtmMovieStart.Name = "dtmMovieStart";
            dtmMovieStart.Size = new Size(204, 27);
            dtmMovieStart.TabIndex = 125;
            // 
            // txtMovieDirector
            // 
            txtMovieDirector.Location = new Point(702, 382);
            txtMovieDirector.Margin = new Padding(3, 2, 3, 2);
            txtMovieDirector.Name = "txtMovieDirector";
            txtMovieDirector.Size = new Size(204, 27);
            txtMovieDirector.TabIndex = 122;
            // 
            // txtDoTuoi
            // 
            txtDoTuoi.Location = new Point(702, 334);
            txtDoTuoi.Margin = new Padding(3, 2, 3, 2);
            txtDoTuoi.Name = "txtDoTuoi";
            txtDoTuoi.Size = new Size(204, 27);
            txtDoTuoi.TabIndex = 121;
            // 
            // txtMovieLength
            // 
            txtMovieLength.Location = new Point(703, 194);
            txtMovieLength.Margin = new Padding(3, 2, 3, 2);
            txtMovieLength.Name = "txtMovieLength";
            txtMovieLength.Size = new Size(204, 27);
            txtMovieLength.TabIndex = 120;
            // 
            // lblMovieEndDate
            // 
            lblMovieEndDate.AutoSize = true;
            lblMovieEndDate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieEndDate.Location = new Point(567, 281);
            lblMovieEndDate.Name = "lblMovieEndDate";
            lblMovieEndDate.Size = new Size(92, 23);
            lblMovieEndDate.TabIndex = 117;
            lblMovieEndDate.Text = "Ngày KT:";
            // 
            // lblMovieStartDate
            // 
            lblMovieStartDate.AutoSize = true;
            lblMovieStartDate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieStartDate.Location = new Point(567, 237);
            lblMovieStartDate.Name = "lblMovieStartDate";
            lblMovieStartDate.Size = new Size(94, 23);
            lblMovieStartDate.TabIndex = 115;
            lblMovieStartDate.Text = "Ngày KC:";
            // 
            // lblMovieLength
            // 
            lblMovieLength.AutoSize = true;
            lblMovieLength.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieLength.Location = new Point(567, 192);
            lblMovieLength.Name = "lblMovieLength";
            lblMovieLength.Size = new Size(109, 23);
            lblMovieLength.TabIndex = 108;
            lblMovieLength.Text = "Thời lượng:";
            // 
            // txtMovieDesc
            // 
            txtMovieDesc.Location = new Point(210, 281);
            txtMovieDesc.Margin = new Padding(3, 2, 3, 2);
            txtMovieDesc.Multiline = true;
            txtMovieDesc.Name = "txtMovieDesc";
            txtMovieDesc.Size = new Size(204, 26);
            txtMovieDesc.TabIndex = 119;
            // 
            // lblMovieYear
            // 
            lblMovieYear.AutoSize = true;
            lblMovieYear.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieYear.Location = new Point(566, 423);
            lblMovieYear.Name = "lblMovieYear";
            lblMovieYear.Size = new Size(124, 26);
            lblMovieYear.TabIndex = 114;
            lblMovieYear.Text = "Dạng phim";
            // 
            // lblMovieGenre
            // 
            lblMovieGenre.AutoSize = true;
            lblMovieGenre.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieGenre.Location = new Point(64, 423);
            lblMovieGenre.Name = "lblMovieGenre";
            lblMovieGenre.Size = new Size(103, 26);
            lblMovieGenre.TabIndex = 113;
            lblMovieGenre.Text = "Thể loại:";
            // 
            // lblMovieDirector
            // 
            lblMovieDirector.AutoSize = true;
            lblMovieDirector.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieDirector.Location = new Point(566, 376);
            lblMovieDirector.Name = "lblMovieDirector";
            lblMovieDirector.Size = new Size(111, 26);
            lblMovieDirector.TabIndex = 112;
            lblMovieDirector.Text = "Đạo diễn:";
            // 
            // lblMovieProductor
            // 
            lblMovieProductor.AutoSize = true;
            lblMovieProductor.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieProductor.Location = new Point(566, 328);
            lblMovieProductor.Name = "lblMovieProductor";
            lblMovieProductor.Size = new Size(95, 26);
            lblMovieProductor.TabIndex = 111;
            lblMovieProductor.Text = "Độ tuổi:";
            // 
            // lblMovieDesc
            // 
            lblMovieDesc.AutoSize = true;
            lblMovieDesc.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieDesc.Location = new Point(74, 281);
            lblMovieDesc.Name = "lblMovieDesc";
            lblMovieDesc.Size = new Size(81, 26);
            lblMovieDesc.TabIndex = 110;
            lblMovieDesc.Text = "Mô tả:";
            // 
            // txtMovieName
            // 
            txtMovieName.Location = new Point(210, 238);
            txtMovieName.Margin = new Padding(3, 2, 3, 2);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.Size = new Size(204, 27);
            txtMovieName.TabIndex = 124;
            // 
            // lblMovieName
            // 
            lblMovieName.AutoSize = true;
            lblMovieName.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieName.Location = new Point(74, 236);
            lblMovieName.Name = "lblMovieName";
            lblMovieName.Size = new Size(117, 26);
            lblMovieName.TabIndex = 109;
            lblMovieName.Text = "Tên phim:";
            // 
            // txtMovieID
            // 
            txtMovieID.Location = new Point(210, 194);
            txtMovieID.Margin = new Padding(3, 2, 3, 2);
            txtMovieID.Name = "txtMovieID";
            txtMovieID.Size = new Size(204, 27);
            txtMovieID.TabIndex = 118;
            // 
            // lblMovieID
            // 
            lblMovieID.AutoSize = true;
            lblMovieID.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieID.Location = new Point(74, 188);
            lblMovieID.Name = "lblMovieID";
            lblMovieID.Size = new Size(113, 26);
            lblMovieID.TabIndex = 116;
            lblMovieID.Text = "Mã phim:";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(210, 624);
            btnHuy.Margin = new Padding(2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(302, 43);
            btnHuy.TabIndex = 130;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(590, 624);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(302, 43);
            btnSua.TabIndex = 131;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(590, 624);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(302, 43);
            btnThem.TabIndex = 132;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 326);
            label1.Name = "label1";
            label1.Size = new Size(93, 26);
            label1.TabIndex = 133;
            label1.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(210, 328);
            txtGhiChu.Margin = new Padding(3, 2, 3, 2);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(204, 26);
            txtGhiChu.TabIndex = 134;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 366);
            label2.Name = "label2";
            label2.Size = new Size(105, 26);
            label2.TabIndex = 135;
            label2.Text = "Nội dung";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(210, 368);
            txtNoiDung.Margin = new Padding(3, 2, 3, 2);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(204, 26);
            txtNoiDung.TabIndex = 136;
            // 
            // ccbDangPhim
            // 
            ccbDangPhim.FormattingEnabled = true;
            ccbDangPhim.Location = new Point(703, 422);
            ccbDangPhim.Margin = new Padding(2);
            ccbDangPhim.Name = "ccbDangPhim";
            ccbDangPhim.Size = new Size(204, 28);
            ccbDangPhim.TabIndex = 137;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(426, 624);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(302, 43);
            btnBack.TabIndex = 138;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Them_Sua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            Controls.Add(btnBack);
            Controls.Add(ccbDangPhim);
            Controls.Add(txtNoiDung);
            Controls.Add(label2);
            Controls.Add(txtGhiChu);
            Controls.Add(label1);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnHuy);
            Controls.Add(pnlLoaiPhim);
            Controls.Add(btnUpLoadPictureFilm);
            Controls.Add(picFilm);
            Controls.Add(dtmMovieEnd);
            Controls.Add(dtmMovieStart);
            Controls.Add(txtMovieDirector);
            Controls.Add(txtDoTuoi);
            Controls.Add(txtMovieLength);
            Controls.Add(lblMovieEndDate);
            Controls.Add(lblMovieStartDate);
            Controls.Add(lblMovieLength);
            Controls.Add(txtMovieDesc);
            Controls.Add(lblMovieYear);
            Controls.Add(lblMovieGenre);
            Controls.Add(lblMovieDirector);
            Controls.Add(lblMovieProductor);
            Controls.Add(lblMovieDesc);
            Controls.Add(txtMovieName);
            Controls.Add(lblMovieName);
            Controls.Add(txtMovieID);
            Controls.Add(lblMovieID);
            Margin = new Padding(2);
            Name = "Them_Sua";
            Size = new Size(1234, 710);
            ((System.ComponentModel.ISupportInitialize)picFilm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLoaiPhim;
        private Button btnUpLoadPictureFilm;
        private PictureBox picFilm;
        private DateTimePicker dtmMovieEnd;
        private DateTimePicker dtmMovieStart;
        private TextBox txtMovieDirector;
        private TextBox txtDoTuoi;
        private TextBox txtMovieLength;
        private Label lblMovieEndDate;
        private Label lblMovieStartDate;
        private Label lblMovieLength;
        private TextBox txtMovieDesc;
        private Label lblMovieYear;
        private Label lblMovieGenre;
        private Label lblMovieDirector;
        private Label lblMovieProductor;
        private Label lblMovieDesc;
        private TextBox txtMovieName;
        private Label lblMovieName;
        private TextBox txtMovieID;
        private Label lblMovieID;
        private Button btnHuy;
        private Button btnSua;
        private Button btnThem;
        private Label label1;
        private TextBox txtGhiChu;
        private Label label2;
        private TextBox txtNoiDung;
        private ComboBox ccbDangPhim;
        private Button btnBack;
    }
}
