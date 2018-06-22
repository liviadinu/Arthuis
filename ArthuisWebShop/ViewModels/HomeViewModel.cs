using ArthuisWebShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthuisWebShop.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Item> NewProducts { get; set; }
        public List<Item> FeaturedProducts { get; set; }
        public List<Item> DiscountedProducts { get; set; }
        public List<Item> BestSellingProducts { get; set; }
        public List<Item> MostViewedProducts { get; set; }
    }
}
