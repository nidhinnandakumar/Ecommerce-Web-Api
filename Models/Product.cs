using ecommerce_web_api.Models;

namespace ecommerce_web_api.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductTitle { get; set; }

        public int ProductPrice { get; set; }
        public string ProductDescription { get; set; }

        public string ProductImages { get; set; }

        public Category? category { get; set; }
    }
}



