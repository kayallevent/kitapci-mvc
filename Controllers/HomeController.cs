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
         var kitaplar = new List<Kitap>
    {
        new Kitap { Id = 1, Ad = "Kürk Mantolu Madonna", Yazar = "Sabahattin Ali", Fiyat = 65 },
        new Kitap { Id = 2, Ad = "1984", Yazar = "George Orwell", Fiyat = 75 },
        new Kitap { Id = 3, Ad = "Sineklerin Tanrısı", Yazar = "William Golding", Fiyat = 60 }
    };
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