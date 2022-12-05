using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aru_software_eng_UI
{
	/**/
	public class InvestmentIdeaDatabaseHandler : DatabaseHandler
	{
		/* This is a blank entry that can be grabbed for testing sake
		while the database controller is being worked on. */

		List<InvestmentIdea> current_investment_ideas;

		/**/
		private InvestmentIdeaDatabaseHandler()
		{
			database_wrapper = DatabaseWrapper.getDatabaseWrapperInstance();
			current_investment_ideas = new List<InvestmentIdea>();
			loadInvestmentIdeasFromDatabaseToList();
		}

		/**/
		public void writeInvestmentIdea(InvestmentIdea n_idea)
		{
			List<string> columns = new List<string>(), values = new List<string>();


			columns.Add("ID");
			columns.Add("User_ID");
			columns.Add("Name");
			columns.Add("Description");
			columns.Add("RiskLevel");
			columns.Add("Cost");
			columns.Add("Date");

			values.Add((database_wrapper.getHighestIDNumber(DatabaseWrapper.InvestmentIdeas, "ID") + 1).ToString());
			values.Add(n_idea.getUserID().ToString());
			values.Add(n_idea.getName());
			values.Add(n_idea.getDescription());
			values.Add(n_idea.getRiskLevel().ToString());
			values.Add(n_idea.getCost().ToString());
			values.Add(n_idea.getDate().ToString());

			try
			{
				database_wrapper.insertNewEntryIntoDatabase(DatabaseWrapper.InvestmentIdeas, columns, values);
			}
			catch(Exception e)
            {
				Console.Write("!!!!\n\nMissing user in table.\n\n(" + e.Message + ")\n\n!!!!");
				database_wrapper.closeConnection();
            }
			InvestmentIdeaDatabaseHandler.getInstance().loadInvestmentIdeasFromDatabaseToList();
		}
		/**/
		public InvestmentIdea getInvestmentIDFromDatabase(int ID)
		{
            InvestmentIdeaDatabaseHandler.getInstance().loadInvestmentIdeasFromDatabaseToList();
			InvestmentIdea ret = new InvestmentIdea(
															database_wrapper.searchDatabaseForDateTime("Date", DatabaseWrapper.InvestmentIdeas, "ID=", ID.ToString()),
															database_wrapper.searchDatabaseForString("Name", DatabaseWrapper.InvestmentIdeas, "ID=", ID.ToString()),
															database_wrapper.searchDatabaseForString("Description", DatabaseWrapper.InvestmentIdeas, "ID=", ID.ToString()),
															database_wrapper.searchDataBaseForInt("ID", DatabaseWrapper.InvestmentIdeas, "ID=", ID.ToString()),
															database_wrapper.searchDataBaseForInt("UserID", DatabaseWrapper.InvestmentIdeas, "ID=", ID.ToString()),
															database_wrapper.searchDataBaseForInt("RiskLevel", DatabaseWrapper.InvestmentIdeas, "ID=", ID.ToString()),
															database_wrapper.searchDataBaseForInt("Cost", DatabaseWrapper.InvestmentIdeas, "ID=", ID.ToString()),
															database_wrapper.searchDatabaseForString("ProductTag", DatabaseWrapper.InvestmentIdeas, "ID=", ID.ToString()),
															database_wrapper.searchDataBaseForInt("AdminLevel", DatabaseWrapper.InvestmentIdeas, "ID=", ID.ToString())
															);
			return ret;
		}

		/**/
		static InvestmentIdeaDatabaseHandler singleton_instance;

		/**/
		new static public InvestmentIdeaDatabaseHandler getInstance()
		{
			if (singleton_instance == null)
			{
				singleton_instance = new InvestmentIdeaDatabaseHandler();
			}
			return singleton_instance;
		}

		/**/
		public void loadInvestmentIdeasFromDatabaseToList()
        {
			for (int i = 0; i != getHighestID(DatabaseWrapper.InvestmentIdeas, "ID"); i++)
			{
				current_investment_ideas.Add(getInvestmentIDFromDatabase(i));
			}
		}

		/**/
		public InvestmentIdea getInvestmentIdeaFromID(int ID)
        {
            InvestmentIdeaDatabaseHandler.getInstance().loadInvestmentIdeasFromDatabaseToList();
            return current_investment_ideas[ID];
		}

		/**/
		public List<InvestmentIdea> getFilteredList(Filters filters)
        {
            InvestmentIdeaDatabaseHandler.getInstance().loadInvestmentIdeasFromDatabaseToList();
			return InvestmentIdeaFiltering.getFilterList(current_investment_ideas, filters);
		}

	}
}
