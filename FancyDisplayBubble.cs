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
		int risk; //Risk number for display purposes - L
		int cost; //Cost for display purposes - L
		int ID; //ID for tracking puproses - L
		string investment_type; //Name for display purposes - L
		string description;
		int RM_rating;

		//Constructor, creates a new bubble with a button and risk attribute - L
		public FancyDisplayBubble(Button n_button, int n_risk, int n_cost, int n_ID, string n_investment_type, string n_description, int n_RM_rating) 
		{
			button = n_button; 
			risk = n_risk; 
			cost = n_cost;
			ID = n_ID;
			investment_type = n_investment_type;
			description = n_description;
			RM_rating = n_RM_rating;

			button.Click += new EventHandler(showButtonInfo); //When button is clicked, run the "showButtonInfo" function - L
		}

		void showButtonInfo(object sender, EventArgs e)
		{
			Button target = (Button)sender;
			
		}
		//Encapuslation commands to get the bubbles information - L  
		public Button getButton()   
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
		public string getInvestmentType()
		{
			return investment_type;
		}
		public string getDescription()
		{
			return description;
		}
		public int getRating()
		{
			return RM_rating;
		}

	};
}
