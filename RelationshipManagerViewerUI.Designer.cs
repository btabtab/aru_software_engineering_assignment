
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelationshipManagerViewerUI));
            this.divide_line = new System.Windows.Forms.ProgressBar();
            this.debugShow = new System.Windows.Forms.Label();
            this.page_right_button = new System.Windows.Forms.Button();
            this.page_left_button = new System.Windows.Forms.Button();
            this.page_number_label = new System.Windows.Forms.Label();
            this.DataOutputLabel2 = new System.Windows.Forms.Label();
            this.IS_Back_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // divide_line
            // 
            this.divide_line.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.divide_line.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.divide_line.Location = new System.Drawing.Point(1288, -13);
            this.divide_line.Margin = new System.Windows.Forms.Padding(6);
            this.divide_line.Minimum = 100;
            this.divide_line.Name = "divide_line";
            this.divide_line.Size = new System.Drawing.Size(4, 1406);
            this.divide_line.Step = 100;
            this.divide_line.TabIndex = 5;
            this.divide_line.Value = 100;
            // 
            // debugShow
            // 
            this.debugShow.AutoSize = true;
            this.debugShow.Location = new System.Drawing.Point(1546, 101);
            this.debugShow.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.debugShow.Name = "debugShow";
            this.debugShow.Size = new System.Drawing.Size(132, 25);
            this.debugShow.TabIndex = 12;
            this.debugShow.Text = "debugoutput";
            // 
            // page_right_button
            // 
            this.page_right_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.page_right_button.Location = new System.Drawing.Point(1720, 138);
            this.page_right_button.Margin = new System.Windows.Forms.Padding(6);
            this.page_right_button.Name = "page_right_button";
            this.page_right_button.Size = new System.Drawing.Size(178, 75);
            this.page_right_button.TabIndex = 13;
            this.page_right_button.Text = "->";
            this.page_right_button.UseVisualStyleBackColor = true;
            this.page_right_button.Click += new System.EventHandler(this.page_right_button_Click);
            // 
            // page_left_button
            // 
            this.page_left_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.page_left_button.Location = new System.Drawing.Point(1304, 138);
            this.page_left_button.Margin = new System.Windows.Forms.Padding(6);
            this.page_left_button.Name = "page_left_button";
            this.page_left_button.Size = new System.Drawing.Size(178, 75);
            this.page_left_button.TabIndex = 14;
            this.page_left_button.Text = "<-";
            this.page_left_button.UseVisualStyleBackColor = true;
            this.page_left_button.Click += new System.EventHandler(this.page_left_button_Click);
            // 
            // page_number_label
            // 
            this.page_number_label.AutoSize = true;
            this.page_number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page_number_label.Location = new System.Drawing.Point(1588, 151);
            this.page_number_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.page_number_label.Name = "page_number_label";
            this.page_number_label.Size = new System.Drawing.Size(44, 48);
            this.page_number_label.TabIndex = 15;
            this.page_number_label.Text = "1";
            // 
            // DataOutputLabel2
            // 
            this.DataOutputLabel2.AutoSize = true;
            this.DataOutputLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataOutputLabel2.Location = new System.Drawing.Point(1302, 219);
            this.DataOutputLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DataOutputLabel2.Name = "DataOutputLabel2";
            this.DataOutputLabel2.Size = new System.Drawing.Size(566, 378);
            this.DataOutputLabel2.TabIndex = 16;
            this.DataOutputLabel2.Text = "ID: 1\r\nName: Beach hut investment\r\nDescription: Spanish beach hut\r\ninvestment for" +
    " new investors\r\nRisk Level: 4\r\nCost: $3400\r\nDate: 04/05/2024\r\nInvest Type: Prope" +
    "rty\r\nPermsion Level: 0";
            this.DataOutputLabel2.Click += new System.EventHandler(this.DataOutputLabel_Click);
            // 
            // IS_Back_Button
            // 
            this.IS_Back_Button.Image = ((System.Drawing.Image)(resources.GetObject("IS_Back_Button.Image")));
            this.IS_Back_Button.Location = new System.Drawing.Point(1310, 15);
            this.IS_Back_Button.Margin = new System.Windows.Forms.Padding(6);
            this.IS_Back_Button.Name = "IS_Back_Button";
            this.IS_Back_Button.Size = new System.Drawing.Size(132, 57);
            this.IS_Back_Button.TabIndex = 20;
            this.IS_Back_Button.Text = "Go back";
            this.IS_Back_Button.UseVisualStyleBackColor = true;
            this.IS_Back_Button.Click += new System.EventHandler(this.IS_Back_Button_Click);
            // 
            // RelationshipManagerViewerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1062);
            this.Controls.Add(this.IS_Back_Button);
            this.Controls.Add(this.DataOutputLabel2);
            this.Controls.Add(this.page_number_label);
            this.Controls.Add(this.page_left_button);
            this.Controls.Add(this.page_right_button);
            this.Controls.Add(this.debugShow);
            this.Controls.Add(this.divide_line);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RelationshipManagerViewerUI";
            this.Text = "RM viewer UI";
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
        private System.Windows.Forms.Label DataOutputLabel2;
        private System.Windows.Forms.Button IS_Back_Button;
    }
}