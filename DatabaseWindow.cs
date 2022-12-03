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
	/*TODO:
	 * Update controls on the interface
	 */
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
																			is_rm_manager_chckbx.Checked
																			)
													);
			updateTable();
		}

		private void DeleteLastLoginButton_Click(object sender, EventArgs e)
		{
			backend_controller.deleteHighestLoginID();
			updateTable();
		}

		private void login_generator_btn_Click(object sender, EventArgs e)
		{
			DataBaseLoginEntry r_entry = backend_controller.randomEntry();
			
			//figures out the character to display if the account is a relationship manager account.

			generated_user_entry_display.Text = r_entry.getAsLabelString();

			//UPDATE naming for r_entry.
			backend_controller.writeLoginDatabaseEntry(r_entry);
			updateTable();
		}

		private void DatabaseWindow_Load(object sender, EventArgs e)
		{
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
			backend_controller.writeLoginDatabaseEntry(backend_controller.randomEntry());
			
			updateTable();

			login_master_button.Text = backend_controller.getHighestUserIDEntry().getAsLabelString();

			backend_controller.deleteHighestLoginID();

			updateTable();
		}

        private void button2_Click(object sender, EventArgs e)
        {
			backend_controller.generateRandomInvestmentIdea();
        }
    }
}
