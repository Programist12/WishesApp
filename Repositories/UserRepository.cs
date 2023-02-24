using WishesApp.Models;
using WishesApp.DBContext;

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
            var existingUser = _appDbContext.Users.FirstOrDefault(x => x.Password == password);
            if (existingUser != null)
                return true;
            else
                return false;
        }
    }
}
