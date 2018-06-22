using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ArthuisWebShop.Models.Interfaces;
using ArthuisWebShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArthuisWebShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISkuItemsList _itemRepository;

        public HomeController(ISkuItemsList itemRepository)
        {
            //constructor injection; we receive MockRepository from Startup class
            _itemRepository = itemRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var items = _itemRepository.GetAllItems().OrderBy(p => p.DisplayName);
            var homeViewModel = new HomeViewModel()
            {
                Title = "Arthuis Catalog - Summer 2018",
                NewProducts = _itemRepository.GetFlaggedList(FlagtType.NewArrival,8).OrderBy(p => p.DisplayName).ToList(),
                FeaturedProducts = _itemRepository.GetFlaggedList(FlagtType.FeaturedProduct,8).OrderBy(p => p.DisplayName).ToList(),
                DiscountedProducts = _itemRepository.GetFlaggedList(FlagtType.DiscountedProduct, 8).OrderBy(p => p.DisplayName).ToList(),
                BestSellingProducts = _itemRepository.GetFlaggedList(FlagtType.BestSeller, 8).OrderBy(p => p.DisplayName).ToList(),
                MostViewedProducts = _itemRepository.GetFlaggedList(FlagtType.MostViewed, 8).OrderBy(p => p.DisplayName).ToList(),
            };
            return View(homeViewModel);
        }

        public IActionResult ShopSidebar()
        {
            var shopGridModel = new ShopGridViewModel()
            {
                Title = "Products"
            };
            return View(shopGridModel);
        }
    }
}
