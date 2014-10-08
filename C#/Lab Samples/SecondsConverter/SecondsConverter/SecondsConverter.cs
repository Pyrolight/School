/* SecondsConverter.cs
 * This applicaton allows user to
 * enter total seconds. It
 * converts that value to an equivalent 
 * number of hours, minutes, and seconds.
 *  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondsConverter
{
    class SecondsConverter
    {
        static void Main(string[] args)
        {
            int totalSeconds,
                hours,
                minutes,
                remainingSeconds;

            totalSeconds = InputSeconds();
          
            hours = DetermineNumberHours(totalSeconds);
            remainingSeconds = DetermineRemainingSeconds(totalSeconds, 3600);
            minutes = DetermineNumberMinutes(remainingSeconds);
            remainingSeconds = DetermineRemainingSeconds(remainingSeconds, 60);

            DisplayResults(totalSeconds, hours, minutes,remainingSeconds);
            Console.ReadKey();
        }

        public static int InputSeconds()
        {
            string inValue;
            int seconds;
            Console.Write("Enter the total seconds: ");
            inValue = Console.ReadLine();
            seconds = int.Parse(inValue);
            return seconds;
        }


        public static int DetermineNumberHours(int totalSeconds)
        {
            return totalSeconds / 3600;
        }

        public static int DetermineRemainingSeconds(int totalSeconds, int divisor)
        {
            return totalSeconds % divisor;
        }
        
        public static int DetermineNumberMinutes(int totalSeconds)
        {
            return totalSeconds / 60;
        }

        public static void DisplayResults(int totalSeconds, int hours, int minutes,
                                            int seconds)
        {
            Console.Clear();
            Console.WriteLine("     Time Converter\n");
            Console.WriteLine("{0,-15} {1,8:N0}", "Total Seconds:", totalSeconds);
            Console.WriteLine();
            Console.WriteLine("{0,-10} {1,8:N0}", "Hours:", hours); 
            Console.WriteLine("{0,-10} {1,8:N0}", "Minutes:", minutes);
            Console.WriteLine("{0,-10} {1,8:N0}", "Seconds:", seconds);
        }
    }
}
