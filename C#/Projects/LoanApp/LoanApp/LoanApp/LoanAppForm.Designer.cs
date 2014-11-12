namespace LoanApp
{
    partial class LoanAppForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmboTypeOfLoan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxLoanAmt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblAutoHeading = new System.Windows.Forms.Label();
            this.lbAutolMake = new System.Windows.Forms.Label();
            this.lblAutoModel = new System.Windows.Forms.Label();
            this.lblAutoYear = new System.Windows.Forms.Label();
            this.lblAutoColor = new System.Windows.Forms.Label();
            this.txtBxAutoMake = new System.Windows.Forms.TextBox();
            this.txtBxAutoModel = new System.Windows.Forms.TextBox();
            this.txtBxAutoYear = new System.Windows.Forms.TextBox();
            this.txtBxAutoColor = new System.Windows.Forms.TextBox();
            this.txtBxHomeYrBuilt = new System.Windows.Forms.TextBox();
            this.txtBxHomeSqFt = new System.Windows.Forms.TextBox();
            this.txtBxHomeAddress = new System.Windows.Forms.TextBox();
            this.lblHomeYearBuilt = new System.Windows.Forms.Label();
            this.lblHomeSqFt = new System.Windows.Forms.Label();
            this.lblHomeAddress = new System.Windows.Forms.Label();
            this.lblHouseHeading = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Kiosk - Apply for a loan today!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // cmboTypeOfLoan
            // 
            this.cmboTypeOfLoan.FormattingEnabled = true;
            this.cmboTypeOfLoan.Items.AddRange(new object[] {
            "",
            "Auto",
            "Home"});
            this.cmboTypeOfLoan.Location = new System.Drawing.Point(280, 78);
            this.cmboTypeOfLoan.Name = "cmboTypeOfLoan";
            this.cmboTypeOfLoan.Size = new System.Drawing.Size(121, 26);
            this.cmboTypeOfLoan.TabIndex = 3;
            this.cmboTypeOfLoan.SelectedIndexChanged += new System.EventHandler(this.cmboTypeOfLoan_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type of Loan";
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(103, 40);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(125, 24);
            this.txtBxFirstName.TabIndex = 5;
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(102, 68);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(126, 24);
            this.txtBxLastName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Interest Rate:";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestRate.Location = new System.Drawing.Point(116, 146);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(0, 18);
            this.lblInterestRate.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Loan Amount:";
            // 
            // txtBxLoanAmt
            // 
            this.txtBxLoanAmt.Location = new System.Drawing.Point(120, 98);
            this.txtBxLoanAmt.Name = "txtBxLoanAmt";
            this.txtBxLoanAmt.Size = new System.Drawing.Size(100, 24);
            this.txtBxLoanAmt.TabIndex = 10;
            this.txtBxLoanAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Number of Years:";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYears.Location = new System.Drawing.Point(315, 146);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(0, 18);
            this.lblYears.TabIndex = 12;
            // 
            // lblAutoHeading
            // 
            this.lblAutoHeading.AutoSize = true;
            this.lblAutoHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoHeading.Location = new System.Drawing.Point(35, 183);
            this.lblAutoHeading.Name = "lblAutoHeading";
            this.lblAutoHeading.Size = new System.Drawing.Size(92, 18);
            this.lblAutoHeading.TabIndex = 13;
            this.lblAutoHeading.Text = "Car Details";
            this.lblAutoHeading.Visible = false;
            // 
            // lbAutolMake
            // 
            this.lbAutolMake.AutoSize = true;
            this.lbAutolMake.Location = new System.Drawing.Point(2, 207);
            this.lbAutolMake.Name = "lbAutolMake";
            this.lbAutolMake.Size = new System.Drawing.Size(49, 18);
            this.lbAutolMake.TabIndex = 14;
            this.lbAutolMake.Text = "Make:";
            this.lbAutolMake.Visible = false;
            // 
            // lblAutoModel
            // 
            this.lblAutoModel.AutoSize = true;
            this.lblAutoModel.Location = new System.Drawing.Point(4, 232);
            this.lblAutoModel.Name = "lblAutoModel";
            this.lblAutoModel.Size = new System.Drawing.Size(53, 18);
            this.lblAutoModel.TabIndex = 15;
            this.lblAutoModel.Text = "Model:";
            this.lblAutoModel.Visible = false;
            // 
            // lblAutoYear
            // 
            this.lblAutoYear.AutoSize = true;
            this.lblAutoYear.Location = new System.Drawing.Point(4, 257);
            this.lblAutoYear.Name = "lblAutoYear";
            this.lblAutoYear.Size = new System.Drawing.Size(42, 18);
            this.lblAutoYear.TabIndex = 16;
            this.lblAutoYear.Text = "Year:";
            this.lblAutoYear.Visible = false;
            // 
            // lblAutoColor
            // 
            this.lblAutoColor.AutoSize = true;
            this.lblAutoColor.Location = new System.Drawing.Point(4, 279);
            this.lblAutoColor.Name = "lblAutoColor";
            this.lblAutoColor.Size = new System.Drawing.Size(49, 18);
            this.lblAutoColor.TabIndex = 17;
            this.lblAutoColor.Text = "Color:";
            this.lblAutoColor.Visible = false;
            // 
            // txtBxAutoMake
            // 
            this.txtBxAutoMake.Location = new System.Drawing.Point(58, 204);
            this.txtBxAutoMake.Name = "txtBxAutoMake";
            this.txtBxAutoMake.Size = new System.Drawing.Size(100, 24);
            this.txtBxAutoMake.TabIndex = 18;
            this.txtBxAutoMake.Visible = false;
            // 
            // txtBxAutoModel
            // 
            this.txtBxAutoModel.Location = new System.Drawing.Point(58, 229);
            this.txtBxAutoModel.Name = "txtBxAutoModel";
            this.txtBxAutoModel.Size = new System.Drawing.Size(100, 24);
            this.txtBxAutoModel.TabIndex = 19;
            this.txtBxAutoModel.Visible = false;
            // 
            // txtBxAutoYear
            // 
            this.txtBxAutoYear.Location = new System.Drawing.Point(58, 254);
            this.txtBxAutoYear.Name = "txtBxAutoYear";
            this.txtBxAutoYear.Size = new System.Drawing.Size(50, 24);
            this.txtBxAutoYear.TabIndex = 20;
            this.txtBxAutoYear.Visible = false;
            // 
            // txtBxAutoColor
            // 
            this.txtBxAutoColor.Location = new System.Drawing.Point(58, 280);
            this.txtBxAutoColor.Name = "txtBxAutoColor";
            this.txtBxAutoColor.Size = new System.Drawing.Size(100, 24);
            this.txtBxAutoColor.TabIndex = 21;
            this.txtBxAutoColor.Visible = false;
            // 
            // txtBxHomeYrBuilt
            // 
            this.txtBxHomeYrBuilt.Location = new System.Drawing.Point(247, 259);
            this.txtBxHomeYrBuilt.Name = "txtBxHomeYrBuilt";
            this.txtBxHomeYrBuilt.Size = new System.Drawing.Size(60, 24);
            this.txtBxHomeYrBuilt.TabIndex = 29;
            this.txtBxHomeYrBuilt.Visible = false;
            // 
            // txtBxHomeSqFt
            // 
            this.txtBxHomeSqFt.Location = new System.Drawing.Point(247, 233);
            this.txtBxHomeSqFt.Name = "txtBxHomeSqFt";
            this.txtBxHomeSqFt.Size = new System.Drawing.Size(48, 24);
            this.txtBxHomeSqFt.TabIndex = 28;
            this.txtBxHomeSqFt.Visible = false;
            // 
            // txtBxHomeAddress
            // 
            this.txtBxHomeAddress.Location = new System.Drawing.Point(247, 207);
            this.txtBxHomeAddress.Name = "txtBxHomeAddress";
            this.txtBxHomeAddress.Size = new System.Drawing.Size(176, 24);
            this.txtBxHomeAddress.TabIndex = 27;
            this.txtBxHomeAddress.Visible = false;
            // 
            // lblHomeYearBuilt
            // 
            this.lblHomeYearBuilt.AutoSize = true;
            this.lblHomeYearBuilt.Location = new System.Drawing.Point(172, 259);
            this.lblHomeYearBuilt.Name = "lblHomeYearBuilt";
            this.lblHomeYearBuilt.Size = new System.Drawing.Size(74, 18);
            this.lblHomeYearBuilt.TabIndex = 25;
            this.lblHomeYearBuilt.Text = "Year Built:";
            this.lblHomeYearBuilt.Visible = false;
            // 
            // lblHomeSqFt
            // 
            this.lblHomeSqFt.AutoSize = true;
            this.lblHomeSqFt.Location = new System.Drawing.Point(172, 234);
            this.lblHomeSqFt.Name = "lblHomeSqFt";
            this.lblHomeSqFt.Size = new System.Drawing.Size(67, 18);
            this.lblHomeSqFt.TabIndex = 24;
            this.lblHomeSqFt.Text = "Sq. Feet:";
            this.lblHomeSqFt.Visible = false;
            // 
            // lblHomeAddress
            // 
            this.lblHomeAddress.AutoSize = true;
            this.lblHomeAddress.Location = new System.Drawing.Point(170, 209);
            this.lblHomeAddress.Name = "lblHomeAddress";
            this.lblHomeAddress.Size = new System.Drawing.Size(62, 18);
            this.lblHomeAddress.TabIndex = 23;
            this.lblHomeAddress.Text = "Address";
            this.lblHomeAddress.Visible = false;
            // 
            // lblHouseHeading
            // 
            this.lblHouseHeading.AutoSize = true;
            this.lblHouseHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseHeading.Location = new System.Drawing.Point(203, 185);
            this.lblHouseHeading.Name = "lblHouseHeading";
            this.lblHouseHeading.Size = new System.Drawing.Size(110, 18);
            this.lblHouseHeading.TabIndex = 22;
            this.lblHouseHeading.Text = "Home Details";
            this.lblHouseHeading.Visible = false;
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(273, 293);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(128, 58);
            this.btnProcess.TabIndex = 30;
            this.btnProcess.Text = "Process Request";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.White;
            this.lblErrorMsg.Location = new System.Drawing.Point(13, 325);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 24);
            this.lblErrorMsg.TabIndex = 31;
            // 
            // LoanAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(426, 363);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtBxHomeYrBuilt);
            this.Controls.Add(this.txtBxHomeSqFt);
            this.Controls.Add(this.txtBxHomeAddress);
            this.Controls.Add(this.lblHomeYearBuilt);
            this.Controls.Add(this.lblHomeSqFt);
            this.Controls.Add(this.lblHomeAddress);
            this.Controls.Add(this.lblHouseHeading);
            this.Controls.Add(this.txtBxAutoColor);
            this.Controls.Add(this.txtBxAutoYear);
            this.Controls.Add(this.txtBxAutoModel);
            this.Controls.Add(this.txtBxAutoMake);
            this.Controls.Add(this.lblAutoColor);
            this.Controls.Add(this.lblAutoYear);
            this.Controls.Add(this.lblAutoModel);
            this.Controls.Add(this.lbAutolMake);
            this.Controls.Add(this.lblAutoHeading);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBxLoanAmt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmboTypeOfLoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Thistle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoanAppForm";
            this.Text = "EZ Loan Processing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmboTypeOfLoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBxLoanAmt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblAutoHeading;
        private System.Windows.Forms.Label lbAutolMake;
        private System.Windows.Forms.Label lblAutoModel;
        private System.Windows.Forms.Label lblAutoYear;
        private System.Windows.Forms.Label lblAutoColor;
        private System.Windows.Forms.TextBox txtBxAutoMake;
        private System.Windows.Forms.TextBox txtBxAutoModel;
        private System.Windows.Forms.TextBox txtBxAutoYear;
        private System.Windows.Forms.TextBox txtBxAutoColor;
        private System.Windows.Forms.TextBox txtBxHomeYrBuilt;
        private System.Windows.Forms.TextBox txtBxHomeSqFt;
        private System.Windows.Forms.TextBox txtBxHomeAddress;
        private System.Windows.Forms.Label lblHomeYearBuilt;
        private System.Windows.Forms.Label lblHomeSqFt;
        private System.Windows.Forms.Label lblHomeAddress;
        private System.Windows.Forms.Label lblHouseHeading;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}

