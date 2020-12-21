using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Event_Management.ServiceReference1;

namespace Event_Management
{
    public partial class fRegister : Form
    {
        public fRegister()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new fLogin();
            f.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Id = txbID.Text;
            acc.UserName = txbUserName.Text;
            acc.Password = txbPassword.Text;
            acc.Type = 1;
            acc.Email = txbEmail.Text;
            acc.PhoneNumber = txbPhoneNumber.Text;
            acc.CreatedTime = DateTime.Now;

            Service1Client service = new Service1Client();

            if (service.InsertAccount(acc) == 1)
            {
                MessageBox.Show("Đăng ký thành công!");
            }
        }
    }
}
