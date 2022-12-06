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
    public partial class RelationshipManagerLogin : Form
    {
        FormManager manager;
        Form next_window;
        BackendController backend_controller;
        public RelationshipManagerLogin(Form n_previous_window)
        {
            InitializeComponent();
            manager = new FormManager(n_previous_window, this);
            backend_controller = BackendController.getInstance();
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
            next_window = new FilterWindow(this, backend_controller.loginSearchUsername(RM_login_name_entry.Text));
            // Get username  
            string username = RM_login_name_entry.Text;
            // Get password
            string password = RM_login_password_entry.Text;
            DataBaseLoginEntry login_entry = backend_controller.loginSearchUsername(username);
            if ((login_entry.getEmail() == username || login_entry.getUsername() == username) && login_entry.getPassword() == password)
            {
                // redirect to Idea Submitter page
                next_window = new IdeaSubmitterForm(this, backend_controller);
            }


        }

        private void RM_backButton_Click(object sender, EventArgs e)
        {
            manager.back(); 
        }

        private void RelationshipManagerLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
