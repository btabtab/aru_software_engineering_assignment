using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aru_software_eng_UI
{
    public partial class StartMenu : Form
    {
        Form next_window;
        public StartMenu()
        {
            InitializeComponent();
        }
        private void LoginPage_Load(object sender, EventArgs e)
        {
        }

        private void IdeaGenBTN_Click(object sender, EventArgs e)
        {
            next_window = new IdeaGeneratorLogin(this);
        }

        private void RelationshipManagerBTN_Click(object sender, EventArgs e)
        {
            RelationshipManagerLogin rm_window = new RelationshipManagerLogin(this);
        }

        private void CreateAccountBTN_Click(object sender, EventArgs e)
        {
            next_window = new Signup(this);
        }
        private void DatabaseDisplay_Click(object sender, EventArgs e)
        {
            next_window = new DatabaseWindow(this);
        }

        private void showRMTEST_Click(object sender, EventArgs e)
        {
//            List<InvestmentIdea> test_list = new List<InvestmentIdea>();
//            for(int i = 0; i != 30; i++)
//            {
//                DataBaseLoginEntry ins = new DataBaseLoginEntry();
//                LoginDatabaseHandler.getInstance().addNewLogin(ins);
//                test_list.Add(new InvestmentIdea(i, ins.getID()));
//            }
            next_window = new FilterWindow(this, BackendController.getInstance().randomEntry());
        }

        private void TestSorting_Click(object sender, EventArgs e)
        {
            Sorting test = new Sorting();
            test.mergeSortTest();
        }
    }
}
