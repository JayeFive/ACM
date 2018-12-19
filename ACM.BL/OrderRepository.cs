using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve one order
        /// </summary>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            // Create instance of the Order class
            // Pass in the requested Id
            var order = new Order(orderId);

            // Code that retrieves one Order

            // Temporary hard coded values to return a poplutated Order
            if (order.OrderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2018, 11, 30, 17, 0, 0, new TimeSpan(-8, 0, 0));
            }

            return order;
        }

        /// <summary>
        /// Save the current order
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
