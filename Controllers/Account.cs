using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Account : Controller
    {
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "abc")
            {
                return RedirectToAction("Dashboard", "Admin");
            }
            else
            {
                return RedirectToAction("InvalidLogin");
            }
        }
        public IActionResult InvalidLogin()
        {
            return View();
        }
    } 
}
