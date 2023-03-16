using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace TestProject3

{
    [TestClass]
    public class UnitTest1
    {
        private readonly StudentGrades converter = new StudentGrades();
        private int[]? testMarks;
        private int[]? value;

        [TestMethod]
        public void TestMethod1()
        {
        }

        private void TestCover39ToGradeF()
        {

            //Arrange
            Grades expectedGrade = Grades.F;

            //Act
            Grades actualGrade = converter.ConvertToGrade(39);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);

        }

        private void TestCovertoToGradeF()
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

        public void CalculateMinMax()
        {
            value = converter.Marks = testMarks;
            int expectedMin = 10;


            //value1 = converter.CalculateMinMax();


            Assert.AreEqual(expectedMin, converter.Minimum);
        }
    }
}