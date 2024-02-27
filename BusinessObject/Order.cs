using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Order
    {
        public int OrderId { get; set; }
        public int MemberId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set;}
        public float Freight { get; set; }

        public Order(int orderId, int memberId, DateTime orderDate, DateTime requiredDate, DateTime shippedDate, float freight)
        {
            OrderId = orderId;
            MemberId = memberId;
            OrderDate = orderDate;
            RequiredDate = requiredDate;
            ShippedDate = shippedDate;
            Freight = freight;
        }
    }
}
