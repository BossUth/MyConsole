using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Uthman version 0.1
    /// </author>
    public class DistanceConverter
    {
        public static double FEET_IN_MILE = 5280;
        public static double MILE_IN_METER = 1609.34;

        public double miles, meter, feet;

        public void MilesToFeet()
        {
            
            OutptHeading("Convering Miles to Feet");
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        public void FeetToMiles()
        {
            OutptHeading("Convering Feet to Miles");
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }

        public void MilesToMeter()
        {
            OutptHeading("Convering Miles to Meter");
            InputMiles();
            CalculateMeters();
            OutputMeters();
        }



        private void OutptHeading(String prompt)
        {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("        Distance Converter   ");
            Console.WriteLine("         by Uthman Uthman   ");
            Console.WriteLine("-----------------------------\n");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles: ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);


        }
        private void CalculateFeet()
        {
            feet = miles * 5280;

        }
        private void OutputFeet()
        {
            Console.WriteLine(miles + "miles is " + feet + " feet!");
        }


        private void InputFeet()
        {
            Console.Write("Please enter the number of feet: ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        private void CalculateMiles()
        {
            miles = feet / 1609.34;
        }

        private void OutputMiles()
        {
            Console.WriteLine(feet + "feet is " + miles + "miles!");
        }


        private void InputMeters ()
        {
            Console.Write("Please enter the number of meters: ");
            string value = Console.ReadLine();
            feet = Convert.ToInt64(value);
        }

        private void CalculateMeters()
        {
            meter = miles / 3.28084;
        }

        private void OutputMeters()
        {
            Console.WriteLine(miles + "miles is " + meter + "meter!");
        }


    }
}
