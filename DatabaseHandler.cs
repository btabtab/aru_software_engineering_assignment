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
		DataBaseLoginEntry dummy_entry;
		
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
			dummy_entry.setID(row_num);
			dummy_entry.setUsername("username_" + row_num);
			dummy_entry.setPassword("password");
			dummy_entry.setEmail("email_" + row_num + "@mail.net");
			//if the row_num is a multiple of 2 the dummy account will be an RM.
			dummy_entry.setIsRelationshipManager((row_num % 2) == 0);
			return dummy_entry;
		}
		public DataBaseLoginEntry searchForEntryBasedOnUsername(string username_search)
		{
			DataBaseLoginEntry ret = new DataBaseLoginEntry();
			ret = database_wrapper;
			return ret;
		}
		//This will return a made up entry with the email based on the searched username and the same username.
		public DataBaseLoginEntry searchForEntryBasedOnEmail(string username_search)
		{
			dummy_entry = generateRandomLoginInfo();
			dummy_entry.setUsername(username_search);
			dummy_entry.setEmail(username_search + "@email.net");
			return dummy_entry;
		}

		public void addNewLogin(DataBaseLoginEntry n_database_login_entry)
		{
			//does nothing, yet.
		}
	}
}