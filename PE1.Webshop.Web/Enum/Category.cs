namespace PE1.Webshop.Web.Enum
{
    public enum Category
    {
        Laptops = 1,
        Desktops = 2,
        GraphicsCards = 3
    }

    public static class CategoryExtensions
    {
        public static string GetHumanName(this Category category)
        {
            return category switch
            {
                Category.Laptops => "Laptops",
                Category.Desktops => "Desktops",
                Category.GraphicsCards => "Graphic cards",
                _ => "Laptops",
            };
        }
    }
}
