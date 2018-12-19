using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            // Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(2018, 11, 30, 17, 0, 0, new TimeSpan(-8, 0, 0))
            };

            // Act
            var actual = orderRepository.Retrieve(10);

            // Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
