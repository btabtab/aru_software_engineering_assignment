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
    public partial class RelationshipManagerFilterView : Form
    {
        InvestmentIdeaDatabaseHandler investment_idea_handler;
        public RelationshipManagerFilterView()
        {
            InitializeComponent();
            investment_idea_handler = InvestmentIdeaDatabaseHandler.getInstance();
        }
        private void RelationshipManagerView_Load(object sender, EventArgs e)
        {
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            new RelationshipManagerViewerUI(this, investment_idea_handler.getFilteredList(new Filters(0, 0, 0, 0, 0, DateTime.Now)));
        }
    }
}
