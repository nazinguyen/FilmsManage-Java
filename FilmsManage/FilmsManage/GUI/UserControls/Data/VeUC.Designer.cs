namespace FilmsManage.GUI.UserControls.Data
{
    partial class VeUC
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
            btnAddTicketsByShowTime = new Button();
            btnAllListShowTimes = new Button();
            btnShowShowTimeNotCreateTickets = new Button();
            lsvAllListShowTimes = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            dtgvVe = new DataGridView();
            btnExport = new Button();
            txtSearchShowtime = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgvVe).BeginInit();
            SuspendLayout();
            // 
            // btnAddTicketsByShowTime
            // 
            btnAddTicketsByShowTime.Location = new Point(6, 175);
            btnAddTicketsByShowTime.Margin = new Padding(5, 6, 5, 6);
            btnAddTicketsByShowTime.Name = "btnAddTicketsByShowTime";
            btnAddTicketsByShowTime.Size = new Size(192, 89);
            btnAddTicketsByShowTime.TabIndex = 0;
            btnAddTicketsByShowTime.Text = "Tự Động Thêm Vé Theo Lịch Chiếu\r\n";
            btnAddTicketsByShowTime.UseVisualStyleBackColor = true;
            btnAddTicketsByShowTime.Click += btnAddTicketsByShowTime_Click;
            // 
            // btnAllListShowTimes
            // 
            btnAllListShowTimes.Location = new Point(483, 175);
            btnAllListShowTimes.Margin = new Padding(5, 6, 5, 6);
            btnAllListShowTimes.Name = "btnAllListShowTimes";
            btnAllListShowTimes.Size = new Size(192, 89);
            btnAllListShowTimes.TabIndex = 3;
            btnAllListShowTimes.Text = "Xem Tất Cả Lịch Chiếu\r\n";
            btnAllListShowTimes.UseVisualStyleBackColor = true;
            btnAllListShowTimes.Click += btnAllListShowTimes_Click;
            // 
            // btnShowShowTimeNotCreateTickets
            // 
            btnShowShowTimeNotCreateTickets.Location = new Point(240, 175);
            btnShowShowTimeNotCreateTickets.Margin = new Padding(5, 6, 5, 6);
            btnShowShowTimeNotCreateTickets.Name = "btnShowShowTimeNotCreateTickets";
            btnShowShowTimeNotCreateTickets.Size = new Size(192, 89);
            btnShowShowTimeNotCreateTickets.TabIndex = 3;
            btnShowShowTimeNotCreateTickets.Text = "Xem Lịch Chiếu Chưa Được Tạo Vé";
            btnShowShowTimeNotCreateTickets.UseVisualStyleBackColor = true;
            btnShowShowTimeNotCreateTickets.Click += btnShowShowTimeNotCreateTickets_Click;
            // 
            // lsvAllListShowTimes
            // 
            lsvAllListShowTimes.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvAllListShowTimes.FullRowSelect = true;
            lsvAllListShowTimes.GridLines = true;
            lsvAllListShowTimes.Location = new Point(0, 304);
            lsvAllListShowTimes.Margin = new Padding(4, 5, 4, 5);
            lsvAllListShowTimes.Name = "lsvAllListShowTimes";
            lsvAllListShowTimes.Size = new Size(828, 763);
            lsvAllListShowTimes.TabIndex = 9;
            lsvAllListShowTimes.UseCompatibleStateImageBehavior = false;
            lsvAllListShowTimes.View = View.Details;
            lsvAllListShowTimes.SelectedIndexChanged += lsvAllListShowTimes_SelectedIndexChanged;
            lsvAllListShowTimes.MouseClick += lsvAllListShowTimes_MouseClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên phòng chiếu";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên phim";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Thời gian";
            columnHeader3.Width = 400;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Trạng thái";
            columnHeader4.Width = 150;
            // 
            // dtgvVe
            // 
            dtgvVe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvVe.Location = new Point(832, 304);
            dtgvVe.Name = "dtgvVe";
            dtgvVe.RowHeadersWidth = 62;
            dtgvVe.Size = new Size(831, 760);
            dtgvVe.TabIndex = 10;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(1306, 175);
            btnExport.Margin = new Padding(5, 6, 5, 6);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(129, 89);
            btnExport.TabIndex = 165;
            btnExport.Text = "Xuất file";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click_1;
            // 
            // txtSearchShowtime
            // 
            txtSearchShowtime.BackColor = SystemColors.ControlLightLight;
            txtSearchShowtime.BorderStyle = BorderStyle.FixedSingle;
            txtSearchShowtime.Location = new Point(749, 223);
            txtSearchShowtime.Margin = new Padding(3, 4, 3, 4);
            txtSearchShowtime.Multiline = true;
            txtSearchShowtime.Name = "txtSearchShowtime";
            txtSearchShowtime.Size = new Size(417, 41);
            txtSearchShowtime.TabIndex = 48;
            txtSearchShowtime.Text = "Tìm theo tên phim...";
            txtSearchShowtime.TextChanged += txtSearchShowtime_TextChanged;
            // 
            // VeUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnExport);
            Controls.Add(txtSearchShowtime);
            Controls.Add(dtgvVe);
            Controls.Add(btnAllListShowTimes);
            Controls.Add(btnShowShowTimeNotCreateTickets);
            Controls.Add(lsvAllListShowTimes);
            Controls.Add(btnAddTicketsByShowTime);
            Margin = new Padding(4, 5, 4, 5);
            Name = "VeUC";
            Size = new Size(1663, 1067);
            ((System.ComponentModel.ISupportInitialize)dtgvVe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel61;
        private System.Windows.Forms.Button btnShowAllTicketsBoughtByShowTime;
        private System.Windows.Forms.Button btnAddTicketsByShowTime;
        private System.Windows.Forms.Button btnAllListShowTimes;
        private System.Windows.Forms.Button btnShowShowTimeNotCreateTickets;
        private System.Windows.Forms.Button btnDeleteTicketsByShowTime;
        private DataGridView dtgvTicket;
        private Panel panel1;
        private ListView lsvAllListShowTimes;
        private DataGridView dataGridView1;
        private DataGridView dtgvVe;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;

        private Button btnExport;

        private TextBox txtSearchShowtime;

    }
}
