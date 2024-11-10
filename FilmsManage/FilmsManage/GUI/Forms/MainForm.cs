using FilmsManage.GUI.DataUserControl;
using FilmsManage.GUI.UserControls;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAccountUC_Click(object sender, EventArgs e)
        {
            this.Text = "Tài Khoản";

            if (!(pnAdmin.Controls.OfType<Account>().Any()))
            {
                pnAdmin.Controls.Clear();
                Account accountUc = new Account();
                accountUc.Dock = DockStyle.Fill;
                pnAdmin.Controls.Add(accountUc);
            }
        }

        private void pnAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCustomerUC_Click(object sender, EventArgs e)
        {
            this.Text = "Khách hàng";

            if (!(pnAdmin.Controls.OfType<Customer>().Any()))
            {
                pnAdmin.Controls.Clear();
                Customer customerUc = new Customer();
                customerUc.Dock = DockStyle.Fill;
                pnAdmin.Controls.Add(customerUc);
            }
        }

        private void btnStaffUC_Click(object sender, EventArgs e)
        {
            this.Text = "Nhân viên";

            if (!(pnAdmin.Controls.OfType<Staff>().Any()))
            {
                pnAdmin.Controls.Clear();
                Staff staffUc = new Staff();
                staffUc.Dock = DockStyle.Fill;
                pnAdmin.Controls.Add(staffUc);
            }
        }

        private void btnDataUC_Click(object sender, EventArgs e)
        {
            this.Text = "Dữ liệu";

            if (!(pnAdmin.Controls.OfType<DataUC>().Any()))
            {
                pnAdmin.Controls.Clear();
                DataUC dataUc = new DataUC();
                dataUc.Dock = DockStyle.Fill;
                pnAdmin.Controls.Add(dataUc);
            }
        }

        private void btnRevenueUC_Click(object sender, EventArgs e)
        {
            this.Text = "Doanh thu";

            if (!(pnAdmin.Controls.OfType<DoanhThu>().Any()))
            {
                pnAdmin.Controls.Clear();
                DoanhThu doanhThu = new DoanhThu();
                doanhThu.Dock = DockStyle.Fill;
                pnAdmin.Controls.Add(doanhThu);
            }
        }
    }
}
