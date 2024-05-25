using Project.Contexts;
using Project.Models;
using Project.Repositories.Interfaces;

namespace Project.Repositories;

public class ReservationRepository(DatabaseContext databaseContext) : IRepository<Reservation>
{
    private readonly DatabaseContext _databaseContext = databaseContext;

    public Reservation Add(Reservation entity)
    {
        var e = _databaseContext.Reservation.Add(entity).Entity;
        _databaseContext.SaveChanges();
        return e;
    }

    public void Delete(int Id)
    {
        var reservation = Get(Id);
        if (reservation != null)
        {
            _databaseContext.Reservation.Remove(reservation);
            _databaseContext.SaveChanges();
        }
    }

    public Reservation Get(int Id)
    {
        return _databaseContext.Reservation.FirstOrDefault(c => c.ReservationId == Id) ?? default!;
    }

    public IEnumerable<Reservation> GetAll()
    {
        return [.. _databaseContext.Reservation];
    }

    public void Update(Reservation entity)
    {
        _databaseContext.Reservation.Update(entity);
        _databaseContext.SaveChanges();
    }
}
