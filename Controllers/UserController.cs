using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WishesApp.DTO;
using WishesApp.Models;
using WishesApp.Repositories;

namespace WishesApp.Controllers
{
    public class UserController : Controller
    {
        private IGenericRepository<User> _UserRepository;
        private IUserRepository _ExtendedUserRepository;


        public UserController(IGenericRepository<User> userRepository, IUserRepository extendedUserRepository)
        {
            _UserRepository = userRepository;
            _ExtendedUserRepository = extendedUserRepository;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(DtoUser user)
        {
            if (user != null)
            {
                User UserToAdd = new User()
                {
                    Email = user.Email,
                    Password = user.Password
                };
                _UserRepository.Add(UserToAdd);
                _UserRepository.Save();
                return Ok($"New user was added with Email {user.Email}");
            }
            return BadRequest("Cannot create new user!");

        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(DtoUser user)
        {
            if(user != null)
            {
                if (_ExtendedUserRepository.GetUserByPassword(user.Password))
                    return RedirectToAction("Index", "Home");
                else
                    return View("ErrorBadRequest","User was not found!");
            }
            else
            {
                return View("ErrorBadRequest", "Bad request! Data from web page cannot be empty!"); ;
            }

        }

    }
}
