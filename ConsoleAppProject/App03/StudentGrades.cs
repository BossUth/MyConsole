using LanguageExt.TypeClasses;
using System;
using System.Linq;
using System.Text;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {


        public const int FIRSTCLASS = 70;
        public const int UPPERSECONDCLASS = 60;
        public const int LOWERSECONDCLASS = 50;
        public const int THIRDCLASS = 40;
        public const int FAIL = 0;


        // The Grade Boundaries

        public const int LowestMarkLowest = 0;
        public const int LowestMarkD = 40;
        public const int LowestMarkC = 50;
        public const int LowestMarkB = 60;
        public const int LowestMarkA = 70;
        public const int HighestMarkPerfect = 100;
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }

        public int[] Counts = new int[10];

        public int students;

        public int Total { get; set; }
        public int Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        public StudentGrades()
        {
            Students = new string[]
            {
                "Uthman", "Aadhi", "Crown" ,"Entwan",
                "Chole", "Ben", "John", "Sophie",
                "Johnathon", "Benjamain"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        public void Run()
        {
            DisplayMenu();
        }

        public void DisplayMenu()
        {
            Console.WriteLine("1. Input Marks");
            Console.WriteLine("2. Output Grades");
            Console.WriteLine("3. Output Statistics");
            Console.WriteLine("4. Output Grade Profile");
            Console.WriteLine("5. Quit");
            string choice;

           
                Console.WriteLine("\t");
                Console.Write("Answer : ");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("Please Select from the Menu");
                    InputMarks();
                    
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Please Select from the Menu");
                    OutputMarks();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Please Select from the Menu");
                    OutputStatistics();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Please Select from the Menu");
                    OutputGradeProfile();
                }
                else if (choice == "5")
                {
                    Environment.Exit(0);
                }
        }

        private void OutputStatistics()
        {
            CalculateMean();
            CalculateMinMax();
            Console.WriteLine($"Mean Mark: {Mean}\nMinimum Mark: {Minimum}\nMaximum Mark: {Maximum}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press a key");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadKey();
            DisplayMenu();
        }

        private void OutputGradeProfile()
        {
            CalculateGradeProfile();
            // ADDING UP ALL THE GRADE COUNTS SO I CAN USE IT AS A TOTAL STUDENTS
            int total = Counts.Sum();
            double total1 = Counts.Sum();
            // PRINTING ON THE SCREEN 
            Console.WriteLine($" A (First Class) > There are {Counts[0]} students in this range, which is {(int)Counts[0] / total:P}");
            Console.WriteLine($" B (Upper Second Class) > {Counts[1]} students in this range, which is {(int)Counts[1] / total:P}");
            Console.WriteLine($" C (Lower Second Class) > {Counts[2]} students in this range, which is  {(int)Counts[2] / total:P}");
            Console.WriteLine($" D (Third Class) > {Counts[3]} students in this range, which is  {(int)Counts[3] / total:P}");
            Console.WriteLine($" F (Fail) > {Counts[4]} students in this range, which is  {(int)Counts[4] / total:P}");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press a key");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadKey();
            DisplayMenu();
        }
       

        public void InputMarks()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                bool validInput = false;
                int mark = 0;
                while (!validInput)
                {
                    Console.WriteLine("Enter the marks for..  " + Students[i] );

                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out mark))
                    {
                        Console.WriteLine("error");
                    }
                    else if (mark > 100 || mark < 0)
                    {
                        Console.WriteLine("Error!");
                    }
                    else
                    {
                        validInput = true;
                    }
                }
                Marks[i] = mark;
            }
            DisplayMenu();

        }

        public void OutputMarks()
        {
            Console.WriteLine("Names".PadRight(14) + "Marks".PadRight(8) + "Grade");
            Console.WriteLine("===".PadRight(14)   + "====".PadRight(8)  + "====");
            int students = 0;
            for (int i = 0; i < Marks.Length; i++)
            {
                int mark = Marks[i];
                Grades grades = ConvertMarktoGrades(mark);
                Console.Write($"{Students[i]}".PadRight(13));
                Console.Write($"{Marks[i]}".PadRight(8));
                Console.Write($"{grades}".PadRight(1));
                Console.WriteLine();
                students++;


            }

            Console.WriteLine($"These are the {students}" + " students. ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press a key");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadKey();
            DisplayMenu();


        }

        public Grades ConvertMarktoGrades(int mark)
        {
            if (mark < 40)
            {
                return Grades.F;
            }

            else if (mark > 39 && mark < 50)
            {
                return Grades.D;
            }

            else if (mark > 49 && mark < 60)
            {
                return Grades.C;
            }

            else if (mark > 59 && mark < 70)
            {
                return Grades.B;
            }

            else if (mark > 69)
            {
                return Grades.A;
            }

            return Grades.X;

        }

        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < LowestMarkD)
            {
                return Grades.F;
            }
            else if (mark >= LowestMarkD && mark < LowestMarkC)
            {
                return Grades.D;
            }
            else if (mark >= LowestMarkC && mark < LowestMarkB)
            {
                return Grades.C;
            }
            else if (mark >= LowestMarkB && mark < LowestMarkA)
            {
                return Grades.B;
            }
            else if (mark >= LowestMarkA && mark < HighestMarkPerfect)
            {
                return Grades.A;
            }
            return Grades.F;

        }

        public void CalculateMinMax()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];

            foreach (int mark in Marks)
            {
                if (mark > Maximum)
                {
                    Maximum = mark;
                }
                else if (mark < Minimum)
                {
                    Minimum = mark;
                }
            }
        }
        public void CalculateMean()
        {
            foreach (int mark in Marks)
            {
                if (mark > Maximum) { Maximum = mark; }

                if (mark < Minimum) { Minimum = mark; }
                Total += mark;
            }
            double Mean = (double)Total / Students.Length;
        }

        public void CalculateGradeProfile()
        {
            

            foreach (int mark in Marks)
            {
                if (mark >= FIRSTCLASS)
                {
                    Counts[0]++;
                }
                else if (mark >= UPPERSECONDCLASS)
                {
                    Counts[1]++;
                }
                else if (mark >= LOWERSECONDCLASS)
                {
                    Counts[2]++;
                }
                else if (mark >= THIRDCLASS)
                {
                    Counts[3]++;
                }
                else
                {
                    Counts[4]++;
                }
            }

            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
        }

        public void CalculateGradeProfileUnitTest()
        {
            for (int i = 0; i < Counts.Length; i++)
            {
                Counts[i] = 0;
            }
            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
        }
    }
}
