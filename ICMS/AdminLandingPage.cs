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
    public partial class AdminLandingPage : Form
    {
        public AdminLandingPage()
        {
            InitializeComponent();
        }

        private void AdminLandingPage_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm backToLogin = new LoginForm();
            this.Hide();
            backToLogin.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            AdminPrivileges adminprivilegepage = new AdminPrivileges();
            this.Hide();
            adminprivilegepage.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchUserForm searchUser = new SearchUserForm();
            this.Hide();
            searchUser.Show();
        }

        private void btnEmploy_Click(object sender, EventArgs e)
        {
            EmployeeDirectory searchEmployee = new EmployeeDirectory();
            this.Hide();
            searchEmployee.Show();
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            ClientMessages adminmessagespage = new ClientMessages();
            this.Hide();
            adminmessagespage.Show();
        }
    }
}
