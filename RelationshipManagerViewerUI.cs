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
    public partial class RelationshipManagerViewerUI : Form 
    {
        FormManager manager;
        BackendController backend_controller;
        public RelationshipManagerViewerUI(Form n_previous_window, BackendController n_backend_controller)
        {
            InitializeComponent();
            manager = new FormManager(n_previous_window, this);
            backend_controller = n_backend_controller;
            multipleButtonMaker();


        }



        private void cost_label_Click(object sender, EventArgs e)
        {

        }


        private void multipleButtonMaker() 
        {
            //Temporary variable names, just for ease of understaning, will be imported from db - L
            string name_of_option = "Bonds";
            int amount_of_items_that_fit_the_search_filter = 4; 
            float cost = 90; 
            float risk = 4;
            //Temporary variable names, just for ease of understaning, will be imported from db - L


            //Temporary variable names, just for ease of understaning, will be imported from RM filter page - L
            float imported_cost = 90;
            float imported_risk = 4;
            //Temporary variable names, just for ease of understaning, will be imported from RM filter page - L


            //Find the difference between the fetched values and the prefered values, then divide that by the avarage of the two values and * 100 to get a % variance - L
            float percent_difference_cost = Math.Abs((imported_cost - cost) / ((imported_cost + cost) / 2) * 100); 
            float percent_difference_risk = Math.Abs((imported_risk - risk) / ((imported_risk + risk) / 2) * 100);

            //Find the avarage variance between the two catagories 
            float percent_difference_avarage = (percent_difference_cost + percent_difference_risk) / 2;
            float suitability_algorithm_outcome = Math.Abs(100 - percent_difference_avarage); //Size of the bubble to be displayed - L
            int size = (int)Math.Round(suitability_algorithm_outcome); //Make the float an int - L

            //Make the float positions int's and make them offset from the centre of the screen based of there size (less desired, further away) - L
            int position_x = (378 - size) - (int)Math.Round(percent_difference_avarage*10);
            int position_y = (300 - size) - (int)Math.Round(percent_difference_avarage*10);

            //Mkae sure no position is negative
            position_x = Math.Max(position_x, 0); 
            position_y = Math.Max(position_y, 0);

            string cost_string = cost.ToString();
            string risk_string = risk.ToString();

            //Create the button with the calculated and fetched paramaters
            createButton(size*2, position_x, position_y, name_of_option + "\nCost: " + cost_string + "\nRisk:" + risk_string );



        }


        private void createButton(int size_of_button, int location_of_button_x, int location_of_button_y, string button_text)
        {
            Point button_size = new Point(size_of_button, size_of_button); //Creates a Point variable to hold the size of the button - L
            Point button_location = new Point(location_of_button_x, location_of_button_y); //Creates a Point variable to hold the location of the button - L
            
            Button button1 = new Button(); //Creates a new instance of a button - L
            this.Controls.Add(button1); //Add controlls to the recently created button - L
            button1.Text = button_text; //Sets the text of the button - L
            button1.Location = button_location; //Sets the location of the button - L
            button1.Size = new Size(button_size); //Sets the size of button to the default size - L
            button1.Font = new Font("Agency FB", 18, FontStyle.Bold); //Sets the buttons font and text size - L

        }














        private void RelationshipManagerViewerUI_Load(object sender, EventArgs e)
        {

        }
    }
}
