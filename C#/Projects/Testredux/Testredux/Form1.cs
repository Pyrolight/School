using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testredux
{
    public partial class randysSportingConsulting : Form
    {
        const decimal TEN_PERCENT_DISOUNT = .10m;
        const decimal TWENTY_PERCENT_DISCOUNT = .20m;
        const decimal TEAM_BUILDING = 125.00m;
        const decimal NUTRITION = 60.00m;
        const decimal EXERCISE = 35.00m;
        const decimal FULL_PACKAGE = 200.00m;
        private decimal totalCost;

        public randysSportingConsulting()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal currentTotal = 0;
            
            if (noSelectionRB.Checked == false)
            {
                if (teamBuildingRB.Checked == true)
                {
                    currentTotal = TEAM_BUILDING;
                }
                else if (nutritionRB.Checked == true)
                {
                    currentTotal = NUTRITION;
                }
                else if (exercizeRB.Checked == true)
                {
                    currentTotal = EXERCISE;
                }
                else if (fullPackageRB.Checked == true)
                {
                    currentTotal = FULL_PACKAGE;
                }

                if (tenPercentDiscountRB.Checked == true)
                {
                    currentTotal -= currentTotal * TEN_PERCENT_DISOUNT;
                }
                else if (twentyPercentDiscountRB.Checked == true)
                {
                    currentTotal -= currentTotal * TWENTY_PERCENT_DISCOUNT;
                }

                totalCost += currentTotal;

                currentServiceTB.Text = currentTotal.ToString("C");
                totalServiceTB.Text = totalCost.ToString("C");
            }
            else {
                MessageBox.Show("Please select a service.", "No Selection Made",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                noDiscountRB.Checked = true;
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            noDiscountRB.Checked = true;
            noSelectionRB.Checked = true;
            totalServiceTB.Clear();
            currentServiceTB.Clear();
            totalCost = 0;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
