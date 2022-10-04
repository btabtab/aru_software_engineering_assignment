
namespace aru_software_eng_UI
{
    partial class CreateAccountButton
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
            this.SuspendLayout();
            // 
            // IdeaGenBTN
            // 
            this.IdeaGenBTN.Location = new System.Drawing.Point(12, 205);
            this.IdeaGenBTN.Name = "IdeaGenBTN";
            this.IdeaGenBTN.Size = new System.Drawing.Size(298, 97);
            this.IdeaGenBTN.TabIndex = 0;
            this.IdeaGenBTN.Text = "Idea Generator";
            this.IdeaGenBTN.UseVisualStyleBackColor = true;
            this.IdeaGenBTN.Click += new System.EventHandler(this.IdeaGenBTN_Click);
            // 
            // RelationshipManagerBTN
            // 
            this.RelationshipManagerBTN.Location = new System.Drawing.Point(490, 205);
            this.RelationshipManagerBTN.Name = "RelationshipManagerBTN";
            this.RelationshipManagerBTN.Size = new System.Drawing.Size(298, 97);
            this.RelationshipManagerBTN.TabIndex = 1;
            this.RelationshipManagerBTN.Text = "Relationship Manager";
            this.RelationshipManagerBTN.UseVisualStyleBackColor = true;
            this.RelationshipManagerBTN.Click += new System.EventHandler(this.RelationshipManagerBTN_Click);
            // 
            // CreateAccountBTN
            // 
            this.CreateAccountBTN.Location = new System.Drawing.Point(316, 273);
            this.CreateAccountBTN.Name = "CreateAccountBTN";
            this.CreateAccountBTN.Size = new System.Drawing.Size(168, 29);
            this.CreateAccountBTN.TabIndex = 2;
            this.CreateAccountBTN.Text = "Create an Account";
            this.CreateAccountBTN.UseVisualStyleBackColor = true;
            this.CreateAccountBTN.Click += new System.EventHandler(this.CreateAccountBTN_Click);
            // 
            // CreateAccountButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateAccountBTN);
            this.Controls.Add(this.RelationshipManagerBTN);
            this.Controls.Add(this.IdeaGenBTN);
            this.Name = "CreateAccountButton";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IdeaGenBTN;
        private System.Windows.Forms.Button RelationshipManagerBTN;
        private System.Windows.Forms.Button CreateAccountBTN;
    }
}

