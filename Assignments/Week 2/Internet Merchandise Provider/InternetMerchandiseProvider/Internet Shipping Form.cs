/*
 * Program name:    Internet Merchandise Provider
 * Author:          Michael Fesser
 * Version: #       1.0, Sept 20, 2014
 * Description:     Internet Merchandise Provider requires a shipping form that will
 *                  calculate the total shipping costs for different numbers of items.  
 *                  These costs decrease as the number of items increase.  There are four 
 *                  pricing categories:
 *                  
 *                  1. $2.99 for the first item.
 *                  2. $1.99 for each of items 2 through 5.
 *                  3. $1.49 for each of items 6 through 14.
 *                  4. $0.99 for each item over 15.
 * Dependencies:    None
 * Change History:  2014.09.20 Original version by MF
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetMerchandiseProvider
{
   
    public partial class InternetShippingForm : Form
    {
        // The following variables are used for the shipping costs for each item based on the number of items purchased.
        private decimal firstItemShipping = 2.99m;
        private decimal twoToFiveItemsShipping = 1.99m;
        private decimal sixToFourteenItemsShipping = 1.49m;
        private decimal fifteenPlusItemsShipping = 0.99m;

        public InternetShippingForm()
        {
            InitializeComponent();
        }

        /*
         * Function name:   CalculateButton_Click
         * Author:          Michael Fesser
         * Version: #       1.0, Sept 20, 2014
         * Description:     This function will on the button click do all the calculations
         *                  needed to calculate the shipping charges. 
         * Inputs:          Parameters - numberOfItems   
         * Outputs:         UI - Error reports. Total shipping costs.
         * Return value:    None.
         * Change History:  2014.09.20 Original version by MF
         */
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int numberOfItems;
            decimal totalPrice = 0.00m;
            // The following variables are used to remove the numberOfItems for each category of shipping charges from the total
            // number of items.
            int lessOneItem = 1;
            int lessFiveItems = 5;
            int lessFourteenItems = 14;
            // The following variables are used to help calculate the max shipping costs for each category of shipping charges.
            int itemsTwoToFive = 4;
            int itemsSixToFourteen = 9;
            // Used to display error messages to the user.
            string messageString;

            try
            {
                // Get the number of items from the user and parse it to an int.
                numberOfItems = int.Parse(NumberOfItemsTextBox.Text);

                /* This set of conditional statements will calculate the total price of the shipping charges.  
                 * This is done by finding the number of items in a category, multiplying by the shipping
                 * charges in that category and adding any shipping charges that would have accumulate from any previous 
                 * shipping categories.
                 * 
                */
                if (numberOfItems == 1)
                {
                    totalPrice = firstItemShipping;
                }
                // Two to five items.
                else if (numberOfItems >= 2 && numberOfItems <= 5)
                {
                    totalPrice = (numberOfItems - lessOneItem) * twoToFiveItemsShipping + firstItemShipping;
                }
                // Six to fourteen items.
                else if (numberOfItems >= 6 && numberOfItems <= 14)
                {
                    totalPrice = (numberOfItems - lessFiveItems) * sixToFourteenItemsShipping + (itemsTwoToFive * twoToFiveItemsShipping) 
                        + firstItemShipping;
                }
                // More then fifteen items.
                else if (numberOfItems >= 15)
                {
                    totalPrice = (numberOfItems - lessFourteenItems) * fifteenPlusItemsShipping + (itemsSixToFourteen * sixToFourteenItemsShipping) 
                        + (itemsTwoToFive * twoToFiveItemsShipping) + firstItemShipping;
                }
                // Display the shipping costs.
                TotalShippingCostTextBox.Text = totalPrice.ToString("C");
            }
            catch (FormatException)
            {
                // Handle a number format exception.
                MessageBox.Show("Number of items must be numeric.",
                   "Data Entry Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                NumberOfItemsTextBox.Clear();
                NumberOfItemsTextBox.Focus();
            }
            catch (Exception theException)
            {
                // Handle all other exceptions.     
                messageString = "Error: " + theException.Message;
                MessageBox.Show(messageString, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                NumberOfItemsTextBox.Clear();
            }
        }

        /*
         * Function name:   ClearButton_Click
         * Author:          Michael Fesser
         * Version: #       1.0, Sept 20, 2014
         * Description:     This function clears the form fields.
         * Inputs:          None.   
         * Outputs:         None.
         * Return value:    None.
         * Change History:  2014.09.20 Original version by MF
         */
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear the form.
            TotalShippingCostTextBox.Clear();
            NumberOfItemsTextBox.Clear();
            NumberOfItemsTextBox.Focus();
        }

        /*
         * Function name:   CloseButton_Click
         * Author:          Michael Fesser
         * Version: #       1.0, Sept 20, 2014
         * Description:     This function closes the form.
         * Inputs:          None.   
         * Outputs:         None.
         * Return value:    None.
         * Change History:  2014.09.20 Original version by MF
         */
        private void CloseButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
