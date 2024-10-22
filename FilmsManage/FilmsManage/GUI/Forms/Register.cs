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
            //if (conn != null && conn.State == ConnectionState.Open)
            //{
            //    conn.Close();
            //}
            //conn.Open();
            //string login = ("SELECT * FROM csharp_user WHERE username =  '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "' ");
            //cmd = new NpgsqlCommand(login, conn);
            //NpgsqlDataReader dr = cmd.ExecuteReader();


            //if (dr.Read() == true)
            //{
            //    conn.Close();
            //    new Dashboard().Show();
            //    Dashboard.instance.lbl.Text = txtUsername.Text;
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Credentials, please try Again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtUsername.Text = "";
            //    txtPassword.Text = "";
            //    txtUsername.Focus();
            //    if (conn != null && conn.State == ConnectionState.Closed)
            //    {
            //        conn.Open();
            //    }
            //}
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
