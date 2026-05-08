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

        [Route("Search/Products/{ProductId?}")]
        public IActionResult Search(int? ProductId)
        {
            ViewBag.ProductId = ProductId;
            return View();
        }

        [Route("Order/Products")]
        public IActionResult Order()
        {
            return View();
        }
    }
}
