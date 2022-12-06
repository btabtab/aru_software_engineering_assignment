using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aru_software_eng_UI
{
	public class BackendController
	{
		LoginDatabaseHandler			login_handler;
		InvestmentIdeaDatabaseHandler	investment_idea_handler;

		private BackendController()
		{
			login_handler			= LoginDatabaseHandler.getInstance();
			investment_idea_handler = InvestmentIdeaDatabaseHandler.getInstance();
		}

		static BackendController singleton_instance;
		static public BackendController getInstance()
		{
			if (singleton_instance == null)
			{
				singleton_instance = new BackendController();
			}
			return singleton_instance;
		}




		public void writeRandomLoginEntry()
		{
			LoginDatabaseHandler.getInstance().writeNewLoginDataEntry(new DataBaseLoginEntry(LoginDatabaseHandler.getInstance().getHighestID(DatabaseWrapper.LoginEntries, "UserID")));
		}
		public DataBaseLoginEntry loginSearchID(int ID)
        {
			return login_handler.getLoginEntryFromID(ID);
        }
		public DataBaseLoginEntry loginSearchEmail(string search)
        {
			return login_handler.getLoginEntryFromEmail(search);
		}
		public DataBaseLoginEntry loginSearchUsername(string search)
        {
			return login_handler.getLoginEntryFromUsername(search);
		}
		//this writes a new login into the database. -J
		public void writeLoginDatabaseEntry(DataBaseLoginEntry n_database_login_entry)
        {
			login_handler.addNewLogin(n_database_login_entry);
        }
		public void deleteUserFromLoginTable(string username)
        {
			login_handler.deleteLoginRowX(login_handler.getLoginEntryFromUsername(username).getID());
        }

		public int getLoginTableRowCount()
        {
			return login_handler.getRowCount(DatabaseWrapper.LoginEntries);
        }
		public DataBaseLoginEntry getHighestUserIDEntry()
        {
			return login_handler.getLoginEntryFromID(login_handler.getHighestID(DatabaseWrapper.LoginEntries, "UserID"));
		}
		public void deleteHighestLoginID()
        {
			login_handler.deleteLoginRowX(login_handler.getHighestID(DatabaseWrapper.LoginEntries, "UserID"));
        }
		public void generateRandomLoginEntry()
		{
		}
		public void writeLoginDatabaseEntry(InvestmentIdea n_investment_idea)
        {
			investment_idea_handler.writeInvestmentIdea(n_investment_idea);
        }
		public InvestmentIdea getInvestmentIdeaFromID(int i)
        {
			return investment_idea_handler.getInvestmentIdeaFromID(i);
        }
		public void writeRandomInvestmentIdea()
        {
			investment_idea_handler.writeInvestmentIdea(new InvestmentIdea(LoginDatabaseHandler.getInstance().getHighestID(DatabaseWrapper.LoginEntries, "UserID")));
        }
		public void deleteHighestInvestmentIdeaID()
		{
			investment_idea_handler.deleteInvestmentIdeaRowX(investment_idea_handler.getHighestID(DatabaseWrapper.InvestmentIdeas, "ID"));
		}

	}
}