using Event_Management.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wcf;

namespace Event_Management
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình?","Thoát chương trình?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //fMain f = new fMain();
            //this.Hide();
            //f.ShowDialog();
            //this.Show();

            Service1 service = new Service1();
            string userName = txbUserName.Text;
            string passWord = txbPassword.Text;
            Console.WriteLine(userName);
            Console.WriteLine(passWord);
            if (service.Login(userName, passWord) == true)
            {
                fMain f = new fMain();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new fRegister();
            f.Show();
        }

    }
}
