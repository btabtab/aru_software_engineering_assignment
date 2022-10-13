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
    public partial class Signup : Form
    {

        FormManager manager;
        public Signup(Form n_previous_window)
        {
            InitializeComponent();
            manager = new FormManager(n_previous_window, this);
        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            String usernameString = LoginGetter.Container.ToString();
            Console.WriteLine(usernameString);

        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {

        }
        
        private void RM_backButton_Click(object sender, EventArgs e)
        {
            manager.back();
        }
    }
}
