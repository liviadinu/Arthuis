using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthuisWebShop.Models
{
    public class ItemAttributes
    {
        public ItemAttributes(int sKU)
        {
            SKU = sKU;
            Color = "Reducer";
        }

        public int SKU { get; set; }
        public string Color { get; set; }
        public DateTime LeadTimeReceiver { get; set; }
        public decimal Height { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal GrossWeight { get; set; }
        public decimal NetWeight { get; set; }
        public decimal UnitVolume { get; set; }
        public decimal UnitsPerParcel { get; set; }
        public string BaseUnitOfMeasure { get; set; }
        public decimal UnitCost { get; set; }
        public string VendorNo { get; set; }
        public string VendorItemNo { get; set; }
        public string AlternativeItemSKU { get; set; }
        public decimal Inventory { get; set; }
        public decimal ReorderPoint { get; set; }
        public bool Discontinued { get; set; }
    }
}
