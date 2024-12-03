namespace FilmsManage.GUI.UserControls.Data
{
    partial class PhimUC
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
            btnUpdateMovie = new Button();
            btnDeleteMovie = new Button();
            btnAddMovie = new Button();
            lwShow = new ListView();
            lblMovieID = new Label();
            ccbDangPhim = new ComboBox();
            lblMovieName = new Label();
            txtMovieName = new TextBox();
            lblMovieDesc = new Label();
            lblMovieProductor = new Label();
            lblMovieDirector = new Label();
            lblMovieGenre = new Label();
            lblMovieYear = new Label();
            txtMovieDesc = new TextBox();
            lblMovieLength = new Label();
            lblMovieStartDate = new Label();
            lblMovieEndDate = new Label();
            txtMovieLength = new TextBox();
            txtDoTuoi = new TextBox();
            txtMovieDirector = new TextBox();
            dtmMovieStart = new DateTimePicker();
            dtmMovieEnd = new DateTimePicker();
            picFilm = new PictureBox();
            txtMovieID = new TextBox();
            pnlLoaiPhim = new Panel();
            label1 = new Label();
            txtGhiChu = new TextBox();
            label2 = new Label();
            txtNoiDung = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picFilm).BeginInit();
            SuspendLayout();
            // 
            // btnUpdateMovie
            // 
            btnUpdateMovie.Location = new Point(414, 686);
            btnUpdateMovie.Margin = new Padding(5, 6, 5, 6);
            btnUpdateMovie.Name = "btnUpdateMovie";
            btnUpdateMovie.Size = new Size(129, 51);
            btnUpdateMovie.TabIndex = 81;
            btnUpdateMovie.Text = "Sửa";
            btnUpdateMovie.UseVisualStyleBackColor = true;
            btnUpdateMovie.Click += btnUpdateMovie_Click;
            // 
            // btnDeleteMovie
            // 
            btnDeleteMovie.Location = new Point(237, 686);
            btnDeleteMovie.Margin = new Padding(5, 6, 5, 6);
            btnDeleteMovie.Name = "btnDeleteMovie";
            btnDeleteMovie.Size = new Size(129, 51);
            btnDeleteMovie.TabIndex = 80;
            btnDeleteMovie.Text = "Xóa";
            btnDeleteMovie.UseVisualStyleBackColor = true;
            btnDeleteMovie.Click += btnDeleteMovie_Click;
            // 
            // btnAddMovie
            // 
            btnAddMovie.Location = new Point(67, 686);
            btnAddMovie.Margin = new Padding(5, 6, 5, 6);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(129, 51);
            btnAddMovie.TabIndex = 79;
            btnAddMovie.Text = "Thêm";
            btnAddMovie.UseVisualStyleBackColor = true;
            btnAddMovie.Click += btnAddMovie_Click;
            // 
            // lwShow
            // 
            lwShow.FullRowSelect = true;
            lwShow.Location = new Point(3, 741);
            lwShow.Name = "lwShow";
            lwShow.Size = new Size(1612, 265);
            lwShow.TabIndex = 106;
            lwShow.UseCompatibleStateImageBehavior = false;
            lwShow.MouseClick += lwShow_MouseClick;
            // 
            // lblMovieID
            // 
            lblMovieID.AutoSize = true;
            lblMovieID.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieID.Location = new Point(90, 242);
            lblMovieID.Margin = new Padding(4, 0, 4, 0);
            lblMovieID.Name = "lblMovieID";
            lblMovieID.Size = new Size(137, 32);
            lblMovieID.TabIndex = 146;
            lblMovieID.Text = "Mã phim:";
            // 
            // ccbDangPhim
            // 
            ccbDangPhim.FormattingEnabled = true;
            ccbDangPhim.Location = new Point(831, 634);
            ccbDangPhim.Name = "ccbDangPhim";
            ccbDangPhim.Size = new Size(254, 33);
            ccbDangPhim.TabIndex = 163;
            // 
            // lblMovieName
            // 
            lblMovieName.AutoSize = true;
            lblMovieName.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieName.Location = new Point(90, 302);
            lblMovieName.Margin = new Padding(4, 0, 4, 0);
            lblMovieName.Name = "lblMovieName";
            lblMovieName.Size = new Size(142, 32);
            lblMovieName.TabIndex = 139;
            lblMovieName.Text = "Tên phim:";
            // 
            // txtMovieName
            // 
            txtMovieName.Location = new Point(260, 305);
            txtMovieName.Margin = new Padding(4, 3, 4, 3);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.Size = new Size(254, 31);
            txtMovieName.TabIndex = 153;
            // 
            // lblMovieDesc
            // 
            lblMovieDesc.AutoSize = true;
            lblMovieDesc.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieDesc.Location = new Point(90, 358);
            lblMovieDesc.Margin = new Padding(4, 0, 4, 0);
            lblMovieDesc.Name = "lblMovieDesc";
            lblMovieDesc.Size = new Size(97, 32);
            lblMovieDesc.TabIndex = 140;
            lblMovieDesc.Text = "Mô tả:";
            // 
            // lblMovieProductor
            // 
            lblMovieProductor.AutoSize = true;
            lblMovieProductor.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieProductor.Location = new Point(660, 516);
            lblMovieProductor.Margin = new Padding(4, 0, 4, 0);
            lblMovieProductor.Name = "lblMovieProductor";
            lblMovieProductor.Size = new Size(114, 32);
            lblMovieProductor.TabIndex = 141;
            lblMovieProductor.Text = "Độ tuổi:";
            // 
            // lblMovieDirector
            // 
            lblMovieDirector.AutoSize = true;
            lblMovieDirector.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieDirector.Location = new Point(660, 576);
            lblMovieDirector.Margin = new Padding(4, 0, 4, 0);
            lblMovieDirector.Name = "lblMovieDirector";
            lblMovieDirector.Size = new Size(133, 32);
            lblMovieDirector.TabIndex = 142;
            lblMovieDirector.Text = "Đạo diễn:";
            // 
            // lblMovieGenre
            // 
            lblMovieGenre.AutoSize = true;
            lblMovieGenre.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieGenre.Location = new Point(55, 468);
            lblMovieGenre.Margin = new Padding(4, 0, 4, 0);
            lblMovieGenre.Name = "lblMovieGenre";
            lblMovieGenre.Size = new Size(122, 32);
            lblMovieGenre.TabIndex = 143;
            lblMovieGenre.Text = "Thể loại:";
            // 
            // lblMovieYear
            // 
            lblMovieYear.AutoSize = true;
            lblMovieYear.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieYear.Location = new Point(660, 635);
            lblMovieYear.Margin = new Padding(4, 0, 4, 0);
            lblMovieYear.Name = "lblMovieYear";
            lblMovieYear.Size = new Size(151, 32);
            lblMovieYear.TabIndex = 144;
            lblMovieYear.Text = "Dạng phim";
            // 
            // txtMovieDesc
            // 
            txtMovieDesc.Location = new Point(260, 358);
            txtMovieDesc.Margin = new Padding(4, 3, 4, 3);
            txtMovieDesc.Multiline = true;
            txtMovieDesc.Name = "txtMovieDesc";
            txtMovieDesc.Size = new Size(254, 32);
            txtMovieDesc.TabIndex = 149;
            // 
            // lblMovieLength
            // 
            lblMovieLength.AutoSize = true;
            lblMovieLength.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieLength.Location = new Point(661, 346);
            lblMovieLength.Margin = new Padding(4, 0, 4, 0);
            lblMovieLength.Name = "lblMovieLength";
            lblMovieLength.Size = new Size(133, 26);
            lblMovieLength.TabIndex = 138;
            lblMovieLength.Text = "Thời lượng:";
            // 
            // lblMovieStartDate
            // 
            lblMovieStartDate.AutoSize = true;
            lblMovieStartDate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieStartDate.Location = new Point(661, 402);
            lblMovieStartDate.Margin = new Padding(4, 0, 4, 0);
            lblMovieStartDate.Name = "lblMovieStartDate";
            lblMovieStartDate.Size = new Size(115, 26);
            lblMovieStartDate.TabIndex = 145;
            lblMovieStartDate.Text = "Ngày KC:";
            // 
            // lblMovieEndDate
            // 
            lblMovieEndDate.AutoSize = true;
            lblMovieEndDate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieEndDate.Location = new Point(661, 457);
            lblMovieEndDate.Margin = new Padding(4, 0, 4, 0);
            lblMovieEndDate.Name = "lblMovieEndDate";
            lblMovieEndDate.Size = new Size(111, 26);
            lblMovieEndDate.TabIndex = 147;
            lblMovieEndDate.Text = "Ngày KT:";
            // 
            // txtMovieLength
            // 
            txtMovieLength.Location = new Point(831, 349);
            txtMovieLength.Margin = new Padding(4, 3, 4, 3);
            txtMovieLength.Name = "txtMovieLength";
            txtMovieLength.Size = new Size(254, 31);
            txtMovieLength.TabIndex = 150;
            // 
            // txtDoTuoi
            // 
            txtDoTuoi.Location = new Point(830, 524);
            txtDoTuoi.Margin = new Padding(4, 3, 4, 3);
            txtDoTuoi.Name = "txtDoTuoi";
            txtDoTuoi.Size = new Size(254, 31);
            txtDoTuoi.TabIndex = 151;
            // 
            // txtMovieDirector
            // 
            txtMovieDirector.Location = new Point(830, 583);
            txtMovieDirector.Margin = new Padding(4, 3, 4, 3);
            txtMovieDirector.Name = "txtMovieDirector";
            txtMovieDirector.Size = new Size(254, 31);
            txtMovieDirector.TabIndex = 152;
            // 
            // dtmMovieStart
            // 
            dtmMovieStart.Format = DateTimePickerFormat.Short;
            dtmMovieStart.Location = new Point(831, 402);
            dtmMovieStart.Margin = new Padding(4, 3, 4, 3);
            dtmMovieStart.Name = "dtmMovieStart";
            dtmMovieStart.Size = new Size(254, 31);
            dtmMovieStart.TabIndex = 154;
            // 
            // dtmMovieEnd
            // 
            dtmMovieEnd.Format = DateTimePickerFormat.Short;
            dtmMovieEnd.Location = new Point(831, 457);
            dtmMovieEnd.Margin = new Padding(4, 3, 4, 3);
            dtmMovieEnd.Name = "dtmMovieEnd";
            dtmMovieEnd.Size = new Size(254, 31);
            dtmMovieEnd.TabIndex = 155;
            // 
            // picFilm
            // 
            picFilm.BorderStyle = BorderStyle.FixedSingle;
            picFilm.Location = new Point(1214, 246);
            picFilm.Margin = new Padding(4, 3, 4, 3);
            picFilm.Name = "picFilm";
            picFilm.Size = new Size(236, 300);
            picFilm.SizeMode = PictureBoxSizeMode.StretchImage;
            picFilm.TabIndex = 156;
            picFilm.TabStop = false;
            // 
            // txtMovieID
            // 
            txtMovieID.Location = new Point(260, 250);
            txtMovieID.Margin = new Padding(4, 3, 4, 3);
            txtMovieID.Name = "txtMovieID";
            txtMovieID.Size = new Size(254, 31);
            txtMovieID.TabIndex = 148;
            // 
            // pnlLoaiPhim
            // 
            pnlLoaiPhim.AutoScroll = true;
            pnlLoaiPhim.Location = new Point(184, 471);
            pnlLoaiPhim.Name = "pnlLoaiPhim";
            pnlLoaiPhim.Size = new Size(351, 196);
            pnlLoaiPhim.TabIndex = 158;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(661, 246);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 159;
            label1.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(831, 249);
            txtGhiChu.Margin = new Padding(4, 3, 4, 3);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(254, 32);
            txtGhiChu.TabIndex = 160;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(661, 296);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 32);
            label2.TabIndex = 161;
            label2.Text = "Nội dung";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(831, 299);
            txtNoiDung.Margin = new Padding(4, 3, 4, 3);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(254, 32);
            txtNoiDung.TabIndex = 162;
            // 
            // PhimUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            Controls.Add(ccbDangPhim);
            Controls.Add(txtNoiDung);
            Controls.Add(label2);
            Controls.Add(txtGhiChu);
            Controls.Add(label1);
            Controls.Add(pnlLoaiPhim);
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
            Controls.Add(lwShow);
            Controls.Add(btnUpdateMovie);
            Controls.Add(btnDeleteMovie);
            Controls.Add(btnAddMovie);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PhimUC";
            Size = new Size(1618, 1232);
            Load += PhimUC_Load;
            ((System.ComponentModel.ISupportInitialize)picFilm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnUpdateMovie;
        private Button btnDeleteMovie;
        private Button btnAddMovie;
        private ListView lwShow;
        private Label lblMovieID;
        private ComboBox ccbDangPhim;
        private Label lblMovieName;
        private TextBox txtMovieName;
        private Label lblMovieDesc;
        private Label lblMovieProductor;
        private Label lblMovieDirector;
        private Label lblMovieGenre;
        private Label lblMovieYear;
        private TextBox txtMovieDesc;
        private Label lblMovieLength;
        private Label lblMovieStartDate;
        private Label lblMovieEndDate;
        private TextBox txtMovieLength;
        private TextBox txtDoTuoi;
        private TextBox txtMovieDirector;
        private DateTimePicker dtmMovieStart;
        private DateTimePicker dtmMovieEnd;
        private PictureBox picFilm;
        private TextBox txtMovieID;
        private Panel pnlLoaiPhim;
        private Label label1;
        private TextBox txtGhiChu;
        private Label label2;
        private TextBox txtNoiDung;
    }
}
