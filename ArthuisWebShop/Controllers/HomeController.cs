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
                Products = items.ToList()
            };

            return View(homeViewModel);
        }
    }
}
