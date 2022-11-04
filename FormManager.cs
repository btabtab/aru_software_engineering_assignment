using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*This is a simple manager to aid moving between forms.
 * to put it simply, it stores the last window and the current window.
 * upon construction:
 *		it auto displays the current window, and hides the old window
 *	
 *	upon "back()":
 *		hides the current window and then reopens the previous window.
 *
 */
public class FormManager
{
	protected Form previous_window, current;
	public FormManager(Form n_previous_window, Form n_current)
	{
		current = n_current;
		previous_window = n_previous_window;
		current.Show();
		previous_window.Hide();
	}

	public void back()
	{
		current.Hide();
		current.Close();
		previous_window.Show();
	}
}
