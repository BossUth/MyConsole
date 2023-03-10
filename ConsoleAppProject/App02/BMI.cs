using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This app is for Calculating BMI
    /// </summary>
    /// <author>
    /// Uthman Uthman-Nureni version 0.1
    /// </author>
    /// 
    /// <summary>
    /// Less than 16.0 - Serverley Underweight
    /// From 16.0 to 18.5 - Under Weight
    /// From 18.6 to 35.0 - Normal Weight
    /// From 25.1 to 30.0 - Over Weight
    /// From 30.1 to 35.0 - Moderately Obese
    /// More than 35.0 - Severly Obese
    /// </summary>
    public class Program
    {
        public void Main()
        {            Console.WriteLine(" BMI Calculator - Uthman Uthman.");


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


            /// Less than 16.0 - Serverley Underweight
            /// From 16.0 to 18.5 - Under Weight
            /// From 18.6 to 35.0 - Normal Weight
            /// From 25.1 to 30.0 - Over Weight
            /// From 30.1 to 35.0 - Moderately Obese
            /// More than 35.0 - Severly Obese
        }


        
        
        

    }
}
        
