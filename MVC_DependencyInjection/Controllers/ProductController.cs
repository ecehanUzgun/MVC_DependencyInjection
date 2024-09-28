using Microsoft.AspNetCore.Mvc;

namespace MVC_DependencyInjection.Controllers
{
    public class ProductController : Controller
    {
    
        public IActionResult Index()
        {
            return View();
        }
    }
}
