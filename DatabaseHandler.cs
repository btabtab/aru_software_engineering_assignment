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
	public class DataBaseLoginEntry
	{
		public int ID;
		public string username;
		public string password;
		public string email;
		public bool is_relationship_manager;
	}
	public class DatabaseHandler
	{
		UserDatabaseDataSet dataset;
		
		/* This is a blank entry that can be grabbed for testing sake
		while the database controller is being worked on. */
		DataBaseLoginEntry dummy_entry;
		
		public DatabaseHandler(UserDatabaseDataSet n_dataset)
		{
			dataset = n_dataset;
		}
		/*
		 * (as of now)
		 * This will return a login entry that
		 * will contain made up info based on the rown num.
		*/
		public DataBaseLoginEntry getRowXofLoginData(int row_num)
		{
			dummy_entry.ID = row_num;
			dummy_entry.username = "username_" + row_num;
			dummy_entry.password = "password";
			dummy_entry.email = "email_" + row_num + "@mail.net";
			//if the row_num is a multiple of 2 the dummy account will be an RM.
			dummy_entry.is_relationship_manager = ((row_num % 2) == 0);
			return dummy_entry;
		}
		public DataBaseLoginEntry generateRandomLoginInfo()
		{
			int random_num = new Random().Next(256);
			DataBaseLoginEntry ret = new DataBaseLoginEntry();
			ret.ID = random_num;
			ret.username = "username_" + random_num;
			ret.password = "password";
			ret.email = "email_" + random_num + "@mail.net";
			//if the row_num is a multiple of 2 the dummy account will be an RM.
			ret.is_relationship_manager = ((random_num % 2) == 0);
			return ret;
		}
		public DataBaseLoginEntry searchForEntryBasedOnUsername(string username_search)
		{
			dummy_entry = generateRandomLoginInfo();
			dummy_entry.username = username_search;
			return dummy_entry;
		}
		//This will return a made up entry with the email based on the searched username and the same username.
		public DataBaseLoginEntry searchForEntryBasedOnEmail(string username_search)
		{
			dummy_entry = generateRandomLoginInfo();
			dummy_entry.username = username_search;
			dummy_entry.email = username_search + "@email.net";
			return dummy_entry;
		}
		public void setRowXofLogin(int row_num)
		{
			//does nothing, yet.
		}
	}
}