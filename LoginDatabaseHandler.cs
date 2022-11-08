using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aru_software_eng_UI
{
    public class LoginDatabaseHandler : DatabaseHandler
	{
        /* This is a blank entry that can be grabbed for testing sake
		while the database controller is being worked on. */

        private LoginDatabaseHandler()
		{
			database_wrapper = DatabaseWrapper.getDatabaseWrapperInstance();
			database_name = "LoginEntries";
		}

		static LoginDatabaseHandler singleton_instance;
		new static public LoginDatabaseHandler getInstance()
		{
			if (singleton_instance == null)
			{
				singleton_instance = new LoginDatabaseHandler();
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

		public void addNewLogin(DataBaseLoginEntry n_database_login_entry)
		{
			database_wrapper.writeNewLoginDataEntry(n_database_login_entry);
		}
	}
}
