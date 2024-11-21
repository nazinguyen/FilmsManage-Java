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
            panel47 = new Panel();
            btnUpLoadPictureFilm = new Button();
            picFilm = new PictureBox();
            clbMovieGenre = new CheckedListBox();
            dtmMovieEnd = new DateTimePicker();
            dtmMovieStart = new DateTimePicker();
            txtMovieYear = new TextBox();
            txtMovieDirector = new TextBox();
            txtMovieProductor = new TextBox();
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
            btnShowMovie = new Button();
            btnUpdateMovie = new Button();
            btnDeleteMovie = new Button();
            btnAddMovie = new Button();
            panel1 = new Panel();
            dtgvMovie = new DataGridView();
            panel47.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFilm).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvMovie).BeginInit();
            SuspendLayout();
            // 
            // panel47
            // 
            panel47.Controls.Add(btnUpLoadPictureFilm);
            panel47.Controls.Add(picFilm);
            panel47.Controls.Add(clbMovieGenre);
            panel47.Controls.Add(dtmMovieEnd);
            panel47.Controls.Add(dtmMovieStart);
            panel47.Controls.Add(txtMovieYear);
            panel47.Controls.Add(txtMovieDirector);
            panel47.Controls.Add(txtMovieProductor);
            panel47.Controls.Add(txtMovieLength);
            panel47.Controls.Add(lblMovieEndDate);
            panel47.Controls.Add(lblMovieStartDate);
            panel47.Controls.Add(lblMovieLength);
            panel47.Controls.Add(txtMovieDesc);
            panel47.Controls.Add(lblMovieYear);
            panel47.Controls.Add(lblMovieGenre);
            panel47.Controls.Add(lblMovieDirector);
            panel47.Controls.Add(lblMovieProductor);
            panel47.Controls.Add(lblMovieDesc);
            panel47.Controls.Add(txtMovieName);
            panel47.Controls.Add(lblMovieName);
            panel47.Controls.Add(txtMovieID);
            panel47.Controls.Add(lblMovieID);
            panel47.Controls.Add(btnShowMovie);
            panel47.Controls.Add(btnUpdateMovie);
            panel47.Controls.Add(btnDeleteMovie);
            panel47.Controls.Add(btnAddMovie);
            panel47.Dock = DockStyle.Top;
            panel47.Location = new Point(0, 0);
            panel47.Margin = new Padding(5, 6, 5, 6);
            panel47.Name = "panel47";
            panel47.Size = new Size(1935, 709);
            panel47.TabIndex = 10;
            // 
            // btnUpLoadPictureFilm
            // 
            btnUpLoadPictureFilm.Location = new Point(1356, 514);
            btnUpLoadPictureFilm.Margin = new Padding(4, 3, 4, 3);
            btnUpLoadPictureFilm.Name = "btnUpLoadPictureFilm";
            btnUpLoadPictureFilm.Size = new Size(159, 64);
            btnUpLoadPictureFilm.TabIndex = 78;
            btnUpLoadPictureFilm.Text = "Chọn hình ảnh";
            btnUpLoadPictureFilm.UseVisualStyleBackColor = true;
            // 
            // picFilm
            // 
            picFilm.BorderStyle = BorderStyle.FixedSingle;
            picFilm.Location = new Point(1320, 156);
            picFilm.Margin = new Padding(4, 3, 4, 3);
            picFilm.Name = "picFilm";
            picFilm.Size = new Size(232, 338);
            picFilm.SizeMode = PictureBoxSizeMode.StretchImage;
            picFilm.TabIndex = 77;
            picFilm.TabStop = false;
            // 
            // clbMovieGenre
            // 
            clbMovieGenre.CheckOnClick = true;
            clbMovieGenre.FormattingEnabled = true;
            clbMovieGenre.Location = new Point(160, 389);
            clbMovieGenre.Margin = new Padding(4, 3, 4, 3);
            clbMovieGenre.MultiColumn = true;
            clbMovieGenre.Name = "clbMovieGenre";
            clbMovieGenre.Size = new Size(415, 144);
            clbMovieGenre.TabIndex = 76;
            // 
            // dtmMovieEnd
            // 
            dtmMovieEnd.Format = DateTimePickerFormat.Short;
            dtmMovieEnd.Location = new Point(942, 286);
            dtmMovieEnd.Margin = new Padding(4, 3, 4, 3);
            dtmMovieEnd.Name = "dtmMovieEnd";
            dtmMovieEnd.Size = new Size(250, 31);
            dtmMovieEnd.TabIndex = 75;
            // 
            // dtmMovieStart
            // 
            dtmMovieStart.Format = DateTimePickerFormat.Short;
            dtmMovieStart.Location = new Point(942, 231);
            dtmMovieStart.Margin = new Padding(4, 3, 4, 3);
            dtmMovieStart.Name = "dtmMovieStart";
            dtmMovieStart.Size = new Size(250, 31);
            dtmMovieStart.TabIndex = 74;
            // 
            // txtMovieYear
            // 
            txtMovieYear.Location = new Point(941, 467);
            txtMovieYear.Margin = new Padding(4, 3, 4, 3);
            txtMovieYear.Name = "txtMovieYear";
            txtMovieYear.Size = new Size(250, 31);
            txtMovieYear.TabIndex = 72;
            // 
            // txtMovieDirector
            // 
            txtMovieDirector.Location = new Point(941, 412);
            txtMovieDirector.Margin = new Padding(4, 3, 4, 3);
            txtMovieDirector.Name = "txtMovieDirector";
            txtMovieDirector.Size = new Size(250, 31);
            txtMovieDirector.TabIndex = 71;
            // 
            // txtMovieProductor
            // 
            txtMovieProductor.Location = new Point(941, 353);
            txtMovieProductor.Margin = new Padding(4, 3, 4, 3);
            txtMovieProductor.Name = "txtMovieProductor";
            txtMovieProductor.Size = new Size(250, 31);
            txtMovieProductor.TabIndex = 70;
            // 
            // txtMovieLength
            // 
            txtMovieLength.Location = new Point(942, 178);
            txtMovieLength.Margin = new Padding(4, 3, 4, 3);
            txtMovieLength.Name = "txtMovieLength";
            txtMovieLength.Size = new Size(250, 31);
            txtMovieLength.TabIndex = 69;
            // 
            // lblMovieEndDate
            // 
            lblMovieEndDate.AutoSize = true;
            lblMovieEndDate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieEndDate.Location = new Point(772, 286);
            lblMovieEndDate.Margin = new Padding(4, 0, 4, 0);
            lblMovieEndDate.Name = "lblMovieEndDate";
            lblMovieEndDate.Size = new Size(111, 26);
            lblMovieEndDate.TabIndex = 66;
            lblMovieEndDate.Text = "Ngày KT:";
            // 
            // lblMovieStartDate
            // 
            lblMovieStartDate.AutoSize = true;
            lblMovieStartDate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieStartDate.Location = new Point(772, 231);
            lblMovieStartDate.Margin = new Padding(4, 0, 4, 0);
            lblMovieStartDate.Name = "lblMovieStartDate";
            lblMovieStartDate.Size = new Size(115, 26);
            lblMovieStartDate.TabIndex = 64;
            lblMovieStartDate.Text = "Ngày KC:";
            // 
            // lblMovieLength
            // 
            lblMovieLength.AutoSize = true;
            lblMovieLength.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieLength.Location = new Point(772, 175);
            lblMovieLength.Margin = new Padding(4, 0, 4, 0);
            lblMovieLength.Name = "lblMovieLength";
            lblMovieLength.Size = new Size(133, 26);
            lblMovieLength.TabIndex = 57;
            lblMovieLength.Text = "Thời lượng:";
            // 
            // txtMovieDesc
            // 
            txtMovieDesc.Location = new Point(325, 294);
            txtMovieDesc.Margin = new Padding(4, 3, 4, 3);
            txtMovieDesc.Multiline = true;
            txtMovieDesc.Name = "txtMovieDesc";
            txtMovieDesc.Size = new Size(250, 32);
            txtMovieDesc.TabIndex = 68;
            // 
            // lblMovieYear
            // 
            lblMovieYear.AutoSize = true;
            lblMovieYear.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieYear.Location = new Point(771, 464);
            lblMovieYear.Margin = new Padding(4, 0, 4, 0);
            lblMovieYear.Name = "lblMovieYear";
            lblMovieYear.Size = new Size(127, 32);
            lblMovieYear.TabIndex = 63;
            lblMovieYear.Text = "Năm SX:";
            // 
            // lblMovieGenre
            // 
            lblMovieGenre.AutoSize = true;
            lblMovieGenre.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieGenre.Location = new Point(155, 345);
            lblMovieGenre.Margin = new Padding(4, 0, 4, 0);
            lblMovieGenre.Name = "lblMovieGenre";
            lblMovieGenre.Size = new Size(122, 32);
            lblMovieGenre.TabIndex = 62;
            lblMovieGenre.Text = "Thể loại:";
            // 
            // lblMovieDirector
            // 
            lblMovieDirector.AutoSize = true;
            lblMovieDirector.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieDirector.Location = new Point(771, 405);
            lblMovieDirector.Margin = new Padding(4, 0, 4, 0);
            lblMovieDirector.Name = "lblMovieDirector";
            lblMovieDirector.Size = new Size(133, 32);
            lblMovieDirector.TabIndex = 61;
            lblMovieDirector.Text = "Đạo diễn:";
            // 
            // lblMovieProductor
            // 
            lblMovieProductor.AutoSize = true;
            lblMovieProductor.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieProductor.Location = new Point(771, 345);
            lblMovieProductor.Margin = new Padding(4, 0, 4, 0);
            lblMovieProductor.Name = "lblMovieProductor";
            lblMovieProductor.Size = new Size(131, 32);
            lblMovieProductor.TabIndex = 60;
            lblMovieProductor.Text = "Sản xuất:";
            // 
            // lblMovieDesc
            // 
            lblMovieDesc.AutoSize = true;
            lblMovieDesc.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieDesc.Location = new Point(155, 286);
            lblMovieDesc.Margin = new Padding(4, 0, 4, 0);
            lblMovieDesc.Name = "lblMovieDesc";
            lblMovieDesc.Size = new Size(97, 32);
            lblMovieDesc.TabIndex = 59;
            lblMovieDesc.Text = "Mô tả:";
            // 
            // txtMovieName
            // 
            txtMovieName.Location = new Point(325, 237);
            txtMovieName.Margin = new Padding(4, 3, 4, 3);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.Size = new Size(250, 31);
            txtMovieName.TabIndex = 73;
            // 
            // lblMovieName
            // 
            lblMovieName.AutoSize = true;
            lblMovieName.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieName.Location = new Point(155, 230);
            lblMovieName.Margin = new Padding(4, 0, 4, 0);
            lblMovieName.Name = "lblMovieName";
            lblMovieName.Size = new Size(142, 32);
            lblMovieName.TabIndex = 58;
            lblMovieName.Text = "Tên phim:";
            // 
            // txtMovieID
            // 
            txtMovieID.Location = new Point(325, 178);
            txtMovieID.Margin = new Padding(4, 3, 4, 3);
            txtMovieID.Name = "txtMovieID";
            txtMovieID.Size = new Size(250, 31);
            txtMovieID.TabIndex = 67;
            // 
            // lblMovieID
            // 
            lblMovieID.AutoSize = true;
            lblMovieID.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieID.Location = new Point(155, 170);
            lblMovieID.Margin = new Padding(4, 0, 4, 0);
            lblMovieID.Name = "lblMovieID";
            lblMovieID.Size = new Size(137, 32);
            lblMovieID.TabIndex = 65;
            lblMovieID.Text = "Mã phim:";
            // 
            // btnShowMovie
            // 
            btnShowMovie.Location = new Point(547, 590);
            btnShowMovie.Margin = new Padding(5, 6, 5, 6);
            btnShowMovie.Name = "btnShowMovie";
            btnShowMovie.Size = new Size(125, 89);
            btnShowMovie.TabIndex = 3;
            btnShowMovie.Text = "Xem";
            btnShowMovie.UseVisualStyleBackColor = true;
            // 
            // btnUpdateMovie
            // 
            btnUpdateMovie.Location = new Point(363, 590);
            btnUpdateMovie.Margin = new Padding(5, 6, 5, 6);
            btnUpdateMovie.Name = "btnUpdateMovie";
            btnUpdateMovie.Size = new Size(125, 89);
            btnUpdateMovie.TabIndex = 2;
            btnUpdateMovie.Text = "Sửa";
            btnUpdateMovie.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMovie
            // 
            btnDeleteMovie.Location = new Point(182, 590);
            btnDeleteMovie.Margin = new Padding(5, 6, 5, 6);
            btnDeleteMovie.Name = "btnDeleteMovie";
            btnDeleteMovie.Size = new Size(125, 89);
            btnDeleteMovie.TabIndex = 1;
            btnDeleteMovie.Text = "Xóa";
            btnDeleteMovie.UseVisualStyleBackColor = true;
            // 
            // btnAddMovie
            // 
            btnAddMovie.Location = new Point(19, 590);
            btnAddMovie.Margin = new Padding(5, 6, 5, 6);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(125, 89);
            btnAddMovie.TabIndex = 0;
            btnAddMovie.Text = "Thêm";
            btnAddMovie.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvMovie);
            panel1.Controls.Add(panel47);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1935, 997);
            panel1.TabIndex = 11;
            // 
            // dtgvMovie
            // 
            dtgvMovie.AllowUserToAddRows = false;
            dtgvMovie.AllowUserToDeleteRows = false;
            dtgvMovie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvMovie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvMovie.Dock = DockStyle.Fill;
            dtgvMovie.Location = new Point(0, 709);
            dtgvMovie.Margin = new Padding(5, 6, 5, 6);
            dtgvMovie.Name = "dtgvMovie";
            dtgvMovie.ReadOnly = true;
            dtgvMovie.RowHeadersWidth = 62;
            dtgvMovie.Size = new Size(1935, 288);
            dtgvMovie.TabIndex = 1;
            dtgvMovie.CellContentClick += dtgvMovie_CellContentClick;
            // 
            // PhimUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PhimUC";
            Size = new Size(1935, 997);
            panel47.ResumeLayout(false);
            panel47.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFilm).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvMovie).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel47;
        private System.Windows.Forms.Button btnShowMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvMovie;
        private Button btnUpLoadPictureFilm;
        private PictureBox picFilm;
        private CheckedListBox clbMovieGenre;
        private DateTimePicker dtmMovieEnd;
        private DateTimePicker dtmMovieStart;
        private TextBox txtMovieYear;
        private TextBox txtMovieDirector;
        private TextBox txtMovieProductor;
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
    }
}
