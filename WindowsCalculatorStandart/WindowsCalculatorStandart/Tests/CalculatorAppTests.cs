using NUnit.Framework;
using WindowsCalculatorStandart.App;

namespace WindowsCalculatorStandart
{
    public class CalculatorAppTests
    {
        private CalculatorApp driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new CalculatorApp();
        }

        [OneTimeTearDown]
        public void ShutDown()
        {
            driver.ShutDownApp();
        }
        [Test]
        public void ValidateCalculator_AdditionCorrectlyWithPositive()
        {
            var result = driver.AdditionOperation(driver.Num1Btn, driver.Num1Btn);
            var expected = "Display is 2";
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void ValidateCalculator_AdditionCorrectlyWithZero()
        {
            var result = driver.AdditionOperation(driver.Num0Btn, driver.Num1Btn);
            var expected = "Display is 1";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidateCalculator_SubtractionCorrectly()
        {
            var result = driver.SubtractionOperation(driver.Num2Btn, driver.Num1Btn);
            var expected = "Display is 1";
            Assert.AreEqual(expected, result);
        }


        [Test]
        public void ValidateCalculator_SubtractionCorrectlyWithZero()
        {
            var result = driver.SubtractionOperation(driver.Num0Btn, driver.Num1Btn);
            var expected = "Display is -1";
            Assert.AreEqual(expected, result);
        }
    }
}
