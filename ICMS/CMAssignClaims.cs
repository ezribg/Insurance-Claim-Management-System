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
    public partial class CMAssignClaims : Form
    {
        public CMAssignClaims()
        {
            InitializeComponent();
            List<clsUser> users = clsDBH_Message.GetMessagableUsers();
            foreach (clsUser user in users)
            {
                user.FetchClaimsList();
                if (user.Type == "financeManager")//add filtering
                {
                    cmbFMs.Items.Add(user);
                }
                else if(user.Type == "client" && user.Claims!=null)
                {
                    foreach (clsClaim claim in user.Claims)
                    {
                        if(claim.Assigned_id == 0)
                        {
                            lstClaims.Items.Add(claim);
                        }
                    }
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            clsUser.BackHome();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lstClaims.Items.Clear(); //clear previous content of list box
            List<clsUser> users = clsDBH_Message.GetMessagableUsers();
            foreach (clsUser user in users)
            {
                user.FetchClaimsList();
                if (user.Type == "client" && user.Claims != null)
                {
                    foreach (clsClaim claim in user.Claims)
                    {
                        if (claim.Assigned_id == 0)
                        {
                            lstClaims.Items.Add(claim);
                        }
                    }
                }
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (lstClaims.SelectedIndex >= 0 && cmbFMs.SelectedIndex >= 0)
            {
                clsClaim currentClaim = (clsClaim)lstClaims.SelectedItem;
                clsUser currentUser = (clsUser)cmbFMs.SelectedItem;
                currentClaim.Assigned_id = currentUser.Id;
                currentClaim.Update();

                clsMessage message = new clsMessage(clsUser.current.Id);
                message.Sender = clsUser.current.Id;
                message.Recipient = currentUser.Id;
                message.Subject = "New Claim";
                message.Content = "You've been assigned claim " + currentClaim.Claim_id + 
                    ". Please finalize the claim.";
                message.TimeSent = DateTime.Now;

                message.Insert();
                MessageBox.Show("Succesfully assigned claim.");
            }
            else
            {
                MessageBox.Show("Please select a claim and a finance manager.");
            }
        }
    }
}
