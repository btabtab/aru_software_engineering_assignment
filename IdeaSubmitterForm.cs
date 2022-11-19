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
    public partial class IdeaSubmitterForm : Form
    {
        Form next_window;
        FormManager manager;
        BackendController backend_controller;
        public IdeaSubmitterForm(Form n_previous_window, BackendController n_backend_controller)
        {
            InitializeComponent();
            manager = new FormManager(n_previous_window, this);
            backend_controller = n_backend_controller;
        }

        private void IdeaSubmitterForm_Load(object sender, EventArgs e)
        {

        }

        private void New_Idea_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
