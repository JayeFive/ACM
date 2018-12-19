﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {
        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        /// <summary>
        /// Retrieves one product
        /// </summary>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            return new Product();
        }

        /// <summary>
        /// Saves the current product
        /// </summary>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Validates the product data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }


}