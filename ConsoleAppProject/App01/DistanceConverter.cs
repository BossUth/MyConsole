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
        public static double METER_IN_MILE = 1609.34;

        public double miles, feet;

        public void Run()
        {
            OutptHeading();

            InputMiles();
            CalculateFeet();
            OutputFeet();

            InputFeet();
            CalculateMiles();
            OutputMiles();


            InputMeters();
            CalculateMiles();
            OutputMiles();



        }

        private void OutptHeading()
        {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("      Conver Miles to Feet   ");
            Console.WriteLine("         by Uthman Uthman   ");
            Console.WriteLine("-----------------------------\n");
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
            Console.Write("Please enter the number of meeters: ");
            string value = Console.ReadLine();
            feet = Convert.ToInt64(value);
        }

        


    }
}
