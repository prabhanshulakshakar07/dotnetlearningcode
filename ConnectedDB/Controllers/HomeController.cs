using ConnectedDB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConnectedDB.Controllers
{
    public class HomeController : Controller
    {

        private readonly EmpDbContext _DbConext;
        public HomeController(EmpDbContext obj )
        {
            _DbConext = obj;
        }
      


        public IActionResult Index()
        {
            List<Emp> emps = _DbConext.GetAllEmps();
            return View(emps);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
