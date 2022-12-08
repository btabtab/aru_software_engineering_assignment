
namespace aru_software_eng_UI
{
    partial class StartMenu
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
            this.IdeaGenBTN = new System.Windows.Forms.Button();
            this.RelationshipManagerBTN = new System.Windows.Forms.Button();
            this.LoginTitleLabel = new System.Windows.Forms.Label();
            this.test_data_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdeaGenBTN
            // 
            this.IdeaGenBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.IdeaGenBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.IdeaGenBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IdeaGenBTN.Location = new System.Drawing.Point(24, 394);
            this.IdeaGenBTN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.IdeaGenBTN.Name = "IdeaGenBTN";
            this.IdeaGenBTN.Size = new System.Drawing.Size(752, 189);
            this.IdeaGenBTN.TabIndex = 0;
            this.IdeaGenBTN.Text = "Idea Generator";
            this.IdeaGenBTN.UseVisualStyleBackColor = false;
            this.IdeaGenBTN.Click += new System.EventHandler(this.IdeaGenBTN_Click);
            // 
            // RelationshipManagerBTN
            // 
            this.RelationshipManagerBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.RelationshipManagerBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.RelationshipManagerBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RelationshipManagerBTN.Location = new System.Drawing.Point(824, 394);
            this.RelationshipManagerBTN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RelationshipManagerBTN.Name = "RelationshipManagerBTN";
            this.RelationshipManagerBTN.Size = new System.Drawing.Size(752, 189);
            this.RelationshipManagerBTN.TabIndex = 1;
            this.RelationshipManagerBTN.Text = "Relationship Manager";
            this.RelationshipManagerBTN.UseVisualStyleBackColor = false;
            this.RelationshipManagerBTN.Click += new System.EventHandler(this.RelationshipManagerBTN_Click);
            // 
            // LoginTitleLabel
            // 
            this.LoginTitleLabel.AutoSize = true;
            this.LoginTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold);
            this.LoginTitleLabel.Location = new System.Drawing.Point(24, 17);
            this.LoginTitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LoginTitleLabel.Name = "LoginTitleLabel";
            this.LoginTitleLabel.Size = new System.Drawing.Size(400, 153);
            this.LoginTitleLabel.TabIndex = 4;
            this.LoginTitleLabel.Text = "Login";
            // 
            // test_data_button
            // 
            this.test_data_button.Location = new System.Drawing.Point(1406, 785);
            this.test_data_button.Name = "test_data_button";
            this.test_data_button.Size = new System.Drawing.Size(170, 69);
            this.test_data_button.TabIndex = 5;
            this.test_data_button.Text = "Generate Test Data";
            this.test_data_button.UseVisualStyleBackColor = true;
            this.test_data_button.Click += new System.EventHandler(this.test_data_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 785);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 69);
            this.button1.TabIndex = 6;
            this.button1.Text = "Admin window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 866);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.test_data_button);
            this.Controls.Add(this.LoginTitleLabel);
            this.Controls.Add(this.RelationshipManagerBTN);
            this.Controls.Add(this.IdeaGenBTN);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "StartMenu";
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.StartMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IdeaGenBTN;
        private System.Windows.Forms.Button RelationshipManagerBTN;
        private System.Windows.Forms.Label LoginTitleLabel;
        private System.Windows.Forms.Button test_data_button;
        private System.Windows.Forms.Button button1;
    }
}

