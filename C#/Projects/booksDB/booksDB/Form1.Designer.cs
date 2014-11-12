namespace booksDB
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
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label copyrightDateLabel;
            System.Windows.Forms.Label authorLastLabel;
            System.Windows.Forms.Label authorFirstLabel;
            System.Windows.Forms.Label pagesLabel;
            System.Windows.Forms.Label publisherLabel;
            System.Windows.Forms.Label courseNumberLabel;
            this.booksDataSet = new booksDB.BooksDataSet();
            this.bookTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableTableAdapter = new booksDB.BooksDataSetTableAdapters.BookTableTableAdapter();
            this.tableAdapterManager = new booksDB.BooksDataSetTableAdapters.TableAdapterManager();
            this.bookTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bookTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.copyrightDateTextBox = new System.Windows.Forms.TextBox();
            this.authorLastTextBox = new System.Windows.Forms.TextBox();
            this.authorFirstTextBox = new System.Windows.Forms.TextBox();
            this.pagesTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.courseNumberTextBox = new System.Windows.Forms.TextBox();
            iSBNLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            copyrightDateLabel = new System.Windows.Forms.Label();
            authorLastLabel = new System.Windows.Forms.Label();
            authorFirstLabel = new System.Windows.Forms.Label();
            pagesLabel = new System.Windows.Forms.Label();
            publisherLabel = new System.Windows.Forms.Label();
            courseNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTableBindingNavigator)).BeginInit();
            this.bookTableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "BooksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableBindingSource
            // 
            this.bookTableBindingSource.DataMember = "BookTable";
            this.bookTableBindingSource.DataSource = this.booksDataSet;
            // 
            // bookTableTableAdapter
            // 
            this.bookTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableTableAdapter = this.bookTableTableAdapter;
            this.tableAdapterManager.CourseBookTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = booksDB.BooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookTableBindingNavigator
            // 
            this.bookTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bookTableBindingNavigator.BindingSource = this.bookTableBindingSource;
            this.bookTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bookTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bookTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bookTableBindingNavigatorSaveItem});
            this.bookTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bookTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bookTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bookTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bookTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bookTableBindingNavigator.Name = "bookTableBindingNavigator";
            this.bookTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bookTableBindingNavigator.Size = new System.Drawing.Size(348, 25);
            this.bookTableBindingNavigator.TabIndex = 0;
            this.bookTableBindingNavigator.Text = "bindingNavigator1";
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
            // bookTableBindingNavigatorSaveItem
            // 
            this.bookTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bookTableBindingNavigatorSaveItem.Image")));
            this.bookTableBindingNavigatorSaveItem.Name = "bookTableBindingNavigatorSaveItem";
            this.bookTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.bookTableBindingNavigatorSaveItem.Text = "Save Data";
            this.bookTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.bookTableBindingNavigatorSaveItem_Click_1);
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(55, 85);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(35, 13);
            iSBNLabel.TabIndex = 1;
            iSBNLabel.Text = "ISBN:";
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookTableBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(144, 82);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(100, 20);
            this.iSBNTextBox.TabIndex = 2;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(55, 111);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookTableBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(144, 108);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 4;
            // 
            // copyrightDateLabel
            // 
            copyrightDateLabel.AutoSize = true;
            copyrightDateLabel.Location = new System.Drawing.Point(55, 137);
            copyrightDateLabel.Name = "copyrightDateLabel";
            copyrightDateLabel.Size = new System.Drawing.Size(80, 13);
            copyrightDateLabel.TabIndex = 5;
            copyrightDateLabel.Text = "Copyright Date:";
            // 
            // copyrightDateTextBox
            // 
            this.copyrightDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookTableBindingSource, "CopyrightDate", true));
            this.copyrightDateTextBox.Location = new System.Drawing.Point(144, 134);
            this.copyrightDateTextBox.Name = "copyrightDateTextBox";
            this.copyrightDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.copyrightDateTextBox.TabIndex = 6;
            // 
            // authorLastLabel
            // 
            authorLastLabel.AutoSize = true;
            authorLastLabel.Location = new System.Drawing.Point(55, 163);
            authorLastLabel.Name = "authorLastLabel";
            authorLastLabel.Size = new System.Drawing.Size(64, 13);
            authorLastLabel.TabIndex = 7;
            authorLastLabel.Text = "Author Last:";
            // 
            // authorLastTextBox
            // 
            this.authorLastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookTableBindingSource, "AuthorLast", true));
            this.authorLastTextBox.Location = new System.Drawing.Point(144, 160);
            this.authorLastTextBox.Name = "authorLastTextBox";
            this.authorLastTextBox.Size = new System.Drawing.Size(100, 20);
            this.authorLastTextBox.TabIndex = 8;
            // 
            // authorFirstLabel
            // 
            authorFirstLabel.AutoSize = true;
            authorFirstLabel.Location = new System.Drawing.Point(55, 189);
            authorFirstLabel.Name = "authorFirstLabel";
            authorFirstLabel.Size = new System.Drawing.Size(63, 13);
            authorFirstLabel.TabIndex = 9;
            authorFirstLabel.Text = "Author First:";
            // 
            // authorFirstTextBox
            // 
            this.authorFirstTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookTableBindingSource, "AuthorFirst", true));
            this.authorFirstTextBox.Location = new System.Drawing.Point(144, 186);
            this.authorFirstTextBox.Name = "authorFirstTextBox";
            this.authorFirstTextBox.Size = new System.Drawing.Size(100, 20);
            this.authorFirstTextBox.TabIndex = 10;
            // 
            // pagesLabel
            // 
            pagesLabel.AutoSize = true;
            pagesLabel.Location = new System.Drawing.Point(55, 215);
            pagesLabel.Name = "pagesLabel";
            pagesLabel.Size = new System.Drawing.Size(40, 13);
            pagesLabel.TabIndex = 11;
            pagesLabel.Text = "Pages:";
            // 
            // pagesTextBox
            // 
            this.pagesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookTableBindingSource, "Pages", true));
            this.pagesTextBox.Location = new System.Drawing.Point(144, 212);
            this.pagesTextBox.Name = "pagesTextBox";
            this.pagesTextBox.Size = new System.Drawing.Size(100, 20);
            this.pagesTextBox.TabIndex = 12;
            // 
            // publisherLabel
            // 
            publisherLabel.AutoSize = true;
            publisherLabel.Location = new System.Drawing.Point(55, 241);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new System.Drawing.Size(53, 13);
            publisherLabel.TabIndex = 13;
            publisherLabel.Text = "Publisher:";
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookTableBindingSource, "Publisher", true));
            this.publisherTextBox.Location = new System.Drawing.Point(144, 238);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(100, 20);
            this.publisherTextBox.TabIndex = 14;
            // 
            // courseNumberLabel
            // 
            courseNumberLabel.AutoSize = true;
            courseNumberLabel.Location = new System.Drawing.Point(55, 267);
            courseNumberLabel.Name = "courseNumberLabel";
            courseNumberLabel.Size = new System.Drawing.Size(83, 13);
            courseNumberLabel.TabIndex = 15;
            courseNumberLabel.Text = "Course Number:";
            // 
            // courseNumberTextBox
            // 
            this.courseNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookTableBindingSource, "CourseNumber", true));
            this.courseNumberTextBox.Location = new System.Drawing.Point(144, 264);
            this.courseNumberTextBox.Name = "courseNumberTextBox";
            this.courseNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseNumberTextBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 412);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.iSBNTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(copyrightDateLabel);
            this.Controls.Add(this.copyrightDateTextBox);
            this.Controls.Add(authorLastLabel);
            this.Controls.Add(this.authorLastTextBox);
            this.Controls.Add(authorFirstLabel);
            this.Controls.Add(this.authorFirstTextBox);
            this.Controls.Add(pagesLabel);
            this.Controls.Add(this.pagesTextBox);
            this.Controls.Add(publisherLabel);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(courseNumberLabel);
            this.Controls.Add(this.courseNumberTextBox);
            this.Controls.Add(this.bookTableBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTableBindingNavigator)).EndInit();
            this.bookTableBindingNavigator.ResumeLayout(false);
            this.bookTableBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BooksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource bookTableBindingSource;
        private BooksDataSetTableAdapters.BookTableTableAdapter bookTableTableAdapter;
        private BooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bookTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bookTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox copyrightDateTextBox;
        private System.Windows.Forms.TextBox authorLastTextBox;
        private System.Windows.Forms.TextBox authorFirstTextBox;
        private System.Windows.Forms.TextBox pagesTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox courseNumberTextBox;

    }
}

