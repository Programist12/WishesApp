using Microsoft.AspNetCore.Mvc;
using WishesApp.DTO;
using WishesApp.Models;
using WishesApp.Repositories;

namespace WishesApp.Controllers
{
    public class WishController : Controller
    {
        private IGenericRepository<Wish> _WishReporsitory;
        private IUserRepository _ExtendedUserRepository;

        public WishController(IGenericRepository<Wish> wishReporsitory, IUserRepository extendedUserRepository)
        {
            _WishReporsitory = wishReporsitory;
            _ExtendedUserRepository = extendedUserRepository;
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

            return View(new DtoWish
            {
                AvailableUsersForWish = _ExtendedUserRepository.GetUserMails()
            });
        }


        [HttpPost]
        public IActionResult CreateWish(DtoWish wish)
        {
            if (wish != null)
            {
                var SelectedUser = _ExtendedUserRepository.GetUserByEmail(wish.SelectedUserEmail);
                if (SelectedUser != null)
                {
                    Wish WishToAdd = new Wish()
                    {
                        Name = wish.Name,
                        Type = wish.Type,
                        Status = wish.Status,
                        Links = wish.Links,
                        Desires = wish.Desires,
                        User = SelectedUser,
                        UserEmail = wish.SelectedUserEmail
                    };
                    _WishReporsitory.Add(WishToAdd);
                }


                _WishReporsitory.Save();
                return Ok("wish created");
            }
            return BadRequest("Something went wrong!");


        }
    }
}
