using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aru_software_eng_UI
{
	public class InvestmentIdeaDatabaseHandler : DatabaseHandler
	{
		/* This is a blank entry that can be grabbed for testing sake
		while the database controller is being worked on. */

		List<InvestmentIdea> current_investment_ideas;
	
		private InvestmentIdeaDatabaseHandler()
		{
			database_wrapper = DatabaseWrapper.getDatabaseWrapperInstance();
			current_investment_ideas = new List<InvestmentIdea>();
		}

		static InvestmentIdeaDatabaseHandler singleton_instance;
		new static public InvestmentIdeaDatabaseHandler getInstance()
		{
			if (singleton_instance == null)
			{
				singleton_instance = new InvestmentIdeaDatabaseHandler();
			}
			return singleton_instance;
		}
		void loadInvestmentIdeasFromDatabaseToList()
        {
            //write stuff in here.
        }
        public InvestmentIdea getInvestmentIdeaFromID(int ID)
        {
            return current_investment_ideas[ID];
        }
		public List<InvestmentIdea> getFilteredList(Filters filters)
        {
			return InvestmentIdeaFiltering.getFilterList(current_investment_ideas, filters);
        }
		public List<InvestmentIdea> loadInvestmentIdeaList()
        {
			return current_investment_ideas;
        }
	}
}
