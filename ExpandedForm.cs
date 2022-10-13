using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public class ExpandedForm : Form
{
    protected Form previous_window;
    public ExpandedForm()
    {
    }
    public ExpandedForm(ExpandedForm n_previous_window)
    {
        this.Show();
        previous_window = n_previous_window;
        previous_window.Hide();
    }
}
