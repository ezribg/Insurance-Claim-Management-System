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
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Drawing.Imaging;




namespace ICMS
{
    public partial class ClientMakeClaim : Form
    {

        public ClientMakeClaim()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text != string.Empty || txtPhotoName.Text != string.Empty)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result;
                result = MessageBox.Show("Submit Without Uploading Files?", "Submit Claim", buttons);
                if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }
            }
            clsClaim claim = new clsClaim(clsUser.current.Id);
            claim.User_id = clsUser.current.Id;
            claim.Type = cmbType.Text;
            claim.Date_filed = dtpClaim.Value;
            claim.Description = rtxtDescripton.Text.ToString();
            clsDBH_Claim.Insert(claim);
            MessageBox.Show("Claim Submitted!");
            cmbType.ResetText();
            rtxtDescripton.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text != string.Empty || txtPhotoName.Text != string.Empty)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result;
                result = MessageBox.Show("Exit Without Uploading Files?", "Exit Claim", buttons);
                if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }
            }

            try
            {
                //delete uploaded files
                clsDBH_Claim.Cnn.Open();

                string query = "DELETE FROM files WHERE claim_id=0 AND user_id=@user_id"; //insert query  
                SqlCommand com = new SqlCommand(query, clsDBH_Claim.Cnn);
                com.Parameters.Add("@user_id", SqlDbType.Int).Value = clsUser.current.Id;
                com.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                throw;
            }
            finally
            {
                clsDBH_Claim.Cnn.Close();
            }
            





            clsUser.BackHome();
            this.Hide();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            ofdFileSelect.Title = "Select File For Upload";
            ofdFileSelect.Filter = "pdf (*.pdf)|*.pdf";
            ofdFileSelect.ShowDialog();
            var filePath = ofdFileSelect.FileName;
            string fileName = Path.GetFileName(filePath);
            txtFileName.Text = fileName;

            

        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text != string.Empty)
            {
                var filePath = ofdFileSelect.FileName;
                string fileName = Path.GetFileName(filePath);
                Stream fileStream = ofdFileSelect.OpenFile();
                string ext = Path.GetExtension(fileName);

                string type = String.Empty;
                if (fileStream.Length == Stream.Null.Length)
                {
                    MessageBox.Show("Please Select File"); //if file uploader has no file selected  
                }
                else
                if (fileStream.Length > Stream.Null.Length)
                {
                    try
                    {
                        switch (ext) // this switch code validate the files which allow to upload only PDF file   
                        {
                            case ".pdf":
                                type = "application/pdf";
                                break;
                        }
                        if (type != String.Empty)
                        {
                            clsDBH_Claim.Cnn.Open();

                            BinaryReader br = new BinaryReader(fileStream); //reads the binary files  
                            Byte[] bytes = br.ReadBytes((Int32)fileStream.Length); //counting the file length into bytes  

                            string query = "insert into [dbo].[files] (user_id, claim_id, file_name, file_type, file_data)" +
                                "values (@user_id, @claim_id, @Name, @type, @Data)"; //insert query  
                            SqlCommand com = new SqlCommand(query, clsDBH_Claim.Cnn);
                            com.Parameters.Add("@user_id", SqlDbType.Int).Value = clsUser.current.Id;
                            com.Parameters.Add("@claim_id", SqlDbType.Int).Value = 0;
                            com.Parameters.Add("@Name", SqlDbType.VarChar).Value = fileName;
                            com.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
                            com.Parameters.Add("@Data", SqlDbType.Binary).Value = bytes;
                            com.ExecuteNonQuery();
                            MessageBox.Show("File Uploaded Successfully");
                            txtFileName.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Select Only PDF Files");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message.ToString());
                    }
                    finally
                    {
                        clsDBH_Claim.Cnn.Close();
                    }
                }

            }
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            fidPhotoSelect.Title = "Select Image For Upload";
            fidPhotoSelect.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";
            fidPhotoSelect.ShowDialog();
            var filePath = fidPhotoSelect.FileName;
            string fileName = Path.GetFileName(filePath);
            var fileStream = fidPhotoSelect.OpenFile();
            txtPhotoName.Text = (string)fileName;

            //using (StreamReader reader = new StreamReader(fileStream))
            //{
            //    fileContent = reader.ReadToEnd();
            //}
            if (fileStream.Length > Stream.Null.Length)
            {
                lblPhotoName.Visible = true;
                lblPhotoName.Text = (string)fileName;
                pictureBox1.Image = null;
                Bitmap myImage = new Bitmap(fileStream);
                pictureBox1.Image = (Image)myImage;
            }

            //MessageBox.Show(fileContent, "File Content at path: " + filename, MessageBoxButtons.OK);

        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            if (txtPhotoName.Text != string.Empty)
            {
                var fileContent = string.Empty;

                var filePath = fidPhotoSelect.FileName;
                string fileName = Path.GetFileName(filePath);
                Stream fileStream = fidPhotoSelect.OpenFile();

                string ext = Path.GetExtension(fileName);

                string type = String.Empty;
                if (fileStream.Length == Stream.Null.Length)
                {
                    MessageBox.Show("Please Select File"); //if file uploader has no file selected  
                }
                else if (fileStream.Length > Stream.Null.Length)
                {
                    try
                    {
                        switch (ext) // this switch code validate the files which allow to upload only PDF file   
                        { // "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";
                            case ".jpg":
                                type = "application/jpg";
                                break;
                            case ".bmp":
                                type = "application/bmp";
                                break;
                            case ".png":
                                type = "application/png";
                                break;
                        }
                        if (type != String.Empty)
                        {
                            clsDBH_Claim.Cnn.Open();

                            BinaryReader br = new BinaryReader(fileStream); //reads the binary files  
                            Byte[] bytes = br.ReadBytes((Int32)fileStream.Length); //counting the file length into bytes  

                            string query = "insert into [dbo].[files] (user_id, claim_id,  file_name, file_type, file_data)" +
                                "values (@user_id, @claim_id, @Name, @type, @Data)"; //insert query  
                            SqlCommand com = new SqlCommand(query, clsDBH_Claim.Cnn);
                            com.Parameters.Add("@user_id", SqlDbType.Int).Value = clsUser.current.Id;
                            com.Parameters.Add("@claim_id", SqlDbType.Int).Value = 0;
                            com.Parameters.Add("@Name", SqlDbType.VarChar).Value = fileName;
                            com.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
                            com.Parameters.Add("@Data", SqlDbType.Binary).Value = bytes;
                            com.ExecuteNonQuery();
                            MessageBox.Show("Photo Uploaded Successfully");
                            txtPhotoName.Clear();
                            lblPhotoName.Visible = false;
                            lblPhotoName.Text = "";
                            pictureBox1.Image = null;
                        }
                        else
                        {
                            MessageBox.Show("Select Only .jpg .bmp or .png Files ");// if file is other than speified extension   
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message.ToString());
                    }
                    finally
                    {
                        clsDBH_Claim.Cnn.Close();
                    }
                }

            }
        }
    }
}
