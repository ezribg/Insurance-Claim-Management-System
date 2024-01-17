using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICMS
{
    public class clsMessage
    {
        public static clsDBH_Message DBH { get; set; } = new clsDBH_Message();

        
        
        public override string ToString()
        {
            //move to database later
            string sender_f = "",sender_l= "",sender_email = "";
            try
            {
                clsDBH_User.Cnn.Open();
                SqlDataReader dataReader;

                string query =
                    "select first_name, last_name, email from user_profile where user_id=@user_id"; //select query  
                SqlCommand com = new SqlCommand(query, clsDBH_User.Cnn);


                com.Parameters.AddWithValue("@user_id", NotYouId);

                dataReader = com.ExecuteReader();

                if (dataReader.Read())
                {
                    if (!dataReader.IsDBNull(0)) { sender_f = dataReader.GetString(0); }
                    if (!dataReader.IsDBNull(1)) { sender_l = dataReader.GetString(1); }
                    if (!dataReader.IsDBNull(2)) { sender_email = dataReader.GetString(2); }                    
                }


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                throw;
            }
            finally
            {
                clsDBH_User.Cnn.Close();
            }

            string abreviatedSubject = Subject;

            if (abreviatedSubject.Length>=30)
            {
                abreviatedSubject = Subject.Substring(0, 27) + "...";
            }
            string readIcon = (ReadReciept == 0&&NotYouId==Sender) ? "[New]" : "     ";
            string pString = string.Format(" {0} {2}, {1} {3,-30} {4:d}",
                 readIcon, sender_f, sender_l, abreviatedSubject, TimeSent);
            ToFromForToString = string.Format(" [{0}, {1}]  {2} ",
                  sender_l, sender_f, sender_email);
            return pString;
        }
        


        public clsMessage(int sender_id=0) 
        {
            Message_id = 0;
            Sender = sender_id;
            Recipient = 0;
            Subject = "";
            Content = "";
            ReadReciept = 0;
            TimeSent = DateTime.Now;
        }

        public clsMessage(int message_id, int sender, int recipient, string subject, string content, int read_reciept, DateTime time_sent)
        {
            Message_id = message_id;
            Sender = sender;
            Recipient = recipient;
            Subject = subject;
            Content = content;
            ReadReciept = read_reciept;
            TimeSent = time_sent;



            //this will overwrite ^ data based on ??
            Fetch();
        }



        //local properties of clsMessages
        public int Message_id { get; set; }
        public int Sender { get; set; }
        public int Recipient { get; set; }
        public String Subject { get; set; }
        public String Content { get; set; }
        public int ReadReciept { get; set; }//read = 1 unread = 0
        public DateTime TimeSent { get; set; }
        public String ToFromForToString { get; set; }
        public int NotYouId { get; set; }



        public void Rewrite(clsMessage message)
        {
            this.Message_id = message.Message_id;
            this.Sender = message.Sender;
            this.Recipient = message.Recipient;
            this.Subject = message.Subject;
            this.Content = message.Content;
            this.ReadReciept = message.ReadReciept;
            this.TimeSent = message.TimeSent;
        }

        public void Fetch(bool using_sender = false)
        {
            if (using_sender)
            {
                Rewrite(clsDBH_Message.FetchMessage(this, SearchBy.sender));
            }
            else
            {
                Rewrite(clsDBH_Message.FetchMessage(this, SearchBy.recipient));
            }
        }
        //Updates claim in the Database
        public bool Update()
        { return clsDBH_Message.Update(this); }
        //Inserts claim into Database
        public int Insert()
        { return clsDBH_Message.Insert(this); }
    }
}
