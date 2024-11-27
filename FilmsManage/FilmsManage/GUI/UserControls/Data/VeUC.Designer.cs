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
            panel61 = new Panel();
            btnShowAllTicketsByShowTime = new Button();
            btnShowAllTicketsBoughtByShowTime = new Button();
            btnAddTicketsByShowTime = new Button();
            btnAllListShowTimes = new Button();
            btnShowShowTimeNotCreateTickets = new Button();
            btnDeleteTicketsByShowTime = new Button();
            dtgvTicket = new DataGridView();
            panel1 = new Panel();
            lsvAllListShowTimes = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel61.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTicket).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel61
            // 
            panel61.Controls.Add(btnShowAllTicketsByShowTime);
            panel61.Controls.Add(btnShowAllTicketsBoughtByShowTime);
            panel61.Controls.Add(btnAddTicketsByShowTime);
            panel61.Controls.Add(btnAllListShowTimes);
            panel61.Controls.Add(btnShowShowTimeNotCreateTickets);
            panel61.Controls.Add(btnDeleteTicketsByShowTime);
            panel61.Dock = DockStyle.Top;
            panel61.Location = new Point(0, 0);
            panel61.Margin = new Padding(5, 6, 5, 6);
            panel61.Name = "panel61";
            panel61.Size = new Size(1935, 100);
            panel61.TabIndex = 10;
            // 
            // btnShowAllTicketsByShowTime
            // 
            btnShowAllTicketsByShowTime.Location = new Point(612, 6);
            btnShowAllTicketsByShowTime.Margin = new Padding(5, 6, 5, 6);
            btnShowAllTicketsByShowTime.Name = "btnShowAllTicketsByShowTime";
            btnShowAllTicketsByShowTime.Size = new Size(192, 89);
            btnShowAllTicketsByShowTime.TabIndex = 5;
            btnShowAllTicketsByShowTime.Text = "Xem Tất Cả Các Vé Theo Lịch Chiếu";
            btnShowAllTicketsByShowTime.UseVisualStyleBackColor = true;
            // 
            // btnShowAllTicketsBoughtByShowTime
            // 
            btnShowAllTicketsBoughtByShowTime.Location = new Point(410, 6);
            btnShowAllTicketsBoughtByShowTime.Margin = new Padding(5, 6, 5, 6);
            btnShowAllTicketsBoughtByShowTime.Name = "btnShowAllTicketsBoughtByShowTime";
            btnShowAllTicketsBoughtByShowTime.Size = new Size(192, 89);
            btnShowAllTicketsBoughtByShowTime.TabIndex = 4;
            btnShowAllTicketsBoughtByShowTime.Text = "Xem Các Vé Được Bán Theo Lịch Chiếu";
            btnShowAllTicketsBoughtByShowTime.UseVisualStyleBackColor = true;
            // 
            // btnAddTicketsByShowTime
            // 
            btnAddTicketsByShowTime.Location = new Point(5, 6);
            btnAddTicketsByShowTime.Margin = new Padding(5, 6, 5, 6);
            btnAddTicketsByShowTime.Name = "btnAddTicketsByShowTime";
            btnAddTicketsByShowTime.Size = new Size(192, 89);
            btnAddTicketsByShowTime.TabIndex = 0;
            btnAddTicketsByShowTime.Text = "Tự Động Thêm Vé Theo Lịch Chiếu\r\n";
            btnAddTicketsByShowTime.UseVisualStyleBackColor = true;
            // 
            // btnAllListShowTimes
            // 
            btnAllListShowTimes.Location = new Point(1018, 6);
            btnAllListShowTimes.Margin = new Padding(5, 6, 5, 6);
            btnAllListShowTimes.Name = "btnAllListShowTimes";
            btnAllListShowTimes.Size = new Size(192, 89);
            btnAllListShowTimes.TabIndex = 3;
            btnAllListShowTimes.Text = "Xem Tất Cả Lịch Chiếu\r\n";
            btnAllListShowTimes.UseVisualStyleBackColor = true;
            // 
            // btnShowShowTimeNotCreateTickets
            // 
            btnShowShowTimeNotCreateTickets.Location = new Point(815, 6);
            btnShowShowTimeNotCreateTickets.Margin = new Padding(5, 6, 5, 6);
            btnShowShowTimeNotCreateTickets.Name = "btnShowShowTimeNotCreateTickets";
            btnShowShowTimeNotCreateTickets.Size = new Size(192, 89);
            btnShowShowTimeNotCreateTickets.TabIndex = 3;
            btnShowShowTimeNotCreateTickets.Text = "Xem Lịch Chiếu Chưa Được Tạo Vé";
            btnShowShowTimeNotCreateTickets.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTicketsByShowTime
            // 
            btnDeleteTicketsByShowTime.Location = new Point(208, 6);
            btnDeleteTicketsByShowTime.Margin = new Padding(5, 6, 5, 6);
            btnDeleteTicketsByShowTime.Name = "btnDeleteTicketsByShowTime";
            btnDeleteTicketsByShowTime.Size = new Size(192, 89);
            btnDeleteTicketsByShowTime.TabIndex = 1;
            btnDeleteTicketsByShowTime.Text = "Xóa Vé Theo Lịch Chiếu";
            btnDeleteTicketsByShowTime.UseVisualStyleBackColor = true;
            // 
            // dtgvTicket
            // 
            dtgvTicket.AllowUserToAddRows = false;
            dtgvTicket.AllowUserToDeleteRows = false;
            dtgvTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTicket.Dock = DockStyle.Fill;
            dtgvTicket.Location = new Point(0, 100);
            dtgvTicket.Margin = new Padding(5, 6, 5, 6);
            dtgvTicket.Name = "dtgvTicket";
            dtgvTicket.RowHeadersWidth = 62;
            dtgvTicket.Size = new Size(1083, 602);
            dtgvTicket.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(lsvAllListShowTimes);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1083, 100);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 602);
            panel1.TabIndex = 11;
            // 
            // lsvAllListShowTimes
            // 
            lsvAllListShowTimes.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvAllListShowTimes.FullRowSelect = true;
            lsvAllListShowTimes.GridLines = true;
            lsvAllListShowTimes.Location = new Point(9, 11);
            lsvAllListShowTimes.Margin = new Padding(4, 5, 4, 5);
            lsvAllListShowTimes.Name = "lsvAllListShowTimes";
            lsvAllListShowTimes.Size = new Size(828, 879);
            lsvAllListShowTimes.TabIndex = 9;
            lsvAllListShowTimes.UseCompatibleStateImageBehavior = false;
            lsvAllListShowTimes.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên Phòng Chiếu";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên Phim";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Thời Gian";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Trạng Thái";
            columnHeader4.Width = 100;
            // 
            // VeUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtgvTicket);
            Controls.Add(panel1);
            Controls.Add(panel61);
            Margin = new Padding(4, 5, 4, 5);
            Name = "VeUC";
            Size = new Size(1935, 702);
            panel61.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTicket).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel61;
        private System.Windows.Forms.Button btnShowAllTicketsByShowTime;
        private System.Windows.Forms.Button btnShowAllTicketsBoughtByShowTime;
        private System.Windows.Forms.Button btnAddTicketsByShowTime;
        private System.Windows.Forms.Button btnAllListShowTimes;
        private System.Windows.Forms.Button btnShowShowTimeNotCreateTickets;
        private System.Windows.Forms.Button btnDeleteTicketsByShowTime;
        private DataGridView dtgvTicket;
        private Panel panel1;
        private ListView lsvAllListShowTimes;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
