
namespace aru_software_eng_UI
{
    partial class DatabaseWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRelationshipManagerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginEntriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coreDataBaseDataSet = new aru_software_eng_UI.CoreDataBaseDataSet();
            this.userLoginDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.username_entrybx = new System.Windows.Forms.TextBox();
            this.AddLoginButton = new System.Windows.Forms.Button();
            this.DeleteLastLoginButton = new System.Windows.Forms.Button();
            this.email_entrybx = new System.Windows.Forms.TextBox();
            this.KillwindowButton = new System.Windows.Forms.Button();
            this.login_generator_btn = new System.Windows.Forms.Button();
            this.loginEntriesTableAdapter = new aru_software_eng_UI.CoreDataBaseDataSetTableAdapters.LoginEntriesTableAdapter();
            this.login_search_btn = new System.Windows.Forms.Button();
            this.search_bar = new System.Windows.Forms.TextBox();
            this.login_output_data_lbl = new System.Windows.Forms.Label();
            this.password_entrybx = new System.Windows.Forms.TextBox();
            this.is_rm_manager_chckbx = new System.Windows.Forms.CheckBox();
            this.display_label = new System.Windows.Forms.Label();
            this.generated_user_entry_display = new System.Windows.Forms.Label();
            this.delete_user_btn = new System.Windows.Forms.Button();
            this.username_delete_search_txtbox = new System.Windows.Forms.TextBox();
            this.LoginEntryViewer = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRelationshipManagerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlTabs = new System.Windows.Forms.TabControl();
            this.login_controls = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login_generator = new System.Windows.Forms.TabPage();
            this.search = new System.Windows.Forms.TabPage();
            this.deletion = new System.Windows.Forms.TabPage();
            this.email_search_btn = new System.Windows.Forms.Button();
            this.email_search_textbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginEntriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coreDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginEntryViewer)).BeginInit();
            this.ControlTabs.SuspendLayout();
            this.login_controls.SuspendLayout();
            this.login_generator.SuspendLayout();
            this.search.SuspendLayout();
            this.deletion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.isRelationshipManagerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loginEntriesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 327);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(1087, 545);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn1.HeaderText = "Username";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn2.HeaderText = "Password";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // isRelationshipManagerDataGridViewTextBoxColumn
            // 
            this.isRelationshipManagerDataGridViewTextBoxColumn.DataPropertyName = "Is_RelationshipManager";
            this.isRelationshipManagerDataGridViewTextBoxColumn.HeaderText = "Is_RelationshipManager";
            this.isRelationshipManagerDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.isRelationshipManagerDataGridViewTextBoxColumn.Name = "isRelationshipManagerDataGridViewTextBoxColumn";
            this.isRelationshipManagerDataGridViewTextBoxColumn.Width = 200;
            // 
            // loginEntriesBindingSource
            // 
            this.loginEntriesBindingSource.DataMember = "LoginEntries";
            this.loginEntriesBindingSource.DataSource = this.coreDataBaseDataSet;
            // 
            // coreDataBaseDataSet
            // 
            this.coreDataBaseDataSet.DataSetName = "CoreDataBaseDataSet";
            this.coreDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userLoginDataBindingSource
            // 
            this.userLoginDataBindingSource.DataMember = "UserLoginData";
            // 
            // username_entrybx
            // 
            this.username_entrybx.Location = new System.Drawing.Point(131, 13);
            this.username_entrybx.Margin = new System.Windows.Forms.Padding(6);
            this.username_entrybx.Name = "username_entrybx";
            this.username_entrybx.Size = new System.Drawing.Size(324, 31);
            this.username_entrybx.TabIndex = 1;
            // 
            // AddLoginButton
            // 
            this.AddLoginButton.Location = new System.Drawing.Point(131, 177);
            this.AddLoginButton.Margin = new System.Windows.Forms.Padding(6);
            this.AddLoginButton.Name = "AddLoginButton";
            this.AddLoginButton.Size = new System.Drawing.Size(324, 42);
            this.AddLoginButton.TabIndex = 2;
            this.AddLoginButton.Text = "Add new login";
            this.AddLoginButton.UseVisualStyleBackColor = true;
            this.AddLoginButton.Click += new System.EventHandler(this.AddLoginButton_Click);
            // 
            // DeleteLastLoginButton
            // 
            this.DeleteLastLoginButton.Location = new System.Drawing.Point(6, 6);
            this.DeleteLastLoginButton.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteLastLoginButton.Name = "DeleteLastLoginButton";
            this.DeleteLastLoginButton.Size = new System.Drawing.Size(196, 41);
            this.DeleteLastLoginButton.TabIndex = 4;
            this.DeleteLastLoginButton.Text = "Delete last login";
            this.DeleteLastLoginButton.UseVisualStyleBackColor = true;
            this.DeleteLastLoginButton.Click += new System.EventHandler(this.DeleteLastLoginButton_Click);
            // 
            // email_entrybx
            // 
            this.email_entrybx.Location = new System.Drawing.Point(131, 56);
            this.email_entrybx.Margin = new System.Windows.Forms.Padding(6);
            this.email_entrybx.Name = "email_entrybx";
            this.email_entrybx.Size = new System.Drawing.Size(324, 31);
            this.email_entrybx.TabIndex = 3;
            // 
            // KillwindowButton
            // 
            this.KillwindowButton.BackColor = System.Drawing.Color.DarkRed;
            this.KillwindowButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.KillwindowButton.Location = new System.Drawing.Point(15, 15);
            this.KillwindowButton.Margin = new System.Windows.Forms.Padding(6);
            this.KillwindowButton.Name = "KillwindowButton";
            this.KillwindowButton.Size = new System.Drawing.Size(112, 88);
            this.KillwindowButton.TabIndex = 5;
            this.KillwindowButton.Text = "Kill window";
            this.KillwindowButton.UseVisualStyleBackColor = false;
            this.KillwindowButton.Click += new System.EventHandler(this.KillwindowButton_Click);
            // 
            // login_generator_btn
            // 
            this.login_generator_btn.Location = new System.Drawing.Point(9, 22);
            this.login_generator_btn.Margin = new System.Windows.Forms.Padding(6);
            this.login_generator_btn.Name = "login_generator_btn";
            this.login_generator_btn.Size = new System.Drawing.Size(438, 31);
            this.login_generator_btn.TabIndex = 9;
            this.login_generator_btn.Text = "Generate new login";
            this.login_generator_btn.UseVisualStyleBackColor = true;
            this.login_generator_btn.Click += new System.EventHandler(this.login_generator_btn_Click);
            // 
            // loginEntriesTableAdapter
            // 
            this.loginEntriesTableAdapter.ClearBeforeFill = true;
            // 
            // login_search_btn
            // 
            this.login_search_btn.Location = new System.Drawing.Point(6, 24);
            this.login_search_btn.Margin = new System.Windows.Forms.Padding(6);
            this.login_search_btn.Name = "login_search_btn";
            this.login_search_btn.Size = new System.Drawing.Size(201, 31);
            this.login_search_btn.TabIndex = 10;
            this.login_search_btn.Text = "search username";
            this.login_search_btn.UseVisualStyleBackColor = true;
            this.login_search_btn.Click += new System.EventHandler(this.login_search_btn_Click);
            // 
            // search_bar
            // 
            this.search_bar.Location = new System.Drawing.Point(219, 24);
            this.search_bar.Margin = new System.Windows.Forms.Padding(6);
            this.search_bar.Name = "search_bar";
            this.search_bar.Size = new System.Drawing.Size(438, 31);
            this.search_bar.TabIndex = 11;
            // 
            // login_output_data_lbl
            // 
            this.login_output_data_lbl.AutoSize = true;
            this.login_output_data_lbl.Location = new System.Drawing.Point(3, 295);
            this.login_output_data_lbl.Name = "login_output_data_lbl";
            this.login_output_data_lbl.Size = new System.Drawing.Size(122, 25);
            this.login_output_data_lbl.TabIndex = 12;
            this.login_output_data_lbl.Text = "Login Data:";
            // 
            // password_entrybx
            // 
            this.password_entrybx.Location = new System.Drawing.Point(131, 99);
            this.password_entrybx.Margin = new System.Windows.Forms.Padding(6);
            this.password_entrybx.Name = "password_entrybx";
            this.password_entrybx.Size = new System.Drawing.Size(324, 31);
            this.password_entrybx.TabIndex = 13;
            // 
            // is_rm_manager_chckbx
            // 
            this.is_rm_manager_chckbx.AutoSize = true;
            this.is_rm_manager_chckbx.Location = new System.Drawing.Point(131, 139);
            this.is_rm_manager_chckbx.Name = "is_rm_manager_chckbx";
            this.is_rm_manager_chckbx.Size = new System.Drawing.Size(279, 29);
            this.is_rm_manager_chckbx.TabIndex = 14;
            this.is_rm_manager_chckbx.Text = "is relationship manager?";
            this.is_rm_manager_chckbx.UseVisualStyleBackColor = true;
            // 
            // display_label
            // 
            this.display_label.AutoSize = true;
            this.display_label.Location = new System.Drawing.Point(6, 59);
            this.display_label.Name = "display_label";
            this.display_label.Size = new System.Drawing.Size(220, 25);
            this.display_label.TabIndex = 7;
            this.display_label.Text = "Generated User Entry";
            // 
            // generated_user_entry_display
            // 
            this.generated_user_entry_display.AutoSize = true;
            this.generated_user_entry_display.Location = new System.Drawing.Point(6, 84);
            this.generated_user_entry_display.Name = "generated_user_entry_display";
            this.generated_user_entry_display.Size = new System.Drawing.Size(222, 25);
            this.generated_user_entry_display.TabIndex = 8;
            this.generated_user_entry_display.Text = "no data generated yet";
            // 
            // delete_user_btn
            // 
            this.delete_user_btn.Location = new System.Drawing.Point(6, 59);
            this.delete_user_btn.Margin = new System.Windows.Forms.Padding(6);
            this.delete_user_btn.Name = "delete_user_btn";
            this.delete_user_btn.Size = new System.Drawing.Size(196, 41);
            this.delete_user_btn.TabIndex = 15;
            this.delete_user_btn.Text = "Delete user:";
            this.delete_user_btn.UseVisualStyleBackColor = true;
            this.delete_user_btn.Click += new System.EventHandler(this.delete_user_btn_Click);
            // 
            // username_delete_search_txtbox
            // 
            this.username_delete_search_txtbox.Location = new System.Drawing.Point(214, 64);
            this.username_delete_search_txtbox.Margin = new System.Windows.Forms.Padding(6);
            this.username_delete_search_txtbox.Name = "username_delete_search_txtbox";
            this.username_delete_search_txtbox.Size = new System.Drawing.Size(438, 31);
            this.username_delete_search_txtbox.TabIndex = 16;
            // 
            // LoginEntryViewer
            // 
            this.LoginEntryViewer.AutoGenerateColumns = false;
            this.LoginEntryViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoginEntryViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.usernameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn1,
            this.passwordDataGridViewTextBoxColumn,
            this.isRelationshipManagerDataGridViewTextBoxColumn1});
            this.LoginEntryViewer.DataSource = this.loginEntriesBindingSource;
            this.LoginEntryViewer.Location = new System.Drawing.Point(778, 151);
            this.LoginEntryViewer.Name = "LoginEntryViewer";
            this.LoginEntryViewer.RowHeadersWidth = 82;
            this.LoginEntryViewer.RowTemplate.Height = 33;
            this.LoginEntryViewer.Size = new System.Drawing.Size(1086, 505);
            this.LoginEntryViewer.TabIndex = 17;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Width = 200;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 200;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.Width = 200;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 200;
            // 
            // isRelationshipManagerDataGridViewTextBoxColumn1
            // 
            this.isRelationshipManagerDataGridViewTextBoxColumn1.DataPropertyName = "Is_RelationshipManager";
            this.isRelationshipManagerDataGridViewTextBoxColumn1.HeaderText = "Is_RelationshipManager";
            this.isRelationshipManagerDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.isRelationshipManagerDataGridViewTextBoxColumn1.Name = "isRelationshipManagerDataGridViewTextBoxColumn1";
            this.isRelationshipManagerDataGridViewTextBoxColumn1.Width = 200;
            // 
            // ControlTabs
            // 
            this.ControlTabs.Controls.Add(this.login_controls);
            this.ControlTabs.Controls.Add(this.login_generator);
            this.ControlTabs.Controls.Add(this.search);
            this.ControlTabs.Controls.Add(this.deletion);
            this.ControlTabs.Location = new System.Drawing.Point(15, 112);
            this.ControlTabs.Name = "ControlTabs";
            this.ControlTabs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ControlTabs.SelectedIndex = 0;
            this.ControlTabs.Size = new System.Drawing.Size(757, 544);
            this.ControlTabs.TabIndex = 18;
            // 
            // login_controls
            // 
            this.login_controls.Controls.Add(this.label3);
            this.login_controls.Controls.Add(this.label2);
            this.login_controls.Controls.Add(this.label1);
            this.login_controls.Controls.Add(this.AddLoginButton);
            this.login_controls.Controls.Add(this.is_rm_manager_chckbx);
            this.login_controls.Controls.Add(this.username_entrybx);
            this.login_controls.Controls.Add(this.password_entrybx);
            this.login_controls.Controls.Add(this.email_entrybx);
            this.login_controls.Location = new System.Drawing.Point(8, 39);
            this.login_controls.Name = "login_controls";
            this.login_controls.Padding = new System.Windows.Forms.Padding(3);
            this.login_controls.Size = new System.Drawing.Size(741, 497);
            this.login_controls.TabIndex = 0;
            this.login_controls.Text = "Login control";
            this.login_controls.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // login_generator
            // 
            this.login_generator.Controls.Add(this.login_generator_btn);
            this.login_generator.Controls.Add(this.display_label);
            this.login_generator.Controls.Add(this.generated_user_entry_display);
            this.login_generator.Location = new System.Drawing.Point(8, 39);
            this.login_generator.Name = "login_generator";
            this.login_generator.Padding = new System.Windows.Forms.Padding(3);
            this.login_generator.Size = new System.Drawing.Size(741, 497);
            this.login_generator.TabIndex = 1;
            this.login_generator.Text = "Login generator";
            this.login_generator.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Controls.Add(this.email_search_btn);
            this.search.Controls.Add(this.email_search_textbx);
            this.search.Controls.Add(this.login_search_btn);
            this.search.Controls.Add(this.search_bar);
            this.search.Controls.Add(this.login_output_data_lbl);
            this.search.Location = new System.Drawing.Point(8, 39);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(741, 497);
            this.search.TabIndex = 2;
            this.search.Text = "Searches";
            this.search.UseVisualStyleBackColor = true;
            // 
            // deletion
            // 
            this.deletion.Controls.Add(this.DeleteLastLoginButton);
            this.deletion.Controls.Add(this.delete_user_btn);
            this.deletion.Controls.Add(this.username_delete_search_txtbox);
            this.deletion.Location = new System.Drawing.Point(8, 39);
            this.deletion.Name = "deletion";
            this.deletion.Size = new System.Drawing.Size(741, 497);
            this.deletion.TabIndex = 3;
            this.deletion.Text = "Deletion";
            this.deletion.UseVisualStyleBackColor = true;
            // 
            // email_search_btn
            // 
            this.email_search_btn.Location = new System.Drawing.Point(6, 67);
            this.email_search_btn.Margin = new System.Windows.Forms.Padding(6);
            this.email_search_btn.Name = "email_search_btn";
            this.email_search_btn.Size = new System.Drawing.Size(201, 31);
            this.email_search_btn.TabIndex = 13;
            this.email_search_btn.Text = "search email";
            this.email_search_btn.UseVisualStyleBackColor = true;
            this.email_search_btn.Click += new System.EventHandler(this.email_search_btn_Click);
            // 
            // email_search_textbx
            // 
            this.email_search_textbx.Location = new System.Drawing.Point(219, 67);
            this.email_search_textbx.Margin = new System.Windows.Forms.Padding(6);
            this.email_search_textbx.Name = "email_search_textbx";
            this.email_search_textbx.Size = new System.Drawing.Size(438, 31);
            this.email_search_textbx.TabIndex = 14;
            // 
            // DatabaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1968, 887);
            this.Controls.Add(this.ControlTabs);
            this.Controls.Add(this.LoginEntryViewer);
            this.Controls.Add(this.KillwindowButton);
            this.Name = "DatabaseWindow";
            this.Text = "DatabaseWindow";
            this.Load += new System.EventHandler(this.DatabaseWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginEntriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coreDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginEntryViewer)).EndInit();
            this.ControlTabs.ResumeLayout(false);
            this.login_controls.ResumeLayout(false);
            this.login_controls.PerformLayout();
            this.login_generator.ResumeLayout(false);
            this.login_generator.PerformLayout();
            this.search.ResumeLayout(false);
            this.search.PerformLayout();
            this.deletion.ResumeLayout(false);
            this.deletion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataBaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource dataBaseDataSet1BindingSource;
        private System.Windows.Forms.BindingSource dataBaseDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource userLoginDataBindingSource;
        private System.Windows.Forms.TextBox username_entrybx;
        private System.Windows.Forms.Button AddLoginButton;
        private System.Windows.Forms.Button DeleteLastLoginButton;
        private System.Windows.Forms.TextBox email_entrybx;
        private System.Windows.Forms.Button KillwindowButton;
        private System.Windows.Forms.Button login_generator_btn;
        private CoreDataBaseDataSet coreDataBaseDataSet;
        private System.Windows.Forms.BindingSource loginEntriesBindingSource;
        private CoreDataBaseDataSetTableAdapters.LoginEntriesTableAdapter loginEntriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn isRelationshipManagerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button login_search_btn;
        private System.Windows.Forms.TextBox search_bar;
        private System.Windows.Forms.Label login_output_data_lbl;
        private System.Windows.Forms.TextBox password_entrybx;
        private System.Windows.Forms.CheckBox is_rm_manager_chckbx;
        private System.Windows.Forms.Label display_label;
        private System.Windows.Forms.Label generated_user_entry_display;
        private System.Windows.Forms.Button delete_user_btn;
        private System.Windows.Forms.TextBox username_delete_search_txtbox;
        private System.Windows.Forms.DataGridView LoginEntryViewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isRelationshipManagerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabControl ControlTabs;
        private System.Windows.Forms.TabPage login_controls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage login_generator;
        private System.Windows.Forms.TabPage search;
        private System.Windows.Forms.TabPage deletion;
        private System.Windows.Forms.Button email_search_btn;
        private System.Windows.Forms.TextBox email_search_textbx;
    }
}