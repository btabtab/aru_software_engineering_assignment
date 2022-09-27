/*
This is to stand between the UI and the backend so as to
allow for easy integration between UI and functionality.

Structure:
UI -> UIBackendInterface -> everything else.
*/
public class UIBackendInterface
{
	DummyDataBaseSystem database;
	public UIBackendInterface(DummyDataBaseSystem n_database)
	{
		database = n_database;
	}

	public bool isUserNameCorrect(string user_input)
	{
		for(int i = 0; i != database.getNumberOfAccounts(); i++)
		{
			if(database.grabAccountName(i).Equals(user_input))
			{
				return true;
			}
		}
		return false;
	}
	public bool isPasswordCorrect(string user_input, int username_ID)
	{
		for(int i = 0; i != database.getNumberOfAccounts(); i++)
		{
			if(database.grabAccountName(i).Equals(user_input))
			{
				return true;
			}
		}
		return false;
	}

}