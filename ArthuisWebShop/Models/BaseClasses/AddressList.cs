using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthuisWebShop.Models
{
    public class AddressList
    {
        public string AddressId { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string CountyRegion { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string AdditionalDetails { get; set; }
        public int OwnerId { get; set; }
        public object OwnerType { get; set; }
    }
}
