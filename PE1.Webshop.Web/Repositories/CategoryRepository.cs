using System.Collections.Generic;
using PE1.Webshop.Web.Entities;
using PE1.Webshop.Web.Enum;
using System.Linq;
using System;

namespace PE1.Webshop.Web.Repositories
{
    public class CategoryRepository
    {
        private static readonly List<Category> _categories = new List<Category>
        {
            Category.Citrus,
            Category.Berries,
            Category.Pomes,
            Category.StoneFruits,
            Category.Tropical
        };

        public IEnumerable<Category> GetAll()
        {
            return _categories;
        }

        public Category GetById(int id)
        {
            foreach (var category in _categories)
            {
                if ((int)category == id)
                {
                    return category;
                }
            }

            throw new KeyNotFoundException($"Category with ID {id} not found.");
        }
    }
}
