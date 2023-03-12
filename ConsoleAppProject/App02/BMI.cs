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
        {            
            Console.WriteLine(" BMI Calculator - Uthman Uthman.");


            Console.Write($"Hi, now let's calculate your BMI.");
            Console.Write("Enter your weight (KG's): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your height (M's): ");
            double height = Convert.ToDouble(Console.ReadLine());

            double BMI = weight / (height * height);
            Console.WriteLine($"Your BMI is {BMI:F2}");


            Console.WriteLine("Hello now we will callculater your bmi using pounds and inches.");
            Console.WriteLine("Enter your weight (LBS): ");
            double weight1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your height (INCH's): ");
            double height1 = Convert.ToDouble(Console.ReadLine());

            double BMI1 = weight * 703 / (height1 * height);
            Console.WriteLine($"Your BMI is {BMI1:F1}");

            if (BMI1 < 18.5)
                Console.WriteLine($"Your BMI of {BMI1:F1} is deemed as underweight.");
            else if (BMI1 >= 18.5 && BMI <= 24.9)
                Console.WriteLine($"Your BMI of {BMI1:F1} is a healthy weight and normal - Keep at your lifestyle.");
            else if (BMI1 >= 25 && BMI <= 29.9)
                Console.WriteLine($"Your BMI of {BMI1:F1} is classified as overwiehgt");
            else if (BMI1 >= 30.0 && BMI <= 34.9);
            else if (BMI1 >= 35.0 && BMI <= 39.9)
                Console.WriteLine($"Your BMI of {BMI1:F1} is considered obese||.");
            else if (BMI1 >= 40.0)
                Console.WriteLine($"Your BMI of {BMI1:F1} is considered obese|||.");


            if (BMI < 18.5)
                Console.WriteLine($"Your BMI of {BMI:F2} is deemed as underweight.");
            else if (BMI >= 18.5 && BMI <= 24.9)
                Console.WriteLine($"Your BMI of {BMI:F2} is a healthy weight and normal - Keep at your lifestyle.");
            else if (BMI >= 25 && BMI <= 29.9)
                Console.WriteLine($"Your BMI of {BMI:F2} is classified as overwiehgt");
            else if (BMI >= 30.0 && BMI <= 34.9)
                Console.WriteLine($"Your BMI of {BMI:F2} is considered obese|.");
            else if (BMI >= 35.0 && BMI <= 39.9)
                Console.WriteLine($"Your BMI of {BMI:F2} is considered obese||.");
            else if (BMI >= 40.0)
                Console.WriteLine($"Your BMI of {BMI:F2} is considered obese|||.");

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
        
