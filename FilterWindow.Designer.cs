
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterWindow));
            this.MinRiskLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MaxRiskLabel = new System.Windows.Forms.Label();
            this.MinCostLabel = new System.Windows.Forms.Label();
            this.MaxCostLabel = new System.Windows.Forms.Label();
            this.MinRiskTrackBar = new System.Windows.Forms.TrackBar();
            this.MaxRiskTrackBar = new System.Windows.Forms.TrackBar();
            this.MinCostTrackBar = new System.Windows.Forms.TrackBar();
            this.MaxCostTrackBar = new System.Windows.Forms.TrackBar();
            this.ExpireDateLabel = new System.Windows.Forms.Label();
            this.ExpireDatePicker = new System.Windows.Forms.DateTimePicker();
            this.PageTitle = new System.Windows.Forms.Label();
            this.manualSearchInput = new System.Windows.Forms.TextBox();
            this.manualSearchLabel = new System.Windows.Forms.Label();
            this.singleSearchButton = new System.Windows.Forms.Button();
            this.divide_line = new System.Windows.Forms.ProgressBar();
            this.singleIdeaPanel = new System.Windows.Forms.Panel();
            this.panelLabel = new System.Windows.Forms.Label();
            this.panelBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MinRiskTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRiskTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinCostTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxCostTrackBar)).BeginInit();
            this.singleIdeaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MinRiskLabel
            // 
            this.MinRiskLabel.AutoSize = true;
            this.MinRiskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.MinRiskLabel.Location = new System.Drawing.Point(44, 185);
            this.MinRiskLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MinRiskLabel.Name = "MinRiskLabel";
            this.MinRiskLabel.Size = new System.Drawing.Size(444, 73);
            this.MinRiskLabel.TabIndex = 1;
            this.MinRiskLabel.Text = "Minimum Risk";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.SearchButton.ForeColor = System.Drawing.Color.Black;
            this.SearchButton.Location = new System.Drawing.Point(50, 500);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(1594, 158);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Search";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MaxRiskLabel
            // 
            this.MaxRiskLabel.AutoSize = true;
            this.MaxRiskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.MaxRiskLabel.Location = new System.Drawing.Point(32, 300);
            this.MaxRiskLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MaxRiskLabel.Name = "MaxRiskLabel";
            this.MaxRiskLabel.Size = new System.Drawing.Size(462, 73);
            this.MaxRiskLabel.TabIndex = 10;
            this.MaxRiskLabel.Text = "Maximum Risk";
            // 
            // MinCostLabel
            // 
            this.MinCostLabel.AutoSize = true;
            this.MinCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.MinCostLabel.Location = new System.Drawing.Point(874, 185);
            this.MinCostLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MinCostLabel.Name = "MinCostLabel";
            this.MinCostLabel.Size = new System.Drawing.Size(452, 73);
            this.MinCostLabel.TabIndex = 11;
            this.MinCostLabel.Text = "Minimum Cost";
            // 
            // MaxCostLabel
            // 
            this.MaxCostLabel.AutoSize = true;
            this.MaxCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.MaxCostLabel.Location = new System.Drawing.Point(862, 296);
            this.MaxCostLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MaxCostLabel.Name = "MaxCostLabel";
            this.MaxCostLabel.Size = new System.Drawing.Size(470, 73);
            this.MaxCostLabel.TabIndex = 12;
            this.MaxCostLabel.Text = "Maximum Cost";
            // 
            // MinRiskTrackBar
            // 
            this.MinRiskTrackBar.LargeChange = 1;
            this.MinRiskTrackBar.Location = new System.Drawing.Point(392, 185);
            this.MinRiskTrackBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinRiskTrackBar.Maximum = 5;
            this.MinRiskTrackBar.Minimum = 1;
            this.MinRiskTrackBar.Name = "MinRiskTrackBar";
            this.MinRiskTrackBar.Size = new System.Drawing.Size(416, 90);
            this.MinRiskTrackBar.TabIndex = 13;
            this.MinRiskTrackBar.Value = 2;
            this.MinRiskTrackBar.Scroll += new System.EventHandler(this.MinRiskTrackBar_Scroll);
            // 
            // MaxRiskTrackBar
            // 
            this.MaxRiskTrackBar.LargeChange = 1;
            this.MaxRiskTrackBar.Location = new System.Drawing.Point(414, 306);
            this.MaxRiskTrackBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaxRiskTrackBar.Maximum = 5;
            this.MaxRiskTrackBar.Minimum = 1;
            this.MaxRiskTrackBar.Name = "MaxRiskTrackBar";
            this.MaxRiskTrackBar.Size = new System.Drawing.Size(394, 90);
            this.MaxRiskTrackBar.TabIndex = 14;
            this.MaxRiskTrackBar.Value = 4;
            this.MaxRiskTrackBar.Scroll += new System.EventHandler(this.MaxRiskTrackBar_Scroll);
            // 
            // MinCostTrackBar
            // 
            this.MinCostTrackBar.LargeChange = 5000;
            this.MinCostTrackBar.Location = new System.Drawing.Point(1228, 185);
            this.MinCostTrackBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinCostTrackBar.Maximum = 100000;
            this.MinCostTrackBar.Name = "MinCostTrackBar";
            this.MinCostTrackBar.Size = new System.Drawing.Size(416, 90);
            this.MinCostTrackBar.TabIndex = 15;
            this.MinCostTrackBar.Value = 10000;
            this.MinCostTrackBar.Scroll += new System.EventHandler(this.MinCostTrackBar_Scroll);
            // 
            // MaxCostTrackBar
            // 
            this.MaxCostTrackBar.LargeChange = 5000;
            this.MaxCostTrackBar.Location = new System.Drawing.Point(1256, 296);
            this.MaxCostTrackBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaxCostTrackBar.Maximum = 100000;
            this.MaxCostTrackBar.Name = "MaxCostTrackBar";
            this.MaxCostTrackBar.Size = new System.Drawing.Size(388, 90);
            this.MaxCostTrackBar.TabIndex = 16;
            this.MaxCostTrackBar.Value = 75000;
            this.MaxCostTrackBar.Scroll += new System.EventHandler(this.MaxCostTrackBar_Scroll);
            // 
            // ExpireDateLabel
            // 
            this.ExpireDateLabel.AutoSize = true;
            this.ExpireDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.ExpireDateLabel.Location = new System.Drawing.Point(922, 406);
            this.ExpireDateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ExpireDateLabel.Name = "ExpireDateLabel";
            this.ExpireDateLabel.Size = new System.Drawing.Size(374, 73);
            this.ExpireDateLabel.TabIndex = 19;
            this.ExpireDateLabel.Text = "Expiry Date";
            // 
            // ExpireDatePicker
            // 
            this.ExpireDatePicker.CalendarFont = new System.Drawing.Font("Calibri", 16.25F, System.Drawing.FontStyle.Bold);
            this.ExpireDatePicker.Font = new System.Drawing.Font("Calibri", 16.25F, System.Drawing.FontStyle.Bold);
            this.ExpireDatePicker.Location = new System.Drawing.Point(1256, 404);
            this.ExpireDatePicker.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ExpireDatePicker.Name = "ExpireDatePicker";
            this.ExpireDatePicker.Size = new System.Drawing.Size(400, 60);
            this.ExpireDatePicker.TabIndex = 20;
            // 
            // PageTitle
            // 
            this.PageTitle.AutoSize = true;
            this.PageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Bold);
            this.PageTitle.Location = new System.Drawing.Point(632, -17);
            this.PageTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PageTitle.Name = "PageTitle";
            this.PageTitle.Size = new System.Drawing.Size(555, 193);
            this.PageTitle.TabIndex = 21;
            this.PageTitle.Text = "Filters";
            // 
            // manualSearchInput
            // 
            this.manualSearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualSearchInput.Location = new System.Drawing.Point(486, 748);
            this.manualSearchInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.manualSearchInput.Name = "manualSearchInput";
            this.manualSearchInput.Size = new System.Drawing.Size(412, 69);
            this.manualSearchInput.TabIndex = 22;
            // 
            // manualSearchLabel
            // 
            this.manualSearchLabel.AutoSize = true;
            this.manualSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.manualSearchLabel.Location = new System.Drawing.Point(166, 748);
            this.manualSearchLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.manualSearchLabel.Name = "manualSearchLabel";
            this.manualSearchLabel.Size = new System.Drawing.Size(442, 73);
            this.manualSearchLabel.TabIndex = 23;
            this.manualSearchLabel.Text = "Enter Idea ID:";
            // 
            // singleSearchButton
            // 
            this.singleSearchButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.singleSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.singleSearchButton.ForeColor = System.Drawing.Color.Black;
            this.singleSearchButton.Location = new System.Drawing.Point(960, 727);
            this.singleSearchButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.singleSearchButton.Name = "singleSearchButton";
            this.singleSearchButton.Size = new System.Drawing.Size(502, 115);
            this.singleSearchButton.TabIndex = 24;
            this.singleSearchButton.Text = "Search manually";
            this.singleSearchButton.UseVisualStyleBackColor = false;
            this.singleSearchButton.Click += new System.EventHandler(this.singleSearchButton_Click);
            // 
            // divide_line
            // 
            this.divide_line.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.divide_line.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.divide_line.Location = new System.Drawing.Point(8, 677);
            this.divide_line.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.divide_line.Minimum = 100;
            this.divide_line.Name = "divide_line";
            this.divide_line.Size = new System.Drawing.Size(1648, 6);
            this.divide_line.Step = 100;
            this.divide_line.TabIndex = 25;
            this.divide_line.Value = 100;
            // 
            // singleIdeaPanel
            // 
            this.singleIdeaPanel.Controls.Add(this.panelLabel);
            this.singleIdeaPanel.Controls.Add(this.panelBackButton);
            this.singleIdeaPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.singleIdeaPanel.Location = new System.Drawing.Point(8, 2);
            this.singleIdeaPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.singleIdeaPanel.Name = "singleIdeaPanel";
            this.singleIdeaPanel.Size = new System.Drawing.Size(1680, 904);
            this.singleIdeaPanel.TabIndex = 26;
            this.singleIdeaPanel.Visible = false;
            // 
            // panelLabel
            // 
            this.panelLabel.AutoSize = true;
            this.panelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLabel.Location = new System.Drawing.Point(6, 15);
            this.panelLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(270, 770);
            this.panelLabel.TabIndex = 1;
            this.panelLabel.Text = "panelLabel\r\npanelLabel\r\npanelLabel\r\npanelLabel\r\npanelLabel\r\npanelLabel\r\npanelLabe" +
    "l\r\npanelLabel\r\npanelLabel\r\npanelLabel\r\npanelLabel\r\npanelLabel\r\npanelLabel\r\npanel" +
    "Label";
            // 
            // panelBackButton
            // 
            this.panelBackButton.Image = ((System.Drawing.Image)(resources.GetObject("panelBackButton.Image")));
            this.panelBackButton.Location = new System.Drawing.Point(1388, 773);
            this.panelBackButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelBackButton.Name = "panelBackButton";
            this.panelBackButton.Size = new System.Drawing.Size(264, 113);
            this.panelBackButton.TabIndex = 0;
            this.panelBackButton.UseVisualStyleBackColor = true;
            this.panelBackButton.Click += new System.EventHandler(this.panelBackButton_Click);
            // 
            // FilterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 887);
            this.Controls.Add(this.singleIdeaPanel);
            this.Controls.Add(this.divide_line);
            this.Controls.Add(this.singleSearchButton);
            this.Controls.Add(this.manualSearchLabel);
            this.Controls.Add(this.manualSearchInput);
            this.Controls.Add(this.PageTitle);
            this.Controls.Add(this.ExpireDatePicker);
            this.Controls.Add(this.ExpireDateLabel);
            this.Controls.Add(this.MaxCostTrackBar);
            this.Controls.Add(this.MinCostTrackBar);
            this.Controls.Add(this.MaxRiskTrackBar);
            this.Controls.Add(this.MinRiskTrackBar);
            this.Controls.Add(this.MaxCostLabel);
            this.Controls.Add(this.MinCostLabel);
            this.Controls.Add(this.MaxRiskLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MinRiskLabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FilterWindow";
            this.Text = "RM Filter page";
            ((System.ComponentModel.ISupportInitialize)(this.MinRiskTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRiskTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinCostTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxCostTrackBar)).EndInit();
            this.singleIdeaPanel.ResumeLayout(false);
            this.singleIdeaPanel.PerformLayout();
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
        private System.Windows.Forms.Label ExpireDateLabel;
        private System.Windows.Forms.DateTimePicker ExpireDatePicker;
        private System.Windows.Forms.Label PageTitle;
        private System.Windows.Forms.TextBox manualSearchInput;
        private System.Windows.Forms.Label manualSearchLabel;
        private System.Windows.Forms.Button singleSearchButton;
        private System.Windows.Forms.ProgressBar divide_line;
        private System.Windows.Forms.Panel singleIdeaPanel;
        private System.Windows.Forms.Button panelBackButton;
        private System.Windows.Forms.Label panelLabel;
    }
}