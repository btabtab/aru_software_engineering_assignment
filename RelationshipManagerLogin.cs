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
        BackendController backend_controller;
        public RelationshipManagerLogin(Form n_previous_window)
        {
            InitializeComponent();
            manager = new FormManager(n_previous_window, this);
            backend_controller = BackendController.getInstance();
        }
        private void RM_login_manager_Click(object sender, EventArgs e)
        {
            // Get username  
            string username = RM_login_name_entry.Text;
            // Get password
            string password = RM_login_password_entry.Text;
            DataBaseLoginEntry login_entry = backend_controller.loginSearchUsername(username);
            if(login_entry.getUsername() != null || login_entry.getPassword() != null)
            {
                if(!login_entry.getIsRelationshipManager())
                {
                    MessageBox.Show("Not a relationship manager", "Not an RM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (login_entry.getUsername().Equals(username) && login_entry.getPassword().Equals(password))
                {
                    new FilterWindow(this, backend_controller.loginSearchUsername(RM_login_name_entry.Text));
                }
                else
                {
                    MessageBox.Show("Please enter a valid Username / Password", "Invalid Username / Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username / Password is NULL", "Invalid Username / Password as they are NULL (possibly doesn't exist?)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RM_backButton_Click(object sender, EventArgs e)
        {
            manager.back();
        }
        private void RM_login_name_entry_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(RM_login_name_entry.Text))
            {
                e.Cancel = true;
                RM_login_name_entry.Focus();
                errorProvider1.SetError(RM_login_name_entry, "Please enter your username: ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(RM_login_name_entry, null);

            }
        }
    }
}