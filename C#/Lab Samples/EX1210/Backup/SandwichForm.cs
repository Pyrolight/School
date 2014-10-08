/*
 * Program:     EX1210 - Exercise 12.10
 * Programmer:  Theresa Berry
 * Date:        August 2009
 * Description: Includes a class for "sandwich" objects.
 *              The user's entries are sent to class and then
 *              retrieved and displayed on another form.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EX1210
{
    public partial class SandwichForm : Form
    {
        public SandwichForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Add the user's selections to the sandwich.

            Sandwich aSandwich = new Sandwich(nameTextBox.Text, meatTextBox.Text,
                breadTextBox.Text, cheeseTextBox.Text, condimentsTextBox.Text);
            clearButton_Click(sender, e);
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // Display the sandwich items on a different form.

            DisplayForm aDisplayForm = new DisplayForm();
            aDisplayForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.

            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the form

            nameTextBox.Clear();
            meatTextBox.Clear();
            cheeseTextBox.Clear();
            breadTextBox.Clear();
            condimentsTextBox.Clear();
        }
    }
}