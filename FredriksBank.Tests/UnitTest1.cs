using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FredriksBank.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var a = 1;
            var b = 2;
            var expected = 3;

            // Act
            var result = a + b;

            // Assert
            Assert.AreEqual(expected, result, "1+2 borde vara 3");
        }
    }
}
