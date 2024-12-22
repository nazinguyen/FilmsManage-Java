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
            // lwShow
            // 
            lwShow.FullRowSelect = true;
            lwShow.Location = new Point(2, 593);
            lwShow.Margin = new Padding(2, 2, 2, 2);
            lwShow.Name = "lwShow";
            lwShow.Size = new Size(1290, 213);
            lwShow.TabIndex = 106;
            lwShow.UseCompatibleStateImageBehavior = false;
            lwShow.MouseClick += lwShow_MouseClick;
            // 
            // lblMovieID
            // 
            lblMovieID.AutoSize = true;
            lblMovieID.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieID.Location = new Point(72, 194);
            lblMovieID.Name = "lblMovieID";
            lblMovieID.Size = new Size(113, 26);
            lblMovieID.TabIndex = 146;
            lblMovieID.Text = "Mã phim:";
            // 
            // ccbDangPhim
            // 
            ccbDangPhim.FormattingEnabled = true;
            ccbDangPhim.Location = new Point(665, 507);
            ccbDangPhim.Margin = new Padding(2, 2, 2, 2);
            ccbDangPhim.Name = "ccbDangPhim";
            ccbDangPhim.Size = new Size(204, 28);
            ccbDangPhim.TabIndex = 163;
            // 
            // lblMovieName
            // 
            lblMovieName.AutoSize = true;
            lblMovieName.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieName.Location = new Point(72, 242);
            lblMovieName.Name = "lblMovieName";
            lblMovieName.Size = new Size(117, 26);
            lblMovieName.TabIndex = 139;
            lblMovieName.Text = "Tên phim:";
            // 
            // txtMovieName
            // 
            txtMovieName.Location = new Point(208, 244);
            txtMovieName.Margin = new Padding(3, 2, 3, 2);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.Size = new Size(204, 27);
            txtMovieName.TabIndex = 153;
            // 
            // lblMovieDesc
            // 
            lblMovieDesc.AutoSize = true;
            lblMovieDesc.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieDesc.Location = new Point(72, 286);
            lblMovieDesc.Name = "lblMovieDesc";
            lblMovieDesc.Size = new Size(81, 26);
            lblMovieDesc.TabIndex = 140;
            lblMovieDesc.Text = "Mô tả:";
            // 
            // lblMovieProductor
            // 
            lblMovieProductor.AutoSize = true;
            lblMovieProductor.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieProductor.Location = new Point(528, 413);
            lblMovieProductor.Name = "lblMovieProductor";
            lblMovieProductor.Size = new Size(95, 26);
            lblMovieProductor.TabIndex = 141;
            lblMovieProductor.Text = "Độ tuổi:";
            // 
            // lblMovieDirector
            // 
            lblMovieDirector.AutoSize = true;
            lblMovieDirector.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieDirector.Location = new Point(528, 461);
            lblMovieDirector.Name = "lblMovieDirector";
            lblMovieDirector.Size = new Size(111, 26);
            lblMovieDirector.TabIndex = 142;
            lblMovieDirector.Text = "Đạo diễn:";
            // 
            // lblMovieGenre
            // 
            lblMovieGenre.AutoSize = true;
            lblMovieGenre.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieGenre.Location = new Point(44, 374);
            lblMovieGenre.Name = "lblMovieGenre";
            lblMovieGenre.Size = new Size(103, 26);
            lblMovieGenre.TabIndex = 143;
            lblMovieGenre.Text = "Thể loại:";
            // 
            // lblMovieYear
            // 
            lblMovieYear.AutoSize = true;
            lblMovieYear.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieYear.Location = new Point(528, 508);
            lblMovieYear.Name = "lblMovieYear";
            lblMovieYear.Size = new Size(124, 26);
            lblMovieYear.TabIndex = 144;
            lblMovieYear.Text = "Dạng phim";
            // 
            // txtMovieDesc
            // 
            txtMovieDesc.Location = new Point(208, 286);
            txtMovieDesc.Margin = new Padding(3, 2, 3, 2);
            txtMovieDesc.Multiline = true;
            txtMovieDesc.Name = "txtMovieDesc";
            txtMovieDesc.Size = new Size(204, 26);
            txtMovieDesc.TabIndex = 149;
            // 
            // lblMovieLength
            // 
            lblMovieLength.AutoSize = true;
            lblMovieLength.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieLength.Location = new Point(529, 277);
            lblMovieLength.Name = "lblMovieLength";
            lblMovieLength.Size = new Size(109, 23);
            lblMovieLength.TabIndex = 138;
            lblMovieLength.Text = "Thời lượng:";
            // 
            // lblMovieStartDate
            // 
            lblMovieStartDate.AutoSize = true;
            lblMovieStartDate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieStartDate.Location = new Point(529, 322);
            lblMovieStartDate.Name = "lblMovieStartDate";
            lblMovieStartDate.Size = new Size(94, 23);
            lblMovieStartDate.TabIndex = 145;
            lblMovieStartDate.Text = "Ngày KC:";
            // 
            // lblMovieEndDate
            // 
            lblMovieEndDate.AutoSize = true;
            lblMovieEndDate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieEndDate.Location = new Point(529, 366);
            lblMovieEndDate.Name = "lblMovieEndDate";
            lblMovieEndDate.Size = new Size(92, 23);
            lblMovieEndDate.TabIndex = 147;
            lblMovieEndDate.Text = "Ngày KT:";
            // 
            // txtMovieLength
            // 
            txtMovieLength.Location = new Point(665, 279);
            txtMovieLength.Margin = new Padding(3, 2, 3, 2);
            txtMovieLength.Name = "txtMovieLength";
            txtMovieLength.Size = new Size(204, 27);
            txtMovieLength.TabIndex = 150;
            // 
            // txtDoTuoi
            // 
            txtDoTuoi.Location = new Point(664, 419);
            txtDoTuoi.Margin = new Padding(3, 2, 3, 2);
            txtDoTuoi.Name = "txtDoTuoi";
            txtDoTuoi.Size = new Size(204, 27);
            txtDoTuoi.TabIndex = 151;
            // 
            // txtMovieDirector
            // 
            txtMovieDirector.Location = new Point(664, 466);
            txtMovieDirector.Margin = new Padding(3, 2, 3, 2);
            txtMovieDirector.Name = "txtMovieDirector";
            txtMovieDirector.Size = new Size(204, 27);
            txtMovieDirector.TabIndex = 152;
            // 
            // dtmMovieStart
            // 
            dtmMovieStart.Format = DateTimePickerFormat.Short;
            dtmMovieStart.Location = new Point(665, 322);
            dtmMovieStart.Margin = new Padding(3, 2, 3, 2);
            dtmMovieStart.Name = "dtmMovieStart";
            dtmMovieStart.Size = new Size(204, 27);
            dtmMovieStart.TabIndex = 154;
            // 
            // dtmMovieEnd
            // 
            dtmMovieEnd.Format = DateTimePickerFormat.Short;
            dtmMovieEnd.Location = new Point(665, 366);
            dtmMovieEnd.Margin = new Padding(3, 2, 3, 2);
            dtmMovieEnd.Name = "dtmMovieEnd";
            dtmMovieEnd.Size = new Size(204, 27);
            dtmMovieEnd.TabIndex = 155;
            // 
            // picFilm
            // 
            picFilm.BorderStyle = BorderStyle.FixedSingle;
            picFilm.Location = new Point(971, 197);
            picFilm.Margin = new Padding(3, 2, 3, 2);
            picFilm.Name = "picFilm";
            picFilm.Size = new Size(189, 240);
            picFilm.SizeMode = PictureBoxSizeMode.StretchImage;
            picFilm.TabIndex = 156;
            picFilm.TabStop = false;
            // 
            // txtMovieID
            // 
            txtMovieID.Location = new Point(208, 200);
            txtMovieID.Margin = new Padding(3, 2, 3, 2);
            txtMovieID.Name = "txtMovieID";
            txtMovieID.Size = new Size(204, 27);
            txtMovieID.TabIndex = 148;
            // 
            // pnlLoaiPhim
            // 
            pnlLoaiPhim.AutoScroll = true;
            pnlLoaiPhim.Location = new Point(147, 377);
            pnlLoaiPhim.Margin = new Padding(2, 2, 2, 2);
            pnlLoaiPhim.Name = "pnlLoaiPhim";
            pnlLoaiPhim.Size = new Size(281, 157);
            pnlLoaiPhim.TabIndex = 158;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(529, 197);
            label1.Name = "label1";
            label1.Size = new Size(93, 26);
            label1.TabIndex = 159;
            label1.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(665, 199);
            txtGhiChu.Margin = new Padding(3, 2, 3, 2);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(204, 26);
            txtGhiChu.TabIndex = 160;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(529, 237);
            label2.Name = "label2";
            label2.Size = new Size(105, 26);
            label2.TabIndex = 161;
            label2.Text = "Nội dung";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(665, 239);
            txtNoiDung.Margin = new Padding(3, 2, 3, 2);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(204, 26);
            txtNoiDung.TabIndex = 162;
            // 
            // PhimUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "PhimUC";
            Size = new Size(1294, 986);
            Load += PhimUC_Load;
            ((System.ComponentModel.ISupportInitialize)picFilm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddMovie;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdateMovie;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDeleteMovie;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExport;
    }
}
