using Microsoft.AspNetCore.Mvc;
using PE1.Webshop.Web.Entities;
using PE1.Webshop.Web.Enum;
using PE1.Webshop.Web.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace PE1.Webshop.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly ProductRepository _productRepository;

        public SearchController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            return View("search");
        }

        public IActionResult Products(string category, string property)
        {
            string categoryName = category?.Replace(" ", "");



            Category parsedCategory;

            switch (categoryName)
            {
                case "Laptops":
                    parsedCategory = Category.Laptops;
                    break;
                case "Desktops":
                    parsedCategory = Category.Desktops;
                    break;
                case "GraphicsCards":
                    parsedCategory = Category.GraphicsCards;
                    break;
                default:
                    return View("SearchResults", new List<Product>());
            }

            var products = _productRepository.GetAll()
                .Where(p => p.Category == parsedCategory)
                .ToList();

            return View("SearchResults", products);
        }
    }
}
