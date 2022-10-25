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
    public partial class RelationshipManagerViewerUI : Form 
    {
        FormManager manager;
        BackendController backend_controller;
        public RelationshipManagerViewerUI(Form n_previous_window, BackendController n_backend_controller)
        {
            InitializeComponent();
            manager = new FormManager(n_previous_window, this);
            backend_controller = n_backend_controller;
            Button bubble1 = new Button(); //test code
        }

        private void cost_label_Click(object sender, EventArgs e)
        {

        }
    }
}
