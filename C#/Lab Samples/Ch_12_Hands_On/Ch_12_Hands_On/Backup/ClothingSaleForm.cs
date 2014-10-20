/* Program:			Ch12HandsOn
 * Programmer:		Bradley/Millspaugh
 * Date:			June 2009
 * Description:		Calculate sales price using the ClothingSale and 
 *                  MemberClothingSale classes.
 *					Main form for the Chapter 12 hands-on project.
 */

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System;
using System.Windows.Forms;
using System.IO;

namespace Ch12HandsOn
{
    public partial class ClothingSaleForm : BaseForm
    {
        public ClothingSaleForm()
        {
            InitializeComponent();
        }

        private void ClothingSaleForm_Load(object sender, EventArgs e)
        {
            // Initialize the form.

            // Hide the ok button.
            this.okButton.Visible = false;

            // Load the drop-down list.
            DialogResult responseDialogResult;
            try
            {
                StreamReader productsStreamReader = new StreamReader("Products.txt");
                string productString, priceString;
                while (productsStreamReader.Peek() != -1)
                {
                    productString = productsStreamReader.ReadLine();
                    priceString = productsStreamReader.ReadLine();
                    productIdComboBox.Items.Add(productString);
                }
                productsStreamReader.Close();
            }
            catch
            {
                responseDialogResult = MessageBox.Show("Product File not found. Run anyway?",
                    "File not Found", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (responseDialogResult == DialogResult.No)
                {
                    // Exit the project.
                    exitToolStripMenuItem_Click(e, new System.EventArgs());
                }
            }
        }

        private void calculateSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Calculate the extended price and any discount.
            decimal discountRateDecimal = 0m;

            if (productIdComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select a product number.", "Error");
            }
            else
            {
                // A product has been selected.
                // Is there a discount?
                try    // Discount rate.
                {
                    if (discountCheckBox.Checked)
                    {
                        discountRateDecimal = decimal.Parse(discountRateTextBox.Text);
                        // Check for decimal fraction.
                        if (discountRateDecimal >= 1M)
                        {
                            throw new ApplicationException();
                        }
                    }
                    try  // Quantity.
                    {
                        int quantityInteger = int.Parse(quantityTextBox.Text);
                        if (membercheckBox.Checked)
                        {
                            // Instantiate a MemberClothingSale object and set the properties.
                            MemberClothingSale aMemberClothingSale =
                                new MemberClothingSale(productIdComboBox.SelectedIndex,
                                quantityInteger, discountRateDecimal);
                            extendedPriceTextBox.Text = aMemberClothingSale.ExtendedPrice.ToString("N");
                        }
                        else
                        {

                            ClothingSale aClothingSale =
                                new ClothingSale(productIdComboBox.SelectedIndex,
                                quantityInteger, discountRateDecimal);
                            extendedPriceTextBox.Text = aClothingSale.ExtendedPrice.ToString("N");
                        }
                    }
                    catch  // Quantity.
                    {
                        MessageBox.Show("Invalid quantity", "Error");
                    }
                }
                catch  // Discount rate.
                {
                    MessageBox.Show("Invalid discount rate.", "Error");
                }
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear the controls for next entry.

            productIdComboBox.SelectedIndex = -1;
            quantityTextBox.Clear();
            discountRateTextBox.Clear();
            discountCheckBox.Checked = false;
            extendedPriceTextBox.Clear();
            productIdComboBox.Focus();
        }

        private void summaryToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // Display the sales summary form.
            SummaryForm aSummaryForm = new SummaryForm();

            // Fill the properties.

            aSummaryForm.SalesTotal = ClothingSale.SalesTotal;
            aSummaryForm.SalesCount = ClothingSale.SalesCount;
            aSummaryForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the project.

            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display the about form.
            AboutForm anAboutForm = new AboutForm();

            anAboutForm.ShowDialog();
        }

        private void discountCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Display input field for discount rate if checked.

            if (discountCheckBox.Checked)
            {
                discountRateTextBox.Visible = true;
                discountRateLabel.Visible = true;
                discountRateTextBox.Focus();
            }
            else
            {
                discountRateTextBox.Visible = false;
                discountRateLabel.Visible = false;
            }
        }
    }
}