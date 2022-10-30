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
		public DataBaseLoginEntry()
        {
        }
		public DataBaseLoginEntry(int n_ID, string n_username, string n_password, string n_email, bool n_is_relationship_manager)
		{
			ID = n_ID;
			username = n_username;
			password = n_password;
			email = n_email;
			is_relationship_manager = n_is_relationship_manager;
		}

		int ID;
		string username;
		string password;
		string email;
		bool is_relationship_manager;

		//These are the getters and setters to the login entry. -John 24/10/2022
		public int getID()						{return ID;}
		public string getUsername()				{return username;}
		public string getPassword()				{return password;}
		public string getEmail()				{return email;}
		public bool getIsRelationshipManager()	{return is_relationship_manager;}

		public void setID(int n_ID)												{ID = n_ID; }
		public void setUsername(string n_username)								{username = n_username; }
		public void setPassword(string n_password)								{password = n_password; }
		public void setEmail(string n_email)									{email = n_email; }
		public void setIsRelationshipManager(bool n_is_relationship_manager)	{is_relationship_manager = n_is_relationship_manager; }

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
			dummy_entry.setID(row_num);
			dummy_entry.setUsername("username_" + row_num);
			dummy_entry.setPassword("password");
			dummy_entry.setEmail("email_" + row_num + "@mail.net");
			//if the row_num is a multiple of 2 the dummy account will be an RM.
			dummy_entry.setIsRelationshipManager((row_num % 2) == 0);
			return dummy_entry;
		}
		public DataBaseLoginEntry generateRandomLoginInfo()
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
		public DataBaseLoginEntry searchForEntryBasedOnUsername(string username_search)
		{
			dummy_entry = generateRandomLoginInfo();
			dummy_entry.setUsername(username_search);
			return dummy_entry;
		}
		//This will return a made up entry with the email based on the searched username and the same username.
		public DataBaseLoginEntry searchForEntryBasedOnEmail(string username_search)
		{
			dummy_entry = generateRandomLoginInfo();
			dummy_entry.setUsername(username_search);
			dummy_entry.setEmail(username_search + "@email.net");
			return dummy_entry;
		}

		public DataBaseLoginEntry searchForEntryBasedOnLogin(string login_entry, string password)
        {
			dummy_entry = searchForEntryBasedOnEmail(login_entry);
			dummy_entry.setPassword(password);
			return dummy_entry;


		}

		public void addNewLogin(DataBaseLoginEntry n_database_login_entry)
		{
			//does nothing, yet.
		}
	}
}