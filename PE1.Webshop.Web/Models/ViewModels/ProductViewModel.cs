using PE1.Webshop.Web.Entities;
using PE1.Webshop.Web.Enum;

namespace PE1.Webshop.Web.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public string ImageUrl { get; set; }
        public List<Property> Properties { get; set; } 
    }
}
