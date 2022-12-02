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
    public partial class RelationshipManagerView : Form
    {
        FormManager form_manager;
        public RelationshipManagerView(Form previous_window)
        {
            InitializeComponent();
            form_manager = new FormManager(previous_window, this);
            updateSearchButton();
        }

        private void updateSearchButton()
        {
            SearchButton.Text = "   Min Risk: " + MinRiskTrackBar.Value.ToString() + "                                      SEARCH                               Min Cost: £" + MinCostTrackBar.Value.ToString() + "\n   Max Risk: " + MaxRiskTrackBar.Value.ToString() + "                                                                                 Max Cost: £" + MaxCostTrackBar.Value.ToString();



        }


        private void RelationshipManagerView_Load(object sender, EventArgs e)
        {

        }

       

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void MaxRiskLabel_Click(object sender, EventArgs e)
        {

        }

        private void MinRiskLabel_Click(object sender, EventArgs e)
        {

        }

        private void MinCostLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void MaxCostLabel_Click(object sender, EventArgs e)
        {

        }

        private void MinRiskTrackBar_Scroll(object sender, EventArgs e)
        {
            updateSearchButton();
        }

        private void MinCostTrackBar_Scroll(object sender, EventArgs e)
        {
            updateSearchButton();
        }

        private void MaxRiskTrackBar_Scroll(object sender, EventArgs e)
        {
            updateSearchButton();
        }

        private void MaxCostTrackBar_Scroll(object sender, EventArgs e)
        {
            updateSearchButton();
        }

        private void ExpireDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ExpireDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void IndustryInputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IndustryLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
