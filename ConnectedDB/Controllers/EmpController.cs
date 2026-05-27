using ConnectedDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConnectedDB.Controllers
{
    public class EmpController : Controller
    {
        private readonly MyDbContext _DbContext;

        //ctrl + . to generate private field 
        public EmpController(MyDbContext context)
        {
            _DbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
