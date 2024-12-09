using Microsoft.AspNetCore.Mvc;

namespace Product_microservice.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
