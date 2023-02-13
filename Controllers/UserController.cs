using Microsoft.AspNetCore.Mvc;
using WishesApp.DTO;
using WishesApp.Models;
using WishesApp.Repositories;

namespace WishesApp.Controllers
{
    public class UserController : Controller
    {
        private IGenericRepository<User> _UserRepository;


        public UserController(IGenericRepository<User> userRepository)
        {
            _UserRepository = userRepository;
        }

        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View();
        //}
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
                    Name = user.Name,
                    SecondName = user.SecondName,
                    PhoneNumber = user.PhoneNumber,
                    About = user.About,
                    Password = user.Password,
                };
                _UserRepository.Add(UserToAdd);
                _UserRepository.Save();
                return Ok($"New user was added with name {user.Name}");
            }
            return BadRequest("Cannot create new user!");

        }

    }
}
