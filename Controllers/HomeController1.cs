using Microsoft.AspNetCore.Mvc;

namespace test_github.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
