using Microsoft.AspNetCore.Mvc;
using PE1.Webshop.Web.Entities;
using PE1.Webshop.Web.Enum;
using PE1.Webshop.Web.Repositories;
using PE1.Webshop.Web.ViewModels;

namespace PE1.Webshop.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductRepository _productRepository;

        public ProductsController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var products = _productRepository.GetAll();

            var productViewModels = products.Select(p => new ProductViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Category = p.Category, 
                ImageUrl = string.IsNullOrEmpty(p.ImageUrl) ? "/img/default.png" : p.ImageUrl 
            }).ToList();

            return View("Products", productViewModels);
        }

        public IActionResult Details(int id)
        {
            var product = _productRepository.GetById(id);

            if (product == null)
            {
                return NotFound();
            }

            var viewModel = new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                Category = product.Category,
                Properties = product.Properties
            };

            return View(viewModel);
        }

    }
}

