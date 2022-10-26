using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
/*
 * File version comment key:
 * st
 * written as:	[-[Initial] x-[month].y]
 * example:		[-J Oct-26.0]
*/
namespace aru_software_eng_UI
{
	/*
	 * A third backend class?????
	 * This class, the database wrapper, is intended to wrap around the database and
	 * integrate with some (poorly understood) SQL commands and provide a nice little
	 * function set with which can be implemented in the higher backend classes which
	 * get implemented into the main form classes.
	-JE oct-26.0
	*/
	class DatabaseWrapper
	{
		//This provides the connection to the database (big shock I know).
		private SqlConnection connection_to_database;

		//A private constructor to stop numerous instances being created.
		private DatabaseWrapper()
		{
			connection_to_database = new SqlConnection(Properties.Settings.Default.database_connection_string);
		}

		static DatabaseWrapper singleton_instance;
		//singleton design pattern, done so as to prevent (bad) redundant copies.
		//	-JE oct-26.0
		public static DatabaseWrapper getDatabaseWrapperInstance()
		{
			if(singleton_instance == null)
			{
				singleton_instance = new DatabaseWrapper();
			}
			return singleton_instance;
		}
		/*
		 * This function will generate an SQL query for the database to find the
		 * contents of a row.
		 * 
		 * Private because it only needs to be called in the class,
		 * there are much prettier, neater and simpler to use functions
		 * that are public and will be connected into the main parts of
		 * the program.
		 * 
		 * variables:
		 *		target_table:
		 *			This is the table being targeted, IE: LoginEntries.
		 *			
		 *		column_to_search:
		 *			this is the desired column that will be scanned through,
		 *			for example "Username".
		 *			
		 *		search_condition:
		 *			What is the goal of the search (for example string equality).
		 *			
		 *		search_string:
		 *			The string that you are searching for.
		 *			
		 *	Example:
		 *		searchDatabaseForString(string column_to_search, string target_table, string search_condition, string search_string)
		 *		searches the [column_to_search] column in [target_table] on the row that has the [search_condition] that matches the search_string.
		 *		
		 *		searchDatabaseForString("Password", login_table, "Username=", search)
		 *		searches the "Password" column in "login_table" on the row that has the "Username=" to the "search".
		 *	
		 *	-JE oct-26.0
		 */
		private string searchDatabaseForString(string column_to_search, string target_table, string search_condition, string search_string)
		{
			string ret = null;

			/*
			 * Assembles an SQL query from the paramaters, makes the process of
			 * writing the query itself much neater and easier to understand.
			 */
			string query_string = "Select " + column_to_search + " FROM " + target_table + " WHERE " + search_condition + "'" + search_string + "'";
			SqlCommand oCmd = runSQLQuery(query_string);

			SqlDataReader oReader = oCmd.ExecuteReader();

			//Cycles through the rows of the database -JE oct-26.0
			int index = 0;
			while (oReader.Read())
			{
				ret = oReader.GetString(index);
				index++;
			}
			//kills the connection to the database. -JE oct-26.0
			connection_to_database.Close();
			return ret; 
		}
		//opens the connection and begins the process. -JE oct-26.0
		private SqlCommand runSQLQuery(string query)
        {
			SqlCommand ret = new SqlCommand(query, connection_to_database);
			connection_to_database.Open();
			return ret;
        }
		private void addNewRow(string target_table, string[] entries, int entry_count)
		{
		}


		public DataBaseLoginEntry getLoginEntryFromUsername(string username)
        {
			string login_table = "LoginEntries";
			DataBaseLoginEntry ret = new DataBaseLoginEntry(
																searchDatabaseForString("Username", login_table, "Username=", username),
																searchDatabaseForString("Password", login_table, "Username=", username),
																searchDatabaseForString("Email",	login_table, "Username=", username),
																searchDatabaseForString("Is_RelationshipManager", login_table, "Email=", email) == "y"
																);
			return ret;
        }
		public DataBaseLoginEntry getLoginEntryFromEmail(string email)
		{
			string login_table = "LoginEntries";
			DataBaseLoginEntry ret = new DataBaseLoginEntry(
																searchDatabaseForString("Username", login_table, "Email=", email),
																searchDatabaseForString("Password", login_table, "Email=", email),
																searchDatabaseForString("Email",	login_table, "Email=", email),
																searchDatabaseForString("Is_RelationshipManager", login_table, "Email=", email) == "y"
																);
			return ret;
		}

	}
}
