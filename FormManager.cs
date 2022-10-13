using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
