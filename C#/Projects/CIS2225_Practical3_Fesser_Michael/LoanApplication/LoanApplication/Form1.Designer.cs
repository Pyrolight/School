namespace LoanApplication
{
    partial class LoanApplication
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
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.loanTypeGB = new System.Windows.Forms.GroupBox();
            this.studentRB = new System.Windows.Forms.RadioButton();
            this.autoRB = new System.Windows.Forms.RadioButton();
            this.homeRB = new System.Windows.Forms.RadioButton();
            this.loanLengthNUD = new System.Windows.Forms.NumericUpDown();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.loanAmountLabel = new System.Windows.Forms.Label();
            this.loanLengthLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.annualInterestTB = new System.Windows.Forms.TextBox();
            this.totalInterestTB = new System.Windows.Forms.TextBox();
            this.loanTotalTB = new System.Windows.Forms.TextBox();
            this.annualInterestLabel = new System.Windows.Forms.Label();
            this.totalInterestLabel = new System.Windows.Forms.Label();
            this.totalLoanLabel = new System.Windows.Forms.Label();
            this.studentDiscountRTB = new System.Windows.Forms.RichTextBox();
            this.loanAmountTB = new System.Windows.Forms.TextBox();
            this.loanTypeGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanLengthNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(121, 35);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(100, 20);
            this.lastNameTB.TabIndex = 0;
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(121, 64);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(100, 20);
            this.firstNameTB.TabIndex = 1;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(121, 90);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(100, 20);
            this.emailTB.TabIndex = 2;
            // 
            // loanTypeGB
            // 
            this.loanTypeGB.Controls.Add(this.studentRB);
            this.loanTypeGB.Controls.Add(this.autoRB);
            this.loanTypeGB.Controls.Add(this.homeRB);
            this.loanTypeGB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.loanTypeGB.Location = new System.Drawing.Point(252, 35);
            this.loanTypeGB.Name = "loanTypeGB";
            this.loanTypeGB.Size = new System.Drawing.Size(117, 108);
            this.loanTypeGB.TabIndex = 3;
            this.loanTypeGB.TabStop = false;
            this.loanTypeGB.Text = "Loan Type";
            // 
            // studentRB
            // 
            this.studentRB.AutoSize = true;
            this.studentRB.Location = new System.Drawing.Point(15, 77);
            this.studentRB.Name = "studentRB";
            this.studentRB.Size = new System.Drawing.Size(62, 17);
            this.studentRB.TabIndex = 2;
            this.studentRB.Text = "Student";
            this.studentRB.UseVisualStyleBackColor = true;
            // 
            // autoRB
            // 
            this.autoRB.AutoSize = true;
            this.autoRB.Location = new System.Drawing.Point(15, 53);
            this.autoRB.Name = "autoRB";
            this.autoRB.Size = new System.Drawing.Size(47, 17);
            this.autoRB.TabIndex = 1;
            this.autoRB.Text = "Auto";
            this.autoRB.UseVisualStyleBackColor = true;
            // 
            // homeRB
            // 
            this.homeRB.AutoSize = true;
            this.homeRB.Checked = true;
            this.homeRB.Location = new System.Drawing.Point(15, 29);
            this.homeRB.Name = "homeRB";
            this.homeRB.Size = new System.Drawing.Size(53, 17);
            this.homeRB.TabIndex = 0;
            this.homeRB.TabStop = true;
            this.homeRB.Text = "Home";
            this.homeRB.UseVisualStyleBackColor = true;
            // 
            // loanLengthNUD
            // 
            this.loanLengthNUD.Location = new System.Drawing.Point(121, 229);
            this.loanLengthNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.loanLengthNUD.Name = "loanLengthNUD";
            this.loanLengthNUD.Size = new System.Drawing.Size(120, 20);
            this.loanLengthNUD.TabIndex = 5;
            this.loanLengthNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(19, 35);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(20, 64);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 7;
            this.firstNameLabel.Text = "First Name:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(19, 88);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email:";
            // 
            // loanAmountLabel
            // 
            this.loanAmountLabel.AutoSize = true;
            this.loanAmountLabel.Location = new System.Drawing.Point(17, 189);
            this.loanAmountLabel.Name = "loanAmountLabel";
            this.loanAmountLabel.Size = new System.Drawing.Size(73, 13);
            this.loanAmountLabel.TabIndex = 10;
            this.loanAmountLabel.Text = "Loan Amount:";
            // 
            // loanLengthLabel
            // 
            this.loanLengthLabel.AutoSize = true;
            this.loanLengthLabel.Location = new System.Drawing.Point(17, 229);
            this.loanLengthLabel.Name = "loanLengthLabel";
            this.loanLengthLabel.Size = new System.Drawing.Size(70, 13);
            this.loanLengthLabel.TabIndex = 11;
            this.loanLengthLabel.Text = "Loan Length:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(277, 229);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Submit Loan";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // annualInterestTB
            // 
            this.annualInterestTB.BackColor = System.Drawing.SystemColors.Window;
            this.annualInterestTB.Location = new System.Drawing.Point(121, 319);
            this.annualInterestTB.Name = "annualInterestTB";
            this.annualInterestTB.ReadOnly = true;
            this.annualInterestTB.Size = new System.Drawing.Size(100, 20);
            this.annualInterestTB.TabIndex = 13;
            // 
            // totalInterestTB
            // 
            this.totalInterestTB.BackColor = System.Drawing.SystemColors.Window;
            this.totalInterestTB.Location = new System.Drawing.Point(121, 346);
            this.totalInterestTB.Name = "totalInterestTB";
            this.totalInterestTB.ReadOnly = true;
            this.totalInterestTB.Size = new System.Drawing.Size(100, 20);
            this.totalInterestTB.TabIndex = 14;
            // 
            // loanTotalTB
            // 
            this.loanTotalTB.BackColor = System.Drawing.SystemColors.Window;
            this.loanTotalTB.Location = new System.Drawing.Point(121, 373);
            this.loanTotalTB.Name = "loanTotalTB";
            this.loanTotalTB.ReadOnly = true;
            this.loanTotalTB.Size = new System.Drawing.Size(100, 20);
            this.loanTotalTB.TabIndex = 15;
            // 
            // annualInterestLabel
            // 
            this.annualInterestLabel.AutoSize = true;
            this.annualInterestLabel.Location = new System.Drawing.Point(18, 319);
            this.annualInterestLabel.Name = "annualInterestLabel";
            this.annualInterestLabel.Size = new System.Drawing.Size(81, 13);
            this.annualInterestLabel.TabIndex = 16;
            this.annualInterestLabel.Text = "Annual Interest:";
            // 
            // totalInterestLabel
            // 
            this.totalInterestLabel.AutoSize = true;
            this.totalInterestLabel.Location = new System.Drawing.Point(17, 346);
            this.totalInterestLabel.Name = "totalInterestLabel";
            this.totalInterestLabel.Size = new System.Drawing.Size(72, 13);
            this.totalInterestLabel.TabIndex = 17;
            this.totalInterestLabel.Text = "Total Interest:";
            // 
            // totalLoanLabel
            // 
            this.totalLoanLabel.AutoSize = true;
            this.totalLoanLabel.Location = new System.Drawing.Point(17, 373);
            this.totalLoanLabel.Name = "totalLoanLabel";
            this.totalLoanLabel.Size = new System.Drawing.Size(61, 13);
            this.totalLoanLabel.TabIndex = 18;
            this.totalLoanLabel.Text = "Total Loan:";
            // 
            // studentDiscountRTB
            // 
            this.studentDiscountRTB.BackColor = System.Drawing.SystemColors.Window;
            this.studentDiscountRTB.Location = new System.Drawing.Point(252, 319);
            this.studentDiscountRTB.Name = "studentDiscountRTB";
            this.studentDiscountRTB.ReadOnly = true;
            this.studentDiscountRTB.Size = new System.Drawing.Size(130, 74);
            this.studentDiscountRTB.TabIndex = 19;
            this.studentDiscountRTB.Text = "For students the interest rates are halved.";
            // 
            // loanAmountTB
            // 
            this.loanAmountTB.Location = new System.Drawing.Point(121, 189);
            this.loanAmountTB.Name = "loanAmountTB";
            this.loanAmountTB.Size = new System.Drawing.Size(100, 20);
            this.loanAmountTB.TabIndex = 4;
            // 
            // LoanApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 442);
            this.Controls.Add(this.studentDiscountRTB);
            this.Controls.Add(this.totalLoanLabel);
            this.Controls.Add(this.totalInterestLabel);
            this.Controls.Add(this.annualInterestLabel);
            this.Controls.Add(this.loanTotalTB);
            this.Controls.Add(this.totalInterestTB);
            this.Controls.Add(this.annualInterestTB);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.loanLengthLabel);
            this.Controls.Add(this.loanAmountLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.loanLengthNUD);
            this.Controls.Add(this.loanAmountTB);
            this.Controls.Add(this.loanTypeGB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.lastNameTB);
            this.Name = "LoanApplication";
            this.Text = "Loan Application";
            this.loanTypeGB.ResumeLayout(false);
            this.loanTypeGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanLengthNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.GroupBox loanTypeGB;
        private System.Windows.Forms.RadioButton studentRB;
        private System.Windows.Forms.RadioButton autoRB;
        private System.Windows.Forms.RadioButton homeRB;
        private System.Windows.Forms.NumericUpDown loanLengthNUD;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label loanAmountLabel;
        private System.Windows.Forms.Label loanLengthLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox annualInterestTB;
        private System.Windows.Forms.TextBox totalInterestTB;
        private System.Windows.Forms.TextBox loanTotalTB;
        private System.Windows.Forms.Label annualInterestLabel;
        private System.Windows.Forms.Label totalInterestLabel;
        private System.Windows.Forms.Label totalLoanLabel;
        private System.Windows.Forms.RichTextBox studentDiscountRTB;
        private System.Windows.Forms.TextBox loanAmountTB;
    }
}

