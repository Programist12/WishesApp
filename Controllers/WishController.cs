using Microsoft.AspNetCore.Mvc;

namespace WishesApp.Controllers
{
    public class WishController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
