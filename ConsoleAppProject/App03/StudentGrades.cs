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

        // THis is the objects
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }

        public int[] Counts = new int[10];

        public int students;

        public int Total { get; set; }
        public int Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }


        // This is for the names for the students
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

        //This is the run method

        public void Run()
        {
            DisplayMenu();
        }


        //This is the Menu for you to pick form
        //The list
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

        // This is for to calculate the minmax
        // Tis is to calculate the Mean

        private void OutputStatistics()
        {
            CalculateMean();
            CalculateMinMax();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press a key");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadKey();
            DisplayMenu();
        }


        // Output the grade profile

        private void OutputGradeProfile()
        {
            CalculateGradeProfile();
            // ADDING UP ALL THE GRADE COUNTS SO I CAN USE IT AS A TOTAL STUDENTS
            //int total = Counts.Sum();
            // PRINTING ON THE SCREEN 
            Grades grades = Grades.X;
            Console.WriteLine();
            foreach (int count in Counts)
            {
                int percentage = count * 100/ Marks.Length;
                Console.WriteLine($"Grade {grades}{percentage}% Count {grades}");
                grades++;
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press a key");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadKey();
            DisplayMenu();
        }
       

        // This is to input the marks that will show on display
        // And if invalid show error

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

        // Output the marks
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

            // This will allow me to carry on until i end it

            Console.WriteLine($"These are the {students}" + " students. ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press a key");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadKey();
            DisplayMenu();


        }


        // Convert the marks
        public Grades ConvertMarktoGrades(int mark)
        {
            if (mark < 40)
            {
                return Grades.F;
            }

            else if ( mark < 50)
            {
                return Grades.D;
            }

            else if (mark < 60)
            {
                return Grades.C;
            }

            else if (mark < 70)
            {
                return Grades.B;
            }

            else if (mark <= 100)
            {
                return Grades.A;
            }

            return Grades.X;

        }


        // this is to conver to grades

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

        // This is where the calculations will held

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


        // this is to calculate the mean for the amount of marks.
        public void CalculateMean()
        {
            foreach (int mark in Marks)
            {
                if (mark < Minimum)
                {
                    Minimum = mark;
                }
                if (mark > Maximum)
                {
                    Maximum = mark;
                }

                Total += mark;
            }
            Mean = Total / Students.Length;

            Console.WriteLine($"Mean Mark: {Mean}\nMinimum Mark: {Minimum}\nMaximum Mark: {Maximum}");

        }


        // to calculate the grade profile which will tell
        // the amount of studnts got the a certern amount a marks

        public void CalculateGradeProfile()
        {
            foreach (int mark in Marks)
            {
                if (mark <= FIRSTCLASS)
                {
                    Counts[0]++;
                }
                else if (mark <= UPPERSECONDCLASS)
                {
                    Counts[1]++;
                }
                else if (mark <= LOWERSECONDCLASS)
                {
                    Counts[2]++;
                }
                else if (mark <= THIRDCLASS)
                {
                    Counts[3]++;
                }
                else if (mark >= FAIL)
                {
                    Counts[4]++;
                }

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
                Counts[(int)grade]++;
            }
        }
    }
}
