using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app is foing to about how i am going to
    /// convert FEET to MILE, MILE to METER 
    /// and FEET to METER
    /// </summary>
    /// <author>
    /// Uthman version 0.6
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILE = 5280;
        public const double MILE_IN_METER = 1609.34;
        public const double FEET_IN_METER = 3.28084;
        public const string FEET = "Feet";
        public const string METER = "Meter";
        public const string MILES = "Miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        /// <summary>
        /// This method is used to input the distance from all the
        /// the reqirements.
        /// </summary>
        public void ConvertDistance()
        {
            OutptHeading();

            fromUnit = SelectUnit(" Select from the distance units ");
            toUnit = SelectUnit(" Select to the distance units ");

            Console.WriteLine($"Convering {fromUnit} to {toUnit}");
            fromDistance = InputDIstance($"Enter miles {fromUnit} ");
            CalculateDistance();
            OutputDistance();
        }

        /// <summary>
        /// This this is for calculating all the 
        /// different distance that you can have.
        /// </summary>
        private void CalculateDistance()
        {
            if(fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILE;
            }
            else if(fromUnit == FEET && toUnit == MILES) 
            {
                toDistance = fromDistance / FEET_IN_MILE;
            }
            else if(fromUnit == METER && toUnit == MILES)
            {
                toDistance = fromDistance / MILE_IN_METER;
            }
            else if (fromUnit == MILES && toUnit == METER)
            {
                toDistance = fromDistance * MILE_IN_METER;
            }
            else if (fromUnit == METER && toUnit == FEET)
            {
                toDistance = fromDistance / FEET_IN_METER;
            }
            else if (fromUnit == FEET && toUnit == METER)
            {
                toDistance = fromDistance * FEET_IN_METER;
            }
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            string unit =  ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;

        }


        /// <summary>
        /// This is to give the a choice from 1 to 3
        /// to pick which one they want to input and
        /// return
        /// </summary>
        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice == "2")
            {
                return METER;
            }
            else if (choice == "3")
            {
                return MILES;
            }
            return null;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METER}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// This is a short discription of the Output
        /// of the Application and the name of the Author
        /// </summary>
        private void OutptHeading()
        {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("        Distance Converter   ");
            Console.WriteLine("         by Uthman Uthman   ");
            Console.WriteLine("-----------------------------\n");

        
        }

        /// <summary>
        /// This is to give a message to input the miles
        /// as a double number
        /// </summary>
        private double InputDIstance(string prompt)
        {
            Console.Write("Please enter the number of miles: ");
            string value = Console.ReadLine();
            return Convert.ToDouble(value);


        }
        

        private void OutputDistance()
        {
            Console.WriteLine($"\n {fromDistance}  {fromUnit}" +
                $" is {toDistance} {toUnit}!");
        }


    }
}
