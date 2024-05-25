using Project.Contexts;
using Project.Models;
using Project.Repositories.Interfaces;

namespace Project.Repositories;

public class ProductRepository(DatabaseContext databaseContext) : IRepository<Product>
{
    private readonly DatabaseContext _databaseContext = databaseContext;
    public Product Add(Product entity)
    {
        var e = _databaseContext.Product.Add(entity).Entity;
        _databaseContext.SaveChanges();
        return e;
    }

    public void Delete(int Id)
    {
        var product = Get(Id);
        if (product != null)
        {
            _databaseContext.Product.Remove(product);
            _databaseContext.SaveChanges();
        }
    }

    public Product Get(int Id)
    {
        return _databaseContext.Product.FirstOrDefault(c => c.ProductId == Id) ?? default!;
    }

    public IEnumerable<Product> GetAll()
    {
        return [.. _databaseContext.Product];
    }

    public void Update(Product entity)
    {
        _databaseContext.Product.Update(entity);
        _databaseContext.SaveChanges();
    }
}
