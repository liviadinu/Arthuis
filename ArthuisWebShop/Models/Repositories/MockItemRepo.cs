using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArthuisWebShop.Models.Interfaces;

namespace ArthuisWebShop.Models.Repositories
{
    public class MockItemRepo : ISkuItemsList
    {
        private List<Item> _items;

        public MockItemRepo()
        {
            if (_items == null)
            {
                InitializeItems();
            }
        }

        private void InitializeItems()
        {
            _items = new List<Item>
            {
                new Item { SKU = 40116188, DisplayName ="HATTEN SIDE TBL 40 TRANSPARENT",    DetailDescription = "Transparent coffee table", SearchDescription = "Hatten table transparent", Collection = "Summer Vibes", AvailableToReserve = false, AvailableStock = 10 },
                new Item { SKU = 80176284, DisplayName ="HEMNES CFF TBL 118X75 BLACK-BROWN", DetailDescription = "Black/Brown coffee table", SearchDescription = "Hemnes table black-brown", Collection = "Summer Vibes", AvailableToReserve = true, AvailableStock = 15 },
                new Item { SKU = 60282134, DisplayName ="HEMNES CFF TBL 118X75 LIGHT BROWN", DetailDescription = "Light Brown coffee table", SearchDescription = "Hemnes table light-brown", Collection = "Summer Vibes", AvailableToReserve = false, AvailableStock = 20 },
                new Item { SKU = 30176286, DisplayName ="HEMNES CFF TBL 118X75 WHITE",       DetailDescription = "White coffee table",       SearchDescription = "Hemnes table white",       Collection = "Summer Vibes", AvailableToReserve = true, AvailableStock = 25 }
            };
        }

        public IEnumerable<Item> GetAllItems()
        {
            return _items ;
        }

        public Item GetItemByDescription(string Description)
        {
            return _items.FirstOrDefault(item => item.DisplayName == Description);
        }

        public Item GetItemBySKU(int SKU)
        {
            return _items.FirstOrDefault(item => item.SKU == SKU);
        }
    }
}
