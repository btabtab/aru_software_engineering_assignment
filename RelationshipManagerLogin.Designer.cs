
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
            System.Windows.Forms.Button RM_login_backbutton;
            this.RMlabel = new System.Windows.Forms.Label();
            RM_login_backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RMlabel
            // 
            this.RMlabel.AutoSize = true;
            this.RMlabel.Font = new System.Drawing.Font("Agency FB", 50F, System.Drawing.FontStyle.Bold);
            this.RMlabel.Location = new System.Drawing.Point(0, 0);
            this.RMlabel.Name = "RMlabel";
            this.RMlabel.Size = new System.Drawing.Size(656, 80);
            this.RMlabel.TabIndex = 0;
            this.RMlabel.Text = "Relationship Manager Login";
            this.RMlabel.Click += new System.EventHandler(this.RMlogin_Click);
            // 
            // RM_login_backbutton
            // 
            RM_login_backbutton.Font = new System.Drawing.Font("Agency FB", 60F, System.Drawing.FontStyle.Bold);
            RM_login_backbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            RM_login_backbutton.Location = new System.Drawing.Point(662, 12);
            RM_login_backbutton.Name = "RM_login_backbutton";
            RM_login_backbutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            RM_login_backbutton.Size = new System.Drawing.Size(126, 68);
            RM_login_backbutton.TabIndex = 1;
            RM_login_backbutton.Text = "←";
            RM_login_backbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            RM_login_backbutton.UseVisualStyleBackColor = true;
            RM_login_backbutton.Click += new System.EventHandler(this.RM_login_backbutton_Click);
            // 
            // RelationshipManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(RM_login_backbutton);
            this.Controls.Add(this.RMlabel);
            this.Name = "RelationshipManagerLogin";
            this.Text = "RelationshipManagerLogin";
            this.Load += new System.EventHandler(this.RelationshipManagerLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RMlabel;
    }
}