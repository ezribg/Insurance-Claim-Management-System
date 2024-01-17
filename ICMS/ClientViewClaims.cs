using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ICMS
{
    public partial class ClientViewClaims : Form
    {

        public ClientViewClaims()
        {
            InitializeComponent();
            lstClaims.Items.Clear();
            clsUser.current.FetchClaimsList();
            updateListBox();
        }

        private void updateListBox()
        {
            
            lstClaims.Items.Clear(); //clear previous content of list box
            try
            {
                if (clsUser.current.Claims != null)
                {
                    //traverse the collection of PayPeriods objects for the current employee
                    foreach (clsClaim claim in clsUser.current.Claims)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            clsUser.BackHome();
            this.Hide();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            updateListBox();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

            if (lstClaims.SelectedIndex >= 0 && ltbFiles.SelectedIndex >= 0)
            {
                clsFile file = (clsFile)ltbFiles.SelectedItem;

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

        private void lstClaims_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltbFiles.Items.Clear();
            clsClaim claim = (clsClaim)lstClaims.SelectedItem;
            claim.FetchFilesInfo();
            foreach (clsFile file in claim.Files)
            {
                ltbFiles.Items.Add(file);
            }
            
        }

        private void btnDownloadALL_Click(object sender, EventArgs e)
        {
            
            if (lstClaims.SelectedIndex >= 0)
            {
                if (ltbFiles.Items.Count>0)
                {
                    fbdDownloadLocation.ShowDialog();
                    string directory = fbdDownloadLocation.SelectedPath;
                    foreach (clsFile file in ltbFiles.Items)
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
