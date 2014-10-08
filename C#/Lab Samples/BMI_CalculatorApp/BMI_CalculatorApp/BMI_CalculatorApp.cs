/* BMI_CalculatorApp.cs
 * This application allows users to input their
 * Imperial formula is BMI = (weight in pounds * 703) / (height in inches squared)
 * Metric Imperial formula is BMI = weight in kilograms / (height in meters squared)
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_CalculatorApp
{
    class BMI_CalculatorApp
    {
        static void Main(string[] args)
        {
            BodyMassIndexCalculator firstTest = new BodyMassIndexCalculator(200, 5, 5);
            Console.WriteLine(firstTest);
            Console.WriteLine("\n\n\n\nPress any key to see the next test...");
            Console.ReadKey();
            Console.Clear();

            BodyMassIndexCalculator secondTest = new BodyMassIndexCalculator(74, 1.82);
            Console.WriteLine(secondTest);
            Console.ReadKey();
        }
    }
}
