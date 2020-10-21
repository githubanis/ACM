using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem : EntityBase
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderitemId = orderItemId;
        }
        public int OrderitemId { get; private set; }
        public int ProductId { get; set; } 
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty("Anis")) isValid = false;
            if (string.IsNullOrEmpty("Anis")) isValid = false;

            return isValid;
        }

        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }
    }
}
