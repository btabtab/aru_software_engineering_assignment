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
            if(0 < LoginDatabaseHandler.getInstance().getRowCount())
            {
                test_data_button.Hide();
            }
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
            BackendController.getInstance().writeRandomLoginEntry();
            BackendController.getInstance().getHighestUserIDEntry().setRMPermissionLevel(5);

            for(int i = 0; i != 35; i++)
            {
                BackendController.getInstance().writeRandomInvestmentIdea();
            }
            next_window = new FilterWindow(this, BackendController.getInstance().getHighestUserIDEntry());
        }

        private void TestSorting_Click(object sender, EventArgs e)
        {
            Sorting test = new Sorting();
            test.mergeSortTest();
        }

        private void test_data_button_Click(object sender, EventArgs e)
        {
            BackendController.getInstance().writeLoginDatabaseEntry(new DataBaseLoginEntry("u@mail.net", "u@mail.net", "u@mail.net", true, 4));
            BackendController.getInstance().writeLoginDatabaseEntry(new DataBaseLoginEntry("M@mail.net", "M@mail.net", "M@mail.net", false, 0));
            
            for (int i = 0; i != 17; i++)
            {
                BackendController.getInstance().writeRandomInvestmentIdea();
            }
            test_data_button.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DatabaseWindow(this);
        }
    }
}
