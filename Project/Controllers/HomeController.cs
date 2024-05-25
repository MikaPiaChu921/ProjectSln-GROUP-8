using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Models.ViewModels;
using Project.Repositories.Interfaces;
using Project.Services;

namespace Project.Controllers
{
    public class HomeController(IRepository<Restaurant> restaurantRepository, SessionService sessionService) : Controller
    {
        private readonly IRepository<Restaurant> restaurantRepository = restaurantRepository;
        private readonly SessionService sessionService = sessionService;
        public IActionResult Index()
        {
            // clear the cart when on homepage
            sessionService.SessionOrder.Clear();

            HomeViewModel model = new()
            {
                Restaurants = restaurantRepository.GetAll()
            };
            return View(model);
        }
    }
}
