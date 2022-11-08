using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aru_software_eng_UI
{
	public class DataBaseLoginEntry
	{

		int ID;
		string username;
		string password;
		string email;
		bool is_relationship_manager;

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

		public DataBaseLoginEntry(string n_username, string n_password, string n_email, bool n_is_relationship_manager)
		{
			username = n_username;
			password = n_password;
			email = n_email;
			is_relationship_manager = n_is_relationship_manager;
		}

		//These are the getters and setters to the login entry. -John 24/10/2022
		public int getID() { return ID; }
		public string getUsername() { return username; }
		public string getPassword() { return password; }
		public string getEmail() { return email; }
		public bool getIsRelationshipManager() { return is_relationship_manager; }

		public void setID(int n_ID) { ID = n_ID; }
		public void setUsername(string n_username) { username = n_username; }
		public void setPassword(string n_password) { password = n_password; }
		public void setEmail(string n_email) { email = n_email; }
		public void setIsRelationshipManager(bool n_is_relationship_manager) { is_relationship_manager = n_is_relationship_manager; }

		//for simplicity sake.
		public string getAsLabelString()
        {
			return (
				"ID: " + this.ID + "\n" +
				"Username: " + this.username + "\n" +
				"Email: " + this.email + "\n" +
				"Password: " + this.password + "\n" +
				"Is RM manager: [ " + this.is_relationship_manager + " ]"
				);
        }
	}
}
