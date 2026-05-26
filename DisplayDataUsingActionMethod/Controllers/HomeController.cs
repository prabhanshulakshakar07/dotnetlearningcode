using Microsoft.AspNetCore.Mvc;
using System.Collections;
using DisplayDataUsingActionMethod.Models;

namespace DisplayDataUsingActionMethod.Controllers
{
    public class HomeController : Controller
    {
        List<Emp> emps = new List<Emp>() {
            new Emp(){ Id = 1, Name="Peter", Address ="London"},
            new Emp(){ Id = 2, Name ="Jack", Address ="Goa"},
            new Emp(){ Id = 3, Name="Ron", Address ="Rome"},
            };

        List<Customer> custs = new List<Customer>()
        {
            new Customer(){ CId = 111, CName = "Tina"},
            new Customer(){ CId = 567, CName = "Olivia"},
        };
        public IActionResult Index()
        {
            int number = 10;
            string name = "Hugh Jackman";
            ArrayList arr = new ArrayList() { number, name };
            return View(arr);
            //return View("Index",number, name);
        }
        public IActionResult About()
        {
            return View("About", emps);
        }

        public IActionResult Data()
        {
            //ArrayList objArr =  new ArrayList() { emps, custs};
            //return View(objArr);

            ViewModel vm = new ViewModel() { es = emps, cs = custs };
            return View(vm);
        }
    }
}