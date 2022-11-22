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

		private InvestmentIdeaDatabaseHandler()
		{
			database_wrapper = DatabaseWrapper.getDatabaseWrapperInstance();
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
	}
}
