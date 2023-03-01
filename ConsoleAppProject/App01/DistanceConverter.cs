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

        public double miles, meters, feet;

        public void Run()
        {
            OutptHeading();

            InputMiles();
            CalculateFeet();
            OutputFeet();

            InputFeet();
            CalcualteMiles();
            OutputMiles();



        }

        private void OutputMiles()
        {
            throw new NotImplementedException();
        }

        private void CalcualteMiles()
        {
            throw new NotImplementedException();
        }

        private void InputFeet()
        {
            Console.Write("Please enter the number of feet > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void OutputFeet()
        {
            throw new NotImplementedException();
        }

        private void CalculateFeet()
        {
            throw new NotImplementedException();
        }

        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void OutptHeading()
        {
            throw new NotImplementedException();
        }

        internal void run()
        {
            Console.WriteLine();
        }
    }
}
