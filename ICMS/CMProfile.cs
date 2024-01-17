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
    public partial class CMProfile : Form
    {
        public CMProfile()
        {
            InitializeComponent();
            clsUser.current.FetchUser();
            txbFirstName.Text = clsUser.current.FirstName;
            txbLastName.Text = clsUser.current.LastName;
            txbEmail.Text = clsUser.current.Email;

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clsUser.current.FirstName = txbFirstName.Text;
            clsUser.current.LastName = txbLastName.Text;
            clsUser.current.Email = txbEmail.Text;

            clsUser.current.UpdateDatabase();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            clsUser.BackHome();
            this.Hide();
        }

        private void CMProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
