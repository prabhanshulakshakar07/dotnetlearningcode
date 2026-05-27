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
            List<Emp> emps = _DbContext.emps.ToList();
            return View(emps);
        }
    }
}
