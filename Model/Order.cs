using System;
using System.Collections.Generic;

namespace CP.API.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }//delete
        public PaymentType Payment { get; set; }
        public int PaymentId { get; set; }
        public Shipper Shipper { get; set; }
        public int ShipperId { get; set; }
        public User user { get; set; }
        public int userId { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

        


    }
}