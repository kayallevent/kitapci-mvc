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
        new Kitap { Id = 1, Ad = "Kürk Mantolu Madonna", Yazar = "Sabahattin Ali", Fiyat = 65.99, ResimUrl = "kitap.jpeg"},
        new Kitap { Id = 2, Ad = "Çalıkuşu", Yazar = "Reşat Nuri Güntekin", Fiyat = 388.20, ResimUrl = "Çalıkuşu.jpg"},
        new Kitap { Id = 3, Ad = "Heidi", Yazar = "Johanna Spyri", Fiyat = 59.92, ResimUrl = "Heidi.jpeg"},
        new Kitap { Id = 3, Ad = "Harry Potter ve Felsefe Taşı", Yazar = "J.K. Rowling", Fiyat = 145.90, ResimUrl = "Harrypot.jpeg"},
        new Kitap { Id = 3, Ad = "Game Of Thrones Song Of Ice And Fire", Yazar = "George R.R. Martin", Fiyat = 509.99, ResimUrl = "kitap(1).jpeg"},
        new Kitap { Id = 3, Ad = "Notre-Dame'ın Kamburu", Yazar = "Victor Hugo", Fiyat = 150.00, ResimUrl = "kurk_mantolu_madonna.jpg"},
        new Kitap { Id = 3, Ad = "Nutuk", Yazar = "Mustafa Kemal Atatürk", Fiyat = 136.05, ResimUrl = "kitap(3).jpeg"},
        new Kitap { Id = 3, Ad = "Küçük Prens", Yazar = "Antoine De Saint-Exupery", Fiyat = 60, ResimUrl = "Kucukprens.jpg"},
        new Kitap { Id = 3, Ad = "The Hobbit", Yazar = "J.R.R. Tolkien", Fiyat = 422.24, ResimUrl = "wi_500.jpeg"},
        new Kitap { Id = 3, Ad = "Don Kişot", Yazar = " Miguel de Cervantes", Fiyat = 128.99, ResimUrl = "wi_800.jpeg" }  
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