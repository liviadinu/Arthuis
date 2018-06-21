using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthuisWebShop.Models
{
    public class ItemVariant
    {
        public string VariantCode { get; set; }
        public int ItemSKU { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
    }
}
