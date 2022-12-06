
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
            this.CreateAccountBTN = new System.Windows.Forms.Button();
            this.DatabaseDisplay = new System.Windows.Forms.Button();
            this.LoginTitleLabel = new System.Windows.Forms.Label();
            this.showRMTEST = new System.Windows.Forms.Button();
            this.TestSorting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdeaGenBTN
            // 
            this.IdeaGenBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.IdeaGenBTN.Font = new System.Drawing.Font("Agency FB", 28F, System.Drawing.FontStyle.Bold);
            this.IdeaGenBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IdeaGenBTN.Location = new System.Drawing.Point(16, 252);
            this.IdeaGenBTN.Margin = new System.Windows.Forms.Padding(4);
            this.IdeaGenBTN.Name = "IdeaGenBTN";
            this.IdeaGenBTN.Size = new System.Drawing.Size(501, 121);
            this.IdeaGenBTN.TabIndex = 0;
            this.IdeaGenBTN.Text = "Idea Generator";
            this.IdeaGenBTN.UseVisualStyleBackColor = false;
            this.IdeaGenBTN.Click += new System.EventHandler(this.IdeaGenBTN_Click);
            // 
            // RelationshipManagerBTN
            // 
            this.RelationshipManagerBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.RelationshipManagerBTN.Font = new System.Drawing.Font("Agency FB", 28F, System.Drawing.FontStyle.Bold);
            this.RelationshipManagerBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RelationshipManagerBTN.Location = new System.Drawing.Point(549, 252);
            this.RelationshipManagerBTN.Margin = new System.Windows.Forms.Padding(4);
            this.RelationshipManagerBTN.Name = "RelationshipManagerBTN";
            this.RelationshipManagerBTN.Size = new System.Drawing.Size(501, 121);
            this.RelationshipManagerBTN.TabIndex = 1;
            this.RelationshipManagerBTN.Text = "Relationship Manager";
            this.RelationshipManagerBTN.UseVisualStyleBackColor = false;
            this.RelationshipManagerBTN.Click += new System.EventHandler(this.RelationshipManagerBTN_Click);
            // 
            // CreateAccountBTN
            // 
            this.CreateAccountBTN.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.CreateAccountBTN.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold);
            this.CreateAccountBTN.Location = new System.Drawing.Point(413, 415);
            this.CreateAccountBTN.Margin = new System.Windows.Forms.Padding(4);
            this.CreateAccountBTN.Name = "CreateAccountBTN";
            this.CreateAccountBTN.Size = new System.Drawing.Size(229, 49);
            this.CreateAccountBTN.TabIndex = 2;
            this.CreateAccountBTN.Text = "Create an Account";
            this.CreateAccountBTN.UseVisualStyleBackColor = true;
            this.CreateAccountBTN.Click += new System.EventHandler(this.CreateAccountBTN_Click);
            // 
            // DatabaseDisplay
            // 
            this.DatabaseDisplay.Location = new System.Drawing.Point(827, 503);
            this.DatabaseDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.DatabaseDisplay.Name = "DatabaseDisplay";
            this.DatabaseDisplay.Size = new System.Drawing.Size(224, 36);
            this.DatabaseDisplay.TabIndex = 3;
            this.DatabaseDisplay.Text = "Show database test";
            this.DatabaseDisplay.UseVisualStyleBackColor = true;
            this.DatabaseDisplay.Click += new System.EventHandler(this.DatabaseDisplay_Click);
            // 
            // LoginTitleLabel
            // 
            this.LoginTitleLabel.AutoSize = true;
            this.LoginTitleLabel.Font = new System.Drawing.Font("Agency FB", 50F, System.Drawing.FontStyle.Bold);
            this.LoginTitleLabel.Location = new System.Drawing.Point(16, 11);
            this.LoginTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginTitleLabel.Name = "LoginTitleLabel";
            this.LoginTitleLabel.Size = new System.Drawing.Size(187, 101);
            this.LoginTitleLabel.TabIndex = 4;
            this.LoginTitleLabel.Text = "Login";
            // 
            // showRMTEST
            // 
            this.showRMTEST.Location = new System.Drawing.Point(16, 503);
            this.showRMTEST.Margin = new System.Windows.Forms.Padding(4);
            this.showRMTEST.Name = "showRMTEST";
            this.showRMTEST.Size = new System.Drawing.Size(224, 36);
            this.showRMTEST.TabIndex = 5;
            this.showRMTEST.Text = "Show RM view test";
            this.showRMTEST.UseVisualStyleBackColor = true;
            this.showRMTEST.Click += new System.EventHandler(this.showRMTEST_Click);
            // 
            // TestSorting
            // 
            this.TestSorting.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.TestSorting.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold);
            this.TestSorting.Location = new System.Drawing.Point(811, 415);
            this.TestSorting.Margin = new System.Windows.Forms.Padding(4);
            this.TestSorting.Name = "TestSorting";
            this.TestSorting.Size = new System.Drawing.Size(229, 49);
            this.TestSorting.TabIndex = 6;
            this.TestSorting.Text = "Sorting Test";
            this.TestSorting.UseVisualStyleBackColor = true;
            this.TestSorting.Click += new System.EventHandler(this.TestSorting_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.TestSorting);
            this.Controls.Add(this.showRMTEST);
            this.Controls.Add(this.LoginTitleLabel);
            this.Controls.Add(this.DatabaseDisplay);
            this.Controls.Add(this.CreateAccountBTN);
            this.Controls.Add(this.RelationshipManagerBTN);
            this.Controls.Add(this.IdeaGenBTN);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StartMenu";
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IdeaGenBTN;
        private System.Windows.Forms.Button RelationshipManagerBTN;
        private System.Windows.Forms.Button CreateAccountBTN;
        private System.Windows.Forms.Button DatabaseDisplay;
        private System.Windows.Forms.Label LoginTitleLabel;
        private System.Windows.Forms.Button showRMTEST;
        private System.Windows.Forms.Button TestSorting;
    }
}

