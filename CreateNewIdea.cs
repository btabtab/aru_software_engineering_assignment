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
        BackendController backend_controller;


        public CreateNewIdeaForm(Form n_previous_window, BackendController n_backend_controller)
        {
            InitializeComponent();
            manager = new FormManager(n_previous_window, this);
            backend_controller = n_backend_controller;
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
    }
}
