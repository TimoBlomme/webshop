namespace PE1.Webshop.Web.Enum
{
    public enum Category
    {
        Citrus = 1,
        Berries = 2,
        Tropical = 3,
        StoneFruits = 4,
        Pomes = 5
    }

    public static class CategoryExtensions
    {
        public static string GetHumanName(this Category category)
        {
            return category switch
            {
                Category.Citrus => "Citrus Fruits",
                Category.Berries => "Berries",
                Category.Tropical => "Tropical Fruits",
                Category.StoneFruits => "Stone Fruits",
                Category.Pomes => "Pome Fruits",
                _ => "Unknown Category",
            };
        }
    }
}
