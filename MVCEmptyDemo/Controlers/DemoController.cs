using Microsoft.AspNetCore.Mvc;

namespace MVCEmptyDemo.Controlers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
