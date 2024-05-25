using Project.Contexts;
using Project.Models;
using Project.Repositories.Interfaces;

namespace Project.Repositories;

public class OrderRepository(DatabaseContext databaseContext) : IRepository<Order>
{
    private readonly DatabaseContext _databaseContext = databaseContext;

    public Order Add(Order entity)
    {
        var e = _databaseContext.Order.Add(entity).Entity;
        _databaseContext.SaveChanges();
        return e;
    }

    public void Delete(int Id)
    {
        var order = Get(Id);
        if (order != null) { 
            _databaseContext.Order.Remove(order);
            _databaseContext.SaveChanges();
        }
    }

    public Order Get(int Id)
    {
        return _databaseContext.Order.FirstOrDefault(c => c.OrderId == Id) ?? default!;
    }

    public IEnumerable<Order> GetAll()
    {
        return [.. _databaseContext.Order];
    }

    public void Update(Order entity)
    {
        _databaseContext.Order.Update(entity);
        _databaseContext.SaveChanges();
    }
}
