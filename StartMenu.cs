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
    public partial class StartMenu : Form
    {
        Form next_window;
        BackendController backend_controller;
        public StartMenu(BackendController n_backend_controller)
        {
            InitializeComponent();
            backend_controller = n_backend_controller;
        }
        private void LoginPage_Load(object sender, EventArgs e)
        {
        }

        private void IdeaGenBTN_Click(object sender, EventArgs e)
        {
            next_window = new IdeaGeneratorLoginLabel(this, backend_controller);
        }

        private void RelationshipManagerBTN_Click(object sender, EventArgs e)
        {
            RelationshipManagerLogin rm_window = new RelationshipManagerLogin(this, backend_controller);
        }

        private void CreateAccountBTN_Click(object sender, EventArgs e)
        {
            next_window = new Signup(this, backend_controller);
        }
        private void DatabaseDisplay_Click(object sender, EventArgs e)
        {
            next_window = new DatabaseWindow(this, backend_controller);
        }

        private void showRMTEST_Click(object sender, EventArgs e)
        {
            next_window = new RelationshipManagerViewerUI(this, backend_controller); 
        }
    }
}
