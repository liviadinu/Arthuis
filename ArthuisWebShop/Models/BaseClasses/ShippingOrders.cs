using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthuisWebShop.Models
{
    public class ShippingOrders
    {
        public int Id { get; set; }
        public int[] TrackingNo { get; set; }
        public string DeliveryService { get; set; }
        public int[] Services { get; set; }
        public int[] SalesOrders { get; set; }
        public int[] ItemSKU { get; set; }
        public Customer CustomerNo { get; set; }
        public AddressList ShippingAddress { get; set; }
    }
}
