using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoanClassLibrary;
using StudentLoanClassLibrary;

/*
    Program Name: LoanApplication
    Author: Michael Fesser
    Version: #1.0
    Description: This is a basic loan form.  It will handle auto, home, and student loans.  The calculations for the loans are 
    done in their respective classes and the results for the annual interest, total interest, and the total loan is shown on the main 
    form.  The StudentLoan and Loan classes are imported as libraries.
    Dependencies: None.
    Change History: None.
    */
namespace LoanApplication
{
    /*
    Class Name: LoanApplication
    Author: Michael Fesser
    Version: #1.0
    Description: This is the form class for the application.  The loan and studentLoan objects are created here and then the 
    options from the form are passed to their respective classes via constructors.  This form will then display the totals for annual interest, total interest, and the total loan.
    Dependencies: None.
    Change History: None.
    */
    public partial class LoanApplication : Form
    {
        public LoanApplication()
        {
            InitializeComponent();
        }

        /*
        Method name: submitButton_Click
        Version: #1.0
        Author: Michael Fesser
        Description: This method accpets the values from the form and creates the loan and studentLoan objects.
        Outputs: anualInterest, totalInterestCharge, totalLoan.
        Returns: None.
        Change History: None.
        */
        private void submitButton_Click(object sender, EventArgs e)
        {
            int error = 0;
            decimal loanAmount = 0;
            try
            {
                loanAmount = Decimal.Parse(loanAmountTB.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("You need to enter a number");
                error = 1;
                loanAmountTB.Clear();
                loanAmountTB.Focus();
            }

            if (error == 0)
            {
                // Check to see if it is a student loan.
                if (studentRB.Checked == true)
                {
                    // Create object and pass values to the constructor.
                    StudentLoan studentLoan = new StudentLoan(lastNameTB.Text, firstNameTB.Text, emailTB.Text, studentRB.Checked, loanAmount, loanLengthNUD.Value);
                    studentLoan.calculate();
                    // Output
                    annualInterestTB.Text = studentLoan.anualInterest.ToString("c");
                    totalInterestTB.Text = studentLoan.totalInterestCharge.ToString("c");
                    loanTotalTB.Text = studentLoan.totalLoan.ToString("c");
                }
                else
                {
                    // Create object and pass values to the constructor.
                    Loan loan = new Loan(lastNameTB.Text, firstNameTB.Text, emailTB.Text, homeRB.Checked, autoRB.Checked, loanAmount, loanLengthNUD.Value);
                    loan.calculate();
                    // Output
                    annualInterestTB.Text = loan.anualInterest.ToString("c");
                    totalInterestTB.Text = loan.totalInterestCharge.ToString("c");
                    loanTotalTB.Text = loan.totalLoan.ToString("c");

                }
            }
        }
    }
}
