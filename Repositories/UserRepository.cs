using WishesApp.Models;
using WishesApp.DBContext;
using Microsoft.EntityFrameworkCore;

namespace WishesApp.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public bool GetUserByPassword(string password)
        {
            var existingUser = _appDbContext.Users.SingleOrDefault(x => x.Password == password);
            if (existingUser != null)
                return true;
            else
                return false;
        }

        public List<string> GetUserMails()
        {
            return _appDbContext.Users.Select(m => m.Email).ToList();
        }

        public User GetUserByEmail(string email)
        {
            return _appDbContext.Users.FirstOrDefault(u => u.Email == email);
        }

        
    }
}
