using Microsoft.AspNetCore.Mvc;
using WishesApp.DTO;
using WishesApp.Models;
using WishesApp.Repositories;

namespace WishesApp.Controllers
{
    public class WishController : Controller
    {
        private IGenericRepository<Wish> _WishReporsitory;

        public WishController(IGenericRepository<Wish> wishReporsitory)
        {
            _WishReporsitory = wishReporsitory;
        }

        [HttpGet]
        public IActionResult ListWishes()
        {
            IEnumerable<Wish> wishes = _WishReporsitory.GetAll();
            if (wishes != null)
                return View(wishes);
            return BadRequest("Wishes is null!");
        }

        [HttpGet]
        public IActionResult GetByWishId(int id)
        {
            var wish = _WishReporsitory.Get(id);
            if (wish != null)
                return View(wish);
            return NotFound($"Wish with id {id} was not found");
        }

        [HttpGet]
        public IActionResult CreateWish()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateWish(DtoWish wish)
        {
            if (wish != null)
            {
                Wish WishToAdd = new Wish()
                {
                    Name = wish.Name,
                    Type = wish.Type,
                    Status = wish.Status,
                    Links = wish.Links,
                    Desires = wish.Desires,
                };
                _WishReporsitory.Add(WishToAdd);
                _WishReporsitory.Save();
            }

            return RedirectToAction("Index");

        }
    }
}
