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
	public class DatabaseWrapper
	{

		/**/
		public const string LoginEntries = "LoginEntries", InvestmentIdeas = "InvestmentIdeas";

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
		public string searchDatabaseForString(string column_to_search, string target_table, string search_condition, string search_string)
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

		/**/
		public int searchDataBaseForInt(string column_to_search, string target_table, string search_condition, string search_string)
        {
			int ret = 0;

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
				ret = oReader.GetInt32(index);
				index++;
			}
			//kills the connection to the database. -JE oct-26.0
			connection_to_database.Close();
			return ret;

		}

		/**/
		public bool searchDatabaseForBool(string column_to_search, string target_table, string search_condition, string search_string)
		{
			//creates a boolean array, and uses ☆ index magic ☆ to return true / false.
			return (new bool[2] { false, true })[searchDataBaseForInt(column_to_search, target_table, search_condition, search_string)];
		}

		/**/
		public DateTime searchDatabaseForDateTime(string column_to_search, string target_table, string search_condition, string search_string)
        {
			DateTime ret = new DateTime();
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
				ret = oReader.GetDateTime(index);
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
			connection_to_database.BeginTransaction().Commit();
			return ret;
		}

		/**/
		public void closeConnection()
        {
			connection_to_database.Close();
        }
		/*For the following functions I will need to implement a set of fixes,
		 *comments and documentation as well as refactoring due to the code
		 *being a bit messy.
		 *
		 *	-JE oct-30.0
		 */

		/*compiles the set of values / columns into a string for the SQL query.
		 *if it is compiling a set of values into a string then "is_value_table" needs to be true.
		 *
		 *	-JE oct-30.0
		 */
		private string compileListIntoFormattedString(List<string> target, bool mark_with_apostrophe)
        {
			string ret = "";
			for (int i = 0; i != (target.Count - 1); i++)
			{
				//probably a smarter way to deal with this, future John can figure that out.
				if(mark_with_apostrophe)
                {
					ret += "'" + (target.ElementAt(i) + "', ");
				}
				else
                {
					ret += (target.ElementAt(i) + ", ");
				}
			}
			if (mark_with_apostrophe)
            {
				ret += "'" + (target.ElementAt(target.Count - 1) + "'");
			}
			else
			{ 
				ret += (target.ElementAt(target.Count - 1));
			}
			return ret;
        }
		//inserts a new entry into a table based around columns and values. -JE oct-30.0
		public void insertNewEntryIntoDatabase(string target_table, List<string> columns_list, List<string> values_list)
		{
			string column_string = compileListIntoFormattedString(columns_list, false), values_string = compileListIntoFormattedString(values_list, true);

			// "INSERT INTO table_name VALUES (value1, value2, value3, ...); "
			string query_string = "INSERT INTO " + target_table + " (" + column_string + ") VALUES (" + values_string + ");";

			Console.WriteLine(query_string);
			SqlCommand oCmd = runSQLQuery(query_string);

			oCmd.ExecuteReader();
			connection_to_database.Close();

		}
		//gets the amount of rows in the database. -JE oct-31.0
		public int getRowCount(string target_table)
		{
			//SELECT COUNT(*) FROM tablename
			SqlCommand oCmd = runSQLQuery("SELECT COUNT(*) FROM " + target_table);
			int ret = (int)(Int32)oCmd.ExecuteScalar();
			closeConnection();
			return ret;
		}
		//deletes the targeted row. -JE oct-31.0
		public void deleteRowX(string target_table, int row_num)
		{
			{
				row_num = getHighestIDNumber(target_table, "UserID");
			}
			// DELETE FROM table WHERE column = 'value';

			string query_string = "DELETE FROM " + target_table + " WHERE UserID=" + row_num;
			Console.WriteLine(query_string);
			SqlCommand oCmd = runSQLQuery(query_string);
			oCmd.ExecuteReader();

			connection_to_database.Close();

		}

		/**/
		public Int32 getHighestIDNumber(string target_table, string ID_column_name)
		{
			if (getRowCount(target_table) == 0)
			{
				return 0;
			}
			//SELECT COUNT(*) FROM tablename
			SqlCommand oCmd = runSQLQuery("SELECT MAX(" + ID_column_name + ") FROM " + target_table);
			int ret = (int)(Int32)oCmd.ExecuteScalar().GetHashCode();
			closeConnection();
			Console.Out.WriteLine("::: " + ret + " ::: @ >>> !");
			return ret;
		}
		//converts bool from LoginEntryClass to string for the table input. -JE oct-30.0
		
	}
}
