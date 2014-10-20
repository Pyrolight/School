/* Loan.cs   
 * This class serves as the base (super) class
 * for alla types of loans. This base class 
 * includes common characteristics
 * about all loans including loan number,
 * customer info, interest rate, amount of the 
 * loan and the number of years financed.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanApp
{
    class Loan
    {
        private string LoanNumber;
        private string customerFirst;
        private string customerLast;
        private double interestRate;
		private double loanAmount;
		private double termYears;
		
		public Loan()
		{
		}

		public Loan(double rate, double amtBorrowed, double time)
		{
			interestRate = rate;
			loanAmount = amtBorrowed;
			termYears = time;
		}

        public Loan(string first, string last,
                      double rate, double amtBorrowed, double time)
        {
            customerFirst = first;
            customerLast = last;
            interestRate = rate;
            loanAmount = amtBorrowed;
            termYears = time;
        }


        public string loanNumber
        {
            get 
            { 
                return LoanNumber; 
            }
            set 
            { 
                LoanNumber = value; 
            }
        }

        public string CustomerFirst
        {
            get 
            { 
                return customerFirst; 
            }
            set 
            { 
                customerFirst = value; 
            }
        }

        public string CustomerLast
        {
            get 
            { 
                return customerLast; 
            }
            set 
            { 
                customerLast = value; 
            }
        }

		//Read-Only Properties
		public double InterestRate
		{
			get
			{
				return interestRate;
			}			
		}

        public double LoanAmount
		{
			get
			{
				return loanAmount;
			}			
		}

		public double TermYears
		{
			get
			{
				return termYears;
			}			
		}

        public override string ToString()
        {
            return "Customer:  " + customerFirst + " " +
                    customerLast +
                    "\nLoan amount:  " + loanAmount.ToString("C") +
                    "\nInterest Rate:  " + interestRate.ToString("p2") +
                    "\nLoan Duration: " + termYears;
        }
	}
}
