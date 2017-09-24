using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalamTestProject
{
    [TestClass]
    public class SalamUnitTest
    {
        [TestMethod]
        public void SalamToConsoleTestMethod()
        {
            // Arrange

            string expectedResult = "Assalamu alaikum";

            // Act

            string result = ConsoleApp1.Program.SalamToConsole();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
