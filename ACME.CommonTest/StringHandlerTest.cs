using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACME.Common;

namespace ACME.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpaceTestValid()
        {
            // Arrange
            var handler = new StringHandler();

            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            // Act
            var actual = handler.InsertSpaces(source);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
