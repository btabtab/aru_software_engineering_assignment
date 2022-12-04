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

        //Creates a function that checks if two passwords are the same, returning 'true' is they are - L
        private Boolean passwordChecker()
        {
            //Sets the input from the boxes to two different variables so they can easily be addressed further on in the code - L
            string password1 = PasswordGetter1.Text;
            string password2 = PasswordGetter2.Text;

            //Compares if the passwords match - L
            bool pass_not_match = Convert.ToBoolean(string.Compare(password1, password2));

            //If the passwords do not match, tell the user and don't let them continue with the sign up process - L
            if (pass_not_match == true)
            {
                errorOutputLabel.Text = "passwords do not match"; //Tell the user their password is wrong - L
                wrongPassSymbol1.Text = "X"; //Add a cross next to the password box - L
                wrongPassSymbol2.Text = "X"; //Add a cross next to the password repeat box - L
                return false;
            }

            //If the passwords do match, format the UI properly - L
            else if (password1.Length > 6)
            {
                errorOutputLabel.Text = ""; //clear the error label - L
                wrongPassSymbol1.Text = ""; //remove the cross next to the password box - L
                wrongPassSymbol2.Text = ""; //remove the cross next to the password repeat box - L
                return true;
            }

            //If the passwords do match but they are too short, infrom the user and let them try again - L
            else
            {
                errorOutputLabel.Text = "minimum password length of 7 characters"; //Tell the user their password is wrong - L
                wrongPassSymbol1.Text = "X"; //Add a cross next to the password box - L
                wrongPassSymbol2.Text = "X"; //Add a cross next to the password repeat box - L
                return false;
            }
        }

        //Creates a function that checks if the email is in the correct format, returning 'true' it is - L
        private Boolean emailChecker()
        {
            //Sets the input from the email box to a simple variable so it can easily be addressed further on in the code - L
            string email = EmailGetter.Text;

            //Checks if the text entered into the email entry point contains the correct symbol - L
            Boolean email_contain = email.Contains("@");
            if (email_contain == true) //If the email contains the correct symbol - L
            {
                //remove the cross next to the email repeat box - L
                wrongEmailSymbol.Text = "";
                return true;
            }

            //If the email does not contain the correct symbol - L
            else
            {
                //Tells the user their email is invalid -
                //replaces "wrong password" as the email is higher up on the login page - L
                errorOutputLabel.Text = "Email is not valid";
                wrongEmailSymbol.Text = "X"; //Add a cross next to the email repeat box - L
                return false;
            }
        }

        //Creates a function that checks if the username is the correct length, returning 'true' it is - L
        private Boolean usernameChecker()
        {
            //Sets the input from the email box to a simple variable
            //so it can easily be addressed further on in the code - L
            string username = LoginGetter.Text;
            if (username.Length > 2) //If the username is long enough - L
            {
                usernameWrongSymbol.Text = ""; //clears the cross
                return true;
            }
            else //If the email username is too short - L
            {
                //Tells the user their username is invalid
                //replaces "wrong email" as the username is first on the login page - L
                errorOutputLabel.Text = "username must be at least 3 characters long";
                usernameWrongSymbol.Text = "X";
                return false;
            }
        }

        //Only lets the user proceed if the checkbox is checked - L
        private Boolean checkboxChecker()
        {
            if (!RulesCheckBox.Checked)
            {
                errorOutputLabel.Text = "please check the rules box";
            }
            return RulesCheckBox.Checked;
        }

        //Calls all the function above, checks if all the fields are valid - L
        //Then checks if the email and username are already taken - L
        private Boolean credentialChecker()
        {
            //if all aspects of the form are correct write the new information to the database - L
            if (emailChecker() && passwordChecker() && usernameChecker() && checkboxChecker())
            {
                string username = LoginGetter.Text; //Gets username the user entered - L
                string email = EmailGetter.Text; //Gets the email the user entered - L

                //searches the database to see if the email and username already exist - L 
                if (backend_controller.loginSearchEmail(email).getEmail() != email &&
                    backend_controller.loginSearchUsername(username).getUsername() != username)
                {
                    //Creates a new database entry with all the correct credentials in - L
                    backend_controller.writeLoginDatabaseEntry(new DataBaseLoginEntry(username, PasswordGetter1.Text, email, IsRMCheckBox.Checked));
                    return true;
                }
            }
            return false;
        }

        //When the sign up button is pressed, run the credential checking code - L
        private void SignUpButton_Click(object sender, EventArgs e)
        {

            //If all the credentials are correct,
            //return the user to the main menu - L
            if (credentialChecker())
            {
                manager.back();
            }
        }

        //If the back button is pressed, go back to the main menu - L
        private void GoBackButton_Click(object sender, EventArgs e)
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
        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }
        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void IsRMCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
