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
		int rm_permission_level;


		/**/
		public DataBaseLoginEntry(int n_ID)
		{
			//using hex notation here cos it's cool
			int random_num = new Random((int)DateTime.Now.Ticks).Next(0, 0xff);
			setID(n_ID);
			setUsername("username_" + random_num);
			setPassword("password" + (random_num >> 1));
			setEmail("email_" + random_num + "@mail.net");
			//if the row_num is a multiple of 2 the dummy account will be an RM. -John
			setIsRelationshipManager((random_num % 2) == 0);
			setRMPermissionLevel(new Random((int)DateTime.Now.Ticks).Next(0, 5));
		}

		/**/
		public DataBaseLoginEntry(int n_ID, string n_username, string n_password, string n_email, bool n_is_relationship_manager)
		{
			ID = n_ID;
			username = n_username;
			password = n_password;
			email = n_email;
			is_relationship_manager = n_is_relationship_manager;
		}

		/**/
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
		public int getRMPermissionLevel() { return rm_permission_level; }

		public void setID(int n_ID) { ID = n_ID; }
		public void setUsername(string n_username) { username = n_username; }
		public void setPassword(string n_password) { password = n_password; }
		public void setEmail(string n_email) { email = n_email; }
		public void setIsRelationshipManager(bool n_is_relationship_manager) { is_relationship_manager = n_is_relationship_manager; }
		public void setRMPermissionLevel(int n_rm_permission_level) { rm_permission_level = n_rm_permission_level; }

		//for simplicity sake.
		public string getAsLabelString()
        {
			return (
				"UserID: " + this.ID + "\n" +
				"Username: " + this.username + "\n" +
				"Email: " + this.email + "\n" +
				"Password: " + this.password + "\n" +
				"Is RM manager: [ " + this.is_relationship_manager + " ]" +
				"RM permission level [" + this.rm_permission_level + " ]"
				);
        }
	}
}
