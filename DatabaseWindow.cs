using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace aru_software_eng_UI
{
	public partial class DatabaseWindow : Form
	{
		FormManager manager;
		BackendController backend_controller;
		public DatabaseWindow(Form n_previous_window)
		{
			InitializeComponent();
			manager = new FormManager(n_previous_window, this);
			backend_controller = BackendController.getInstance();
		}

		void updateTable()
		{
			loginEntriesTableAdapter.Fill(this.coreDataBaseDataSet.LoginEntries);
			investmentIdeasTableAdapter.Fill(this.coreDataBaseDataSet.InvestmentIdeas);

			//this.loginEntriesTableAdapter1.Fill(this.coreDataSet.LoginEntries);
		}

		private void KillwindowButton_Click(object sender, EventArgs e)
		{
			manager.back();
		}

		private void AddLoginButton_Click(object sender, EventArgs e)
		{
			backend_controller.writeLoginDatabaseEntry(new DataBaseLoginEntry(
																			username_entrybx.Text,
																			password_entrybx.Text,
																			email_entrybx.Text,
																			is_rm_manager_chckbx.Checked,
																			rm_level.Value
																			)
													);
			updateTable();
		}

		private void DeleteLastLoginButton_Click(object sender, EventArgs e)
		{
			backend_controller.deleteHighestLoginID();
			backend_controller.deleteHighestInvestmentIdeaID();
			updateTable();
		}

		private void login_generator_btn_Click(object sender, EventArgs e)
		{
			backend_controller.writeRandomLoginEntry();

			updateTable();
		}

		private void DatabaseWindow_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'coreDataBaseDataSet.InvestmentIdeas' table. You can move, or remove it, as needed.
            this.investmentIdeasTableAdapter.Fill(this.coreDataBaseDataSet.InvestmentIdeas);
            // TODO: This line of code loads data into the 'coreDataBaseDataSet.LoginEntries' table. You can move, or remove it, as needed.
            this.loginEntriesTableAdapter.Fill(this.coreDataBaseDataSet.LoginEntries);
            // TODO: This line of code loads data into the 'coreDataBaseDataSet.LoginEntries' table. You can move, or remove it, as needed.
            this.loginEntriesTableAdapter.Fill(this.coreDataBaseDataSet.LoginEntries);
            // TODO: This line of code loads data into the 'coreDataBaseDataSet.InvestmentIdeas' table. You can move, or remove it, as needed.
            this.investmentIdeasTableAdapter.Fill(this.coreDataBaseDataSet.InvestmentIdeas);
            // TODO: This line of code loads data into the 'coreDataBaseDataSet.LoginEntries' table. You can move, or remove it, as needed.
            this.loginEntriesTableAdapter.Fill(this.coreDataBaseDataSet.LoginEntries);
            updateTable();
		}

		private void delete_user_btn_Click(object sender, EventArgs e)
        {
			backend_controller.deleteUserFromLoginTable(username_delete_search_txtbox.Text);

			updateTable();
		}

		private void login_search_btn_Click(object sender, EventArgs e)
		{
			login_output_data_lbl.Text = backend_controller.loginSearchUsername(search_bar.Text).getAsLabelString();
		}

		private void email_search_btn_Click(object sender, EventArgs e)
        {
			login_output_data_lbl.Text = backend_controller.loginSearchEmail(email_search_textbx.Text).getAsLabelString();

		}

        private void login_master_button_Click(object sender, EventArgs e)
        {
			//makes random entry. -[ John | SID: 2118490 ]
			backend_controller.writeRandomLoginEntry();

			updateTable();
			//gets the highest ID in the table (the entry just made) and displays it on the button. -[ John | SID: 2118490 ]
			login_master_button.Text = backend_controller.getHighestUserIDEntry().getAsLabelString();

			//delets the highest login (being the just made entry). -[ John | SID: 2118490 ]
			backend_controller.deleteHighestLoginID();

			updateTable();
		}

        private void button2_Click(object sender, EventArgs e)
        {
			backend_controller.writeRandomInvestmentIdea();
			updateTable();
        }

        private void button7_Click(object sender, EventArgs e)
        {
			backend_controller.writeRandomLoginEntry();
			updateTable();

			for(int i = 0; i != 10; i++)
            {
				backend_controller.writeRandomInvestmentIdea();
            }
			for(int i = 0; i != 10; i++)
            {
				backend_controller.deleteHighestInvestmentIdeaID();
            }
				
		}

        private void TestGenerator_Click(object sender, EventArgs e)
        {
			backend_controller.writeLoginDatabaseEntry(new DataBaseLoginEntry("u@mail.net", "u@mail.net", "u@mail.net", true,	4));
			backend_controller.writeLoginDatabaseEntry(new DataBaseLoginEntry("M@mail.net", "M@mail.net", "M@mail.net", false,	0));
			updateTable();

			for (int i = 0; i != 17; i++)
			{
				backend_controller.writeRandomInvestmentIdea();
			}
		}
    }
}
