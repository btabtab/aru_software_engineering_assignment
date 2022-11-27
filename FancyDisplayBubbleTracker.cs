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
	class FancyDisplayBubbleTracker
	{
		public static FancyDisplayBubbleTracker instance;
		List<FancyDisplayBubble> bubbles;
		Label target_output_label;
		int last_pressed_bubble;

		//Singleton design pattern esque stuff <3
		private FancyDisplayBubbleTracker()
		{
			bubbles = new List<FancyDisplayBubble>();
			last_pressed_bubble = -1;
		}
		/*
		 John:
		*/
		public int getLastPressedBubbleID()
        {
			return last_pressed_bubble;
        }
		public int scanForPressedBubble()
		{
			for (int i = 0; i != bubbles.Count; i++)
			{
				if (bubbles[i].isClicked())
				{
					Console.WriteLine("clicked " + i);
					last_pressed_bubble = i;
					return i - 1;
				}
				bubbles[i].resetClickFlag();
			}
			return -1;
		}
		void showButtonInfo(object sender, EventArgs e)
		{
			scanForPressedBubble();
			Console.WriteLine("i = " + FancyDisplayBubbleTracker.getBubbleTracker().getLastPressedBubbleID());

			if (FancyDisplayBubbleTracker.getBubbleTracker().getLastPressedBubbleID() != -1)
			{
				target_output_label.Text = bubbles[(FancyDisplayBubbleTracker.getBubbleTracker().getLastPressedBubbleID())].getInvestmentIdea().getAsLabelString();
			}
		}
		public void setLabel(Label n_target_output_label)
        {
			target_output_label = n_target_output_label;
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
		
		void addBubble(Button n_button, InvestmentIdea n_investment_idea)
		{
			bubbles.Add(new FancyDisplayBubble(n_button, n_investment_idea, showButtonInfo));
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

		public static void instanceAddBubble(Button n_button, InvestmentIdea n_investment_idea)
		{
			getBubbleTracker().addBubble(n_button, n_investment_idea);
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
			while (getBubbleTracker().getBubbleCount() != 0)
			{
				current_form.Controls.Remove(instance.getLastBubble().getButton());
				instance.deleteBubble(getBubbleTracker().getBubbleCount());
			}
		}
	};
}
