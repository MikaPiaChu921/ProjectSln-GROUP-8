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
            new Product { ProductId = 100, Name = "Roasted Suckling Pork", Description = "Served with soya onion gravy, apple, and mustard leaf, this dish highlights Cebu’s reputation for pork dishes.", Price = 850, Stock = 999, RestaurantId = 1},
            new Product { ProductId = 101, Name = "Truffle Mac & Cheese", Description = "A Filipino ceviche with shrimp, calamansi, pickled papaya, chili, and coconut, offering a fresh and tangy flavor profile.", Price = 650, Stock = 999, RestaurantId = 1 },
            new Product { ProductId = 102, Name = "Local Red Mullet and Clams", Description = "This seafood dish is served in a bacon beer sauce, combining local seafood with rich, savory flavors.", Price = 950, Stock = 999, RestaurantId = 1 },
            new Product { ProductId = 103, Name = "Tuna Sashimi", Description = "A modern twist featuring jalapeno ice, adding a spicy and cool element to the fresh sashimi.", Price = 1200, Stock = 999, RestaurantId = 1 },
            new Product { ProductId = 104, Name = "Chicken Tomahawk", Description = "A A hearty and flavorful chicken dish, perfect for those looking for a substantial meal​", Price = 450, Stock = 999, RestaurantId = 1 },
            
            new Product { ProductId = 200, Name = "Brian’s Ribs", Description = "This signature dish features tender, flavorful baby back ribs smothered in a tangy barbecue sauce.", Price = 380, Stock = 999, RestaurantId = 2 },
            new Product { ProductId = 201, Name = "David Dean’s Tenderloin", Description = "A juicy steak served with mashed potatoes and vegetables, perfect for meat lovers.", Price = 880, Stock = 999, RestaurantId = 2 },
            new Product { ProductId = 202, Name = "Mighty Ton Burger", Description = "A gigantic burger loaded with beef patties, cheese, bacon, and various toppings, ideal for sharing.", Price = 520, Stock = 999, RestaurantId = 2 },
            new Product { ProductId = 203, Name = "Tricia’s Pasta", Description = "A creamy and savory pasta dish with grilled chicken and mushrooms.", Price = 690, Stock = 999, RestaurantId = 2 },
            new Product { ProductId = 204, Name = "Lauren’s Lava Cake", Description = "A rich and decadent chocolate lava cake served with ice cream", Price = 250, Stock = 999, RestaurantId = 2 },

            new Product { ProductId = 300, Name = "Lechon de Cebu", Description = "The house specialty, featuring crispy skin and tender, flavorful meat, is a must-try.", Price = 550, Stock = 999, RestaurantId = 3 },
            new Product { ProductId = 301, Name = "Lechon Paksiw", Description = "A stew made from leftover lechon, cooked with vinegar, liver sauce, and spices.", Price = 450, Stock = 999, RestaurantId = 3 },
            new Product { ProductId = 302, Name = "Sizzling Lechon Sisig", Description = " A sizzling platter of chopped lechon mixed with onions, chili, and spices.", Price = 980, Stock = 999, RestaurantId = 3 },
            new Product { ProductId = 303, Name = "Lechon Sinigang", Description = "A traditional Filipino sour soup with lechon, vegetables, and tamarind broth.", Price = 750, Stock = 999, RestaurantId = 3 },
            new Product { ProductId = 304, Name = "Pritchon", Description = "Fried lechon served with a variety of dipping sauces for an extra crispy experience​.  ", Price = 280, Stock = 999, RestaurantId = 3 },

            new Product { ProductId = 400, Name = "Organic Roast Chicken", Description = "This dish features locally sourced organic chicken roasted to perfection with herbs and spices.", Price = 890, Stock = 999, RestaurantId = 4 },
            new Product { ProductId = 401, Name = "Seared Tuna", Description = "Fresh tuna seared and served with a tangy wasabi dressing and vegetables.", Price = 750, Stock = 999, RestaurantId = 4 },
            new Product { ProductId = 402, Name = "Lamb Shank Caldereta", Description = "A Filipino-Spanish fusion dish with slow-cooked lamb shank in a rich tomato-based stew.", Price = 950, Stock = 999, RestaurantId = 4 },
            new Product { ProductId = 403, Name = "Pumpkin and Goat Cheese Risotto", Description = "A creamy risotto with pumpkin, goat cheese, and a hint of truffle oil.", Price = 700, Stock = 999, RestaurantId = 4 },
            new Product { ProductId = 404, Name = "Mango Float", Description = "A traditional Filipino dessert made with layers of graham crackers, cream, and fresh mangoes​", Price = 280, Stock = 999, RestaurantId = 4 },

            new Product { ProductId = 500, Name = "Brian’s Ribs", Description = "A hearty breakfast platter featuring eggs, bacon, sausage, toast, and a side of greens.", Price = 450, Stock = 999, RestaurantId = 5 },
            new Product { ProductId = 501, Name = "David Dean’s Tenderloin", Description = "Creamy avocado spread on toasted artisanal bread, topped with cherry tomatoes, feta cheese, and a sprinkle of chili flakes. ", Price = 350, Stock = 999, RestaurantId = 5 },
            new Product { ProductId = 502, Name = "Mighty Ton Burger", Description = "Poached eggs and smoked salmon on a toasted English muffin, drizzled with hollandaise sauce and served with a side salad", Price = 480, Stock = 999, RestaurantId = 5 },
            new Product { ProductId = 503, Name = "Tricia’s Pasta", Description = "Fluffy pancakes served with maple syrup and butter, perfect for a sweet breakfast treat.", Price = 320, Stock = 999, RestaurantId = 5 },
            new Product { ProductId = 504, Name = "Lauren’s Lava Cake", Description = "A flavorful dish of spicy chorizo sausage, potatoes, and bell peppers, topped with a fried egg.", Price = 420, Stock = 999, RestaurantId = 5 }
           );

        modelBuilder.Entity<Restaurant>().HasData(
            new Restaurant { RestaurantId = 1, Name = "The Pig & Palm", Description = "The Pig & Palm offers a contemporary dining experience with a focus on European and gastropub cuisine. Founded by Michelin-starred British chef Jason Atherton and his Cebuana wife Irha, the restaurant features a modern, stylish interior with a relaxed atmosphere. The menu emphasizes locally sourced ingredients and innovative dishes, making it a popular spot for both brunch and dinner. Signature dishes include their creative takes on classic pub fare and a variety of cocktails crafted to perfection.", Locaton = "Cebu Business Park" },
            new Restaurant { RestaurantId = 2, Name = "Casa Verde", Description = "This family-owned restaurant offers a mix of Spanish and American dishes in a cozy, homey setting. The most popular dish is their Baby Back Ribs, which are renowned for their generous portions and delicious flavor​", Locaton = "Ayala Cebu" },
            new Restaurant { RestaurantId = 3, Name = "House of Lechon", Description = "House of Lechon specializes in the iconic Cebuano lechon, a traditional roasted pig known for its crispy skin and savory meat. The restaurant brings the renowned flavor of Carcar's lechon to the city, offering a taste of this beloved regional delicacy without the need for a long drive. The dining experience is enhanced by a casual, family-friendly atmosphere, perfect for enjoying authentic Filipino cuisine.", Locaton = "Robinsons Galleria Cebu" },
            new Restaurant { RestaurantId = 4, Name = "Circa 1900", Description = "Located in a beautifully restored colonial home, Circa 1900 combines historical charm with modern culinary excellence. The restaurant's ambiance is both vintage and sophisticated, providing a unique setting for dining. The menu features international dishes with a focus on local ingredients, skillfully prepared by their talented chefs. This makes Circa 1900 an ideal venue for intimate dinners and special occasions.", Locaton = "Sanjercas Ville Ext. Rd, Cebu City​" },
            new Restaurant { RestaurantId = 5, Name = "Abaca Baking Company", Description = "Abaca Baking Company is renowned for its artisanal bread, pastries, and hearty breakfast dishes. It's a cozy spot perfect for brunch with a menu that showcases fresh, locally sourced ingredients.", Locaton = "Ayala Cebu" }
            );
    }
}
