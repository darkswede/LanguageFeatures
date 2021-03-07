namespace LanguageFeatures.Models
{
    public class Product
    {
        public Product(bool inStock = true)
        {
            InStock = inStock;
        }
        
        public string Name { get; set; }
        public string Category { get; set; } = "Wodniarstwo";
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; } = true;

        public static Product[] GetProduct()
        {
            Product kayak = new Product
            {
                Name = "kayak",
                Category = "Water Sports",
                Price = 275M
            };

            Product lifejacket = new Product(false)
            {
                Name = "lifejacket",
                Price = 48.95M
            };

            kayak.Related = lifejacket;

            return new Product[] {kayak, lifejacket, null};
        }
    }
}