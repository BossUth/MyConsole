using System;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
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

        public int Total { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        public StudentGrades()
        {
            Students = new string[]
            {
                "Uthman", "Aadhi", "Crown" ,"entwan"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        public void Run()
        {
            DisplayMenue();
        }

        public void DisplayMenue()
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
                    Console.WriteLine("Please Select from the Menue");
                    InputMarks();
                    
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Please Select from the Menue");
                    OutputMarks();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Please Select from the Menue");
                    OutputStatistics();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Please Select from the Menue");
                    OutputGradeProfile();
                }
                else if (choice == "5")
                {
                    Environment.Exit(0);
                }
        }

        private void OutputStatistics()
        {
            double overallMean = Mean;
            Console.WriteLine($"Mean: {overallMean:F}");

            int minimumMark = Minimum;
            Console.WriteLine($" Minimum mark: {minimumMark}");


            int maximumMark = Maximum;
            Console.WriteLine($" Maximum mark: {maximumMark}");
        }

        private void OutputGradeProfile()
        {
            Grades grades = Grades.X;
            Console.WriteLine();

            foreach(int count in GradeProfile)
                {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grades {grades} {percentage}% Count {count}");
                grades++;
            }
        }

        public void InputMarks()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                bool validInput = false;
                int mark = 0;
                while (!validInput)
                {
                    Console.WriteLine("Enter the mark..");
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out mark))
                    {
                        Console.WriteLine("error");
                    }
                    else if (mark > 100 || mark < 0)
                    {
                        Console.WriteLine("Error");
                    }
                    else
                    {
                        validInput = true;
                    }
                }
                Marks[i] = mark;
            }
            DisplayMenue();

        }

        public void OutputMarks()
        {
            for (int i = 0; i < Marks.Length; i++)
            {
                Grades outputGrade = ConvertMarktoGrades(Marks[i]);
                Console.WriteLine($"{Students[i]} ------- Mark = {Marks[i]} Grade = {outputGrade}");
            }

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
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
        }
    }
}
