using Microsoft.AspNetCore.Mvc;

namespace layaoutViewsExample.Controllers
{
    public class ProductsController : Controller
    {
        [Route("/Products")]
        public IActionResult Index() 
        {
            return View();
        }

        [Route("Search/Products")]
        public IActionResult Search()
        {
            return View();
        }

        [Route("Order/Products")]
        public IActionResult Order()
        {
            return View();
        }
    }
}
