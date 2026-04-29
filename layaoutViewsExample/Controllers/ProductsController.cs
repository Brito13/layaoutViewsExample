using Microsoft.AspNetCore.Mvc;

namespace layaoutViewsExample.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }

        [Route("Order/Products")]
        public IActionResult Search()
        {
            return View();
        }

        [Route("Search/Products")]
        public IActionResult Order()
        {
            return View();
        }
    }
}
