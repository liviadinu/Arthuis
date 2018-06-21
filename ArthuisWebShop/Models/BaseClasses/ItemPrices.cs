using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthuisWebShop.Models
{
    public class ItemPrices
    {
        private int sKU;

        public ItemPrices(int sKU)
        {
            ItemSKU = sKU;
            Price = GetItemFixedPrice(sKU, false);
        }

        public int ItemSKU { get; set; }
        public decimal Price { get; set; }
        public decimal MaxDiscountPercAllowed { get; set; }
        public decimal SpecialPrice { get; set; }

        public decimal GetItemFixedPrice(int itemSKU, bool isSpecial)
        {

            if (itemSKU != 0)
            {
                var random = new Random();
                Price = new decimal(random.NextDouble()) * 200;
            }
            else
            {
               Price = 0;
            }
            return Price;
        }
    }
}
