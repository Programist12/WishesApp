using WishesApp.Models;

namespace WishesApp.Repositories
{
    public interface IUserRepository
    {
        bool GetUserByPassword(string password);
    }
}
