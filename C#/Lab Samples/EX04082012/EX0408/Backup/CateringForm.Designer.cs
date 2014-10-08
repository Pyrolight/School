namespace EX0408
{
    partial class CateringForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.amountDueTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.guestTextBox = new System.Windows.Forms.TextBox();
            this.summaryButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openBarCheckBox = new System.Windows.Forms.CheckBox();
            this.wineCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nothingSelectedRadioButton = new System.Windows.Forms.RadioButton();
            this.pastaRadioButton = new System.Windows.Forms.RadioButton();
            this.primeRibRadioButton = new System.Windows.Forms.RadioButton();
            this.chickenRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.amountDueTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(85, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 40);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // amountDueTextBox
            // 
            this.amountDueTextBox.Location = new System.Drawing.Point(85, 13);
            this.amountDueTextBox.Name = "amountDueTextBox";
            this.amountDueTextBox.ReadOnly = true;
            this.amountDueTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountDueTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amount Due";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(253, 259);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // guestTextBox
            // 
            this.guestTextBox.Location = new System.Drawing.Point(10, 34);
            this.guestTextBox.Name = "guestTextBox";
            this.guestTextBox.Size = new System.Drawing.Size(87, 20);
            this.guestTextBox.TabIndex = 1;
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(172, 259);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(75, 23);
            this.summaryButton.TabIndex = 7;
            this.summaryButton.Text = "&Summary";
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(91, 259);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "C&lear";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.calculateButton.Location = new System.Drawing.Point(10, 259);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.openBarCheckBox);
            this.groupBox2.Controls.Add(this.wineCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(170, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 75);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bar Selection";
            // 
            // openBarCheckBox
            // 
            this.openBarCheckBox.AutoSize = true;
            this.openBarCheckBox.Location = new System.Drawing.Point(6, 19);
            this.openBarCheckBox.Name = "openBarCheckBox";
            this.openBarCheckBox.Size = new System.Drawing.Size(71, 17);
            this.openBarCheckBox.TabIndex = 0;
            this.openBarCheckBox.Text = "&Open Bar";
            // 
            // wineCheckBox
            // 
            this.wineCheckBox.AutoSize = true;
            this.wineCheckBox.Location = new System.Drawing.Point(6, 48);
            this.wineCheckBox.Name = "wineCheckBox";
            this.wineCheckBox.Size = new System.Drawing.Size(107, 17);
            this.wineCheckBox.TabIndex = 1;
            this.wineCheckBox.Text = "&Wine with Dinner";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nothingSelectedRadioButton);
            this.groupBox1.Controls.Add(this.pastaRadioButton);
            this.groupBox1.Controls.Add(this.primeRibRadioButton);
            this.groupBox1.Controls.Add(this.chickenRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(10, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Choices";
            // 
            // nothingSelectedRadioButton
            // 
            this.nothingSelectedRadioButton.AutoSize = true;
            this.nothingSelectedRadioButton.Checked = true;
            this.nothingSelectedRadioButton.Location = new System.Drawing.Point(6, 10);
            this.nothingSelectedRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nothingSelectedRadioButton.Name = "nothingSelectedRadioButton";
            this.nothingSelectedRadioButton.Size = new System.Drawing.Size(107, 17);
            this.nothingSelectedRadioButton.TabIndex = 9;
            this.nothingSelectedRadioButton.TabStop = true;
            this.nothingSelectedRadioButton.Text = "Nothing Selected";
            this.nothingSelectedRadioButton.UseVisualStyleBackColor = true;
            this.nothingSelectedRadioButton.Visible = false;
            // 
            // pastaRadioButton
            // 
            this.pastaRadioButton.AutoSize = true;
            this.pastaRadioButton.Location = new System.Drawing.Point(6, 77);
            this.pastaRadioButton.Name = "pastaRadioButton";
            this.pastaRadioButton.Size = new System.Drawing.Size(52, 17);
            this.pastaRadioButton.TabIndex = 2;
            this.pastaRadioButton.Tag = "";
            this.pastaRadioButton.Text = "&Pasta";
            // 
            // primeRibRadioButton
            // 
            this.primeRibRadioButton.AutoSize = true;
            this.primeRibRadioButton.Location = new System.Drawing.Point(6, 24);
            this.primeRibRadioButton.Name = "primeRibRadioButton";
            this.primeRibRadioButton.Size = new System.Drawing.Size(70, 17);
            this.primeRibRadioButton.TabIndex = 0;
            this.primeRibRadioButton.Text = "Prime &Rib";
            // 
            // chickenRadioButton
            // 
            this.chickenRadioButton.AutoSize = true;
            this.chickenRadioButton.Location = new System.Drawing.Point(6, 48);
            this.chickenRadioButton.Name = "chickenRadioButton";
            this.chickenRadioButton.Size = new System.Drawing.Size(64, 17);
            this.chickenRadioButton.TabIndex = 1;
            this.chickenRadioButton.Text = "C&hicken";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of &Guests";
            // 
            // CateringForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(352, 303);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.guestTextBox);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CateringForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catherine\'s Catering";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.TextBox amountDueTextBox;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button exitButton;
        internal System.Windows.Forms.TextBox guestTextBox;
        internal System.Windows.Forms.Button summaryButton;
        internal System.Windows.Forms.Button clearButton;
        internal System.Windows.Forms.Button calculateButton;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.CheckBox openBarCheckBox;
        internal System.Windows.Forms.CheckBox wineCheckBox;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.RadioButton pastaRadioButton;
        internal System.Windows.Forms.RadioButton primeRibRadioButton;
        internal System.Windows.Forms.RadioButton chickenRadioButton;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton nothingSelectedRadioButton;
    }
}

