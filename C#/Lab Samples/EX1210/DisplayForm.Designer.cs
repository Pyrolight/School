namespace EX1210
{
    partial class DisplayForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.condimentsLabel = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.breadLabel = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.cheeseLabel = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.meatLabel = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(208, 224);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 21;
            this.okButton.Text = "&OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // condimentsLabel
            // 
            this.condimentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.condimentsLabel.Location = new System.Drawing.Point(393, 145);
            this.condimentsLabel.Name = "condimentsLabel";
            this.condimentsLabel.Size = new System.Drawing.Size(100, 64);
            this.condimentsLabel.TabIndex = 20;
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(393, 121);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(100, 23);
            this.Label9.TabIndex = 19;
            this.Label9.Text = "Condiments:";
            // 
            // breadLabel
            // 
            this.breadLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.breadLabel.Location = new System.Drawing.Point(273, 145);
            this.breadLabel.Name = "breadLabel";
            this.breadLabel.Size = new System.Drawing.Size(100, 24);
            this.breadLabel.TabIndex = 18;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(273, 121);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(100, 24);
            this.Label7.TabIndex = 17;
            this.Label7.Text = "Bread:";
            // 
            // cheeseLabel
            // 
            this.cheeseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cheeseLabel.Location = new System.Drawing.Point(153, 145);
            this.cheeseLabel.Name = "cheeseLabel";
            this.cheeseLabel.Size = new System.Drawing.Size(100, 23);
            this.cheeseLabel.TabIndex = 16;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(153, 121);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(100, 23);
            this.Label5.TabIndex = 15;
            this.Label5.Text = "Cheese:";
            // 
            // meatLabel
            // 
            this.meatLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.meatLabel.Location = new System.Drawing.Point(25, 145);
            this.meatLabel.Name = "meatLabel";
            this.meatLabel.Size = new System.Drawing.Size(100, 23);
            this.meatLabel.TabIndex = 14;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(25, 121);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 23);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "Meat:";
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(193, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 23);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(193, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 23);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Sandwich Name:";
            // 
            // DisplayForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 265);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.condimentsLabel);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.breadLabel);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.cheeseLabel);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.meatLabel);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DisplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Sandwich Order:";
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button okButton;
        internal System.Windows.Forms.Label condimentsLabel;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label breadLabel;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label cheeseLabel;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label meatLabel;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label nameLabel;
        internal System.Windows.Forms.Label Label1;
    }
}