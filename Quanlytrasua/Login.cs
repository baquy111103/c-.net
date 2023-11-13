using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlytrasua
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {   
            string userName = txbUserName1.Text;
            string passWord = txbPassWord1.Text;
            if (Login1(userName,passWord)) 
            {
                fTableManager f = new fTableManager();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!!");
            }
        }
        bool Login1(string userName,string passWord)
        {  
            return AccountDAO.Instance.Login1(userName, passWord);  
        }
        private void btnThoat1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
