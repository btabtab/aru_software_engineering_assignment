using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aru_software_eng_UI
{
	public class BackendController
	{
		DatabaseHandler database_handler;
		public BackendController(DatabaseHandler n_dtbase_hndlr)
		{
			database_handler = n_dtbase_hndlr;
		}

		public DataBaseLoginEntry randomEntry()
        {
			return database_handler.generateRandomLoginInfo();
        }

		public DataBaseLoginEntry loginSearchEmail(string search)
        {
			return database_handler.searchForEntryBasedOnEmail(search);
        }
		public DataBaseLoginEntry loginSearchUsername(string search)
        {
			return database_handler.searchForEntryBasedOnUsername(search);
        }
		//this writes a new login into the database. -J
		public void writeDatabaseEntry(DataBaseLoginEntry n_database_login_entry)
        {
			database_handler.addNewLogin(n_database_login_entry);
        }

		public DataBaseLoginEntry getLoginDetails (string username, string password)
        {

			return database_handler.searchForEntryBasedOnLogin(username, password); 
		}
	}
}