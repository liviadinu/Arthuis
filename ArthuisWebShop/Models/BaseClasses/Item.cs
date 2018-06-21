using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthuisWebShop.Models
{
    public class Item
    {
        private int _myProperty;

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
        public int AvailableStock { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrlThumbnail { get; set; }
        public ItemAttributes ItemAttributes => new ItemAttributes(SKU);
        public decimal Price => GetItemPrice(SKU);

        private decimal GetItemPrice(int sKU)
        {
            ItemPrices prodPrice = new ItemPrices(SKU);
            return prodPrice.Price;
        }
    }
}
