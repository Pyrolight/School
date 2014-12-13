namespace RnrBooks
{
    partial class RnrBooksForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label publisherLabel;
            System.Windows.Forms.Label subject_CodeLabel;
            System.Windows.Forms.Label shelf_LocationLabel;
            System.Windows.Forms.Label fictionLabel;
            this.titleListingCB = new System.Windows.Forms.ComboBox();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rnrBooksDataSet = new RnrBooks.RnrBooksDataSet();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.booksTableAdapter = new RnrBooks.RnrBooksDataSetTableAdapters.BooksTableAdapter();
            this.tableAdapterManager = new RnrBooks.RnrBooksDataSetTableAdapters.TableAdapterManager();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.subject_CodeTextBox = new System.Windows.Forms.TextBox();
            this.shelf_LocationTextBox = new System.Windows.Forms.TextBox();
            this.fictionCheckBox = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            publisherLabel = new System.Windows.Forms.Label();
            subject_CodeLabel = new System.Windows.Forms.Label();
            shelf_LocationLabel = new System.Windows.Forms.Label();
            fictionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rnrBooksDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(42, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(30, 13);
            label1.TabIndex = 55;
            label1.Text = "Title:";
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(42, 81);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(35, 13);
            iSBNLabel.TabIndex = 56;
            iSBNLabel.Text = "ISBN:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(42, 107);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 57;
            titleLabel.Text = "Title:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(42, 133);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(41, 13);
            authorLabel.TabIndex = 58;
            authorLabel.Text = "Author:";
            // 
            // publisherLabel
            // 
            publisherLabel.AutoSize = true;
            publisherLabel.Location = new System.Drawing.Point(42, 159);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new System.Drawing.Size(53, 13);
            publisherLabel.TabIndex = 59;
            publisherLabel.Text = "Publisher:";
            // 
            // subject_CodeLabel
            // 
            subject_CodeLabel.AutoSize = true;
            subject_CodeLabel.Location = new System.Drawing.Point(42, 185);
            subject_CodeLabel.Name = "subject_CodeLabel";
            subject_CodeLabel.Size = new System.Drawing.Size(74, 13);
            subject_CodeLabel.TabIndex = 60;
            subject_CodeLabel.Text = "Subject Code:";
            // 
            // shelf_LocationLabel
            // 
            shelf_LocationLabel.AutoSize = true;
            shelf_LocationLabel.Location = new System.Drawing.Point(42, 211);
            shelf_LocationLabel.Name = "shelf_LocationLabel";
            shelf_LocationLabel.Size = new System.Drawing.Size(78, 13);
            shelf_LocationLabel.TabIndex = 61;
            shelf_LocationLabel.Text = "Shelf Location:";
            // 
            // fictionLabel
            // 
            fictionLabel.AutoSize = true;
            fictionLabel.Location = new System.Drawing.Point(42, 239);
            fictionLabel.Name = "fictionLabel";
            fictionLabel.Size = new System.Drawing.Size(41, 13);
            fictionLabel.TabIndex = 62;
            fictionLabel.Text = "Fiction:";
            // 
            // titleListingCB
            // 
            this.titleListingCB.DataSource = this.booksBindingSource;
            this.titleListingCB.DisplayMember = "Title";
            this.titleListingCB.FormattingEnabled = true;
            this.titleListingCB.Location = new System.Drawing.Point(126, 45);
            this.titleListingCB.Name = "titleListingCB";
            this.titleListingCB.Size = new System.Drawing.Size(248, 21);
            this.titleListingCB.TabIndex = 0;
            this.titleListingCB.ValueMember = "ISBN";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.rnrBooksDataSet;
            // 
            // rnrBooksDataSet
            // 
            this.rnrBooksDataSet.DataSetName = "RnrBooksDataSet";
            this.rnrBooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(48, 288);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(129, 288);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 9;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(210, 288);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Enabled = false;
            this.confirmButton.Location = new System.Drawing.Point(48, 288);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Visible = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(292, 288);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(75, 23);
            this.reloadButton.TabIndex = 11;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = this.booksTableAdapter;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RnrBooks.RnrBooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(126, 78);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(248, 20);
            this.iSBNTextBox.TabIndex = 1;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(126, 104);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(248, 20);
            this.titleTextBox.TabIndex = 2;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Author", true));
            this.authorTextBox.Location = new System.Drawing.Point(126, 130);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(248, 20);
            this.authorTextBox.TabIndex = 3;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Publisher", true));
            this.publisherTextBox.Location = new System.Drawing.Point(126, 156);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(248, 20);
            this.publisherTextBox.TabIndex = 4;
            // 
            // subject_CodeTextBox
            // 
            this.subject_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Subject_Code", true));
            this.subject_CodeTextBox.Location = new System.Drawing.Point(126, 182);
            this.subject_CodeTextBox.Name = "subject_CodeTextBox";
            this.subject_CodeTextBox.Size = new System.Drawing.Size(248, 20);
            this.subject_CodeTextBox.TabIndex = 5;
            // 
            // shelf_LocationTextBox
            // 
            this.shelf_LocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Shelf_Location", true));
            this.shelf_LocationTextBox.Location = new System.Drawing.Point(126, 208);
            this.shelf_LocationTextBox.Name = "shelf_LocationTextBox";
            this.shelf_LocationTextBox.Size = new System.Drawing.Size(248, 20);
            this.shelf_LocationTextBox.TabIndex = 6;
            // 
            // fictionCheckBox
            // 
            this.fictionCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.booksBindingSource, "Fiction", true));
            this.fictionCheckBox.Location = new System.Drawing.Point(126, 234);
            this.fictionCheckBox.Name = "fictionCheckBox";
            this.fictionCheckBox.Size = new System.Drawing.Size(232, 24);
            this.fictionCheckBox.TabIndex = 7;
            this.fictionCheckBox.UseVisualStyleBackColor = true;
            // 
            // rnrBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 359);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.iSBNTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(publisherLabel);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(subject_CodeLabel);
            this.Controls.Add(this.subject_CodeTextBox);
            this.Controls.Add(shelf_LocationLabel);
            this.Controls.Add(this.shelf_LocationTextBox);
            this.Controls.Add(fictionLabel);
            this.Controls.Add(this.fictionCheckBox);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(label1);
            this.Controls.Add(this.titleListingCB);
            this.Name = "rnrBooksForm";
            this.Text = "RnrBooks";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rnrBooksDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox titleListingCB;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button reloadButton;
        private RnrBooksDataSet rnrBooksDataSet;
        private RnrBooksDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private RnrBooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox subject_CodeTextBox;
        private System.Windows.Forms.TextBox shelf_LocationTextBox;
        private System.Windows.Forms.CheckBox fictionCheckBox;
    }
}

