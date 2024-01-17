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
    public partial class LoginForm : Form
    {
        //WelcomeForm frmwelcome;
        public LoginForm()
        {
            clsUser.current.Logout();
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateUserForm registration = new CreateUserForm();
            this.Hide();
            registration.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("No Username Entered, please enter your username.", "Login Feedback");
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("No Password Entered, please enter your password.", "Login Feedback");
            }
            else
            {
                clsUser.current.Username = txtUsername.Text;
                clsUser.current.Password = txtPassword.Text;

                clsUser.current = clsDBH_User.Login(clsUser.current);

                if (clsUser.current.Id > 0)
                {
                    clsUser.current.CreateProfile();

                    // determines user type for directing user to proper landing page
                    if (clsUser.current.Type == "admin")
                    {
                        AdminLandingPage adminWelcome = new AdminLandingPage();
                        this.Hide();

                        adminWelcome.Show();
                    }
                    else if (clsUser.current.Type == "claimManager")
                    {
                        CMLandingPage claimWelcome = new CMLandingPage();
                        this.Hide();

                        claimWelcome.Show();
                    }
                    else if (clsUser.current.Type == "financeManager")
                    {
                        FMLanding financeWelcome = new FMLanding();
                        this.Hide();

                        financeWelcome.Show();
                    }
                    else if (clsUser.current.Type == "client")
                    {
                        ClientLandingPage clientWelcome = new ClientLandingPage();
                        this.Hide();

                        clientWelcome.Show();
                    }
                    else
                    {
                        MessageBox.Show("No user type, please contact administrator.", "Login Feedback");
                    }
                }
                else { MessageBox.Show("Incorrect Username/Password!", "Login Unsuccessful"); }
            }
        }
    }
}
