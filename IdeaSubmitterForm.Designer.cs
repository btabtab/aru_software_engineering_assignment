
namespace aru_software_eng_UI
{
    partial class IdeaSubmitterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdeaSubmitterForm));
            this.Idea_Submitter_label = new System.Windows.Forms.Label();
            this.New_Idea_Button = new System.Windows.Forms.Button();
            this.Delete_Idea_Button = new System.Windows.Forms.Button();
            this.IS_Back_Button = new System.Windows.Forms.Button();
            this.Idea_Submitter_Table = new System.Windows.Forms.DataGridView();
            this.investmentIdeasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coreDataBaseDataSet = new aru_software_eng_UI.CoreDataBaseDataSet();
            this.investmentIdeasTableAdapter = new aru_software_eng_UI.CoreDataBaseDataSetTableAdapters.InvestmentIdeasTableAdapter();
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RiskLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequiredPermissions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Idea_Submitter_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.investmentIdeasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coreDataBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Idea_Submitter_label
            // 
            this.Idea_Submitter_label.AutoSize = true;
            this.Idea_Submitter_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idea_Submitter_label.Location = new System.Drawing.Point(0, 0);
            this.Idea_Submitter_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Idea_Submitter_label.Name = "Idea_Submitter_label";
            this.Idea_Submitter_label.Size = new System.Drawing.Size(952, 153);
            this.Idea_Submitter_label.TabIndex = 12;
            this.Idea_Submitter_label.Text = "Idea Submitter";
            // 
            // New_Idea_Button
            // 
            this.New_Idea_Button.BackColor = System.Drawing.SystemColors.Highlight;
            this.New_Idea_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Idea_Button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.New_Idea_Button.Location = new System.Drawing.Point(24, 263);
            this.New_Idea_Button.Margin = new System.Windows.Forms.Padding(6);
            this.New_Idea_Button.Name = "New_Idea_Button";
            this.New_Idea_Button.Size = new System.Drawing.Size(1162, 123);
            this.New_Idea_Button.TabIndex = 17;
            this.New_Idea_Button.Text = "New Idea";
            this.New_Idea_Button.UseVisualStyleBackColor = false;
            this.New_Idea_Button.Click += new System.EventHandler(this.New_Idea_Button_Click);
            // 
            // Delete_Idea_Button
            // 
            this.Delete_Idea_Button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Delete_Idea_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Idea_Button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Delete_Idea_Button.Location = new System.Drawing.Point(1198, 263);
            this.Delete_Idea_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Delete_Idea_Button.Name = "Delete_Idea_Button";
            this.Delete_Idea_Button.Size = new System.Drawing.Size(1162, 123);
            this.Delete_Idea_Button.TabIndex = 18;
            this.Delete_Idea_Button.Text = "Delete Idea";
            this.Delete_Idea_Button.UseVisualStyleBackColor = false;
            this.Delete_Idea_Button.Click += new System.EventHandler(this.Delete_Idea_Button_Click);
            // 
            // IS_Back_Button
            // 
            this.IS_Back_Button.Image = ((System.Drawing.Image)(resources.GetObject("IS_Back_Button.Image")));
            this.IS_Back_Button.Location = new System.Drawing.Point(2104, 128);
            this.IS_Back_Button.Margin = new System.Windows.Forms.Padding(6);
            this.IS_Back_Button.Name = "IS_Back_Button";
            this.IS_Back_Button.Size = new System.Drawing.Size(256, 123);
            this.IS_Back_Button.TabIndex = 19;
            this.IS_Back_Button.UseVisualStyleBackColor = true;
            this.IS_Back_Button.Click += new System.EventHandler(this.IS_Back_Button_Click);
            // 
            // Idea_Submitter_Table
            // 
            this.Idea_Submitter_Table.AutoGenerateColumns = false;
            this.Idea_Submitter_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Idea_Submitter_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Idea_Submitter_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_ID,
            this.Name,
            this.Description,
            this.RiskLevel,
            this.Cost,
            this.Date,
            this.ProductTag,
            this.RequiredPermissions});
            this.Idea_Submitter_Table.DataSource = this.investmentIdeasBindingSource;
            this.Idea_Submitter_Table.Location = new System.Drawing.Point(26, 398);
            this.Idea_Submitter_Table.Margin = new System.Windows.Forms.Padding(6);
            this.Idea_Submitter_Table.Name = "Idea_Submitter_Table";
            this.Idea_Submitter_Table.RowHeadersWidth = 82;
            this.Idea_Submitter_Table.Size = new System.Drawing.Size(2334, 781);
            this.Idea_Submitter_Table.TabIndex = 20;
            // 
            // investmentIdeasBindingSource
            // 
            this.investmentIdeasBindingSource.DataMember = "InvestmentIdeas";
            this.investmentIdeasBindingSource.DataSource = this.coreDataBaseDataSet;
            // 
            // coreDataBaseDataSet
            // 
            this.coreDataBaseDataSet.DataSetName = "CoreDataBaseDataSet";
            this.coreDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // investmentIdeasTableAdapter
            // 
            this.investmentIdeasTableAdapter.ClearBeforeFill = true;
            // 
            // User_ID
            // 
            this.User_ID.DataPropertyName = "User_ID";
            this.User_ID.HeaderText = "User_ID";
            this.User_ID.MinimumWidth = 10;
            this.User_ID.Name = "User_ID";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 10;
            this.Name.Name = "Name";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 10;
            this.Description.Name = "Description";
            // 
            // RiskLevel
            // 
            this.RiskLevel.DataPropertyName = "RiskLevel";
            this.RiskLevel.HeaderText = "RiskLevel";
            this.RiskLevel.MinimumWidth = 10;
            this.RiskLevel.Name = "RiskLevel";
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 10;
            this.Cost.Name = "Cost";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 10;
            this.Date.Name = "Date";
            // 
            // ProductTag
            // 
            this.ProductTag.DataPropertyName = "ProductTag";
            this.ProductTag.HeaderText = "ProductTag";
            this.ProductTag.MinimumWidth = 10;
            this.ProductTag.Name = "ProductTag";
            // 
            // RequiredPermissions
            // 
            this.RequiredPermissions.DataPropertyName = "RequiredPermissions";
            this.RequiredPermissions.HeaderText = "RequiredPermissions";
            this.RequiredPermissions.MinimumWidth = 10;
            this.RequiredPermissions.Name = "RequiredPermissions";
            // 
            // IdeaSubmitterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2740, 1604);
            this.Controls.Add(this.Idea_Submitter_Table);
            this.Controls.Add(this.IS_Back_Button);
            this.Controls.Add(this.Delete_Idea_Button);
            this.Controls.Add(this.New_Idea_Button);
            this.Controls.Add(this.Idea_Submitter_label);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Text = "IdeaSubmitterForm";
            ((System.ComponentModel.ISupportInitialize)(this.Idea_Submitter_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.investmentIdeasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coreDataBaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Idea_Submitter_label;
        private System.Windows.Forms.Button New_Idea_Button;
        private System.Windows.Forms.Button Delete_Idea_Button;
        private System.Windows.Forms.Button IS_Back_Button;
        public System.Windows.Forms.DataGridView Idea_Submitter_Table;
        private CoreDataBaseDataSet coreDataBaseDataSet;
        private System.Windows.Forms.BindingSource investmentIdeasBindingSource;
        private CoreDataBaseDataSetTableAdapters.InvestmentIdeasTableAdapter investmentIdeasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn RiskLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequiredPermissions;
    }
}