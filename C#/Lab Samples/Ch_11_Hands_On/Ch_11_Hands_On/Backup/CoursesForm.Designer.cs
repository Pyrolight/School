namespace Ch11HandsOn
{
    partial class CoursesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoursesForm));
            this.classesComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addACourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeACourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTheCourseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayCourseCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printAllPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.printSelectedPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // classesComboBox
            // 
            this.classesComboBox.FormattingEnabled = true;
            this.classesComboBox.Location = new System.Drawing.Point(108, 91);
            this.classesComboBox.Name = "classesComboBox";
            this.classesComboBox.Size = new System.Drawing.Size(206, 21);
            this.classesComboBox.Sorted = true;
            this.classesComboBox.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(383, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCoursesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveCoursesToolStripMenuItem
            // 
            this.saveCoursesToolStripMenuItem.Name = "saveCoursesToolStripMenuItem";
            this.saveCoursesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveCoursesToolStripMenuItem.Text = "&Save Courses";
            this.saveCoursesToolStripMenuItem.Click += new System.EventHandler(this.saveCoursesToolStripMenuItem_Click);
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
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addACourseToolStripMenuItem,
            this.removeACourseToolStripMenuItem,
            this.clearTheCourseListToolStripMenuItem,
            this.displayCourseCountToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "E&dit";
            // 
            // addACourseToolStripMenuItem
            // 
            this.addACourseToolStripMenuItem.Name = "addACourseToolStripMenuItem";
            this.addACourseToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.addACourseToolStripMenuItem.Text = "&Add a &Course";
            this.addACourseToolStripMenuItem.Click += new System.EventHandler(this.addACourseToolStripMenuItem_Click);
            // 
            // removeACourseToolStripMenuItem
            // 
            this.removeACourseToolStripMenuItem.Name = "removeACourseToolStripMenuItem";
            this.removeACourseToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.removeACourseToolStripMenuItem.Text = "&Remove a Course";
            this.removeACourseToolStripMenuItem.Click += new System.EventHandler(this.removeACourseToolStripMenuItem_Click);
            // 
            // clearTheCourseListToolStripMenuItem
            // 
            this.clearTheCourseListToolStripMenuItem.Name = "clearTheCourseListToolStripMenuItem";
            this.clearTheCourseListToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.clearTheCourseListToolStripMenuItem.Text = "C&lear the Course List";
            this.clearTheCourseListToolStripMenuItem.Click += new System.EventHandler(this.clearTheCourseListToolStripMenuItem_Click);
            // 
            // displayCourseCountToolStripMenuItem
            // 
            this.displayCourseCountToolStripMenuItem.Name = "displayCourseCountToolStripMenuItem";
            this.displayCourseCountToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.displayCourseCountToolStripMenuItem.Text = "Display Course &Count";
            this.displayCourseCountToolStripMenuItem.Click += new System.EventHandler(this.displayCourseCountToolStripMenuItem_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(108, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(206, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client &Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Classes";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 185);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.classesComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CoursesForm";
            this.Text = "Look Sharp Fitness Center";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoursesForm_FormClosing);
            this.Load += new System.EventHandler(this.CoursesForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox classesComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addACourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeACourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearTheCourseListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayCourseCountToolStripMenuItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printAllPrintDocument;
        private System.Drawing.Printing.PrintDocument printSelectedPrintDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveCoursesToolStripMenuItem;
    }
}

