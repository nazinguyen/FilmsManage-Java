namespace FilmsManage.GUI.Forms
{
    partial class Register
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new Label();
            clearButton = new Button();
            cbPassword = new CheckBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            btn_Register = new Button();
            btn_Login = new Button();
            txtConfirmPass = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(104, 633);
            label5.Name = "label5";
            label5.Size = new Size(196, 25);
            label5.TabIndex = 20;
            label5.Text = "You have an account?";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.White;
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatAppearance.BorderSize = 2;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.ForeColor = Color.DimGray;
            clearButton.Location = new Point(359, 19);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(29, 35);
            clearButton.TabIndex = 4;
            clearButton.Text = "X";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // cbPassword
            // 
            cbPassword.AutoSize = true;
            cbPassword.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            cbPassword.ForeColor = Color.FromArgb(64, 64, 64);
            cbPassword.Location = new Point(32, 363);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(184, 25);
            cbPassword.TabIndex = 16;
            cbPassword.Text = "Hiển thị mật khẩu";
            cbPassword.UseVisualStyleBackColor = true;
            cbPassword.CheckedChanged += cbPassword_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(29, 209);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 8;
            label2.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Arial", 12F);
            txtUsername.Location = new Point(32, 163);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(330, 28);
            txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(29, 133);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 9;
            label1.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(32, 61);
            label3.Name = "label3";
            label3.Size = new Size(206, 27);
            label3.TabIndex = 6;
            label3.Text = "Đăng kí tài khoản";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Arial", 12F);
            txtPassword.Location = new Point(32, 238);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(330, 28);
            txtPassword.TabIndex = 1;
            // 
            // btn_Register
            // 
            btn_Register.BackColor = Color.FromArgb(133, 19, 33);
            btn_Register.Cursor = Cursors.Hand;
            btn_Register.FlatAppearance.BorderSize = 0;
            btn_Register.FlatStyle = FlatStyle.Flat;
            btn_Register.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Register.ForeColor = Color.White;
            btn_Register.Location = new Point(29, 411);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(330, 52);
            btn_Register.TabIndex = 3;
            btn_Register.Text = "Đăng kí";
            btn_Register.UseVisualStyleBackColor = false;
            btn_Register.Click += registrationButton_Click;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.FromArgb(133, 19, 33);
            btn_Login.Cursor = Cursors.Hand;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(29, 674);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(330, 52);
            btn_Login.TabIndex = 21;
            btn_Login.Text = "Đăng nhập";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.BackColor = Color.FromArgb(230, 231, 233);
            txtConfirmPass.BorderStyle = BorderStyle.None;
            txtConfirmPass.Font = new Font("Arial", 12F);
            txtConfirmPass.Location = new Point(32, 314);
            txtConfirmPass.Multiline = true;
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PasswordChar = '*';
            txtConfirmPass.Size = new Size(330, 28);
            txtConfirmPass.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(29, 285);
            label4.Name = "label4";
            label4.Size = new Size(175, 21);
            label4.TabIndex = 23;
            label4.Text = "Xác nhận mật khẩu";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 761);
            ControlBox = false;
            Controls.Add(txtConfirmPass);
            Controls.Add(label4);
            Controls.Add(btn_Login);
            Controls.Add(label5);
            Controls.Add(clearButton);
            Controls.Add(btn_Register);
            Controls.Add(cbPassword);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(label3);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox cbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private Button btn_Register;
        private Button btn_Login;
        private TextBox txtConfirmPass;
        private Label label4;
    }
}