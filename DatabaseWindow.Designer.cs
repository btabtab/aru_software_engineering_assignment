
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
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLoginDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDatabaseDataSet = new aru_software_eng_UI.UserDatabaseDataSet();
            this.dataBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddLoginButton = new System.Windows.Forms.Button();
            this.DeleteLastLoginButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.KillwindowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userLoginDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1256, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(688, 840);
            this.dataGridView1.TabIndex = 0;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 200;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 200;
            // 
            // userLoginDataBindingSource
            // 
            this.userLoginDataBindingSource.DataMember = "UserLoginData";
            this.userLoginDataBindingSource.DataSource = this.userDatabaseDataSetBindingSource;
            // 
            // userDatabaseDataSetBindingSource
            // 
            this.userDatabaseDataSetBindingSource.DataSource = this.userDatabaseDataSet;
            this.userDatabaseDataSetBindingSource.Position = 0;
            // 
            // userDatabaseDataSet
            // 
            this.userDatabaseDataSet.DataSetName = "UserDatabaseDataSet";
            this.userDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(768, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(438, 31);
            this.textBox1.TabIndex = 1;
            // 
            // AddLoginButton
            // 
            this.AddLoginButton.Location = new System.Drawing.Point(560, 23);
            this.AddLoginButton.Margin = new System.Windows.Forms.Padding(6);
            this.AddLoginButton.Name = "AddLoginButton";
            this.AddLoginButton.Size = new System.Drawing.Size(196, 88);
            this.AddLoginButton.TabIndex = 2;
            this.AddLoginButton.Text = "Add new login";
            this.AddLoginButton.UseVisualStyleBackColor = true;
            this.AddLoginButton.Click += new System.EventHandler(this.AddLoginButton_Click);
            // 
            // DeleteLastLoginButton
            // 
            this.DeleteLastLoginButton.Location = new System.Drawing.Point(768, 123);
            this.DeleteLastLoginButton.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteLastLoginButton.Name = "DeleteLastLoginButton";
            this.DeleteLastLoginButton.Size = new System.Drawing.Size(442, 38);
            this.DeleteLastLoginButton.TabIndex = 4;
            this.DeleteLastLoginButton.Text = "Delete last login";
            this.DeleteLastLoginButton.UseVisualStyleBackColor = true;
            this.DeleteLastLoginButton.Click += new System.EventHandler(this.DeleteLastLoginButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(768, 73);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(438, 31);
            this.textBox2.TabIndex = 3;
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
            // DatabaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1968, 887);
            this.Controls.Add(this.KillwindowButton);
            this.Controls.Add(this.DeleteLastLoginButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.AddLoginButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DatabaseWindow";
            this.Text = "DatabaseWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataBaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource dataBaseDataSet1BindingSource;
        private System.Windows.Forms.BindingSource dataBaseDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource userDatabaseDataSetBindingSource;
        private UserDatabaseDataSet userDatabaseDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userLoginDataBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddLoginButton;
        private System.Windows.Forms.Button DeleteLastLoginButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button KillwindowButton;
    }
}