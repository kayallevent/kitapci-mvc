using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Basics.Controllers
{
    public class AdminController : Controller
    {
        // GET: /Admin/Login
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "1234")
            {
                HttpContext.Session.SetString("admin", "true");
                return RedirectToAction("Dashboard");
            }

            ViewBag.Error = "Hatalı kullanıcı adı veya şifre.";
            return View();
        }

        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("admin") != "true")
                return RedirectToAction("Login");

            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("admin");
            return RedirectToAction("Login");
        }
    }
}
