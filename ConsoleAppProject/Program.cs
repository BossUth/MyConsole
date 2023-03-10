using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Derek Peacock 05/02/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("This is the distance converter");
            Console.WriteLine();
            Console.Beep();

           DistanceConverter converter = new DistanceConverter();
           converter.ConvertDistance();


            Console.WriteLine("This is the BMI Calculator");
            Console.WriteLine();
            Console.Beep();

            Console.WriteLine(" BMI Calculator - Uthman Uthman.");


            Console.Write($"Hi, now let's calculate your BMI.");
            Console.Write("Enter your weight (KG's): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your height (M's): ");
            double height = Convert.ToDouble(Console.ReadLine());

            double BMI = weight / (height * height);
            Console.WriteLine($"Your BMI is {BMI:F2}");

            if (BMI < 18.5)
                Console.WriteLine($"Your BMI of {BMI:F2} is deemed as underweight.");
            else if (BMI >= 18.5 && BMI <= 24.9)
                Console.WriteLine($"Your BMI of {BMI:F2} is a healthy weight and normal - Keep at your lifestyle.");
            else if (BMI >= 25 && BMI <= 29.9)
                Console.WriteLine($"Your BMI of {BMI:F2} is classified as overwiehgt");
            else
                Console.WriteLine($"Your BMI f {BMI:F2} is considered obese.");


            Console.Write("You people should focous more on exercising than eatin then you would not be this weight.");
        }

        
    }
}
