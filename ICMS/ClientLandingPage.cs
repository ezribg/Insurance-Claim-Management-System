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
    public partial class ClientLandingPage : Form
    {
        public ClientLandingPage()
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
            UserProfile clientprofilepage = new UserProfile();
            this.Hide();
            clientprofilepage.Show();
        }
        private void btnClaimPage_Click(object sender, EventArgs e)
        {
            ClientMakeClaim clientClaimPage = new ClientMakeClaim();
            this.Hide();
            clientClaimPage.Show();
        }

        private void bntViewClaims_Click(object sender, EventArgs e)
        {
            ClientViewClaims clientViewClaims = new ClientViewClaims();
            this.Hide();
            clientViewClaims.Show();
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            ClientMessages clientmessagespage = new ClientMessages();
            this.Hide();
            clientmessagespage.Show();
        }
    }
}
