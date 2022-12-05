
namespace aru_software_eng_UI
{
    partial class FilterWindow
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
            this.manualSearchInput = new System.Windows.Forms.TextBox();
            this.manualSearchLabel = new System.Windows.Forms.Label();
            this.singleSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MinRiskTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRiskTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinCostTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxCostTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // MinRiskLabel
            // 
            this.MinRiskLabel.AutoSize = true;
            this.MinRiskLabel.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold);
            this.MinRiskLabel.Location = new System.Drawing.Point(22, 96);
            this.MinRiskLabel.Name = "MinRiskLabel";
            this.MinRiskLabel.Size = new System.Drawing.Size(158, 39);
            this.MinRiskLabel.TabIndex = 1;
            this.MinRiskLabel.Text = "Minimum Risk";
            this.MinRiskLabel.Click += new System.EventHandler(this.MinRiskLabel_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SearchButton.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold);
            this.SearchButton.ForeColor = System.Drawing.Color.Black;
            this.SearchButton.Location = new System.Drawing.Point(25, 260);
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
            this.MaxRiskLabel.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold);
            this.MaxRiskLabel.Location = new System.Drawing.Point(16, 156);
            this.MaxRiskLabel.Name = "MaxRiskLabel";
            this.MaxRiskLabel.Size = new System.Drawing.Size(164, 39);
            this.MaxRiskLabel.TabIndex = 10;
            this.MaxRiskLabel.Text = "Maximum Risk";
            this.MaxRiskLabel.Click += new System.EventHandler(this.MaxRiskLabel_Click);
            // 
            // MinCostLabel
            // 
            this.MinCostLabel.AutoSize = true;
            this.MinCostLabel.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold);
            this.MinCostLabel.Location = new System.Drawing.Point(437, 90);
            this.MinCostLabel.Name = "MinCostLabel";
            this.MinCostLabel.Size = new System.Drawing.Size(159, 39);
            this.MinCostLabel.TabIndex = 11;
            this.MinCostLabel.Text = "Minimum Cost";
            this.MinCostLabel.Click += new System.EventHandler(this.MinCostLabel_Click);
            // 
            // MaxCostLabel
            // 
            this.MaxCostLabel.AutoSize = true;
            this.MaxCostLabel.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold);
            this.MaxCostLabel.Location = new System.Drawing.Point(431, 154);
            this.MaxCostLabel.Name = "MaxCostLabel";
            this.MaxCostLabel.Size = new System.Drawing.Size(165, 39);
            this.MaxCostLabel.TabIndex = 12;
            this.MaxCostLabel.Text = "Maximum Cost";
            this.MaxCostLabel.Click += new System.EventHandler(this.MaxCostLabel_Click);
            // 
            // MinRiskTrackBar
            // 
            this.MinRiskTrackBar.LargeChange = 1;
            this.MinRiskTrackBar.Location = new System.Drawing.Point(196, 96);
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
            this.MaxRiskTrackBar.LargeChange = 1;
            this.MaxRiskTrackBar.Location = new System.Drawing.Point(207, 159);
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
            this.MinCostTrackBar.Location = new System.Drawing.Point(614, 90);
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
            this.MaxCostTrackBar.Location = new System.Drawing.Point(628, 154);
            this.MaxCostTrackBar.Maximum = 100000;
            this.MaxCostTrackBar.Name = "MaxCostTrackBar";
            this.MaxCostTrackBar.Size = new System.Drawing.Size(194, 45);
            this.MaxCostTrackBar.TabIndex = 16;
            this.MaxCostTrackBar.Value = 75000;
            this.MaxCostTrackBar.Scroll += new System.EventHandler(this.MaxCostTrackBar_Scroll);
            // 
            // IndustryLabel
            // 
            this.IndustryLabel.AutoSize = true;
            this.IndustryLabel.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold);
            this.IndustryLabel.Location = new System.Drawing.Point(79, 211);
            this.IndustryLabel.Name = "IndustryLabel";
            this.IndustryLabel.Size = new System.Drawing.Size(101, 39);
            this.IndustryLabel.TabIndex = 17;
            this.IndustryLabel.Text = "Industry";
            this.IndustryLabel.Click += new System.EventHandler(this.IndustryLabel_Click);
            // 
            // IndustryInputTextBox
            // 
            this.IndustryInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndustryInputTextBox.Location = new System.Drawing.Point(190, 205);
            this.IndustryInputTextBox.Name = "IndustryInputTextBox";
            this.IndustryInputTextBox.Size = new System.Drawing.Size(208, 38);
            this.IndustryInputTextBox.TabIndex = 18;
            this.IndustryInputTextBox.TextChanged += new System.EventHandler(this.IndustryInputTextBox_TextChanged);
            // 
            // ExpireDateLabel
            // 
            this.ExpireDateLabel.AutoSize = true;
            this.ExpireDateLabel.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold);
            this.ExpireDateLabel.Location = new System.Drawing.Point(461, 211);
            this.ExpireDateLabel.Name = "ExpireDateLabel";
            this.ExpireDateLabel.Size = new System.Drawing.Size(135, 39);
            this.ExpireDateLabel.TabIndex = 19;
            this.ExpireDateLabel.Text = "Expiry Date";
            this.ExpireDateLabel.Click += new System.EventHandler(this.ExpireDateLabel_Click);
            // 
            // ExpireDatePicker
            // 
            this.ExpireDatePicker.CalendarFont = new System.Drawing.Font("Calibri", 16.25F, System.Drawing.FontStyle.Bold);
            this.ExpireDatePicker.Font = new System.Drawing.Font("Calibri", 16.25F, System.Drawing.FontStyle.Bold);
            this.ExpireDatePicker.Location = new System.Drawing.Point(628, 210);
            this.ExpireDatePicker.Name = "ExpireDatePicker";
            this.ExpireDatePicker.Size = new System.Drawing.Size(202, 34);
            this.ExpireDatePicker.TabIndex = 20;
            this.ExpireDatePicker.ValueChanged += new System.EventHandler(this.ExpireDatePicker_ValueChanged);
            // 
            // PageTitle
            // 
            this.PageTitle.AutoSize = true;
            this.PageTitle.Font = new System.Drawing.Font("Agency FB", 64F, System.Drawing.FontStyle.Bold);
            this.PageTitle.Location = new System.Drawing.Point(316, -9);
            this.PageTitle.Name = "PageTitle";
            this.PageTitle.Size = new System.Drawing.Size(234, 102);
            this.PageTitle.TabIndex = 21;
            this.PageTitle.Text = "Filters";
            // 
            // manualSearchInput
            // 
            this.manualSearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualSearchInput.Location = new System.Drawing.Point(342, 390);
            this.manualSearchInput.Name = "manualSearchInput";
            this.manualSearchInput.Size = new System.Drawing.Size(208, 38);
            this.manualSearchInput.TabIndex = 22;
            this.manualSearchInput.TextChanged += new System.EventHandler(this.manualSearchInput_TextChanged);
            // 
            // manualSearchLabel
            // 
            this.manualSearchLabel.AutoSize = true;
            this.manualSearchLabel.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold);
            this.manualSearchLabel.Location = new System.Drawing.Point(22, 387);
            this.manualSearchLabel.Name = "manualSearchLabel";
            this.manualSearchLabel.Size = new System.Drawing.Size(311, 39);
            this.manualSearchLabel.TabIndex = 23;
            this.manualSearchLabel.Text = "Search for an idea manually:";
            // 
            // singleSearchButton
            // 
            this.singleSearchButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.singleSearchButton.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold);
            this.singleSearchButton.ForeColor = System.Drawing.Color.Black;
            this.singleSearchButton.Location = new System.Drawing.Point(571, 367);
            this.singleSearchButton.Name = "singleSearchButton";
            this.singleSearchButton.Size = new System.Drawing.Size(251, 82);
            this.singleSearchButton.TabIndex = 24;
            this.singleSearchButton.Text = "Search manually";
            this.singleSearchButton.UseVisualStyleBackColor = false;
            // 
            // FilterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.singleSearchButton);
            this.Controls.Add(this.manualSearchLabel);
            this.Controls.Add(this.manualSearchInput);
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
            this.Name = "FilterWindow";
            this.Text = "RM Filter page";
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
        private System.Windows.Forms.TextBox manualSearchInput;
        private System.Windows.Forms.Label manualSearchLabel;
        private System.Windows.Forms.Button singleSearchButton;
    }
}