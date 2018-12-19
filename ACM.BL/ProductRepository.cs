using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieves one product
        /// </summary>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);

            if(product.ProductId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted sizes of sunflowers";
                product.CurrentPrice = 15.96m;
            }
            return product;
        }

        /// <summary>
        /// Saves the current product
        /// </summary>
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges && product.IsValid)
            {
                if (product.IsNew)
                {
                    // Call an insert stored procedure
                }
                else
                {
                    // Call an update stored procedure
                }
            }
            return success;
        }
    }
}
