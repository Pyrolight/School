/*
 * Program:     EX1210 - Exercise 12.10
 * Programmer:  Theresa Berry
 * Date:        August 2009
 * Description: Display the selections for the sandwich.
 * Form:       DisplayForm
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
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            // Display the information from the sandwich class.

            nameLabel.Text = Sandwich.Name;
            breadLabel.Text = Sandwich.Bread;
            cheeseLabel.Text = Sandwich.Cheese;
            condimentsLabel.Text = Sandwich.Condiments;
            meatLabel.Text = Sandwich.Meat;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Close this form.

            this.Close();
        }
    }
}