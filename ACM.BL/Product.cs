﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {

        }
        public Product(int ProductId)
        {
            this.ProductId = ProductId;
        }
        public string ProductDescription { get; set; } 
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public decimal? CurrentPrice { get; set; }

        public override string ToString() => ProductName;
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
        
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }
    }
}
