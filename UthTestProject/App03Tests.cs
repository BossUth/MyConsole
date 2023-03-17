using ConsoleAppProject.App03;

namespace UthTestProject
{
	[TestClass]
	public class App03Tests
	{
		private readonly StudentGrades converter = new();
		
		private int[]? testMarks = new int[]
		{
			10, 20, 30, 40, 50, 60, 70, 80, 90, 100
		};
		
		public int[]? value;

        public int OutputMarks { get; private set; }

        [TestMethod]
		public void TestConvert0ToGradeF()
		{
			//Arrange
			Grades expectedGrade = Grades.F;

			//Act
			Grades actualGrade = converter.ConvertToGrade(39);

			//Assert
			Assert.AreEqual(expectedGrade, actualGrade);
		}

        public void TestConvert30ToGradeF()
        {
            //Arrange
            Grades expectedGrade = Grades.F;

            //Act
            Grades actualGrade = converter.ConvertToGrade(30);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }
        public void TestConvert39ToGradeDminus()
        {
            //Arrange
            Grades expectedGrade = Grades.DMINUS;

            //Act
            Grades actualGrade = converter.ConvertToGrade(39);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
		public void TestConvert40ToGradeD()
		{

			//Arrange
			Grades expectedGrade = Grades.D;

			//Act
			Grades actualGrade = converter.ConvertToGrade(40);

			//Assert
			Assert.AreEqual(expectedGrade, actualGrade);

		}
        [TestMethod]
        public void TestConvert49ToGradeD()
        {

            //Arrange
            Grades expectedGrade = Grades.D;

            //Act
            Grades actualGrade = converter.ConvertToGrade(49);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);

        }

        [TestMethod]
        public void TestConvert50ToGradeC()
        {

            //Arrange
            Grades expectedGrade = Grades.C;

            //Act
            Grades actualGrade = converter.ConvertToGrade(50);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);

        }

        [TestMethod]
        public void TestConvert59ToGradeC()
        {

            //Arrange
            Grades expectedGrade = Grades.C;

            //Act
            Grades actualGrade = converter.ConvertToGrade(59);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);

        }

        [TestMethod]
        public void TestConvert60ToGradeB()
        {

            //Arrange
            Grades expectedGrade = Grades.B;

            //Act
            Grades actualGrade = converter.ConvertToGrade(60);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);

        }

        [TestMethod]
        public void TestConvert69ToGradeB()
        {

            //Arrange
            Grades expectedGrade = Grades.B;

            //Act
            Grades actualGrade = converter.ConvertToGrade(69);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);

        }

        [TestMethod]
        public void TestConvert70ToGradeA()
        {

            //Arrange
            Grades expectedGrade = Grades.A;

            //Act
            Grades actualGrade = converter.ConvertToGrade(70);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);

        }

        

		[TestMethod]

		public void TestMean()
		{
            StudentGrades grades = new()
            {
                Marks = testMarks
            };
            grades.CalculateMean();

            OutputMarks = 55;

            Assert.AreEqual(OutputMarks, grades.Mean);
        }


        [TestMethod]
		public void GradeProfile()
        {
			// Arrage

			converter.Marks = testMarks;

            // Act
            converter.CalculateGradeProfileUnitTest();

			 bool expectedProfile;
			
			expectedProfile = ((converter.GradeProfile[0] == 3 &&
							   converter.GradeProfile[1] == 1 &&
							   converter.GradeProfile[2] == 1 &&
							   converter.GradeProfile[3] == 1 &&
							   converter.GradeProfile[4] == 4));
			// Assert
			Assert.IsTrue(expectedProfile);
		}

		[TestMethod]
		public void CalculateMinMax()
		{
			value = converter.Marks = testMarks;

			int expectedMin = 10;
			int expectedMax = 100;

			converter.CalculateMinMax();

			Assert.AreEqual(expectedMin, converter.Minimum);
			Assert.AreEqual(expectedMax, converter.Maximum);
		}
	}

}