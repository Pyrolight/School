using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Program name: Acme Widget Company
Author: Michael Fesser
Version: #1.0
Description: This program will calculate the pay received by an employee based on the number of widgets they produce.  There are four
categories of pay:
 1. 1 to 100 50 cents
 2. 101 to 399 55 cents
 3. 400 to 599 60 cents
 4. 600+ 65 cents  
The program will also have functionality to total the number of widgets, total pay for all employees, and find the average pay for the employees.
Finally the user will be able to clear the current employee's totals as well as the summary of all the employee's totals.
Dependencies: None.
Change History: 2014/10/06 Added header comments.
*/

namespace AcmeWidgetCompany
{
    public partial class acmeWidgets : Form
    {
        // Pay rate for 1 to 100 widgets
        const decimal FIRST_PAYMENT_CATEGORY_PAY_RATE = .50m;
        // Pay rate for 101 to 399 widgets
        const decimal SECOND_PAYMENT_CATEGORY_PAY_RATE = .55m;
        // Pay rate for 400 to 599 widgets
        const decimal THIRD_PAYMENT_CATEGORY_PAY_RATE = .60m;
        // Pay rate for 600+ widgets
        const decimal FOURTH_PAYMENT_CATEGORY_PAY_RATE = .65m;
        // The following three constants are used to hold the upper limit of each pay catgeory
        const int FIRST_PAYMENT_CATEGORY_WIDGET_UPPER_LIMIT = 100;
        const int SECOND_PAYMENT_CATEGORY_WIDGET_UPPER_LIMIT = 399;
        const int THIRD_PAYMENT_CATEGORY_WIDGET_UPPER_LIMIT = 599;

        private decimal employeePay;
        private decimal totalPay;
        private decimal averagePay;
        private int totalWidgetsProduced;

        public acmeWidgets()
        {
            InitializeComponent();
        }

        /*
        Function name: Calculate Button
        Version: #1.0
        Author: Michael Fesser
        Description: This function calculates the total pay for each employee based on the number of widgets produced.
        Inputs: User input for number of widgets
        Outputs: Display the total pay.
        Change History: None.
        */
        private void calculateButton_Click(object sender, EventArgs e)
        {
            int numberWidgets = 0;
            // If the name field is empty warn the user.
            if (employeeNameTB.Text == "")
            {
                MessageBox.Show("Please enter the name of the employee.", "No Selection Made",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // If the number of widgets field is empty warn the user.
            else if (numberOfWidgetsTB.Text == "")
            {
                MessageBox.Show("Please enter the number of widgets.", "No Selection Made",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //  Continue with the program.
            else
            {
                try
                {
                    // Get the number of widgets.
                    numberWidgets = int.Parse(numberOfWidgetsTB.Text);

                    // The following conditional statement block defines the base pay per widget based on how many are produced.
                    if (numberWidgets > 0 && numberWidgets <= FIRST_PAYMENT_CATEGORY_WIDGET_UPPER_LIMIT)
                    {
                        employeePay = numberWidgets * FIRST_PAYMENT_CATEGORY_PAY_RATE;
                    }
                    else if (numberWidgets > FIRST_PAYMENT_CATEGORY_WIDGET_UPPER_LIMIT && numberWidgets <= SECOND_PAYMENT_CATEGORY_WIDGET_UPPER_LIMIT)
                    {
                        employeePay = numberWidgets * SECOND_PAYMENT_CATEGORY_PAY_RATE;
                    }
                    else if (numberWidgets > SECOND_PAYMENT_CATEGORY_WIDGET_UPPER_LIMIT && numberWidgets <= THIRD_PAYMENT_CATEGORY_WIDGET_UPPER_LIMIT)
                    {
                        employeePay = numberWidgets * THIRD_PAYMENT_CATEGORY_PAY_RATE;
                    }
                    else if (numberWidgets > THIRD_PAYMENT_CATEGORY_WIDGET_UPPER_LIMIT)
                    {
                        employeePay = numberWidgets * FOURTH_PAYMENT_CATEGORY_PAY_RATE;
                    }

                    // Add to the current total for all employees pay.
                    totalPay += employeePay;
                    // Add to the current total for all widgets.
                    totalWidgetsProduced += numberWidgets;
                    // Find the average pay.
                    averagePay = totalPay / totalWidgetsProduced;

                    employeePayTB.Text = employeePay.ToString("C");
                    // Used to enable the summary button after the first employee's totals have been calculated.
                    summaryButton.Enabled = true;

                }
                catch (FormatException)
                {
                    // Make sure the number of widgets is numeric
                    MessageBox.Show("Number of widgets must be numeric.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    numberOfWidgetsTB.Focus();
                }
                catch (Exception theException)
                {
                    MessageBox.Show("Error: " + theException.Message);
                }

            }
        }

        /*
        Function name: Summary Button
        Version: #1.0
        Author: Michael Fesser
        Description: This function calculates the total pay for all the employees, the total number of widgets, and the average pay for all employees.
        Inputs: None.
        Outputs: Display the total and average pay for all employees and the number of widgets produced.
        Change History: None.
        */
        private void summaryButton_Click(object sender, EventArgs e)
        {
            totalWidgetsTB.Text = totalWidgetsProduced.ToString();
            totalPayTB.Text = totalPay.ToString("C");
            avgPayTB.Text = averagePay.ToString("C");
        }

        /*
        Function name: Clear Button 
        Version: #1.0
        Author: Michael Fesser
        Description: This clears the fields related to the employee.
        Inputs: None.
        Outputs: Cleared employee fields.
        Change History: None.
        */
        private void clearButton_Click(object sender, EventArgs e)
        {
            employeeNameTB.Clear();
            numberOfWidgetsTB.Clear();
            employeePayTB.Clear();
            employeeNameTB.Focus();
        }

        /*
        Function name: Clear All Button 
        Version: #1.0
        Author: Michael Fesser
        Description: This clears the fields related to the summary.  A warning to the user will be shown and a confimation is required.
        Inputs: None.
        Outputs: Cleared summary fields.
        Change History: None.
        */
        private void clearAllButton_Click(object sender, EventArgs e)
        {

            // Add confirmation warning.
            DialogResult dr = MessageBox.Show("Do you rally want to clear the summary?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                totalWidgetsTB.Clear();
                totalPayTB.Clear();
                avgPayTB.Clear();
                // Lock the summary button until a new employee has had their pay calculated.
                summaryButton.Enabled = false;
                // Clear the summary variables.
                totalPay = 0;
                totalWidgetsProduced = 0;
                averagePay = 0;
            }
        }
    }
}
