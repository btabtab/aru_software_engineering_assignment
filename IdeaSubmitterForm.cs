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
        BackendController backend_controller;
        DataBaseLoginEntry user;
        public IdeaSubmitterForm(Form n_previous_window, DataBaseLoginEntry n_user)
        {
            InitializeComponent();
            manager = new FormManager(n_previous_window, this);
            user = n_user;
        }
        private void New_Idea_Button_Click(object sender, EventArgs e)
        {
            CreateNewIdeaForm newIdeaForm = new CreateNewIdeaForm(this, user);
            newIdeaForm.Show();
        }

        private void IS_Back_Button_Click(object sender, EventArgs e)
        {
            manager.back();
        }

        private void Idea_Submitter_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Idea_Submitter_Table_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.Idea_Submitter_Table.Rows[e.RowIndex].Cells["Column1"].Value = (e.RowIndex + 1).ToString();
        }

        private void Delete_Idea_Button_Click(object sender, EventArgs e)
        {
            if (Idea_Submitter_Table.CurrentRow.IsNewRow)
            {
                return;

            }
            int rowIndex = Idea_Submitter_Table.CurrentCell.RowIndex;
            Idea_Submitter_Table.Rows.RemoveAt(rowIndex);
        }

        private void IdeaSubmitterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
