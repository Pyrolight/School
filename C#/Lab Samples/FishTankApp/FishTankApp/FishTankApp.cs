/* FishTankApp.cs
 * This application allows users to input the pH number 
 * of a fish aquarium. It displays the aquarium’s level
 * (acidic, neutral, or alkaline).
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTankApp
{
    class FishTankApp
    {
        static void Main(string[] args)
        {
            double ph;
            string phLevel;

            DisplayInstructions();
            ph = GetInput();
            phLevel = TestpH(ph);
            DisplayResults(ph, phLevel);
            Console.ReadKey();
        }

        public static void DisplayInstructions()
        {
            Console.WriteLine("\tFish Tank ph Tester App");
            Console.WriteLine("\nThis application enables you to input a pH number.");
            Console.WriteLine("It tests the value entered and displays the aquarium\'s ");
            Console.WriteLine("ph level (acidic, neutral, or alkaline)");
            Console.WriteLine("\n\nPress any key when you are ready to begin...");
            Console.ReadKey();
        }

        public static double GetInput()
        {
            double ph;

            Console.Clear();
            Console.Write("Please enter the ph number: ");
            if (double.TryParse(Console.ReadLine(), out ph) == false)
            {
                Console.WriteLine("Invalid data entered");
            }
            return ph;
        }

        public static string TestpH(double ph)
        {
            string result;
            if (ph > 14)
                result = "Invalid input - (Number entered too large)";
            else
                if (ph < 0)
                    result = "Invalid input - (Number entered too small)";
                else
                    if (ph < 7)
                        result = "Acidic";
                    else
                        if (ph == 7)
                            result = "Neutral";
                        else
                            result = "Alkaline";
            return result;
        }

        public static void DisplayResults(double ph, string phLevel)
        {
            Console.Clear();
            Console.WriteLine("\tFish Tank ph Tester App");
            Console.WriteLine("\n\npH: {0}", ph);
            Console.WriteLine("pH Level: {0}", phLevel);
        }

    }
}
