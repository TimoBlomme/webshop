using System.Collections.Generic;
using PE1.Webshop.Web.Entities;

namespace PE1.Webshop.Web.Repositories
{
    public class PropertyRepository
    {
        private static List<Property> _properties = new List<Property>
        {
            new Property { Id = 1, Name = "Organic" },
            new Property { Id = 2, Name = "Juicy" },
            new Property { Id = 3, Name = "Seedless" },
            new Property { Id = 4, Name = "Sweet" },
            new Property { Id = 5, Name = "Sour" }
        };

        public IEnumerable<Property> GetAll()
        {
            return _properties;
        }

        public Property GetById(int id)
        {
            return _properties.Find(p => p.Id == id);
        }
    }
}
