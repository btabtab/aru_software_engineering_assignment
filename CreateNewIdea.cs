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
    public partial class CreateNewIdeaForm : Form
    {

        FormManager manager;
        DataBaseLoginEntry user;
        public CreateNewIdeaForm(Form previous_form, DataBaseLoginEntry n_user)
        {
            InitializeComponent();
            manager = new FormManager(previous_form, this);
            user = n_user;
        }
        private void IS_back_button_Click(object sender, EventArgs e)
        {
            manager.back();
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            manager.back();
        }

        private void IS_save_button_Click(object sender, EventArgs e)
        {
            InvestmentIdeaDatabaseHandler.getInstance().writeInvestmentIdea(new InvestmentIdea(date_picker.Value, name.Text, desc.Text, InvestmentIdeaDatabaseHandler.getInstance().getHighestID(DatabaseWrapper.InvestmentIdeas, "ID"), user.getID(), Cost.Value, Risk.Value, product_tag.Text, user.getRMPermissionLevel()));
            manager.back();
        }

        private void IS_back_button_Click_2(object sender, EventArgs e)
        {
            manager.back();
        }

    }
}
