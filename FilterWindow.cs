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
    public partial class FilterWindow : Form
    {
        FormManager form_manager;
        DataBaseLoginEntry user_login;
        BackendController backend_controller;

        public FilterWindow(Form previous_window, DataBaseLoginEntry n_user_login)
        {
            InitializeComponent();
            this.Text += " USER: " + n_user_login.getUsername();
            user_login = n_user_login;
            form_manager = new FormManager(previous_window, this);
            updateSearchButton();
        }

        //When ran, updates the button to show the correct information - L
        private void updateSearchButton()
        {
            //The data from all four sliders is pulled and dsiplayed on the "search" button - L
            SearchButton.Text = "   Min Risk: " + MinRiskTrackBar.Value.ToString() + "" +
            "                                      SEARCH                               " +
            "Min Cost: £" + MinCostTrackBar.Value.ToString() + 
            "\n   Max Risk: " + MaxRiskTrackBar.Value.ToString() + "" +
            "                                                                                 " + 
            "Max Cost: £" + MaxCostTrackBar.Value.ToString();
        }




        //This function shows a single idea. The RM can select the idea by entering its ID number - L
        private void singleIdeaDisplay() 
        {
            //Convert the inputted numbers into a int - L
            int ID_to_search = Int32.Parse(manualSearchInput.Text);

            //This should print the row that contains the investment idea?? - L
            Console.WriteLine(backend_controller.getInvestmentIdeaFromID(ID_to_search));
        }

       
        //When the search button is pressed, the stored values are passed
        //through to the next page ready to be processed and displayed
        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Create an instance of the filter class and fill it with the appropriate information
            Filters pass_through = new Filters(MinCostTrackBar.Value, MaxCostTrackBar.Value, MinRiskTrackBar.Value, MaxRiskTrackBar.Value, user_login.getIsRelationshipManager(), ExpireDatePicker.Value);
            Console.WriteLine(pass_through.asString() + "\n");
            Console.WriteLine(pass_through.ToString() + "\n");

            //Load the page to sort the information and display the bubbles, pass through the infomration the user has entered 
            new RelationshipManagerViewerUI(this, InvestmentIdeaDatabaseHandler.getInstance().getFilteredList(pass_through));
        }



//Whenever a change is made to any of the four sliders, the button search button is updated - L
        private void MinRiskTrackBar_Scroll(object sender, EventArgs e)
        {
            updateSearchButton();
        }

        private void MinCostTrackBar_Scroll(object sender, EventArgs e)
        {
            updateSearchButton();
        }

        private void MaxRiskTrackBar_Scroll(object sender, EventArgs e)
        {
            updateSearchButton();
        }

        private void MaxCostTrackBar_Scroll(object sender, EventArgs e)
        {
            updateSearchButton();
        }



        private void ExpireDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }
        private void ExpireDateLabel_Click(object sender, EventArgs e)
        {

        }
        private void IndustryInputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void IndustryLabel_Click(object sender, EventArgs e)
        {

        }
        private void manualSearchInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void MaxRiskLabel_Click(object sender, EventArgs e)
        {
        }
        private void MinRiskLabel_Click(object sender, EventArgs e)
        {
        }
        private void MinCostLabel_Click(object sender, EventArgs e)
        {
        }
        private void MaxCostLabel_Click(object sender, EventArgs e)
        {
        }
        private void RelationshipManagerView_Load(object sender, EventArgs e)
        {
        }
    }
}
