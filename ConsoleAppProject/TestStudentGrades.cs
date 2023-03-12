using ConsoleAppProject.App03;
using System;


namespace ConsoleAppProject
{
    [TestClass]
    public class TestStudentGrades
    {
        
        private readonly StudentGrades converter = new StudentGrades();
        private int[] testMarks;

        public object Assert { get; private set; }

        [TestMethod]
        public void TestCovertoToGradeF()
        {

            //Arrange
            Grades expectedGrade = Grades.F;

            //Act
            Grades actualGrade = converter.ConvertToGrade(0);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);

        }

        [TestMethod]
        public void TestCover39ToGradeF()
        {

            //Arrange
            Grades expectedGrade = Grades.F;

            //Act
            Grades actualGrade = converter.ConvertToGrade(39);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);

        }

        private class TestClassAttribute : Attribute
        {
        }

        private class TestMethodAttribute : Attribute
        {
        }



        [TestMethod]
        public void TestCalculateMean()
        {
            converter.Marks = testMarks;
            double expectedMean = 55.0;
            conveter.CalculateStats();

            Assert.AreEqual(expectedMean, converter.Mean);
        }


        [TestMethod]
        public void TestGradeProfile()
        {
            // Arrage

            converter.Marks = testMarks;

            // Act
            converter.CalculateGradeProfile();

            bool expectedProfile;
            expectedProfile = ((converter.GradeProfile[0] == 3) &&
                               (converter.GradeProfile[1] == 1) &&
                               (converter.GradeProfile[2] == 1) &&
                               (converter.GradeProfile[3] == 1) &&
                               (converter.GradeProfile[4] == 4));
            // Assert
            Assert.IsTrue(expectedProfile);
        }



    }
}
