using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ICMS
{
    public class clsDBH_Claim : clsInheritanceDatabase
    {
		public static clsClaim FetchClaim(int claim_id)
		{
			clsClaim claim = new clsClaim();

			claim.Claim_id = claim_id;
			
			Cnn = new SqlConnection(strConnection);

			try
			{
				Cnn.Open();
				SqlCommand command = new SqlCommand();

				command.Connection = Cnn;
				SqlDataReader dataReader;

				command.CommandText = 
					"SELECT user_id, type_claim, current_status, assigned_manager_id, date_filed," +
						"amount, description_name_taken"+
					"FROM dbo.claims WHERE claim_id =@claim_id;";
				command.Parameters.AddWithValue("@claim_id", claim.Claim_id);
				dataReader = command.ExecuteReader();
				dataReader.Read();
				if (dataReader.HasRows)
				{
					if (!dataReader.IsDBNull(0)) { claim.User_id = dataReader.GetInt32(0); }
					if (!dataReader.IsDBNull(1)) { claim.Type = dataReader.GetString(1); }
					if (!dataReader.IsDBNull(2)) { claim.CurrentStatus = dataReader.GetString(2); }
					if (!dataReader.IsDBNull(3)) { claim.Assigned_id = dataReader.GetInt32(3); }
					if (!dataReader.IsDBNull(4)) { claim.Date_filed = dataReader.GetDateTime(4); }
					if (!dataReader.IsDBNull(5)) { claim.Amount = dataReader.GetDecimal(5); }
					if (!dataReader.IsDBNull(6)) { claim.Description = dataReader.GetString(6); }
				}
			}
			catch (Exception err)
			{
				//it handles any other errors
				MessageBox.Show(err.Message, "Claim does not exist");
			}
			finally
			{
				Cnn.Close(); //Close connection regardless of any errors or not
			}

			return claim;
		}

		public static int Insert(clsClaim claim)
		{
			claim.Claim_id = 0;
			Cnn = new SqlConnection(strConnection);

			try
			{

				Cnn.Open();
				SqlCommand command = new SqlCommand();
				command.Connection = Cnn;

				SqlDataReader dataReader;

				command.CommandText =
					"INSERT INTO claims(user_id, type_claim, current_status, assigned_manager_id, date_filed, amount, notes, description_name_taken)" +
					"VALUES(@user_id, @type_claim, @current_status, @assigned_manager_id, @date_filed, @amount, @notes,  @description);";
				command.Parameters.AddWithValue("@user_id", claim.User_id);
				command.Parameters.AddWithValue("@type_claim", claim.Type);
				command.Parameters.AddWithValue("@current_status", claim.CurrentStatus);
				command.Parameters.AddWithValue("@assigned_manager_id", claim.Assigned_id);
				command.Parameters.AddWithValue("@date_filed", claim.Date_filed);
				command.Parameters.AddWithValue("@amount", claim.Amount);
				command.Parameters.AddWithValue("@notes", claim.Notes);
				command.Parameters.AddWithValue("@description", claim.Description);

				command.ExecuteNonQuery();
				command.Parameters.Clear(); //clear previous parameter values

				command.CommandText =
					"select Max(claim_id) from claims where user_id = @user_id";
				command.Parameters.AddWithValue("@user_id", claim.User_id);

				dataReader = command.ExecuteReader();
				dataReader.Read();
				claim.Claim_id = dataReader.GetInt32(0);
				dataReader.Close();

				command.Parameters.Clear(); //clear previous parameter values

				command.CommandText =
					"UPDATE files SET claim_id = @claim_id WHERE user_id = @user_id AND claim_id = 0; ";
				command.Parameters.AddWithValue("@user_id", claim.User_id);
				command.Parameters.AddWithValue("@claim_id", claim.Claim_id);
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

			return claim.Claim_id;
		}

		public static List<clsClaimUpdate> FetchClaimUpdateList(int claim_id)
		{
			//declare a list of clsClaimUpdate objects
			List<clsClaimUpdate> ClaimUpdates;

			ClaimUpdates = new List<clsClaimUpdate>(); //instantiate the clsClaimUpdate list

			try //error handling
			{

				clsClaimUpdate tempUpdate;

				Cnn = new SqlConnection(strConnection);
				Cnn.Open();

				SqlCommand sqlCommand = new SqlCommand("SELECT * FROM claim_updates WHERE claim_id=@claim_id", Cnn);
				sqlCommand.Parameters.AddWithValue("@claim_id", claim_id);

				SqlDataReader reader = sqlCommand.ExecuteReader();

				while (reader.Read())
				{
					claim_id = (int)reader["claim_id"];
					string current_status = (string)reader["current_status"];
					DateTime date_filed = (DateTime)reader["date_filed"];
					int manager_id = (int)reader["manager_id"];

					tempUpdate = new clsClaimUpdate(claim_id, current_status, date_filed, manager_id);
					tempUpdate.InDatabase = true;

					ClaimUpdates.Add(tempUpdate);
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

			return ClaimUpdates;
		}

		public static void PushClaimUpdateList(List<clsClaimUpdate> claimUpdates)
		{
			try
			{
				Cnn = new SqlConnection(strConnection);
				Cnn.Open();

				SqlCommand cmd =
					new SqlCommand(
						"INSERT INTO dbo.claim_updates (claim_id, current_status, date_filed, manager_id)" +
						"VALUES(@claim_id, @current_status, @date_filed, @manager_id); ");
				cmd.Connection = Cnn;

				//traverse the list of employees
				foreach (var update in claimUpdates)
				{
					if (!update.InDatabase)
                    {
						cmd.Parameters.Clear(); //clear previous parameter values

						//populate the query parameters with actual values taken from each Employee object
						cmd.Parameters.AddWithValue("@claim_id", update.Claim_id);
						cmd.Parameters.AddWithValue("@current_status", update.CurrentStatus);
						cmd.Parameters.AddWithValue("@date_filed", update.Date_filed);
						cmd.Parameters.AddWithValue("@manager_id", update.Assigned_id);

						cmd.ExecuteNonQuery();
					}
				}

			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message, "Something went wrong with inserting data to the database!");
			}
			finally
			{
				Cnn.Close();
			}
		}

		public static bool Update(clsClaim claim)
		{
			bool success = false;
			Cnn = new SqlConnection(strConnection);

			try
			{
				Cnn.Open();
				SqlCommand command = new SqlCommand();
				command.Connection = Cnn;

				command.CommandText =
					"UPDATE dbo.claims SET user_id = @user_id, type_claim = @type_claim, current_status = @current_status, " +
						"assigned_manager_id = @assigned_manager_id, date_filed = @date_filed, amount = @amount,notes=@notes, description_name_taken=@description " +
					"WHERE claim_id=@claim_id;";


				command.Parameters.AddWithValue("@user_id", claim.User_id);
				command.Parameters.AddWithValue("@type_claim", claim.Type);
				command.Parameters.AddWithValue("@current_status", claim.CurrentStatus);
				command.Parameters.AddWithValue("@assigned_manager_id", claim.Assigned_id);
				command.Parameters.AddWithValue("@date_filed", claim.Date_filed);
				command.Parameters.AddWithValue("@amount", claim.Amount);
				command.Parameters.AddWithValue("@claim_id", claim.Claim_id);
				command.Parameters.AddWithValue("@notes", claim.Notes);
				command.Parameters.AddWithValue("@description", claim.Description);

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

		public static bool PushClaimUpdate(clsClaim claim)
		{
			bool success = false;
			Cnn = new SqlConnection(strConnection);

			try
			{
				Cnn.Open();
				SqlCommand command = new SqlCommand();
				command.Connection = Cnn;

				command.CommandText =
					"UPDATE dbo.claims SET user_id = @user_id, type_claim = @type_claim, current_status = @current_status, " +
						"assigned_manager_id = @assigned_manager_id, date_filed = @date_filed, amount = @amount,notes=@notes, description_name_taken=@description " +
					"WHERE claim_id=@claim_id;";


				command.Parameters.AddWithValue("@user_id", claim.User_id);
				command.Parameters.AddWithValue("@type_claim", claim.Type);
				command.Parameters.AddWithValue("@current_status", claim.CurrentStatus);
				command.Parameters.AddWithValue("@assigned_manager_id", claim.Assigned_id);
				command.Parameters.AddWithValue("@date_filed", claim.Date_filed);
				command.Parameters.AddWithValue("@amount", claim.Amount);
				command.Parameters.AddWithValue("@claim_id", claim.Claim_id);
				command.Parameters.AddWithValue("@notes", claim.Claim_id);
				command.Parameters.AddWithValue("@description", claim.Description);

				command.ExecuteNonQuery();

				success = true;
				//claim.InDatabase=true;

			}
			catch (Exception err)
			{
				//it handles any other errors
				MessageBox.Show(err.Message, "Warning!");
			}
			finally { Cnn.Close(); }

			return success;
		}

		public static List<clsFile> FetchFilesInformation(clsClaim claim)
        {
			List<clsFile> fileInfo = new List<clsFile>();

			SqlCommand command = new SqlCommand();

			try
			{
				clsDBH_File.Cnn.Open();

				command.Connection = clsDBH_File.Cnn;
				command.CommandText =
					"SELECT  file_name, file_type, file_id, user_id from files where claim_id = @claim_id;";
				command.Parameters.AddWithValue("@claim_id", claim.Claim_id);
				SqlDataReader dataReader;

				dataReader = command.ExecuteReader();
				
				while (dataReader.Read())
				{
					clsFile file = new clsFile();
					
					//if (!dataReader.IsDBNull(0)) { fileContent = dataReader.GetSqlBinary(0); }
					if (!dataReader.IsDBNull(0)) { file.File_name = dataReader.GetString(0); }
					if (!dataReader.IsDBNull(1)) { file.File_type = dataReader.GetString(1); }
					if (!dataReader.IsDBNull(2)) { file.File_id = dataReader.GetInt32(2); }
					if (!dataReader.IsDBNull(3)) { file.User_id = dataReader.GetInt32(3); }



					fileInfo.Add(file);
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message.ToString());
			}
			finally { clsDBH_File.Cnn.Close(); }




			return fileInfo;
		}
		public static List<clsFile> FetchFilesInformation(int claim_id)
		{
			List<clsFile> fileInfo = new List<clsFile>();

			SqlCommand command = new SqlCommand();

			try
			{
				clsDBH_File.Cnn.Open();

				command.Connection = clsDBH_File.Cnn;
				command.CommandText =
					"SELECT  file_name, file_type, file_id, user_id from files where claim_id = @claim_id;";
				command.Parameters.AddWithValue("@claim_id", claim_id);
				SqlDataReader dataReader;

				dataReader = command.ExecuteReader();

				while (dataReader.Read())
				{
					clsFile file = new clsFile();

					//if (!dataReader.IsDBNull(0)) { fileContent = dataReader.GetSqlBinary(0); }
					if (!dataReader.IsDBNull(0)) { file.File_name = dataReader.GetString(0); }
					if (!dataReader.IsDBNull(1)) { file.File_type = dataReader.GetString(1); }
					if (!dataReader.IsDBNull(2)) { file.File_id = dataReader.GetInt32(2); }
					if (!dataReader.IsDBNull(3)) { file.User_id = dataReader.GetInt32(3); }



					fileInfo.Add(file);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message.ToString());
			}
			finally { clsDBH_File.Cnn.Close(); }




			return fileInfo;
		}
		public static List<clsFile> FetchFiles(clsClaim claim)
		{
			List<clsFile> fileInfo = new List<clsFile>();

			SqlCommand command = new SqlCommand();

			try
			{
				clsDBH_File.Cnn.Open();

				command.Connection = clsDBH_File.Cnn;
				command.CommandText =
					"SELECT  file_data, file_name, file_type from files where claim_id = @claim_id;";
				command.Parameters.AddWithValue("@claim_id", claim.Claim_id);
				SqlDataReader dataReader;

				dataReader = command.ExecuteReader();

				while (dataReader.Read())
				{
					clsFile file = new clsFile();

					if (!dataReader.IsDBNull(0)) { file.Data = (byte[])dataReader.GetSqlBinary(0); }
					if (!dataReader.IsDBNull(1)) { file.File_name = dataReader.GetString(1); }
					if (!dataReader.IsDBNull(2)) { file.File_type = dataReader.GetString(2); }
					if (!dataReader.IsDBNull(3)) { file.File_id = dataReader.GetInt32(3); }
					if (!dataReader.IsDBNull(4)) { file.User_id = dataReader.GetInt32(4); }

					fileInfo.Add(file);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message.ToString());
			}
			finally { clsDBH_File.Cnn.Close(); }




			return fileInfo;
		}
		public static List<clsFile> FetchFiles(int claim_id)
		{
			List<clsFile> fileInfo = new List<clsFile>();

			SqlCommand command = new SqlCommand();

			try
			{
				clsDBH_File.Cnn.Open();

				command.Connection = clsDBH_File.Cnn;
				command.CommandText =
					"SELECT  file_data, file_name, file_type from files where claim_id = @claim_id;";
				command.Parameters.AddWithValue("@claim_id", claim_id);
				SqlDataReader dataReader;

				dataReader = command.ExecuteReader();

				while (dataReader.Read())
				{
					clsFile file = new clsFile();

					if (!dataReader.IsDBNull(0)) { file.Data = (byte[])dataReader.GetSqlBinary(0); }
					if (!dataReader.IsDBNull(1)) { file.File_name = dataReader.GetString(1); }
					if (!dataReader.IsDBNull(2)) { file.File_type = dataReader.GetString(2); }
					if (!dataReader.IsDBNull(3)) { file.File_id = dataReader.GetInt32(3); }
					if (!dataReader.IsDBNull(4)) { file.User_id = dataReader.GetInt32(4); }

					fileInfo.Add(file);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message.ToString());
			}
			finally { clsDBH_File.Cnn.Close(); }




			return fileInfo;
		}


	}
}
