using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aru_software_eng_UI
{
	/*
	 * This is a class that will carry the content of each entry.
	 * This way it can be a return type wich will simplify
	 * the process massively.
	*/
	
	public class DatabaseHandler
	{
		DatabaseWrapper database_wrapper;
		
		/* This is a blank entry that can be grabbed for testing sake
		while the database controller is being worked on. */
		
		private DatabaseHandler()
		{
			database_wrapper = DatabaseWrapper.getDatabaseWrapperInstance();
		}

		static DatabaseHandler singleton_instance;
		static public DatabaseHandler getInstance()
        {
			if(singleton_instance == null)
            {
				singleton_instance = new DatabaseHandler();
			}
			return singleton_instance;

		}
		/*
		 * (as of now)
		 * This will return a login entry that
		 * will contain made up info based on the rown num.
		*/
		public DataBaseLoginEntry getRowXofLoginData(int row_num)
		{
			return new DataBaseLoginEntry();
		}
		public DataBaseLoginEntry searchForEntryBasedOnUsername(string username_search)
		{
			return database_wrapper.getLoginEntryFromUsername(username_search);
		}
		//This will return a made up entry with the email based on the searched username and the same username.
		public DataBaseLoginEntry searchForEntryBasedOnEmail(string email_search)
		{
			return database_wrapper.getLoginEntryFromEmail(email_search);
		}

		public DataBaseLoginEntry searchForEntryBasedOnLogin(string login_entry, string password)
        {
			dummy_entry = searchForEntryBasedOnEmail(login_entry);
			dummy_entry.setPassword(password);
			return dummy_entry;


		}

		public void addNewLogin(DataBaseLoginEntry n_database_login_entry)
		{
			database_wrapper.writeNewLoginDataEntry(n_database_login_entry);
		}
		public void deleteLoginRowX(int target_row)
        {
			database_wrapper.deleteRowX("LoginEntries", target_row);
        }
		public int getRowCount(string table)
        {
			return database_wrapper.getRowCount(table);
        }
		public int getHighestID(string target_table)
        {
			return database_wrapper.getHighestIDNumber(target_table);
        }
	}
}