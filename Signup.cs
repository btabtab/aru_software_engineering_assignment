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
            String username = LoginGetter.Text;
            String password1 = PasswordGetter1.Text;
            String password2 = PasswordGetter2.Text;
            String email = EmailGetter.Text;
            bool passwordCorrect = false;
            bool emailCorrect = false;
            bool usernameCorrect = false;



            //PASSWORD CODE
            bool passNotMatch = Convert.ToBoolean(string.Compare(password1, password2)); //Compares if the passwords match - L
            if (passNotMatch == true) //If the passwords do not match, do the following code - L
            {
                errorOutputLabel.Text = "passwords do not match"; //Tell the user their password is wrong - L
                wrongPassSymbol1.Text = "X"; //Add a cross next to the password box - L
                wrongPassSymbol2.Text = "X"; //Add a cross next to the password repeat box - L
            }
            else //If the passwords do match, do the following code - L
            {
                errorOutputLabel.Text = ""; //clear the error label - L
                wrongPassSymbol1.Text = ""; //remove the cross next to the password box - L
                wrongPassSymbol2.Text = ""; //remove the cross next to the password repeat box - L
                passwordCorrect = true;
            }
            //PASSWORD CODE


            //EMAIL CODE
            Boolean emailContain = email.Contains("@"); //Checks if the text entered into the email entry point contains the correct symbol - L
            if (emailContain == true) //If the email contains the correct symbol - L
            {
                wrongEmailSymbol.Text = ""; //remove the cross next to the email repeat box - L
                emailCorrect = true;
            }

            else //If the email does not contain the correct symbol - L
            {
                errorOutputLabel.Text = "Email is not valid"; //Tells the user their email is invalid - replaces wrong password text as the email is first on the data entry list - L
                wrongEmailSymbol.Text = "X"; //Add a cross next to the email repeat box - L
            }
            //EMAIL CODE


            if (passwordCorrect == true & emailCorrect == true)
            { //if all aspects of the form are correct, run the code below - L
                errorOutputLabel.Text = "SUCSESS"; //clear the error label - L

            }



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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordGetter1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
