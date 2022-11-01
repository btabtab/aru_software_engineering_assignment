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
		static public DatabaseHandler getDatabaseHandlerInstance()
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
			DataBaseLoginEntry ret = database_wrapper.getLoginEntryFromUsername(username_search);
			return ret;
		}
		//This will return a made up entry with the email based on the searched username and the same username.
		public DataBaseLoginEntry searchForEntryBasedOnEmail(string username_search)
		{
			return new DataBaseLoginEntry();
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
	}
}