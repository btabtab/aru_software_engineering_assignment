using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aru_software_eng_UI
{
	public class BackendController
	{
		LoginDatabaseHandler			login_handler;
		InvestmentIdeaDatabaseHandler	investment_idea_handler;

		private BackendController()
		{
			login_handler			= LoginDatabaseHandler.getInstance();
			investment_idea_handler = InvestmentIdeaDatabaseHandler.getInstance();
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
		public DataBaseLoginEntry loginSearchID(int ID)
        {
			return login_handler.getLoginEntryFromID(ID);
        }
		public DataBaseLoginEntry loginSearchEmail(string search)
        {
			return login_handler.getLoginEntryFromUsername(search);
		}
		public DataBaseLoginEntry loginSearchUsername(string search)
        {
			return login_handler.getLoginEntryFromEmail(search);
		}
		//this writes a new login into the database. -J
		public void writeLoginDatabaseEntry(DataBaseLoginEntry n_database_login_entry)
        {
			login_handler.addNewLogin(n_database_login_entry);
        }
		public void deleteUserFromLoginTable(string username)
        {
			login_handler.deleteLoginRowX(login_handler.getLoginEntryFromUsername(username).getID());
        }

		public int getLoginTableRowCount()
        {
			return login_handler.getRowCount(DatabaseWrapper.LoginEntries);
        }
		public DataBaseLoginEntry getHighestUserIDEntry()
        {
			return login_handler.getLoginEntryFromID(login_handler.getHighestID(DatabaseWrapper.LoginEntries));
		}
		public void deleteHighestLoginID()
        {
			login_handler.deleteLoginRowX(login_handler.getHighestID(DatabaseWrapper.LoginEntries));
        }
	}
}