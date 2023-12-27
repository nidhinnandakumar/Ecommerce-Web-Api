using ecommerce_web_api.Models;

namespace ecommerce_web_api.Services.Products
{
    public interface IProductService
    {

        List<Product> GetProducts();
        Product GetProductById(int d);
        Product Addproduct(Product product, int id);
        Product UpdateProduct(int d, Product product);
        void DeleteProduct(int d);
        List<Product> GetProductsByCatId(int catId);


    }
}
