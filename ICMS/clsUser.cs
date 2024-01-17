using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICMS
{
    public class clsUser
    {
        public static clsDBH_User DBH { get; set; } = new clsDBH_User();

        //if you need any information about the currently logged in user
        //use the FetchUser() function to make the information is stored locally.
        //Then you can use clsUser.current.(Id,Username, Email, etc.) just like a normal variable
        //
        //you can write to these variables as well, just run clsCurrentUser.UpdateDatabase()
        //to update the changes you made to the database.


        public override string ToString()
        {
            string pString = "";
            if (LastName == "" || FirstName == "")
            {
                if (Email != "")
                {
                    pString = Email;
                }
                return "";
            }
            else if (Email == "")
            {
                pString = "[" + LastName + ", " + FirstName + "]";
            }
            else
            {
                pString = string.Format(" [{0}, {1}]  {2} ",
                  LastName, FirstName, Email);
            }
            
            return pString;
        }


        public void Logout()
        {
            Id = 0;
            Username = Password = Type = FirstName = LastName = Email = Phone = Address = City = State = ZipCode = "";
        }
        public static clsUser current { get; set; } = new clsUser();
        public clsUser(string email, bool using_username=false)
        {
            if (using_username)
            {
                Username = email;
                FetchUser(true);
            }
            Email = email;
            Id = 0;
            FetchUser();
        }
        public clsUser(int id)
        {
            Id = id;
            FetchUser();
        }
        public clsUser()
        {
            Id = 0;
            Username = Password = Type = FirstName = LastName = Email = Phone = Address = City = State = ZipCode = "";
        }

        //local properties of clsUser
        public int Id { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Type { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String ZipCode { get; set; }

        public List<clsClaim> Claims { get; set; }
        public List<clsMessage> Inbox { get; set; }
        public List<clsMessage> Outbox { get; set; }
        public List<clsClaim> Assigned { get; set; }

        //methods
        //
        //fetches/updates local properties
        public void FetchUser(bool using_username=false)
        {
            if (Id==0)
            {
                if (using_username)
                {
                    clsDBH_User.CreateProfile(Username);
                    Rewrite(clsDBH_User.FetchUser(this, SearchBy.username));
                }
                else
                {
                    Rewrite(clsDBH_User.FetchUser(this, SearchBy.email));
                }

            }
            else
            {
                Rewrite(clsDBH_User.FetchUser(this, SearchBy.user_id)); 
            }
        }
        //pushes local changes to database
        public bool UpdateDatabase()
        {
            return clsDBH_User.PushUpdate(this);
        }
        //creates a an entry in user_profiles for the user if one does not exist
        public void CreateProfile()
        {
            clsDBH_User.CreateProfile(Id, FirstName, LastName);
            
        }
        public void CreateUser()
        {
            if (Type == "") { Type = "client"; }
            Id = clsDBH_User.NewUser(this);
            if (Id != 0)
            {
                CreateProfile();
                MessageBox.Show("Registration Sucessful!", "New User Feedback");
            }
            
        }

        public void FetchClaimsList()
        {
            Claims = clsDBH_User.FetchClaimsForList(Id);
        }

        public bool PushClaimsList()
        {
            return clsDBH_User.PushClaimsList(Claims);
        }

        public class MessageCompare : IComparer<clsMessage>
        {
            // Compares by Height, Length, and Width.
            public int Compare(clsMessage x, clsMessage y)
            {
                return DateTime.Compare(x.TimeSent, y.TimeSent);
            }
        }
        public void FetchInbox()
        {
            Inbox = clsDBH_User.FetchInbox(Id);
            //MessageCompare mc = new MessageCompare();
            Inbox.OrderBy(p=>p.TimeSent);
            Inbox.Reverse();
        }

        public void FetchOutbox()
        {
            Outbox = clsDBH_User.FetchOutbox(Id);
            //MessageCompare mc = new MessageCompare();
            Outbox.OrderBy(p=>p.TimeSent);
            Outbox.Reverse();
        }

        public void FetchAssigned()
        {
            Assigned = clsDBH_User.FetchAssignedClaims(Id);
        }


        public static void BackHome()
        {
            if (current.Type == "admin")
            {
                AdminLandingPage adminWelcome = new AdminLandingPage();
                adminWelcome.Show();
            }
            else if (current.Type == "claimManager")
            {
                CMLandingPage claimWelcome = new CMLandingPage();
                claimWelcome.Show();
            }
            else if (current.Type == "financeManager")
            {
                FMLanding financeWelcome = new FMLanding();
                financeWelcome.Show();
            }
            else if (current.Type == "client")
            {
                ClientLandingPage clientWelcome = new ClientLandingPage();
                clientWelcome.Show();
            }
            else
            {
                MessageBox.Show("No user type, please contact administrator.", "Login Feedback");
                //not sure if this can even happen
                ClientLandingPage clientWelcome = new ClientLandingPage();
                clientWelcome.Show();
            }
        }

        private void Rewrite(clsUser user)
        {
            Id = user.Id;
            Username = user.Username;
            Password = user.Password;
            Type = user.Type;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
            Phone = user.Phone;
            Address = user.Address;
            City = user.City;
            State = user.State;
            ZipCode = user.ZipCode;
        }

    }
}
