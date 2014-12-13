using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

/*
Program Name: RnrBooks
Author: Michael Fesser
Version: #1.0
Description: This programs tests basic database functionality.  It uses the TableAdapter class to Create, Read, Update, and Delete books.  There is
basic form validation and error checking against the database itself. 

Note:  The form is set up with two distinct confirmation options.  The first is the add/confirm buttons.  When the add button is clicked it clears the form
and then locks the edit and delete button while also hiding itself and making the confirm button visible and active.  The second is standard yes/no
popups for edit and delete. 
Dependencies: None.
Change History: None.
*/
namespace RnrBooks
{
    /*
    Class Name: RnrBooksForm
    Author: Michael Fesser
    Version: #1.0
    Description: This is the main class that holds the main form.  The books RnrBooks books are displayed as well all data entry is done here.
    Dependencies: None.
    Change History: None.
    */
    public partial class RnrBooksForm : Form
    {
        public RnrBooksForm()
        {
            InitializeComponent();
        }

        /*
        Method name: Form1_Load
        Version: #1.0
        Author: Michael Fesser
        Description: This method initialises the form on load.  It will load the RnrBooks database and display it to the user.
        Returns: None.
        Change History: None.
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            // Try to get the database objects to populate the form
            try
            {
                // Populate form
                this.booksTableAdapter.Fill(this.rnrBooksDataSet.Books);
            }
            // Warn the user of a database error
            catch (Exception ex)
            {
                MessageBox.Show("There is an error accessing the database, please contact the database administrator.\r\n\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
        Method name: addButton_Click
        Version: #1.0
        Author: Michael Fesser
        Description: This method initializes the form for data entry by clearing it and disabling the edit and delete buttons to avoid exceptions.
        Returns: None.
        Change History: None.
        */
        private void addButton_Click(object sender, EventArgs e)
        {
            //  Set up the form for data entry
            titleListingCB.Text = "";
            // Disable the edit button
            editButton.Enabled = false;
            // Disable the delete button
            deleteButton.Enabled = false;
            iSBNTextBox.Clear();
            titleTextBox.Clear();
            authorTextBox.Clear();
            publisherTextBox.Clear();
            subject_CodeTextBox.Clear();
            shelf_LocationTextBox.Clear();
            fictionCheckBox.Checked = false;
            // Hide the add button for data entry
            addButton.Visible = false;
            addButton.Enabled = false;
            // Show the confirmation button for data entry.
            confirmButton.Enabled = true;
            confirmButton.Visible = true;
        }

        /*
        Method name: confirmButton_Click
        Version: #1.0
        Author: Michael Fesser
        Description: This method adds the fields to the database as a new row.  It also validate the fields and checks for a database error.
        Returns: None.
        Change History: None.
        */
        private void confirmButton_Click(object sender, EventArgs e)
        {
            int error = 0;
            // Error message to be built
            string errorMessage = "";
            // Validation of fields
            if (iSBNTextBox.Text.Length == 0)
            {
                error = 1;
                errorMessage += "The ISBN must be entered";
            }
            if (titleTextBox.Text.Length == 0)
            {
                error = 1;
                errorMessage += "\r\nThe title must be entered";
            }
            if (authorTextBox.Text.Length == 0)
            {
                error = 1;
                errorMessage += "\r\nThe author must be entered";
            }
            if (publisherTextBox.Text.Length == 0)
            {
                error = 1;
                errorMessage += "\r\nThe publisher must be entered";
            }
            if (subject_CodeTextBox.Text.Length == 0)
            {
                error = 1;
                errorMessage += "\r\nThe subject code must be entered";
            }
            if (shelf_LocationTextBox.Text.Length == 0)
            {
                error = 1;
                errorMessage += "\r\nThe shelf location must be entered";
            }
            // Display message if there is a validation error and do not continue
            if (error == 1)
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (error == 0)
            {
                try
                {
                    // Create a new row in the dataset
                    DataRow newBookRow = rnrBooksDataSet.Tables["Books"].NewRow();

                    // Add the values to the columns of the new row
                    newBookRow["ISBN"] = iSBNTextBox.Text;
                    newBookRow["Title"] = titleTextBox.Text;
                    newBookRow["Author"] = authorTextBox.Text;
                    newBookRow["Publisher"] = publisherTextBox.Text;
                    newBookRow["Subject_Code"] = subject_CodeTextBox.Text;
                    newBookRow["Shelf_Location"] = shelf_LocationTextBox.Text;
                    newBookRow["Fiction"] = fictionCheckBox.Checked;

                    // Add the row to the table
                    rnrBooksDataSet.Tables["Books"].Rows.Add(newBookRow);

                    // Update the table in the database
                    this.booksTableAdapter.Update(this.rnrBooksDataSet);
                    // Update the dataset the user sees
                    this.booksTableAdapter.Fill(this.rnrBooksDataSet.Books);
                }
                // Catch exception and display relevant database error to user  
                catch (Exception ex)
                {
                    MessageBox.Show("There is an error adding the data to the database, please contact the database administrator.\r\n\r\n"
                        + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Break out of the method
                    return;
                }
                // Set the values for all the button do their default settings if no errors occurred
                editButton.Enabled = true;
                deleteButton.Enabled = true;
                addButton.Visible = true;
                addButton.Enabled = true;
                confirmButton.Visible = false;
                confirmButton.Enabled = false;
            }
        }

        /*
      Method name: confirmButton_Click
      Version: #1.0
      Author: Michael Fesser
      Description: This method edits the fields of a database row.  It also validate the fields and checks for a database error.
      Returns: None.
      Change History: None.
      */
        private void editButton_Click(object sender, EventArgs e)
        {
            int error = 0;
            // Error message to be built
            string errorMessage = "";
            // Validation of fields
            if (iSBNTextBox.Text.Length == 0)
            {
                error = 1;
                errorMessage += "The ISBN must be entered";
            }
            if (titleTextBox.Text.Length == 0)
            {
                error = 1;
                errorMessage += "\r\nThe title must be entered";
            }
            if (authorTextBox.Text.Length == 0)
            {
                error = 1;
                errorMessage += "\r\nThe author must be entered";
            }
            if (publisherTextBox.Text.Length == 0)
            {
                error = 1;
                errorMessage += "\r\nThe publisher must be entered";
            }
            if (subject_CodeTextBox.Text.Length == 0)
            {
                error = 1;
                errorMessage += "\r\nThe subject code must be entered";
            }
            if (shelf_LocationTextBox.Text.Length == 0)
            {
                error = 1;
                errorMessage += "\r\nThe shelf location must be entered";
            }
            // Display message if there is a validation error and do not continue
            if (error == 1)
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (error == 0)
            {
                try
                {
                    string message = "Are you sure that you would like to edit this record";
                    string caption = "Edit Record";
                    // Create a confirmation dialogue box for the user when they click edit.  
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        this.Validate();
                        // Update the record in data source
                        this.booksBindingSource.EndEdit();
                        // Update the record in database
                        this.booksTableAdapter.Update(this.rnrBooksDataSet);
                        // Update the dataset the user sees
                        this.booksTableAdapter.Fill(this.rnrBooksDataSet.Books);
                    }
                }
                // Catch exception and display relevant database error to user  
                catch (Exception ex)
                {
                    MessageBox.Show("There is an error editing the data in the database, please contact the database administrator.\r\n\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Are you sure that you would like to delete this record";
                string caption = "Edit Record";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Validate();
                    // Delete the item from the list
                    this.booksBindingSource.RemoveCurrent();
                    // Delete the record in data source
                    this.booksBindingSource.EndEdit();
                    // Delete the record in database
                    this.booksTableAdapter.Update(this.rnrBooksDataSet);
                    // Update the dataset the user sees
                    this.booksTableAdapter.Fill(this.rnrBooksDataSet.Books);
                }
            }
            // Catch exception and display relevant database error to user 
            catch (Exception ex)
            {
                MessageBox.Show("There is an error deleting the data in the database, please contact the database administrator.\r\n\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the values for all the button do their default settings
                addButton.Visible = true;
                addButton.Enabled = true;
                confirmButton.Visible = false;
                confirmButton.Enabled = false;
                editButton.Enabled = true;
                deleteButton.Enabled = true;
                // Update the dataset the user sees
                this.booksTableAdapter.Fill(this.rnrBooksDataSet.Books);
            }
            // Catch exception and display relevant database error to user 
            catch (Exception ex)
            {
                MessageBox.Show("There is an error accessing the database, please contact the database administrator.\r\n\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}