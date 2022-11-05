
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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Bonds");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("IT");
            this.RiskTrackBar = new System.Windows.Forms.TrackBar();
            this.RiskLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostTrackBar = new System.Windows.Forms.TrackBar();
            this.ExpiryDateLabel = new System.Windows.Forms.Label();
            this.ExpireDateTrackBar = new System.Windows.Forms.TrackBar();
            this.IndustryLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.TrendingCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RiskTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpireDateTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // RiskTrackBar
            // 
            this.RiskTrackBar.Location = new System.Drawing.Point(319, 130);
            this.RiskTrackBar.Name = "RiskTrackBar";
            this.RiskTrackBar.Size = new System.Drawing.Size(301, 45);
            this.RiskTrackBar.TabIndex = 0;
            this.RiskTrackBar.Scroll += new System.EventHandler(this.RiskTrackBar_Scroll);
            // 
            // RiskLabel
            // 
            this.RiskLabel.AutoSize = true;
            this.RiskLabel.Location = new System.Drawing.Point(191, 140);
            this.RiskLabel.Name = "RiskLabel";
            this.RiskLabel.Size = new System.Drawing.Size(28, 13);
            this.RiskLabel.TabIndex = 1;
            this.RiskLabel.Text = "Risk";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(191, 191);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CostLabel.Size = new System.Drawing.Size(28, 13);
            this.CostLabel.TabIndex = 2;
            this.CostLabel.Text = "Cost";
            // 
            // CostTrackBar
            // 
            this.CostTrackBar.Location = new System.Drawing.Point(319, 181);
            this.CostTrackBar.Name = "CostTrackBar";
            this.CostTrackBar.Size = new System.Drawing.Size(301, 45);
            this.CostTrackBar.TabIndex = 3;
            this.CostTrackBar.Scroll += new System.EventHandler(this.CostTrackBar_Scroll);
            // 
            // ExpiryDateLabel
            // 
            this.ExpiryDateLabel.AutoSize = true;
            this.ExpiryDateLabel.Location = new System.Drawing.Point(191, 241);
            this.ExpiryDateLabel.Name = "ExpiryDateLabel";
            this.ExpiryDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExpiryDateLabel.Size = new System.Drawing.Size(62, 13);
            this.ExpiryDateLabel.TabIndex = 4;
            this.ExpiryDateLabel.Text = "Expire Date";
            // 
            // ExpireDateTrackBar
            // 
            this.ExpireDateTrackBar.Location = new System.Drawing.Point(319, 232);
            this.ExpireDateTrackBar.Name = "ExpireDateTrackBar";
            this.ExpireDateTrackBar.Size = new System.Drawing.Size(301, 45);
            this.ExpireDateTrackBar.TabIndex = 5;
            this.ExpireDateTrackBar.Scroll += new System.EventHandler(this.ExpireDateTrackBar_Scroll);
            // 
            // IndustryLabel
            // 
            this.IndustryLabel.AutoSize = true;
            this.IndustryLabel.Location = new System.Drawing.Point(191, 286);
            this.IndustryLabel.Name = "IndustryLabel";
            this.IndustryLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IndustryLabel.Size = new System.Drawing.Size(44, 13);
            this.IndustryLabel.TabIndex = 6;
            this.IndustryLabel.Text = "Industry";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6});
            this.listView1.Location = new System.Drawing.Point(425, 286);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 42);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // TrendingCheckBox
            // 
            this.TrendingCheckBox.AutoSize = true;
            this.TrendingCheckBox.Location = new System.Drawing.Point(310, 334);
            this.TrendingCheckBox.Name = "TrendingCheckBox";
            this.TrendingCheckBox.Size = new System.Drawing.Size(122, 17);
            this.TrendingCheckBox.TabIndex = 8;
            this.TrendingCheckBox.Text = "Show Only Trending";
            this.TrendingCheckBox.UseVisualStyleBackColor = true;
            this.TrendingCheckBox.CheckedChanged += new System.EventHandler(this.TrendingCheckBox_CheckedChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(308, 390);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // RelationshipManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.TrendingCheckBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.IndustryLabel);
            this.Controls.Add(this.ExpireDateTrackBar);
            this.Controls.Add(this.ExpiryDateLabel);
            this.Controls.Add(this.CostTrackBar);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.RiskLabel);
            this.Controls.Add(this.RiskTrackBar);
            this.Name = "RelationshipManagerView";
            this.Text = "RelationshipManagerView";
            this.Load += new System.EventHandler(this.RelationshipManagerView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RiskTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpireDateTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar RiskTrackBar;
        private System.Windows.Forms.Label RiskLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TrackBar CostTrackBar;
        private System.Windows.Forms.Label ExpiryDateLabel;
        private System.Windows.Forms.TrackBar ExpireDateTrackBar;
        private System.Windows.Forms.Label IndustryLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox TrendingCheckBox;
        private System.Windows.Forms.Button SearchButton;
    }
}