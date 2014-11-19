using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanClassLibrary;


namespace StudentLoanClassLibrary
{
    /*
    Class Name: StudentLoan
    Author: Michael Fesser
    Version: #1.0
    Description: This is a derived class of the Loan Class.  This class does the caluculations for the student loan only. 
    This class does override the claculate method form the Loan class.
    Dependencies: Loan.
    Change History: None.
    */
    public class StudentLoan : Loan
    {
        // Student discount
        public const decimal STUDENT_DISCOUNT = .5m;

        /*
        Constructor name: StudentLoan
        Version: #1.0
        Author: Michael Fesser
        Description: This constructor accepts the values from the form and then passes them to the base class which is Loan.
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        public StudentLoan(string lastName, string firstName, string email, bool studentLoan, decimal loanAmount, decimal loanLength)
            : base(lastName, firstName, email, studentLoan, loanAmount, loanLength)
        {
        }

        /*
       Method name: Calculate
       Version: #1.0
       Author: Michael Fesser
       Description: This is a overridden method that does the main calculations.  It calcualates the aunnual interest, the 
       total interest, and the total for the loan with the student discount factored in.
       Returns: None.
       Change History: None.
       */
        public override void calculate()
        {
            this.anualInterest = 0m;
            this.totalInterestCharge = 0m;
            this.totalLoan = 0m;

            // Check which loan rate to use and add student discount
            if (loanLength == 1)
            {
                this.anualInterest = loanAmount * ONE_YEAR_RATE * STUDENT_DISCOUNT;
            }
            else if (loanLength == 2)
            {
                this.anualInterest = loanAmount * TWO_YEAR_RATE * STUDENT_DISCOUNT;
            }
            else if (loanLength == 3)
            {
                this.anualInterest = loanAmount * THREE_YEAR_RATE * STUDENT_DISCOUNT;
            }
            else
            {
                this.anualInterest = loanAmount * FOUR_PLUS_YEAR_RATE * STUDENT_DISCOUNT;
            }
            // Calculate results
            this.totalInterestCharge = anualInterest * loanLength;
            this.totalLoan = loanAmount + totalInterestCharge;
        }
    }
}
