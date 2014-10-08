namespace InternetMerchandiseProvider
{
    partial class InternetShippingForm
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.NumberOfItemsTextBox = new System.Windows.Forms.TextBox();
            this.TotalShippingCostTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.NumberOfItemsLabel = new System.Windows.Forms.Label();
            this.NumberOfItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalShippingCostGroupBox = new System.Windows.Forms.GroupBox();
            this.ShippingCostLabel = new System.Windows.Forms.Label();
            this.NumberOfItemsGroupBox.SuspendLayout();
            this.TotalShippingCostGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(273, 176);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // NumberOfItemsTextBox
            // 
            this.NumberOfItemsTextBox.Location = new System.Drawing.Point(182, 27);
            this.NumberOfItemsTextBox.Name = "NumberOfItemsTextBox";
            this.NumberOfItemsTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberOfItemsTextBox.TabIndex = 1;
            this.NumberOfItemsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalShippingCostTextBox
            // 
            this.TotalShippingCostTextBox.Location = new System.Drawing.Point(182, 29);
            this.TotalShippingCostTextBox.Name = "TotalShippingCostTextBox";
            this.TotalShippingCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalShippingCostTextBox.TabIndex = 2;
            this.TotalShippingCostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(192, 176);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(111, 176);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NumberOfItemsLabel
            // 
            this.NumberOfItemsLabel.AutoSize = true;
            this.NumberOfItemsLabel.Location = new System.Drawing.Point(19, 23);
            this.NumberOfItemsLabel.Name = "NumberOfItemsLabel";
            this.NumberOfItemsLabel.Size = new System.Drawing.Size(130, 26);
            this.NumberOfItemsLabel.TabIndex = 5;
            this.NumberOfItemsLabel.Text = "Enter the number of items \r\nyou wish to purchase:\r\n";
            this.NumberOfItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberOfItemsGroupBox
            // 
            this.NumberOfItemsGroupBox.Controls.Add(this.NumberOfItemsTextBox);
            this.NumberOfItemsGroupBox.Controls.Add(this.NumberOfItemsLabel);
            this.NumberOfItemsGroupBox.Location = new System.Drawing.Point(59, 12);
            this.NumberOfItemsGroupBox.Name = "NumberOfItemsGroupBox";
            this.NumberOfItemsGroupBox.Size = new System.Drawing.Size(289, 64);
            this.NumberOfItemsGroupBox.TabIndex = 6;
            this.NumberOfItemsGroupBox.TabStop = false;
            // 
            // TotalShippingCostGroupBox
            // 
            this.TotalShippingCostGroupBox.Controls.Add(this.ShippingCostLabel);
            this.TotalShippingCostGroupBox.Controls.Add(this.TotalShippingCostTextBox);
            this.TotalShippingCostGroupBox.Location = new System.Drawing.Point(59, 82);
            this.TotalShippingCostGroupBox.Name = "TotalShippingCostGroupBox";
            this.TotalShippingCostGroupBox.Size = new System.Drawing.Size(289, 67);
            this.TotalShippingCostGroupBox.TabIndex = 7;
            this.TotalShippingCostGroupBox.TabStop = false;
            // 
            // ShippingCostLabel
            // 
            this.ShippingCostLabel.AutoSize = true;
            this.ShippingCostLabel.Location = new System.Drawing.Point(19, 32);
            this.ShippingCostLabel.Name = "ShippingCostLabel";
            this.ShippingCostLabel.Size = new System.Drawing.Size(120, 13);
            this.ShippingCostLabel.TabIndex = 3;
            this.ShippingCostLabel.Text = "Total Shipping Charges:";
            // 
            // InternetShippingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 272);
            this.Controls.Add(this.TotalShippingCostGroupBox);
            this.Controls.Add(this.NumberOfItemsGroupBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Name = "InternetShippingForm";
            this.Text = "Internet Shipping Form";
            this.NumberOfItemsGroupBox.ResumeLayout(false);
            this.NumberOfItemsGroupBox.PerformLayout();
            this.TotalShippingCostGroupBox.ResumeLayout(false);
            this.TotalShippingCostGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox NumberOfItemsTextBox;
        private System.Windows.Forms.TextBox TotalShippingCostTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label NumberOfItemsLabel;
        private System.Windows.Forms.GroupBox NumberOfItemsGroupBox;
        private System.Windows.Forms.GroupBox TotalShippingCostGroupBox;
        private System.Windows.Forms.Label ShippingCostLabel;
    }
}

