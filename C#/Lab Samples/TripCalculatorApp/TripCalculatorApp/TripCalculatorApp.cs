/* TripCalculatorApp.cs
 * This application enables the
 * user to calculate their miles
 * per gallon for a given trip.
 * Destination, miles traveled,
 * and gallons consumed are entered.
 * A reset button enables multiple 
 * calculations to be performed.
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

namespace TripCalculatorApp
{
    public partial class TripCalculatorApp : Form
    {
        public TripCalculatorApp()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBxDestination.Clear();
            txtBxGallons.Clear();
            txtBxMiles.Clear();
            lblOutput.Text = string.Empty;
            txtBxDestination.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double gallons,
                   miles;

            while (double.TryParse(txtBxMiles.Text, out miles) == false)
            {
                lblOutput.Text = "Miles must be numeric";
                txtBxMiles.Clear();
                txtBxMiles.Focus();
           
            }
            while (double.TryParse(txtBxGallons.Text, out gallons) == false)
            {
                lblOutput.Text = "Gallons must be numeric";
                txtBxGallons.Clear();
                txtBxGallons.Focus();
            }

            lblOutput.Text = "Miles per Gallon: " +
                        (miles / gallons).ToString("F1");
        }

    }
}
