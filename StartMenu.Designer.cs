
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
            this.SuspendLayout();
            // 
            // IdeaGenBTN
            // 
            this.IdeaGenBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.IdeaGenBTN.Font = new System.Drawing.Font("Agency FB", 28F, System.Drawing.FontStyle.Bold);
            this.IdeaGenBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IdeaGenBTN.Location = new System.Drawing.Point(12, 205);
            this.IdeaGenBTN.Name = "IdeaGenBTN";
            this.IdeaGenBTN.Size = new System.Drawing.Size(376, 98);
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
            this.RelationshipManagerBTN.Location = new System.Drawing.Point(412, 205);
            this.RelationshipManagerBTN.Name = "RelationshipManagerBTN";
            this.RelationshipManagerBTN.Size = new System.Drawing.Size(376, 98);
            this.RelationshipManagerBTN.TabIndex = 1;
            this.RelationshipManagerBTN.Text = "Relationship Manager";
            this.RelationshipManagerBTN.UseVisualStyleBackColor = false;
            this.RelationshipManagerBTN.Click += new System.EventHandler(this.RelationshipManagerBTN_Click);
            // 
            // CreateAccountBTN
            // 
            this.CreateAccountBTN.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.CreateAccountBTN.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold);
            this.CreateAccountBTN.Location = new System.Drawing.Point(310, 337);
            this.CreateAccountBTN.Name = "CreateAccountBTN";
            this.CreateAccountBTN.Size = new System.Drawing.Size(172, 40);
            this.CreateAccountBTN.TabIndex = 2;
            this.CreateAccountBTN.Text = "Create an Account";
            this.CreateAccountBTN.UseVisualStyleBackColor = true;
            this.CreateAccountBTN.Click += new System.EventHandler(this.CreateAccountBTN_Click);
            // 
            // DatabaseDisplay
            // 
            this.DatabaseDisplay.Location = new System.Drawing.Point(620, 409);
            this.DatabaseDisplay.Name = "DatabaseDisplay";
            this.DatabaseDisplay.Size = new System.Drawing.Size(168, 29);
            this.DatabaseDisplay.TabIndex = 3;
            this.DatabaseDisplay.Text = "Show database test";
            this.DatabaseDisplay.UseVisualStyleBackColor = true;
            this.DatabaseDisplay.Click += new System.EventHandler(this.DatabaseDisplay_Click);
            // 
            // LoginTitleLabel
            // 
            this.LoginTitleLabel.AutoSize = true;
            this.LoginTitleLabel.Font = new System.Drawing.Font("Agency FB", 50F, System.Drawing.FontStyle.Bold);
            this.LoginTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.LoginTitleLabel.Name = "LoginTitleLabel";
            this.LoginTitleLabel.Size = new System.Drawing.Size(151, 80);
            this.LoginTitleLabel.TabIndex = 4;
            this.LoginTitleLabel.Text = "Login";
            // 
            // showRMTEST
            // 
            this.showRMTEST.Location = new System.Drawing.Point(12, 409);
            this.showRMTEST.Name = "showRMTEST";
            this.showRMTEST.Size = new System.Drawing.Size(168, 29);
            this.showRMTEST.TabIndex = 5;
            this.showRMTEST.Text = "Show RM view test";
            this.showRMTEST.UseVisualStyleBackColor = true;
            this.showRMTEST.Click += new System.EventHandler(this.showRMTEST_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showRMTEST);
            this.Controls.Add(this.LoginTitleLabel);
            this.Controls.Add(this.DatabaseDisplay);
            this.Controls.Add(this.CreateAccountBTN);
            this.Controls.Add(this.RelationshipManagerBTN);
            this.Controls.Add(this.IdeaGenBTN);
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
    }
}

