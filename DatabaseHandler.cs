using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aru_software_eng_UI
{
	public class DatabaseHandler
	{
		protected string table_name;
		/**/
		protected DatabaseWrapper database_wrapper;
		
		/* This is a blank entry that can be grabbed for testing sake
		while the database controller is being worked on. */
		
		protected DatabaseHandler()
		{
			database_wrapper = DatabaseWrapper.getDatabaseWrapperInstance();
		}

		/**/
		static DatabaseHandler singleton_instance;

		/**/
		static public DatabaseHandler getInstance()
        {
			if(singleton_instance == null)
            {
				singleton_instance = new DatabaseHandler();
			}
			return singleton_instance;

		}

		/**/
		public void deleteLoginRowX(int target_row)
        {
			database_wrapper.deleteRowX(DatabaseWrapper.LoginEntries, "UserID", target_row);
		}

		/**/
		public void deleteInvestmentIdeaRowX(int target_row)
        {
			database_wrapper.deleteRowX(DatabaseWrapper.InvestmentIdeas, "ID", target_row);
		}

		/**/
		public int getRowCount()
        {
			return database_wrapper.getRowCount(table_name);
		}

		/**/
		public int getHighestID(string target_table, string name_of_ID_column)
        {
			return database_wrapper.getHighestIDNumber(target_table, name_of_ID_column);
        }
	}
}