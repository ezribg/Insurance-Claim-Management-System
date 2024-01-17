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
    public partial class AdminPrivileges : Form
    {
        public AdminPrivileges()
        {
            InitializeComponent();
            comBox1.SelectedIndex = 0;
            comBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm backToLogin = new LoginForm();
            this.Hide();
            backToLogin.Show();
        }

        private void btnSub1_Click(object sender, EventArgs e)
        {
            clsUser updateUser = new clsUser(); //create an OtherUser instance for updating
            updateUser.Username = txtUser1.Text.ToString(); //this is actually for searching by the username, but you put it into the updateUser.email because that's how the FetchUser works
            updateUser.FetchUser(true); //fetch user information of user with the input username
            if (updateUser.Id == 0) //Id will be 0 if the user doesn't exist
            {
                MessageBox.Show("User does not exist.", "User Privileges Feedback");
                txtUser1.Text = String.Empty;
            }
            else //else, user is found
            {
                updateUser.Type = comBox1.SelectedItem.ToString(); //update the type of updateUser
                updateUser.UpdateDatabase(); //push the update to the database
                MessageBox.Show("User type updated.", "User Privileges Feedback");
                txtUser1.Text = String.Empty;
                comBox1.SelectedIndex = -1;
            }
        }

        private void btnSub2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUser2.Text)) //makes sure username is entered
            {
                MessageBox.Show("No username entered, please enter a username.", "Registration Feedback");
            }
            else if (String.IsNullOrEmpty(txtPass.Text)) //makes sure password is entered
            {
                MessageBox.Show("No password entered, please enter a password.", "Registration Feedback");
            }
            else if (comBox2.SelectedIndex == -1) //makes sure type is selected
            {
                MessageBox.Show("No user type selected, please choose a user type.", "Registration Feedback");
            }
            else
            {
                clsUser newUser = new clsUser(); //create an OtherUser instance for the new user 
                newUser.Username = txtUser2.Text.ToString(); //set username, password, and type from user input
                newUser.Password = txtPass.Text.ToString();
                newUser.Type = comBox2.SelectedItem.ToString();
                txtUser2.Text = "";
                txtPass.Text = "";
                comBox2.SelectedIndex = -1;
                newUser.CreateUser(); //call CreateUser
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            clsUser.BackHome();
        }

        private void AdminPrivileges_Load(object sender, EventArgs e)
        {

        }
    }
}
