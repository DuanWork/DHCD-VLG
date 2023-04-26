using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoDong
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(215, 33, 52);
            if (txtUserName.Text == "Admin" && txtPassword.Text == "12345")
            {
                new Index().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The User name or password you entered is incorrect, try again");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
                txtPassword.Focus();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
