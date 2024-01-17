using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICMS
{
    public partial class EmployeeDirectory : Form
    {
        public EmployeeDirectory()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            clsUser.BackHome();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comBox.ResetText();
            txtSearch.Text = String.Empty;
            txtFirstDisp.Text = String.Empty;
            txtLastDisp.Text = String.Empty;
            txtEmailDisp.Text = String.Empty;
            txtIDDisp.Text = String.Empty;
            txtTitle.Text = String.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clsUser searchUser = new clsUser();
            if (comBox.SelectedIndex == 0)//email
            {
                searchUser.Email = txtSearch.Text.ToString();
                searchUser.FetchUser();
                if (searchUser.Id == 0)
                {
                    MessageBox.Show("Employee does not exist.", "Search Feedback");
                    txtSearch.Text = String.Empty;
                }
                else if (searchUser.Type == "client")
                {
                    MessageBox.Show("Employee does not exist.", "Search Feedback");
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
                        MessageBox.Show("Employee does not exist.", "Search Feedback");
                        txtSearch.Text = String.Empty;
                    }
                    else if (searchUser.Type == "client")
                    {
                        MessageBox.Show("Employee does not exist.", "Search Feedback");
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
                    MessageBox.Show("Employee does not exist.", "Search Feedback");
                    txtSearch.Text = String.Empty;
                }
                else if (searchUser.Type == "client")
                {
                    MessageBox.Show("Employee does not exist.", "Search Feedback");
                    txtSearch.Text = String.Empty;


                }
            }
            else
            {
                MessageBox.Show("Please select a search type.", "Search Feedback");
            }

            if(searchUser.Type != "client" && searchUser.Type != "")
            {
                txtFirstDisp.Text = searchUser.FirstName;
                txtLastDisp.Text = searchUser.LastName;
                txtEmailDisp.Text = searchUser.Email;
                txtTitle.Text = searchUser.Type;
                if (searchUser.Id == 0) { txtIDDisp.Text = ""; }
                else { txtIDDisp.Text = searchUser.Id.ToString(); }
            }
            else 
            { 
                txtIDDisp.Text = "";
                txtFirstDisp.Text = "";
                txtLastDisp.Text = "";
                txtEmailDisp.Text = "";
                txtTitle.Text = "";
            }
        }
    }
}
