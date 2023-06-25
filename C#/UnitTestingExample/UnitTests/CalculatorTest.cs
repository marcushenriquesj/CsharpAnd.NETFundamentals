using UnitTestingExample;

namespace UnitTests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Calculator_Sum_Returns19for12And7()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Sum(12, 7);

            //Assert
            Assert.AreEqual(19, result);
        }

        [TestMethod]
        public void Calculator_Divide_Returns10for200And20()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Divide(200, 20);

            //Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Calculator_Divide_ThrowsExceptionFor100and0()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            calculator.Divide(100, 0);
        }
    }
}