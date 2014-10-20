/* AutoLoan.cs   
 * This class extends the super class Loan. 
 * Additional characteristics about the loan including
 * what auto make, model and year were financed is 
 * included.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanApp
{
    class AutoLoan : Loan
    {
        private int yearBuilt;
        private string model;
        private string make;
        private string autoColor;

        public AutoLoan()
            : base()
        {
        }

        public AutoLoan(double intRate, double prinBorrowed, 
                        double duration, int yr, string mod, 
                        string carMake)
            : base(intRate, prinBorrowed, duration)
        {
            yearBuilt = yr;
            model = mod;
            make = carMake;
        }

        public AutoLoan(string first, string last, double intRate, double prinBorrowed,
                double duration, int yr, string mod,
                string carMake)
            : base(first, last, intRate, prinBorrowed, duration)
        {
            yearBuilt = yr;
            model = mod;
            make = carMake;
        }

        // Property for yearBuilt
        public int YearBuilt
        {
            get
            {
                return yearBuilt;
            }
            set
            {
                yearBuilt = value;
            }
        }

        //Property for model
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        // Property for make
        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }
 
        public string AutoColor
        {
            get
            {
                return autoColor;
            }
            set
            {
                make = autoColor;
            }
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nType of Car: " +
                yearBuilt + " " +
                autoColor + " " + model;
        }
    }
}