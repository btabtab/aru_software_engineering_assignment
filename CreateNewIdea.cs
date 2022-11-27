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

        Form next_window;
        FormManager manager;
        IdeaSubmitterForm submitterForm;

        public CreateNewIdeaForm(IdeaSubmitterForm ideaSubmitter)
        {
            InitializeComponent();
         
            this.submitterForm = ideaSubmitter;
        }

        private void CreateNewIdea_Load(object sender, EventArgs e)
        {

        }

        private void risk_index_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void expiry_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IS_back_button_Click(object sender, EventArgs e)
        {
            manager.back();
        }

        private void IS_cost_label_Click(object sender, EventArgs e)
        {

        }

        private void IS_back_button_Click_1(object sender, EventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            manager.back();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IS_save_button_Click(object sender, EventArgs e)
        {
            submitterForm.Idea_Submitter_Table.Rows.Add(IS_industry_textbox.Text, IS_cost_textbox.Text, IS_risk_combobox.SelectedIndex, IS_expiry_date.Value, IS_rmrating_combobox.SelectedIndex, IS_description_textbox.Text);
        }
    }
}
