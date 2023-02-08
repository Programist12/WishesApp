namespace WishesApp.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
        void Save();

    }
}
