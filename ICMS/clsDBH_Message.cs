using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ICMS
{
    public class clsDBH_Message : clsInheritanceDatabase
    {
		public static List<clsUser> GetMessagableUsers ()
        {
			List<clsUser> users = new List<clsUser>();

			try //error handling
			{

				clsUser user;


				Cnn = new SqlConnection(strConnection);
				Cnn.Open();

				SqlCommand sqlCommand = new SqlCommand("SELECT username, passwrd, [type], users.user_id, " +
						"first_name, last_name, email, phone_num, address, city, state, zip_code " +
						"FROM users " +
						"INNER JOIN user_profile " +
						"ON users.user_id = user_profile.user_id ", Cnn);

				SqlDataReader dataReader = sqlCommand.ExecuteReader();

				while (dataReader.Read())
				{
					user = new clsUser();

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


					users.Add(user);
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

			return users;

		}

		public static int Insert(clsMessage message)
		{
			message.Message_id = 0;
			Cnn = new SqlConnection(strConnection);

			try
			{

				Cnn.Open();
				SqlCommand command = new SqlCommand();
				command.Connection = Cnn;

				// SqlDataReader dataReader;

				command.CommandText =
					"INSERT INTO messages(sender, recipient, subject, content, read_reciept, time_sent)" +
					"VALUES(@sender, @recipient, @subject, @content, @read_reciept, @time_sent);";
				command.Parameters.AddWithValue("@sender", message.Sender);
				command.Parameters.AddWithValue("@recipient", message.Recipient);
				command.Parameters.AddWithValue("@subject", message.Subject);
				command.Parameters.AddWithValue("@content", message.Content);
				command.Parameters.AddWithValue("@read_reciept", message.ReadReciept);
				command.Parameters.AddWithValue("@time_sent", message.TimeSent);

				command.ExecuteNonQuery();
				command.Parameters.Clear(); //clear previous parameter values
				/*
				command.CommandText =
					"select Max(message_id) from messages where sender = @sender";
				command.Parameters.AddWithValue("@sender", message.Sender);

				dataReader = command.ExecuteReader();
				dataReader.Read();
				message.Message_id = dataReader.GetInt32(0);
				dataReader.Close();

				command.Parameters.Clear(); //clear previous parameter values

				command.CommandText =
					"UPDATE messages SET message_id = @message_id WHERE message_id = 0; ";
				command.Parameters.AddWithValue("@message_id", message.Message_id);
				command.ExecuteNonQuery();
				*/

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

			return message.Message_id;
		}
		public static bool Update(clsMessage message)
		{
			bool success = false;
			Cnn = new SqlConnection(strConnection);

			try
			{
				Cnn.Open();
				SqlCommand command = new SqlCommand();
				command.Connection = Cnn;

				command.CommandText =
					"UPDATE dbo.messages SET sender = @sender, recipient = @recipient, " +
						"subject = @subject, content = @content, read_reciept = @read_reciept, time_sent = @time_sent " +
					"WHERE message_id = @message_id;";

				command.Parameters.AddWithValue("@sender", message.Sender);
				command.Parameters.AddWithValue("@recipient", message.Recipient);
				command.Parameters.AddWithValue("@subject", message.Subject);
				command.Parameters.AddWithValue("@content", message.Content);
				command.Parameters.AddWithValue("@read_reciept", message.ReadReciept);
				command.Parameters.AddWithValue("@time_sent", message.TimeSent);

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

		public static clsMessage FetchMessage(clsMessage message, SearchBy searchBy = SearchBy.sender)
		{

			SqlConnection Cnn;
			Cnn = new SqlConnection(strConnection);

			try
			{
				Cnn.Open();
				SqlCommand command = new SqlCommand();

				command.Connection = Cnn;
				SqlDataReader dataReader;
				if (searchBy == SearchBy.sender)
				{
					command.CommandText = "SELECT message_id, recipient, subject, content," +
						"read_reciept, time_sent" +
					"FROM dbo.messages WHERE sender =@sender;";
					command.Parameters.AddWithValue("@sender", message.Sender);
				}
				else
				{
					command.CommandText = "SELECT message_id, sender, subject, content," +
						"read_reciept, time_sent" +
					"FROM dbo.messages WHERE recipient =@recipient;";
					command.Parameters.AddWithValue("@recipient", message.Recipient);

				}
				dataReader = command.ExecuteReader();

				if (dataReader.Read())
				{
					if (!dataReader.IsDBNull(0)) { message.Message_id = dataReader.GetInt32(3); }
					else { message.Message_id = 0; }
					if (!dataReader.IsDBNull(1)) { message.Sender = dataReader.GetInt32(3); }
					if (!dataReader.IsDBNull(2)) { message.Recipient = dataReader.GetInt32(3); }
					if (!dataReader.IsDBNull(3)) { message.Subject = dataReader.GetString(2); }
					if (!dataReader.IsDBNull(4)) { message.Content = dataReader.GetString(6); }
					if (!dataReader.IsDBNull(5)) { message.ReadReciept = dataReader.GetInt32(1); }
					if (!dataReader.IsDBNull(6)) { message.TimeSent = dataReader.GetDateTime(4); }
				}
				else { message.Message_id = 0; }

			}
			catch (Exception err)
			{
				//it handles any other errors
				MessageBox.Show(err.Message, "Message does not exist");
			}
			finally
			{
				Cnn.Close(); //Close connection regardless of any errors or not
			}

			return message;
		}

		public static void ReadReciept(clsMessage message)
        {
			SqlConnection Cnn;
			Cnn = new SqlConnection(strConnection);

			try
			{
				Cnn.Open();
				SqlCommand command = new SqlCommand();

				command.Connection = Cnn;
				SqlDataReader dataReader;
				
				command.CommandText = "UPdate messages SET read_reciept = 1" +
					"where message_id = @message_id";
				command.Parameters.AddWithValue("@message_id", message.Message_id);

				command.ExecuteNonQuery();
				

			}
			catch (Exception err)
			{
				//it handles any other errors
				MessageBox.Show(err.Message, "Message read reciept error");
			}
			finally
			{
				Cnn.Close(); //Close connection regardless of any errors or not
			}

		}

	}
}
