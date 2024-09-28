using MVC_DependencyInjection.Models.Northwind;

namespace MVC_DependencyInjection.Models.Data.FakeData
{
    public class ProductFakeData
    {
        public static List<Product> Products = new List<Product>
        {
            new Product{ProductId = 80, ProductName = "Highlighter", UnitPrice = 600, UnitsInStock = 20, Discontinued = false}
        };
    }
}
