using Microsoft.EntityFrameworkCore;
using WishesApp.Models;

namespace WishesApp.DBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):
            base(options)
        {

        }


        public DbSet<Wish> Wishes { get; set; }
        public DbSet<User> Users { get; set; } 
    }
}
