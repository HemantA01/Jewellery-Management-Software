using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JewelleryShopManagementApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == " " && txtPassword.Text == " ")
            {
                MessageBox.Show("Missing information to Login");
            }
            //else if (txtUsername.Text == "Admin" && txtPassword.Text == "Admin@123")
            else if (txtUsername.Text == "1" && txtPassword.Text == "1")
            {
                MessageBox.Show("Login Successful");
                Customer obj = new Customer();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please entrer correct Username and password");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPassword.Text = " ";
            txtPassword.Text = " ";
        }

        
    }
}
