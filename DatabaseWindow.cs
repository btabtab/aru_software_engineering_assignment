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
			this.loginEntriesTableAdapter.Fill(this.coreDataBaseDataSet.LoginEntries);
		}

		private void KillwindowButton_Click(object sender, EventArgs e)
		{
			manager.back();
		}

		private void AddLoginButton_Click(object sender, EventArgs e)
		{
			backend_controller.writeDatabaseEntry(new DataBaseLoginEntry(
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
			backend_controller.writeDatabaseEntry(r_entry);
			updateTable();
		}

		private void DatabaseWindow_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'coreDataBaseDataSet1.InvestmentIdeaTable' table. You can move, or remove it, as needed.
            this.investmentIdeaTableTableAdapter.Fill(this.coreDataBaseDataSet1.InvestmentIdeaTable);
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
	}
}
