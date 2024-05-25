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
            new Product { ProductId = 3, Name = "Spaghetti", Description = "Lasagna", Price = 10, Stock = 200, RestaurantId = 1 }
            );

        modelBuilder.Entity<Restaurant>().HasData(
            new Restaurant { RestaurantId = 1, Name = "Pia Restobar", Description = "Enjoy nice food", Locaton = "Tabunok"}
            );
    }
}
