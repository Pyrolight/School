namespace PizzaInAMinute
{
    partial class OrderSummaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderSummaryForm));
            this.pizzaTB = new System.Windows.Forms.TextBox();
            this.toppingsTB = new System.Windows.Forms.TextBox();
            this.toppingsLabel = new System.Windows.Forms.Label();
            this.pizzaLable = new System.Windows.Forms.Label();
            this.customerTB = new System.Windows.Forms.TextBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.drinksTB = new System.Windows.Forms.TextBox();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.extrasTB = new System.Windows.Forms.TextBox();
            this.extrasLabel = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.PictureBox();
            this.orderSummaryLabel = new System.Windows.Forms.Label();
            this.printOrderButton = new System.Windows.Forms.Button();
            this.printSummary = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            this.SuspendLayout();
            // 
            // pizzaTB
            // 
            this.pizzaTB.BackColor = System.Drawing.SystemColors.Window;
            this.pizzaTB.Location = new System.Drawing.Point(15, 203);
            this.pizzaTB.Name = "pizzaTB";
            this.pizzaTB.ReadOnly = true;
            this.pizzaTB.Size = new System.Drawing.Size(343, 20);
            this.pizzaTB.TabIndex = 0;
            // 
            // toppingsTB
            // 
            this.toppingsTB.BackColor = System.Drawing.SystemColors.Window;
            this.toppingsTB.Location = new System.Drawing.Point(15, 266);
            this.toppingsTB.Multiline = true;
            this.toppingsTB.Name = "toppingsTB";
            this.toppingsTB.ReadOnly = true;
            this.toppingsTB.Size = new System.Drawing.Size(121, 175);
            this.toppingsTB.TabIndex = 1;
            // 
            // toppingsLabel
            // 
            this.toppingsLabel.AutoSize = true;
            this.toppingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingsLabel.Location = new System.Drawing.Point(12, 245);
            this.toppingsLabel.Name = "toppingsLabel";
            this.toppingsLabel.Size = new System.Drawing.Size(51, 13);
            this.toppingsLabel.TabIndex = 2;
            this.toppingsLabel.Text = "Toppings";
            // 
            // pizzaLable
            // 
            this.pizzaLable.AutoSize = true;
            this.pizzaLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaLable.Location = new System.Drawing.Point(14, 182);
            this.pizzaLable.Name = "pizzaLable";
            this.pizzaLable.Size = new System.Drawing.Size(32, 13);
            this.pizzaLable.TabIndex = 3;
            this.pizzaLable.Text = "Pizza";
            // 
            // customerTB
            // 
            this.customerTB.BackColor = System.Drawing.SystemColors.Window;
            this.customerTB.Location = new System.Drawing.Point(390, 203);
            this.customerTB.Multiline = true;
            this.customerTB.Name = "customerTB";
            this.customerTB.ReadOnly = true;
            this.customerTB.Size = new System.Drawing.Size(190, 60);
            this.customerTB.TabIndex = 4;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(387, 182);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(72, 13);
            this.customerLabel.TabIndex = 5;
            this.customerLabel.Text = "Customer Info";
            // 
            // drinksTB
            // 
            this.drinksTB.BackColor = System.Drawing.SystemColors.Window;
            this.drinksTB.Location = new System.Drawing.Point(170, 386);
            this.drinksTB.Multiline = true;
            this.drinksTB.Name = "drinksTB";
            this.drinksTB.ReadOnly = true;
            this.drinksTB.Size = new System.Drawing.Size(121, 45);
            this.drinksTB.TabIndex = 6;
            // 
            // drinksLabel
            // 
            this.drinksLabel.AutoSize = true;
            this.drinksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksLabel.Location = new System.Drawing.Point(167, 365);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(37, 13);
            this.drinksLabel.TabIndex = 7;
            this.drinksLabel.Text = "Drinks";
            // 
            // extrasTB
            // 
            this.extrasTB.BackColor = System.Drawing.SystemColors.Window;
            this.extrasTB.Location = new System.Drawing.Point(170, 266);
            this.extrasTB.Multiline = true;
            this.extrasTB.Name = "extrasTB";
            this.extrasTB.ReadOnly = true;
            this.extrasTB.Size = new System.Drawing.Size(121, 85);
            this.extrasTB.TabIndex = 8;
            // 
            // extrasLabel
            // 
            this.extrasLabel.AutoSize = true;
            this.extrasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extrasLabel.Location = new System.Drawing.Point(170, 245);
            this.extrasLabel.Name = "extrasLabel";
            this.extrasLabel.Size = new System.Drawing.Size(36, 13);
            this.extrasLabel.TabIndex = 9;
            this.extrasLabel.Text = "Extras";
            // 
            // header
            // 
            this.header.Image = ((System.Drawing.Image)(resources.GetObject("header.Image")));
            this.header.Location = new System.Drawing.Point(12, 12);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(576, 96);
            this.header.TabIndex = 61;
            this.header.TabStop = false;
            // 
            // orderSummaryLabel
            // 
            this.orderSummaryLabel.AutoSize = true;
            this.orderSummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderSummaryLabel.Location = new System.Drawing.Point(12, 143);
            this.orderSummaryLabel.Name = "orderSummaryLabel";
            this.orderSummaryLabel.Size = new System.Drawing.Size(162, 25);
            this.orderSummaryLabel.TabIndex = 62;
            this.orderSummaryLabel.Text = "Order Summary";
            // 
            // printOrderButton
            // 
            this.printOrderButton.Location = new System.Drawing.Point(390, 422);
            this.printOrderButton.Name = "printOrderButton";
            this.printOrderButton.Size = new System.Drawing.Size(75, 23);
            this.printOrderButton.TabIndex = 63;
            this.printOrderButton.Text = "Print Order";
            this.printOrderButton.UseVisualStyleBackColor = true;
            this.printOrderButton.Click += new System.EventHandler(this.printOrderButton_Click);
            // 
            // printSummary
            // 
            this.printSummary.DocumentName = "document";
            this.printSummary.Form = this;
            this.printSummary.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            this.printSummary.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printSummary.PrinterSettings")));
            this.printSummary.PrintFileName = null;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(471, 422);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 64;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(387, 365);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 65;
            this.totalLabel.Text = "Total";
            // 
            // totalTB
            // 
            this.totalTB.BackColor = System.Drawing.SystemColors.Window;
            this.totalTB.Location = new System.Drawing.Point(389, 386);
            this.totalTB.Name = "totalTB";
            this.totalTB.ReadOnly = true;
            this.totalTB.Size = new System.Drawing.Size(100, 20);
            this.totalTB.TabIndex = 66;
            // 
            // OrderSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 457);
            this.Controls.Add(this.totalTB);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.printOrderButton);
            this.Controls.Add(this.orderSummaryLabel);
            this.Controls.Add(this.header);
            this.Controls.Add(this.extrasLabel);
            this.Controls.Add(this.extrasTB);
            this.Controls.Add(this.drinksLabel);
            this.Controls.Add(this.drinksTB);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.customerTB);
            this.Controls.Add(this.pizzaLable);
            this.Controls.Add(this.toppingsLabel);
            this.Controls.Add(this.toppingsTB);
            this.Controls.Add(this.pizzaTB);
            this.Name = "OrderSummaryForm";
            this.Text = "Order Summary";
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pizzaTB;
        private System.Windows.Forms.TextBox toppingsTB;
        private System.Windows.Forms.Label toppingsLabel;
        private System.Windows.Forms.Label pizzaLable;
        private System.Windows.Forms.TextBox customerTB;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox drinksTB;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.TextBox extrasTB;
        private System.Windows.Forms.Label extrasLabel;
        private System.Windows.Forms.PictureBox header;
        private System.Windows.Forms.Label orderSummaryLabel;
        private System.Windows.Forms.Button printOrderButton;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printSummary;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox totalTB;
        private System.Windows.Forms.Label totalLabel;

    }
}