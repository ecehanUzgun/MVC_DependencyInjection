using Microsoft.AspNetCore.Mvc;
using MVC_DependencyInjection.Models.Northwind;
using MVC_DependencyInjection.Services.Abstracts;
using MVC_DependencyInjection.Services.Concretes;

namespace MVC_DependencyInjection.Controllers
{
    public class ProductController : Controller
    {
        ProductService productService = new ProductService();
        //Dependency Injection: Bağımlığın dahil edilmesi/kullanılması.
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        //Instance

        //Product List
        public IActionResult Index()
        {
            var products = _productService.GetProducts();
            return View(products);
        }

        //Product Create
        public IActionResult Create() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productService.CreateProduct(product);
        }

        //Product Update
        public IActionResult Update()
        {
            return View();
        }

        //Product Delete
        public IActionResult Delete()
        {
            return View();
        }
    }
}
