
namespace aru_software_eng_UI
{
    partial class RelationshipManagerViewerUI
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
            this.title_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.risk_label = new System.Windows.Forms.Label();
            this.cost_label = new System.Windows.Forms.Label();
            this.rating_label = new System.Windows.Forms.Label();
            this.divide_line = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.debugShow = new System.Windows.Forms.Label();
            this.page_right_button = new System.Windows.Forms.Button();
            this.page_left_button = new System.Windows.Forms.Button();
            this.page_number_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold);
            this.title_label.Location = new System.Drawing.Point(769, 9);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(79, 50);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Title";
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold);
            this.description_label.Location = new System.Drawing.Point(773, 65);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(90, 26);
            this.description_label.TabIndex = 1;
            this.description_label.Text = "Description";
            // 
            // risk_label
            // 
            this.risk_label.AutoSize = true;
            this.risk_label.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold);
            this.risk_label.Location = new System.Drawing.Point(773, 368);
            this.risk_label.Name = "risk_label";
            this.risk_label.Size = new System.Drawing.Size(53, 26);
            this.risk_label.TabIndex = 2;
            this.risk_label.Text = "Risk: ";
            // 
            // cost_label
            // 
            this.cost_label.AutoSize = true;
            this.cost_label.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold);
            this.cost_label.Location = new System.Drawing.Point(773, 403);
            this.cost_label.Name = "cost_label";
            this.cost_label.Size = new System.Drawing.Size(48, 26);
            this.cost_label.TabIndex = 3;
            this.cost_label.Text = "Cost:";
            this.cost_label.Click += new System.EventHandler(this.cost_label_Click);
            // 
            // rating_label
            // 
            this.rating_label.AutoSize = true;
            this.rating_label.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold);
            this.rating_label.Location = new System.Drawing.Point(773, 438);
            this.rating_label.Name = "rating_label";
            this.rating_label.Size = new System.Drawing.Size(65, 26);
            this.rating_label.TabIndex = 4;
            this.rating_label.Text = "Rating: ";
            // 
            // divide_line
            // 
            this.divide_line.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.divide_line.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.divide_line.Location = new System.Drawing.Point(757, -5);
            this.divide_line.Minimum = 100;
            this.divide_line.Name = "divide_line";
            this.divide_line.Size = new System.Drawing.Size(3, 731);
            this.divide_line.Step = 100;
            this.divide_line.TabIndex = 5;
            this.divide_line.Value = 100;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar2.Location = new System.Drawing.Point(771, 397);
            this.progressBar2.Minimum = 100;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(195, 3);
            this.progressBar2.Step = 100;
            this.progressBar2.TabIndex = 7;
            this.progressBar2.Value = 100;
            // 
            // progressBar3
            // 
            this.progressBar3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar3.Location = new System.Drawing.Point(771, 432);
            this.progressBar3.Minimum = 100;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(195, 3);
            this.progressBar3.Step = 100;
            this.progressBar3.TabIndex = 8;
            this.progressBar3.Value = 100;
            // 
            // progressBar5
            // 
            this.progressBar5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar5.Location = new System.Drawing.Point(771, 362);
            this.progressBar5.Minimum = 100;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(195, 3);
            this.progressBar5.Step = 100;
            this.progressBar5.TabIndex = 10;
            this.progressBar5.Value = 100;
            // 
            // progressBar6
            // 
            this.progressBar6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar6.Location = new System.Drawing.Point(771, 59);
            this.progressBar6.Minimum = 100;
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(195, 3);
            this.progressBar6.Step = 100;
            this.progressBar6.TabIndex = 11;
            this.progressBar6.Value = 100;
            // 
            // debugShow
            // 
            this.debugShow.AutoSize = true;
            this.debugShow.Location = new System.Drawing.Point(778, 502);
            this.debugShow.Name = "debugShow";
            this.debugShow.Size = new System.Drawing.Size(67, 13);
            this.debugShow.TabIndex = 12;
            this.debugShow.Text = "debugoutput";
            this.debugShow.Click += new System.EventHandler(this.debugShow_Click);
            // 
            // page_right_button
            // 
            this.page_right_button.Location = new System.Drawing.Point(897, 526);
            this.page_right_button.Name = "page_right_button";
            this.page_right_button.Size = new System.Drawing.Size(75, 23);
            this.page_right_button.TabIndex = 13;
            this.page_right_button.Text = "->";
            this.page_right_button.UseVisualStyleBackColor = true;
            this.page_right_button.Click += new System.EventHandler(this.page_right_button_Click);
            // 
            // page_left_button
            // 
            this.page_left_button.Location = new System.Drawing.Point(766, 526);
            this.page_left_button.Name = "page_left_button";
            this.page_left_button.Size = new System.Drawing.Size(75, 23);
            this.page_left_button.TabIndex = 14;
            this.page_left_button.Text = "<-";
            this.page_left_button.UseVisualStyleBackColor = true;
            this.page_left_button.Click += new System.EventHandler(this.page_left_button_Click);
            // 
            // page_number_label
            // 
            this.page_number_label.AutoSize = true;
            this.page_number_label.Location = new System.Drawing.Point(863, 531);
            this.page_number_label.Name = "page_number_label";
            this.page_number_label.Size = new System.Drawing.Size(13, 13);
            this.page_number_label.TabIndex = 15;
            this.page_number_label.Text = "1";
            this.page_number_label.Click += new System.EventHandler(this.page_number_label_Click);
            // 
            // RelationshipManagerViewerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.page_number_label);
            this.Controls.Add(this.page_left_button);
            this.Controls.Add(this.page_right_button);
            this.Controls.Add(this.debugShow);
            this.Controls.Add(this.progressBar6);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.divide_line);
            this.Controls.Add(this.rating_label);
            this.Controls.Add(this.cost_label);
            this.Controls.Add(this.risk_label);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.title_label);
            this.Name = "RelationshipManagerViewerUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RelationshipManagerViewerUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label risk_label;
        private System.Windows.Forms.Label cost_label;
        private System.Windows.Forms.Label rating_label;
        private System.Windows.Forms.ProgressBar divide_line;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.Label debugShow;
        private System.Windows.Forms.Button page_right_button;
        private System.Windows.Forms.Button page_left_button;
        private System.Windows.Forms.Label page_number_label;
    }
}