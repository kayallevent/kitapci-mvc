using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Basics.Models;


namespace KitapciMvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
         var kitaplar = new List<Kitap>(); // Şimdilik boş liste
         return View(kitaplar);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Kitaplar()
    {
        return View(); // Views/Home/Kitaplar.cshtml dosyasını çağırır
    }

    

}