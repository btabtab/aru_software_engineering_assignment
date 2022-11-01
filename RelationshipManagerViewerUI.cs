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
	class FancyDisplayBubble
	{
		Button button;
		int risk;

		public FancyDisplayBubble(Button n_button, int n_risk)
		{
			button = n_button;
			risk = n_risk;
		}
		public Button getButton()
        {
			return button;
        }
		public int getRisk()
        {
			return risk;
        }
	};
	//will write more later. -JE NOV 1.0
	class FancyDisplayBubbleTracker
	{
		static FancyDisplayBubbleTracker instance;
		List<FancyDisplayBubble> bubbles;
		//Singleton design pattern esque stuff <3
		private FancyDisplayBubbleTracker()
		{
			bubbles = new List<FancyDisplayBubble>();
		}
		public static FancyDisplayBubbleTracker getBubbleTracker()
		{
			if (instance == null)
			{
				instance = new FancyDisplayBubbleTracker();
			}
			return instance;
		}

		FancyDisplayBubble getBubble(int index)
		{
			return bubbles.ElementAt(index);
		}
		void addBubble(Button n_button, int risk_factor)
		{
			bubbles.Add(new FancyDisplayBubble(n_button,risk_factor));
		}

		FancyDisplayBubble getLastBubble()
		{
			return getBubble(bubbles.Count - 1);
		}

		int getBubbleCount()
        {
			return bubbles.Count;
        }
		public static FancyDisplayBubble instanceGetBubble(int index)
		{
			return getBubbleTracker().getBubble(index);
		}

		public static void instanceAddBubble(Button n_button, int risk_factor)
		{
			getBubbleTracker().addBubble(n_button, risk_factor);
		}

		public static FancyDisplayBubble instanceGetLastBubble()
		{
			return getBubbleTracker().getBubble(instance.getBubbleCount() - 1);
		}


	};

	public partial class RelationshipManagerViewerUI : Form 
	{
		FormManager manager;
		BackendController backend_controller;
		private bool large_slot_taken = false;
		private int meduim_slot_counter = 0;
		public RelationshipManagerViewerUI(Form n_previous_window, BackendController n_backend_controller)
		{
			InitializeComponent();
			manager = new FormManager(n_previous_window, this);
			backend_controller = n_backend_controller;
			multipleButtonMaker();
			multipleButtonMaker();
			multipleButtonMaker();
			multipleButtonMaker();
			multipleButtonMaker();
		}



		private void cost_label_Click(object sender, EventArgs e)
		{

		}


		private int mathsSutability(float imported_cost, float cost, float imported_risk, float risk) 
		{
			//Find the difference between the fetched values and the prefered values, then divide that by the avarage of the two values and * 100 to get a % variance - L
			float percent_difference_cost = Math.Abs((imported_cost - cost) / ((imported_cost + cost) / 2) * 100);
			float percent_difference_risk = Math.Abs((imported_risk - risk) / ((imported_risk + risk) / 2) * 100);

			//Find the avarage variance between the two catagories 
			float percent_difference_avarage = (percent_difference_cost + percent_difference_risk) / 2;
			float suitability_algorithm_outcome = Math.Abs(100 - percent_difference_avarage); //Size of the bubble to be displayed - L
			return (int)Math.Round(suitability_algorithm_outcome); //Make the float an int - L
		}

		private Point positionCalculator(int size) 
		{
			Point ret = new Point();
			if (size > 66 && large_slot_taken == false)
			{
				ret.X = 379 - (size / 2);
				ret.Y = 300 - (size / 2);
				large_slot_taken = true;
			}


			else if (size > 33)
			{

				switch (meduim_slot_counter)
				{
					case 0:
						ret.X = 279 - (size / 2);
						ret.Y = 400 - (size / 2);
						break;
					case 1:
						ret.X = 479 - (size / 2);
						ret.Y = 200 - (size / 2);
						break;
					case 2:
						ret.X = 279 - (size / 2);
						ret.Y = 200 - (size / 2);
						break;
					case 3:
						ret.X = 479 - (size / 2);
						ret.Y = 400 - (size / 2);
						break;

					default:
						break;
				}
				meduim_slot_counter++;
			}

			else
			{
				ret.X = 52;
				ret.Y = 0;
			}

			return ret;
		}

		private void multipleButtonMaker() 
		{
			//Temporary variable names, just for ease of understaning, will be imported from db - L
			string name_of_option = "Bonds";
			int amount_of_items_that_fit_the_search_filter = 4; 
			float cost = 1500; 
			float risk = 4;
			//Temporary variable names, just for ease of understaning, will be imported from db - L


			//Temporary variable names, just for ease of understaning, will be imported from RM filter page - L
			float imported_cost = 1480;
			float imported_risk = 3;
			//Temporary variable names, just for ease of understaning, will be imported from RM filter page - L

			string cost_string = cost.ToString();
			string risk_string = risk.ToString();

			//Create the button with the calculated and fetched paramaters
			//createButton(size*2, position_x, position_y, name_of_option + "\nCost: " + cost_string + "\nRisk:" + risk_string );
			createButton(mathsSutability(imported_cost, cost, imported_risk, risk));



		}


		private void createButton(int size_of_button)
		{
			Point button_pos = positionCalculator(size_of_button); //Creates a Point variable to hold the size of the button - L
			
			FancyDisplayBubbleTracker.instanceAddBubble(new Button(), /*this value will be the risk of the button but it will be left as 0 for now -JE*/0); //Creates a new instance of a button - L
			this.Controls.Add(FancyDisplayBubbleTracker.instanceGetLastBubble().getButton()); //Add controlls to the recently created button - L
			FancyDisplayBubbleTracker.instanceGetLastBubble().getButton().Text = size_of_button.ToString(); //Sets the text of the button - L
			FancyDisplayBubbleTracker.instanceGetLastBubble().getButton().Location = button_pos; //Sets the location of the button - L
			FancyDisplayBubbleTracker.instanceGetLastBubble().getButton().Size = new Size(size_of_button, size_of_button); //Sets the size of button to the default size - L
			FancyDisplayBubbleTracker.instanceGetLastBubble().getButton().Font = new Font("Agency FB", 18, FontStyle.Bold); //Sets the buttons font and text size - L
		}

		private void RelationshipManagerViewerUI_Load(object sender, EventArgs e)
		{
		}
	}
}
