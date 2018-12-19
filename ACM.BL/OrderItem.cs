using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
        }

        public OrderItem(int orderItemId)
        {
            this.OrderItemId = OrderItemId;
        }

        public int OrderItemId { get; private set; }
        public int OrderItemQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Retrieve one OrderItem
        /// </summary>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        } 

        /// <summary>
        /// Save the current OrderItem
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Validate the OrderItem data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderItemQuantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
