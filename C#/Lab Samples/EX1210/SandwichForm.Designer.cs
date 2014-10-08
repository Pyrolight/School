namespace EX1210
{
    partial class SandwichForm
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
            this.Label5 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.condimentsTextBox = new System.Windows.Forms.TextBox();
            this.breadTextBox = new System.Windows.Forms.TextBox();
            this.cheeseTextBox = new System.Windows.Forms.TextBox();
            this.meatTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(374, 75);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(100, 16);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "Bread:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(377, 221);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(88, 23);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "E&xit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(266, 192);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 23);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "&Add Sandwich";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(266, 221);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(88, 23);
            this.displayButton.TabIndex = 12;
            this.displayButton.Text = "&Display";
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(498, 72);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(72, 16);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "Condiments:";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(254, 75);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 16);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Cheese:";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(134, 75);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 16);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Meat:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(14, 75);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Name:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(150, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(200, 24);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Create Your Sandwich";
            // 
            // condimentsTextBox
            // 
            this.condimentsTextBox.Location = new System.Drawing.Point(501, 91);
            this.condimentsTextBox.Multiline = true;
            this.condimentsTextBox.Name = "condimentsTextBox";
            this.condimentsTextBox.Size = new System.Drawing.Size(112, 48);
            this.condimentsTextBox.TabIndex = 10;
            // 
            // breadTextBox
            // 
            this.breadTextBox.Location = new System.Drawing.Point(374, 91);
            this.breadTextBox.Name = "breadTextBox";
            this.breadTextBox.Size = new System.Drawing.Size(100, 20);
            this.breadTextBox.TabIndex = 8;
            // 
            // cheeseTextBox
            // 
            this.cheeseTextBox.Location = new System.Drawing.Point(254, 91);
            this.cheeseTextBox.Name = "cheeseTextBox";
            this.cheeseTextBox.Size = new System.Drawing.Size(100, 20);
            this.cheeseTextBox.TabIndex = 6;
            // 
            // meatTextBox
            // 
            this.meatTextBox.Location = new System.Drawing.Point(134, 91);
            this.meatTextBox.Name = "meatTextBox";
            this.meatTextBox.Size = new System.Drawing.Size(100, 20);
            this.meatTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(14, 91);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(377, 192);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(88, 23);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "&Clear";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(599, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 62);
            this.label7.TabIndex = 15;
            this.label7.Text = "(To add more items, press Enter after each item)";
            // 
            // SandwichForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 292);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.condimentsTextBox);
            this.Controls.Add(this.breadTextBox);
            this.Controls.Add(this.cheeseTextBox);
            this.Controls.Add(this.meatTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SandwichForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create a Sandwich";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button exitButton;
        internal System.Windows.Forms.Button addButton;
        internal System.Windows.Forms.Button displayButton;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox condimentsTextBox;
        internal System.Windows.Forms.TextBox breadTextBox;
        internal System.Windows.Forms.TextBox cheeseTextBox;
        internal System.Windows.Forms.TextBox meatTextBox;
        internal System.Windows.Forms.TextBox nameTextBox;
        internal System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label7;
    }
}

