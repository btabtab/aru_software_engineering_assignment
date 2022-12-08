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
    public partial class IdeaSubmitterForm : Form
    {
        FormManager manager;
        DataBaseLoginEntry user;
        public IdeaSubmitterForm(Form n_previous_window, DataBaseLoginEntry n_user)
        {
            InitializeComponent();
            manager = new FormManager(n_previous_window, this);
            user = n_user;
            updateTable();
        }
        void updateTable()
        {
            investmentIdeasTableAdapter.Fill(this.coreDataBaseDataSet.InvestmentIdeas);
        }

        private void New_Idea_Button_Click(object sender, EventArgs e)
        {
            CreateNewIdeaForm newIdeaForm = new CreateNewIdeaForm(this, user);
            updateTable();
        }

        private void IS_Back_Button_Click(object sender, EventArgs e)
        {
            manager.back();
        }

        private void Delete_Idea_Button_Click(object sender, EventArgs e)
        {
            int row_index = 0;
            try
            {
                if (Idea_Submitter_Table.CurrentRow.IsNewRow)
                {
                    return;
                }
                row_index = int.Parse(Idea_Submitter_Table.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            InvestmentIdeaDatabaseHandler.getInstance().deleteInvestmentIdeaRowX(row_index);
            updateTable();
        }
    }
}
