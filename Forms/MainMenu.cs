using System.Windows.Forms;
using System;

//This controls the form for the main menu.
public class MainMenu : FormWindow
{
	public MainMenu(UIBackendInterface n_uib_interface)
	{
		uibinterface = n_uib_interface;
		formLayout("Main Menu");
	}
}