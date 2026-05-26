using Microsoft.AspNetCore.Mvc;
using System.Collections;
using DisplayDataUsingActionMethod.Models;

namespace DisplayDataUsingActionMethod.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int number = 10;
            string name = "Hugh Jackman";
            ArrayList arr = new ArrayList()
            { number ,name};

            return View(arr);
        }


        public IActionResult About()
        {
            List<Emp> emps = new List<Emp>() {
            new Emp(){ Id = 1, Name="Peter", Address ="London"},
            new Emp(){ Id = 2, Name ="Jack", Address ="Goa"},
            new Emp(){ Id = 3, Name="Ron", Address ="Rome"},
            };

            return View("About", emps);
        }



    }
}
