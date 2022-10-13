using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aru_software_eng_UI
{
    public partial class DatabaseWindow : Form
    {
        FormManager manager;
        public DatabaseWindow(Form n_previous_window)
        {
            InitializeComponent();
            manager = new FormManager(n_previous_window, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            manager.back();
        }
    }
}
