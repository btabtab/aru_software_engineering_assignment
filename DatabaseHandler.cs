using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aru_software_eng_UI
{
    class DatabaseHandler
    {
        UserDatabaseDataSet dataset;
        public DatabaseHandler(UserDatabaseDataSet n_dataset)
        {
            dataset = n_dataset;
        }

        void getRowXofLoginData(int row_num)
        {
        }
    }
}