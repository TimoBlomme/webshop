using System.Collections.Generic;
using System.Linq;
using PE1.Webshop.Web.Entities;
using PE1.Webshop.Web.Enum;

namespace PE1.Webshop.Web.Repositories
{
    public class ProductRepository
    {
        private static List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Gaming Laptop", Price = 1500, Description = "High-end gaming laptop", ImageUrl = "/images/Product1.jpg", Category = Category.Laptops,  },
            new Product { Id = 2, Name = "Budget Desktop", Price = 800, Description = "Affordable desktop for basic tasks", ImageUrl = "/images/Product2.jpg", Category = Category.Desktops },
            new Product { Id = 3, Name = "High-End Graphics Card", Price = 1200, Description = "Perfect for gaming and 3D rendering", ImageUrl = "/images/Product3.jpg", Category = Category.GraphicsCards},
            new Product { Id = 4, Name = "Gaming Laptop nr2", Price = 1500, Description = "High-end gaming laptop", ImageUrl = "/images/Product4.jpg", Category = Category.Laptops },
            new Product { Id = 5, Name = "Budget Desktop nr2", Price = 800, Description = "Affordable desktop for basic tasks", ImageUrl = "/images/Product5.jpg", Category = Category.Desktops },
            new Product { Id = 6, Name = "High-End Graphics Card nr2", Price = 1200, Description = "Perfect for gaming and 3D rendering", ImageUrl = "/images/Product6.jpg", Category = Category.GraphicsCards }
        };

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}
