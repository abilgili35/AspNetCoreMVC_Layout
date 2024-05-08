using AspNetCoreMVC_Layout.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC_Layout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            NorthwindContext context = new NorthwindContext();

            

            return View(context.Products.ToList());
        }

        public IActionResult About()
        {
            return View();
        }

    }
}
