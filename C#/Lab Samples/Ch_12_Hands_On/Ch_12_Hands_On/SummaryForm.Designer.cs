namespace Ch12HandsOn
{
    partial class SummaryForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.salesTotalTextBox = new System.Windows.Forms.TextBox();
            this.salesCountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sales Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of Sales:";
            // 
            // salesTotalTextBox
            // 
            this.salesTotalTextBox.Location = new System.Drawing.Point(272, 112);
            this.salesTotalTextBox.Name = "salesTotalTextBox";
            this.salesTotalTextBox.ReadOnly = true;
            this.salesTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.salesTotalTextBox.TabIndex = 4;
            this.salesTotalTextBox.TabStop = false;
            // 
            // salesCountTextBox
            // 
            this.salesCountTextBox.Location = new System.Drawing.Point(272, 138);
            this.salesCountTextBox.Name = "salesCountTextBox";
            this.salesCountTextBox.ReadOnly = true;
            this.salesCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.salesCountTextBox.TabIndex = 5;
            this.salesCountTextBox.TabStop = false;
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(484, 360);
            this.Controls.Add(this.salesCountTextBox);
            this.Controls.Add(this.salesTotalTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "SummaryForm";
            this.Text = "Clothing Sales Summary";
            this.Load += new System.EventHandler(this.SummaryForm_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.salesTotalTextBox, 0);
            this.Controls.SetChildIndex(this.salesCountTextBox, 0);
            this.Controls.SetChildIndex(this.okButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox salesTotalTextBox;
        private System.Windows.Forms.TextBox salesCountTextBox;
    }
}
