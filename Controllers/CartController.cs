using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

namespace Basics.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<int>>("cart") ?? new List<int>();
            return View(cart);
        }

        public IActionResult AddToCart(int id)
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<int>>("cart") ?? new List<int>();
            if (!cart.Contains(id))
            {
                cart.Add(id);
                HttpContext.Session.SetObjectAsJson("cart", cart);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromCart(int id)
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<int>>("cart") ?? new List<int>();
            cart.Remove(id);
            HttpContext.Session.SetObjectAsJson("cart", cart);
            return RedirectToAction("Index");
        }
    }
}
