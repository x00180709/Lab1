using Microsoft.VisualStudio.TestTools.UnitTesting;
using BMICalculator;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BMI bmi = new BMI { WeightStones = 15, WeightPounds = 10, HeightFeet = 6, HeightInches = 2 };
            Assert.AreNotEqual(bmi.BMICategory, BMICategory.Normal);

        }

        [TestMethod]
        public void TestMethod2()
        {
            BMI bmi = new BMI { WeightStones = 10, WeightPounds = 2, HeightFeet = 6, HeightInches = 2 };
            Assert.AreEqual(bmi.BMICategory, BMICategory.Underweight);

        }
    }
}
