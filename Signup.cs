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
        BackendController backend_controller;
        public Signup(Form n_previous_window)
        {
            InitializeComponent();
            manager = new FormManager(n_previous_window, this);
            backend_controller = BackendController.getInstance();
        }

        private Boolean passwordChecker() 
        {
            string password1 = PasswordGetter1.Text;
            string password2 = PasswordGetter2.Text;
            bool pass_not_match = Convert.ToBoolean(string.Compare(password1, password2)); //Compares if the passwords match - L
            if (pass_not_match == true) //If the passwords do not match, do the following code - L
            {
                errorOutputLabel.Text = "passwords do not match"; //Tell the user their password is wrong - L
                wrongPassSymbol1.Text = "X"; //Add a cross next to the password box - L
                wrongPassSymbol2.Text = "X"; //Add a cross next to the password repeat box - L
                return false;
            }
            else if (password1.Length > 6) //If the passwords do match, do the following code - L
            {
                errorOutputLabel.Text = ""; //clear the error label - L
                wrongPassSymbol1.Text = ""; //remove the cross next to the password box - L
                wrongPassSymbol2.Text = ""; //remove the cross next to the password repeat box - L
                return true;

            }
            else 
            {
                errorOutputLabel.Text = "minimum password length of 7 characters"; //Tell the user their password is wrong - L
                wrongPassSymbol1.Text = "X"; //Add a cross next to the password box - L
                wrongPassSymbol2.Text = "X"; //Add a cross next to the password repeat box - L
                return false;
            }
        }


        private Boolean emailChecker()
        {
            string email = EmailGetter.Text;
            Boolean email_contain = email.Contains("@"); //Checks if the text entered into the email entry point contains the correct symbol - L
            if (email_contain == true) //If the email contains the correct symbol - L
            {
                wrongEmailSymbol.Text = ""; //remove the cross next to the email repeat box - L
                return true;
            }
            else //If the email does not contain the correct symbol - L
            {
                errorOutputLabel.Text = "Email is not valid"; //Tells the user their email is invalid - replaces wrong password text as the email is first on the data entry list - L
                wrongEmailSymbol.Text = "X"; //Add a cross next to the email repeat box - L
                return false;
            }
        }

        private Boolean usernameChecker()
        {
            string username = LoginGetter.Text;
            if (username.Length > 2) //If the username is long enough - L
            {
                usernameWrongSymbol.Text = ""; //clears the cross
                return true;
            }
            else //If the email username is too short - L
            {
                errorOutputLabel.Text = "username must be atleast 3 characters long"; //Tells the user their email is invalid - replaces wrong password text as the email is first on the data entry list - L
                usernameWrongSymbol.Text = "X";
                return false;
            }
        }

        private Boolean checkboxChecker() 
        {
            if (!RulesCheckBox.Checked)
            {
                errorOutputLabel.Text = "please check the rules box";
            }
            return RulesCheckBox.Checked;
        }

        private Boolean credentialChecker() {
           

            if (emailChecker() && passwordChecker() && usernameChecker() && checkboxChecker()) //if all aspects of the form are correct, run the code below - L
            {
                string username = LoginGetter.Text; //Gets username the user entered - L
                string email = EmailGetter.Text; //Gets the email the user entered - L
                if (backend_controller.loginSearchEmail(email).getEmail() != email && backend_controller.loginSearchUsername(username).getUsername() != username) //searches the database to see if the account and username already exist - L 
                {
                    backend_controller.writeLoginDatabaseEntry(new DataBaseLoginEntry(username, "password", email, true)); //Creates a new database entry with all the correct credentials in - L
                }
                return true;
            }
            return false;
        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {


            if (credentialChecker()) //if methoud output is true, run the following code - L
            {
                errorOutputLabel.Text = "SUCSESS - MOVE FORWARD"; //clear the error label - L
            }
        }



        private void GoBackButton_Click(object sender, EventArgs e)
        {
            manager.back();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordGetter1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RulesCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoginGetter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
