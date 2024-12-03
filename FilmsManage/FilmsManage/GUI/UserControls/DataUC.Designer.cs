namespace FilmsManage.GUI.DataUserControl
{
    partial class DataUC
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
            SidePanel = new Panel();
            btnTicketsUC = new Button();
            btnShowTimesUC = new Button();
            btnFormatMovieUC = new Button();
            btnMovieUC = new Button();
            btnGenreUC = new Button();
            btnCinemaUC = new Button();
            btnScreenTypeUC = new Button();
            pnData = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 39, 40);
            panel1.Controls.Add(SidePanel);
            panel1.Controls.Add(btnTicketsUC);
            panel1.Controls.Add(btnShowTimesUC);
            panel1.Controls.Add(btnFormatMovieUC);
            panel1.Controls.Add(btnMovieUC);
            panel1.Controls.Add(btnGenreUC);
            panel1.Controls.Add(btnCinemaUC);
            panel1.Controls.Add(btnScreenTypeUC);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 1028);
            panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(178, 8, 55);
            SidePanel.Location = new Point(0, 116);
            SidePanel.Margin = new Padding(5, 6, 5, 6);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(16, 103);
            SidePanel.TabIndex = 5;
            // 
            // btnTicketsUC
            // 
            btnTicketsUC.FlatAppearance.BorderSize = 0;
            btnTicketsUC.FlatStyle = FlatStyle.Flat;
            btnTicketsUC.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTicketsUC.ForeColor = Color.White;
            btnTicketsUC.ImageAlign = ContentAlignment.MiddleLeft;
            btnTicketsUC.Location = new Point(19, 734);
            btnTicketsUC.Margin = new Padding(5, 6, 5, 6);
            btnTicketsUC.Name = "btnTicketsUC";
            btnTicketsUC.Size = new Size(267, 103);
            btnTicketsUC.TabIndex = 6;
            btnTicketsUC.Text = "       Vé";
            btnTicketsUC.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTicketsUC.UseVisualStyleBackColor = true;
            btnTicketsUC.Click += btnTicketsUC_Click;
            // 
            // btnShowTimesUC
            // 
            btnShowTimesUC.FlatAppearance.BorderSize = 0;
            btnShowTimesUC.FlatStyle = FlatStyle.Flat;
            btnShowTimesUC.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowTimesUC.ForeColor = Color.White;
            btnShowTimesUC.ImageAlign = ContentAlignment.MiddleLeft;
            btnShowTimesUC.Location = new Point(19, 631);
            btnShowTimesUC.Margin = new Padding(5, 6, 5, 6);
            btnShowTimesUC.Name = "btnShowTimesUC";
            btnShowTimesUC.Size = new Size(267, 103);
            btnShowTimesUC.TabIndex = 7;
            btnShowTimesUC.Text = "      Lịch Chiếu";
            btnShowTimesUC.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnShowTimesUC.UseVisualStyleBackColor = true;
            btnShowTimesUC.Click += btnShowTimesUC_Click;
            // 
            // btnFormatMovieUC
            // 
            btnFormatMovieUC.FlatAppearance.BorderSize = 0;
            btnFormatMovieUC.FlatStyle = FlatStyle.Flat;
            btnFormatMovieUC.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFormatMovieUC.ForeColor = Color.White;
            btnFormatMovieUC.ImageAlign = ContentAlignment.MiddleLeft;
            btnFormatMovieUC.Location = new Point(19, 527);
            btnFormatMovieUC.Margin = new Padding(5, 6, 5, 6);
            btnFormatMovieUC.Name = "btnFormatMovieUC";
            btnFormatMovieUC.Size = new Size(267, 103);
            btnFormatMovieUC.TabIndex = 8;
            btnFormatMovieUC.Text = "      Định Dạng";
            btnFormatMovieUC.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFormatMovieUC.UseVisualStyleBackColor = true;
            btnFormatMovieUC.Click += btnFormatMovieUC_Click;
            // 
            // btnMovieUC
            // 
            btnMovieUC.FlatAppearance.BorderSize = 0;
            btnMovieUC.FlatStyle = FlatStyle.Flat;
            btnMovieUC.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMovieUC.ForeColor = Color.White;
            btnMovieUC.ImageAlign = ContentAlignment.MiddleLeft;
            btnMovieUC.Location = new Point(19, 423);
            btnMovieUC.Margin = new Padding(5, 6, 5, 6);
            btnMovieUC.Name = "btnMovieUC";
            btnMovieUC.Size = new Size(267, 103);
            btnMovieUC.TabIndex = 9;
            btnMovieUC.Text = "       Phim";
            btnMovieUC.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMovieUC.UseVisualStyleBackColor = true;
            btnMovieUC.Click += btnMovieUC_Click;
            // 
            // btnGenreUC
            // 
            btnGenreUC.FlatAppearance.BorderSize = 0;
            btnGenreUC.FlatStyle = FlatStyle.Flat;
            btnGenreUC.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenreUC.ForeColor = Color.White;
            btnGenreUC.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenreUC.Location = new Point(19, 320);
            btnGenreUC.Margin = new Padding(5, 6, 5, 6);
            btnGenreUC.Name = "btnGenreUC";
            btnGenreUC.Size = new Size(267, 103);
            btnGenreUC.TabIndex = 10;
            btnGenreUC.Text = "      Thể Loại";
            btnGenreUC.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGenreUC.UseVisualStyleBackColor = true;
            btnGenreUC.Click += btnGenreUC_Click;
            // 
            // btnCinemaUC
            // 
            btnCinemaUC.FlatAppearance.BorderSize = 0;
            btnCinemaUC.FlatStyle = FlatStyle.Flat;
            btnCinemaUC.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCinemaUC.ForeColor = Color.White;
            btnCinemaUC.ImageAlign = ContentAlignment.MiddleLeft;
            btnCinemaUC.Location = new Point(19, 216);
            btnCinemaUC.Margin = new Padding(5, 6, 5, 6);
            btnCinemaUC.Name = "btnCinemaUC";
            btnCinemaUC.Size = new Size(267, 103);
            btnCinemaUC.TabIndex = 11;
            btnCinemaUC.Text = "       Phòng Chiếu";
            btnCinemaUC.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCinemaUC.UseVisualStyleBackColor = true;
            btnCinemaUC.Click += btnCinemaUC_Click;
            // 
            // btnScreenTypeUC
            // 
            btnScreenTypeUC.FlatAppearance.BorderSize = 0;
            btnScreenTypeUC.FlatStyle = FlatStyle.Flat;
            btnScreenTypeUC.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnScreenTypeUC.ForeColor = Color.White;
            btnScreenTypeUC.ImageAlign = ContentAlignment.MiddleLeft;
            btnScreenTypeUC.Location = new Point(19, 112);
            btnScreenTypeUC.Margin = new Padding(5, 6, 5, 6);
            btnScreenTypeUC.Name = "btnScreenTypeUC";
            btnScreenTypeUC.Size = new Size(267, 103);
            btnScreenTypeUC.TabIndex = 12;
            btnScreenTypeUC.Text = "     Loại màn hình";
            btnScreenTypeUC.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnScreenTypeUC.UseVisualStyleBackColor = true;
            btnScreenTypeUC.Click += btnScreenTypeUC_Click;
            // 
            // pnData
            // 
            pnData.Dock = DockStyle.Bottom;
            pnData.Location = new Point(286, 5);
            pnData.Margin = new Padding(4, 5, 4, 5);
            pnData.Name = "pnData";
            pnData.Size = new Size(2002, 1023);
            pnData.TabIndex = 1;
            pnData.Paint += pnData_Paint;
            // 
            // DataUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnData);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DataUC";
            Size = new Size(2288, 1028);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnTicketsUC;
        private System.Windows.Forms.Button btnShowTimesUC;
        private System.Windows.Forms.Button btnFormatMovieUC;
        private System.Windows.Forms.Button btnMovieUC;
        private System.Windows.Forms.Button btnGenreUC;
        private System.Windows.Forms.Button btnCinemaUC;
        private System.Windows.Forms.Button btnScreenTypeUC;
        public System.Windows.Forms.Panel pnData;
    }
}
