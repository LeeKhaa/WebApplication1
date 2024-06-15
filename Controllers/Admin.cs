using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Admin : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
