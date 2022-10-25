using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace aru_software_eng_UI
{
	/*
	 This will wrap around the database and make it humane to interact with.
	-J 24/10/2022
	*/
	class DatabaseWrapper
	{
		private SqlConnection connection_to_database;

		private DatabaseWrapper()
		{
			connection_to_database = new SqlConnection(Properties.Settings.Default.database_connection_string);
		}

		static DatabaseWrapper singleton_instance;
		//This is the only way to access the only existing instance of the class for singleton design reasons.
		public static DatabaseWrapper getDatabaseWrapperInstance()
		{
			if(singleton_instance == null)
			{
				singleton_instance = new DatabaseWrapper();
			}
			return singleton_instance;
		}

		private string searchDatabaseForString(string column_to_search, string target_table, string search_string)
		{
			string ret = null;

			string oString = "Select " + column_to_search + " FROM " + target_table;
			SqlCommand oCmd = new SqlCommand(oString, connection_to_database);
			oCmd.Parameters.AddWithValue("@search_string", search_string);
			connection_to_database.Open();
			SqlDataReader oReader = oCmd.ExecuteReader();
			while (oReader.Read())
			{
				ret = oReader["search_string"].ToString();
			}
			connection_to_database.Close();
			return ret; 
		}

		public DataBaseLoginEntry getLoginEntryFromUsername(string username)
        {
			DataBaseLoginEntry ret = new DataBaseLoginEntry();

			return ret;
        }
	}
}
