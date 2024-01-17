using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ICMS
{
	static class clsDatabase
	{

		//public static string strConnection { get; set; } = @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_C;Persist Security Info=True;User ID=TEAM_C;Password=GJuANjex89rS7uxfksbj4cjt";

		//public static SqlConnection Cnn { get; set; }

		//public static bool PushUpdate(int ID, string username, string passwrd, string type, string first_name, string last_name, string email, string phone_num, string address, string city, string state, string zip_code)
		//{
		//	bool success = false;
			
		//	Cnn = new SqlConnection(strConnection);

		//	try
		//	{
		//		Cnn.Open();
		//		SqlCommand command = new SqlCommand();
		//		command.Connection = Cnn;

		//		command.CommandText = "UPDATE user_profile SET email = @email, first_name = @first_name, last_name = @last_name, " +
		//			"phone_num = @phone_num, address = @address, city = @city, state = @state, zip_code = @zip_code " +
		//			"WHERE user_id=@user_id; UPDATE users SET username = @username, passwrd = @passwrd, type = @type  " +
		//			"WHERE user_id=@user_id;";

				//command.Parameters.AddWithValue("@user_id", ID);
				//command.Parameters.AddWithValue("@username", username);
				//command.Parameters.AddWithValue("@passwrd", passwrd);
				//command.Parameters.AddWithValue("@type", type);
				//command.Parameters.AddWithValue("@first_name", first_name);
				//command.Parameters.AddWithValue("@last_name", last_name);
				//if ("@email" != string.Empty) { command.Parameters.AddWithValue("@email", email); }
				//else { command.Parameters.AddWithValue("@email", DBNull.Value); }
				//command.Parameters.AddWithValue("@phone_num", phone_num);
				//command.Parameters.AddWithValue("@address", address);
				//command.Parameters.AddWithValue("@city", city);
				//command.Parameters.AddWithValue("@state", state);
				//command.Parameters.AddWithValue("@zip_code", zip_code);

		//		command.ExecuteNonQuery();

		//		Cnn.Close();
		//		success = true;
		//	}
		//	catch (Exception err)
		//	{
		//		//it handles any other errors
		//		MessageBox.Show(err.Message, "Warning!");
		//	}
		//	return success;
		//}

		////FetchUser(int Id)
		////Fetches a tuple from the database,users&user_profiles based on user_id input
		//public static (string username, string passwrd, string type, int id, string first_name, string last_name, string email, string phone_num, string address, string city, string state, string zip_code) FetchUser(int ID) // tuple return type
		//{

		//	int dbId = 0;
		//	String dbUsername = "", dbPassword = "", dbType = "", dbFirst_name = "", dbLast_name = "", dbEmail = "", dbPhone = "", dbAddress = "", dbCity = "", dbState = "", dbZip = "";
		//	SqlConnection Cnn;
		//	Cnn = new SqlConnection(strConnection);

		//	try
		//	{
		//		Cnn.Open();
		//		SqlCommand command = new SqlCommand();

		//		command.Connection = Cnn;
		//		SqlDataReader dataReader;

		//		command.CommandText = "SELECT username, passwrd, [type], users.user_id, first_name, last_name, email, phone_num, address, city, state, zip_code FROM users INNER JOIN user_profile ON users.user_id = user_profile.user_id WHERE users.user_id = @user_id;";
		//		command.Parameters.AddWithValue("@user_id", ID);
		//		dataReader = command.ExecuteReader();
		//		dataReader.Read();
		//		if (dataReader.HasRows)
		//		{
		//			if (!dataReader.IsDBNull(0)) { dbUsername = dataReader.GetString(0); }
		//			else { dbUsername = ""; }
		//			if (!dataReader.IsDBNull(1)) { dbPassword = dataReader.GetString(1); }
		//			else { dbPassword = ""; }
		//			if (!dataReader.IsDBNull(2)) { dbType = dataReader.GetString(2); }
		//			else { dbType = ""; }
		//			if (!dataReader.IsDBNull(3)) { dbId = dataReader.GetInt32(3); }
		//			else { dbId = 0; }
		//			if (!dataReader.IsDBNull(4)) { dbFirst_name = dataReader.GetString(4); }
		//			else { dbFirst_name = ""; }
		//			if (!dataReader.IsDBNull(5)) { dbLast_name = dataReader.GetString(5); }
		//			else { dbLast_name = ""; }
		//			if (!dataReader.IsDBNull(6)) { dbEmail += dataReader.GetString(6); }
		//			else { dbEmail = ""; }
		//			if (!dataReader.IsDBNull(7)) { dbPhone = dataReader.GetString(7); }
		//			else { dbPhone = ""; }
		//			if (!dataReader.IsDBNull(8)) { dbAddress = dataReader.GetString(8); }
		//			else { dbAddress = ""; }
		//			if (!dataReader.IsDBNull(9)) { dbCity = dataReader.GetString(9); }
		//			else { dbCity = ""; }
		//			if (!dataReader.IsDBNull(10)) { dbState = dataReader.GetString(10); }
		//			else { dbState = ""; }
		//			if (!dataReader.IsDBNull(11)) { dbZip = dataReader.GetString(11); }
		//			else { dbZip = ""; }
		//		}




		//	}
		//	catch (Exception err)
		//	{
		//		//it handles any other errors
		//		MessageBox.Show(err.Message, "User does not exist");
		//	}
		//	finally
		//	{
		//		Cnn.Close(); //Close connection regardless of any errors or not
		//	}

		//	return (dbUsername, dbPassword, dbType, dbId, dbFirst_name, dbLast_name, dbEmail, dbPhone, dbAddress, dbCity, dbState, dbZip); // tuple literal
		//}

		////FetchUser(string email, bool using_username=false)
		////Fetches a tuple from the database,users&user_profiles based on email/username based on 2nd F/T input
		//public static (string username, string passwrd, string type, int id, string first_name, string last_name, string email) FetchUser(string Email, bool using_username = false) // tuple return type
		//{
		//	int dbId = 0;
		//	String dbUsername = "", dbPassword = "", dbType = "", dbFirst_name = "", dbLast_name = "", dbEmail = "";
		//	Cnn = new SqlConnection(strConnection);

		//	try
		//	{
		//		Cnn.Open();
		//		SqlCommand command = new SqlCommand();

		//		command.Connection = Cnn;
		//		SqlDataReader dataReader;
		//		if (using_username)
		//		{ command.CommandText = "SELECT username, passwrd, [type], users.user_id, first_name, last_name, email  FROM users INNER JOIN user_profile ON users.user_id = user_profile.user_id WHERE users.username = @email;"; }
		//		else { command.CommandText = "SELECT username, passwrd, [type], users.user_id, first_name, last_name, email  FROM users INNER JOIN user_profile ON users.user_id = user_profile.user_id WHERE user_profile.email = @email;"; }
		//		command.Parameters.AddWithValue("@email", Email);
		//		dataReader = command.ExecuteReader();
		//		dataReader.Read();

		//		if (dataReader.HasRows)
		//		{
		//			if (!dataReader.IsDBNull(0)) { dbUsername = dataReader.GetString(0); }
		//			else { dbUsername = ""; }
		//			if (!dataReader.IsDBNull(1)) { dbPassword = dataReader.GetString(1); }
		//			else { dbPassword = ""; }
		//			if (!dataReader.IsDBNull(2)) { dbType = dataReader.GetString(2); }
		//			else { dbType = ""; }
		//			if (!dataReader.IsDBNull(2)) { dbId = dataReader.GetInt32(3); }
		//			else { dbId = 0; }
		//			if (!dataReader.IsDBNull(3)) { dbFirst_name = dataReader.GetString(4); }
		//			else { dbFirst_name = ""; }
		//			if (!dataReader.IsDBNull(4)) { dbLast_name = dataReader.GetString(5); }
		//			else { dbLast_name = ""; }
		//			if (!dataReader.IsDBNull(5)) { dbEmail = dataReader.GetString(6); }
		//			else { dbEmail = ""; }
		//		}


		//	}
		//	catch (Exception err)
		//	{
		//		//it handles any other errors
		//		MessageBox.Show(err.Message, "User does not exist");
		//	}
		//	finally
		//	{
		//		Cnn.Close(); //Close connection regardless of any errors or not
		//	}

		//	return (dbUsername, dbPassword, dbType, dbId, dbFirst_name, dbLast_name, dbEmail); // tuple literal
		//}

		//public static void CreateProfile(int ID, string f, string l, string e)
		//{
		//	Cnn = new SqlConnection(strConnection);

		//	try
		//	{
		//		Cnn.Open();
		//		SqlCommand command = new SqlCommand();
		//		command.Connection = Cnn;

		//		command.CommandText = "BEGIN IF NOT EXISTS(SELECT user_id FROM user_profile WHERE user_id = @user_id) BEGIN INSERT INTO user_profile(user_id, first_name, last_name, email) VALUES(@user_id, @f, @l, @e) END END";
		//		command.Parameters.AddWithValue("@user_id", ID);
		//		command.Parameters.AddWithValue("@f", f);
		//		command.Parameters.AddWithValue("@l", l);
		//		command.Parameters.AddWithValue("@e", e);

		//		command.ExecuteNonQuery();

		//		Cnn.Close();
		//	}
		//	catch (Exception err)
		//	{
		//		//it handles any other errors
		//		MessageBox.Show(err.Message, "Warning!");
		//	}


		//}
		//public static void CreateProfile(int ID, string f = "", string l = "")
		//{
		//	Cnn = new SqlConnection(strConnection);

		//	try
		//	{
		//		Cnn.Open();
		//		SqlCommand command = new SqlCommand();
		//		command.Connection = Cnn;

		//		command.CommandText = "BEGIN IF NOT EXISTS(SELECT user_id FROM user_profile WHERE user_id = @user_id) BEGIN INSERT INTO user_profile(user_id, first_name, last_name) VALUES(@user_id, @f, @l) END END";
		//		command.Parameters.AddWithValue("@user_id", ID);
		//		command.Parameters.AddWithValue("@f", f);
		//		command.Parameters.AddWithValue("@l", l);

		//		command.ExecuteNonQuery();

		//		Cnn.Close();
		//	}
		//	catch (Exception err)
		//	{
		//		//it handles any other errors
		//		MessageBox.Show(err.Message, "Warning!");
		//	}


		//}
		//public static void CreateProfile(string username, string f = "", string l = "")
		//{
		//	Cnn = new SqlConnection(strConnection);

		//	try
		//	{
		//		Cnn.Open();
		//		SqlCommand command = new SqlCommand();
		//		command.Connection = Cnn;
		//		SqlDataReader dataReader;
		//		int Id = 0;

		//		command.CommandText = "SELECT user_id FROM users WHERE username = @username;";
		//		command.Parameters.AddWithValue("@username", username);
		//		dataReader = command.ExecuteReader();
		//		dataReader.Read();

		//		if (dataReader.HasRows)
		//		{
		//			if (!dataReader.IsDBNull(0)) { Id = dataReader.GetInt32(0); }
		//			else { Id = 0; }
		//		}
		//		dataReader.Close();

		//		command.Parameters.Clear(); //clear previous parameter values

		//		command.CommandText = "BEGIN IF NOT EXISTS(SELECT user_id FROM user_profile WHERE user_id = @user_id) BEGIN INSERT INTO user_profile(user_id, first_name, last_name) VALUES(@user_id, @f, @l) END END";
		//		command.Parameters.AddWithValue("@user_id", Id);
		//		command.Parameters.AddWithValue("@f", f);
		//		command.Parameters.AddWithValue("@l", l);

		//		command.ExecuteNonQuery();

		//		Cnn.Close();
		//	}
		//	catch (Exception err)
		//	{
		//		//it handles any other errors
		//		MessageBox.Show(err.Message, "Warning!");
		//	}


		//}

		////creates a new user as long as the username isnt already taken
		////returns id of new user. if 0, unsuccessful
		//public static int NewUser(string Username, string Password, string optionalType = "client")
		//{
		//	int Id = 0;
		//	Cnn = new SqlConnection(strConnection);

		//	try
		//	{

		//		Cnn.Open();
		//		SqlCommand command = new SqlCommand();
		//		command.Connection = Cnn;
		//		command.CommandText = "select user_id From users where username=@username;";
		//		command.Parameters.AddWithValue("@username", Username);

		//		SqlDataReader dataReader;
		//		dataReader = command.ExecuteReader();
		//		// dataReader.Read(); // removed this

		//		if (dataReader.Read() == false) //changed this
		//		{
		//			dataReader.Close(); //added this
		//			command.CommandText = "INSERT INTO users(username, passwrd, type) VALUES(@username2, @password, @type);";
		//			command.Parameters.AddWithValue("@username2", Username);
		//			command.Parameters.AddWithValue("@password", Password);
		//			command.Parameters.AddWithValue("@type", optionalType);

		//			command.ExecuteNonQuery();
		//			command.CommandText = "Select user_id FROM users WHERE username=@username3;";
		//			command.Parameters.AddWithValue("@username3", Username);

		//			dataReader = command.ExecuteReader();
		//			dataReader.Read();
		//			Id = dataReader.GetInt32(0);
		//		}
		//		else
		//		{
		//			MessageBox.Show("Username Already Taken", "Creation Unsuccessful");
		//			Id = 0;
		//		}

		//		Cnn.Close();
		//	}
		//	catch (Exception err)
		//	{
		//		//it handles any other errors
		//		MessageBox.Show(err.Message, "Warning!");
		//	}

		//	return Id;
		//}

		//public static (int id, string type) Login(string Username, string Password)
		//{
		//	int Id = 0;
		//	string Type = "";
		//	Cnn = new SqlConnection(strConnection);

		//	try
		//	{
		//		Cnn.Open();
		//		SqlCommand command = new SqlCommand();
		//		command.Connection = Cnn;
		//		SqlDataReader dataReader;
		//		command.CommandText = "SELECT user_id, type FROM users WHERE username=@username AND passwrd=@password";
		//		command.Parameters.AddWithValue("@username", Username);
		//		command.Parameters.AddWithValue("@password", Password);


		//		dataReader = command.ExecuteReader();
		//		dataReader.Read();
		//		if (dataReader.HasRows)
		//		{
		//			if (!dataReader.IsDBNull(0)) { Id = dataReader.GetInt32(0); }
		//			else { Id = 0; }
		//			if (!dataReader.IsDBNull(1)) { Type = dataReader.GetString(1); }
		//			else { Type = ""; }
		//		}

		//		Cnn.Close();
		//	}
		//	catch (Exception err)
		//	{
		//		//it handles any other errors
		//		MessageBox.Show(err.Message, "Warning!");
		//	}
		//	return (Id, Type);
		//}

		//public static (int User_id, string Type, string CurrentStatus, int Assigned_id, DateTime Date_filed, Decimal Amount, string Description) FetchClaim(int Claim_id)
		//{
		//	int User_id = 0, Assigned_id = 0;
		//	Decimal Amount = -1;
		//	string Type = "", CurrentStatus = "", Description = "";
		//	DateTime Date_filed = default(DateTime);

		//	Cnn = new SqlConnection(strConnection);

		//	try
		//	{
		//		Cnn.Open();
		//		SqlCommand command = new SqlCommand();

		//		command.Connection = Cnn;
		//		SqlDataReader dataReader;

		//		command.CommandText = "SELECT user_id, type_claim, current_status, assigned_manager_id, date_filed, amount, description_name_taken FROM dbo.claims WHERE claim_id =@user_id;";
		//		command.Parameters.AddWithValue("@user_id", Claim_id);
		//		dataReader = command.ExecuteReader();
		//		dataReader.Read();
		//		if (dataReader.HasRows)
		//		{
		//			if (!dataReader.IsDBNull(0)) { User_id = dataReader.GetInt32(0); }
		//			if (!dataReader.IsDBNull(1)) { Type = dataReader.GetString(1); }
		//			if (!dataReader.IsDBNull(2)) { CurrentStatus = dataReader.GetString(2); }
		//			if (!dataReader.IsDBNull(3)) { Assigned_id = dataReader.GetInt32(3); }
		//			if (!dataReader.IsDBNull(4)) { Date_filed = dataReader.GetDateTime(4); }
		//			if (!dataReader.IsDBNull(5)) { Amount = dataReader.GetDecimal(5); }
		//			if (!dataReader.IsDBNull(6)) { Description = dataReader.GetString(6); }
		//		}
		//	}
		//	catch (Exception err)
		//	{
		//		//it handles any other errors
		//		MessageBox.Show(err.Message, "Claim does not exist");
		//	}
		//	finally
		//	{
		//		Cnn.Close(); //Close connection regardless of any errors or not
		//	}

		//	return (User_id, Type, CurrentStatus, Assigned_id, Date_filed, Amount, Description);
		//}



		//public static bool PushClaimUpdate(int Claim_id, int User_id, string Type, string CurrentStatus, int Assigned_id, DateTime Date_filed, decimal Amount,string Notes, string Description)
		//{
		//	bool success = false;
		//	Cnn = new SqlConnection(strConnection);

		//	try
		//	{
		//		Cnn.Open();
		//		SqlCommand command = new SqlCommand();
		//		command.Connection = Cnn;

  //              command.CommandText =
  //                  "UPDATE dbo.claims SET user_id = @user_id, type_claim = @type_claim, current_status = @current_status, " +
		//				"assigned_manager_id = @assigned_manager_id, date_filed = @date_filed, amount = @amount,notes=@notes, description_name_taken=@description "+
		//			"WHERE claim_id=@claim_id;";


  //              command.Parameters.AddWithValue("@user_id", User_id);
		//		command.Parameters.AddWithValue("@type_claim", Type);
		//		command.Parameters.AddWithValue("@current_status", CurrentStatus);
		//		command.Parameters.AddWithValue("@assigned_manager_id", Assigned_id);
		//		command.Parameters.AddWithValue("@date_filed", Date_filed);
		//		command.Parameters.AddWithValue("@amount", Amount);
		//		command.Parameters.AddWithValue("@claim_id", Claim_id); 
		//		command.Parameters.AddWithValue("@notes", Claim_id);
		//		command.Parameters.AddWithValue("@description", Description);

		//		command.ExecuteNonQuery();

		//		Cnn.Close();
		//		success = true;
		//	}
		//	catch (Exception err)
		//	{
		//		//it handles any other errors
		//		MessageBox.Show(err.Message, "Warning!");
		//	}
		//	return success;
		//}


		//public static int NewClaim(int User_id, string Type, string CurrentStatus, int Assigned_id, DateTime Date_filed, decimal Amount,string Notes, string Description)
		//{
		//	int Id = 0;
		//	Cnn = new SqlConnection(strConnection);

		//	try
		//	{

		//		Cnn.Open();
		//		SqlCommand command = new SqlCommand();
		//		command.Connection = Cnn;

		//		SqlDataReader dataReader;



		//		command.CommandText = 
		//			"INSERT INTO claims(user_id, type_claim, current_status, assigned_manager_id, date_filed, amount, notes, description_name_taken)"+
		//			"VALUES(@user_id, @type_claim, @current_status, @assigned_manager_id, @date_filed, @amount, @notes,  @description);";
		//		command.Parameters.AddWithValue("@user_id", User_id);
		//		command.Parameters.AddWithValue("@type_claim", Type);
		//		command.Parameters.AddWithValue("@current_status", CurrentStatus);
		//		command.Parameters.AddWithValue("@assigned_manager_id", Assigned_id);
		//		command.Parameters.AddWithValue("@date_filed", Date_filed);
		//		command.Parameters.AddWithValue("@amount", Amount);
		//		command.Parameters.AddWithValue("@notes", Notes);
		//		command.Parameters.AddWithValue("@description", Description);

		//		command.ExecuteNonQuery();
		//		command.Parameters.Clear(); //clear previous parameter values

		//		command.CommandText =
		//			"select Max(claim_id) from claims where user_id = @user_id";
		//		command.Parameters.AddWithValue("@user_id", User_id);

		//		dataReader = command.ExecuteReader();
  //              dataReader.Read();
  //              Id = dataReader.GetInt32(0);
		//		dataReader.Close();

		//		command.Parameters.Clear(); //clear previous parameter values

		//		command.CommandText =
		//			"UPDATE files SET claim_id = @claim_id WHERE user_id = @user_id AND claim_id = 0; ";
		//		command.Parameters.AddWithValue("@user_id", User_id);
		//		command.Parameters.AddWithValue("@claim_id", Id);
		//		command.ExecuteNonQuery();



		//		Cnn.Close();
		//	}
		//	catch (Exception err)
		//	{
		//		//it handles any other errors
		//		MessageBox.Show(err.Message, "Warning!");
		//	}
		//	return Id;
		//}
		//public static List<clsClaimUpdate> FetchClaimUpdatesForList(int claim_id)
		//{
		//	//declare a list of clsClaimUpdate objects
		//	List<clsClaimUpdate> ClaimUpdates;

		//	ClaimUpdates = new List<clsClaimUpdate>(); //instantiate the clsClaimUpdate list

		//	try //error handling
		//	{

		//		clsClaimUpdate tempUpdate;

		//		Cnn = new SqlConnection(strConnection);
		//		Cnn.Open();

		//		SqlCommand sqlCommand = new SqlCommand("SELECT * FROM claim_updates WHERE claim_id=@claim_id", Cnn);
		//		sqlCommand.Parameters.AddWithValue("@claim_id", claim_id);

		//		SqlDataReader reader = sqlCommand.ExecuteReader();

		//		while (reader.Read())
		//		{
		//			claim_id = (int)reader["claim_id"];
		//			string current_status = (string)reader["current_status"];
		//			DateTime date_filed = (DateTime)reader["date_filed"];
		//			int manager_id = (int)reader["manager_id"];

		//			tempUpdate = new clsClaimUpdate(claim_id, current_status, date_filed, manager_id);

		//			ClaimUpdates.Add(tempUpdate);
		//		}
		//	}
		//	catch (Exception err)
		//	{
		//		MessageBox.Show(err.Message, "Something went wrong with loading data from the database!");

		//	}
		//	finally
		//	{
		//		Cnn.Close();

		//	}

		//	return ClaimUpdates;
		//}
		//public static void PushClaimUpdatesList(List<clsClaimUpdate> claimUpdates)
		//{
		//	try
		//	{
		//		Cnn = new SqlConnection(strConnection);
		//		Cnn.Open();

		//		SqlCommand cmd =
		//			new SqlCommand(
		//				"INSERT INTO dbo.claim_updates (claim_id, current_status, date_filed, manager_id)"+
		//				"VALUES(@claim_id, @current_status, @date_filed, @manager_id); ");
		//		cmd.Connection = Cnn;

		//		//traverse the list of employees
		//		foreach (var update in claimUpdates)
		//		{
		//			cmd.Parameters.Clear(); //clear previous parameter values

		//			//populate the query parameters with actual values taken from each Employee object
		//			cmd.Parameters.AddWithValue("@claim_id", update.Claim_id);
		//			cmd.Parameters.AddWithValue("@current_status", update.CurrentStatus);
		//			cmd.Parameters.AddWithValue("@date_filed", update.Date_filed);
		//			cmd.Parameters.AddWithValue("@manager_id", update.Assigned_id);

		//			cmd.ExecuteNonQuery();

		//		}

		//	}
		//	catch (Exception err)
		//	{
		//		MessageBox.Show(err.Message, "Something went wrong with inserting data to the database!");

		//	}
		//	finally
		//	{
		//		Cnn.Close();
		//	}
		//}









		//public static List<clsClaim> FetchClaimsForList(int Id)
		//{
		//	//declare a list of clsClaim objects
		//	List<clsClaim> Claims;

		//	Claims = new List<clsClaim>(); //instantiate the clsClaim list

		//	try //error handling
		//	{

		//		clsClaim tempClaim;

				
		//		Cnn = new SqlConnection(strConnection);
		//		Cnn.Open();

		//		SqlCommand sqlCommand = new SqlCommand("SELECT * FROM claims WHERE user_id=@user_id", Cnn);
		//		sqlCommand.Parameters.AddWithValue("@user_id", Id);

		//		SqlDataReader reader = sqlCommand.ExecuteReader();

		//		while (reader.Read())
		//		{
		//			tempClaim = new clsClaim();

  //                  tempClaim.Claim_id =  !reader.IsDBNull(0) ? (int)reader["claim_id"] : 0;
		//			tempClaim.User_id = !reader.IsDBNull(1) ? (int)reader["user_id"] : 0 ;
		//			tempClaim.Type= !reader.IsDBNull(2) ? (string)reader["type_claim"] : "";
		//			tempClaim.CurrentStatus  = !reader.IsDBNull(3) ? (string)reader["current_status"] : "";
		//			tempClaim.Assigned_id = !reader.IsDBNull(4) ? (int)reader["assigned_manager_id"] : 0;
		//			tempClaim.Date_filed = !reader.IsDBNull(5) ? (DateTime)reader["date_filed"] : DateTime.MaxValue;
		//			tempClaim.Amount = !reader.IsDBNull(6) ? (decimal)reader["amount"] : -1;
		//			tempClaim.Notes = !reader.IsDBNull(7) ? (string)reader["notes"] : "";
		//			tempClaim.Description = !reader.IsDBNull(8) ? (string)reader["description_name_taken"] : "";

		//			Claims.Add(tempClaim);
		//		}
		//	}
		//	catch (Exception err)
		//	{
		//		MessageBox.Show(err.Message, "Something went wrong with loading data from the database!");

		//	}
		//	finally
		//	{
		//		Cnn.Close();

		//	}

		//	return Claims;
		//}
		//public static bool PushClaimsList(List<clsClaim> Claims)
		//{
		//	bool success = false;
		//	try
		//	{
				
		//		Cnn = new SqlConnection(strConnection);
		//		Cnn.Open();

		//		SqlCommand cmd =
		//			new SqlCommand(
		//				"INSERT INTO dbo.claims (user_id, type_claim, current_status,assigned_manager_id,"+
		//					"date_filed, amount, notes, description_name_taken)" +
		//				"VALUES(@user_idtype_claim, @current_status, @assigned_manager_id, @date_filed, @amount"+
		//					"@notes, @description"); 

		//		cmd.Connection = Cnn;

		//		SqlCommand command = 
		//			new SqlCommand(
		//				"UPDATE claims SET user_id=@user_idX, type_claim=@type_claimX, current_status=@current_statusX, "+
		//				"assigned_manager_id=@assigned_manager_idX, date_filed=@date_filedX, amount=@amountX, notes=@notes, "+
		//				"description_name_taken=@descriptionX;");
		//		//traverse the list of claims
		//		foreach (var clm in Claims)
		//		{
		//			if (clm.Claim_id == 0)
  //                  {
		//				cmd.Parameters.Clear(); //clear previous parameter values

		//				//populate the query parameters with actual values taken from each Employee object
		//				cmd.Parameters.AddWithValue("@user_id", clm.User_id);
		//				cmd.Parameters.AddWithValue("@type_claim", clm.Type);
		//				cmd.Parameters.AddWithValue("@current_status", clm.CurrentStatus);
		//				cmd.Parameters.AddWithValue("@assigned_manager_id", clm.Assigned_id);
		//				cmd.Parameters.AddWithValue("@date_filed", clm.Date_filed);
		//				cmd.Parameters.AddWithValue("@amount", clm.Amount);
		//				cmd.Parameters.AddWithValue("@notes", clm.Notes);
		//				cmd.Parameters.AddWithValue("@description", clm.Description);

		//				cmd.ExecuteNonQuery();
		//			}
		//			else
  //                  {
		//				command.Parameters.Clear(); //clear previous parameter values

		//				command.Parameters.AddWithValue("@claim_id", clm.Claim_id);
		//				command.Parameters.AddWithValue("@user_idX", clm.User_id);
		//				command.Parameters.AddWithValue("@type_claimX", clm.Type);
		//				command.Parameters.AddWithValue("@current_statusX", clm.CurrentStatus);
		//				command.Parameters.AddWithValue("@assigned_manager_idX", clm.Assigned_id);
		//				command.Parameters.AddWithValue("@date_filedX", clm.Date_filed);
		//				command.Parameters.AddWithValue("@amountX", clm.Amount);
		//				command.Parameters.AddWithValue("@notes", clm.Notes);
		//				command.Parameters.AddWithValue("@descriptionX", clm.Description);

		//				command.ExecuteNonQuery();
		//			}

		//		}
		//		success = true;
		//	}
		//	catch (Exception err)
		//	{
		//		MessageBox.Show(err.Message, "Something went wrong with inserting data to the database!");

		//	}
		//	finally
		//	{
		//		Cnn.Close();
		//	}
		//	return success;
		//}
	}
}
