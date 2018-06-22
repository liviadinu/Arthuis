using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthuisWebShop.Models
{
    public class Item
    {

        public int SKU { get; set; }
        public string DisplayName { get; set; }
        public string DetailDescription { get; set; }
        public string SearchDescription { get; set; }
        public string Collection { get; set; }
     
        public bool IsAvailableToReserve { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsNewArrival { get; set; }
        public bool IsBestSeller { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsMostViewed { get; set; }

        public int AvailableStock { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrlThumbnail { get; set; }
        public ItemAttributes ItemAttributes => new ItemAttributes(SKU);
        public ItemPrices ItemPrices => new ItemPrices(SKU);

    }
}
