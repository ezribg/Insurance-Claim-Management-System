using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICMS
{
    public partial class FMassignedClaims : Form
    {
        public FMassignedClaims()
        {
            InitializeComponent();

            lstClaims.Items.Clear();
            clsUser.current.FetchAssigned();
            updateListBox();
        }

        private void updateListBox()
        {
            lstClaims.Items.Clear(); //clear previous content of list box
            try
            {
                if (clsUser.current.Assigned != null)
                {
                    //traverse the collection of PayPeriods objects for the current employee
                    foreach (clsClaim claim in clsUser.current.Assigned)
                    {
                        lstClaims.Items.Add(claim);

                    }
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }


        }

        private void lstClaims_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClaims.SelectedIndex != -1)
            {
                clsClaim currentClaim = (clsClaim)lstClaims.SelectedItem;
                rtxtClaim.Text = "Type: " + currentClaim.Type.ToString() + "\nDescription: " + currentClaim.Description.ToString() + "\nNotes: " + currentClaim.Notes.ToString() + "\nCurrentAmount: " + currentClaim.Amount.ToString() + "\nStatus: " + currentClaim.CurrentStatus.ToString();

                cbbFiles.Items.Clear();
                clsClaim claim = (clsClaim)lstClaims.SelectedItem;
                claim.FetchFilesInfo();
                foreach (clsFile file in claim.Files)
                {
                    cbbFiles.Items.Add(file);
                }
            }
        }

        private void btnDownloadClaims_Click(object sender, EventArgs e)
        {
            if (lstClaims.SelectedIndex >= 0)
            {
                if (cbbFiles.Items.Count > 0)
                {
                    fbdDownloadLocation.ShowDialog();
                    string directory = fbdDownloadLocation.SelectedPath;
                    foreach (clsFile file in cbbFiles.Items)
                    {
                        file.Fetch();
                        string path = directory + @"\" + file.File_name;
                        File.WriteAllBytes(path, file.Data);
                    }
                }
                else { MessageBox.Show("No files to download.", "Feedback"); }

            }
            else
            {
                MessageBox.Show("Please select a claim.", "Feedback");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //AdminLandingPage adminHome = new AdminLandingPage();
            this.Hide();
            //adminHome.Show();
            clsUser.BackHome();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clsClaim currentClaim = (clsClaim)lstClaims.SelectedItem;
            try
            {
                int x = lstClaims.SelectedIndex;

                if (lstClaims.SelectedIndex >= 0)
                {
                    currentClaim.Amount = numAmount.Value;
                    currentClaim.CurrentStatus = "In Progress";
                    updateListBox();
                    lstClaims.SelectedIndex = x;
                    currentClaim.Update();
                }
                else
                {
                    MessageBox.Show("Please select a claim.", "Feedback");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning");
            }
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            clsClaim currentClaim = (clsClaim)lstClaims.SelectedItem;
            try
            {
                int x = lstClaims.SelectedIndex;

                if (lstClaims.SelectedIndex >= 0)
                {
                    currentClaim.Amount = numAmount.Value;
                    currentClaim.CurrentStatus = "Finalized";
                    updateListBox();
                    lstClaims.SelectedIndex = x;
                    currentClaim.Assigned_id = -1;
                    currentClaim.Update();

                    clsMessage message = new clsMessage(clsUser.current.Id);
                    message.Sender = clsUser.current.Id;
                    message.Subject = "Claim #" + currentClaim.Claim_id +" Processed";
                    message.Content = "Claim #" + currentClaim.Claim_id + " has been finalized.";
                    message.Recipient = currentClaim.User_id;
                    clsDBH_Message.Insert(message);

                }
                else
                {
                    MessageBox.Show("Please select a claim.", "Feedback");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtClaim.Text = String.Empty;
            numAmount.Value = 0;
            lstClaims.SelectedIndex = -1;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (lstClaims.SelectedIndex >= 0 && cbbFiles.SelectedIndex >= 0)
            {
                clsFile file = (clsFile)cbbFiles.SelectedItem;

                file.Fetch();

                string path;
                fbdDownloadLocation.Description = "Select Folder For Download";
                fbdDownloadLocation.ShowDialog();
                path = fbdDownloadLocation.SelectedPath + @"\" + file.File_name;

                File.WriteAllBytes(path, file.Data);
            }
            else
            {
                MessageBox.Show("Please select a claim and file.", "Feedback");
            }
        }
    }
}
