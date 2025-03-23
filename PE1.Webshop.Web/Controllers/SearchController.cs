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

        [Route("Search/Products/Tropical/Juicy")]
        public IActionResult TropicalJuicy()
        {
            var products = _productRepository.GetAll()
                .Where(p => p.Category == Category.Tropical)
                .Where(p => p.Properties.Any(prop => prop.Name == "Juicy"))
                .ToList();

            return View("SearchResults", products);
        }

        [Route("Search/Products/Berries/PriceOver3/Sweet")]
        public IActionResult BerriesPriceOver3Sweet()
        {
            var products = _productRepository.GetAll()
                .Where(p => p.Category == Category.Berries)
                .Where(p => p.Price > 3.00m)
                .Where(p => p.Properties.Any(prop => prop.Name == "Sweet"))
                .ToList();

            return View("SearchResults", products);
        }

        [Route("Search/Products/Organic/Seedless/Citrus")]
        public IActionResult OrganicSeedlessCitrus()
        {
            var products = _productRepository.GetAll()
                .Where(p => p.Category == Category.Citrus)
                .Where(p => p.Properties.Any(prop => prop.Name == "Organic"))
                .Where(p => p.Properties.Any(prop => prop.Name == "Seedless"))
                .ToList();

            return View("SearchResults", products);
        }

        public IActionResult Products(string category, string property)
        {
            string categoryName = category?.Replace(" ", "");

            Category parsedCategory;
            switch (categoryName)
            {
                case "Citrus":
                    parsedCategory = Category.Citrus;
                    break;
                case "Berries":
                    parsedCategory = Category.Berries;
                    break;
                case "Tropical":
                    parsedCategory = Category.Tropical;
                    break;
                case "StoneFruits":
                    parsedCategory = Category.StoneFruits;
                    break;
                case "Pomes":
                    parsedCategory = Category.Pomes;
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
