namespace aru_software_eng_UI
{
    partial class RelationshipManagerLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelationshipManagerLogin));
            this.RMlabel = new System.Windows.Forms.Label();
            this.RM_backButton = new System.Windows.Forms.Button();
            this.RM_login_name_entry = new System.Windows.Forms.TextBox();
            this.RM_login_password_entry = new System.Windows.Forms.TextBox();
            this.RM_login_name_label = new System.Windows.Forms.Label();
            this.RM_login_password_label = new System.Windows.Forms.Label();
            this.RM_login_manager = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // RMlabel
            // 
            this.RMlabel.AutoSize = true;
            this.RMlabel.Font = new System.Drawing.Font("Agency FB", 50.25F, System.Drawing.FontStyle.Bold);
            this.RMlabel.Location = new System.Drawing.Point(0, 0);
            this.RMlabel.Name = "RMlabel";
            this.RMlabel.Size = new System.Drawing.Size(656, 80);
            this.RMlabel.TabIndex = 0;
            this.RMlabel.Text = "Relationship Manager Login";
            // 
            // RM_backButton
            // 
            this.RM_backButton.Image = ((System.Drawing.Image)(resources.GetObject("RM_backButton.Image")));
            this.RM_backButton.Location = new System.Drawing.Point(694, 12);
            this.RM_backButton.Name = "RM_backButton";
            this.RM_backButton.Size = new System.Drawing.Size(128, 64);
            this.RM_backButton.TabIndex = 5;
            this.RM_backButton.UseVisualStyleBackColor = true;
            this.RM_backButton.Click += new System.EventHandler(this.RM_backButton_Click);
            // 
            // RM_login_name_entry
            // 
            this.RM_login_name_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.RM_login_name_entry.Location = new System.Drawing.Point(294, 171);
            this.RM_login_name_entry.Name = "RM_login_name_entry";
            this.RM_login_name_entry.Size = new System.Drawing.Size(502, 53);
            this.RM_login_name_entry.TabIndex = 1;
            this.RM_login_name_entry.Validating += new System.ComponentModel.CancelEventHandler(this.RM_login_name_entry_Validating);
            // 
            // RM_login_password_entry
            // 
            this.RM_login_password_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.RM_login_password_entry.Location = new System.Drawing.Point(294, 251);
            this.RM_login_password_entry.Name = "RM_login_password_entry";
            this.RM_login_password_entry.PasswordChar = '*';
            this.RM_login_password_entry.Size = new System.Drawing.Size(502, 53);
            this.RM_login_password_entry.TabIndex = 2;
            // 
            // RM_login_name_label
            // 
            this.RM_login_name_label.AutoSize = true;
            this.RM_login_name_label.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold);
            this.RM_login_name_label.Location = new System.Drawing.Point(10, 174);
            this.RM_login_name_label.Name = "RM_login_name_label";
            this.RM_login_name_label.Size = new System.Drawing.Size(167, 50);
            this.RM_login_name_label.TabIndex = 4;
            this.RM_login_name_label.Text = "Username:";
            // 
            // RM_login_password_label
            // 
            this.RM_login_password_label.AutoSize = true;
            this.RM_login_password_label.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold);
            this.RM_login_password_label.Location = new System.Drawing.Point(12, 250);
            this.RM_login_password_label.Name = "RM_login_password_label";
            this.RM_login_password_label.Size = new System.Drawing.Size(163, 50);
            this.RM_login_password_label.TabIndex = 5;
            this.RM_login_password_label.Text = "Password:";
            // 
            // RM_login_manager
            // 
            this.RM_login_manager.BackColor = System.Drawing.SystemColors.Highlight;
            this.RM_login_manager.Font = new System.Drawing.Font("Agency FB", 20.25F);
            this.RM_login_manager.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RM_login_manager.Location = new System.Drawing.Point(21, 349);
            this.RM_login_manager.Name = "RM_login_manager";
            this.RM_login_manager.Size = new System.Drawing.Size(775, 86);
            this.RM_login_manager.TabIndex = 6;
            this.RM_login_manager.Text = "Login";
            this.RM_login_manager.UseVisualStyleBackColor = false;
            this.RM_login_manager.Click += new System.EventHandler(this.RM_login_manager_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RelationshipManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.RM_login_manager);
            this.Controls.Add(this.RM_login_password_label);
            this.Controls.Add(this.RM_login_name_label);
            this.Controls.Add(this.RM_login_password_entry);
            this.Controls.Add(this.RM_login_name_entry);
            this.Controls.Add(this.RM_backButton);
            this.Controls.Add(this.RMlabel);
            this.Name = "RelationshipManagerLogin";
            this.Text = "RelationshipManagerLogin";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RMlabel;
        private System.Windows.Forms.Button RM_backButton;
        private System.Windows.Forms.TextBox RM_login_name_entry;
        private System.Windows.Forms.TextBox RM_login_password_entry;
        private System.Windows.Forms.Label RM_login_name_label;
        private System.Windows.Forms.Label RM_login_password_label;
        private System.Windows.Forms.Button RM_login_manager;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}