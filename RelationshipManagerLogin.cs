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
    public partial class RelationshipManagerLogin : ExpandedForm
    {
        public RelationshipManagerLogin(Form n_previous_window)
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RMlogin_Click(object sender, EventArgs e)
        {

        }

        private void RM_login_backbutton_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RM_login_manager_Click(object sender, EventArgs e)
        {
            this.Hide();
            RelationshipManagerLogin rm_window = new RelationshipManagerLogin(this);
            rm_window.Show();
        }

        private void RM_backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            previous_window.Show();
            this.Close();
        }
    }
}
