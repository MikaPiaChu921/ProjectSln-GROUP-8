using Project.Contexts;
using Project.Models;
using Project.Repositories.Interfaces;

namespace Project.Repositories;

public class RestaurantRepository(DatabaseContext databaseContext) : IRepository<Restaurant>
{
    private readonly DatabaseContext _databaseContext = databaseContext;

    public Restaurant Add(Restaurant entity)
    {
        var e = _databaseContext.Restaurant.Add(entity).Entity;
        _databaseContext.SaveChanges();
        return e;
    }

    public void Delete(int Id)
    {
        var restaurant = Get(Id);
        if (restaurant != null)
        {
            _databaseContext.Restaurant.Remove(restaurant);
            _databaseContext.SaveChanges();
        }
    }

    public Restaurant Get(int Id)
    {
        return _databaseContext.Restaurant.FirstOrDefault(c => c.RestaurantId == Id) ?? default!;
    }

    public IEnumerable<Restaurant> GetAll()
    {
        return [.. _databaseContext.Restaurant];
    }

    public void Update(Restaurant entity)
    {
        _databaseContext.Restaurant.Update(entity);
        _databaseContext.SaveChanges();
    }
}
