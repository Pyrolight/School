/*
 * Program:     EX1212 - Exercise 12.12
 * Programmer:  Theresa Berry
 * Date:        August 2009
 * Description: Class to calculate the recording studio charges.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace EX1212
{
    class Charges
    {
        const decimal RENTAL_RATE_Decimal = 200m / 60m;
        private int minutesInteger;
        private decimal rentalChargeDecimal;
        private static int groupCountInteger;
        private static decimal rentalChargeAllGroupsDecimal; 
        private decimal avgChargeDecimal;

        public Charges(int numberMinutesInteger)
        {
            Minutes = numberMinutesInteger;
            findCharges();
        }

        public int Minutes
        {
            set
            {
                minutesInteger = value;
            }
        }

        public decimal RentalCharge
        {
            get
            {
                return rentalChargeDecimal;
            }
        }

        public int GroupCount
        {
            get
            {
                return groupCountInteger;
            }
        }

        public decimal RentalChargesAllGroups
        {
            get
            {
                return rentalChargeAllGroupsDecimal;
            }
        }


        public decimal Average
        {
            get
            {
                return avgChargeDecimal;
            }
        }

        private void findCharges()
        {
                // Calculate charges for current group
                rentalChargeDecimal = minutesInteger * RENTAL_RATE_Decimal;

                // Calculate the total number of groups
                groupCountInteger++;

                // Calculate the total charges
                rentalChargeAllGroupsDecimal += rentalChargeDecimal;
                
                // Calculate the average charges 
                avgChargeDecimal = decimal.Round((rentalChargeAllGroupsDecimal / groupCountInteger), 2);
        }
    }
}
