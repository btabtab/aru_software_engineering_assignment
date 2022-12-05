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

        private LoginDatabaseHandler() : base()
		{
			database_wrapper = DatabaseWrapper.getDatabaseWrapperInstance();
		}


		/**/
		static LoginDatabaseHandler singleton_instance;

		/**/
		new static public LoginDatabaseHandler getInstance()
		{
			if (singleton_instance == null)
			{
				singleton_instance = new LoginDatabaseHandler();
			}
			return singleton_instance;

		}

		/**/
		public void addNewLogin(DataBaseLoginEntry n_database_login_entry)
		{
			writeNewLoginDataEntry(n_database_login_entry);
		}

		/**/
		string rmStatusToString(bool is_rm_manager)
        {
			string ret = "0";

			if(is_rm_manager)
            {
				ret = "1";
            }
			return ret;
		}

		/**/
		public void writeNewLoginDataEntry(DataBaseLoginEntry n_entry)
		{
			List<string> columns = new List<string>(), values = new List<string>();

			columns.Add("UserID");
			values.Add("" + (database_wrapper.getHighestIDNumber(DatabaseWrapper.LoginEntries, "UserID") +1));

			columns.Add("Username");
			columns.Add("Email");
			columns.Add("Password");
			columns.Add("Is_RelationshipManager");

			values.Add(n_entry.getUsername());
			values.Add(n_entry.getEmail());
			values.Add(n_entry.getPassword());
			values.Add(rmStatusToString(n_entry.getIsRelationshipManager()));


			database_wrapper.insertNewEntryIntoDatabase(DatabaseWrapper.LoginEntries, columns, values);
		}

		/**/
		public DataBaseLoginEntry getLoginEntryFromUsername(string username)
		{
			DataBaseLoginEntry ret = new DataBaseLoginEntry(
																database_wrapper.searchDataBaseForInt(	"UserID", 						DatabaseWrapper.LoginEntries, "Username=", username),
																database_wrapper.searchDatabaseForString("Username", 				DatabaseWrapper.LoginEntries, "Username=", username),
																database_wrapper.searchDatabaseForString("Password", 				DatabaseWrapper.LoginEntries, "Username=", username),
																database_wrapper.searchDatabaseForString("Email", 					DatabaseWrapper.LoginEntries, "Username=", username),
																database_wrapper.searchDatabaseForBool(	"Is_RelationshipManager", 	DatabaseWrapper.LoginEntries, "Username=", username)
																);
			return ret;
		}

		/**/
		public DataBaseLoginEntry getLoginEntryFromEmail(string email)
		{
			DataBaseLoginEntry ret = new DataBaseLoginEntry(
																database_wrapper.searchDataBaseForInt("UserID", 						DatabaseWrapper.LoginEntries, "Email=", email),
																database_wrapper.searchDatabaseForString("Username", 				DatabaseWrapper.LoginEntries, "Email=", email),
																database_wrapper.searchDatabaseForString("Password", 				DatabaseWrapper.LoginEntries, "Email=", email),
																database_wrapper.searchDatabaseForString("Email", 					DatabaseWrapper.LoginEntries, "Email=", email),
																database_wrapper.searchDatabaseForBool(	"Is_RelationshipManager", 	DatabaseWrapper.LoginEntries, "Email=", email)
																);
			return ret;
		}

		/**/
		public DataBaseLoginEntry getLoginEntryFromID(int ID)
        {
			DataBaseLoginEntry ret = new DataBaseLoginEntry(
															database_wrapper.searchDataBaseForInt("UserID",								DatabaseWrapper.LoginEntries, "UserID=", ID.ToString()),
															database_wrapper.searchDatabaseForString("Username",					DatabaseWrapper.LoginEntries, "UserID=", ID.ToString()),
															database_wrapper.searchDatabaseForString("Password",					DatabaseWrapper.LoginEntries, "UserID=", ID.ToString()),
															database_wrapper.searchDatabaseForString("Email",						DatabaseWrapper.LoginEntries, "UserID=", ID.ToString()),
															database_wrapper.searchDatabaseForBool("Is_RelationshipManager",		DatabaseWrapper.LoginEntries, "UserID=", ID.ToString())
															);
			return ret;
		}
	}
}
