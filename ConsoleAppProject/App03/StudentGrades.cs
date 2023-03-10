using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
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



        public void InputMarks() 
        {

        }

        public void OutputMarks()
        {

        }

        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < LowestMarkD) 
            {
                return Grades.F;
            }
            else return Grades.D;
        }

        public void CalculateStats()
        {

        }
    }
}
