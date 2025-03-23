using PE1.Webshop.Web.Enum;
using System.ComponentModel.DataAnnotations;

namespace PE1.Webshop.Web.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [Range(0.01, 99999.99)]
        public decimal Price { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public Category Category { get; set; }

        public List<Property> Properties { get; set; } = new List<Property>();
    }
}
