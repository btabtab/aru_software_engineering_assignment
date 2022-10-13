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
            //sets some variabels equal to each input from the sign up page - L
            String usernameString = LoginGetter.Text;
            String passwordString1 = PasswordGetter1.Text;
            String passwordString2 = PasswordGetter2.Text;
            String emailEntry = EmailGetter.Text;


            //EMAIL CODE
            Boolean emailContain = emailEntry.Contains("@"); //Checks if the text entered into the email entry point contains the correct symbol.
            if (emailContain == true) //If the email contains the correct symbol - L
            {
                outputTestLabel.Text = "Email is valid";
            }
            else //If the email does not contain the correct symbol - L
            {
                outputTestLabel.Text = "Email is not valid";
            }
            //EMAIL CODE

            //PASSWORD CODE
            bool passNotMatch = Convert.ToBoolean(string.Compare(passwordString1, passwordString2)); //Compares if the passwords match - L
            if (passNotMatch == true) //If the passwords do not match, do the following code - L
            {
                outputTestLabel.Text = "passes are not the same";
            }
            else //If the passwords do match, do the following code - L
            {
                outputTestLabel.Text = "passes are the same";
            }
            //PASSWORD CODE

        }


        private void GoBackButton_Click(object sender, EventArgs e)
        {

        }
        
        private void RM_backButton_Click(object sender, EventArgs e)
        {
            manager.back();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmailGetter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
