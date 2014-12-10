namespace HatsRUs
{
    partial class CompletedOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompletedOrder));
            this.customerInfoGB = new System.Windows.Forms.GroupBox();
            this.customerInfoRTB = new System.Windows.Forms.RichTextBox();
            this.totalGB = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.shippingLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.totalTB = new System.Windows.Forms.TextBox();
            this.shippingTB = new System.Windows.Forms.TextBox();
            this.subtotalTB = new System.Windows.Forms.TextBox();
            this.orderInfoRTB = new System.Windows.Forms.RichTextBox();
            this.printOrder = new System.Windows.Forms.Button();
            this.orderInformationGB = new System.Windows.Forms.GroupBox();
            this.orderPrint = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.closeFormButton = new System.Windows.Forms.Button();
            this.customerInfoGB.SuspendLayout();
            this.totalGB.SuspendLayout();
            this.orderInformationGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerInfoGB
            // 
            this.customerInfoGB.Controls.Add(this.customerInfoRTB);
            this.customerInfoGB.Location = new System.Drawing.Point(26, 42);
            this.customerInfoGB.Name = "customerInfoGB";
            this.customerInfoGB.Size = new System.Drawing.Size(211, 128);
            this.customerInfoGB.TabIndex = 6;
            this.customerInfoGB.TabStop = false;
            this.customerInfoGB.Text = "Customer Informaiton";
            // 
            // customerInfoRTB
            // 
            this.customerInfoRTB.Location = new System.Drawing.Point(9, 19);
            this.customerInfoRTB.Name = "customerInfoRTB";
            this.customerInfoRTB.Size = new System.Drawing.Size(189, 96);
            this.customerInfoRTB.TabIndex = 13;
            this.customerInfoRTB.Text = "";
            // 
            // totalGB
            // 
            this.totalGB.Controls.Add(this.totalLabel);
            this.totalGB.Controls.Add(this.shippingLabel);
            this.totalGB.Controls.Add(this.subTotalLabel);
            this.totalGB.Controls.Add(this.totalTB);
            this.totalGB.Controls.Add(this.shippingTB);
            this.totalGB.Controls.Add(this.subtotalTB);
            this.totalGB.Location = new System.Drawing.Point(26, 189);
            this.totalGB.Name = "totalGB";
            this.totalGB.Size = new System.Drawing.Size(267, 100);
            this.totalGB.TabIndex = 10;
            this.totalGB.TabStop = false;
            this.totalGB.Text = "Total";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(40, 72);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 15;
            this.totalLabel.Text = "Total";
            // 
            // shippingLabel
            // 
            this.shippingLabel.AutoSize = true;
            this.shippingLabel.Location = new System.Drawing.Point(40, 48);
            this.shippingLabel.Name = "shippingLabel";
            this.shippingLabel.Size = new System.Drawing.Size(48, 13);
            this.shippingLabel.TabIndex = 14;
            this.shippingLabel.Text = "Shipping";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Location = new System.Drawing.Point(40, 25);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(46, 13);
            this.subTotalLabel.TabIndex = 13;
            this.subTotalLabel.Text = "Subtotal";
            // 
            // totalTB
            // 
            this.totalTB.Location = new System.Drawing.Point(140, 72);
            this.totalTB.Name = "totalTB";
            this.totalTB.Size = new System.Drawing.Size(100, 20);
            this.totalTB.TabIndex = 12;
            // 
            // shippingTB
            // 
            this.shippingTB.Location = new System.Drawing.Point(140, 45);
            this.shippingTB.Name = "shippingTB";
            this.shippingTB.Size = new System.Drawing.Size(100, 20);
            this.shippingTB.TabIndex = 11;
            // 
            // subtotalTB
            // 
            this.subtotalTB.Location = new System.Drawing.Point(140, 19);
            this.subtotalTB.Name = "subtotalTB";
            this.subtotalTB.Size = new System.Drawing.Size(100, 20);
            this.subtotalTB.TabIndex = 10;
            // 
            // orderInfoRTB
            // 
            this.orderInfoRTB.Location = new System.Drawing.Point(36, 19);
            this.orderInfoRTB.Name = "orderInfoRTB";
            this.orderInfoRTB.Size = new System.Drawing.Size(148, 96);
            this.orderInfoRTB.TabIndex = 11;
            this.orderInfoRTB.Text = "";
            // 
            // printOrder
            // 
            this.printOrder.Location = new System.Drawing.Point(344, 266);
            this.printOrder.Name = "printOrder";
            this.printOrder.Size = new System.Drawing.Size(75, 23);
            this.printOrder.TabIndex = 13;
            this.printOrder.Text = "Print Order";
            this.printOrder.UseVisualStyleBackColor = true;
            this.printOrder.Click += new System.EventHandler(this.printOrder_Click);
            // 
            // orderInformationGB
            // 
            this.orderInformationGB.Controls.Add(this.orderInfoRTB);
            this.orderInformationGB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.orderInformationGB.Location = new System.Drawing.Point(278, 42);
            this.orderInformationGB.Name = "orderInformationGB";
            this.orderInformationGB.Size = new System.Drawing.Size(206, 128);
            this.orderInformationGB.TabIndex = 14;
            this.orderInformationGB.TabStop = false;
            this.orderInformationGB.Text = "Order Information";
            // 
            // orderPrint
            // 
            this.orderPrint.DocumentName = "document";
            this.orderPrint.Form = this;
            this.orderPrint.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            this.orderPrint.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("orderPrint.PrinterSettings")));
            this.orderPrint.PrintFileName = null;
            // 
            // closeFormButton
            // 
            this.closeFormButton.Location = new System.Drawing.Point(425, 266);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(75, 23);
            this.closeFormButton.TabIndex = 15;
            this.closeFormButton.Text = "Exit";
            this.closeFormButton.UseVisualStyleBackColor = true;
            this.closeFormButton.Click += new System.EventHandler(this.closeFormButton_Click);
            // 
            // CompletedOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 324);
            this.Controls.Add(this.closeFormButton);
            this.Controls.Add(this.orderInformationGB);
            this.Controls.Add(this.printOrder);
            this.Controls.Add(this.totalGB);
            this.Controls.Add(this.customerInfoGB);
            this.Name = "CompletedOrder";
            this.Text = "Completed Order";
            this.customerInfoGB.ResumeLayout(false);
            this.totalGB.ResumeLayout(false);
            this.totalGB.PerformLayout();
            this.orderInformationGB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox customerInfoGB;
        private System.Windows.Forms.GroupBox totalGB;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label shippingLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.TextBox totalTB;
        private System.Windows.Forms.TextBox shippingTB;
        private System.Windows.Forms.TextBox subtotalTB;
        private System.Windows.Forms.RichTextBox orderInfoRTB;
        private System.Windows.Forms.RichTextBox customerInfoRTB;
        private System.Windows.Forms.Button printOrder;
        private System.Windows.Forms.GroupBox orderInformationGB;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm orderPrint;
        private System.Windows.Forms.Button closeFormButton;

    }
}