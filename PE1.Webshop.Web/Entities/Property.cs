using System.ComponentModel.DataAnnotations;

namespace PE1.Webshop.Web.Entities
{
    public class Property
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
