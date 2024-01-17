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
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
            clsUser.current.FetchUser();
            txbFirstName.Text= clsUser.current.FirstName;
            txbLastName.Text = clsUser.current.LastName;
            txbEmail.Text = clsUser.current.Email;
            txbPhone.Text = clsUser.current.Phone;
            txbAddress.Text = clsUser.current.Address;
            txbCity.Text = clsUser.current.City;
            txbState.Text = clsUser.current.State;
            txbZip.Text = clsUser.current.ZipCode;


        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clsUser.current.FirstName = txbFirstName.Text;
            clsUser.current.LastName = txbLastName.Text;
            clsUser.current.Email = txbEmail.Text;
            clsUser.current.Phone = txbPhone.Text;
            clsUser.current.Address = txbAddress.Text;
            clsUser.current.City = txbCity.Text;
            clsUser.current.State = txbState.Text;
            clsUser.current.ZipCode = txbZip.Text;

            if (clsUser.current.UpdateDatabase())
            { MessageBox.Show("Update Successful."); }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            clsUser.BackHome();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }
    }
}
