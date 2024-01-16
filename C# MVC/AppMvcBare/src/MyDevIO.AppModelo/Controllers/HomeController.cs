using Microsoft.AspNetCore.Mvc;

namespace MyDevIO.AppModelo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
