using NUnit.Framework;
using MyMathLibrary;

namespace MyMathLibrary.Tests
{
    [TestFixture]
    public class MathUtilsTests
    {
        [Test]
        public void TestAdd()
        {
            // Arrange
            MathUtils mathUtils = new MathUtils();

            // Act
            int result = mathUtils.Add(2, 3);

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void TestSubtract()
        {
            // Arrange
            MathUtils mathUtils = new MathUtils();

            // Act
            int result = mathUtils.Subtract(5, 2);

            // Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void TestMultiply()
        {
            // Arrange
            MathUtils mathUtils = new MathUtils();

            // Act
            int result = mathUtils.Multiply(2, 3);

            // Assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void TestDivide()
        {
            // Arrange
            MathUtils mathUtils = new MathUtils();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => mathUtils.Divide(5, 0));
            Assert.AreEqual(2, mathUtils.Divide(10, 5));
            Assert.AreEqual(-2, mathUtils.Divide(-10, 5));
        }

        [Test]
        public void TestIsPrime()
        {
            // Arrange
            MathUtils mathUtils = new MathUtils();

            // Act & Assert
            Assert.IsFalse(mathUtils.IsPrime(1));
            Assert.IsTrue(mathUtils.IsPrime(2));
            Assert.IsTrue(mathUtils.IsPrime(7));
            Assert.IsFalse(mathUtils.IsPrime(4));
            Assert.IsFalse(mathUtils.IsPrime(0));
            Assert.IsFalse(mathUtils.IsPrime(-5));
        }
    }
}
