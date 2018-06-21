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
        public List<Item> Products { get; set; }
    }
}
