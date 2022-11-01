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
		public DatabaseWindow(Form n_previous_window, BackendController n_backend_controller)
		{
			InitializeComponent();
			manager = new FormManager(n_previous_window, this);
			backend_controller = n_backend_controller;
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
		}

		private void DeleteLastLoginButton_Click(object sender, EventArgs e)
		{
			backend_controller.removeRowFromLoginTable(0);
		}

		private void login_generator_btn_Click(object sender, EventArgs e)
		{
			DataBaseLoginEntry r_entry = backend_controller.randomEntry();
			
			//figures out the character to display if the account is a relationship manager account.
			char is_rm = 'N';
			if(r_entry.getIsRelationshipManager()) { is_rm = ('Y'); }

			generated_user_entry_display.Text = "result:\n" +
				"ID: " + r_entry.getID() + "\n" +
				"Username: " + r_entry.getUsername() + "\n" +
				"Email: " + r_entry.getEmail() + "\n" +
				"Password: " + r_entry.getPassword() + "\n" +
				"Is RM manager: [ " + is_rm + " ]";

			//UPDATE naming for r_entry.
			backend_controller.writeDatabaseEntry(r_entry);
		}

		private void DatabaseWindow_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'coreDataBaseDataSet.LoginEntries' table. You can move, or remove it, as needed.
			this.loginEntriesTableAdapter.Fill(this.coreDataBaseDataSet.LoginEntries);
		}

		private void login_search_btn_Click(object sender, EventArgs e)
		{
			DataBaseLoginEntry output = backend_controller.loginSearchUsername(search_bar.Text);
			login_output_data_lbl.Text = "Username: " + output.getUsername() + " email:" + output.getEmail();
		}
	}
}
