namespace StudentForm
{
    partial class Presentation
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
            this.studentLabel = new System.Windows.Forms.Label();
            this.displayStudentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(58, 39);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(99, 13);
            this.studentLabel.TabIndex = 0;
            this.studentLabel.Text = "Student Information";
            // 
            // displayStudentButton
            // 
            this.displayStudentButton.Location = new System.Drawing.Point(101, 282);
            this.displayStudentButton.Name = "displayStudentButton";
            this.displayStudentButton.Size = new System.Drawing.Size(95, 23);
            this.displayStudentButton.TabIndex = 1;
            this.displayStudentButton.Text = "Display Student";
            this.displayStudentButton.UseVisualStyleBackColor = true;
            this.displayStudentButton.Click += new System.EventHandler(this.displayStudentButton_Click);
            // 
            // Presentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 339);
            this.Controls.Add(this.displayStudentButton);
            this.Controls.Add(this.studentLabel);
            this.Name = "Presentation";
            this.Text = "Student Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Button displayStudentButton;
    }
}

