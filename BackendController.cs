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
			//database_handler = DatabaseHandler.;
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
		public void deleteUserFromLoginTable(string username)
        {
			//database_handler.deleteLoginRowX(database_handler.searchForEntryBasedOnUsername(username).getID());
        }
		public int getLoginTableRowCount()
        {
			return 0;
			//return database_handler.getRowCount("LoginEntries");
        }
		public void deleteHighestLoginID()
        {
			//database_handler.deleteLoginRowX(database_handler.getHighestID("LoginEntries"));
        }
	}
}