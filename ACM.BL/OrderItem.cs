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
        public OrderItem(int OrderItemId)
        {
            this.OrderitemId = OrderItemId;
        }
        public int OrderitemId { get; private set; }
        public int ProductId { get; set; } 
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        public OrderItem Retrieve(int customerId)
        {
            return new OrderItem();
        }
        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValid = true;

            //if (string.IsNullOrEmpty(LastName)) isValid = false;
            //if (string.IsNullOrEmpty(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
