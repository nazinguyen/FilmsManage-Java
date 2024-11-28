using FilmsManage.GUI.Forms;
using FilmsManage.Models;
using System.Data;
using System.Drawing.Drawing2D;

namespace FilmsManage
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //cbPassword.CheckedChanged += cbPassword_CheckedChanged;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //public bool checklogin(string username, string password)
        //{
        //    //try
        //    //{
        //    //    using (var db = new FilmsManageDbContext())
        //    //    {
        //    //        return db.NhanViens.Any(tk => tk.TenDangNhap == username && tk.MatKhau == password);
        //    //    }
        //    //}
        //    //catch (Exception)
        //    //{
        //    //    return false;
        //    //}
        //}

        public string USER_NAME = "";

        private void registrationButton_Click(object sender, EventArgs e)
        {
            //FilmsManageDbContext db = new FilmsManageDbContext();
            //string userName = txtUsername.Text;
            //string passWord = txtPassword.Text;
            //USER_NAME = userName;

            //if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
            //{
            //    MessageBox.Show("Please fill all fields!");
            //    return;
            //}
            //if (checklogin(userName, passWord))
            //{
            //    this.Hide();
            //}
            //else
            //{

            //    MessageBox.Show("Fail to login. Please try again!");
            //}
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbPassword.Checked ? '\0' : '*';
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

    }
}
