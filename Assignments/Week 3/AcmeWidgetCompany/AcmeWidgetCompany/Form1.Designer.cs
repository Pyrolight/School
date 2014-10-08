namespace AcmeWidgetCompany
{
    partial class acmeWidgets
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
            this.employeePayLabel = new System.Windows.Forms.Label();
            this.employeePayTB = new System.Windows.Forms.TextBox();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.avgPayLabel = new System.Windows.Forms.Label();
            this.totalPayLabel = new System.Windows.Forms.Label();
            this.totalWidetsLabel = new System.Windows.Forms.Label();
            this.noOfWidetsLabel = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.avgPayTB = new System.Windows.Forms.TextBox();
            this.totalPayTB = new System.Windows.Forms.TextBox();
            this.totalWidgetsTB = new System.Windows.Forms.TextBox();
            this.numberOfWidgetsTB = new System.Windows.Forms.TextBox();
            this.employeeNameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // employeePayLabel
            // 
            this.employeePayLabel.AutoSize = true;
            this.employeePayLabel.Location = new System.Drawing.Point(23, 81);
            this.employeePayLabel.Name = "employeePayLabel";
            this.employeePayLabel.Size = new System.Drawing.Size(77, 13);
            this.employeePayLabel.TabIndex = 31;
            this.employeePayLabel.Text = "Employee Pay:";
            // 
            // employeePayTB
            // 
            this.employeePayTB.BackColor = System.Drawing.SystemColors.Window;
            this.employeePayTB.Location = new System.Drawing.Point(213, 81);
            this.employeePayTB.Name = "employeePayTB";
            this.employeePayTB.ReadOnly = true;
            this.employeePayTB.Size = new System.Drawing.Size(100, 20);
            this.employeePayTB.TabIndex = 30;
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(254, 275);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(75, 23);
            this.clearAllButton.TabIndex = 29;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(173, 275);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 28;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // summaryButton
            // 
            this.summaryButton.Enabled = false;
            this.summaryButton.Location = new System.Drawing.Point(92, 275);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(75, 23);
            this.summaryButton.TabIndex = 27;
            this.summaryButton.Text = "Summary";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(11, 275);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 26;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // avgPayLabel
            // 
            this.avgPayLabel.AutoSize = true;
            this.avgPayLabel.Location = new System.Drawing.Point(23, 214);
            this.avgPayLabel.Name = "avgPayLabel";
            this.avgPayLabel.Size = new System.Drawing.Size(153, 13);
            this.avgPayLabel.TabIndex = 25;
            this.avgPayLabel.Text = "Average Pay for all Employees:";
            // 
            // totalPayLabel
            // 
            this.totalPayLabel.AutoSize = true;
            this.totalPayLabel.Location = new System.Drawing.Point(23, 188);
            this.totalPayLabel.Name = "totalPayLabel";
            this.totalPayLabel.Size = new System.Drawing.Size(137, 13);
            this.totalPayLabel.TabIndex = 24;
            this.totalPayLabel.Text = "Total Pay for all Employees:";
            // 
            // totalWidetsLabel
            // 
            this.totalWidetsLabel.AutoSize = true;
            this.totalWidetsLabel.Location = new System.Drawing.Point(23, 159);
            this.totalWidetsLabel.Name = "totalWidetsLabel";
            this.totalWidetsLabel.Size = new System.Drawing.Size(125, 13);
            this.totalWidetsLabel.TabIndex = 23;
            this.totalWidetsLabel.Text = "Total Widgets Produced:";
            // 
            // noOfWidetsLabel
            // 
            this.noOfWidetsLabel.AutoSize = true;
            this.noOfWidetsLabel.Location = new System.Drawing.Point(23, 55);
            this.noOfWidetsLabel.Name = "noOfWidetsLabel";
            this.noOfWidetsLabel.Size = new System.Drawing.Size(95, 13);
            this.noOfWidetsLabel.TabIndex = 22;
            this.noOfWidetsLabel.Text = "Number of Widets:";
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(23, 29);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(87, 13);
            this.employeeNameLabel.TabIndex = 21;
            this.employeeNameLabel.Text = "Employee Name:";
            // 
            // avgPayTB
            // 
            this.avgPayTB.BackColor = System.Drawing.SystemColors.Window;
            this.avgPayTB.Location = new System.Drawing.Point(213, 214);
            this.avgPayTB.Name = "avgPayTB";
            this.avgPayTB.ReadOnly = true;
            this.avgPayTB.Size = new System.Drawing.Size(100, 20);
            this.avgPayTB.TabIndex = 20;
            // 
            // totalPayTB
            // 
            this.totalPayTB.BackColor = System.Drawing.SystemColors.Window;
            this.totalPayTB.Location = new System.Drawing.Point(213, 188);
            this.totalPayTB.Name = "totalPayTB";
            this.totalPayTB.ReadOnly = true;
            this.totalPayTB.Size = new System.Drawing.Size(100, 20);
            this.totalPayTB.TabIndex = 19;
            // 
            // totalWidgetsTB
            // 
            this.totalWidgetsTB.BackColor = System.Drawing.SystemColors.Window;
            this.totalWidgetsTB.Location = new System.Drawing.Point(213, 159);
            this.totalWidgetsTB.Name = "totalWidgetsTB";
            this.totalWidgetsTB.ReadOnly = true;
            this.totalWidgetsTB.Size = new System.Drawing.Size(100, 20);
            this.totalWidgetsTB.TabIndex = 18;
            // 
            // numberOfWidgetsTB
            // 
            this.numberOfWidgetsTB.Location = new System.Drawing.Point(213, 55);
            this.numberOfWidgetsTB.Name = "numberOfWidgetsTB";
            this.numberOfWidgetsTB.Size = new System.Drawing.Size(100, 20);
            this.numberOfWidgetsTB.TabIndex = 17;
            // 
            // employeeNameTB
            // 
            this.employeeNameTB.Location = new System.Drawing.Point(213, 29);
            this.employeeNameTB.Name = "employeeNameTB";
            this.employeeNameTB.Size = new System.Drawing.Size(100, 20);
            this.employeeNameTB.TabIndex = 16;
            // 
            // acmeWidgets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 340);
            this.Controls.Add(this.employeePayLabel);
            this.Controls.Add(this.employeePayTB);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.avgPayLabel);
            this.Controls.Add(this.totalPayLabel);
            this.Controls.Add(this.totalWidetsLabel);
            this.Controls.Add(this.noOfWidetsLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.avgPayTB);
            this.Controls.Add(this.totalPayTB);
            this.Controls.Add(this.totalWidgetsTB);
            this.Controls.Add(this.numberOfWidgetsTB);
            this.Controls.Add(this.employeeNameTB);
            this.Name = "acmeWidgets";
            this.Text = "Acme Widgets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeePayLabel;
        private System.Windows.Forms.TextBox employeePayTB;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label avgPayLabel;
        private System.Windows.Forms.Label totalPayLabel;
        private System.Windows.Forms.Label totalWidetsLabel;
        private System.Windows.Forms.Label noOfWidetsLabel;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.TextBox avgPayTB;
        private System.Windows.Forms.TextBox totalPayTB;
        private System.Windows.Forms.TextBox totalWidgetsTB;
        private System.Windows.Forms.TextBox numberOfWidgetsTB;
        private System.Windows.Forms.TextBox employeeNameTB;
    }
}

