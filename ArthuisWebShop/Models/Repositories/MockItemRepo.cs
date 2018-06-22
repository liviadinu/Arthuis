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
                new Item { SKU = 40116181, DisplayName ="HATTEN SIDE TBL 40 TRANSPARENT",    DetailDescription = "Transparent coffee table",IsBestSeller = true, SearchDescription = "Hatten table transparent", Collection = "Summer Vibes",  AvailableStock = 10 },
                new Item { SKU = 80176282, DisplayName ="HEMNES CFF TBL 118X75 BLACK-BROWN", DetailDescription = "Black/Brown coffee table",IsBestSeller = true, SearchDescription = "Hemnes table black-brown", Collection = "Summer Vibes",  AvailableStock = 15 },
                new Item { SKU = 60282133, DisplayName ="HEMNES CFF TBL 118X75 LIGHT BROWN", DetailDescription = "Light Brown coffee table",IsBestSeller = true, SearchDescription = "Hemnes table light-brown", Collection = "Summer Vibes",  AvailableStock = 20 },
                new Item { SKU = 30176284, DisplayName ="HEMNES CFF TBL 118X75 WHITE",       DetailDescription = "White coffee table",      IsBestSeller = true, SearchDescription = "Hemnes table white",       Collection = "Summer Vibes",  AvailableStock = 25 },
                new Item { SKU = 40116185, DisplayName ="HATTEN SIDE TBL 40 TRANSPARENT",    DetailDescription = "Transparent coffee table",IsBestSeller = true, SearchDescription = "Hatten table transparent", Collection = "Summer Vibes",  AvailableStock = 10 },
                new Item { SKU = 80176286, DisplayName ="HEMNES CFF TBL 118X75 BLACK-BROWN", DetailDescription = "Black/Brown coffee table",IsBestSeller = true, SearchDescription = "Hemnes table black-brown", Collection = "Summer Vibes",  AvailableStock = 15 },
                new Item { SKU = 60282137, DisplayName ="HEMNES CFF TBL 118X75 LIGHT BROWN", DetailDescription = "Light Brown coffee table",IsBestSeller = true, SearchDescription = "Hemnes table light-brown", Collection = "Summer Vibes",  AvailableStock = 20 },
                new Item { SKU = 30176288, DisplayName ="HEMNES CFF TBL 118X75 WHITE",       DetailDescription = "White coffee table",      IsBestSeller = true, SearchDescription = "Hemnes table white",       Collection = "Summer Vibes",  AvailableStock = 25 },

                new Item { SKU = 10116188, DisplayName ="ARTHUIS SIDE TBL 40 TRANSPARENT",    DetailDescription = "Transparent coffee table",IsFeatured = true, SearchDescription = "Hatten table transparent", Collection = "Summer Vibes",  AvailableStock = 10 },
                new Item { SKU = 20176284, DisplayName ="ARTHUIS CFF TBL 118X75 BLACK-BROWN", DetailDescription = "Black/Brown coffee table",IsFeatured = true, SearchDescription = "Hemnes table black-brown", Collection = "Summer Vibes",  AvailableStock = 15 },
                new Item { SKU = 30282134, DisplayName ="ARTHUIS CFF TBL 118X75 LIGHT BROWN", DetailDescription = "Light Brown coffee table",IsFeatured = true, SearchDescription = "Hemnes table light-brown", Collection = "Summer Vibes",  AvailableStock = 20 },
                new Item { SKU = 40176286, DisplayName ="ARTHUIS CFF TBL 118X75 WHITE",       DetailDescription = "White coffee table",      IsFeatured = true, SearchDescription = "Hemnes table white",       Collection = "Summer Vibes",  AvailableStock = 25 },
                new Item { SKU = 50116188, DisplayName ="ARTHUIS SIDE TBL 40 TRANSPARENT",    DetailDescription = "Transparent coffee table",IsFeatured = true, SearchDescription = "Hatten table transparent", Collection = "Summer Vibes",  AvailableStock = 10 },
                new Item { SKU = 60176284, DisplayName ="ARTHUIS CFF TBL 118X75 BLACK-BROWN", DetailDescription = "Black/Brown coffee table",IsFeatured = true, SearchDescription = "Hemnes table black-brown", Collection = "Summer Vibes",  AvailableStock = 15 },
                new Item { SKU = 70282134, DisplayName ="ARTHUIS CFF TBL 118X75 LIGHT BROWN", DetailDescription = "Light Brown coffee table",IsFeatured = true, SearchDescription = "Hemnes table light-brown", Collection = "Summer Vibes",  AvailableStock = 20 },
                new Item { SKU = 80176286, DisplayName ="ARTHUIS CFF TBL 118X75 WHITE",       DetailDescription = "White coffee table",      IsFeatured = true, SearchDescription = "Hemnes table white",       Collection = "Summer Vibes",  AvailableStock = 25 },

                new Item { SKU = 40110000, DisplayName ="MAKREL SIDE TBL 40 TRANSPARENT",    DetailDescription = "Transparent coffee table",IsNewArrival = true, SearchDescription = "Hatten table transparent", Collection = "Summer Vibes",  AvailableStock = 10 },
                new Item { SKU = 80170000, DisplayName ="MAKREL CFF TBL 118X75 BLACK-BROWN", DetailDescription = "Black/Brown coffee table",IsNewArrival = true, SearchDescription = "Hemnes table black-brown", Collection = "Summer Vibes",  AvailableStock = 15 },
                new Item { SKU = 60280000, DisplayName ="MAKREL CFF TBL 118X75 LIGHT BROWN", DetailDescription = "Light Brown coffee table",IsNewArrival = true, SearchDescription = "Hemnes table light-brown", Collection = "Summer Vibes",  AvailableStock = 20 },
                new Item { SKU = 30170000, DisplayName ="MAKREL CFF TBL 118X75 WHITE",       DetailDescription = "White coffee table",      IsNewArrival = true, SearchDescription = "Hemnes table white",       Collection = "Summer Vibes",  AvailableStock = 25 },
                new Item { SKU = 40110000, DisplayName ="MAKREL SIDE TBL 40 TRANSPARENT",    DetailDescription = "Transparent coffee table",IsNewArrival = true, SearchDescription = "Hatten table transparent", Collection = "Summer Vibes",  AvailableStock = 10 },
                new Item { SKU = 80170000, DisplayName ="MAKREL CFF TBL 118X75 BLACK-BROWN", DetailDescription = "Black/Brown coffee table",IsNewArrival = true, SearchDescription = "Hemnes table black-brown", Collection = "Summer Vibes",  AvailableStock = 15 },
                new Item { SKU = 60280000, DisplayName ="MAKREL CFF TBL 118X75 LIGHT BROWN", DetailDescription = "Light Brown coffee table",IsNewArrival = true, SearchDescription = "Hemnes table light-brown", Collection = "Summer Vibes",  AvailableStock = 20 },
                new Item { SKU = 30170000, DisplayName ="MAKREL CFF TBL 118X75 WHITE",       DetailDescription = "White coffee table",      IsNewArrival = true, SearchDescription = "Hemnes table white",       Collection = "Summer Vibes",  AvailableStock = 25 },

                new Item { SKU = 00006188, DisplayName ="BAUHAUS SIDE TBL 40 TRANSPARENT",    DetailDescription = "Transparent coffee table",IsOnSale = true, SearchDescription = "Hatten table transparent", Collection = "Summer Vibes",  AvailableStock = 10 },
                new Item { SKU = 00006284, DisplayName ="BAUHAUS CFF TBL 118X75 BLACK-BROWN", DetailDescription = "Black/Brown coffee table",IsOnSale = true, SearchDescription = "Hemnes table black-brown", Collection = "Summer Vibes",  AvailableStock = 15 },
                new Item { SKU = 00002134, DisplayName ="BAUHAUS CFF TBL 118X75 LIGHT BROWN", DetailDescription = "Light Brown coffee table",IsOnSale = true, SearchDescription = "Hemnes table light-brown", Collection = "Summer Vibes",  AvailableStock = 20 },
                new Item { SKU = 00006286, DisplayName ="BAUHAUS CFF TBL 118X75 WHITE",       DetailDescription = "White coffee table",      IsOnSale = true, SearchDescription = "Hemnes table white",       Collection = "Summer Vibes",  AvailableStock = 25 },
                new Item { SKU = 00006188, DisplayName ="BAUHAUS SIDE TBL 40 TRANSPARENT",    DetailDescription = "Transparent coffee table",IsOnSale = true, SearchDescription = "Hatten table transparent", Collection = "Summer Vibes",  AvailableStock = 10 },
                new Item { SKU = 00006284, DisplayName ="BAUHAUS CFF TBL 118X75 BLACK-BROWN", DetailDescription = "Black/Brown coffee table",IsOnSale = true, SearchDescription = "Hemnes table black-brown", Collection = "Summer Vibes",  AvailableStock = 15 },
                new Item { SKU = 00002134, DisplayName ="BAUHAUS CFF TBL 118X75 LIGHT BROWN", DetailDescription = "Light Brown coffee table",IsOnSale = true, SearchDescription = "Hemnes table light-brown", Collection = "Summer Vibes",  AvailableStock = 20 },
                new Item { SKU = 00006286, DisplayName ="BAUHAUS CFF TBL 118X75 WHITE",       DetailDescription = "White coffee table",      IsOnSale = true, SearchDescription = "Hemnes table white",       Collection = "Summer Vibes",  AvailableStock = 25 },

                new Item { SKU = 10006188, DisplayName ="HORIAET SIDE TBL 40 TRANSPARENT",    DetailDescription = "Transparent coffee table",IsMostViewed = true, SearchDescription = "Hatten table transparent", Collection = "Summer Vibes",  AvailableStock = 10 },
                new Item { SKU = 20006284, DisplayName ="HORIAET CFF TBL 118X75 BLACK-BROWN", DetailDescription = "Black/Brown coffee table",IsMostViewed = true, SearchDescription = "Hemnes table black-brown", Collection = "Summer Vibes",  AvailableStock = 15 },
                new Item { SKU = 30002134, DisplayName ="HORIAET CFF TBL 118X75 LIGHT BROWN", DetailDescription = "Light Brown coffee table",IsMostViewed = true, SearchDescription = "Hemnes table light-brown", Collection = "Summer Vibes",  AvailableStock = 20 },
                new Item { SKU = 40006286, DisplayName ="HORIAET CFF TBL 118X75 WHITE",       DetailDescription = "White coffee table",      IsMostViewed = true, SearchDescription = "Hemnes table white",       Collection = "Summer Vibes",  AvailableStock = 25 },
                new Item { SKU = 50006188, DisplayName ="HORIAET SIDE TBL 40 TRANSPARENT",    DetailDescription = "Transparent coffee table",IsMostViewed = true, SearchDescription = "Hatten table transparent", Collection = "Summer Vibes",  AvailableStock = 10 },
                new Item { SKU = 60006284, DisplayName ="HORIAET CFF TBL 118X75 BLACK-BROWN", DetailDescription = "Black/Brown coffee table",IsMostViewed = true, SearchDescription = "Hemnes table black-brown", Collection = "Summer Vibes",  AvailableStock = 15 },
                new Item { SKU = 70002134, DisplayName ="HORIAET CFF TBL 118X75 LIGHT BROWN", DetailDescription = "Light Brown coffee table",IsMostViewed = true, SearchDescription = "Hemnes table light-brown", Collection = "Summer Vibes",  AvailableStock = 20 },
                new Item { SKU = 80006286, DisplayName ="HORIAET CFF TBL 118X75 WHITE",       DetailDescription = "White coffee table",      IsMostViewed = true, SearchDescription = "Hemnes table white",       Collection = "Summer Vibes",  AvailableStock = 25 }
            };
        }

        public IEnumerable<Item> GetAllItems()
        {
            return _items.Take(4);
        }

        public Item GetItemByDescription(string Description)
        {
            return _items.FirstOrDefault(item => item.DisplayName == Description);
        }

        public Item GetItemBySKU(int SKU)
        {
            return _items.FirstOrDefault(item => item.SKU == SKU);
        }

        public IEnumerable<Item> GetFlaggedList(FlagtType flag, int group)
        {
            switch (flag)
            {
                case FlagtType.BestSeller:
                        return _items.Where(item => item.IsNewArrival == true).Take(group);
                case FlagtType.DiscountedProduct:
                        return _items.Where(item => item.IsOnSale == true).Take(group);
                case FlagtType.FeaturedProduct:
                        return _items.Where(item => item.IsFeatured == true).Take(group);
                case FlagtType.MostViewed:
                        return _items.Where(item => item.IsMostViewed == true).Take(group);
                case FlagtType.AvailableToReserve:
                        return _items.Where(item => item.IsAvailableToReserve == true).Take(group);
                default:
                        return _items.OrderBy(p => p.SKU).Take(group);
            }
        }
    }
}