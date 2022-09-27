/*
This will exist as a way of pretending there is
a database to enable sanity and validity tests.

This class DOES NOT run any process, checks or anything else.
only gets and sets to check and alter data. Any comparisons and
validation is dealt with by other aspecects.
*/
public class DummyDataBaseSystem
{
	/*
	Basic constructor:
		This will generate the data within the database.
	*/
	//For login testing
	string[] Account_Names;
	string[] Account_Passwords;
	public DummyDataBaseSystem()
	{
		Account_Names = new string[4];
		Account_Passwords = new string[4];
	}

	public string grabAccountName(int i)
	{
		if(i < 0 || Account_Names.Length <= i)
		{
			return "error";
		}
		return Account_Names[i];
	}
	
	public string grabPassword(int i)
	{
		if(i < 0 || Account_Passwords.Length <= i)
		{
			return "error";
		}
		return Account_Passwords[i];
	}

	public int getNumberOfAccounts()
	{
		return Account_Names.Length;
	}
};