using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthuisWebShop.Models
{
    public class OrderItems
    {
        public int ItemSKU { get; set; }
        public string ItemDescription { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal VATamount { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal Discount { get; set; }
        public SalesOrders SalesOrderId { get; set; }
        public CustomOrders CustomOrderId { get; set; }
        public ShippingOrders ShippingOrderId { get; set; }
    }
}
