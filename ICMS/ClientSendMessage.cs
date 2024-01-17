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
    public partial class ClientSendMessage : Form
    {

        public ClientSendMessage()
        {
            InitializeComponent();
            List<clsUser> users = clsDBH_Message.GetMessagableUsers();
            foreach (clsUser user in users)
            {
                if ((user.Type!="client"||clsUser.current.Type!="client"))//add filtering
                {
                    if (user.ToString() !="")
                    {
                        cmbName.Items.Add(user);

                    }

                }
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void ClientSendMessage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dataSet1.users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientMessages clientmessagespage = new ClientMessages();
            this.Hide();
            clientmessagespage.Show();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            clsMessage message = new clsMessage(clsUser.current.Id);
            message.Sender = clsUser.current.Id;
            message.Subject = txtSubject.Text;
            message.Content = txtBxMessage.Text;

            if (cmbName.SelectedIndex>-1)
            {
                clsUser fetchRecipient = (clsUser)cmbName.SelectedItem;

                //fetchRecipient.Username = cmbName.SelectedItem;
                //fetchRecipient.FetchUser(true);
                if (fetchRecipient.Id == 0)
                {
                    MessageBox.Show("Recipient is invalid.", "Email Feedback");
                    cmbName.ResetText();
                }
                else
                {
                    message.Recipient = fetchRecipient.Id;
                    clsDBH_Message.Insert(message);
                    MessageBox.Show("Message Sent");
                    txtSubject.Clear();
                    txtBxMessage.Clear();
                    cmbName.ResetText();
                }
            }
            
           
        }

       
    }
}
