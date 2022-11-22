using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aru_software_eng_UI
{
	public class InvestmentIdea
	{
		//this generates a random InvestmentIdea for testing sake.
		public InvestmentIdea()
		{
			date = DateTime.Now;
			ID = new Random().Next(0, 255);
			int desc_len = new Random().Next(0, 255);
			int a = 10;
			for (int i = 0; i != desc_len; i++)
            {
				a--;

				if (new Random().Next(0, 10) == 6 || a == 0)
				{
					description = description + "\n";
					a = new Random().Next(0, 5);
				}
				description = description + new Random().Next(0, 9);
			}
			name = "idea name " + ID;
			risk_level = ID ^ (new Random().Next(0, 255));
			cost = (float)(new Random().Next(ID, 10000 + ID));
			investment_type = "type - " + new Random().Next(0, 255) + " investment";
			permission_level = new Random().Next(0, 5);

		}
		//This is used to contruct an investment idea. - J
		public InvestmentIdea(DateTime n_date, string n_name, string n_description, int n_ID, int n_risk_level, float n_cost, string n_investment_type, int n_permission_level)
        {
			date = n_date;
			ID = n_ID;
			name = n_name;
			description = n_description;
			risk_level = n_risk_level;
			cost = n_cost;
			investment_type = n_investment_type;
			permission_level = n_permission_level;
		}

		DateTime date;
		string name, description, investment_type;
		int ID, user_ID, risk_level, permission_level;
		float cost;

		public DateTime getDate()				{ return date;				}
		public string	getName()				{ return name;				}
		public string	getDescription()		{ return description;		}
		public int		getID()					{ return ID;				}
		public int		getUserID()				{ return user_ID;			}
		public int		getRiskLevel()			{ return risk_level;		}
		public float	getCost()				{ return cost;				}
		public string	getInvestmentType()		{ return investment_type;	}
		public int		getRmPermissionLevel()	{ return permission_level;	}

		public void setDate(DateTime n_date)					{ date				= n_date;				}
		public void setName(string n_name)						{ name				= n_name;				}
		public void setDescription(string n_description)		{ description		= n_description;		}
		public void setID(int n_ID)								{ ID				= n_ID;					}
		public void setUserID(int n_user_ID)					{ user_ID			= n_user_ID;			}
		public void setRiskLevel(int n_risk_level) 				{ risk_level		= n_risk_level;			}
		public void setCost(float n_cost)						{ cost				= n_cost;				}
		public void setInvestmentType(string n_investment_type)	{ investment_type	= n_investment_type;	}
		public void setPermissionLevel(int n_permission_level)	{ permission_level	= n_permission_level;	}

		public string getAsLabelString()
		{
			return (
				"ID: " + ID +
				"\nName: " + name +
				"\nDescription: " + description +
				"\nRisk level: " + risk_level +
				"\n:Cost: " + cost +
				"\n:Date: " + date.ToString() +
				"\n:investment type: " + investment_type.ToString() +
				"\n:permission level: " + permission_level
				);
		}
	}
}
