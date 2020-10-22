using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : EntityBase , ILoggable
    {
        public Order() : this(0)
        {

        }
        public Order(int OrderId)
        {
            this.OrderId = OrderId;
            orderItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderItem> orderItems { get; set; } 
        public int ShippingAddressId { get; set; }
        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";


        public List<Order> Retrieve()
        {
            return new List<Order>();
        }
        
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty("Anis")) isValid = false;
            if (string.IsNullOrEmpty("Anis")) isValid = false;

            return isValid;
        }

        public string Log()
        {
            throw new NotImplementedException();
        }
    }
}
