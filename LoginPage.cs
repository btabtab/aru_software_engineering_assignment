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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void LoginPage_Load(object sender, EventArgs e)
        {
        }

        private void IdeaGenBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RelationshipManagerBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CreateAccountBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DatabaseDisplay_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DatabaseWindow().Show();
        }
    }
}
