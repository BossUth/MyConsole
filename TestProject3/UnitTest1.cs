using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace TestProject3

{
    [TestClass]
    public class UnitTest1
    {
        private readonly StudentGrades converter = new StudentGrades();
        private int[]? testMarks = new int[]
        {
            10, 20, 30, 40, 50, 60, 70, 80, 90, 100
        };
        private int[]? value;

        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        private void TestCover39ToGradeF()
        {

            //Arrange
            Grades expectedGrade = Grades.F;

            //Act
            Grades actualGrade = converter.ConvertToGrade(39);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);

        }

        [TestMethod]
        private void TestCovert0ToGradeF()
        {

            //Arrange
            Grades expectedGrade = Grades.F;

            //Act
            Grades actualGrade = converter.ConvertToGrade(0);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);

        }


        [TestMethod]
        public void TestGradeProfile()
        {
            // Arrage

            converter.Marks = testMarks;

            // Act
            converter.CalculateGradeProfile();

            bool expectedProfile;
            expectedProfile = converter.GradeProfile[0] == 3 &&
                               converter.GradeProfile[1] == 1 &&
                               converter.GradeProfile[2] == 1 &&
                               converter.GradeProfile[3] == 1 &&
                               converter.GradeProfile[4] == 4;
            // Assert
             Assert.IsTrue(expectedProfile);
        }

        [TestMethod]
        public void CalculateMinMax()
        {
            value = converter.Marks = testMarks;
            int expectedMin = 10;


            value = converter.Marks = testMarks;
            int expectedMax = 100;

            Assert.AreEqual(expectedMin, converter.Minimum);
            Assert.AreEqual(expectedMax, converter.Maximum);
        }
    }
}