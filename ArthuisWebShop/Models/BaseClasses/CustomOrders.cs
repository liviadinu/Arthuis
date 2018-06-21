using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthuisWebShop.Models
{
    public class CustomOrders
    {
        public int CustomOrderId { get; set; }
        public Customer CustomerName { get; set; }
        public Services ServiceType { get; set; }
        public SalesOrders SalesOrderDetails { get; set; }
        public decimal ServiceOrderCost { get; set; }
        public string ExpectedDeliveryTime { get; set; }       
        public string Status { get; set; }
    }
}
