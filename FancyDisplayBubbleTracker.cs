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
			while (getBubbleTracker().getBubbleCount() != 0)
			{
				current_form.Controls.Remove(instance.getLastBubble().getButton());
				instance.deleteBubble(getBubbleTracker().getBubbleCount());
			}
		}
	};
}
