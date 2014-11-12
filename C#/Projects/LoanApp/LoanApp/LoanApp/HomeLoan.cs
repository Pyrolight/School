/* HomeLoan.cs   
 * This class extends the base class,
 * Loan. It includes additional details
 * about the home financed, including the 
 * year the home was built, street address 
 * and the size of the home in square feet.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanApp
{
    class HomeLoan : Loan
    {
        private string address;
        private int yearBuilt;
        private int sqFootage;

        public HomeLoan()
            : base()
        {
        }

        public HomeLoan(double intRate, double prinBorrowed, double duration,
                            int yrBuilt, int sqFeet, string add)
            : base(intRate, prinBorrowed, duration)
        {
            yearBuilt = yrBuilt;
            sqFootage = sqFeet;
            address = add;
        }

        public HomeLoan(string first, string last, double intRate, double prinBorrowed, double duration,
                    int yrBuilt, int sqFeet, string add)
            : base(first, last, intRate, prinBorrowed, duration)
        {
            yearBuilt = yrBuilt;
            sqFootage = sqFeet;
            address = add;
        }


        //Property yearBuilt
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

        //Property for sqFootage
        public int SqFootage
        {
            get
            {
                return sqFootage;
            }
            set
            {
                sqFootage = value;
            }
        }

        // Property for address
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nHome Loan Address: " + address;
        }
    }
}
