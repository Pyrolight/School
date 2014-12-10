/*
 * Program Name:   	Ch05HandsOn
 * Programmer:     	Bradley/Millspaugh
 * Date:           	June 2009
 * 
 * Description:    		This project calculates the amount due
 *                      based on the customer selection
 *                      and accumulates summary data for the day.
 *                      Includes menus, common dialog boxes, a
 *                      switch statement, and general methods.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ch05HandsOn
{
    public partial class JuiceBarForm : Form
    {
        // Declare class variables.
        decimal itemSizeDecimal, totalOrderDecimal, totalSalesDecimal;
        decimal drinkDecimal;
        int drinksInteger, ordersInteger;

        public JuiceBarForm()
        {
            InitializeComponent();
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            // Add the current item price and quantity to the order.

            if (noSizeRadioButton.Checked)
            {
                MessageBox.Show("You must select a drink and size.", 
                    "Missing required entry");
            }
            else
            {
                try
                {
                    int quantityInteger = int.Parse(quantityTextBox.Text);
                    if (quantityInteger > 0)
                    {
                        drinksInteger += quantityInteger;
                        totalOrderDecimal += drinkDecimal * quantityInteger;
                        clearForNextItem();
                        orderCompleteButton.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a quantity", 
                            "Missing Required Entry");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Quantity", "Data Entry Error");
                    quantityTextBox.Focus();
                    quantityTextBox.SelectAll();
                }
            }
        }

        private void orderCompletebutton_Click(object sender, EventArgs e)
        {
            // Order is complete, add to summary and clear order.


            // Check if the last item was added to the total.
            if (itemPriceTextBox.Text != "")
            {
                DialogResult responseDialogResult;
                string messageString = 
                    "Current item not recorded. Add to order?";
                responseDialogResult = MessageBox.Show(messageString,
                    "Verify Last Drink Purchase", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (responseDialogResult == DialogResult.Yes)
                {
                    addToOrderButton_Click(sender, e);
                }
            }
            // Display amount due.
            string dueString = "Amount Due " + totalOrderDecimal.ToString("C");
            MessageBox.Show(dueString, "Order Complete");

            // Add to summary totals.
            ordersInteger++;
            totalSalesDecimal += totalOrderDecimal;

            // Reset all for new order.
            summaryButton.Enabled = true;
            summaryToolStripMenuItem.Enabled = true;
            orderCompleteButton.Enabled = false;
            orderCompleteToolStripMenuItem.Enabled = false;
            totalOrderDecimal = 0m;
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            // Display the summary information in a message box.


            string summaryString = "Drinks Sold:      " 
                        + drinksInteger.ToString()
                        + "\n\n" + "Number of Orders: " 
                        + ordersInteger.ToString()
                        + "\n\n" + "Total Sales:      " 
                        + totalSalesDecimal.ToString("C");
            MessageBox.Show(summaryString, 
                        "Juice Bar Sales Summary", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // End the application.

            this.Close();
        }

        private void twelveOunceRadioButton_CheckedChanged(object sender, 
            EventArgs e)
        {
            // Calculate and display the price for the selected item. 
            // Handles all check boxes and radio buttons.

            // Cast the sender to a RadioButton type.
            RadioButton selectedSizeRadioButton = (RadioButton)sender;

            switch (selectedSizeRadioButton.Name)
            {
                case "twelveOunceRadioButton":
                    itemSizeDecimal = 3m;
                    break;
                case "sixteenOunceRadioButton":
                    itemSizeDecimal = 3.5m;
                    break;
                case "twentyOunceRadioButton":
                    itemSizeDecimal = 4m;
                    break;
            }
            drinkDecimal = itemSizeDecimal + findExtrasPrice();
            itemPriceTextBox.Text = drinkDecimal.ToString("C");
        }

        private void clearForNextItem()
        {
            // Clear radio buttons, check boxes, text boxes.

            noSizeRadioButton.Checked = true;
            fruitJuiceRadioButton.Checked = true;
            vitaminPackCheckBox.Checked = false;
            energyBoosterCheckBox.Checked = false;
            ladiesCheckBox.Checked = false;
            itemPriceTextBox.Clear();
            quantityTextBox.Text = "1";
        }

        private decimal findExtrasPrice()
        {
            // Find price for additives.
            decimal extrasDecimal = 0m;

            if (vitaminPackCheckBox.Checked)
                extrasDecimal += .5m;
            if (energyBoosterCheckBox.Checked)
                extrasDecimal += .5m;
            if (ladiesCheckBox.Checked)
                extrasDecimal += .5m;

            return extrasDecimal;
        }

        private void vitaminPackCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Check price of additives and display current price.

            drinkDecimal = itemSizeDecimal + findExtrasPrice();
            itemPriceTextBox.Text = drinkDecimal.ToString("C");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display information in a message box.

            string aboutString = "Programmed by A. Programmer\nVersion 1.1";
            string captionString = "About Look Sharp Fitness Center Juice Bar Orders";
            MessageBox.Show(aboutString, captionString);
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Change the label's font.

            // Initialize the dialog box.
            fontDialog1.Font = titleLabel.Font;
            // Display the dialog box.
            fontDialog1.ShowDialog();
            // Assign the new font.
            titleLabel.Font = fontDialog1.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Change the form's ForeColor.
            // Applies to all conrols on the form that haven't had their
            //    ForeColor explicitly modified.

            // Initialize the dialog box.
            colorDialog1.Color = this.ForeColor;
            // Display the dialog box.
            colorDialog1.ShowDialog();
            // Assign the new color.
            this.ForeColor = colorDialog1.Color;
        }
    }
}