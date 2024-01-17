using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICMS
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm backToLogin = new LoginForm();
            this.Hide();
            backToLogin.Show();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUser.Text)) //checks to make sure username is entered
            {
                MessageBox.Show("No username entered, please enter a username.", "Registration Feedback");
            }
            else if (String.IsNullOrEmpty(txtPass.Text)) //checks to make sure password is entered
            {
                MessageBox.Show("No password entered, please enter a password.", "Registration Feedback");
            }
            else
            {
                clsUser newUser = new clsUser(); //creates an instance of OtherUser for the new user
                newUser.Username = txtUser.Text.ToString(); //sets username and password from user input
                newUser.Password = txtPass.Text.ToString();
                newUser.CreateUser(); //calls CreateUser
                LoginForm backToLogin = new LoginForm(); //return to login screen
                this.Hide();
                backToLogin.Show();
            }
        }
    }
}
