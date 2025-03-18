using Microsoft.AspNetCore.Mvc;
using PE1.Webshop.Web.Repositories;

namespace PE1.Webshop.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly CategoryRepository _categoryRepository = new CategoryRepository();

        public IActionResult Index()
        {
            var categories = _categoryRepository.GetAll();
            return View(categories);
        }
    }
}
