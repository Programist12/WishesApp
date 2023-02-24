using WishesApp.Models;

namespace WishesApp.Repositories
{
    public interface IUserRepository
    {
        bool GetUserByPassword(string password);
        List<string> GetUserMails();

        User GetUserByEmail(string email);
    }
}
