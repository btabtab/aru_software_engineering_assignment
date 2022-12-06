
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
            this.IS_newIdeaLabel = new System.Windows.Forms.Label();
            this.IS_back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.Risk = new System.Windows.Forms.TrackBar();
            this.Cost = new System.Windows.Forms.TrackBar();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.product_tag = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Risk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).BeginInit();
            this.SuspendLayout();
            // 
            // IS_save_button
            // 
            this.IS_save_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.IS_save_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.IS_save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_save_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IS_save_button.Location = new System.Drawing.Point(430, 777);
            this.IS_save_button.Margin = new System.Windows.Forms.Padding(6);
            this.IS_save_button.Name = "IS_save_button";
            this.IS_save_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IS_save_button.Size = new System.Drawing.Size(212, 85);
            this.IS_save_button.TabIndex = 0;
            this.IS_save_button.Text = "Save ";
            this.IS_save_button.UseVisualStyleBackColor = false;
            this.IS_save_button.Click += new System.EventHandler(this.IS_save_button_Click);
            // 
            // IS_newIdeaLabel
            // 
            this.IS_newIdeaLabel.AutoSize = true;
            this.IS_newIdeaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_newIdeaLabel.Location = new System.Drawing.Point(8, 17);
            this.IS_newIdeaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IS_newIdeaLabel.Name = "IS_newIdeaLabel";
            this.IS_newIdeaLabel.Size = new System.Drawing.Size(640, 153);
            this.IS_newIdeaLabel.TabIndex = 25;
            this.IS_newIdeaLabel.Text = "New Idea";
            // 
            // IS_back_button
            // 
            this.IS_back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_back_button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.IS_back_button.Location = new System.Drawing.Point(452, 869);
            this.IS_back_button.Margin = new System.Windows.Forms.Padding(4);
            this.IS_back_button.Name = "IS_back_button";
            this.IS_back_button.Size = new System.Drawing.Size(164, 54);
            this.IS_back_button.TabIndex = 31;
            this.IS_back_button.Text = "Cancel";
            this.IS_back_button.UseVisualStyleBackColor = true;
            this.IS_back_button.Click += new System.EventHandler(this.IS_back_button_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 67);
            this.label1.TabIndex = 32;
            this.label1.Text = "Name\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 67);
            this.label2.TabIndex = 33;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 67);
            this.label3.TabIndex = 35;
            this.label3.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 67);
            this.label4.TabIndex = 34;
            this.label4.Text = "Expiry date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 67);
            this.label6.TabIndex = 36;
            this.label6.Text = "Risk level";
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(361, 227);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(667, 67);
            this.desc.TabIndex = 37;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(361, 180);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(667, 31);
            this.name.TabIndex = 38;
            // 
            // Risk
            // 
            this.Risk.LargeChange = 5000;
            this.Risk.Location = new System.Drawing.Point(361, 490);
            this.Risk.Margin = new System.Windows.Forms.Padding(6);
            this.Risk.Maximum = 100000;
            this.Risk.Name = "Risk";
            this.Risk.Size = new System.Drawing.Size(416, 90);
            this.Risk.TabIndex = 40;
            this.Risk.Value = 10000;
            // 
            // Cost
            // 
            this.Cost.LargeChange = 1;
            this.Cost.Location = new System.Drawing.Point(361, 402);
            this.Cost.Margin = new System.Windows.Forms.Padding(6);
            this.Cost.Maximum = 5;
            this.Cost.Minimum = 1;
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(416, 90);
            this.Cost.TabIndex = 39;
            this.Cost.Value = 2;
            // 
            // date_picker
            // 
            this.date_picker.Location = new System.Drawing.Point(361, 352);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(400, 31);
            this.date_picker.TabIndex = 41;
            // 
            // product_tag
            // 
            this.product_tag.Location = new System.Drawing.Point(361, 589);
            this.product_tag.Multiline = true;
            this.product_tag.Name = "product_tag";
            this.product_tag.Size = new System.Drawing.Size(667, 67);
            this.product_tag.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 589);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 67);
            this.label5.TabIndex = 43;
            this.label5.Text = "Product tag:";
            // 
            // CreateNewIdeaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 939);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.product_tag);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.Risk);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.name);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IS_back_button);
            this.Controls.Add(this.IS_newIdeaLabel);
            this.Controls.Add(this.IS_save_button);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateNewIdeaForm";
            this.Text = "CreateNewIdea";
            this.Load += new System.EventHandler(this.CreateNewIdea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Risk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IS_save_button;
        private System.Windows.Forms.Label IS_newIdeaLabel;
        private System.Windows.Forms.Button IS_back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TrackBar Risk;
        private System.Windows.Forms.TrackBar Cost;
        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.TextBox product_tag;
        private System.Windows.Forms.Label label5;
    }
}