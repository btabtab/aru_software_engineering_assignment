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

		/*
		 * Constants to help aid in accessing the databases.
		 * 
		 * -[ John | SID: 2118490 ]
		 */
		public const string LoginEntries = "LoginEntries", InvestmentIdeas = "InvestmentIdeas";

		private SqlConnection connection_to_database;

		/*
		 * A private constructor to stop numerous instances being created.
		 * 
		 * -[ John | SID: 2118490 ]
		 */
		private DatabaseWrapper()
		{
			connection_to_database = new SqlConnection(Properties.Settings.Default.database_connection_string);
		}

		static DatabaseWrapper singleton_instance;
		/*
		 * singleton design pattern, done so as to prevent (bad) redundant copies.
		 * 
		 * -[ John | SID: 2118490 ]
		 */
		public static DatabaseWrapper getDatabaseWrapperInstance()
		{
			if(singleton_instance == null)
			{
				singleton_instance = new DatabaseWrapper();
			}
			return singleton_instance;
		}

		/*
		 * Handles opening and closing the connection to the database.
		 * 
		 * -[ John | SID: 2118490 ]
		 */
		public void openConnection()
		{
			try
			{
				connection_to_database.Open();
			}
			catch(Exception e)
			{
			}

		}

		public void closeConnection()
		{
			try
			{
				connection_to_database.Close();
			}
			catch (Exception e)
			{
				Console.Write("\t!!!\n" + "Database already closed.\n (" + e.Message + ")\n\t!!!");
			}
		}
		/*
		 * This function will make sure that the connection is opened / closed responsibly.
		 * If the connection is open then it will close it, if the connection is closed
		 * then it will open it.
		 * should save time writing try / catches elsewhere.
		 * 
		 * -[ John | SID: 2118490 ]
		 */


		/*
		 * opens the connection and begins the process.
		 * 
		 * -[ John | SID: 2118490 ]
		 */
		private SqlCommand runSQLQuery(string query)
		{
			openConnection();
			SqlCommand ret = new SqlCommand(query, connection_to_database);
			connection_to_database.BeginTransaction().Commit();
			return ret;
		}

		/*
		 * This will stitch together a set of parameters into a single search query.
		 */
		string generateSearchQuery(string column_to_search, string target_table, string search_condition, string search_string)
		{
			return "SELECT " + column_to_search + " FROM " + target_table + " WHERE " + search_condition + "'" + search_string + "'";
		}
		/*
		 * This will search the database for a string matching the
		 * conditions.
		 * 
		 * -[ John | SID: 2118490 ]
		 */
		public string searchDatabaseForString(string column_to_search, string target_table, string search_condition, string search_string)
		{
			string ret = null;

			/*
			 * Assembles an SQL query from the paramaters, makes the process of
			 * writing the query itself much neater and easier to understand.
			 */
			string query = generateSearchQuery(column_to_search, target_table, search_condition, search_string);

			SqlDataReader oReader = runSQLQuery(query).ExecuteReader();

			//Cycles through the rows of the database -JE oct-26.0
			int index = 0;
			while (oReader.Read())
			{
				ret = oReader.GetString(index);
				index++;
			}
			//kills the connection to the database. -JE oct-26.0
			closeConnection();
			return ret;
		}

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
			closeConnection();
			return ret;

		}
		public float searchDataBaseForFloat(string column_to_search, string target_table, string search_condition, string search_string)
		{
			float ret = 0;

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
				ret = (float)oReader.GetDouble(index);
				index++;
			}
			//kills the connection to the database. -JE oct-26.0
			closeConnection();
			return ret;

		}


		public bool searchDatabaseForBool(string column_to_search, string target_table, string search_condition, string search_string)
		{
			//creates a boolean array, and uses ☆ index magic ☆ to return true / false.
			int access_index = searchDataBaseForInt(column_to_search, target_table, search_condition, search_string);
			if(1 < access_index)
			{
				Console.WriteLine("\nWarning:\n\tDatabase entry for boolean has a number that is higher than 1, this is an issue and should be resolved ASAP\n");
				access_index = 1;
			}
			if(access_index < 0)
			{
				Console.WriteLine("\nWarning:\n\tDatabase entry for boolean has a number that is lower than 0, this is an issue and should be resolved ASAP\n");
				access_index = 0;
			}
			return (new bool[2] { false, true })[access_index];
		}

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
			closeConnection();
			return ret;
        }
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

		public void insertNewEntryIntoDatabase(string target_table, List<string> columns_list, List<string> values_list)
		{
			string column_string = compileListIntoFormattedString(columns_list, false), values_string = compileListIntoFormattedString(values_list, true);

			// "INSERT INTO table_name VALUES (value1, value2, value3, ...); "
			string query_string = "INSERT INTO " + target_table + " (" + column_string + ") VALUES (" + values_string + ");";

			Console.WriteLine(query_string);
			SqlCommand oCmd = runSQLQuery(query_string);

			oCmd.ExecuteReader();
			closeConnection();
		}

		public int getRowCount(string target_table)
		{
			//SELECT COUNT(*) FROM tablename
			SqlCommand oCmd = runSQLQuery("SELECT COUNT(*) FROM " + target_table);
			int ret = (int)(Int32)oCmd.ExecuteScalar();
			closeConnection();
			return ret;
		}
		public Int32 getHighestIDNumber(string target_table, string ID_column_name)
		{
			if (getRowCount(target_table) == 0)
			{
				return 0;
			}
			openConnection();
			//SELECT COUNT(*) FROM tablename
			SqlCommand oCmd = runSQLQuery("SELECT MAX(" + ID_column_name + ") FROM " + target_table);
			int ret = (int)(Int32)oCmd.ExecuteScalar().GetHashCode();
			closeConnection();
			Console.Out.WriteLine("::: highest ID in table " + target_table + " in column: " + ID_column_name + " = " + ret + " ::: @ >>> !");
			return ret;
		}

		public void deleteRowX(string target_table, string target_column_name, int row_num)
		{
			{
				row_num = getHighestIDNumber(target_table, target_column_name);
			}
			// DELETE FROM table WHERE column = 'value';

			string query_string = "DELETE FROM " + target_table + " WHERE " + target_column_name + "=" + row_num;
			Console.WriteLine(query_string);
			SqlCommand oCmd = runSQLQuery(query_string);
			oCmd.ExecuteReader();
			
			closeConnection();

		}
	}
}
