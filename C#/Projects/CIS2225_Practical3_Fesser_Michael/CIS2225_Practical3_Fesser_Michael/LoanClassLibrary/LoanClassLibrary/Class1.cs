using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanClassLibrary
{
    /*
    Class Name: Loan
    Author: Michael Fesser
    Version: #1.0
    Description: This class holds all the values from the form.  This class does the caluculations for both auto and home loans but
    not the student loans.  It does hold all the values that are passed into the studentLoan object.
    Dependencies: LoanApplication.
    Change History: None.
    */
    public class Loan
    {
        // Constants used for the loan rate based on the number of years of the loan
        public const decimal ONE_YEAR_RATE = .02m;
        public const decimal TWO_YEAR_RATE = .04m;
        public const decimal THREE_YEAR_RATE = .06m;
        public const decimal FOUR_PLUS_YEAR_RATE = .08m;

        // Form values
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string email { get; set; }
        public bool homeLoan { get; set; }
        public bool studentLoan { get; set; }
        public bool autoLoan { get; set; }
        public decimal loanAmount { get; set; }
        public decimal loanLength { get; set; }
        //  Calculate values
        public decimal anualInterest { get; set; }
        public decimal totalInterestCharge { get; set; }
        public decimal totalLoan { get; set; }

        // Default constructor
        public Loan(){}

        /*
        Constructor name: Loan
        Version: #1.0
        Author: Michael Fesser
        Description: This constructor accepts the values from the form when the object is created and then sets the fields.  It does not accepts the 
        value for the student object.
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        public Loan(string lastName, string firstName, string email, bool homeLoan, bool autoLoan, decimal loanAmount, decimal loanLength)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.email = email;
            this.homeLoan = homeLoan;
            this.autoLoan = autoLoan;
            this.loanAmount = loanAmount;
            this.loanLength = loanLength;       
        }

        /*
        Constructor name: Loan
        Version: #1.0
        Author: Michael Fesser
        Description: This constructor recieves the values from the constructor in the studentLoan class and then sets the fields.
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        public Loan(string lastName, string firstName, string email, bool studentLoan, decimal loanAmount, decimal loanLength)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.email = email;
            this.studentLoan = studentLoan;
            this.loanAmount = loanAmount;
            this.loanLength = loanLength;     
        }

        /*
        Method name: Calculate
        Version: #1.0
        Author: Michael Fesser
        Description: This is a virtual method that does the main calculations.  It calcualates the aunnual interest, the 
        total interest, and the total for the loan.  This method is overridden in the derived studentLoan class.
        Returns: None.
        Change History: None.
        */
        public virtual void calculate() {
            this.anualInterest = 0m;
            this.totalInterestCharge = 0m;
            this.totalLoan = 0m;

            // Check which loan rate to use
            if (loanLength == 1)
            {
                anualInterest = loanAmount * ONE_YEAR_RATE;
            }
            else if (loanLength == 2)
            {
                anualInterest = loanAmount * TWO_YEAR_RATE;
            }
            else if (loanLength == 3)
            {
                anualInterest = loanAmount * THREE_YEAR_RATE;
            }
            else
            {
                anualInterest = loanAmount * FOUR_PLUS_YEAR_RATE;
            }
            // Do calcualtions
            totalInterestCharge = anualInterest * loanLength;
            totalLoan = loanAmount + totalInterestCharge;        
        }
    }
}
