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
		InvestmentIdea investment_idea; //This is the investment_idea that will be displayed.

		//Constructor, creates a new bubble with a button and risk attribute - L
		public FancyDisplayBubble(Button n_button, InvestmentIdea n_investment_idea, EventHandler function)
		{
			button = n_button;
			investment_idea = n_investment_idea;
			clicked = false;

			button.Click += new EventHandler(setToClicked);
			button.Click += new EventHandler(function); //When button is clicked, run the "showButtonInfo" function - L
		}

		bool clicked;
		public bool isClicked()
        {
			return clicked;
        }
		public void setClickFlag(bool n_clicked)
		{
			clicked = n_clicked;
		}
		void setToClicked(object sender, EventArgs e)
		{
			clicked = true;
		}
		//Encapuslation commands to get the bubbles information - L  
		public Button getButton()   
		{
			return button;
		}
		public InvestmentIdea getInvestmentIdea()
        {
			return investment_idea;
        }
	};
}
