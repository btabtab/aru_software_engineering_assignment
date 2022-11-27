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
		public InvestmentIdea(int seed)
		{
			expiry_date = DateTime.Now;
			Random random = new Random((int)DateTime.Now.Ticks + seed);
			ID = random.Next(0, 255);
			int desc_len = random.Next(0, 255);
			int a = 10;
			char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
			description = "random description: ";
			for (int i = 0; i != desc_len; i++)
            {
				a--;
				if (random.Next(0, 40) == 1 || a == 0)
				{
					a = random.Next(0, 40);
					description += "\n";
				}
				description = description + alphabet[random.Next(0, 26)];
			}
			name = "idea name " + ID;
			risk_level = ID ^ (random.Next(0, 255));
			cost = (float)(random.Next(ID, 10000 + ID));
			product_tag = "type - " + random.Next(0, 255) + " investment";
			admin_level = random.Next(0, 5);

		}
		//This is used to contruct an investment idea. - J
		public InvestmentIdea(DateTime n_date, string n_name, string n_description, int n_ID, int n_risk_level, float n_cost, string n_product_tag, int n_admin_level)
        {
			expiry_date = n_date;
			ID = n_ID;
			name = n_name;
			description = n_description;
			risk_level = n_risk_level;
			cost = n_cost;
			product_tag = n_product_tag;
			admin_level = n_admin_level;
		}

		DateTime expiry_date;
		string name, description, product_tag;
		int ID, user_ID, risk_level, admin_level;
		float cost;

		public DateTime getDate()				{ return expiry_date;	}
		public string	getName()				{ return name;			}
		public string	getDescription()		{ return description;	}
		public int		getID()					{ return ID;			}
		public int		getUserID()				{ return user_ID;		}
		public int		getRiskLevel()			{ return risk_level;	}
		public float	getCost()				{ return cost;			}
		public string	getInvestmentType()		{ return product_tag;	}
		public int		getRmAdminLevel()		{ return admin_level;	}

		public void setDate(DateTime n_date)				{ expiry_date		= n_date;			}
		public void setName(string n_name)					{ name				= n_name;			}
		public void setDescription(string n_description)	{ description		= n_description;	}
		public void setID(int n_ID)							{ ID				= n_ID;				}
		public void setUserID(int n_user_ID)				{ user_ID			= n_user_ID;		}
		public void setRiskLevel(int n_risk_level) 			{ risk_level		= n_risk_level;		}
		public void setCost(float n_cost)					{ cost				= n_cost;			}
		public void setInvestmentType(string n_product_tag)	{ product_tag		= n_product_tag;	}
		public void setAdminLevel(int n_admin_level)		{ admin_level = n_admin_level;			}

		public string getAsLabelString()
		{
			return (
				"ID: " + ID +
				"\nName: " + name +
				"\nDescription: " + description +
				"\nRisk level: " + risk_level +
				"\n:Cost: " + cost +
				"\n:Date: " + expiry_date.ToString() +
				"\n:investment type: " + product_tag.ToString() +
				"\n:permission level: " + admin_level
				);
		}
	}
}
