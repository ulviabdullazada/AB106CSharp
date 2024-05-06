using Microsoft.AspNetCore.Mvc;

namespace FiuApp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
