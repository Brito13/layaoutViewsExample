using Microsoft.AspNetCore.Mvc;

namespace layaoutViewsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/about/us")]
        public IActionResult about() 
        {
            return View();
        }

        [Route("/contact/support")]
        public IActionResult contact()
        {
            return View();
        }
    }
}
