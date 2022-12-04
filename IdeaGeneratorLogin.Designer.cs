
namespace aru_software_eng_UI
{
    partial class IdeaGeneratorLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdeaGeneratorLogin));
            this.IG_back_button = new System.Windows.Forms.Button();
            this.IG_password_textbox = new System.Windows.Forms.TextBox();
            this.IG_login_textbox = new System.Windows.Forms.TextBox();
            this.IG_password_label = new System.Windows.Forms.Label();
            this.IG_login_label = new System.Windows.Forms.Label();
            this.IG_login_button = new System.Windows.Forms.Button();
            this.IG_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IG_back_button
            // 
            this.IG_back_button.Image = ((System.Drawing.Image)(resources.GetObject("IG_back_button.Image")));
            this.IG_back_button.Location = new System.Drawing.Point(702, 12);
            this.IG_back_button.Name = "IG_back_button";
            this.IG_back_button.Size = new System.Drawing.Size(128, 64);
            this.IG_back_button.TabIndex = 15;
            this.IG_back_button.UseVisualStyleBackColor = true;
            this.IG_back_button.Click += new System.EventHandler(this.IG_Back_Button_Click);
            // 
            // IG_password_textbox
            // 
            this.IG_password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IG_password_textbox.Location = new System.Drawing.Point(294, 251);
            this.IG_password_textbox.Name = "IG_password_textbox";
            this.IG_password_textbox.Size = new System.Drawing.Size(502, 53);
            this.IG_password_textbox.TabIndex = 14;
            // 
            // IG_login_textbox
            // 
            this.IG_login_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IG_login_textbox.Location = new System.Drawing.Point(294, 171);
            this.IG_login_textbox.Name = "IG_login_textbox";
            this.IG_login_textbox.Size = new System.Drawing.Size(502, 53);
            this.IG_login_textbox.TabIndex = 13;
            // 
            // IG_password_label
            // 
            this.IG_password_label.AutoSize = true;
            this.IG_password_label.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IG_password_label.Location = new System.Drawing.Point(12, 250);
            this.IG_password_label.Name = "IG_password_label";
            this.IG_password_label.Size = new System.Drawing.Size(163, 50);
            this.IG_password_label.TabIndex = 12;
            this.IG_password_label.Text = "Password:";
            // 
            // IG_login_label
            // 
            this.IG_login_label.AutoSize = true;
            this.IG_login_label.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IG_login_label.Location = new System.Drawing.Point(10, 174);
            this.IG_login_label.Name = "IG_login_label";
            this.IG_login_label.Size = new System.Drawing.Size(98, 50);
            this.IG_login_label.TabIndex = 11;
            this.IG_login_label.Text = "Login:";
            // 
            // IG_login_button
            // 
            this.IG_login_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.IG_login_button.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IG_login_button.ForeColor = System.Drawing.SystemColors.Control;
            this.IG_login_button.Location = new System.Drawing.Point(21, 349);
            this.IG_login_button.Name = "IG_login_button";
            this.IG_login_button.Size = new System.Drawing.Size(775, 86);
            this.IG_login_button.TabIndex = 9;
            this.IG_login_button.Text = "Login";
            this.IG_login_button.UseVisualStyleBackColor = false;
            this.IG_login_button.Click += new System.EventHandler(this.IG_login_button_Click);
            // 
            // IG_text
            // 
            this.IG_text.AutoSize = true;
            this.IG_text.Font = new System.Drawing.Font("Agency FB", 50F, System.Drawing.FontStyle.Bold);
            this.IG_text.Location = new System.Drawing.Point(0, 0);
            this.IG_text.Name = "IG_text";
            this.IG_text.Size = new System.Drawing.Size(379, 80);
            this.IG_text.TabIndex = 10;
            this.IG_text.Text = "Idea Generator";
            // 
            // IdeaGeneratorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.IG_back_button);
            this.Controls.Add(this.IG_password_textbox);
            this.Controls.Add(this.IG_login_textbox);
            this.Controls.Add(this.IG_password_label);
            this.Controls.Add(this.IG_login_label);
            this.Controls.Add(this.IG_text);
            this.Controls.Add(this.IG_login_button);
            this.Name = "IdeaGeneratorLogin";
            this.Text = "IdeaGeneratorLoginLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IG_back_button;
        private System.Windows.Forms.TextBox IG_password_textbox;
        private System.Windows.Forms.TextBox IG_login_textbox;
        private System.Windows.Forms.Label IG_password_label;
        private System.Windows.Forms.Label IG_login_label;
        private System.Windows.Forms.Button IG_login_button;
        private System.Windows.Forms.Label IG_text;
    }
}