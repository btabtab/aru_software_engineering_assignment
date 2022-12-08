
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
            this.divide_line = new System.Windows.Forms.ProgressBar();
            this.debugShow = new System.Windows.Forms.Label();
            this.page_right_button = new System.Windows.Forms.Button();
            this.page_left_button = new System.Windows.Forms.Button();
            this.page_number_label = new System.Windows.Forms.Label();
            this.DataOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // divide_line
            // 
            this.divide_line.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.divide_line.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.divide_line.Location = new System.Drawing.Point(644, -7);
            this.divide_line.Minimum = 100;
            this.divide_line.Name = "divide_line";
            this.divide_line.Size = new System.Drawing.Size(2, 731);
            this.divide_line.Step = 100;
            this.divide_line.TabIndex = 5;
            this.divide_line.Value = 100;
            this.divide_line.Click += new System.EventHandler(this.divide_line_Click);
            // 
            // debugShow
            // 
            this.debugShow.AutoSize = true;
            this.debugShow.Location = new System.Drawing.Point(774, 489);
            this.debugShow.Name = "debugShow";
            this.debugShow.Size = new System.Drawing.Size(0, 13);
            this.debugShow.TabIndex = 12;
            this.debugShow.Click += new System.EventHandler(this.debugShow_Click);
            // 
            // page_right_button
            // 
            this.page_right_button.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold);
            this.page_right_button.Location = new System.Drawing.Point(861, 508);
            this.page_right_button.Name = "page_right_button";
            this.page_right_button.Size = new System.Drawing.Size(89, 39);
            this.page_right_button.TabIndex = 13;
            this.page_right_button.Text = "->";
            this.page_right_button.UseVisualStyleBackColor = true;
            this.page_right_button.Click += new System.EventHandler(this.page_right_button_Click);
            // 
            // page_left_button
            // 
            this.page_left_button.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold);
            this.page_left_button.Location = new System.Drawing.Point(653, 508);
            this.page_left_button.Name = "page_left_button";
            this.page_left_button.Size = new System.Drawing.Size(89, 39);
            this.page_left_button.TabIndex = 14;
            this.page_left_button.Text = "<-";
            this.page_left_button.UseVisualStyleBackColor = true;
            this.page_left_button.Click += new System.EventHandler(this.page_left_button_Click);
            // 
            // page_number_label
            // 
            this.page_number_label.AutoSize = true;
            this.page_number_label.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page_number_label.Location = new System.Drawing.Point(795, 515);
            this.page_number_label.Name = "page_number_label";
            this.page_number_label.Size = new System.Drawing.Size(16, 25);
            this.page_number_label.TabIndex = 15;
            this.page_number_label.Text = "1";
            this.page_number_label.Click += new System.EventHandler(this.page_number_label_Click);
            // 
            // DataOutputLabel
            // 
            this.DataOutputLabel.AutoSize = true;
            this.DataOutputLabel.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold);
            this.DataOutputLabel.Location = new System.Drawing.Point(653, 5);
            this.DataOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DataOutputLabel.Name = "DataOutputLabel";
            this.DataOutputLabel.Size = new System.Drawing.Size(84, 25);
            this.DataOutputLabel.TabIndex = 16;
            this.DataOutputLabel.Text = "Output Label";
            // 
            // RelationshipManagerViewerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 552);
            this.Controls.Add(this.DataOutputLabel);
            this.Controls.Add(this.page_number_label);
            this.Controls.Add(this.page_left_button);
            this.Controls.Add(this.page_right_button);
            this.Controls.Add(this.debugShow);
            this.Controls.Add(this.divide_line);
            this.Name = "RelationshipManagerViewerUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RelationshipManagerViewerUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar divide_line;
        private System.Windows.Forms.Label debugShow;
        private System.Windows.Forms.Button page_right_button;
        private System.Windows.Forms.Button page_left_button;
        private System.Windows.Forms.Label page_number_label;
        private System.Windows.Forms.Label DataOutputLabel;
    }
}