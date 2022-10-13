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
    public partial class mainMenu : Form
    {
        Form next_window;
        public mainMenu()
        {
            InitializeComponent();
        }
        private void LoginPage_Load(object sender, EventArgs e)
        {
        }

        private void IdeaGenBTN_Click(object sender, EventArgs e)
        {
            next_window = new IdeaGeneratorLoginLabel(this);
        }

        private void RelationshipManagerBTN_Click(object sender, EventArgs e)
        {
            RelationshipManagerLogin rm_window = new RelationshipManagerLogin(this);
        }

        private void CreateAccountBTN_Click(object sender, EventArgs e)
        {
            next_window = new Signup(this);
        }
        private void DatabaseDisplay_Click(object sender, EventArgs e)
        {
            next_window = new DatabaseWindow(this);
        }
    }
}
