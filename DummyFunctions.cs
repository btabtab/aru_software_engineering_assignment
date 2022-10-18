/*
This is to stand between the UI and the backend so as to
allow for easy integration between UI and functionality.

Structure:
UI -> UIBackendInterface -> everything else.
*/
public class UIBackendInterface
{
	public UIBackendInterface()
	{
	}

	public int getMatchingUsernameID(string user_input)
	{
		return 0;
	}
	public bool isUserNameCorrect(string user_input)
	{
		return false;
	}
	public bool isPasswordCorrect(string password_input, int username_ID)
	{
		return false;
	}
}