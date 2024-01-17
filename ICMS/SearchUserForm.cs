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
    public partial class SearchUserForm : Form
    {
        clsUser searchUser = new clsUser();
        public SearchUserForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            if (comBox.SelectedIndex == 0)//email
            {
                searchUser.Email = txtSearch.Text.ToString();
                searchUser.FetchUser();
                if (searchUser.Id == 0)
                {
                    MessageBox.Show("Email does not exist.", "Search Feedback");
                    txtSearch.Text = String.Empty;
                }
                else if (searchUser.Type != "client")
                {
                    MessageBox.Show("Client does not exist.", "Search Feedback");
                    txtSearch.Text = String.Empty;
                }
            }
            else if (comBox.SelectedIndex == 1)//ID
            {
                int value;

                if (int.TryParse(txtSearch.Text, out value))
                {
                    searchUser.Id = value;
                    searchUser.FetchUser();
                    if (searchUser.Id == 0)
                    {
                        MessageBox.Show("ID does not exist.", "Search Feedback");
                        txtSearch.Text = String.Empty;
                    }
                    else if (searchUser.Type != "client")
                    {
                        MessageBox.Show("Client does not exist.", "Search Feedback");
                        txtSearch.Text = String.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("ID number must be a number.", "Search Feedback");
                    txtSearch.Text = String.Empty;
                }

            }
            else if (comBox.SelectedIndex == 2)//username
            {
                searchUser.Username = txtSearch.Text.ToString();
                searchUser.FetchUser(true);
                if (searchUser.Id == 0)
                {
                    MessageBox.Show("Username does not exist.", "Search Feedback");
                    txtSearch.Text = String.Empty;
                }
                else if (searchUser.Type != "client")
                {
                    MessageBox.Show("Client does not exist.", "Search Feedback");
                    txtSearch.Text = String.Empty;
                }
            }
            else
            {
                MessageBox.Show("Please select a search type.", "Search Feedback");
            }

            if (searchUser.Type == "client")
            {
                txtFirstDisp.Text = searchUser.FirstName;
                txtLastDisp.Text = searchUser.LastName;
                txtEmailDisp.Text = searchUser.Email;
                if (searchUser.Id == 0) { txtIDDisp.Text = ""; }
                else { txtIDDisp.Text = searchUser.Id.ToString(); }
            }
            else
            {
                txtIDDisp.Text = "";
                txtFirstDisp.Text = "";
                txtLastDisp.Text = "";
                txtEmailDisp.Text = "";
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = String.Empty;
            txtFirstDisp.Text = String.Empty;
            txtLastDisp.Text = String.Empty;
            txtEmailDisp.Text = String.Empty;
            txtIDDisp.Text = String.Empty;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
            //AdminLandingPage adminHome = new AdminLandingPage();
            this.Hide();
            //adminHome.Show();
            clsUser.BackHome();
        }

        private void btnToClaims_Click(object sender, EventArgs e)
        {
            try
            {
                //check to see if a user has been searched and exists
                if (searchUser != null && searchUser.Id > 0)
                {
                    //create a new ViewClaims form
                    ViewClaims viewClaims = new ViewClaims(searchUser);

                    this.Hide();
                    //show the ViewClaims form
                    viewClaims.Show();
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
    }
}
