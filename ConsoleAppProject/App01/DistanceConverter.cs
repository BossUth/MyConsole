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
            miles = InputDIstance("Enter miles");
            CalculateFeet();
            OutputDistance(miles, nameof(miles), feet, nameof(feet));
        }

        public void FeetToMiles()
        {
            OutptHeading("Convering Feet to Miles");
            feet = InputDIstance("Enter feet");
            CalculateMiles();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }

        public void MilesToMeter()
        {
            OutptHeading("Convering Miles to Meter");
            miles = InputDIstance("Enter miles");
            CalculateMeter();
            OutputDistance(miles, nameof(miles), meter, nameof(meter));
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
        private double InputDIstance(string prompt)
        {
            Console.Write("Please enter the number of miles: ");
            string value = Console.ReadLine();
            return Convert.ToDouble(value);


        }
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILE;

        }
        


        
        private void CalculateMiles()
        {
            miles = feet / 1609.34;
        }

    
         

        private void CalculateMeter()
        {
            meter = miles / 3.28084;
        }

        private void OutputDistance(
            double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($"{fromDistance}  {fromUnit}" +
                $" is {toDistance} {toUnit}!");
        }


    }
}
