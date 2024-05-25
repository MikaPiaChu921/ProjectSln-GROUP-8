using Project.Contexts;
using Project.Models;
using Project.Repositories.Interfaces;

namespace Project.Repositories;

public class OrdersRepository(DatabaseContext databaseContext) : IRepository<Orders>
{
    private readonly DatabaseContext _databaseContext = databaseContext;

    public Orders Add(Orders entity)
    {
        var e = _databaseContext.Orders.Add(entity).Entity;
        _databaseContext.SaveChanges();
        return e;
    }

    public void Delete(int Id)
    {
        var order = Get(Id);
        if (order != null)
        {
            _databaseContext.Orders.Remove(order);
            _databaseContext.SaveChanges();
        }
    }

    public Orders Get(int Id)
    {
        return _databaseContext.Orders.FirstOrDefault(c => c.OrdersId == Id) ?? default!;
    }

    public IEnumerable<Orders> GetAll()
    {
        return [.. _databaseContext.Orders];
    }

    public void Update(Orders entity)
    {
        _databaseContext.Orders.Update(entity);
        _databaseContext.SaveChanges();
    }
}
