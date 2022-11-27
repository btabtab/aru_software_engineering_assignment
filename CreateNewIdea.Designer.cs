
namespace aru_software_eng_UI
{
    partial class CreateNewIdeaForm
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
            this.IS_save_button = new System.Windows.Forms.Button();
            this.IS_expirydate_label = new System.Windows.Forms.Label();
            this.IS_industry_label = new System.Windows.Forms.Label();
            this.IS_cost_label = new System.Windows.Forms.Label();
            this.IS_risk_label = new System.Windows.Forms.Label();
            this.IS_risk_combobox = new System.Windows.Forms.ComboBox();
            this.IS_cost_textbox = new System.Windows.Forms.TextBox();
            this.IS_expiry_date = new System.Windows.Forms.DateTimePicker();
            this.IS_newIdeaLabel = new System.Windows.Forms.Label();
            this.IS_description_label = new System.Windows.Forms.Label();
            this.IS_description_textbox = new System.Windows.Forms.TextBox();
            this.IS_industry_textbox = new System.Windows.Forms.TextBox();
            this.IS_rmrating_label = new System.Windows.Forms.Label();
            this.IS_rmrating_combobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // IS_save_button
            // 
            this.IS_save_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.IS_save_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.IS_save_button.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_save_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IS_save_button.Location = new System.Drawing.Point(215, 404);
            this.IS_save_button.Name = "IS_save_button";
            this.IS_save_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IS_save_button.Size = new System.Drawing.Size(106, 44);
            this.IS_save_button.TabIndex = 0;
            this.IS_save_button.Text = "Save ";
            this.IS_save_button.UseVisualStyleBackColor = false;
            this.IS_save_button.Click += new System.EventHandler(this.IS_save_button_Click);
            // 
            // IS_expirydate_label
            // 
            this.IS_expirydate_label.AutoSize = true;
            this.IS_expirydate_label.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_expirydate_label.Location = new System.Drawing.Point(12, 246);
            this.IS_expirydate_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IS_expirydate_label.Name = "IS_expirydate_label";
            this.IS_expirydate_label.Size = new System.Drawing.Size(135, 39);
            this.IS_expirydate_label.TabIndex = 18;
            this.IS_expirydate_label.Text = "Expiry Date";
            // 
            // IS_industry_label
            // 
            this.IS_industry_label.AutoSize = true;
            this.IS_industry_label.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_industry_label.Location = new System.Drawing.Point(10, 114);
            this.IS_industry_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IS_industry_label.Name = "IS_industry_label";
            this.IS_industry_label.Size = new System.Drawing.Size(101, 39);
            this.IS_industry_label.TabIndex = 19;
            this.IS_industry_label.Text = "Industry";
            this.IS_industry_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IS_cost_label
            // 
            this.IS_cost_label.AutoSize = true;
            this.IS_cost_label.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_cost_label.Location = new System.Drawing.Point(12, 157);
            this.IS_cost_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IS_cost_label.Name = "IS_cost_label";
            this.IS_cost_label.Size = new System.Drawing.Size(63, 39);
            this.IS_cost_label.TabIndex = 20;
            this.IS_cost_label.Text = "Cost";
            this.IS_cost_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.IS_cost_label.Click += new System.EventHandler(this.IS_cost_label_Click);
            // 
            // IS_risk_label
            // 
            this.IS_risk_label.AutoSize = true;
            this.IS_risk_label.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_risk_label.Location = new System.Drawing.Point(12, 202);
            this.IS_risk_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IS_risk_label.Name = "IS_risk_label";
            this.IS_risk_label.Size = new System.Drawing.Size(62, 39);
            this.IS_risk_label.TabIndex = 23;
            this.IS_risk_label.Text = "Risk";
            // 
            // IS_risk_combobox
            // 
            this.IS_risk_combobox.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_risk_combobox.FormattingEnabled = true;
            this.IS_risk_combobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.IS_risk_combobox.Location = new System.Drawing.Point(250, 201);
            this.IS_risk_combobox.Name = "IS_risk_combobox";
            this.IS_risk_combobox.Size = new System.Drawing.Size(300, 40);
            this.IS_risk_combobox.TabIndex = 22;
            // 
            // IS_cost_textbox
            // 
            this.IS_cost_textbox.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_cost_textbox.Location = new System.Drawing.Point(250, 157);
            this.IS_cost_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.IS_cost_textbox.Name = "IS_cost_textbox";
            this.IS_cost_textbox.Size = new System.Drawing.Size(300, 39);
            this.IS_cost_textbox.TabIndex = 21;
            this.IS_cost_textbox.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            // 
            // IS_expiry_date
            // 
            this.IS_expiry_date.CalendarFont = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_expiry_date.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_expiry_date.Location = new System.Drawing.Point(250, 247);
            this.IS_expiry_date.Name = "IS_expiry_date";
            this.IS_expiry_date.Size = new System.Drawing.Size(300, 39);
            this.IS_expiry_date.TabIndex = 1;
            this.IS_expiry_date.TabStop = false;
            this.IS_expiry_date.ValueChanged += new System.EventHandler(this.expiry_date_ValueChanged);
            // 
            // IS_newIdeaLabel
            // 
            this.IS_newIdeaLabel.AutoSize = true;
            this.IS_newIdeaLabel.Font = new System.Drawing.Font("Agency FB", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_newIdeaLabel.Location = new System.Drawing.Point(4, 9);
            this.IS_newIdeaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IS_newIdeaLabel.Name = "IS_newIdeaLabel";
            this.IS_newIdeaLabel.Size = new System.Drawing.Size(238, 80);
            this.IS_newIdeaLabel.TabIndex = 25;
            this.IS_newIdeaLabel.Text = "New Idea";
            // 
            // IS_description_label
            // 
            this.IS_description_label.AutoSize = true;
            this.IS_description_label.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_description_label.Location = new System.Drawing.Point(10, 334);
            this.IS_description_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IS_description_label.Name = "IS_description_label";
            this.IS_description_label.Size = new System.Drawing.Size(134, 39);
            this.IS_description_label.TabIndex = 26;
            this.IS_description_label.Text = "Description";
            this.IS_description_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // IS_description_textbox
            // 
            this.IS_description_textbox.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_description_textbox.Location = new System.Drawing.Point(249, 337);
            this.IS_description_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.IS_description_textbox.Name = "IS_description_textbox";
            this.IS_description_textbox.Size = new System.Drawing.Size(300, 39);
            this.IS_description_textbox.TabIndex = 27;
            // 
            // IS_industry_textbox
            // 
            this.IS_industry_textbox.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_industry_textbox.Location = new System.Drawing.Point(250, 114);
            this.IS_industry_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.IS_industry_textbox.Name = "IS_industry_textbox";
            this.IS_industry_textbox.Size = new System.Drawing.Size(300, 39);
            this.IS_industry_textbox.TabIndex = 28;
            // 
            // IS_rmrating_label
            // 
            this.IS_rmrating_label.AutoSize = true;
            this.IS_rmrating_label.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_rmrating_label.Location = new System.Drawing.Point(12, 289);
            this.IS_rmrating_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IS_rmrating_label.Name = "IS_rmrating_label";
            this.IS_rmrating_label.Size = new System.Drawing.Size(116, 39);
            this.IS_rmrating_label.TabIndex = 30;
            this.IS_rmrating_label.Text = "RM rating";
            // 
            // IS_rmrating_combobox
            // 
            this.IS_rmrating_combobox.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_rmrating_combobox.FormattingEnabled = true;
            this.IS_rmrating_combobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.IS_rmrating_combobox.Location = new System.Drawing.Point(249, 292);
            this.IS_rmrating_combobox.Name = "IS_rmrating_combobox";
            this.IS_rmrating_combobox.Size = new System.Drawing.Size(300, 40);
            this.IS_rmrating_combobox.TabIndex = 29;
            // 
            // CreateNewIdeaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 491);
            this.Controls.Add(this.IS_rmrating_label);
            this.Controls.Add(this.IS_rmrating_combobox);
            this.Controls.Add(this.IS_industry_textbox);
            this.Controls.Add(this.IS_description_textbox);
            this.Controls.Add(this.IS_description_label);
            this.Controls.Add(this.IS_newIdeaLabel);
            this.Controls.Add(this.IS_risk_label);
            this.Controls.Add(this.IS_risk_combobox);
            this.Controls.Add(this.IS_cost_textbox);
            this.Controls.Add(this.IS_cost_label);
            this.Controls.Add(this.IS_industry_label);
            this.Controls.Add(this.IS_expirydate_label);
            this.Controls.Add(this.IS_expiry_date);
            this.Controls.Add(this.IS_save_button);
            this.Name = "CreateNewIdeaForm";
            this.Text = "CreateNewIdea";
            this.Load += new System.EventHandler(this.CreateNewIdea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IS_save_button;
        private System.Windows.Forms.Label IS_expirydate_label;
        private System.Windows.Forms.Label IS_industry_label;
        private System.Windows.Forms.Label IS_cost_label;
        private System.Windows.Forms.Label IS_risk_label;
        private System.Windows.Forms.ComboBox IS_risk_combobox;
        private System.Windows.Forms.TextBox IS_cost_textbox;
        private System.Windows.Forms.DateTimePicker IS_expiry_date;
        private System.Windows.Forms.Label IS_newIdeaLabel;
        private System.Windows.Forms.Label IS_description_label;
        private System.Windows.Forms.TextBox IS_description_textbox;
        private System.Windows.Forms.TextBox IS_industry_textbox;
        private System.Windows.Forms.Label IS_rmrating_label;
        private System.Windows.Forms.ComboBox IS_rmrating_combobox;
    }
}