
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
            this.Edit_Idea_Button = new System.Windows.Forms.Button();
            this.New_Idea_Button = new System.Windows.Forms.Button();
            this.Delete_Idea_Button = new System.Windows.Forms.Button();
            this.IS_Back_Button = new System.Windows.Forms.Button();
            this.Idea_Submitter_Table = new System.Windows.Forms.DataGridView();
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
            // Edit_Idea_Button
            // 
            this.Edit_Idea_Button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Edit_Idea_Button.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Idea_Button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Edit_Idea_Button.Location = new System.Drawing.Point(564, 137);
            this.Edit_Idea_Button.Name = "Edit_Idea_Button";
            this.Edit_Idea_Button.Size = new System.Drawing.Size(337, 64);
            this.Edit_Idea_Button.TabIndex = 16;
            this.Edit_Idea_Button.Text = "Edit Idea";
            this.Edit_Idea_Button.UseVisualStyleBackColor = false;
            // 
            // New_Idea_Button
            // 
            this.New_Idea_Button.BackColor = System.Drawing.SystemColors.Highlight;
            this.New_Idea_Button.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Idea_Button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.New_Idea_Button.Location = new System.Drawing.Point(12, 137);
            this.New_Idea_Button.Name = "New_Idea_Button";
            this.New_Idea_Button.Size = new System.Drawing.Size(337, 64);
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
            this.Delete_Idea_Button.Location = new System.Drawing.Point(1116, 137);
            this.Delete_Idea_Button.Name = "Delete_Idea_Button";
            this.Delete_Idea_Button.Size = new System.Drawing.Size(337, 64);
            this.Delete_Idea_Button.TabIndex = 18;
            this.Delete_Idea_Button.Text = "Delete Idea";
            this.Delete_Idea_Button.UseVisualStyleBackColor = false;
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
            this.Idea_Submitter_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Idea_Submitter_Table.Location = new System.Drawing.Point(12, 236);
            this.Idea_Submitter_Table.Name = "Idea_Submitter_Table";
            this.Idea_Submitter_Table.Size = new System.Drawing.Size(1441, 569);
            this.Idea_Submitter_Table.TabIndex = 20;
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
            this.Controls.Add(this.Edit_Idea_Button);
            this.Controls.Add(this.Idea_Submitter_label);
            this.Name = "IdeaSubmitterForm";
            this.Text = "IdeaSubmitterForm";
            ((System.ComponentModel.ISupportInitialize)(this.Idea_Submitter_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Idea_Submitter_label;
        private System.Windows.Forms.Button Edit_Idea_Button;
        private System.Windows.Forms.Button New_Idea_Button;
        private System.Windows.Forms.Button Delete_Idea_Button;
        private System.Windows.Forms.Button IS_Back_Button;
        private System.Windows.Forms.DataGridView Idea_Submitter_Table;
    }
}