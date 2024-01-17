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
    public partial class ClientMessages : Form
    {
        public ClientMessages()
        {
            InitializeComponent();
            lstMessagesIO.Items.Clear();
            clsUser.current.FetchInbox();
            updateInbox();
            cmbIO.SelectedIndex = 0;
        }

        private void updateInbox()
        {
            lstMessagesIO.Items.Clear(); //clear previous content of list box
            try
            {
                if (clsUser.current.Inbox != null)
                {
                    //traverse the collection of PayPeriods objects for the current employee
                    foreach (clsMessage message in clsUser.current.Inbox)
                    {
                        lstMessagesIO.Items.Add(message);

                    }
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
        private void updateOutbox()
        {
            lstMessagesIO.Items.Clear(); //clear previous content of list box
            try
            {
                if (clsUser.current.Outbox != null)
                {
                    //traverse the collection of PayPeriods objects for the current employee
                    foreach (clsMessage message in clsUser.current.Outbox)
                    {
                        lstMessagesIO.Items.Add(message);

                    }
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            clsUser.BackHome();
            this.Hide();
        }

        private void ClientMessages_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dataSet1.users);

        }

        private void btnSndMsg_Click(object sender, EventArgs e)
        {
            ClientSendMessage clientsendmessagespage = new ClientSendMessage();
            this.Hide();
            clientsendmessagespage.Show();
        }

        private void cmbIO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbIO.SelectedIndex == 0)
            {
                lstMessagesIO.Items.Clear();
                clsUser.current.FetchInbox();
                updateInbox();
            }
            else
            {
                lstMessagesIO.Items.Clear();
                clsUser.current.FetchOutbox();
                updateOutbox();
            }
        }

        private void lstMessagesIO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMessagesIO.SelectedIndex != -1)
            {
                txtMessageText.Clear();
                string nl = Environment.NewLine;
                clsMessage currentMessage = (clsMessage)lstMessagesIO.SelectedItem;
                if (currentMessage.Sender==currentMessage.NotYouId&&currentMessage.ReadReciept==0)
                {
                    currentMessage.ReadReciept = 1;
                    clsDBH_Message.ReadReciept(currentMessage);
                }
                txtMessageText.Text = "From: " + currentMessage.ToFromForToString + nl + "Subject: " + currentMessage.Subject + nl + nl + currentMessage.Content + nl + nl + currentMessage.TimeSent;
            }
        }
    }
}
