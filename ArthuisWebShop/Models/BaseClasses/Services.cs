using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthuisWebShop.Models
{
    public class Services
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceProvider { get; set; }
        public decimal ServiceCost { get; set; }
        public decimal ServicePrice { get; set; }
        public int[] SalesOrder { get; set; }
    }
}
