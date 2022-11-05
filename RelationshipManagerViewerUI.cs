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
		private int slot_counter = 0;
		private int page_number = 1;

		//Temporary variable names, just for ease of understaning, will be imported from db - L
		string[] database_string_array = new string[] { "Bonds", "Bonds", "Shares", "Art", "Real estate", "Share", "Share", "Stock", "Bonds", "Art", "Random" };
		float[] database_cost_array = new float[] { 1500, 1500, 1500, 1500, 1500, 1500, 1000, 2000, 9000, 5000, 200 };
		float[] database_risk_array = new float[] { 2, 2, 2, 2, 2, 2, 7, 8, 9, 10, 11 };
		//Temporary variable names, just for ease of understaning, will be imported from db - L

		//Temporary variable names, just for ease of understaning, will be imported from RM filter page - L
		float imported_cost = 1500;
		float imported_risk = 2;
		//Temporary variable names, just for ease of understaning, will be imported from RM filter page - L


		class FancyDisplayBubble
	{
		Button button; //Creates a button object for tracking purposes, named button - L
		int risk; //Risk number for tracking purposes - L
		int cost;
		int ID;
			public FancyDisplayBubble(Button n_button, int n_risk, int n_cost, int n_ID) //Constructor, creates a new bubble with a button and risk attribute - L
			{
				button = n_button; //Creates new button attribute for bubble - L
				risk = n_risk; //Creates a risk attribute for the bubble - L
				cost = n_cost;
				ID = n_ID;
				button.Click += new EventHandler(showButtonInfo); //When button is clicked, run the "showButtonInfo" function - L
			}

			void showButtonInfo(object sender, EventArgs e)
			{
				Button target = (Button)sender;

			}








		public Button getButton() //Encapuslation command to get the buttons reference hidden in fancyDisplayButton - L    
		{
			return button; 
		}

		public int getRisk()
		{
			return risk;
		}

		public int getCost()
		{
			return cost;
		}

		public int getID()
		{
			return ID;
		}

		};
	//will write more later. -JE NOV 1.0
	class FancyDisplayBubbleTracker
	{
		public static FancyDisplayBubbleTracker instance;
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
		void addBubble(Button n_button, int risk_factor, int cost_factor, int ID)
		{
			bubbles.Add(new FancyDisplayBubble(n_button, risk_factor, cost_factor, ID));
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

		public static void instanceAddBubble(Button n_button, int risk_factor, int cost_factor, int ID)
		{
			getBubbleTracker().addBubble(n_button, risk_factor, cost_factor, ID);
		}

		public static FancyDisplayBubble instanceGetLastBubble()
		{
			return getBubbleTracker().getBubble(instance.getBubbleCount() - 1);
		}

		void deleteButton(object sender, EventArgs e)
		{
			Button target = (Button)sender;
			target.Dispose();
		}

		public void deleteBubble(int index)
		{
			if (getBubbleCount() == 0) { Console.WriteLine("No bubbles left."); return; }
			if (index < 0) { index = 0; }
			if (getBubbleCount() <= index) { index = getBubbleCount() - 1; }

			bubbles.RemoveAt(index);
		}

		public static void instanceDeleteBubble(int index)
		{
			getBubbleTracker().deleteBubble(index);
		}
		public static void deleteAllBubbles(Form current_form)
		{
			while(getBubbleTracker().getBubbleCount() != 0)
			{
				current_form.Controls.Remove(instance.getLastBubble().getButton());
				instance.deleteBubble(getBubbleTracker().getBubbleCount());
			}
		}
	};







		public RelationshipManagerViewerUI(Form n_previous_window, BackendController n_backend_controller)
		{
			InitializeComponent();
			manager = new FormManager(n_previous_window, this);
			backend_controller = n_backend_controller;
			multipleButtonMaker(page_number);

		}

		private void cost_label_Click(object sender, EventArgs e)
		{

		}

		private int mathsSutability(float imported_cost, float cost, float imported_risk, float risk)
		{
			//Find the difference between the fetched values and the prefered values, then divide that by the avarage of the two values and * 100 to get a % variance - L
			float percent_difference_cost = Math.Abs((imported_cost - cost) / ((imported_cost + cost) / 2) * 100);
			float percent_difference_risk = Math.Abs((imported_risk - risk) / ((imported_risk + risk) / 2) * 100);

			//Find the avarage variance between the two catagories - L
			float percent_difference_avarage = (percent_difference_cost + percent_difference_risk) / 2;
			float suitability_algorithm_outcome = Math.Abs(100 - percent_difference_avarage); //Size of the bubble to be displayed - L
			return (int)Math.Round(suitability_algorithm_outcome); //Make the float an int - L
		}

		//Place the bubbles in the appropriate place, based roughly off their size - L
		private Point positionCalculator(int size)
		{
			Point ret = new Point();
				switch (slot_counter)
				{
				case 0:
					ret.X = 350 - (size / 2);
					ret.Y = 235 - (size / 2);
					break;
				case 1:
					ret.X = 150 - (size / 2);
					ret.Y = 435 - (size / 2);
					break;
				case 2:
					ret.X = 550 - (size / 2);
					ret.Y = 35 - (size / 2);
					break;
				case 3:
					ret.X = 150 - (size / 2);
					ret.Y = 35 - (size / 2);
					break;
				case 4:
					ret.X = 550 - (size / 2);
					ret.Y = 453 - (size / 2);
					break;

				default:
					break;


			}
			slot_counter++; //Incriment the slot counter so we know how many bubbles are on the page - L
			return ret; //return the position of the bubble - L
		}

		private void multipleButtonMaker(int start_of_range) 
		{
			int max_possible_page = 3;
			int end_of_range = start_of_range + 5;

			if (page_number == max_possible_page) //If the user is trying to populate the final page... - L
			{
				end_of_range = database_cost_array.Length + 1; //Make it display the appropriate amount of bubbles so you don't have an out of bounds issue - L
			
			}

			
			for (int i = start_of_range; i < end_of_range; i++) //Generate the appropriate amount of bubbles based of previously determined paramneters - L
			{
				createButton(mathsSutability(imported_cost, database_cost_array[i - 1], imported_risk, database_risk_array[i - 1]), database_risk_array[i-1], database_cost_array[i - 1], database_string_array[i - 1] + "\nRisk: " + database_risk_array[i - 1].ToString() + "\n£" + database_cost_array[i - 1].ToString());
			}

		}

		private void createButton(int size_of_button, float risk_to_input, float cost_to_input, string title_of_button)
		{
			Point button_pos = positionCalculator(size_of_button); //Creates a Point variable to hold the size of the button - L
			
			FancyDisplayBubbleTracker.instanceAddBubble(new Button(), 0, 4000, 1); //Creates a new instance of a button - L
			this.Controls.Add(FancyDisplayBubbleTracker.instanceGetLastBubble().getButton()); //Add controlls to the recently created button - L
			FancyDisplayBubbleTracker.instanceGetLastBubble().getButton().Text = title_of_button; //Sets the text of the button - L
			FancyDisplayBubbleTracker.instanceGetLastBubble().getButton().Location = button_pos; //Sets the location of the button - L
			FancyDisplayBubbleTracker.instanceGetLastBubble().getButton().Size = new Size(size_of_button*2, size_of_button*2); //Sets the size of button to the default size - L
			FancyDisplayBubbleTracker.instanceGetLastBubble().getButton().Font = new Font("Agency FB", size_of_button/3, FontStyle.Bold); //Sets the buttons font and text size, makes the font fit the button no matter the size - L
			FancyDisplayBubbleTracker.instanceGetLastBubble().getButton().risk_factor = risk_to_input;


		}

		//If the left button is pressed, reload the current buttons to display the "next page" - L
        private void page_left_button_Click(object sender, EventArgs e)
        {
			if (1 < page_number)
			{
				page_number -= 1;
				page_number_label.Text = page_number.ToString(); //Display the page number to the user - L
				FancyDisplayBubbleTracker.deleteAllBubbles(this);
				slot_counter = 0;
				multipleButtonMaker(1 + (page_number - 1) * 5);
			}
			
		}

		//If the right button is pressed, reload the current buttons to display the "next page" - L
		private void page_right_button_Click(object sender, EventArgs e)
        {

			if (page_number < (database_cost_array.Length - 1) / 5 + 1) //If page number less than max amount it possibly can be - L
			{
				page_number += 1;
				page_number_label.Text = page_number.ToString();
				FancyDisplayBubbleTracker.deleteAllBubbles(this);
				slot_counter = 0;
				multipleButtonMaker(1+(page_number-1) * 5);
			}
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
	}
}
