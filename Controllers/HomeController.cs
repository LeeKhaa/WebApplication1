using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        //public ActionResult GetEmpName(int EmpId)
        //{
        //    var employees = new[]
        //    {
        //        new { EmpId = 1, EmpName = "Kha", Salary = 9000},
        //        new { EmpId = 2, EmpName = "Thanh", Salary = 7000},
        //        new { EmpId = 3, EmpName = "Hao", Salary = 8000},
        //    };
        //    string matchEmpName = null;
        //    foreach (var item in employees)
        //    {
        //        if (item.EmpId == EmpId)
        //        {
        //            matchEmpName = item.EmpName;
        //        }
        //    }
        //    return Content(matchEmpName, "text/plain");
        //}

        public IActionResult About()
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
