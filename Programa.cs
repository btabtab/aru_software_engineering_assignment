using System;
using System.Windows.Forms;

/*The only class functions that you are allowed to run in
the windows are the ones directly from the UIBackendInterface
instance created here.*/

public class Program
{
	[STAThread]
	static void Main(string[] args)
	{
		DummyDataBaseSystem	database = new DummyDataBaseSystem();
		UIBackendInterface uib_interface = new UIBackendInterface(database);
		FormWindow main_menu = new MainMenu(uib_interface);
		Application.Run(main_menu);
	}
}