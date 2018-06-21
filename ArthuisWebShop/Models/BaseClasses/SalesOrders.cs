using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthuisWebShop.Models
{
    public class SalesOrders
    {
        public int Id { get; set; }
        public string OrderStatus { get; set; }
        public int ServiceOrderId { get; set; }
        public int ShippingOrderId { get; set; }
        public int WhsePickingOrderId { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public decimal Amount { get; set; }
        public decimal VATamount { get; set; }
        public decimal TotalAmountWithVAT { get; set; }
        public decimal Discount { get; set; }
        public Customer CustomerDetails { get; set; }
        public AddressList ShippingAddress { get; set; }
    }
}
