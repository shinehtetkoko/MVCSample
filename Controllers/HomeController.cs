using Microsoft.AspNetCore.Mvc;

namespace MVCSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
