namespace MDITextEditor
{
    partial class textEditorFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(textEditorFrom));
            this.textEditorMenuStrip = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.textEditorTS = new System.Windows.Forms.ToolStrip();
            this.saveTSB = new System.Windows.Forms.ToolStripButton();
            this.saveAsTSB = new System.Windows.Forms.ToolStripButton();
            this.closeTSB = new System.Windows.Forms.ToolStripButton();
            this.textEditorSS = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateTimeTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.textEditorTB = new System.Windows.Forms.TextBox();
            this.textEditorMenuStrip.SuspendLayout();
            this.textEditorTS.SuspendLayout();
            this.textEditorSS.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEditorMenuStrip
            // 
            this.textEditorMenuStrip.AllowMerge = false;
            this.textEditorMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.textEditorMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.textEditorMenuStrip.Name = "textEditorMenuStrip";
            this.textEditorMenuStrip.Size = new System.Drawing.Size(432, 24);
            this.textEditorMenuStrip.TabIndex = 0;
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTSMI,
            this.saveAsTSMI});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.saveToolStripMenuItem.Text = "&File";
            // 
            // saveTSMI
            // 
            this.saveTSMI.Name = "saveTSMI";
            this.saveTSMI.Size = new System.Drawing.Size(152, 22);
            this.saveTSMI.Text = "&Save";
            this.saveTSMI.Click += new System.EventHandler(this.saveTSMI_Click);
            // 
            // saveAsTSMI
            // 
            this.saveAsTSMI.Name = "saveAsTSMI";
            this.saveAsTSMI.Size = new System.Drawing.Size(152, 22);
            this.saveAsTSMI.Text = "Save &As";
            this.saveAsTSMI.Click += new System.EventHandler(this.saveAsTSMI_Click);
            // 
            // textEditorTS
            // 
            this.textEditorTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTSB,
            this.saveAsTSB,
            this.closeTSB});
            this.textEditorTS.Location = new System.Drawing.Point(0, 24);
            this.textEditorTS.Name = "textEditorTS";
            this.textEditorTS.Size = new System.Drawing.Size(432, 25);
            this.textEditorTS.TabIndex = 1;
            // 
            // saveTSB
            // 
            this.saveTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveTSB.Image = ((System.Drawing.Image)(resources.GetObject("saveTSB.Image")));
            this.saveTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveTSB.Name = "saveTSB";
            this.saveTSB.Size = new System.Drawing.Size(23, 22);
            this.saveTSB.Text = "Save";
            this.saveTSB.Click += new System.EventHandler(this.saveTSMI_Click);
            // 
            // saveAsTSB
            // 
            this.saveAsTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAsTSB.Image = ((System.Drawing.Image)(resources.GetObject("saveAsTSB.Image")));
            this.saveAsTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsTSB.Name = "saveAsTSB";
            this.saveAsTSB.Size = new System.Drawing.Size(23, 22);
            this.saveAsTSB.Text = "Save As";
            this.saveAsTSB.Click += new System.EventHandler(this.saveAsTSMI_Click);
            // 
            // closeTSB
            // 
            this.closeTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeTSB.Image = ((System.Drawing.Image)(resources.GetObject("closeTSB.Image")));
            this.closeTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeTSB.Name = "closeTSB";
            this.closeTSB.Size = new System.Drawing.Size(23, 22);
            this.closeTSB.Text = "Close";
            this.closeTSB.Click += new System.EventHandler(this.closeTSB_Click);
            // 
            // textEditorSS
            // 
            this.textEditorSS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.dateTimeTSSL});
            this.textEditorSS.Location = new System.Drawing.Point(0, 330);
            this.textEditorSS.Name = "textEditorSS";
            this.textEditorSS.Size = new System.Drawing.Size(432, 22);
            this.textEditorSS.TabIndex = 2;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // dateTimeTSSL
            // 
            this.dateTimeTSSL.Name = "dateTimeTSSL";
            this.dateTimeTSSL.Size = new System.Drawing.Size(82, 17);
            this.dateTimeTSSL.Text = "dateTimeTSSL";
            // 
            // textEditorTB
            // 
            this.textEditorTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditorTB.Location = new System.Drawing.Point(0, 49);
            this.textEditorTB.Multiline = true;
            this.textEditorTB.Name = "textEditorTB";
            this.textEditorTB.Size = new System.Drawing.Size(432, 281);
            this.textEditorTB.TabIndex = 3;
            // 
            // textEditorFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 352);
            this.Controls.Add(this.textEditorTB);
            this.Controls.Add(this.textEditorSS);
            this.Controls.Add(this.textEditorTS);
            this.Controls.Add(this.textEditorMenuStrip);
            this.MainMenuStrip = this.textEditorMenuStrip;
            this.Name = "textEditorFrom";
            this.Text = "Text Editor";
            this.textEditorMenuStrip.ResumeLayout(false);
            this.textEditorMenuStrip.PerformLayout();
            this.textEditorTS.ResumeLayout(false);
            this.textEditorTS.PerformLayout();
            this.textEditorSS.ResumeLayout(false);
            this.textEditorSS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip textEditorMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTSMI;
        private System.Windows.Forms.ToolStrip textEditorTS;
        private System.Windows.Forms.ToolStripButton saveTSB;
        private System.Windows.Forms.ToolStripButton closeTSB;
        private System.Windows.Forms.StatusStrip textEditorSS;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.TextBox textEditorTB;
        private System.Windows.Forms.ToolStripMenuItem saveAsTSMI;
        private System.Windows.Forms.ToolStripStatusLabel dateTimeTSSL;
        private System.Windows.Forms.ToolStripButton saveAsTSB;
    }
}