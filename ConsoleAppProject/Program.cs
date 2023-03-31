using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
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
             
             Console.WriteLine();
             Console.WriteLine("----------------------------------------------------------------------------");
             Console.WriteLine("         This is Uthmans Console App Project BY UTHMAN UTHMAN-NURENI    ");
             Console.WriteLine("----------------------------------------------------------------------------");
             Console.Beep();

             DistanceConverter converter = new DistanceConverter();
            StudentGrades studentgrades = new StudentGrades();
            NetworkApp app04 = new NetworkApp();

            Console.WriteLine("\t");
            Console.WriteLine("  Choose the application by entering the number ");
            Console.WriteLine(" 1. Distance Converter ");
            Console.WriteLine(" 2. BMI Calculator ");
            Console.WriteLine(" 3. Student Grades ");
            Console.WriteLine(" 4. Social Network ");

            Console.WriteLine("\t");
            Console.Write("Answer : ");

            string choicestr = Console.ReadLine();
            int choice;
            if (!int.TryParse(choicestr, out choice) || (choice < 1 || choice > 4))
            {
                Console.WriteLine("Error! Try again");
                return;
            }

            if (choice == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine(" =================================================");
                Console.WriteLine("          Welcome to Distance Converter! ");
                Console.WriteLine(" =================================================");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                converter.ConvertDistance();

            }
            
            else if (choice == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine(" =================================================");
                Console.WriteLine("          Welcome to Students Grades App! ");
                Console.WriteLine(" =================================================");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                studentgrades.Run();
            }

            else if (choice == 4)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine(" =================================================");
                Console.WriteLine("          Welcome to Students Grades App! ");
                Console.WriteLine(" =================================================");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                app04.Run();
            }
            
            app04.Run();
        }


    }
}
