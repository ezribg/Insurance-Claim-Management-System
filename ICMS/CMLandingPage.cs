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
    public partial class CMLandingPage : Form
    {
        public CMLandingPage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginForm backToLogin = new LoginForm();
            this.Hide();
            backToLogin.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            UserProfile profilepage = new UserProfile();
            this.Hide();
            profilepage.Show();
        }

        private void btnCProfiles_Click(object sender, EventArgs e)
        {
            SearchUFCMFM searchUser = new SearchUFCMFM();
            this.Hide();
            searchUser.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnEmploy_Click(object sender, EventArgs e)
        {
            EmployeeDirectory searchEmployee = new EmployeeDirectory();
            this.Hide();
            searchEmployee.Show();
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            ClientMessages managermessagespage = new ClientMessages();
            this.Hide();
            managermessagespage.Show();
        }

        private void btnAssignClaims_Click(object sender, EventArgs e)
        {
            CMAssignClaims assignpage = new CMAssignClaims();
            this.Hide();
            assignpage.Show();
        }
    }
}
