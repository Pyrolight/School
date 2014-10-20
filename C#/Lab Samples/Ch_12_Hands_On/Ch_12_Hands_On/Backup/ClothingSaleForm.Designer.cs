namespace Ch12HandsOn
{
    partial class ClothingSaleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productIdComboBox = new System.Windows.Forms.ComboBox();
            this.discountCheckBox = new System.Windows.Forms.CheckBox();
            this.discountRateLabel = new System.Windows.Forms.Label();
            this.discountRateTextBox = new System.Windows.Forms.TextBox();
            this.membercheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.extendedPriceTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Product ID:";
            this.toolTip1.SetToolTip(this.label1, "roduct ID from the catalog.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Quantity:";
            this.toolTip1.SetToolTip(this.label2, "Enter a whole number.");
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(211, 147);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.quantityTextBox, "Enter a whole number.");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.summaryToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.calculateToolStripMenuItem.Text = "&Calculate Sale";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateSaleToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearToolStripMenuItem.Text = "C&lear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.summaryToolStripMenuItem.Text = "&Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // productIdComboBox
            // 
            this.productIdComboBox.FormattingEnabled = true;
            this.productIdComboBox.Location = new System.Drawing.Point(211, 119);
            this.productIdComboBox.Name = "productIdComboBox";
            this.productIdComboBox.Size = new System.Drawing.Size(156, 22);
            this.productIdComboBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.productIdComboBox, "Product ID from the catalog.");
            // 
            // discountCheckBox
            // 
            this.discountCheckBox.AutoSize = true;
            this.discountCheckBox.Location = new System.Drawing.Point(129, 173);
            this.discountCheckBox.Name = "discountCheckBox";
            this.discountCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.discountCheckBox.Size = new System.Drawing.Size(95, 18);
            this.discountCheckBox.TabIndex = 4;
            this.discountCheckBox.Text = "&Discount:        ";
            this.discountCheckBox.UseVisualStyleBackColor = true;
            this.discountCheckBox.CheckedChanged += new System.EventHandler(this.discountCheckBox_CheckedChanged);
            // 
            // discountRateLabel
            // 
            this.discountRateLabel.AutoSize = true;
            this.discountRateLabel.Location = new System.Drawing.Point(109, 200);
            this.discountRateLabel.Name = "discountRateLabel";
            this.discountRateLabel.Size = new System.Drawing.Size(77, 14);
            this.discountRateLabel.TabIndex = 5;
            this.discountRateLabel.Text = "Discount &Rate:";
            this.toolTip1.SetToolTip(this.discountRateLabel, "Enter as a decimal, such as .20 for 20%.");
            this.discountRateLabel.Visible = false;
            // 
            // discountRateTextBox
            // 
            this.discountRateTextBox.Location = new System.Drawing.Point(211, 197);
            this.discountRateTextBox.Name = "discountRateTextBox";
            this.discountRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.discountRateTextBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.discountRateTextBox, "Enter as a decimal, such as .20 for 20%.");
            this.discountRateTextBox.Visible = false;
            // 
            // membercheckBox
            // 
            this.membercheckBox.AutoSize = true;
            this.membercheckBox.Location = new System.Drawing.Point(139, 223);
            this.membercheckBox.Name = "membercheckBox";
            this.membercheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.membercheckBox.Size = new System.Drawing.Size(85, 18);
            this.membercheckBox.TabIndex = 8;
            this.membercheckBox.Text = "&Member:      ";
            this.membercheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Extended Price:";
            // 
            // extendedPriceTextBox
            // 
            this.extendedPriceTextBox.Location = new System.Drawing.Point(211, 247);
            this.extendedPriceTextBox.Name = "extendedPriceTextBox";
            this.extendedPriceTextBox.ReadOnly = true;
            this.extendedPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.extendedPriceTextBox.TabIndex = 10;
            this.extendedPriceTextBox.TabStop = false;
            // 
            // ClothingSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 374);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.productIdComboBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.discountRateLabel);
            this.Controls.Add(this.discountRateTextBox);
            this.Controls.Add(this.extendedPriceTextBox);
            this.Controls.Add(this.membercheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.discountCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClothingSaleForm";
            this.Text = "Clothing Sales";
            this.Load += new System.EventHandler(this.ClothingSaleForm_Load);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.discountCheckBox, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.membercheckBox, 0);
            this.Controls.SetChildIndex(this.extendedPriceTextBox, 0);
            this.Controls.SetChildIndex(this.discountRateTextBox, 0);
            this.Controls.SetChildIndex(this.discountRateLabel, 0);
            this.Controls.SetChildIndex(this.quantityTextBox, 0);
            this.Controls.SetChildIndex(this.productIdComboBox, 0);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.okButton, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox productIdComboBox;
        private System.Windows.Forms.CheckBox discountCheckBox;
        private System.Windows.Forms.Label discountRateLabel;
        private System.Windows.Forms.TextBox discountRateTextBox;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.CheckBox membercheckBox;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox extendedPriceTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

