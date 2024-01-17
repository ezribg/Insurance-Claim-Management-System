using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ICMS
{
	public enum SearchBy { user_id, username, email, sender, recipient};
	public class clsDBH_User : clsInheritanceDatabase
	{
		public static clsUser Login(clsUser user)
		{

			Cnn = new SqlConnection(strConnection);

			try
			{
				Cnn.Open();
				SqlCommand command = new SqlCommand();
				command.Connection = Cnn;
				SqlDataReader dataReader;
				command.CommandText = "SELECT user_id, type FROM users WHERE username=@username AND passwrd=@password";
				command.Parameters.AddWithValue("@username", user.Username);
				command.Parameters.AddWithValue("@password", user.Password);


				dataReader = command.ExecuteReader();
				dataReader.Read();
				if (dataReader.HasRows)
				{
					if (!dataReader.IsDBNull(0)) { user.Id = dataReader.GetInt32(0); }
					else { user.Id = 0; }
					if (!dataReader.IsDBNull(1)) { user.Type = dataReader.GetString(1); }
					else { user.Type = ""; }
				}

			}
			catch (Exception err)
			{
				//it handles any other errors
				MessageBox.Show(err.Message, "Warning!");
			}
			finally
			{
				Cnn.Close();
			}

			return user;
		}


		//profile must exist to search by email!!!!
		public static clsUser FetchUser(clsUser user, SearchBy searchBy = SearchBy.user_id)
		{

			SqlConnection Cnn;
			Cnn = new SqlConnection(strConnection);

			try
			{
				Cnn.Open();
				SqlCommand command = new SqlCommand();

				command.Connection = Cnn;
				SqlDataReader dataReader;
				if (searchBy == SearchBy.user_id)
				{
					command.CommandText = "SELECT username, passwrd, [type], users.user_id, " +
						"first_name, last_name, email, phone_num, address, city, state, zip_code " +
						"FROM users " +
						"INNER JOIN user_profile " +
						"ON users.user_id = user_profile.user_id " +
						"WHERE users.user_id = @user_id;";
					command.Parameters.AddWithValue("@user_id", user.Id);
				}
				else if (searchBy == SearchBy.username)
				{
					command.CommandText =
						"SELECT username, passwrd, [type], users.user_id," +
						"first_name, last_name, email, phone_num, address," +
						"city, state, zip_code  " +
						"FROM users " +
						"INNER JOIN user_profile " +
						"ON users.user_id = user_profile.user_id " +
						"WHERE users.username = @username;";
					command.Parameters.AddWithValue("@username", user.Username);

				}
				else
				{
					command.CommandText =
						  "SELECT username, passwrd, [type], users.user_id," +
						  "first_name, last_name, email, phone_num, address," +
						  "city, state, zip_code  " +
						  "FROM users " +
						  "INNER JOIN user_profile " +
						  "ON users.user_id = user_profile.user_id " +
						  "WHERE user_profile.email = @email;";
					command.Parameters.AddWithValue("@email", user.Email);

				}
				dataReader = command.ExecuteReader();

				if (dataReader.Read())
				{
					if (!dataReader.IsDBNull(0)) { user.Username = dataReader.GetString(0); }
					if (!dataReader.IsDBNull(1)) { user.Password = dataReader.GetString(1); }
					if (!dataReader.IsDBNull(2)) { user.Type = dataReader.GetString(2); }
					if (!dataReader.IsDBNull(3)) { user.Id = dataReader.GetInt32(3); }
					else { user.Id = 0; }
					if (!dataReader.IsDBNull(4)) { user.FirstName = dataReader.GetString(4); }
					if (!dataReader.IsDBNull(5)) { user.LastName = dataReader.GetString(5); }
					if (!dataReader.IsDBNull(6)) { user.Email = dataReader.GetString(6); }
					if (!dataReader.IsDBNull(7)) { user.Phone = dataReader.GetString(7); }
					if (!dataReader.IsDBNull(8)) { user.Address = dataReader.GetString(8); }
					if (!dataReader.IsDBNull(9)) { user.City = dataReader.GetString(9); }
					if (!dataReader.IsDBNull(10)) { user.State = dataReader.GetString(10); }
					if (!dataReader.IsDBNull(11)) { user.ZipCode = dataReader.GetString(11); }
				}
				else { user.Id = 0; }




			}
			catch (Exception err)
			{
				//it handles any other errors
				MessageBox.Show(err.Message, "User does not exist");
			}
			finally
			{
				Cnn.Close(); //Close connection regardless of any errors or not
			}

			return user;
		}

		public static List<clsClaim> FetchClaimsForList(int Id)
		{
			//declare a list of clsClaim objects
			List<clsClaim> Claims;

			Claims = new List<clsClaim>(); //instantiate the clsClaim list

			try //error handling
			{

				clsClaim tempClaim;


				Cnn = new SqlConnection(strConnection);
				Cnn.Open();

				SqlCommand sqlCommand = new SqlCommand("SELECT * FROM claims WHERE user_id=@user_id", Cnn);
				sqlCommand.Parameters.AddWithValue("@user_id", Id);

				SqlDataReader reader = sqlCommand.ExecuteReader();

				while (reader.Read())
				{
					tempClaim = new clsClaim();

					tempClaim.Claim_id = !reader.IsDBNull(0) ? (int)reader["claim_id"] : 0;
					tempClaim.User_id = !reader.IsDBNull(1) ? (int)reader["user_id"] : 0;
					tempClaim.Type = !reader.IsDBNull(2) ? (string)reader["type_claim"] : "";
					tempClaim.CurrentStatus = !reader.IsDBNull(3) ? (string)reader["current_status"] : "";
					tempClaim.Assigned_id = !reader.IsDBNull(4) ? (int)reader["assigned_manager_id"] : 0;
					tempClaim.Date_filed = !reader.IsDBNull(5) ? (DateTime)reader["date_filed"] : DateTime.MaxValue;
					tempClaim.Amount = !reader.IsDBNull(6) ? (decimal)reader["amount"] : -1;
					tempClaim.Notes = !reader.IsDBNull(7) ? (string)reader["notes"] : "";
					tempClaim.Description = !reader.IsDBNull(8) ? (string)reader["description_name_taken"] : "";

					Claims.Add(tempClaim);
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message, "Something went wrong with loading data from the database!");

			}
			finally
			{
				Cnn.Close();

			}

			return Claims;
		}

		public static bool PushClaimsList(List<clsClaim> Claims)
		{
			bool success = false;
			try
			{

				Cnn = new SqlConnection(strConnection);
				Cnn.Open();

				SqlCommand cmd =
					new SqlCommand(
						"INSERT INTO dbo.claims (user_id, type_claim, current_status,assigned_manager_id," +
							"date_filed, amount, notes, description_name_taken)" +
						"VALUES(@user_id, @type_claim, @current_status, @assigned_manager_id, @date_filed, @amount" +
							"@notes, @description");

				cmd.Connection = Cnn;

				SqlCommand command =
					new SqlCommand(
						"UPDATE claims SET user_id=@user_idX, type_claim=@type_claimX, current_status=@current_statusX, " +
						"assigned_manager_id=@assigned_manager_idX, date_filed=@date_filedX, amount=@amountX, notes=@notes, " +
						"description_name_taken=@descriptionX;");
				command.Connection = Cnn;


				//traverse the list of claims
				foreach (var clm in Claims)
				{
					if (clm.Claim_id == 0)
					{
						cmd.Parameters.Clear(); //clear previous parameter values

						//populate the query parameters with actual values taken from each Employee object
						cmd.Parameters.AddWithValue("@user_id", clm.User_id);
						cmd.Parameters.AddWithValue("@type_claim", clm.Type);
						cmd.Parameters.AddWithValue("@current_status", clm.CurrentStatus);
						cmd.Parameters.AddWithValue("@assigned_manager_id", clm.Assigned_id);
						cmd.Parameters.AddWithValue("@date_filed", clm.Date_filed);
						cmd.Parameters.AddWithValue("@amount", clm.Amount);
						cmd.Parameters.AddWithValue("@notes", clm.Notes);
						cmd.Parameters.AddWithValue("@description", clm.Description);

						cmd.ExecuteNonQuery();
					}
					else
					{
						command.Parameters.Clear(); //clear previous parameter values

						command.Parameters.AddWithValue("@claim_id", clm.Claim_id);
						command.Parameters.AddWithValue("@user_idX", clm.User_id);
						command.Parameters.AddWithValue("@type_claimX", clm.Type);
						command.Parameters.AddWithValue("@current_statusX", clm.CurrentStatus);
						command.Parameters.AddWithValue("@assigned_manager_idX", clm.Assigned_id);
						command.Parameters.AddWithValue("@date_filedX", clm.Date_filed);
						command.Parameters.AddWithValue("@amountX", clm.Amount);
						command.Parameters.AddWithValue("@notes", clm.Notes);
						command.Parameters.AddWithValue("@descriptionX", clm.Description);

						command.ExecuteNonQuery();
					}

				}
				success = true;
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message, "Something went wrong with inserting data to the database!");

			}
			finally
			{
				Cnn.Close();
			}
			return success;
		}

		public static int NewUser(clsUser newUser)
		{
			Cnn = new SqlConnection(strConnection);

			try
			{

				Cnn.Open();
				SqlCommand command = new SqlCommand();
				command.Connection = Cnn;
				command.CommandText = "select user_id From users where username=@username;";
				command.Parameters.AddWithValue("@username", newUser.Username);

				SqlDataReader dataReader;
				dataReader = command.ExecuteReader();

				if (!dataReader.Read()) //changed this
				{
					dataReader.Close(); //added this
					command.Parameters.Clear();

					command.CommandText =
						"INSERT INTO users(username, passwrd, type) " +
						"VALUES(@username, @password, @type);";
					command.Parameters.AddWithValue("@username", newUser.Username);
					command.Parameters.AddWithValue("@password", newUser.Password);
					command.Parameters.AddWithValue("@type", newUser.Type);

					command.ExecuteNonQuery();

					command.Parameters.Clear();

					command.CommandText = "SELECT user_id FROM users WHERE username=@username;";
					command.Parameters.AddWithValue("@username", newUser.Username);

					dataReader = command.ExecuteReader();
					dataReader.Read();
					newUser.Id = dataReader.GetInt32(0);
					dataReader.Close();
					command.Parameters.Clear();

					command.CommandText =
						"BEGIN IF NOT EXISTS(SELECT user_id FROM user_profile " +
						"	WHERE user_id = @user_id) " +
						"BEGIN INSERT INTO user_profile(user_id, first_name, last_name) " +
						"	VALUES(@user_id, @f, @l) END END";
					command.Parameters.AddWithValue("@user_id", newUser.Id);
					command.Parameters.AddWithValue("@f", newUser.FirstName);
					command.Parameters.AddWithValue("@l", newUser.LastName);

					command.ExecuteNonQuery();
				}
				else
				{
					MessageBox.Show("Username Already Taken", "Creation Unsuccessful");
					newUser.Id = 0;
				}

			}
			catch (Exception err)
			{
				//it handles any other errors
				MessageBox.Show(err.Message, "Warning!");
				newUser.Id = 0;
			}
			finally
			{
				Cnn.Close();
			}
			return newUser.Id;
		}

		public static void CreateProfile(int ID, string f = "", string l = "")
		{
			Cnn = new SqlConnection(strConnection);

			try
			{
				Cnn.Open();
				SqlCommand command = new SqlCommand();
				command.Connection = Cnn;

				command.CommandText = "BEGIN IF NOT EXISTS(SELECT user_id FROM user_profile WHERE user_id = @user_id) BEGIN INSERT INTO user_profile(user_id, first_name, last_name) VALUES(@user_id, @f, @l) END END";
				command.Parameters.AddWithValue("@user_id", ID);
				command.Parameters.AddWithValue("@f", f);
				command.Parameters.AddWithValue("@l", l);

				command.ExecuteNonQuery();

			}
			catch (Exception err)
			{
				//it handles any other errors
				MessageBox.Show(err.Message, "Warning!");
			}
			finally
			{
				Cnn.Close();
			}


		}

		public static bool PushUpdate(clsUser user)
		{
			bool success = false;

			Cnn = new SqlConnection(strConnection);

			try
			{
				Cnn.Open();
				SqlCommand command = new SqlCommand();
				command.Connection = Cnn;

				if (user.Email == "")
				{
					command.CommandText = "UPDATE user_profile SET first_name = @first_name, last_name = @last_name, " +
					"phone_num = @phone_num, address = @address, city = @city, state = @state, zip_code = @zip_code " +
					"WHERE user_id=@user_id; UPDATE users SET username = @username, passwrd = @passwrd, type = @type  " +
					"WHERE user_id=@user_id;";
				}
				else
				{
					command.CommandText = "SELECT * FROM user_profile WHERE email=@email AND user_id!=@user_id;";
					command.Parameters.AddWithValue("@email", user.Email);
					command.Parameters.AddWithValue("@user_id", user.Id);
					SqlDataReader dataReader;
					dataReader = command.ExecuteReader();

					if (!dataReader.Read())
					{
						dataReader.Close();
						command.Parameters.Clear();

						command.CommandText = "UPDATE user_profile SET email = @email, first_name = @first_name, last_name = @last_name, " +
							"phone_num = @phone_num, address = @address, city = @city, state = @state, zip_code = @zip_code " +
							"WHERE user_id=@user_id; UPDATE users SET username = @username, passwrd = @passwrd, type = @type  " +
							"WHERE user_id=@user_id;";

						command.Parameters.AddWithValue("@email", user.Email);

					}
					else
					{
						MessageBox.Show("Email is already associated with another account", "Update Unsuccessfull");
						dataReader.Close();
						Cnn.Close();
						return false;
					}


				}

				command.Parameters.AddWithValue("@user_id", user.Id);
				command.Parameters.AddWithValue("@username", user.Username);
				command.Parameters.AddWithValue("@passwrd", user.Password);
				command.Parameters.AddWithValue("@type", user.Type);
				command.Parameters.AddWithValue("@first_name", user.FirstName);
				command.Parameters.AddWithValue("@last_name", user.LastName);
				command.Parameters.AddWithValue("@phone_num", user.Phone);
				command.Parameters.AddWithValue("@address", user.Address);
				command.Parameters.AddWithValue("@city", user.City);
				command.Parameters.AddWithValue("@state", user.State);
				command.Parameters.AddWithValue("@zip_code", user.ZipCode);

				command.ExecuteNonQuery();

				success = true;
			}
			catch (Exception err)
			{
				//it handles any other errors
				MessageBox.Show(err.Message, "Warning!");
			}
			finally
			{
				Cnn.Close();
			}
			return success;
		}

		public static void CreateProfile(string username, string f = "", string l = "")
		{
			Cnn = new SqlConnection(strConnection);
			int Id = 0;
			try
			{
				Cnn.Open();
				SqlCommand command = new SqlCommand();
				command.Connection = Cnn;

				command.CommandText = "SELECT user_id FROM users where username = @username;";
				command.Parameters.AddWithValue("@username", username);


				SqlDataReader dataReader;
				dataReader = command.ExecuteReader();

				if (dataReader.Read())
                {
					Id = !dataReader.IsDBNull(0) ? (int)dataReader["user_id"] : 0;
				}

			}
			catch (Exception err)
			{
				//it handles any other errors
				MessageBox.Show(err.Message, "Warning!");
			}
			finally
			{
				Cnn.Close();
			}

			CreateProfile(Id, f, l);

		}

		public static List<clsMessage> FetchMessages(int user_id, bool In_T__sent_F=true)
		{
			List<clsMessage> messages = new List<clsMessage>();

			SqlCommand command = new SqlCommand();

			try
			{
				clsDBH_File.Cnn.Open();
				string sender_or_recipient = In_T__sent_F ? "recipient" : "sender";
				command.Connection = clsDBH_File.Cnn;
				command.CommandText =
					"SELECT  * from files where " + sender_or_recipient +" = @S_or_R;";
				command.Parameters.AddWithValue("@S_or_R", user_id);
				SqlDataReader dataReader;

				dataReader = command.ExecuteReader();

				while (dataReader.Read())
				{
					clsMessage message = new clsMessage();

					//if (!dataReader.IsDBNull(0)) { fileContent = dataReader.GetSqlBinary(0); }
					if (!dataReader.IsDBNull(0)) { message.Message_id = dataReader.GetInt32(0); }
					if (!dataReader.IsDBNull(1)) { message.Sender = dataReader.GetInt32(1); }
					if (!dataReader.IsDBNull(2)) { message.Recipient = dataReader.GetInt32(2); }
					if (!dataReader.IsDBNull(3)) { message.Subject = dataReader.GetString(3); }
					if (!dataReader.IsDBNull(4)) { message.Content = dataReader.GetString(4); }
					if (!dataReader.IsDBNull(5)) { message.ReadReciept = dataReader.GetInt32(5); }
					if (!dataReader.IsDBNull(6)) { message.TimeSent = dataReader.GetDateTime(6); }

					messages.Add(message);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message.ToString());
			}
			finally { clsDBH_File.Cnn.Close(); }




			return messages;
		}

		public static List<clsMessage> FetchInbox(int Id)
		{
			//declare a list of clsClaim objects
			List<clsMessage> messages = new List<clsMessage>(); //instantiate the clsClaim list

			try //error handling
			{

				clsMessage tempMessage;


				Cnn = new SqlConnection(strConnection);
				Cnn.Open();

				SqlCommand sqlCommand = new SqlCommand("SELECT * FROM messages WHERE recipient=@recipient", Cnn);
				sqlCommand.Parameters.AddWithValue("@recipient", Id);

				SqlDataReader reader = sqlCommand.ExecuteReader();

				while (reader.Read())
				{
					tempMessage = new clsMessage();

					tempMessage.Message_id = !reader.IsDBNull(0) ? (int)reader["message_id"] : 0;
					tempMessage.Sender = !reader.IsDBNull(1) ? (int)reader["sender"] : 0;
					tempMessage.Recipient = !reader.IsDBNull(2) ? (int)reader["recipient"] : 0;
					tempMessage.Subject = !reader.IsDBNull(3) ? (string)reader["subject"] : "";
					tempMessage.Content = !reader.IsDBNull(4) ? (string)reader["content"] : "";
					tempMessage.ReadReciept = !reader.IsDBNull(5) ? (int)reader["read_reciept"] : 0;
					tempMessage.TimeSent = !reader.IsDBNull(6) ? (DateTime)reader["time_sent"] : DateTime.MaxValue;

					tempMessage.NotYouId = tempMessage.Sender;


					messages.Add(tempMessage);
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message, "Something went wrong with loading data from the database!");

			}
			finally
			{
				Cnn.Close();

			}

			return messages;
		}
		public static List<clsMessage> FetchOutbox(int Id)
		{
			//declare a list of clsClaim objects
			List<clsMessage> messages = new List<clsMessage>(); //instantiate the clsClaim list

			try //error handling
			{

				clsMessage tempMessage;


				Cnn = new SqlConnection(strConnection);
				Cnn.Open();

				SqlCommand sqlCommand = new SqlCommand("SELECT * FROM messages WHERE sender=@sender", Cnn);
				sqlCommand.Parameters.AddWithValue("@sender", Id);

				SqlDataReader reader = sqlCommand.ExecuteReader();

				while (reader.Read())
				{
					tempMessage = new clsMessage();

					tempMessage.Message_id = !reader.IsDBNull(0) ? (int)reader["message_id"] : 0;
					tempMessage.Sender = !reader.IsDBNull(1) ? (int)reader["sender"] : 0;
					tempMessage.Recipient = !reader.IsDBNull(2) ? (int)reader["recipient"] : 0;
					tempMessage.Subject = !reader.IsDBNull(3) ? (string)reader["subject"] : "";
					tempMessage.Content = !reader.IsDBNull(4) ? (string)reader["content"] : "";
					tempMessage.ReadReciept = !reader.IsDBNull(5) ? (int)reader["read_reciept"] : 0;
					tempMessage.TimeSent = !reader.IsDBNull(6) ? (DateTime)reader["time_sent"] : DateTime.MaxValue;

					tempMessage.NotYouId = tempMessage.Recipient;


					messages.Add(tempMessage);
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message, "Something went wrong with loading data from the database!");

			}
			finally
			{
				Cnn.Close();

			}

			return messages;
		}

		public static List<clsClaim> FetchAssignedClaims(int Id)
		{
			//declare a list of clsClaim objects
			List<clsClaim> Claims;

			Claims = new List<clsClaim>(); //instantiate the clsClaim list

			try //error handling
			{

				clsClaim tempClaim;


				Cnn = new SqlConnection(strConnection);
				Cnn.Open();

				SqlCommand sqlCommand = new SqlCommand("SELECT * FROM claims WHERE assigned_manager_id=@assigned", Cnn);
				sqlCommand.Parameters.AddWithValue("@assigned", Id);

				SqlDataReader reader = sqlCommand.ExecuteReader();

				while (reader.Read())
				{
					tempClaim = new clsClaim();

					tempClaim.Claim_id = !reader.IsDBNull(0) ? (int)reader["claim_id"] : 0;
					tempClaim.User_id = !reader.IsDBNull(1) ? (int)reader["user_id"] : 0;
					tempClaim.Type = !reader.IsDBNull(2) ? (string)reader["type_claim"] : "";
					tempClaim.CurrentStatus = !reader.IsDBNull(3) ? (string)reader["current_status"] : "";
					tempClaim.Assigned_id = !reader.IsDBNull(4) ? (int)reader["assigned_manager_id"] : 0;
					tempClaim.Date_filed = !reader.IsDBNull(5) ? (DateTime)reader["date_filed"] : DateTime.MaxValue;
					tempClaim.Amount = !reader.IsDBNull(6) ? (decimal)reader["amount"] : -1;
					tempClaim.Notes = !reader.IsDBNull(7) ? (string)reader["notes"] : "";
					tempClaim.Description = !reader.IsDBNull(8) ? (string)reader["description_name_taken"] : "";

					Claims.Add(tempClaim);
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message, "Something went wrong with loading data from the database!");

			}
			finally
			{
				Cnn.Close();

			}

			return Claims;
		}

	}
}
