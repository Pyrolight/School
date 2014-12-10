namespace HatsRUs
{
    partial class OrderForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.userInformationGB = new System.Windows.Forms.GroupBox();
            this.sytleGB = new System.Windows.Forms.GroupBox();
            this.plainUD = new System.Windows.Forms.NumericUpDown();
            this.leatherUD = new System.Windows.Forms.NumericUpDown();
            this.fringedUD = new System.Windows.Forms.NumericUpDown();
            this.pirateUD = new System.Windows.Forms.NumericUpDown();
            this.beadedUD = new System.Windows.Forms.NumericUpDown();
            this.fullDecorativeUD = new System.Windows.Forms.NumericUpDown();
            this.plainLabel = new System.Windows.Forms.Label();
            this.leatherLabel = new System.Windows.Forms.Label();
            this.fringedLabel = new System.Windows.Forms.Label();
            this.pirateLabel = new System.Windows.Forms.Label();
            this.beadedLabel = new System.Windows.Forms.Label();
            this.fullDecorativeLabel = new System.Windows.Forms.Label();
            this.plainRB = new System.Windows.Forms.RadioButton();
            this.leatherRB = new System.Windows.Forms.RadioButton();
            this.fringedRB = new System.Windows.Forms.RadioButton();
            this.pirateRB = new System.Windows.Forms.RadioButton();
            this.beadedRB = new System.Windows.Forms.RadioButton();
            this.fullDecorativeRB = new System.Windows.Forms.RadioButton();
            this.shippingCB = new System.Windows.Forms.ComboBox();
            this.shippingLabel = new System.Windows.Forms.Label();
            this.calculateOrder = new System.Windows.Forms.Button();
            this.processOrderButton = new System.Windows.Forms.Button();
            this.orderSubtotalTB = new System.Windows.Forms.TextBox();
            this.orderSippingTB = new System.Windows.Forms.TextBox();
            this.orderTotalTB = new System.Windows.Forms.TextBox();
            this.orderSubtotalLabel = new System.Windows.Forms.Label();
            this.orderShippingLabel = new System.Windows.Forms.Label();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.userInformationGB.SuspendLayout();
            this.sytleGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plainUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leatherUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fringedUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pirateUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beadedUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDecorativeUD)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateOrderToolStripMenuItem,
            this.processOrderToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // calculateOrderToolStripMenuItem
            // 
            this.calculateOrderToolStripMenuItem.Name = "calculateOrderToolStripMenuItem";
            this.calculateOrderToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.calculateOrderToolStripMenuItem.Text = "Calculate Order";
            this.calculateOrderToolStripMenuItem.Click += new System.EventHandler(this.calculateOrder_Click);
            // 
            // processOrderToolStripMenuItem
            // 
            this.processOrderToolStripMenuItem.Enabled = false;
            this.processOrderToolStripMenuItem.Name = "processOrderToolStripMenuItem";
            this.processOrderToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.processOrderToolStripMenuItem.Text = "Process Order";
            this.processOrderToolStripMenuItem.Click += new System.EventHandler(this.processOrder_Click);
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(78, 70);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(100, 20);
            this.lastNameTB.TabIndex = 2;
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(78, 46);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(100, 20);
            this.firstNameTB.TabIndex = 1;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(78, 92);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(100, 20);
            this.emailTB.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(7, 73);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(7, 49);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(7, 99);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // userInformationGB
            // 
            this.userInformationGB.Controls.Add(this.lastNameLabel);
            this.userInformationGB.Controls.Add(this.emailLabel);
            this.userInformationGB.Controls.Add(this.lastNameTB);
            this.userInformationGB.Controls.Add(this.firstNameLabel);
            this.userInformationGB.Controls.Add(this.firstNameTB);
            this.userInformationGB.Controls.Add(this.emailTB);
            this.userInformationGB.Location = new System.Drawing.Point(12, 49);
            this.userInformationGB.Name = "userInformationGB";
            this.userInformationGB.Size = new System.Drawing.Size(200, 161);
            this.userInformationGB.TabIndex = 7;
            this.userInformationGB.TabStop = false;
            this.userInformationGB.Text = "Your Information";
            // 
            // sytleGB
            // 
            this.sytleGB.Controls.Add(this.plainUD);
            this.sytleGB.Controls.Add(this.leatherUD);
            this.sytleGB.Controls.Add(this.fringedUD);
            this.sytleGB.Controls.Add(this.pirateUD);
            this.sytleGB.Controls.Add(this.beadedUD);
            this.sytleGB.Controls.Add(this.fullDecorativeUD);
            this.sytleGB.Controls.Add(this.plainLabel);
            this.sytleGB.Controls.Add(this.leatherLabel);
            this.sytleGB.Controls.Add(this.fringedLabel);
            this.sytleGB.Controls.Add(this.pirateLabel);
            this.sytleGB.Controls.Add(this.beadedLabel);
            this.sytleGB.Controls.Add(this.fullDecorativeLabel);
            this.sytleGB.Controls.Add(this.plainRB);
            this.sytleGB.Controls.Add(this.leatherRB);
            this.sytleGB.Controls.Add(this.fringedRB);
            this.sytleGB.Controls.Add(this.pirateRB);
            this.sytleGB.Controls.Add(this.beadedRB);
            this.sytleGB.Controls.Add(this.fullDecorativeRB);
            this.sytleGB.Location = new System.Drawing.Point(274, 49);
            this.sytleGB.Name = "sytleGB";
            this.sytleGB.Size = new System.Drawing.Size(307, 163);
            this.sytleGB.TabIndex = 8;
            this.sytleGB.TabStop = false;
            this.sytleGB.Text = "Style";
            // 
            // plainUD
            // 
            this.plainUD.Location = new System.Drawing.Point(172, 134);
            this.plainUD.Name = "plainUD";
            this.plainUD.Size = new System.Drawing.Size(120, 20);
            this.plainUD.TabIndex = 12;
            // 
            // leatherUD
            // 
            this.leatherUD.Location = new System.Drawing.Point(172, 113);
            this.leatherUD.Name = "leatherUD";
            this.leatherUD.Size = new System.Drawing.Size(120, 20);
            this.leatherUD.TabIndex = 11;
            // 
            // fringedUD
            // 
            this.fringedUD.Location = new System.Drawing.Point(172, 90);
            this.fringedUD.Name = "fringedUD";
            this.fringedUD.Size = new System.Drawing.Size(120, 20);
            this.fringedUD.TabIndex = 10;
            // 
            // pirateUD
            // 
            this.pirateUD.Location = new System.Drawing.Point(172, 67);
            this.pirateUD.Name = "pirateUD";
            this.pirateUD.Size = new System.Drawing.Size(120, 20);
            this.pirateUD.TabIndex = 9;
            // 
            // beadedUD
            // 
            this.beadedUD.Location = new System.Drawing.Point(172, 41);
            this.beadedUD.Name = "beadedUD";
            this.beadedUD.Size = new System.Drawing.Size(120, 20);
            this.beadedUD.TabIndex = 8;
            // 
            // fullDecorativeUD
            // 
            this.fullDecorativeUD.Location = new System.Drawing.Point(172, 16);
            this.fullDecorativeUD.Name = "fullDecorativeUD";
            this.fullDecorativeUD.Size = new System.Drawing.Size(120, 20);
            this.fullDecorativeUD.TabIndex = 7;
            // 
            // plainLabel
            // 
            this.plainLabel.AutoSize = true;
            this.plainLabel.Location = new System.Drawing.Point(109, 136);
            this.plainLabel.Name = "plainLabel";
            this.plainLabel.Size = new System.Drawing.Size(40, 13);
            this.plainLabel.TabIndex = 55;
            this.plainLabel.Text = "$20.00";
            // 
            // leatherLabel
            // 
            this.leatherLabel.AutoSize = true;
            this.leatherLabel.Location = new System.Drawing.Point(109, 115);
            this.leatherLabel.Name = "leatherLabel";
            this.leatherLabel.Size = new System.Drawing.Size(40, 13);
            this.leatherLabel.TabIndex = 54;
            this.leatherLabel.Text = "$80.00";
            // 
            // fringedLabel
            // 
            this.fringedLabel.AutoSize = true;
            this.fringedLabel.Location = new System.Drawing.Point(109, 90);
            this.fringedLabel.Name = "fringedLabel";
            this.fringedLabel.Size = new System.Drawing.Size(40, 13);
            this.fringedLabel.TabIndex = 53;
            this.fringedLabel.Text = "$25.00";
            // 
            // pirateLabel
            // 
            this.pirateLabel.AutoSize = true;
            this.pirateLabel.Location = new System.Drawing.Point(109, 67);
            this.pirateLabel.Name = "pirateLabel";
            this.pirateLabel.Size = new System.Drawing.Size(40, 13);
            this.pirateLabel.TabIndex = 52;
            this.pirateLabel.Text = "$40.00";
            // 
            // beadedLabel
            // 
            this.beadedLabel.AutoSize = true;
            this.beadedLabel.Location = new System.Drawing.Point(109, 44);
            this.beadedLabel.Name = "beadedLabel";
            this.beadedLabel.Size = new System.Drawing.Size(40, 13);
            this.beadedLabel.TabIndex = 51;
            this.beadedLabel.Text = "$45.00";
            // 
            // fullDecorativeLabel
            // 
            this.fullDecorativeLabel.AutoSize = true;
            this.fullDecorativeLabel.Location = new System.Drawing.Point(109, 21);
            this.fullDecorativeLabel.Name = "fullDecorativeLabel";
            this.fullDecorativeLabel.Size = new System.Drawing.Size(40, 13);
            this.fullDecorativeLabel.TabIndex = 50;
            this.fullDecorativeLabel.Text = "$50.00";
            // 
            // plainRB
            // 
            this.plainRB.AutoSize = true;
            this.plainRB.Location = new System.Drawing.Point(6, 136);
            this.plainRB.Name = "plainRB";
            this.plainRB.Size = new System.Drawing.Size(48, 17);
            this.plainRB.TabIndex = 5;
            this.plainRB.Text = "Plain";
            this.plainRB.UseVisualStyleBackColor = true;
            // 
            // leatherRB
            // 
            this.leatherRB.AutoSize = true;
            this.leatherRB.Location = new System.Drawing.Point(6, 113);
            this.leatherRB.Name = "leatherRB";
            this.leatherRB.Size = new System.Drawing.Size(61, 17);
            this.leatherRB.TabIndex = 4;
            this.leatherRB.Text = "Leather";
            this.leatherRB.UseVisualStyleBackColor = true;
            // 
            // fringedRB
            // 
            this.fringedRB.AutoSize = true;
            this.fringedRB.Location = new System.Drawing.Point(6, 90);
            this.fringedRB.Name = "fringedRB";
            this.fringedRB.Size = new System.Drawing.Size(60, 17);
            this.fringedRB.TabIndex = 3;
            this.fringedRB.Text = "Fringed";
            this.fringedRB.UseVisualStyleBackColor = true;
            // 
            // pirateRB
            // 
            this.pirateRB.AutoSize = true;
            this.pirateRB.Location = new System.Drawing.Point(6, 67);
            this.pirateRB.Name = "pirateRB";
            this.pirateRB.Size = new System.Drawing.Size(52, 17);
            this.pirateRB.TabIndex = 2;
            this.pirateRB.Text = "Pirate";
            this.pirateRB.UseVisualStyleBackColor = true;
            // 
            // beadedRB
            // 
            this.beadedRB.AutoSize = true;
            this.beadedRB.Location = new System.Drawing.Point(6, 44);
            this.beadedRB.Name = "beadedRB";
            this.beadedRB.Size = new System.Drawing.Size(62, 17);
            this.beadedRB.TabIndex = 1;
            this.beadedRB.Text = "Beaded";
            this.beadedRB.UseVisualStyleBackColor = true;
            // 
            // fullDecorativeRB
            // 
            this.fullDecorativeRB.AutoSize = true;
            this.fullDecorativeRB.Checked = true;
            this.fullDecorativeRB.Location = new System.Drawing.Point(6, 21);
            this.fullDecorativeRB.Name = "fullDecorativeRB";
            this.fullDecorativeRB.Size = new System.Drawing.Size(96, 17);
            this.fullDecorativeRB.TabIndex = 0;
            this.fullDecorativeRB.TabStop = true;
            this.fullDecorativeRB.Text = "Full Decorative";
            this.fullDecorativeRB.UseVisualStyleBackColor = true;
            // 
            // shippingCB
            // 
            this.shippingCB.FormattingEnabled = true;
            this.shippingCB.Items.AddRange(new object[] {
            "Overnight service:\t10% of order total",
            "Three day service:\t 7% of order total",
            "Standard service:\t 5% of order total"});
            this.shippingCB.Location = new System.Drawing.Point(22, 245);
            this.shippingCB.Name = "shippingCB";
            this.shippingCB.Size = new System.Drawing.Size(210, 21);
            this.shippingCB.TabIndex = 9;
            // 
            // shippingLabel
            // 
            this.shippingLabel.AutoSize = true;
            this.shippingLabel.Location = new System.Drawing.Point(19, 229);
            this.shippingLabel.Name = "shippingLabel";
            this.shippingLabel.Size = new System.Drawing.Size(87, 13);
            this.shippingLabel.TabIndex = 10;
            this.shippingLabel.Text = "Shipping Options";
            // 
            // calculateOrder
            // 
            this.calculateOrder.Location = new System.Drawing.Point(346, 316);
            this.calculateOrder.Name = "calculateOrder";
            this.calculateOrder.Size = new System.Drawing.Size(107, 23);
            this.calculateOrder.TabIndex = 11;
            this.calculateOrder.Text = "Calculate Order";
            this.calculateOrder.UseVisualStyleBackColor = true;
            this.calculateOrder.Click += new System.EventHandler(this.calculateOrder_Click);
            // 
            // processOrderButton
            // 
            this.processOrderButton.Enabled = false;
            this.processOrderButton.Location = new System.Drawing.Point(459, 316);
            this.processOrderButton.Name = "processOrderButton";
            this.processOrderButton.Size = new System.Drawing.Size(107, 23);
            this.processOrderButton.TabIndex = 12;
            this.processOrderButton.Text = "Process Order";
            this.processOrderButton.UseVisualStyleBackColor = true;
            this.processOrderButton.Click += new System.EventHandler(this.processOrder_Click);
            // 
            // orderSubtotalTB
            // 
            this.orderSubtotalTB.Location = new System.Drawing.Point(481, 222);
            this.orderSubtotalTB.Name = "orderSubtotalTB";
            this.orderSubtotalTB.Size = new System.Drawing.Size(100, 20);
            this.orderSubtotalTB.TabIndex = 13;
            // 
            // orderSippingTB
            // 
            this.orderSippingTB.Location = new System.Drawing.Point(481, 245);
            this.orderSippingTB.Name = "orderSippingTB";
            this.orderSippingTB.Size = new System.Drawing.Size(100, 20);
            this.orderSippingTB.TabIndex = 14;
            // 
            // orderTotalTB
            // 
            this.orderTotalTB.Location = new System.Drawing.Point(481, 271);
            this.orderTotalTB.Name = "orderTotalTB";
            this.orderTotalTB.Size = new System.Drawing.Size(100, 20);
            this.orderTotalTB.TabIndex = 15;
            // 
            // orderSubtotalLabel
            // 
            this.orderSubtotalLabel.AutoSize = true;
            this.orderSubtotalLabel.Location = new System.Drawing.Point(383, 222);
            this.orderSubtotalLabel.Name = "orderSubtotalLabel";
            this.orderSubtotalLabel.Size = new System.Drawing.Size(46, 13);
            this.orderSubtotalLabel.TabIndex = 16;
            this.orderSubtotalLabel.Text = "Subtotal";
            // 
            // orderShippingLabel
            // 
            this.orderShippingLabel.AutoSize = true;
            this.orderShippingLabel.Location = new System.Drawing.Point(383, 245);
            this.orderShippingLabel.Name = "orderShippingLabel";
            this.orderShippingLabel.Size = new System.Drawing.Size(48, 13);
            this.orderShippingLabel.TabIndex = 17;
            this.orderShippingLabel.Text = "Shipping";
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.AutoSize = true;
            this.orderTotalLabel.Location = new System.Drawing.Point(383, 271);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(31, 13);
            this.orderTotalLabel.TabIndex = 18;
            this.orderTotalLabel.Text = "Total";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 364);
            this.Controls.Add(this.orderTotalLabel);
            this.Controls.Add(this.orderShippingLabel);
            this.Controls.Add(this.orderSubtotalLabel);
            this.Controls.Add(this.orderTotalTB);
            this.Controls.Add(this.orderSippingTB);
            this.Controls.Add(this.orderSubtotalTB);
            this.Controls.Add(this.processOrderButton);
            this.Controls.Add(this.calculateOrder);
            this.Controls.Add(this.shippingLabel);
            this.Controls.Add(this.shippingCB);
            this.Controls.Add(this.sytleGB);
            this.Controls.Add(this.userInformationGB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.Text = "HatsRUs";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.userInformationGB.ResumeLayout(false);
            this.userInformationGB.PerformLayout();
            this.sytleGB.ResumeLayout(false);
            this.sytleGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plainUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leatherUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fringedUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pirateUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beadedUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDecorativeUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processOrderToolStripMenuItem;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.GroupBox userInformationGB;
        private System.Windows.Forms.GroupBox sytleGB;
        private System.Windows.Forms.Label plainLabel;
        private System.Windows.Forms.Label leatherLabel;
        private System.Windows.Forms.Label fringedLabel;
        private System.Windows.Forms.Label pirateLabel;
        private System.Windows.Forms.Label beadedLabel;
        private System.Windows.Forms.Label fullDecorativeLabel;
        private System.Windows.Forms.RadioButton plainRB;
        private System.Windows.Forms.RadioButton leatherRB;
        private System.Windows.Forms.RadioButton fringedRB;
        private System.Windows.Forms.RadioButton pirateRB;
        private System.Windows.Forms.RadioButton beadedRB;
        private System.Windows.Forms.RadioButton fullDecorativeRB;
        private System.Windows.Forms.NumericUpDown plainUD;
        private System.Windows.Forms.NumericUpDown leatherUD;
        private System.Windows.Forms.NumericUpDown fringedUD;
        private System.Windows.Forms.NumericUpDown pirateUD;
        private System.Windows.Forms.NumericUpDown beadedUD;
        private System.Windows.Forms.NumericUpDown fullDecorativeUD;
        private System.Windows.Forms.ComboBox shippingCB;
        private System.Windows.Forms.Label shippingLabel;
        private System.Windows.Forms.Button calculateOrder;
        private System.Windows.Forms.Button processOrderButton;
        private System.Windows.Forms.TextBox orderSubtotalTB;
        private System.Windows.Forms.TextBox orderSippingTB;
        private System.Windows.Forms.TextBox orderTotalTB;
        private System.Windows.Forms.Label orderSubtotalLabel;
        private System.Windows.Forms.Label orderShippingLabel;
        private System.Windows.Forms.Label orderTotalLabel;
    }
}

