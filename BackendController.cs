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

		private BackendController()
		{
			database_handler = DatabaseHandler.getInstance();
		}

		static BackendController singleton_instance;
		static public BackendController getInstance()
		{
			if (singleton_instance == null)
			{
				singleton_instance = new BackendController();
			}
			return singleton_instance;

		}

		public DataBaseLoginEntry randomEntry()
		{
			int random_num = new Random().Next(256);
			DataBaseLoginEntry ret = new DataBaseLoginEntry();
			ret.setID(random_num);
			ret.setUsername("username_" + random_num);
			ret.setPassword("password");
			ret.setEmail("email_" + random_num + "@mail.net");
			//if the row_num is a multiple of 2 the dummy account will be an RM.
			ret.setIsRelationshipManager((random_num % 2) == 0);
			return ret;
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

		public void deleteUserFromLoginTable(string username)
        {
			database_handler.deleteLoginRowX(database_handler.searchForEntryBasedOnUsername(username).getID());
        }

		public int getLoginTableRowCount()
        {
			return database_handler.getRowCount("LoginEntries");
        }

		public void deleteHighestLoginID()
        {
			database_handler.deleteLoginRowX(database_handler.getHighestID("LoginEntries"));
        }
		public DataBaseLoginEntry getLoginDetails (string username, string password)
        {

			return database_handler.searchForEntryBasedOnLogin(username, password); 
		}
	}
}