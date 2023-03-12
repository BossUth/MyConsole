using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.WindowsRuntime;
using ConsoleAppProject.Helpers;

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
        

        //
        public string[] Students { get; set; }

        public int[] Marks { get; set; }

        public int[] GradeProfile { get; set; }

        public double [] Mean { get; set; }

        public int [] Minimum { get; set;}

        public int[] Maximum { get; set;}


        public StudentGrades()
        {
            Students = new string[] 
            {
                "Uthman", "Aadhi", "Crown"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }



        public void DisplayMenue()
        {

        }

        public void InputMarks() 
        {

        }

        public void OutputMarks()
        {
            Grade grade = Grade.x;
            Console.WriteLine();
            
            foreach(int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} {percentage}% Count {count}");
                grade++;
            }

            Console.WriteLine();

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

        public void CalculateStats()
        {
            double total = 0;

            Minimum = HighestMarkPerfect;
            Maximum = 0;
            foreach(int mark in Marks)
            {
                total = total + mark;
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
            }

            Mean = total / Marks.Length;
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

        private class Grade
        {
            internal static Grade x;
        }
    }
}
