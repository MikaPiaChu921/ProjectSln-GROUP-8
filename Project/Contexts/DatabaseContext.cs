using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Contexts;

public class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options)
{
    // DbSets
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Orders> Orders { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<Restaurant> Restaurant { get; set; }
    public DbSet<Reservation> Reservation { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Customer>().HasData(
            new Customer { CustomerId = 1, FullName = "Pia Admin", Address = "Talisay City"},
            new Customer { CustomerId = 2, FullName = "User Admin", Address = "Cebu City" }
            );

        modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, Name = "Ice Cream", Description = "Joyce Ice Cream", Price = 10, Stock = 999, RestaurantId = 1},
            new Product { ProductId = 2, Name = "Lollipop", Description = "Masarap", Price = 2, Stock = 500, RestaurantId = 1 },
            new Product { ProductId = 3, Name = "Spaghetti", Description = "Lasagna", Price = 10, Stock = 200, RestaurantId = 2 },
            new Product { ProductId = 4, Name = "Chiken", Description = "jollibee, Mcdo and kfc", Price = 140, Stock = 200, RestaurantId = 2 },
            new Product { ProductId = 5, Name = "Burger", Description = "yum, big mac, 4 cheese woper", Price = 150, Stock = 200, RestaurantId = 3 },
            new Product { ProductId = 6, Name = "chocolate", Description = "white, dark and milk", Price = 100, Stock = 200, RestaurantId = 3 },
            new Product { ProductId = 7, Name = "ambot", Description = "bla bla bla", Price = 100, Stock = 200, RestaurantId = 4 },
            new Product { ProductId = 8, Name = "chocolate", Description = "white, dark and milk", Price = 100, Stock = 200, RestaurantId = 4 },
            new Product { ProductId = 9, Name = "ambot", Description = "bla bla abla", Price = 100, Stock = 200, RestaurantId = 5 },
            new Product { ProductId = 10, Name = "chocolate", Description = "white, dark and milk", Price = 100, Stock = 200, RestaurantId = 5 }
            );

        modelBuilder.Entity<Restaurant>().HasData(
            new Restaurant { RestaurantId = 1, Name = "Pia Restobar", Description = "Enjoy nice food", Locaton = "Tabunok"},
            new Restaurant { RestaurantId = 2, Name = "Jayharron", Description = "Enjoy nice food", Locaton = "San Isidro" },
            new Restaurant { RestaurantId = 3, Name = "Aubrey", Description = "Enjoy nice food", Locaton = "Tisa" },
            new Restaurant { RestaurantId = 4, Name = "Cyra", Description = "Enjoy nice food", Locaton = "ambot" },
            new Restaurant { RestaurantId = 5, Name = "Paul", Description = "Enjoy nice food", Locaton = "ambot" }
            );
    }
}
