using Project.Contexts;
using Project.Models;
using Project.Repositories.Interfaces;

namespace Project.Repositories;

public class CustomerRepository(DatabaseContext databaseContext) : IRepository<Customer>
{
    private readonly DatabaseContext _databaseContext = databaseContext;

    public Customer Add(Customer entity)
    {
        var e = _databaseContext.Customer.Add(entity);
        _databaseContext.SaveChanges();
        return e.Entity;
    }

    public void Delete(int Id)
    {
        var customer = Get(Id);
        if (customer != null)
        {
            _databaseContext.Customer.Remove(customer);
            _databaseContext.SaveChanges();
        }
    }

    public Customer Get(int Id)
    {
        return _databaseContext.Customer.FirstOrDefault(c => c.CustomerId == Id) ?? default!;
    }

    public IEnumerable<Customer> GetAll()
    {
        return [.. _databaseContext.Customer];
    }

    public void Update(Customer entity)
    {
        _databaseContext.Customer.Update(entity);
        _databaseContext.SaveChanges();
    }
}
