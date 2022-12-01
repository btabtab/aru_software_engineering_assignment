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
        Form next_window;
        FormManager manager;
        BackendController backend_controller;
        public IdeaSubmitterForm(Form n_previous_window, BackendController n_backend_controller)
        {
            InitializeComponent();
            manager = new FormManager(n_previous_window, this);
            backend_controller = n_backend_controller;
        }

<<<<<<< HEAD
        private void New_Idea_Button_Click(object sender, EventArgs e)
        {
            CreateNewIdeaForm newIdeaForm = new CreateNewIdeaForm(this);
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

=======
>>>>>>> Ig_LoginImplementation
        private void IdeaSubmitterForm_Load(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD
=======

        private void New_Idea_Button_Click(object sender, EventArgs e)
        {

        }
>>>>>>> Ig_LoginImplementation
    }
}
