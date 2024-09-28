using MVC_DependencyInjection.Models.Northwind;

namespace MVC_DependencyInjection.Services.Abstracts
{
    public interface IProductService
    {
        List<Product> GetProducts();
        
        Product GetProductById(int id);

        void CreateProduct(Product product);

        void UpdateProduct(Product product);    

        void DeleteProduct(int id);
    }
}
