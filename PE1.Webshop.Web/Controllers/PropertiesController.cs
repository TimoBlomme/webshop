using Microsoft.AspNetCore.Mvc;
using PE1.Webshop.Web.Repositories;

namespace PE1.Webshop.Web.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly PropertyRepository _propertyRepository = new PropertyRepository();

        public IActionResult Index()
        {
            var properties = _propertyRepository.GetAll();
            return View(properties);
        }
    }
}
