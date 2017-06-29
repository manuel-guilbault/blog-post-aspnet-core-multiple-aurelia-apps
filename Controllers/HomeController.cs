using Microsoft.AspNetCore.Mvc;

namespace blog_post_aspnet_core_multiple_aurelia_apps.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult App1()
        {
            return View();
        }

        public IActionResult App2()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
