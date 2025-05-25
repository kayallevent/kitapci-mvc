using Microsoft.AspNetCore.Mvc;

namespace KitapciMVC.Controllers
{  

public class KullaniciController : Controller
{
    public IActionResult Giris()
    {
        return View();
    }

    public IActionResult Kayit()
    {
        return View();
    }
}
}