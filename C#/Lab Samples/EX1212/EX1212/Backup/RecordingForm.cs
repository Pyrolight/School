/*
 *Project:          EX1212 - Exercise 12.12
 *Programmer:       Theresa Berry
 *Date:             August 2009
 *Description:      Modification of Exercise 3.2
 *                  Calculate charges for a group to use the recording studio.
 *                  Display summary information as more groups use the studio.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EX1212
{
    public partial class RecordingForm : Form
        {  
       
        public RecordingForm()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int minutesUsedInteger;
            try
            {
                // Convert time if input is numeric
                minutesUsedInteger = int.Parse(timeTextBox.Text);

                Charges groupCharges = new Charges(minutesUsedInteger);

                // Display the calculated results.
                currentTextBox.Text = groupCharges.RentalCharge.ToString("C");
                numberTextBox.Text = groupCharges.GroupCount.ToString("N0");
                averageTextBox.Text = groupCharges.Average.ToString("C");
                chargesTextBox.Text = groupCharges.RentalChargesAllGroups.ToString("C");
            }
            catch (FormatException)
            {
                // Handle the number of minutes
                MessageBox.Show("Number of minutes must be numeric.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                timeTextBox.Focus();
                timeTextBox.SelectAll();
            }
            catch (Exception theException)
            {
                MessageBox.Show("Error: " + theException.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the form

            timeTextBox.Clear();
            currentTextBox.Clear();
            nameTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // End the program

            this.Close();
        }
    }
}