using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICMS
{
    public partial class ViewClaims : Form
    {
        private clsUser client;
        public ViewClaims(clsUser client)
        {
            InitializeComponent();

            this.client = client;
            lstClaims.Items.Clear();
            client.FetchClaimsList();
            updateListBox();
        }

        private void updateListBox()
        {
            lstClaims.Items.Clear(); //clear previous content of list box
            try
            {
                if (client.Claims != null)
                {
                    //traverse the collection of PayPeriods objects for the current employee
                    foreach (clsClaim claim in client.Claims)
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
                    MessageBox.Show("Please select a claim." , "Feedback");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
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
                    message.Subject = "Claim Processed";
                    message.Content = "Claim " + currentClaim.Claim_id + " has been finalized.";
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

        private static readonly Regex sWhitespace = new Regex(@"\s+");
        public static string ReplaceWhitespace(string input, string replacement)
        {
            return sWhitespace.Replace(input, replacement);
        }
        private void btnDownloadClaims_Click_1(object sender, EventArgs e)
        {

            clsClaim claim = (clsClaim)lstClaims.SelectedItem;

            


            if (lstClaims.SelectedIndex >= 0)
            {
                string potentialSavename = "Claim_User_" + (int)claim.User_id + "_" + claim.Type;
                saveFileDialog1.FileName = potentialSavename;
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter =
                            "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.CreatePrompt = false;
                saveFileDialog1.OverwritePrompt = true;
                DialogResult result = saveFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string assigned = claim.Assigned_id == -1 ? "Unassinged" : claim.Assigned_id.ToString();
                    var path = Path.GetFullPath(saveFileDialog1.FileName);

                    string finalText = "";
                    clsUser claimUser = new clsUser();
                    claimUser.Id = claim.User_id;
                    claimUser = clsDBH_User.FetchUser(claimUser);

                    finalText = string.Format(
                        "Claim ID: {0,6} Type: {1,6} Date: {2,8:d}\n\n" +
                    "Client ID: {3,6} First Name: {4,10} Last Name: {5,10}\n\n" +
                    "Email: {6,15} Phone Number: {7,15}\n\n" +
                    "Assigned Manager: {8,5}\n\n" +
                    "Description: {9}", claim.Claim_id, claim.Type, claim.Date_Occured, claim.User_id, claimUser.FirstName, claimUser.LastName,
                        claimUser.Email, claimUser.Phone, assigned, claim.Description);
                   

                    byte[] data = Encoding.ASCII.GetBytes(finalText);

                    File.WriteAllBytes(path, data);
                }


                //if (cbbFiles.Items.Count > 0)
                //{
                //    fbdDownloadLocation.ShowDialog();
                //    string directory = fbdDownloadLocation.SelectedPath;
                //    foreach (clsFile file in cbbFiles.Items)
                //    {
                //        file.Fetch();
                //        string path = directory + @"\" + file.File_name;
                //        File.WriteAllBytes(path, file.Data);
                //    }
                //}
                //else { MessageBox.Show("No files to download.", "Feedback"); }

            }
            else
            {
                MessageBox.Show("Please select a claim.", "Feedback");
            }
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

        private void btnDownloadALL_Click(object sender, EventArgs e)
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
    }
}
