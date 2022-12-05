
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdeaSubmitterForm));
            this.Idea_Submitter_label = new System.Windows.Forms.Label();
            this.New_Idea_Button = new System.Windows.Forms.Button();
            this.Delete_Idea_Button = new System.Windows.Forms.Button();
            this.IS_Back_Button = new System.Windows.Forms.Button();
            this.Idea_Submitter_Table = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Idea_Submitter_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Idea_Submitter_label
            // 
            this.Idea_Submitter_label.AutoSize = true;
            this.Idea_Submitter_label.Font = new System.Drawing.Font("Agency FB", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idea_Submitter_label.Location = new System.Drawing.Point(0, 0);
            this.Idea_Submitter_label.Name = "Idea_Submitter_label";
            this.Idea_Submitter_label.Size = new System.Drawing.Size(370, 80);
            this.Idea_Submitter_label.TabIndex = 12;
            this.Idea_Submitter_label.Text = "Idea Submitter";
            // 
            // New_Idea_Button
            // 
            this.New_Idea_Button.BackColor = System.Drawing.SystemColors.Highlight;
            this.New_Idea_Button.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Idea_Button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.New_Idea_Button.Location = new System.Drawing.Point(12, 137);
            this.New_Idea_Button.Name = "New_Idea_Button";
            this.New_Idea_Button.Size = new System.Drawing.Size(581, 64);
            this.New_Idea_Button.TabIndex = 17;
            this.New_Idea_Button.Text = "New Idea";
            this.New_Idea_Button.UseVisualStyleBackColor = false;
            this.New_Idea_Button.Click += new System.EventHandler(this.New_Idea_Button_Click);
            // 
            // Delete_Idea_Button
            // 
            this.Delete_Idea_Button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Delete_Idea_Button.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Idea_Button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Delete_Idea_Button.Location = new System.Drawing.Point(872, 137);
            this.Delete_Idea_Button.Name = "Delete_Idea_Button";
            this.Delete_Idea_Button.Size = new System.Drawing.Size(581, 64);
            this.Delete_Idea_Button.TabIndex = 18;
            this.Delete_Idea_Button.Text = "Delete Idea";
            this.Delete_Idea_Button.UseVisualStyleBackColor = false;
            this.Delete_Idea_Button.Click += new System.EventHandler(this.Delete_Idea_Button_Click);
            // 
            // IS_Back_Button
            // 
            this.IS_Back_Button.Image = ((System.Drawing.Image)(resources.GetObject("IS_Back_Button.Image")));
            this.IS_Back_Button.Location = new System.Drawing.Point(1325, 25);
            this.IS_Back_Button.Name = "IS_Back_Button";
            this.IS_Back_Button.Size = new System.Drawing.Size(128, 64);
            this.IS_Back_Button.TabIndex = 19;
            this.IS_Back_Button.UseVisualStyleBackColor = true;
            this.IS_Back_Button.Click += new System.EventHandler(this.IS_Back_Button_Click);
            // 
            // Idea_Submitter_Table
            // 
            this.Idea_Submitter_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Idea_Submitter_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Idea_Submitter_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.Idea_Submitter_Table.Location = new System.Drawing.Point(12, 236);
            this.Idea_Submitter_Table.Name = "Idea_Submitter_Table";
            this.Idea_Submitter_Table.Size = new System.Drawing.Size(1441, 569);
            this.Idea_Submitter_Table.TabIndex = 20;
            this.Idea_Submitter_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Idea_Submitter_Table_CellContentClick);
            this.Idea_Submitter_Table.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.Idea_Submitter_Table_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Industry";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cost";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Risk";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Expiry Date";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "RM rating";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Description";
            this.Column7.Name = "Column7";
            // 
            // IdeaSubmitterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 834);
            this.Controls.Add(this.Idea_Submitter_Table);
            this.Controls.Add(this.IS_Back_Button);
            this.Controls.Add(this.Delete_Idea_Button);
            this.Controls.Add(this.New_Idea_Button);
            this.Controls.Add(this.Idea_Submitter_label);
            this.Name = "IdeaSubmitterForm";
            this.Text = "IdeaSubmitterForm";
            this.Load += new System.EventHandler(this.IdeaSubmitterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Idea_Submitter_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Idea_Submitter_label;
        private System.Windows.Forms.Button New_Idea_Button;
        private System.Windows.Forms.Button Delete_Idea_Button;
        private System.Windows.Forms.Button IS_Back_Button;
        public System.Windows.Forms.DataGridView Idea_Submitter_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}