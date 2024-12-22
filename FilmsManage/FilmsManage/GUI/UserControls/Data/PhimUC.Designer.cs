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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhimUC));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
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
            btnAddMovie = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnUpdateMovie = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnDeleteMovie = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnExport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)picFilm).BeginInit();
            SuspendLayout();
            // 
            // lwShow
            // 
            lwShow.FullRowSelect = true;
            lwShow.Location = new Point(2, 741);
            lwShow.Margin = new Padding(2);
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
            ccbDangPhim.Margin = new Padding(2);
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
            txtMovieName.Margin = new Padding(4, 2, 4, 2);
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
            txtMovieDesc.Margin = new Padding(4, 2, 4, 2);
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
            lblMovieEndDate.Location = new Point(661, 458);
            lblMovieEndDate.Margin = new Padding(4, 0, 4, 0);
            lblMovieEndDate.Name = "lblMovieEndDate";
            lblMovieEndDate.Size = new Size(111, 26);
            lblMovieEndDate.TabIndex = 147;
            lblMovieEndDate.Text = "Ngày KT:";
            // 
            // txtMovieLength
            // 
            txtMovieLength.Location = new Point(831, 349);
            txtMovieLength.Margin = new Padding(4, 2, 4, 2);
            txtMovieLength.Name = "txtMovieLength";
            txtMovieLength.Size = new Size(254, 31);
            txtMovieLength.TabIndex = 150;
            // 
            // txtDoTuoi
            // 
            txtDoTuoi.Location = new Point(830, 524);
            txtDoTuoi.Margin = new Padding(4, 2, 4, 2);
            txtDoTuoi.Name = "txtDoTuoi";
            txtDoTuoi.Size = new Size(254, 31);
            txtDoTuoi.TabIndex = 151;
            // 
            // txtMovieDirector
            // 
            txtMovieDirector.Location = new Point(830, 582);
            txtMovieDirector.Margin = new Padding(4, 2, 4, 2);
            txtMovieDirector.Name = "txtMovieDirector";
            txtMovieDirector.Size = new Size(254, 31);
            txtMovieDirector.TabIndex = 152;
            // 
            // dtmMovieStart
            // 
            dtmMovieStart.Format = DateTimePickerFormat.Short;
            dtmMovieStart.Location = new Point(831, 402);
            dtmMovieStart.Margin = new Padding(4, 2, 4, 2);
            dtmMovieStart.Name = "dtmMovieStart";
            dtmMovieStart.Size = new Size(254, 31);
            dtmMovieStart.TabIndex = 154;
            // 
            // dtmMovieEnd
            // 
            dtmMovieEnd.Format = DateTimePickerFormat.Short;
            dtmMovieEnd.Location = new Point(831, 458);
            dtmMovieEnd.Margin = new Padding(4, 2, 4, 2);
            dtmMovieEnd.Name = "dtmMovieEnd";
            dtmMovieEnd.Size = new Size(254, 31);
            dtmMovieEnd.TabIndex = 155;
            // 
            // picFilm
            // 
            picFilm.BorderStyle = BorderStyle.FixedSingle;
            picFilm.Location = new Point(1214, 246);
            picFilm.Margin = new Padding(4, 2, 4, 2);
            picFilm.Name = "picFilm";
            picFilm.Size = new Size(236, 300);
            picFilm.SizeMode = PictureBoxSizeMode.StretchImage;
            picFilm.TabIndex = 156;
            picFilm.TabStop = false;
            // 
            // txtMovieID
            // 
            txtMovieID.Location = new Point(260, 250);
            txtMovieID.Margin = new Padding(4, 2, 4, 2);
            txtMovieID.Name = "txtMovieID";
            txtMovieID.Size = new Size(254, 31);
            txtMovieID.TabIndex = 148;
            // 
            // pnlLoaiPhim
            // 
            pnlLoaiPhim.AutoScroll = true;
            pnlLoaiPhim.Location = new Point(184, 471);
            pnlLoaiPhim.Margin = new Padding(2);
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
            txtGhiChu.Margin = new Padding(4, 2, 4, 2);
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
            txtNoiDung.Margin = new Padding(4, 2, 4, 2);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(254, 32);
            txtNoiDung.TabIndex = 162;
            // 
            // btnAddMovie
            // 
            btnAddMovie.AllowAnimations = true;
            btnAddMovie.AllowMouseEffects = true;
            btnAddMovie.AllowToggling = false;
            btnAddMovie.AnimationSpeed = 200;
            btnAddMovie.AutoGenerateColors = false;
            btnAddMovie.AutoRoundBorders = false;
            btnAddMovie.AutoSizeLeftIcon = true;
            btnAddMovie.AutoSizeRightIcon = true;
            btnAddMovie.BackColor = Color.Transparent;
            btnAddMovie.BackColor1 = Color.FromArgb(51, 122, 183);
            btnAddMovie.BackgroundImage = (Image)resources.GetObject("btnAddMovie.BackgroundImage");
            btnAddMovie.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAddMovie.ButtonText = "Thêm";
            btnAddMovie.ButtonTextMarginLeft = 0;
            btnAddMovie.ColorContrastOnClick = 45;
            btnAddMovie.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btnAddMovie.CustomizableEdges = borderEdges1;
            btnAddMovie.DialogResult = DialogResult.None;
            btnAddMovie.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnAddMovie.DisabledFillColor = Color.Empty;
            btnAddMovie.DisabledForecolor = Color.Empty;
            btnAddMovie.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnAddMovie.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnAddMovie.ForeColor = Color.White;
            btnAddMovie.IconLeft = null;
            btnAddMovie.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnAddMovie.IconLeftCursor = Cursors.Default;
            btnAddMovie.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnAddMovie.IconMarginLeft = 11;
            btnAddMovie.IconPadding = 10;
            btnAddMovie.IconRight = null;
            btnAddMovie.IconRightAlign = ContentAlignment.MiddleRight;
            btnAddMovie.IconRightCursor = Cursors.Default;
            btnAddMovie.IconRightPadding = new Padding(3, 3, 7, 3);
            btnAddMovie.IconSize = 25;
            btnAddMovie.IdleBorderColor = Color.Empty;
            btnAddMovie.IdleBorderRadius = 0;
            btnAddMovie.IdleBorderThickness = 0;
            btnAddMovie.IdleFillColor = Color.Empty;
            btnAddMovie.IdleIconLeftImage = null;
            btnAddMovie.IdleIconRightImage = null;
            btnAddMovie.IndicateFocus = false;
            btnAddMovie.Location = new Point(184, 681);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnAddMovie.OnDisabledState.BorderRadius = 30;
            btnAddMovie.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAddMovie.OnDisabledState.BorderThickness = 2;
            btnAddMovie.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnAddMovie.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnAddMovie.OnDisabledState.IconLeftImage = null;
            btnAddMovie.OnDisabledState.IconRightImage = null;
            btnAddMovie.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnAddMovie.onHoverState.BorderRadius = 30;
            btnAddMovie.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAddMovie.onHoverState.BorderThickness = 2;
            btnAddMovie.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnAddMovie.onHoverState.ForeColor = Color.White;
            btnAddMovie.onHoverState.IconLeftImage = null;
            btnAddMovie.onHoverState.IconRightImage = null;
            btnAddMovie.OnIdleState.BorderColor = Color.FromArgb(30, 150, 255);
            btnAddMovie.OnIdleState.BorderRadius = 30;
            btnAddMovie.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAddMovie.OnIdleState.BorderThickness = 2;
            btnAddMovie.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnAddMovie.OnIdleState.ForeColor = Color.White;
            btnAddMovie.OnIdleState.IconLeftImage = null;
            btnAddMovie.OnIdleState.IconRightImage = null;
            btnAddMovie.OnPressedState.BorderColor = Color.FromArgb(30, 150, 255);
            btnAddMovie.OnPressedState.BorderRadius = 30;
            btnAddMovie.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAddMovie.OnPressedState.BorderThickness = 2;
            btnAddMovie.OnPressedState.FillColor = Color.Gold;
            btnAddMovie.OnPressedState.ForeColor = Color.White;
            btnAddMovie.OnPressedState.IconLeftImage = null;
            btnAddMovie.OnPressedState.IconRightImage = null;
            btnAddMovie.Size = new Size(145, 55);
            btnAddMovie.TabIndex = 164;
            btnAddMovie.TextAlign = ContentAlignment.MiddleCenter;
            btnAddMovie.TextAlignment = HorizontalAlignment.Center;
            btnAddMovie.TextMarginLeft = 0;
            btnAddMovie.TextPadding = new Padding(0);
            btnAddMovie.UseDefaultRadiusAndThickness = true;
            btnAddMovie.Click += btnAddMovie_Click;
            // 
            // btnUpdateMovie
            // 
            btnUpdateMovie.AllowAnimations = true;
            btnUpdateMovie.AllowMouseEffects = true;
            btnUpdateMovie.AllowToggling = false;
            btnUpdateMovie.AnimationSpeed = 200;
            btnUpdateMovie.AutoGenerateColors = false;
            btnUpdateMovie.AutoRoundBorders = false;
            btnUpdateMovie.AutoSizeLeftIcon = true;
            btnUpdateMovie.AutoSizeRightIcon = true;
            btnUpdateMovie.BackColor = Color.Transparent;
            btnUpdateMovie.BackColor1 = Color.FromArgb(51, 122, 183);
            btnUpdateMovie.BackgroundImage = (Image)resources.GetObject("btnUpdateMovie.BackgroundImage");
            btnUpdateMovie.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateMovie.ButtonText = "Sửa";
            btnUpdateMovie.ButtonTextMarginLeft = 0;
            btnUpdateMovie.ColorContrastOnClick = 45;
            btnUpdateMovie.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            btnUpdateMovie.CustomizableEdges = borderEdges2;
            btnUpdateMovie.DialogResult = DialogResult.None;
            btnUpdateMovie.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnUpdateMovie.DisabledFillColor = Color.Empty;
            btnUpdateMovie.DisabledForecolor = Color.Empty;
            btnUpdateMovie.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnUpdateMovie.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnUpdateMovie.ForeColor = Color.White;
            btnUpdateMovie.IconLeft = null;
            btnUpdateMovie.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnUpdateMovie.IconLeftCursor = Cursors.Default;
            btnUpdateMovie.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnUpdateMovie.IconMarginLeft = 11;
            btnUpdateMovie.IconPadding = 10;
            btnUpdateMovie.IconRight = null;
            btnUpdateMovie.IconRightAlign = ContentAlignment.MiddleRight;
            btnUpdateMovie.IconRightCursor = Cursors.Default;
            btnUpdateMovie.IconRightPadding = new Padding(3, 3, 7, 3);
            btnUpdateMovie.IconSize = 25;
            btnUpdateMovie.IdleBorderColor = Color.Empty;
            btnUpdateMovie.IdleBorderRadius = 0;
            btnUpdateMovie.IdleBorderThickness = 0;
            btnUpdateMovie.IdleFillColor = Color.Empty;
            btnUpdateMovie.IdleIconLeftImage = null;
            btnUpdateMovie.IdleIconRightImage = null;
            btnUpdateMovie.IndicateFocus = false;
            btnUpdateMovie.Location = new Point(390, 681);
            btnUpdateMovie.Name = "btnUpdateMovie";
            btnUpdateMovie.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnUpdateMovie.OnDisabledState.BorderRadius = 30;
            btnUpdateMovie.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateMovie.OnDisabledState.BorderThickness = 2;
            btnUpdateMovie.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnUpdateMovie.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnUpdateMovie.OnDisabledState.IconLeftImage = null;
            btnUpdateMovie.OnDisabledState.IconRightImage = null;
            btnUpdateMovie.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnUpdateMovie.onHoverState.BorderRadius = 30;
            btnUpdateMovie.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateMovie.onHoverState.BorderThickness = 2;
            btnUpdateMovie.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnUpdateMovie.onHoverState.ForeColor = Color.White;
            btnUpdateMovie.onHoverState.IconLeftImage = null;
            btnUpdateMovie.onHoverState.IconRightImage = null;
            btnUpdateMovie.OnIdleState.BorderColor = Color.DodgerBlue;
            btnUpdateMovie.OnIdleState.BorderRadius = 30;
            btnUpdateMovie.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateMovie.OnIdleState.BorderThickness = 2;
            btnUpdateMovie.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnUpdateMovie.OnIdleState.ForeColor = Color.White;
            btnUpdateMovie.OnIdleState.IconLeftImage = null;
            btnUpdateMovie.OnIdleState.IconRightImage = null;
            btnUpdateMovie.OnPressedState.BorderColor = Color.FromArgb(30, 150, 255);
            btnUpdateMovie.OnPressedState.BorderRadius = 30;
            btnUpdateMovie.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnUpdateMovie.OnPressedState.BorderThickness = 2;
            btnUpdateMovie.OnPressedState.FillColor = Color.Gold;
            btnUpdateMovie.OnPressedState.ForeColor = Color.White;
            btnUpdateMovie.OnPressedState.IconLeftImage = null;
            btnUpdateMovie.OnPressedState.IconRightImage = null;
            btnUpdateMovie.Size = new Size(145, 55);
            btnUpdateMovie.TabIndex = 165;
            btnUpdateMovie.TextAlign = ContentAlignment.MiddleCenter;
            btnUpdateMovie.TextAlignment = HorizontalAlignment.Center;
            btnUpdateMovie.TextMarginLeft = 0;
            btnUpdateMovie.TextPadding = new Padding(0);
            btnUpdateMovie.UseDefaultRadiusAndThickness = true;
            btnUpdateMovie.Click += btnUpdateMovie_Click;
            // 
            // btnDeleteMovie
            // 
            btnDeleteMovie.AllowAnimations = true;
            btnDeleteMovie.AllowMouseEffects = true;
            btnDeleteMovie.AllowToggling = false;
            btnDeleteMovie.AnimationSpeed = 200;
            btnDeleteMovie.AutoGenerateColors = false;
            btnDeleteMovie.AutoRoundBorders = false;
            btnDeleteMovie.AutoSizeLeftIcon = true;
            btnDeleteMovie.AutoSizeRightIcon = true;
            btnDeleteMovie.BackColor = Color.Transparent;
            btnDeleteMovie.BackColor1 = Color.FromArgb(51, 122, 183);
            btnDeleteMovie.BackgroundImage = (Image)resources.GetObject("btnDeleteMovie.BackgroundImage");
            btnDeleteMovie.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteMovie.ButtonText = "Xóa";
            btnDeleteMovie.ButtonTextMarginLeft = 0;
            btnDeleteMovie.ColorContrastOnClick = 45;
            btnDeleteMovie.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            btnDeleteMovie.CustomizableEdges = borderEdges3;
            btnDeleteMovie.DialogResult = DialogResult.None;
            btnDeleteMovie.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnDeleteMovie.DisabledFillColor = Color.Empty;
            btnDeleteMovie.DisabledForecolor = Color.Empty;
            btnDeleteMovie.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnDeleteMovie.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnDeleteMovie.ForeColor = Color.White;
            btnDeleteMovie.IconLeft = null;
            btnDeleteMovie.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnDeleteMovie.IconLeftCursor = Cursors.Default;
            btnDeleteMovie.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnDeleteMovie.IconMarginLeft = 11;
            btnDeleteMovie.IconPadding = 10;
            btnDeleteMovie.IconRight = null;
            btnDeleteMovie.IconRightAlign = ContentAlignment.MiddleRight;
            btnDeleteMovie.IconRightCursor = Cursors.Default;
            btnDeleteMovie.IconRightPadding = new Padding(3, 3, 7, 3);
            btnDeleteMovie.IconSize = 25;
            btnDeleteMovie.IdleBorderColor = Color.Empty;
            btnDeleteMovie.IdleBorderRadius = 0;
            btnDeleteMovie.IdleBorderThickness = 0;
            btnDeleteMovie.IdleFillColor = Color.Empty;
            btnDeleteMovie.IdleIconLeftImage = null;
            btnDeleteMovie.IdleIconRightImage = null;
            btnDeleteMovie.IndicateFocus = false;
            btnDeleteMovie.Location = new Point(605, 681);
            btnDeleteMovie.Name = "btnDeleteMovie";
            btnDeleteMovie.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnDeleteMovie.OnDisabledState.BorderRadius = 30;
            btnDeleteMovie.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteMovie.OnDisabledState.BorderThickness = 2;
            btnDeleteMovie.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnDeleteMovie.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnDeleteMovie.OnDisabledState.IconLeftImage = null;
            btnDeleteMovie.OnDisabledState.IconRightImage = null;
            btnDeleteMovie.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnDeleteMovie.onHoverState.BorderRadius = 30;
            btnDeleteMovie.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteMovie.onHoverState.BorderThickness = 2;
            btnDeleteMovie.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnDeleteMovie.onHoverState.ForeColor = Color.White;
            btnDeleteMovie.onHoverState.IconLeftImage = null;
            btnDeleteMovie.onHoverState.IconRightImage = null;
            btnDeleteMovie.OnIdleState.BorderColor = Color.DodgerBlue;
            btnDeleteMovie.OnIdleState.BorderRadius = 30;
            btnDeleteMovie.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteMovie.OnIdleState.BorderThickness = 2;
            btnDeleteMovie.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnDeleteMovie.OnIdleState.ForeColor = Color.White;
            btnDeleteMovie.OnIdleState.IconLeftImage = null;
            btnDeleteMovie.OnIdleState.IconRightImage = null;
            btnDeleteMovie.OnPressedState.BorderColor = Color.FromArgb(30, 150, 255);
            btnDeleteMovie.OnPressedState.BorderRadius = 30;
            btnDeleteMovie.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnDeleteMovie.OnPressedState.BorderThickness = 2;
            btnDeleteMovie.OnPressedState.FillColor = Color.Gold;
            btnDeleteMovie.OnPressedState.ForeColor = Color.White;
            btnDeleteMovie.OnPressedState.IconLeftImage = null;
            btnDeleteMovie.OnPressedState.IconRightImage = null;
            btnDeleteMovie.Size = new Size(145, 55);
            btnDeleteMovie.TabIndex = 166;
            btnDeleteMovie.TextAlign = ContentAlignment.MiddleCenter;
            btnDeleteMovie.TextAlignment = HorizontalAlignment.Center;
            btnDeleteMovie.TextMarginLeft = 0;
            btnDeleteMovie.TextPadding = new Padding(0);
            btnDeleteMovie.UseDefaultRadiusAndThickness = true;
            btnDeleteMovie.Click += btnDeleteMovie_Click;
            // 
            // btnExport
            // 
            btnExport.AllowAnimations = true;
            btnExport.AllowMouseEffects = true;
            btnExport.AllowToggling = false;
            btnExport.AnimationSpeed = 200;
            btnExport.AutoGenerateColors = false;
            btnExport.AutoRoundBorders = false;
            btnExport.AutoSizeLeftIcon = true;
            btnExport.AutoSizeRightIcon = true;
            btnExport.BackColor = Color.Transparent;
            btnExport.BackColor1 = Color.FromArgb(51, 122, 183);
            btnExport.BackgroundImage = (Image)resources.GetObject("btnExport.BackgroundImage");
            btnExport.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnExport.ButtonText = "Xuất File";
            btnExport.ButtonTextMarginLeft = 0;
            btnExport.ColorContrastOnClick = 45;
            btnExport.ColorContrastOnHover = 45;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            btnExport.CustomizableEdges = borderEdges4;
            btnExport.DialogResult = DialogResult.None;
            btnExport.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnExport.DisabledFillColor = Color.Empty;
            btnExport.DisabledForecolor = Color.Empty;
            btnExport.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnExport.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.IconLeft = null;
            btnExport.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnExport.IconLeftCursor = Cursors.Default;
            btnExport.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnExport.IconMarginLeft = 11;
            btnExport.IconPadding = 10;
            btnExport.IconRight = null;
            btnExport.IconRightAlign = ContentAlignment.MiddleRight;
            btnExport.IconRightCursor = Cursors.Default;
            btnExport.IconRightPadding = new Padding(3, 3, 7, 3);
            btnExport.IconSize = 25;
            btnExport.IdleBorderColor = Color.Empty;
            btnExport.IdleBorderRadius = 0;
            btnExport.IdleBorderThickness = 0;
            btnExport.IdleFillColor = Color.Empty;
            btnExport.IdleIconLeftImage = null;
            btnExport.IdleIconRightImage = null;
            btnExport.IndicateFocus = false;
            btnExport.Location = new Point(831, 681);
            btnExport.Name = "btnExport";
            btnExport.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnExport.OnDisabledState.BorderRadius = 30;
            btnExport.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnExport.OnDisabledState.BorderThickness = 2;
            btnExport.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnExport.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnExport.OnDisabledState.IconLeftImage = null;
            btnExport.OnDisabledState.IconRightImage = null;
            btnExport.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnExport.onHoverState.BorderRadius = 30;
            btnExport.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnExport.onHoverState.BorderThickness = 2;
            btnExport.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnExport.onHoverState.ForeColor = Color.White;
            btnExport.onHoverState.IconLeftImage = null;
            btnExport.onHoverState.IconRightImage = null;
            btnExport.OnIdleState.BorderColor = Color.DodgerBlue;
            btnExport.OnIdleState.BorderRadius = 30;
            btnExport.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnExport.OnIdleState.BorderThickness = 2;
            btnExport.OnIdleState.FillColor = Color.FromArgb(119, 33, 19);
            btnExport.OnIdleState.ForeColor = Color.White;
            btnExport.OnIdleState.IconLeftImage = null;
            btnExport.OnIdleState.IconRightImage = null;
            btnExport.OnPressedState.BorderColor = Color.FromArgb(30, 150, 255);
            btnExport.OnPressedState.BorderRadius = 30;
            btnExport.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnExport.OnPressedState.BorderThickness = 2;
            btnExport.OnPressedState.FillColor = Color.Gold;
            btnExport.OnPressedState.ForeColor = Color.White;
            btnExport.OnPressedState.IconLeftImage = null;
            btnExport.OnPressedState.IconRightImage = null;
            btnExport.Size = new Size(145, 55);
            btnExport.TabIndex = 167;
            btnExport.TextAlign = ContentAlignment.MiddleCenter;
            btnExport.TextAlignment = HorizontalAlignment.Center;
            btnExport.TextMarginLeft = 0;
            btnExport.TextPadding = new Padding(0);
            btnExport.UseDefaultRadiusAndThickness = true;
            btnExport.Click += btnExport_Click;
            // 
            // PhimUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            Controls.Add(btnExport);
            Controls.Add(btnDeleteMovie);
            Controls.Add(btnUpdateMovie);
            Controls.Add(btnAddMovie);
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
            Margin = new Padding(4, 2, 4, 2);
            Name = "PhimUC";
            Size = new Size(1618, 1232);
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
        //private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddMovie;
        //private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdateMovie;
        //private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDeleteMovie;
        //private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExport;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddMovie;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdateMovie;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDeleteMovie;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExport;
	}
}
