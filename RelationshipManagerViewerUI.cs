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
		private int slot_counter = 0; //Keeps track of how many slots are use by buttons, globally - L
		private int button_base_size = 170; //Allows us to easily change the base size of a button - L
		private int button_spacing = 20; //Allows us to easily dicate how far apart buttons are form each other - L
		public RelationshipManagerViewerUI(Form n_previous_window, List<InvestmentIdea> n_idea_list)
		{
			InitializeComponent();
			manager = new FormManager(n_previous_window, this);
			idea_list = n_idea_list;
			FancyDisplayBubbleTracker.getBubbleTracker().setLabel(DataOutputLabel);
		}
		List<InvestmentIdea> idea_list;

		//Some temporary values for testing, mimicking the values being imported from the filter page - L
		int temp_min_cost = 50;
		int temp_max_cost = 150;
		int temp_min_risk = 2;
		int temp_max_risk = 4;

		int temp_db_cost = 100;
		int temp_db_risk = 3;


		private Point findPosition(int size) 
		{
			Point ret = new Point();
			switch (slot_counter)
			{
				case 0:
					ret.X = 378 - (size / 2);
					ret.Y = 276 - (size / 2);
					break;
				case 1: //Bottom left
					ret.X = 378 - (size / 2) - button_base_size - button_spacing;
					ret.Y = 276 - (size / 2) + button_base_size + button_spacing;
					break;
				case 2: //Top right
					ret.X = 378 - (size / 2) + button_base_size + button_spacing;
					ret.Y = 276 - (size / 2) - button_base_size - button_spacing;
					break;
				case 3://Top Left
					ret.X = 378 - (size / 2) - button_base_size - button_spacing;
					ret.Y = 276 - (size / 2) - button_base_size - button_spacing;
					break;
				case 4://Bottom Right
					ret.X = 378 - (size / 2) + button_base_size + button_spacing;
					ret.Y = 276 - (size / 2) + button_base_size + button_spacing;
					break;

				default:
					break;
			}
			slot_counter++; //Incriment the slot counter so we know how many bubbles are on the page - L
			return ret; //return the position of the bubble - L
		}


		//A function that takes the filter results from the previous page and compares them to the inputted results from the database to result in a level of suitability from 0 - 100 - L
		private int buttonSizeCalcualtor(int min_cost_filter, int max_cost_filter, int min_risk_filter, int max_risk_filter, int db_cost, int db_risk) 
		{
			//Find the middle point of the toggles to use in the suitability calculations - L
			float av_cost_filter = min_cost_filter * max_cost_filter / 2;
			float av_risk_filter = min_risk_filter * max_risk_filter / 2;

			//Find the % difference. The closer to 0, the closer to a full size button - L
			float suitability_cost = db_cost / av_cost_filter;
			suitability_cost = System.Math.Abs(suitability_cost - 1);
			float suitability_risk = db_risk / av_risk_filter;
			suitability_risk = System.Math.Abs(suitability_risk - 1);

			//Find the avarage value between the two % differences - L
			float av_suitability = suitability_cost * suitability_risk / 2;

			//Make it so the closer the number is to 0, the closer it now it to 1
			av_suitability = 1 - av_suitability;

			//The closer to 1 the number is, the closer to full size it will be - L
			float final_suitability = av_suitability * button_base_size;

			return (int)final_suitability;
		}

		//A function that spawns in a button - L
		private void spawnButton(int button_index_from_list) 
		{
			//Calculates a buttons size based of values inputted from the database, and the filters previously selected - L
			int size_of_button = buttonSizeCalcualtor(temp_min_cost, temp_max_cost, temp_min_risk, temp_max_risk, temp_db_cost, temp_db_risk);

			//Finds a buttons location based off of it's size - L
			Point location_of_button = findPosition(size_of_button); 

			FancyDisplayBubbleTracker.instanceAddBubble(new Button(), idea_list[button_index_from_list]);
			this.Controls.Add(FancyDisplayBubbleTracker.instanceGetLastBubble().getButton()); //Add controlls to the recently created button - L
			FancyDisplayBubbleTracker.instanceGetLastBubble().getButton().Text = idea_list[button_index_from_list].getName(); //Sets the text of the button - L
			FancyDisplayBubbleTracker.instanceGetLastBubble().getButton().Location = location_of_button; //Sets the location of the button - L
			FancyDisplayBubbleTracker.instanceGetLastBubble().getButton().Size = new Size(size_of_button, size_of_button); //Sets the size of button to the default size - L
			FancyDisplayBubbleTracker.instanceGetLastBubble().getButton().Font = new Font("Agency FB", size_of_button / 6, FontStyle.Bold);
		}



		//If the left button is pressed - L
        private void page_left_button_Click(object sender, EventArgs e)
        {
			spawnButton(0);
			spawnButton(1);
			spawnButton(2);
			spawnButton(3);
			spawnButton(4);

		}

		//If the right button is pressed - L
		private void page_right_button_Click(object sender, EventArgs e)
        {

		}













        private void page_number_label_Click(object sender, EventArgs e)
        {
        }
		private void RelationshipManagerViewerUI_Load(object sender, EventArgs e)
		{
		}
		private void debugShow_Click(object sender, EventArgs e)
		{
		}
		private void cost_label_Click(object sender, EventArgs e)
		{
		}

        private void divide_line_Click(object sender, EventArgs e)
        {

        }
    }
}
