/*
 * Program:     EX1210 - Exercise 12.10
 * Programmer:  Theresa Berry
 * Date:        August 2009
 * Description: Class with properties for a Sandwich class.
 * Class:       Sandwich
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace EX1210
{
    class Sandwich
    {
        private static string nameString;
        private static string meatString;
        private static string breadString;
        private static string cheeseString;
        private static string condimentsString;

        public Sandwich(string selectedNameString, string selectedMeatString,
            string selectedBreadString, string selectedCheeseString,
            string selectedCondimentsString)
        {
            Name = selectedNameString;
            Meat = selectedMeatString;
            Bread = selectedBreadString;
            Cheese = selectedCheeseString;
            condimentsString = selectedCondimentsString;
        }

        public static string Name
        {
            get
            {
                return nameString;
            }
            set
            {
                nameString = value;
            }
        }

        public static string Meat
        {
            get
            {
                return meatString;
            }
            set
            {
                meatString = value;
            }
        }

        public static string Bread
        {
            get
            {
                return breadString;
            }
            set
            {
                breadString = value;
            }
        }

        public static string Cheese
        {
            get
            {
                return cheeseString;
            }
            set
            {
                cheeseString = value;
            }
        }

        public static string Condiments
        {
            get
            {
                return condimentsString;
            }
            set
            {
               condimentsString = value;
            }
        }
    }
}
