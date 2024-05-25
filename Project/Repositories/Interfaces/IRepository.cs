namespace Project.Repositories.Interfaces;

public interface IRepository<T> where T : class
{
    public T Add(T entity);
    public void Update(T entity);
    public void Delete(int Id);
    public T Get(int Id);
    public IEnumerable<T> GetAll();
}
