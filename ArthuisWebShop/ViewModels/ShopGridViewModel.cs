using ArthuisWebShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthuisWebShop.ViewModels
{
    public class ShopGridViewModel
    {
        public string Title { get; set; }
        public List<Item> AvailableProducts { get; set; }
    }
}
