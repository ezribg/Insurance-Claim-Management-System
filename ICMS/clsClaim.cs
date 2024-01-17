using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICMS
{
    public class clsClaim
    {
        public static clsDBH_Claim DBH { get; set; } = new clsDBH_Claim();

        public override string ToString()
        {
            //move to database later
            string file_name = "";
            try
            {
                clsDBH_Claim.Cnn.Open();
                SqlDataReader dataReader;

                string query =
                    "select file_name from files where claim_id=@claim_id"; //select query  
                SqlCommand com = new SqlCommand(query, clsDBH_Claim.Cnn);


                com.Parameters.AddWithValue("@claim_id", Claim_id);

                dataReader = com.ExecuteReader();

                while (dataReader.Read())
                {
                    file_name += (string)dataReader.GetString(0);
                    file_name += (string)" ";
                }


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


            string pString = string.Format("Claim #: {0} Type: {1} Description: {2} {3} ",
                Claim_id, Type, Description, file_name != "" ? "File Name(s): " +file_name : "") ;            
            return pString;
        }

        public clsClaim(int claim_id, int user_id,string current_status, string type, int assigned_id, DateTime date_filed, string description, decimal amount=-1)
        {
            Claim_id = claim_id;
            User_id = user_id;
            Type = type;
            CurrentStatus = current_status;
            Assigned_id = assigned_id;
            Date_filed = date_filed;
            Amount = amount;
            Description = description;



            //this will overwrite ^ data based on claim_id
            Fetch();
        }
        public clsClaim(int user_id=0) 
        {
            Claim_id = 0;
            User_id = user_id;
            Type = "";
            CurrentStatus = "New";
            Assigned_id =0;
            Date_filed = DateTime.MaxValue;
            Amount = -1;
            Notes = "";
            Description = "";
        }



        //local properties of clsClaim
        public int Claim_id { get; set; }
        public int User_id { get; set; }
        public String Type { get; set; }
        public String CurrentStatus { get; set; }
        public int Assigned_id { get; set; }
        public DateTime Date_filed { get; set; }
        public decimal Amount { get; set; }
        public String Notes { get; set; }
        public String Description { get; set; }
        public DateTime Date_Occured { get; set; }
        public DateTime Date_Updated { get; set; }
        //create variables to store photos and files somehow

        public List<clsClaimUpdate> claimUpdates { get; set; }
        public List<clsFile> Files { get; set; }

        public void FetchFilesInfo()
        {
            Files = clsDBH_Claim.FetchFilesInformation(Claim_id);
        }
        public void FetchClaimUpdates()
        {
            claimUpdates = clsDBH_Claim.FetchClaimUpdateList(Claim_id);
        }

        public void PushClaimUpdateList()
        {
            clsDBH_Claim.PushClaimUpdateList(claimUpdates);
        }

        public void Rewrite(clsClaim claim)
        {
            this.Claim_id = claim.Claim_id;
            this.User_id = claim.User_id;
            this.Type = claim.Type;
            this.CurrentStatus = claim.CurrentStatus;
            this.Assigned_id = claim.Assigned_id;
            this.Date_filed = claim.Date_filed;
            this.Amount = claim.Amount;
            this.Notes = claim.Notes;
            this.Description = claim.Description;
        }

        public void Fetch()
        {
             Rewrite(clsDBH_Claim.FetchClaim(Claim_id));
        }
        //Updates claim in the Database
        public bool Update()
        {   return clsDBH_Claim.Update(this);    }
        //Inserts claim into Database
        public int Insert()
        {   return clsDBH_Claim.Insert(this);    }
        
    }
}
