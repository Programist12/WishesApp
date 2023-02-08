using Microsoft.EntityFrameworkCore;
using WishesApp.DBContext;
using WishesApp.Models;

namespace WishesApp.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private AppDbContext _context;
        public DbSet<T> Table;

        public GenericRepository(AppDbContext _context)
        {
            this._context = _context; 
            Table = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return Table.ToList();
        }

        public T Get(int id)
        {
            return Table.Find(id);
        }

        public void Add(T entity)
        {
            Table.Add(entity);
        }

        public void Delete(int id)
        {
            T ExistingRecord=Table.Find(id);
            if(ExistingRecord!=null)
                Table.Remove(ExistingRecord);
        }

        public void Update(T entity)
        {
            Table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
