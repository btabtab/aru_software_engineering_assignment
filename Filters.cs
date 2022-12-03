using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aru_software_eng_UI
{
	public class Filters
	{
		public Filters(int n_min_cost, int n_max_cost, int n_min_risk, int n_max_risk, int n_rm_permission_level, DateTime n_expiry_date)
		{
			min_cost = n_min_cost;
			max_cost = n_max_cost;
			min_risk = n_min_risk;
			max_risk = n_max_risk;
			rm_permission_level = n_rm_permission_level;
			expiry_date =  n_expiry_date;
		}

		int min_cost, max_cost;
		int min_risk, max_risk;
		int rm_permission_level;
		DateTime expiry_date;

		public int getMinCost()			{ return min_cost;				}
		public int getMaxCost()			{ return max_cost;				}
		public int getMinRisk()			{ return min_risk;				}
		public int getMaxRisk()			{ return max_risk;				}
		public int getPermissionLevel()	{ return rm_permission_level;	}
		public DateTime getDate()		{ return expiry_date;			}
	}
}
