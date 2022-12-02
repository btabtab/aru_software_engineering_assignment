﻿
namespace aru_software_eng_UI
{
    partial class RelationshipManagerView
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
            this.MinRiskLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MaxRiskLabel = new System.Windows.Forms.Label();
            this.MinCostLabel = new System.Windows.Forms.Label();
            this.MaxCostLabel = new System.Windows.Forms.Label();
            this.MinRiskTrackBar = new System.Windows.Forms.TrackBar();
            this.MaxRiskTrackBar = new System.Windows.Forms.TrackBar();
            this.MinCostTrackBar = new System.Windows.Forms.TrackBar();
            this.MaxCostTrackBar = new System.Windows.Forms.TrackBar();
            this.IndustryLabel = new System.Windows.Forms.Label();
            this.IndustryInputTextBox = new System.Windows.Forms.TextBox();
            this.ExpireDateLabel = new System.Windows.Forms.Label();
            this.ExpireDatePicker = new System.Windows.Forms.DateTimePicker();
            this.PageTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MinRiskTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRiskTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinCostTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxCostTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // MinRiskLabel
            // 
            this.MinRiskLabel.AutoSize = true;
            this.MinRiskLabel.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinRiskLabel.Location = new System.Drawing.Point(12, 153);
            this.MinRiskLabel.Name = "MinRiskLabel";
            this.MinRiskLabel.Size = new System.Drawing.Size(178, 42);
            this.MinRiskLabel.TabIndex = 1;
            this.MinRiskLabel.Text = "Minimum Risk";
            this.MinRiskLabel.Click += new System.EventHandler(this.MinRiskLabel_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SearchButton.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold);
            this.SearchButton.ForeColor = System.Drawing.Color.Black;
            this.SearchButton.Location = new System.Drawing.Point(25, 367);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(797, 82);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Search";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MaxRiskLabel
            // 
            this.MaxRiskLabel.AutoSize = true;
            this.MaxRiskLabel.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxRiskLabel.Location = new System.Drawing.Point(16, 216);
            this.MaxRiskLabel.Name = "MaxRiskLabel";
            this.MaxRiskLabel.Size = new System.Drawing.Size(185, 42);
            this.MaxRiskLabel.TabIndex = 10;
            this.MaxRiskLabel.Text = "Maximum Risk";
            this.MaxRiskLabel.Click += new System.EventHandler(this.MaxRiskLabel_Click);
            // 
            // MinCostLabel
            // 
            this.MinCostLabel.AutoSize = true;
            this.MinCostLabel.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinCostLabel.Location = new System.Drawing.Point(430, 150);
            this.MinCostLabel.Name = "MinCostLabel";
            this.MinCostLabel.Size = new System.Drawing.Size(181, 42);
            this.MinCostLabel.TabIndex = 11;
            this.MinCostLabel.Text = "Minimum Cost";
            this.MinCostLabel.Click += new System.EventHandler(this.MinCostLabel_Click);
            // 
            // MaxCostLabel
            // 
            this.MaxCostLabel.AutoSize = true;
            this.MaxCostLabel.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxCostLabel.Location = new System.Drawing.Point(431, 214);
            this.MaxCostLabel.Name = "MaxCostLabel";
            this.MaxCostLabel.Size = new System.Drawing.Size(188, 42);
            this.MaxCostLabel.TabIndex = 12;
            this.MaxCostLabel.Text = "Maximum Cost";
            this.MaxCostLabel.Click += new System.EventHandler(this.MaxCostLabel_Click);
            // 
            // MinRiskTrackBar
            // 
            this.MinRiskTrackBar.Location = new System.Drawing.Point(196, 156);
            this.MinRiskTrackBar.Maximum = 5;
            this.MinRiskTrackBar.Minimum = 1;
            this.MinRiskTrackBar.Name = "MinRiskTrackBar";
            this.MinRiskTrackBar.Size = new System.Drawing.Size(208, 45);
            this.MinRiskTrackBar.TabIndex = 13;
            this.MinRiskTrackBar.Value = 2;
            this.MinRiskTrackBar.Scroll += new System.EventHandler(this.MinRiskTrackBar_Scroll);
            // 
            // MaxRiskTrackBar
            // 
            this.MaxRiskTrackBar.Location = new System.Drawing.Point(207, 219);
            this.MaxRiskTrackBar.Maximum = 5;
            this.MaxRiskTrackBar.Minimum = 1;
            this.MaxRiskTrackBar.Name = "MaxRiskTrackBar";
            this.MaxRiskTrackBar.Size = new System.Drawing.Size(197, 45);
            this.MaxRiskTrackBar.TabIndex = 14;
            this.MaxRiskTrackBar.Value = 4;
            this.MaxRiskTrackBar.Scroll += new System.EventHandler(this.MaxRiskTrackBar_Scroll);
            // 
            // MinCostTrackBar
            // 
            this.MinCostTrackBar.LargeChange = 5000;
            this.MinCostTrackBar.Location = new System.Drawing.Point(614, 150);
            this.MinCostTrackBar.Maximum = 100000;
            this.MinCostTrackBar.Name = "MinCostTrackBar";
            this.MinCostTrackBar.Size = new System.Drawing.Size(208, 45);
            this.MinCostTrackBar.TabIndex = 15;
            this.MinCostTrackBar.Value = 10000;
            this.MinCostTrackBar.Scroll += new System.EventHandler(this.MinCostTrackBar_Scroll);
            // 
            // MaxCostTrackBar
            // 
            this.MaxCostTrackBar.LargeChange = 5000;
            this.MaxCostTrackBar.Location = new System.Drawing.Point(628, 214);
            this.MaxCostTrackBar.Maximum = 100000;
            this.MaxCostTrackBar.Name = "MaxCostTrackBar";
            this.MaxCostTrackBar.Size = new System.Drawing.Size(194, 45);
            this.MaxCostTrackBar.TabIndex = 16;
            this.MaxCostTrackBar.Value = 10000;
            this.MaxCostTrackBar.Scroll += new System.EventHandler(this.MaxCostTrackBar_Scroll);
            // 
            // IndustryLabel
            // 
            this.IndustryLabel.AutoSize = true;
            this.IndustryLabel.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndustryLabel.Location = new System.Drawing.Point(76, 284);
            this.IndustryLabel.Name = "IndustryLabel";
            this.IndustryLabel.Size = new System.Drawing.Size(114, 42);
            this.IndustryLabel.TabIndex = 17;
            this.IndustryLabel.Text = "Industry";
            this.IndustryLabel.Click += new System.EventHandler(this.IndustryLabel_Click);
            // 
            // IndustryInputTextBox
            // 
            this.IndustryInputTextBox.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndustryInputTextBox.Location = new System.Drawing.Point(196, 286);
            this.IndustryInputTextBox.Name = "IndustryInputTextBox";
            this.IndustryInputTextBox.Size = new System.Drawing.Size(208, 40);
            this.IndustryInputTextBox.TabIndex = 18;
            this.IndustryInputTextBox.TextChanged += new System.EventHandler(this.IndustryInputTextBox_TextChanged);
            // 
            // ExpireDateLabel
            // 
            this.ExpireDateLabel.AutoSize = true;
            this.ExpireDateLabel.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpireDateLabel.Location = new System.Drawing.Point(462, 278);
            this.ExpireDateLabel.Name = "ExpireDateLabel";
            this.ExpireDateLabel.Size = new System.Drawing.Size(149, 42);
            this.ExpireDateLabel.TabIndex = 19;
            this.ExpireDateLabel.Text = "Expiry Date";
            this.ExpireDateLabel.Click += new System.EventHandler(this.ExpireDateLabel_Click);
            // 
            // ExpireDatePicker
            // 
            this.ExpireDatePicker.CalendarFont = new System.Drawing.Font("Calibri", 16.25F, System.Drawing.FontStyle.Bold);
            this.ExpireDatePicker.Font = new System.Drawing.Font("Calibri", 16.25F, System.Drawing.FontStyle.Bold);
            this.ExpireDatePicker.Location = new System.Drawing.Point(620, 286);
            this.ExpireDatePicker.Name = "ExpireDatePicker";
            this.ExpireDatePicker.Size = new System.Drawing.Size(202, 34);
            this.ExpireDatePicker.TabIndex = 20;
            this.ExpireDatePicker.ValueChanged += new System.EventHandler(this.ExpireDatePicker_ValueChanged);
            // 
            // PageTitle
            // 
            this.PageTitle.AutoSize = true;
            this.PageTitle.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTitle.Location = new System.Drawing.Point(12, 9);
            this.PageTitle.Name = "PageTitle";
            this.PageTitle.Size = new System.Drawing.Size(577, 77);
            this.PageTitle.TabIndex = 21;
            this.PageTitle.Text = "Enter your requirments:";
            // 
            // RelationshipManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.PageTitle);
            this.Controls.Add(this.ExpireDatePicker);
            this.Controls.Add(this.ExpireDateLabel);
            this.Controls.Add(this.IndustryInputTextBox);
            this.Controls.Add(this.IndustryLabel);
            this.Controls.Add(this.MaxCostTrackBar);
            this.Controls.Add(this.MinCostTrackBar);
            this.Controls.Add(this.MaxRiskTrackBar);
            this.Controls.Add(this.MinRiskTrackBar);
            this.Controls.Add(this.MaxCostLabel);
            this.Controls.Add(this.MinCostLabel);
            this.Controls.Add(this.MaxRiskLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MinRiskLabel);
            this.Name = "RelationshipManagerView";
            this.Text = "RelationshipManagerView";
            this.Load += new System.EventHandler(this.RelationshipManagerView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MinRiskTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRiskTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinCostTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxCostTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MinRiskLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label MaxRiskLabel;
        private System.Windows.Forms.Label MinCostLabel;
        private System.Windows.Forms.Label MaxCostLabel;
        private System.Windows.Forms.TrackBar MinRiskTrackBar;
        private System.Windows.Forms.TrackBar MaxRiskTrackBar;
        private System.Windows.Forms.TrackBar MinCostTrackBar;
        private System.Windows.Forms.TrackBar MaxCostTrackBar;
        private System.Windows.Forms.Label IndustryLabel;
        private System.Windows.Forms.TextBox IndustryInputTextBox;
        private System.Windows.Forms.Label ExpireDateLabel;
        private System.Windows.Forms.DateTimePicker ExpireDatePicker;
        private System.Windows.Forms.Label PageTitle;
    }
}