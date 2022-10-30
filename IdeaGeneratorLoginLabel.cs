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
    public partial class IdeaGeneratorLoginLabel : Form
    {
        Form next_window;
        FormManager manager;
        BackendController backend_controller;
        public IdeaGeneratorLoginLabel(Form n_previous_window, BackendController n_backend_controller)
        {
            InitializeComponent();
            manager = new FormManager(n_previous_window, this);
            backend_controller = n_backend_controller;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void IG_Back_Button_Click(object sender, EventArgs e)
        {
            manager.back();
        }

        private void IG_login_button_Click(object sender, EventArgs e)
        {
            // Get username  
            string username = IG_login_textbox.Text;
            // Get password
            string password = IG_password_textbox.Text;
            DataBaseLoginEntry loginEntry = backend_controller.getLoginDetails(username, password);
           if ((loginEntry.getEmail() == username || loginEntry.getUsername() == username) && loginEntry.getPassword() == password)
            {
                // redirect to Idea Submitter page
                // next_window = new IdeaSubmitter(this, backend_controller);
            }
        }
    }
}
