using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aru_software_eng_UI
{
    class BackendController
    {
        DatabaseHandler database_handler;
        public BackendController(DatabaseHandler n_dtbase_hndlr)
        {
            database_handler = n_dtbase_hndlr;
        }
    }
}