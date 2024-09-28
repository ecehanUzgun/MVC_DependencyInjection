using Microsoft.EntityFrameworkCore;
using MVC_DependencyInjection.Models.Northwind;
using MVC_DependencyInjection.Services.Abstracts;

namespace MVC_DependencyInjection.Services.Concretes
{
    public class ProductService : IProductService
    {
        private readonly NorthwindContext _db;
        public ProductService(NorthwindContext db)
        {
            _db = db;
        }

        public void CreateProduct(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            Product deleted = _db.Products.FirstOrDefault(x => x.ProductId == id);
            if (deleted != null) 
            { 
                _db.Products.Remove(deleted);
                _db.SaveChanges();
            }
        }

        public Product GetProductById(int id)
        {
            return _db.Products.FirstOrDefault(x => x.ProductId == id);
        }

        public List<Product> GetProducts()
        {
            return _db.Products.ToList();
        }

        public void UpdateProduct(Product product)
        {
           Product updated = _db.Products.FirstOrDefault(x => x.ProductId ==  product.ProductId);
            if (updated != null) 
            {
                product.ProductName = updated.ProductName;
                product.UnitPrice = updated.UnitPrice;
                product.QuantityPerUnit = updated.QuantityPerUnit;
                product.UnitsInStock = updated.UnitsInStock;
                product.UnitsOnOrder = updated.UnitsOnOrder;
                product.Discontinued = updated.Discontinued;

                _db.SaveChanges();
            }
        }
    }
}
