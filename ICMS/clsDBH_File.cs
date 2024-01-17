using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ICMS
{
    public class clsDBH_File : clsInheritanceDatabase
    {

		public static clsFile FetchFile(int File_id)
		{
			clsFile file = new clsFile();
			SqlCommand command = new SqlCommand();

			try
			{
				clsDBH_File.Cnn.Open();

				command.Connection = clsDBH_File.Cnn;
				command.CommandText =
					"SELECT  file_data, file_name, file_type, claim_id from files where file_id = @file_id;";
				command.Parameters.AddWithValue("@file_id", File_id);
				SqlDataReader dataReader;

				dataReader = command.ExecuteReader();

				if (dataReader.Read())
				{

					if (!dataReader.IsDBNull(0)) { file.Data = (byte[])dataReader.GetSqlBinary(0); }
					if (!dataReader.IsDBNull(1)) { file.File_name = dataReader.GetString(1); }
					if (!dataReader.IsDBNull(2)) { file.File_type = dataReader.GetString(2); }
					if (!dataReader.IsDBNull(3)) { file.File_id = dataReader.GetInt32(3); }


				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message.ToString());
			}
			finally { clsDBH_File.Cnn.Close(); }




			return file;
		}
		public static clsFile FetchFile(clsFile file)
		{

			SqlCommand command = new SqlCommand();

			try
			{
				clsDBH_File.Cnn.Open();

				command.Connection = clsDBH_File.Cnn;
				command.CommandText =
					"SELECT  file_data, file_name, file_type, claim_id from files where file_id = @file_id;";
				command.Parameters.AddWithValue("@file_id", file.File_id);
				SqlDataReader dataReader;

				dataReader = command.ExecuteReader();

				if (dataReader.Read())
				{
					if (!dataReader.IsDBNull(0)) { file.Data = (byte[])dataReader.GetSqlBinary(0); }
					if (!dataReader.IsDBNull(1)) { file.File_name = dataReader.GetString(1); }
					if (!dataReader.IsDBNull(2)) { file.File_type = dataReader.GetString(2); }
					if (!dataReader.IsDBNull(3)) { file.File_id = dataReader.GetInt32(3); }
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message.ToString());
			}
			finally { clsDBH_File.Cnn.Close(); }




			return file;
		}


	}
}
