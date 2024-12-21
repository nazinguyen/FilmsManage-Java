namespace FilmsManage.GUI.Forms.BanVe_Form.UserControl_BanVe
{
    partial class Food
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
            flpFillFood = new FlowLayoutPanel();
            pnlLIstButton = new Panel();
            BtnNuocUong = new Button();
            BtnDoAn = new Button();
            btnTatCa = new Button();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlTitle = new Panel();
            label1 = new Label();
            btnTiepTuc = new Button();
            btnHuy = new Button();
            panel1.SuspendLayout();
            pnlLIstButton.SuspendLayout();
            panel2.SuspendLayout();
            pnlTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(flpFillFood);
            panel1.Controls.Add(pnlLIstButton);
            panel1.Location = new Point(17, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(1021, 677);
            panel1.TabIndex = 0;
            // 
            // flpFillFood
            // 
            flpFillFood.AutoScroll = true;
            flpFillFood.Location = new Point(3, 56);
            flpFillFood.Name = "flpFillFood";
            flpFillFood.Size = new Size(1015, 618);
            flpFillFood.TabIndex = 1;
            // 
            // pnlLIstButton
            // 
            pnlLIstButton.Controls.Add(BtnNuocUong);
            pnlLIstButton.Controls.Add(BtnDoAn);
            pnlLIstButton.Controls.Add(btnTatCa);
            pnlLIstButton.Location = new Point(3, 3);
            pnlLIstButton.Name = "pnlLIstButton";
            pnlLIstButton.Size = new Size(1015, 47);
            pnlLIstButton.TabIndex = 0;
            // 
            // BtnNuocUong
            // 
            BtnNuocUong.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNuocUong.Location = new Point(681, -3);
            BtnNuocUong.Name = "BtnNuocUong";
            BtnNuocUong.Size = new Size(334, 50);
            BtnNuocUong.TabIndex = 2;
            BtnNuocUong.Text = "Thức uống";
            BtnNuocUong.UseVisualStyleBackColor = true;
            BtnNuocUong.Click += BtnNuocUong_Click;
            BtnNuocUong.Paint += BtnNuocUong_Paint;
            // 
            // BtnDoAn
            // 
            BtnDoAn.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDoAn.Location = new Point(329, 0);
            BtnDoAn.Name = "BtnDoAn";
            BtnDoAn.Size = new Size(356, 47);
            BtnDoAn.TabIndex = 1;
            BtnDoAn.Text = "Đồ ăn";
            BtnDoAn.UseVisualStyleBackColor = true;
            BtnDoAn.Click += BtnDoAn_Click;
            BtnDoAn.Paint += BtnDoAn_Paint;
            // 
            // btnTatCa
            // 
            btnTatCa.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTatCa.Location = new Point(0, 0);
            btnTatCa.Name = "btnTatCa";
            btnTatCa.Size = new Size(330, 47);
            btnTatCa.TabIndex = 0;
            btnTatCa.Text = "Tất cả";
            btnTatCa.UseVisualStyleBackColor = true;
            btnTatCa.Click += btnTatCa_Click;
            btnTatCa.Paint += btnTatCa_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(pnlTitle);
            panel2.Location = new Point(1151, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 671);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(16, 65);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(380, 586);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // pnlTitle
            // 
            pnlTitle.Controls.Add(label1);
            pnlTitle.Location = new Point(16, 3);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(368, 56);
            pnlTitle.TabIndex = 0;
            pnlTitle.Paint += pnlTitle_Paint;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(99, 6);
            label1.Name = "label1";
            label1.Size = new Size(162, 38);
            label1.TabIndex = 0;
            label1.Text = "Giỏ hàng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTiepTuc
            // 
            btnTiepTuc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTiepTuc.Location = new Point(1137, 785);
            btnTiepTuc.Name = "btnTiepTuc";
            btnTiepTuc.Size = new Size(219, 50);
            btnTiepTuc.TabIndex = 2;
            btnTiepTuc.Text = "Tiếp tục";
            btnTiepTuc.UseVisualStyleBackColor = true;
            btnTiepTuc.Click += btnTiepTuc_Click;
            btnTiepTuc.Paint += btnTiepTuc_Paint;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(1362, 785);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(219, 50);
            btnHuy.TabIndex = 3;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            btnHuy.Paint += btnHuy_Paint;
            // 
            // Food
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnHuy);
            Controls.Add(btnTiepTuc);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Food";
            Size = new Size(1615, 875);
            panel1.ResumeLayout(false);
            pnlLIstButton.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnlTitle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlLIstButton;
        private Button btnTatCa;
        private FlowLayoutPanel flpFillFood;
        private Button BtnNuocUong;
        private Button BtnDoAn;
        private Panel panel2;
        private Panel pnlTitle;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnTiepTuc;
        private Button btnHuy;
    }
}
