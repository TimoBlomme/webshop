using System.Collections.Generic;
using System.Linq;
using PE1.Webshop.Web.Entities;
using PE1.Webshop.Web.Enum;

namespace PE1.Webshop.Web.Repositories
{
    public class ProductRepository
    {
        private readonly PropertyRepository _propertyRepository;

        public ProductRepository(PropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;

            _products = new List<Product>
            {
                new Product 
                { 
                    Id = 1, 
                    Name = "Valencia Orange", 
                    Price = 2.50m, 
                    Description = "Juicy and refreshing orange", 
                    ImageUrl = "/img/product1.jpg", 
                    Category = Category.Citrus, 
                    Properties = new List<Property> 
                    { 
                        _propertyRepository.GetById(1), 
                        _propertyRepository.GetById(4) 
                    }.Where(p => p != null).ToList() 
                },

                new Product 
                { 
                    Id = 2, 
                    Name = "Blueberry Delight", 
                    Price = 3.90m, 
                    Description = "Sweet and tangy blueberries", 
                    ImageUrl = "/img/product2.jpg", 
                    Category = Category.Berries, 
                    Properties = new List<Property> 
                    { 
                        _propertyRepository.GetById(2), 
                        _propertyRepository.GetById(3) 
                    }.Where(p => p != null).ToList() 
                },

                new Product 
                { 
                    Id = 3, 
                    Name = "Tropical Mango", 
                    Price = 3.75m, 
                    Description = "Exotic and ripe mango", 
                    ImageUrl = "/img/product3.jpg", 
                    Category = Category.Tropical, 
                    Properties = new List<Property> 
                    { 
                        _propertyRepository.GetById(3), 
                        _propertyRepository.GetById(1) 
                    }.Where(p => p != null).ToList() 
                },

                new Product 
                { 
                    Id = 4, 
                    Name = "Peach Paradise", 
                    Price = 4.10m, 
                    Description = "Soft and flavorful peach", 
                    ImageUrl = "/img/product4.jpg", 
                    Category = Category.StoneFruits, 
                    Properties = new List<Property> 
                    { 
                        _propertyRepository.GetById(4), 
                        _propertyRepository.GetById(3) 
                    }.Where(p => p != null).ToList() 
                },

                new Product 
                { 
                    Id = 5, 
                    Name = "Golden Apple", 
                    Price = 2.80m, 
                    Description = "Crisp and sweet golden apple", 
                    ImageUrl = "/img/product5.jpg", 
                    Category = Category.Pomes, 
                    Properties = new List<Property> 
                    { 
                        _propertyRepository.GetById(1), 
                        _propertyRepository.GetById(3) 
                    }.Where(p => p != null).ToList() 
                },

                new Product 
                { 
                    Id = 6, 
                    Name = "Strawberry Bliss", 
                    Price = 3.20m, 
                    Description = "Bright and juicy strawberries", 
                    ImageUrl = "/img/product6.jpg", 
                    Category = Category.Berries, 
                    Properties = new List<Property> 
                    { 
                        _propertyRepository.GetById(2), 
                        _propertyRepository.GetById(4) 
                    }.Where(p => p != null).ToList() 
                },

                new Product 
                { 
                    Id = 7, 
                    Name = "Pineapple Burst", 
                    Price = 4.50m, 
                    Description = "Tropical and tangy pineapple", 
                    ImageUrl = "/img/product7.jpg", 
                    Category = Category.Tropical, 
                    Properties = new List<Property> 
                    { 
                        _propertyRepository.GetById(2), 
                        _propertyRepository.GetById(5) 
                    }.Where(p => p != null).ToList() 
                },

                new Product 
                { 
                    Id = 8, 
                    Name = "Plum Perfection", 
                    Price = 3.00m, 
                    Description = "Rich and tender plum", 
                    ImageUrl = "/img/product8.jpg", 
                    Category = Category.StoneFruits, 
                    Properties = new List<Property> 
                    { 
                        _propertyRepository.GetById(1), 
                        _propertyRepository.GetById(5) 
                    }.Where(p => p != null).ToList() 
                }
            };
        }

        private List<Product> _products;

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
