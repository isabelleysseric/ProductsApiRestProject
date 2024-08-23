using Microsoft.AspNetCore.Mvc;

namespace ProductsApiRestProject.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Content("Welcome to the Products API");
        }
    }
}
