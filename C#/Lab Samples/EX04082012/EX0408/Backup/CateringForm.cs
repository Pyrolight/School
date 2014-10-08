/*
 * Project:         EX0408 - Exercise 4.8
 * Programmer:      Theresa Berry
 * Date:            August 2009
 * Description:     Catherine's Catering offers a variety of choices
 *                  for your dining experience.  This projects calculates
 *                  the amount due for a single event.  The summary displays
 *                  the total number of events and the total dollar amount for all events.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EX0408
{
    public partial class CateringForm : Form
    {
        const decimal PRIME_RIB_Decimal = 25.95m;
        const decimal CHICKEN_Decimal = 18.95m;
        const decimal PASTA_Decimal = 12.95m;
        const decimal OPEN_BAR_Decimal = 25m;
        const decimal WINE_Decimal = 8m;
        private int totalEventsInteger;
        private decimal totalDollarAmountDecimal;

        public CateringForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Calculate the amount due for catering this event.
            int numberGuestsInteger;
            decimal mealCostDecimal, amountDueDecimal;
            string messageString;
            decimal extraDecimal = 0;
            
            try
            {
                numberGuestsInteger = int.Parse(guestTextBox.Text);

                // Determine which menu was chosen.
                if (nothingSelectedRadioButton.Checked == false)
                {
                    if (primeRibRadioButton.Checked)
                    {
                        mealCostDecimal = PRIME_RIB_Decimal;
                    }
                    else if (chickenRadioButton.Checked)
                    {
                        mealCostDecimal = CHICKEN_Decimal;
                    }
                    else
                    {
                        mealCostDecimal = PASTA_Decimal;
                    }

                    if (openBarCheckBox.Checked)
                    {
                        extraDecimal = OPEN_BAR_Decimal;
                    }

                    if (wineCheckBox.Checked)
                    {
                        extraDecimal += WINE_Decimal;
                    }
                    // Calculate and display the amount due for this event.
                    amountDueDecimal = 
                        numberGuestsInteger * (mealCostDecimal + extraDecimal);
                    amountDueTextBox.Text = amountDueDecimal.ToString("C");

                    // Calculate the total for all events.
                    totalEventsInteger ++;
                    totalDollarAmountDecimal += amountDueDecimal;
                }
                else
                {
                    MessageBox.Show("Please make a menu selection.", "Input Needed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Number of guests must be numeric.",
                   "Data Entry Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                guestTextBox.Focus();
                guestTextBox.SelectAll();
            }
            catch (Exception theException)
            {
                // Handle all other exceptions.
                messageString = "Error: " + theException.Message;
                MessageBox.Show(messageString, "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the form.

            nothingSelectedRadioButton.Checked = true;
            openBarCheckBox.Checked = false;
            wineCheckBox.Checked = false;
            amountDueTextBox.Clear();
            guestTextBox.Clear();
            guestTextBox.Focus();
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            // Display the summary information.
            DialogResult responseDialogResult;

            if (totalEventsInteger > 0)
            {
                // Concatenate the message string.
                string messageString = "Total Number of Events:  "
                    + totalEventsInteger.ToString()
                    + "\n\n"
                    + "Total Dollar Amount:  " + totalDollarAmountDecimal.ToString("C")
                    + "\n\n"
                    + "\n\n"
                    + "Would you like to clear the summary information?";
                responseDialogResult = MessageBox.Show(messageString, 
                    "Catherine's Catering Summary", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (responseDialogResult == DialogResult.Yes)  // User said Yes.
                {
                    //Reset the summary variables.
                    totalEventsInteger = 0;
                    totalDollarAmountDecimal = 0;
                    clearButton_Click(sender, e);           // Clear the screen fields.
                }
            }
            else
            {
                string messageString = "No sales data to summarize.";
                MessageBox.Show(messageString, "Catherine's Catering Summary",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
           // End the project.

            this.Close();
        }
    }
}