namespace CustomerDatabase
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label roomLabel1;
            System.Windows.Forms.Label bedCodeLabel1;
            System.Windows.Forms.Label jacuzziLabel1;
            System.Windows.Forms.Label private_AccessLabel1;
            System.Windows.Forms.Label fireplaceLabel1;
            System.Windows.Forms.Label bedTypeLabel1;
            System.Windows.Forms.Label weekendRateLabel1;
            System.Windows.Forms.Label weekdayRateLabel1;
            System.Windows.Forms.Label guestLabel;
            System.Windows.Forms.Label departureLabel;
            System.Windows.Forms.Label arrivalLabel;
            System.Windows.Forms.Label creditCardNumberLabel;
            System.Windows.Forms.Label cardLabel;
            this.cottages2DataSet = new CustomerDatabase.Cottages2DataSet();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new CustomerDatabase.Cottages2DataSetTableAdapters.RoomsTableAdapter();
            this.tableAdapterManager = new CustomerDatabase.Cottages2DataSetTableAdapters.TableAdapterManager();
            this.roomsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.roomsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.roomTextBox1 = new System.Windows.Forms.TextBox();
            this.bedCodeTextBox1 = new System.Windows.Forms.TextBox();
            this.jacuzziCheckBox1 = new System.Windows.Forms.CheckBox();
            this.private_AccessCheckBox1 = new System.Windows.Forms.CheckBox();
            this.fireplaceCheckBox1 = new System.Windows.Forms.CheckBox();
            this.bedTypeTextBox1 = new System.Windows.Forms.TextBox();
            this.weekendRateTextBox1 = new System.Windows.Forms.TextBox();
            this.weekdayRateTextBox1 = new System.Windows.Forms.TextBox();
            this.guestTextBox = new System.Windows.Forms.TextBox();
            this.departureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.arrivalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.creditCardNumberTextBox = new System.Windows.Forms.TextBox();
            this.cardTextBox = new System.Windows.Forms.TextBox();
            roomLabel1 = new System.Windows.Forms.Label();
            bedCodeLabel1 = new System.Windows.Forms.Label();
            jacuzziLabel1 = new System.Windows.Forms.Label();
            private_AccessLabel1 = new System.Windows.Forms.Label();
            fireplaceLabel1 = new System.Windows.Forms.Label();
            bedTypeLabel1 = new System.Windows.Forms.Label();
            weekendRateLabel1 = new System.Windows.Forms.Label();
            weekdayRateLabel1 = new System.Windows.Forms.Label();
            guestLabel = new System.Windows.Forms.Label();
            departureLabel = new System.Windows.Forms.Label();
            arrivalLabel = new System.Windows.Forms.Label();
            creditCardNumberLabel = new System.Windows.Forms.Label();
            cardLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cottages2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingNavigator)).BeginInit();
            this.roomsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cottages2DataSet
            // 
            this.cottages2DataSet.DataSetName = "Cottages2DataSet";
            this.cottages2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.cottages2DataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BedsTableAdapter = null;
            this.tableAdapterManager.GuestsTableAdapter = null;
            this.tableAdapterManager.ReservationsTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = this.roomsTableAdapter;
            this.tableAdapterManager.StatesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CustomerDatabase.Cottages2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // roomsBindingNavigator
            // 
            this.roomsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.roomsBindingNavigator.BindingSource = this.roomsBindingSource;
            this.roomsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.roomsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.roomsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.roomsBindingNavigatorSaveItem});
            this.roomsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.roomsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.roomsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.roomsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.roomsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.roomsBindingNavigator.Name = "roomsBindingNavigator";
            this.roomsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.roomsBindingNavigator.Size = new System.Drawing.Size(505, 25);
            this.roomsBindingNavigator.TabIndex = 0;
            this.roomsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // roomsBindingNavigatorSaveItem
            // 
            this.roomsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.roomsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("roomsBindingNavigatorSaveItem.Image")));
            this.roomsBindingNavigatorSaveItem.Name = "roomsBindingNavigatorSaveItem";
            this.roomsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.roomsBindingNavigatorSaveItem.Text = "Save Data";
            this.roomsBindingNavigatorSaveItem.Click += new System.EventHandler(this.roomsBindingNavigatorSaveItem_Click_2);
            // 
            // roomLabel1
            // 
            roomLabel1.AutoSize = true;
            roomLabel1.Location = new System.Drawing.Point(92, 52);
            roomLabel1.Name = "roomLabel1";
            roomLabel1.Size = new System.Drawing.Size(38, 13);
            roomLabel1.TabIndex = 17;
            roomLabel1.Text = "Room:";
            // 
            // roomTextBox1
            // 
            this.roomTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Room", true));
            this.roomTextBox1.Location = new System.Drawing.Point(200, 49);
            this.roomTextBox1.Name = "roomTextBox1";
            this.roomTextBox1.Size = new System.Drawing.Size(200, 20);
            this.roomTextBox1.TabIndex = 18;
            // 
            // bedCodeLabel1
            // 
            bedCodeLabel1.AutoSize = true;
            bedCodeLabel1.Location = new System.Drawing.Point(92, 78);
            bedCodeLabel1.Name = "bedCodeLabel1";
            bedCodeLabel1.Size = new System.Drawing.Size(57, 13);
            bedCodeLabel1.TabIndex = 19;
            bedCodeLabel1.Text = "Bed Code:";
            // 
            // bedCodeTextBox1
            // 
            this.bedCodeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "BedCode", true));
            this.bedCodeTextBox1.Location = new System.Drawing.Point(200, 75);
            this.bedCodeTextBox1.Name = "bedCodeTextBox1";
            this.bedCodeTextBox1.Size = new System.Drawing.Size(200, 20);
            this.bedCodeTextBox1.TabIndex = 20;
            // 
            // jacuzziLabel1
            // 
            jacuzziLabel1.AutoSize = true;
            jacuzziLabel1.Location = new System.Drawing.Point(92, 106);
            jacuzziLabel1.Name = "jacuzziLabel1";
            jacuzziLabel1.Size = new System.Drawing.Size(45, 13);
            jacuzziLabel1.TabIndex = 21;
            jacuzziLabel1.Text = "Jacuzzi:";
            // 
            // jacuzziCheckBox1
            // 
            this.jacuzziCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.roomsBindingSource, "Jacuzzi", true));
            this.jacuzziCheckBox1.Location = new System.Drawing.Point(200, 101);
            this.jacuzziCheckBox1.Name = "jacuzziCheckBox1";
            this.jacuzziCheckBox1.Size = new System.Drawing.Size(200, 24);
            this.jacuzziCheckBox1.TabIndex = 22;
            this.jacuzziCheckBox1.Text = "checkBox1";
            this.jacuzziCheckBox1.UseVisualStyleBackColor = true;
            // 
            // private_AccessLabel1
            // 
            private_AccessLabel1.AutoSize = true;
            private_AccessLabel1.Location = new System.Drawing.Point(92, 136);
            private_AccessLabel1.Name = "private_AccessLabel1";
            private_AccessLabel1.Size = new System.Drawing.Size(81, 13);
            private_AccessLabel1.TabIndex = 23;
            private_AccessLabel1.Text = "Private Access:";
            // 
            // private_AccessCheckBox1
            // 
            this.private_AccessCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.roomsBindingSource, "Private Access", true));
            this.private_AccessCheckBox1.Location = new System.Drawing.Point(200, 131);
            this.private_AccessCheckBox1.Name = "private_AccessCheckBox1";
            this.private_AccessCheckBox1.Size = new System.Drawing.Size(200, 24);
            this.private_AccessCheckBox1.TabIndex = 24;
            this.private_AccessCheckBox1.Text = "checkBox1";
            this.private_AccessCheckBox1.UseVisualStyleBackColor = true;
            // 
            // fireplaceLabel1
            // 
            fireplaceLabel1.AutoSize = true;
            fireplaceLabel1.Location = new System.Drawing.Point(92, 166);
            fireplaceLabel1.Name = "fireplaceLabel1";
            fireplaceLabel1.Size = new System.Drawing.Size(53, 13);
            fireplaceLabel1.TabIndex = 25;
            fireplaceLabel1.Text = "Fireplace:";
            // 
            // fireplaceCheckBox1
            // 
            this.fireplaceCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.roomsBindingSource, "Fireplace", true));
            this.fireplaceCheckBox1.Location = new System.Drawing.Point(200, 161);
            this.fireplaceCheckBox1.Name = "fireplaceCheckBox1";
            this.fireplaceCheckBox1.Size = new System.Drawing.Size(200, 24);
            this.fireplaceCheckBox1.TabIndex = 26;
            this.fireplaceCheckBox1.Text = "checkBox1";
            this.fireplaceCheckBox1.UseVisualStyleBackColor = true;
            // 
            // bedTypeLabel1
            // 
            bedTypeLabel1.AutoSize = true;
            bedTypeLabel1.Location = new System.Drawing.Point(92, 194);
            bedTypeLabel1.Name = "bedTypeLabel1";
            bedTypeLabel1.Size = new System.Drawing.Size(56, 13);
            bedTypeLabel1.TabIndex = 27;
            bedTypeLabel1.Text = "Bed Type:";
            // 
            // bedTypeTextBox1
            // 
            this.bedTypeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "BedType", true));
            this.bedTypeTextBox1.Location = new System.Drawing.Point(200, 191);
            this.bedTypeTextBox1.Name = "bedTypeTextBox1";
            this.bedTypeTextBox1.Size = new System.Drawing.Size(200, 20);
            this.bedTypeTextBox1.TabIndex = 28;
            // 
            // weekendRateLabel1
            // 
            weekendRateLabel1.AutoSize = true;
            weekendRateLabel1.Location = new System.Drawing.Point(92, 220);
            weekendRateLabel1.Name = "weekendRateLabel1";
            weekendRateLabel1.Size = new System.Drawing.Size(83, 13);
            weekendRateLabel1.TabIndex = 29;
            weekendRateLabel1.Text = "Weekend Rate:";
            // 
            // weekendRateTextBox1
            // 
            this.weekendRateTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "WeekendRate", true));
            this.weekendRateTextBox1.Location = new System.Drawing.Point(200, 217);
            this.weekendRateTextBox1.Name = "weekendRateTextBox1";
            this.weekendRateTextBox1.Size = new System.Drawing.Size(200, 20);
            this.weekendRateTextBox1.TabIndex = 30;
            // 
            // weekdayRateLabel1
            // 
            weekdayRateLabel1.AutoSize = true;
            weekdayRateLabel1.Location = new System.Drawing.Point(92, 246);
            weekdayRateLabel1.Name = "weekdayRateLabel1";
            weekdayRateLabel1.Size = new System.Drawing.Size(82, 13);
            weekdayRateLabel1.TabIndex = 31;
            weekdayRateLabel1.Text = "Weekday Rate:";
            // 
            // weekdayRateTextBox1
            // 
            this.weekdayRateTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "WeekdayRate", true));
            this.weekdayRateTextBox1.Location = new System.Drawing.Point(200, 243);
            this.weekdayRateTextBox1.Name = "weekdayRateTextBox1";
            this.weekdayRateTextBox1.Size = new System.Drawing.Size(200, 20);
            this.weekdayRateTextBox1.TabIndex = 32;
            // 
            // guestLabel
            // 
            guestLabel.AutoSize = true;
            guestLabel.Location = new System.Drawing.Point(92, 272);
            guestLabel.Name = "guestLabel";
            guestLabel.Size = new System.Drawing.Size(38, 13);
            guestLabel.TabIndex = 33;
            guestLabel.Text = "Guest:";
            // 
            // guestTextBox
            // 
            this.guestTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Guest", true));
            this.guestTextBox.Location = new System.Drawing.Point(200, 269);
            this.guestTextBox.Name = "guestTextBox";
            this.guestTextBox.Size = new System.Drawing.Size(200, 20);
            this.guestTextBox.TabIndex = 34;
            // 
            // departureLabel
            // 
            departureLabel.AutoSize = true;
            departureLabel.Location = new System.Drawing.Point(92, 299);
            departureLabel.Name = "departureLabel";
            departureLabel.Size = new System.Drawing.Size(57, 13);
            departureLabel.TabIndex = 35;
            departureLabel.Text = "Departure:";
            // 
            // departureDateTimePicker
            // 
            this.departureDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.roomsBindingSource, "Departure", true));
            this.departureDateTimePicker.Location = new System.Drawing.Point(200, 295);
            this.departureDateTimePicker.Name = "departureDateTimePicker";
            this.departureDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.departureDateTimePicker.TabIndex = 36;
            // 
            // arrivalLabel
            // 
            arrivalLabel.AutoSize = true;
            arrivalLabel.Location = new System.Drawing.Point(92, 325);
            arrivalLabel.Name = "arrivalLabel";
            arrivalLabel.Size = new System.Drawing.Size(39, 13);
            arrivalLabel.TabIndex = 37;
            arrivalLabel.Text = "Arrival:";
            // 
            // arrivalDateTimePicker
            // 
            this.arrivalDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.roomsBindingSource, "Arrival", true));
            this.arrivalDateTimePicker.Location = new System.Drawing.Point(200, 321);
            this.arrivalDateTimePicker.Name = "arrivalDateTimePicker";
            this.arrivalDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.arrivalDateTimePicker.TabIndex = 38;
            // 
            // creditCardNumberLabel
            // 
            creditCardNumberLabel.AutoSize = true;
            creditCardNumberLabel.Location = new System.Drawing.Point(92, 350);
            creditCardNumberLabel.Name = "creditCardNumberLabel";
            creditCardNumberLabel.Size = new System.Drawing.Size(102, 13);
            creditCardNumberLabel.TabIndex = 39;
            creditCardNumberLabel.Text = "Credit Card Number:";
            // 
            // creditCardNumberTextBox
            // 
            this.creditCardNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "CreditCardNumber", true));
            this.creditCardNumberTextBox.Location = new System.Drawing.Point(200, 347);
            this.creditCardNumberTextBox.Name = "creditCardNumberTextBox";
            this.creditCardNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.creditCardNumberTextBox.TabIndex = 40;
            // 
            // cardLabel
            // 
            cardLabel.AutoSize = true;
            cardLabel.Location = new System.Drawing.Point(92, 376);
            cardLabel.Name = "cardLabel";
            cardLabel.Size = new System.Drawing.Size(32, 13);
            cardLabel.TabIndex = 41;
            cardLabel.Text = "Card:";
            // 
            // cardTextBox
            // 
            this.cardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Card", true));
            this.cardTextBox.Location = new System.Drawing.Point(200, 373);
            this.cardTextBox.Name = "cardTextBox";
            this.cardTextBox.Size = new System.Drawing.Size(200, 20);
            this.cardTextBox.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 463);
            this.Controls.Add(roomLabel1);
            this.Controls.Add(this.roomTextBox1);
            this.Controls.Add(bedCodeLabel1);
            this.Controls.Add(this.bedCodeTextBox1);
            this.Controls.Add(jacuzziLabel1);
            this.Controls.Add(this.jacuzziCheckBox1);
            this.Controls.Add(private_AccessLabel1);
            this.Controls.Add(this.private_AccessCheckBox1);
            this.Controls.Add(fireplaceLabel1);
            this.Controls.Add(this.fireplaceCheckBox1);
            this.Controls.Add(bedTypeLabel1);
            this.Controls.Add(this.bedTypeTextBox1);
            this.Controls.Add(weekendRateLabel1);
            this.Controls.Add(this.weekendRateTextBox1);
            this.Controls.Add(weekdayRateLabel1);
            this.Controls.Add(this.weekdayRateTextBox1);
            this.Controls.Add(guestLabel);
            this.Controls.Add(this.guestTextBox);
            this.Controls.Add(departureLabel);
            this.Controls.Add(this.departureDateTimePicker);
            this.Controls.Add(arrivalLabel);
            this.Controls.Add(this.arrivalDateTimePicker);
            this.Controls.Add(creditCardNumberLabel);
            this.Controls.Add(this.creditCardNumberTextBox);
            this.Controls.Add(cardLabel);
            this.Controls.Add(this.cardTextBox);
            this.Controls.Add(this.roomsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cottages2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingNavigator)).EndInit();
            this.roomsBindingNavigator.ResumeLayout(false);
            this.roomsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cottages2DataSet cottages2DataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private Cottages2DataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private Cottages2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator roomsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton roomsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox roomTextBox1;
        private System.Windows.Forms.TextBox bedCodeTextBox1;
        private System.Windows.Forms.CheckBox jacuzziCheckBox1;
        private System.Windows.Forms.CheckBox private_AccessCheckBox1;
        private System.Windows.Forms.CheckBox fireplaceCheckBox1;
        private System.Windows.Forms.TextBox bedTypeTextBox1;
        private System.Windows.Forms.TextBox weekendRateTextBox1;
        private System.Windows.Forms.TextBox weekdayRateTextBox1;
        private System.Windows.Forms.TextBox guestTextBox;
        private System.Windows.Forms.DateTimePicker departureDateTimePicker;
        private System.Windows.Forms.DateTimePicker arrivalDateTimePicker;
        private System.Windows.Forms.TextBox creditCardNumberTextBox;
        private System.Windows.Forms.TextBox cardTextBox;





    }
}

