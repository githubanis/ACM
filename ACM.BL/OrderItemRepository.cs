using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItemRepository
    {
        public OrderItem Retrieve(int orderItemId)
        {
            OrderItem orderItem = new OrderItem(orderItemId);

            if (orderItemId == 1)
            {
                orderItem.Quantity = 20;
            }
            return orderItem;
        }

        public bool Save(OrderItem orderItem)
        {
            var success = true;

            if (orderItem.HasChanges)
            {
                if (orderItem.isValid)
                {
                    if (orderItem.IsNew)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
