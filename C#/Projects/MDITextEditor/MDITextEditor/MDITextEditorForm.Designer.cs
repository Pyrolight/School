namespace MDITextEditor
{
    partial class MDITextEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDITextEditorForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.openTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.datepickerTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolBarStrip = new System.Windows.Forms.ToolStrip();
            this.newTSB = new System.Windows.Forms.ToolStripButton();
            this.openTSB = new System.Windows.Forms.ToolStripButton();
            this.closeTSB = new System.Windows.Forms.ToolStripButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateTimeTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenuStrip.SuspendLayout();
            this.mainToolBarStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(671, 24);
            this.mainMenuStrip.TabIndex = 1;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTSMI,
            this.openTSMI,
            this.datepickerTSMI});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.menuToolStripMenuItem.Text = "&File";
            // 
            // newTSMI
            // 
            this.newTSMI.Name = "newTSMI";
            this.newTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newTSMI.Size = new System.Drawing.Size(172, 22);
            this.newTSMI.Text = "&New";
            this.newTSMI.Click += new System.EventHandler(this.newTSMI_Click);
            // 
            // openTSMI
            // 
            this.openTSMI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openTSMI.Name = "openTSMI";
            this.openTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openTSMI.Size = new System.Drawing.Size(172, 22);
            this.openTSMI.Text = "&Open";
            this.openTSMI.Click += new System.EventHandler(this.openTSMI_Click);
            // 
            // datepickerTSMI
            // 
            this.datepickerTSMI.Enabled = false;
            this.datepickerTSMI.Name = "datepickerTSMI";
            this.datepickerTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.datepickerTSMI.Size = new System.Drawing.Size(172, 22);
            this.datepickerTSMI.Text = "&Datepicker";
            this.datepickerTSMI.Click += new System.EventHandler(this.datepickerToolStripMenuItem_Click);
            // 
            // mainToolBarStrip
            // 
            this.mainToolBarStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTSB,
            this.openTSB,
            this.closeTSB});
            this.mainToolBarStrip.Location = new System.Drawing.Point(0, 24);
            this.mainToolBarStrip.Name = "mainToolBarStrip";
            this.mainToolBarStrip.Size = new System.Drawing.Size(671, 25);
            this.mainToolBarStrip.TabIndex = 2;
            // 
            // newTSB
            // 
            this.newTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newTSB.Image = ((System.Drawing.Image)(resources.GetObject("newTSB.Image")));
            this.newTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newTSB.Name = "newTSB";
            this.newTSB.Size = new System.Drawing.Size(23, 22);
            this.newTSB.Text = "New";
            this.newTSB.Click += new System.EventHandler(this.newTSMI_Click);
            // 
            // openTSB
            // 
            this.openTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openTSB.Image = ((System.Drawing.Image)(resources.GetObject("openTSB.Image")));
            this.openTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openTSB.Name = "openTSB";
            this.openTSB.Size = new System.Drawing.Size(23, 22);
            this.openTSB.Text = "Open";
            this.openTSB.Click += new System.EventHandler(this.openTSMI_Click);
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
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(86, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Visible = false;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.dateTimeTSSL});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 508);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(671, 22);
            this.mainStatusStrip.TabIndex = 6;
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
            // MDITextEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 530);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.mainToolBarStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MDITextEditorForm";
            this.Text = "MDI Text Editor";
            this.Load += new System.EventHandler(this.MDITextEditorForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainToolBarStrip.ResumeLayout(false);
            this.mainToolBarStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTSMI;
        private System.Windows.Forms.ToolStripMenuItem openTSMI;
        private System.Windows.Forms.ToolStrip mainToolBarStrip;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ToolStripMenuItem datepickerTSMI;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel dateTimeTSSL;
        private System.Windows.Forms.ToolStripButton newTSB;
        private System.Windows.Forms.ToolStripButton openTSB;
        private System.Windows.Forms.ToolStripButton closeTSB;
    }
}

