using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aru_software_eng_UI
{
	class InvestmentIdea
	{
		//this generates a random InvestmentIdea for testing sake.
		public InvestmentIdea()
		{
			date = DateTime.Now;
			ID = new Random().Next(0, 255);
			name = "idea name " + ID;
			risk_level = ID ^ (new Random().Next(0, 255));
			cost = (float)(new Random().Next(ID, 10000 + ID));
		}
		public InvestmentIdea(DateTime n_date, string n_name, string n_description, int n_ID, int n_risk_level, float n_cost)
        {
			date = n_date;
			ID = n_ID;
			name = n_name;
			description = n_description;
			risk_level = n_risk_level;
			cost = n_cost;
		}

		DateTime date;
		string name, description;
		int ID, user_ID, risk_level;
		float cost;

		DateTime getDate()	{ return date;			}
		string getName()	{ return name;			}
		int getID()			{ return ID;			}
		int getUserID()		{ return user_ID;		}
		int getRiskLevel()	{ return risk_level;	}
		float getCost()		{ return cost;			}

		void setDate(DateTime n_date)		{ date			= n_date;		}
		void setName(string n_name)			{ name			= n_name;		}
		void setID(int n_ID)				{ ID			= n_ID;			}
		void setUserID(int n_user_ID)		{ user_ID		= n_user_ID;	}
		void setRiskLevel(int n_risk_level) { risk_level	= n_risk_level;	}
		void setCost(float n_cost)			{ cost			= n_cost;		}

		public string getAsLabelString()
		{
			return (
				"ID: " + ID +
				"\nName: " + name +
				"\nDescription: " + description +
				"\nRisk level: " + risk_level +
				"\n:Cost: " + cost +
				"\n:Date: " + date.ToString()
				);
		}
	}
}
