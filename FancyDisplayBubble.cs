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
}
