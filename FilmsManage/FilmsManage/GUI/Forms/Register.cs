using FilmsManage.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsManage.GUI.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            var userName = txtUsername.Text;
            var password = txtPassword.Text;
            var confirmPassword = txtConfirmPass.Text;
            if (password != confirmPassword) {
                MessageBox.Show("Vui lòng xác nhận đúng mật khẩu!");
                return;
            }

            try
            {
                var registerDTO = new RegisterDTO() { 
                    password = password,
                    userName = userName,
                };
            }
            catch (Exception ex)
            {

            }
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbPassword.Checked ? '\0' : '*';
            txtConfirmPass.PasswordChar = cbPassword.Checked ? '\0' : '*';
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
