using System.Windows.Forms;
using System;

public class FormWindow : Form
{
	protected UIBackendInterface uibinterface;
	public void formLayout(string window_name)
	{
		this.Name = this.Text = window_name;
		this.Size = new System.Drawing.Size(1000, 500);
	}


	public FormWindow()
	{
		formLayout("base window");
		this.StartPosition = FormStartPosition.CenterScreen;
	}
}