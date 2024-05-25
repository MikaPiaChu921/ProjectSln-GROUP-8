using Microsoft.EntityFrameworkCore;
using Project.Contexts;
using Project.Models;
using Project.Repositories;
using Project.Repositories.Interfaces;
using Project.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DatabaseContext>(option => option.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnectionString"]));

// Singleton Service
builder.Services.AddSingleton<SessionService>();

// Add depedency inject for Repositories
builder.Services.AddScoped<IRepository<Customer>, CustomerRepository>();
builder.Services.AddScoped<IRepository<Product>, ProductRepository>();
builder.Services.AddScoped<IRepository<Order>, OrderRepository>();
builder.Services.AddScoped<IRepository<Orders>, OrdersRepository>();
builder.Services.AddScoped<IRepository<Restaurant>, RestaurantRepository>();
builder.Services.AddScoped<IRepository<Reservation>, ReservationRepository>();


var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
