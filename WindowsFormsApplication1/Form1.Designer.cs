namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.naturalCitizenCheckBox = new System.Windows.Forms.CheckBox();
            this.yearOfBirthLabel = new System.Windows.Forms.Label();
            this.PriorTermsLabel = new System.Windows.Forms.Label();
            this.yearsResidedLabel = new System.Windows.Forms.Label();
            this.impeachedCheckBox = new System.Windows.Forms.CheckBox();
            this.rebelledCheckBox = new System.Windows.Forms.CheckBox();
            this.yearOfBirthAnswer = new System.Windows.Forms.TextBox();
            this.yearsResidedAnswer = new System.Windows.Forms.TextBox();
            this.priorTermsAnswer = new System.Windows.Forms.TextBox();
            this.CheckEligibilityButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // naturalCitizenCheckBox
            // 
            this.naturalCitizenCheckBox.AutoSize = true;
            this.naturalCitizenCheckBox.Location = new System.Drawing.Point(78, 49);
            this.naturalCitizenCheckBox.Name = "naturalCitizenCheckBox";
            this.naturalCitizenCheckBox.Size = new System.Drawing.Size(204, 21);
            this.naturalCitizenCheckBox.TabIndex = 0;
            this.naturalCitizenCheckBox.Text = "Natural Born Citizen of USA";
            this.naturalCitizenCheckBox.UseVisualStyleBackColor = true;
            this.naturalCitizenCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // yearOfBirthLabel
            // 
            this.yearOfBirthLabel.AutoSize = true;
            this.yearOfBirthLabel.Location = new System.Drawing.Point(75, 90);
            this.yearOfBirthLabel.Name = "yearOfBirthLabel";
            this.yearOfBirthLabel.Size = new System.Drawing.Size(87, 17);
            this.yearOfBirthLabel.TabIndex = 1;
            this.yearOfBirthLabel.Text = "Year of Birth";
            // 
            // PriorTermsLabel
            // 
            this.PriorTermsLabel.AutoSize = true;
            this.PriorTermsLabel.Location = new System.Drawing.Point(75, 158);
            this.PriorTermsLabel.Name = "PriorTermsLabel";
            this.PriorTermsLabel.Size = new System.Drawing.Size(201, 17);
            this.PriorTermsLabel.TabIndex = 2;
            this.PriorTermsLabel.Text = "Prior Number of Terms Served";
            // 
            // yearsResidedLabel
            // 
            this.yearsResidedLabel.AutoSize = true;
            this.yearsResidedLabel.Location = new System.Drawing.Point(75, 124);
            this.yearsResidedLabel.Name = "yearsResidedLabel";
            this.yearsResidedLabel.Size = new System.Drawing.Size(246, 17);
            this.yearsResidedLabel.TabIndex = 3;
            this.yearsResidedLabel.Text = "Number Years Resided in USA           ";
            this.yearsResidedLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // impeachedCheckBox
            // 
            this.impeachedCheckBox.AutoSize = true;
            this.impeachedCheckBox.Location = new System.Drawing.Point(78, 196);
            this.impeachedCheckBox.Name = "impeachedCheckBox";
            this.impeachedCheckBox.Size = new System.Drawing.Size(177, 21);
            this.impeachedCheckBox.TabIndex = 4;
            this.impeachedCheckBox.Text = "I have been impeached";
            this.impeachedCheckBox.UseVisualStyleBackColor = true;
            this.impeachedCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // rebelledCheckBox
            // 
            this.rebelledCheckBox.AutoSize = true;
            this.rebelledCheckBox.Location = new System.Drawing.Point(78, 223);
            this.rebelledCheckBox.Name = "rebelledCheckBox";
            this.rebelledCheckBox.Size = new System.Drawing.Size(220, 21);
            this.rebelledCheckBox.TabIndex = 5;
            this.rebelledCheckBox.Text = "I have rebelled against the US";
            this.rebelledCheckBox.UseVisualStyleBackColor = true;
            // 
            // yearOfBirthAnswer
            // 
            this.yearOfBirthAnswer.Location = new System.Drawing.Point(282, 90);
            this.yearOfBirthAnswer.Name = "yearOfBirthAnswer";
            this.yearOfBirthAnswer.Size = new System.Drawing.Size(52, 22);
            this.yearOfBirthAnswer.TabIndex = 6;
            // 
            // yearsResidedAnswer
            // 
            this.yearsResidedAnswer.Location = new System.Drawing.Point(282, 124);
            this.yearsResidedAnswer.Name = "yearsResidedAnswer";
            this.yearsResidedAnswer.Size = new System.Drawing.Size(52, 22);
            this.yearsResidedAnswer.TabIndex = 7;
            // 
            // priorTermsAnswer
            // 
            this.priorTermsAnswer.Location = new System.Drawing.Point(282, 158);
            this.priorTermsAnswer.Name = "priorTermsAnswer";
            this.priorTermsAnswer.Size = new System.Drawing.Size(52, 22);
            this.priorTermsAnswer.TabIndex = 8;
            // 
            // CheckEligibilityButton
            // 
            this.CheckEligibilityButton.Location = new System.Drawing.Point(78, 306);
            this.CheckEligibilityButton.Name = "CheckEligibilityButton";
            this.CheckEligibilityButton.Size = new System.Drawing.Size(228, 34);
            this.CheckEligibilityButton.TabIndex = 9;
            this.CheckEligibilityButton.Text = "Am I Eligible To Be President?";
            this.CheckEligibilityButton.UseVisualStyleBackColor = true;
            this.CheckEligibilityButton.Click += new System.EventHandler(this.CheckEligibilityButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 362);
            this.Controls.Add(this.CheckEligibilityButton);
            this.Controls.Add(this.priorTermsAnswer);
            this.Controls.Add(this.yearsResidedAnswer);
            this.Controls.Add(this.yearOfBirthAnswer);
            this.Controls.Add(this.rebelledCheckBox);
            this.Controls.Add(this.impeachedCheckBox);
            this.Controls.Add(this.yearsResidedLabel);
            this.Controls.Add(this.PriorTermsLabel);
            this.Controls.Add(this.yearOfBirthLabel);
            this.Controls.Add(this.naturalCitizenCheckBox);
            this.Name = "Form1";
            this.Text = "Presidential Eligibility Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox naturalCitizenCheckBox;
        private System.Windows.Forms.Label yearOfBirthLabel;
        private System.Windows.Forms.Label PriorTermsLabel;
        private System.Windows.Forms.Label yearsResidedLabel;
        private System.Windows.Forms.CheckBox impeachedCheckBox;
        private System.Windows.Forms.CheckBox rebelledCheckBox;
        private System.Windows.Forms.TextBox yearOfBirthAnswer;
        private System.Windows.Forms.TextBox yearsResidedAnswer;
        private System.Windows.Forms.TextBox priorTermsAnswer;
        private System.Windows.Forms.Button CheckEligibilityButton;
    }
}

