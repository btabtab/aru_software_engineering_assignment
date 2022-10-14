
namespace aru_software_eng_UI
{
    partial class Signup
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
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.RulesCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginGetter = new System.Windows.Forms.TextBox();
            this.RulesText = new System.Windows.Forms.LinkLabel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.EmailGetter = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordGetter1 = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.AgainPasswordLabel = new System.Windows.Forms.Label();
            this.PasswordGetter2 = new System.Windows.Forms.TextBox();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.Account_type = new System.Windows.Forms.Label();
            this.accountTypeSelector = new System.Windows.Forms.ComboBox();
            this.wrongPassSymbol1 = new System.Windows.Forms.Label();
            this.wrongPassSymbol2 = new System.Windows.Forms.Label();
            this.wrongEmailSymbol = new System.Windows.Forms.Label();
            this.wrongUserSymbol = new System.Windows.Forms.Label();
            this.errorOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SignUpButton.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SignUpButton.Location = new System.Drawing.Point(337, 369);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(2);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(106, 44);
            this.SignUpButton.TabIndex = 0;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Font = new System.Drawing.Font("Agency FB", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabel.Location = new System.Drawing.Point(-8, -5);
            this.SignUpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(451, 80);
            this.SignUpLabel.TabIndex = 1;
            this.SignUpLabel.Text = "Create an account";
            // 
            // RulesCheckBox
            // 
            this.RulesCheckBox.AutoSize = true;
            this.RulesCheckBox.Location = new System.Drawing.Point(269, 344);
            this.RulesCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.RulesCheckBox.Name = "RulesCheckBox";
            this.RulesCheckBox.Size = new System.Drawing.Size(15, 14);
            this.RulesCheckBox.TabIndex = 2;
            this.RulesCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginGetter
            // 
            this.LoginGetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LoginGetter.Location = new System.Drawing.Point(445, 115);
            this.LoginGetter.Margin = new System.Windows.Forms.Padding(2);
            this.LoginGetter.MaxLength = 20;
            this.LoginGetter.Name = "LoginGetter";
            this.LoginGetter.Size = new System.Drawing.Size(224, 38);
            this.LoginGetter.TabIndex = 3;
            // 
            // RulesText
            // 
            this.RulesText.AutoSize = true;
            this.RulesText.Location = new System.Drawing.Point(288, 344);
            this.RulesText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RulesText.Name = "RulesText";
            this.RulesText.Size = new System.Drawing.Size(243, 13);
            this.RulesText.TabIndex = 4;
            this.RulesText.TabStop = true;
            this.RulesText.Text = "I confirm I have read the rules and privacy policies";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold);
            this.LoginLabel.Location = new System.Drawing.Point(344, 116);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(106, 34);
            this.LoginLabel.TabIndex = 5;
            this.LoginLabel.Text = "Username:";
            // 
            // EmailGetter
            // 
            this.EmailGetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailGetter.Location = new System.Drawing.Point(187, 156);
            this.EmailGetter.Margin = new System.Windows.Forms.Padding(2);
            this.EmailGetter.Name = "EmailGetter";
            this.EmailGetter.Size = new System.Drawing.Size(482, 38);
            this.EmailGetter.TabIndex = 6;
            this.EmailGetter.TextChanged += new System.EventHandler(this.EmailGetter_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold);
            this.EmailLabel.Location = new System.Drawing.Point(110, 157);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(64, 34);
            this.EmailLabel.TabIndex = 7;
            this.EmailLabel.Text = "Email:";
            // 
            // PasswordGetter1
            // 
            this.PasswordGetter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordGetter1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PasswordGetter1.Location = new System.Drawing.Point(187, 199);
            this.PasswordGetter1.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordGetter1.MaxLength = 14;
            this.PasswordGetter1.Name = "PasswordGetter1";
            this.PasswordGetter1.PasswordChar = '*';
            this.PasswordGetter1.Size = new System.Drawing.Size(482, 38);
            this.PasswordGetter1.TabIndex = 8;
            this.PasswordGetter1.UseSystemPasswordChar = true;
            this.PasswordGetter1.TextChanged += new System.EventHandler(this.PasswordGetter1_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold);
            this.PasswordLabel.Location = new System.Drawing.Point(68, 199);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(106, 34);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // AgainPasswordLabel
            // 
            this.AgainPasswordLabel.AutoSize = true;
            this.AgainPasswordLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold);
            this.AgainPasswordLabel.Location = new System.Drawing.Point(6, 242);
            this.AgainPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AgainPasswordLabel.Name = "AgainPasswordLabel";
            this.AgainPasswordLabel.Size = new System.Drawing.Size(168, 34);
            this.AgainPasswordLabel.TabIndex = 10;
            this.AgainPasswordLabel.Text = "Repeat password:";
            // 
            // PasswordGetter2
            // 
            this.PasswordGetter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordGetter2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PasswordGetter2.Location = new System.Drawing.Point(187, 245);
            this.PasswordGetter2.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordGetter2.MaxLength = 14;
            this.PasswordGetter2.Name = "PasswordGetter2";
            this.PasswordGetter2.PasswordChar = '*';
            this.PasswordGetter2.Size = new System.Drawing.Size(482, 38);
            this.PasswordGetter2.TabIndex = 11;
            this.PasswordGetter2.UseSystemPasswordChar = true;
            // 
            // GoBackButton
            // 
            this.GoBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.GoBackButton.Location = new System.Drawing.Point(350, 417);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(82, 28);
            this.GoBackButton.TabIndex = 12;
            this.GoBackButton.Text = "Go back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // Account_type
            // 
            this.Account_type.AutoSize = true;
            this.Account_type.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold);
            this.Account_type.Location = new System.Drawing.Point(44, 114);
            this.Account_type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Account_type.Name = "Account_type";
            this.Account_type.Size = new System.Drawing.Size(130, 34);
            this.Account_type.TabIndex = 13;
            this.Account_type.Text = "Account type:";
            // 
            // accountTypeSelector
            // 
            this.accountTypeSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.accountTypeSelector.FormattingEnabled = true;
            this.accountTypeSelector.Location = new System.Drawing.Point(187, 114);
            this.accountTypeSelector.Name = "accountTypeSelector";
            this.accountTypeSelector.Size = new System.Drawing.Size(153, 39);
            this.accountTypeSelector.TabIndex = 15;
            // 
            // wrongPassSymbol1
            // 
            this.wrongPassSymbol1.AutoSize = true;
            this.wrongPassSymbol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.wrongPassSymbol1.ForeColor = System.Drawing.Color.Red;
            this.wrongPassSymbol1.Location = new System.Drawing.Point(674, 202);
            this.wrongPassSymbol1.Name = "wrongPassSymbol1";
            this.wrongPassSymbol1.Size = new System.Drawing.Size(0, 31);
            this.wrongPassSymbol1.TabIndex = 17;
            // 
            // wrongPassSymbol2
            // 
            this.wrongPassSymbol2.AutoSize = true;
            this.wrongPassSymbol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.wrongPassSymbol2.ForeColor = System.Drawing.Color.Red;
            this.wrongPassSymbol2.Location = new System.Drawing.Point(674, 248);
            this.wrongPassSymbol2.Name = "wrongPassSymbol2";
            this.wrongPassSymbol2.Size = new System.Drawing.Size(0, 31);
            this.wrongPassSymbol2.TabIndex = 18;
            // 
            // wrongEmailSymbol
            // 
            this.wrongEmailSymbol.AutoSize = true;
            this.wrongEmailSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.wrongEmailSymbol.ForeColor = System.Drawing.Color.Red;
            this.wrongEmailSymbol.Location = new System.Drawing.Point(674, 159);
            this.wrongEmailSymbol.Name = "wrongEmailSymbol";
            this.wrongEmailSymbol.Size = new System.Drawing.Size(0, 31);
            this.wrongEmailSymbol.TabIndex = 19;
            // 
            // wrongUserSymbol
            // 
            this.wrongUserSymbol.AutoSize = true;
            this.wrongUserSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.wrongUserSymbol.ForeColor = System.Drawing.Color.Red;
            this.wrongUserSymbol.Location = new System.Drawing.Point(674, 118);
            this.wrongUserSymbol.Name = "wrongUserSymbol";
            this.wrongUserSymbol.Size = new System.Drawing.Size(0, 31);
            this.wrongUserSymbol.TabIndex = 20;
            // 
            // errorOutputLabel
            // 
            this.errorOutputLabel.AutoSize = true;
            this.errorOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.errorOutputLabel.ForeColor = System.Drawing.Color.Red;
            this.errorOutputLabel.Location = new System.Drawing.Point(285, 301);
            this.errorOutputLabel.Name = "errorOutputLabel";
            this.errorOutputLabel.Size = new System.Drawing.Size(0, 31);
            this.errorOutputLabel.TabIndex = 16;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.wrongUserSymbol);
            this.Controls.Add(this.wrongEmailSymbol);
            this.Controls.Add(this.wrongPassSymbol2);
            this.Controls.Add(this.wrongPassSymbol1);
            this.Controls.Add(this.errorOutputLabel);
            this.Controls.Add(this.accountTypeSelector);
            this.Controls.Add(this.Account_type);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.PasswordGetter2);
            this.Controls.Add(this.AgainPasswordLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordGetter1);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmailGetter);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.RulesText);
            this.Controls.Add(this.LoginGetter);
            this.Controls.Add(this.RulesCheckBox);
            this.Controls.Add(this.SignUpLabel);
            this.Controls.Add(this.SignUpButton);
            this.Name = "Signup";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.CheckBox RulesCheckBox;
        private System.Windows.Forms.TextBox LoginGetter;
        private System.Windows.Forms.LinkLabel RulesText;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox EmailGetter;
        private System.Windows.Forms.TextBox PasswordGetter1;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label AgainPasswordLabel;
        private System.Windows.Forms.TextBox PasswordGetter2;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label Account_type;
        private System.Windows.Forms.ComboBox accountTypeSelector;
        private System.Windows.Forms.Label wrongPassSymbol1;
        private System.Windows.Forms.Label wrongPassSymbol2;
        private System.Windows.Forms.Label wrongEmailSymbol;
        private System.Windows.Forms.Label wrongUserSymbol;
        private System.Windows.Forms.Label errorOutputLabel;
    }
}