using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System.Collections.Generic;

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

        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            // Arrange
            var orderRepository = new OrderRepository();
            var expected = new OrderDisplay()
            {
                FirstName = "Bilbo",
                LastName = "Baggins",
                OrderDate = new DateTimeOffset(2018, 11, 10, 13, 0, 0, new TimeSpan(-8, 0, 0)),
                ShippingAddress = new Address()
                {
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                },
                OrderDisplayItemList = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                        ProductName = "Sunflowers",
                        PurchasePrice = 15.96m,
                        OrderQunatity = 2
                    },
                    new OrderDisplayItem()
                    {
                        ProductName = "Rake",
                        PurchasePrice = 6m,
                        OrderQunatity = 1
                    }
                }
            };
        }
    }
}
