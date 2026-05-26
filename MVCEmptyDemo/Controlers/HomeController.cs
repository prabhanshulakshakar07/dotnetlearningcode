using Microsoft.AspNetCore.Mvc;

namespace MVCEmptyDemo.Controlers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
       


    }
}
