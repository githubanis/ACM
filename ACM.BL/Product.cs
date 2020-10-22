using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase , ILoggable
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

        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }
        public decimal? CurrentPrice { get; set; }

        public string Log() => $"{ProductId}: {ProductName} Details: {ProductDescription} Status: {EntityState.ToString()}";

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
