/* BodyMassIndexCalculator
 * This class includes data members to enable both the imperial and metric
 * formulas to be used to calculate a person's body mass index (BMI).
 * Imperial formula is BMI = (weight in pounds * 703) / (height in inches squared)
 * Metric Imperial formula is BMI = weight in kilograms / (height in meters squared)
 * A method is also included that returns the weight status using the following
 * table:
 *     BMI		    Weight Status
 *   Below 18.5	    Underweight
 *   18.5 - 24.9	Normal
 *   25 - 29.9	    Overweight
 *   30 & above	    Obese 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_CalculatorApp
{
    class BodyMassIndexCalculator
    {
        private int weight;
        private int heightInFeet;
        private int heightInInches;
        private int weightInKilograms;
        private double heightInMeters;

        public BodyMassIndexCalculator()
        {
        }

        public BodyMassIndexCalculator(int lbs, int feet, int inches)
        {
            weight = lbs;
            heightInFeet = feet;
            heightInInches = inches;
        }

        public BodyMassIndexCalculator(int kilograms, double meters)
        {
            weightInKilograms = kilograms;
            heightInMeters = meters;
        }

        public int HeightInFeet
        {
            get
            {
                return heightInFeet;
            }
            set
            {
                heightInFeet = value;
            }
        }

        public int HeightInInches
        {
            get
            {
                return heightInInches;
            }
            set
            {
                heightInInches = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public double HeightInMeters
        {
            get
            {
                return heightInMeters;
            }
            set
            {
                heightInMeters = value;
            }
        }

        public int WeightInKilograms
        {
            get
            {
                return weightInKilograms;
            }
            set
            {
                weightInKilograms = value;
            }
        }

        public double CalculateMetricBMIUsingMetricMeasurements()
        {
            return weightInKilograms / Math.Pow(heightInMeters, 2);  //Math.Pow( ) returns a double, thus no cast is needed
        }

        public double CalculateBMI()
        {
            return (weight * 703) / Math.Pow((heightInFeet * 12 + heightInInches), 2);
        }

        public string ReturnWeightStatus( )
        {
 
            double bodyMassIndex;
            string weightStatus;

            if (weight != 0)
                bodyMassIndex = CalculateBMI( );
            else
                bodyMassIndex = CalculateMetricBMIUsingMetricMeasurements();

            if (bodyMassIndex < 18.5)
                weightStatus = "Underweight";
            else
                if (bodyMassIndex < 25)
                    weightStatus = "Normal";
                else
                    if (bodyMassIndex < 30)
                        weightStatus = "Overweight";
                    else
                        weightStatus = "Obese";
            return weightStatus;

        }

        public override string ToString()
        {
            string result = "\tBMI App\n\nWeight ";
            if (weight != 0)
            {
                result += "(lbs.): " + weight +
                        "\nHeight (Feet/Inches): " + heightInFeet + "\' " + heightInInches + "\" " +
                        "\nBMI: " + CalculateBMI().ToString("F2");
            }
            else
            {
                result += "(kilograms): " + weightInKilograms +
                    "\nHeight (Meters): " + heightInMeters +
                    "\nBMI: " + CalculateMetricBMIUsingMetricMeasurements().ToString("F2");
            }
            result += "\n\nWeight Status: " + ReturnWeightStatus();
            return result;
        }

    }
}
