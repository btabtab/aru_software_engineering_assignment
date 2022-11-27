using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aru_software_eng_UI
{
    class InvestmentIdeaFiltering
    {
		
		static List<InvestmentIdea> getFilteredResultDate(List<InvestmentIdea> current_list, Filters filter)
		{
			List<InvestmentIdea> filtered_ideas = new List<InvestmentIdea>();
			for (int i = 0; i != current_list.Count; i++)
			{
				if (current_list[i].getDate().CompareTo(filter.getDate()) < 0)
				{
					filtered_ideas.Add(current_list[i]);
				}
			}
			return filtered_ideas;
		}
		static List<InvestmentIdea> getFilteredResultCost(List<InvestmentIdea> current_list, Filters filter)
		{
			List<InvestmentIdea> filtered_ideas = new List<InvestmentIdea>();
			for (int i = 0; i != current_list.Count; i++)
			{
				if (filter.getMinCost() < current_list[i].getCost() && current_list[i].getCost() < filter.getMaxCost())
				{
					filtered_ideas.Add(current_list[i]);
				}
			}
			filtered_ideas.Sort();
			for (int i = 0; i != filtered_ideas.Count; i++)
			{
				Console.WriteLine("\ncost: " + filtered_ideas[i].getCost());
			}
			return filtered_ideas;
		}
		static List<InvestmentIdea> getFilteredRisk(List<InvestmentIdea> current_list, Filters filter_for_search)
        {
			List<InvestmentIdea> filtered_ideas = new List<InvestmentIdea>();
			return filtered_ideas;
		}
		static public List<InvestmentIdea> getFilterList(List<InvestmentIdea> current_list, Filters filter_for_search)
		{
			return getFilteredResultDate(getFilteredResultCost(getFilteredRisk(current_list, filter_for_search), filter_for_search), filter_for_search);
		}
	}
}
