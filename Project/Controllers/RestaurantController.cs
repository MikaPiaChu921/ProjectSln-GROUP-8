using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Models.ViewModels;
using Project.Repositories.Interfaces;
using Project.Services;

namespace Project.Controllers
{
    public class RestaurantController(
        IRepository<Product> productRepository, 
        IRepository<Restaurant> restaurantRepository, 
        IRepository<Reservation> reservationRepository,
        IRepository<Customer> customerRepository,
        IRepository<Order> orderRepository,
        SessionService sessionService
        ) : Controller
    {
        private readonly IRepository<Product> productRepository = productRepository;
        private readonly IRepository<Restaurant> restaurantRepository = restaurantRepository;
        private readonly IRepository<Reservation> reservationRepository = reservationRepository;
        private readonly IRepository<Customer> customerRepository = customerRepository;
        private readonly IRepository<Order> orderRepository = orderRepository;
        private readonly SessionService sessionService = sessionService;

        public IActionResult View(int id)
        {
            RestaurantViewProductModel model = new()
            {
                ProductList = productRepository.GetAll().Where(p => p.RestaurantId == id),
                Restaurant = restaurantRepository.Get(id),
                OrderList = GetCart("MySession"),
                CartSize = GetCartSize("MySession")
            };
            sessionService.RestaurantIdSession.TryAdd("MySession", id);
            Task.Delay(100);
            return View("Index",model);
        }

        public IActionResult Cart(int id)
        {
            CartViewModel model = new()
            {
                RestaurantId = id,
                Products = productRepository.GetAll().Where(p => p.RestaurantId == id).ToList(),
                Orders = GetCart("MySession")
            };
            Task.Delay(100);
            return View("Cart", model);
        }

        public IActionResult Checkout(int id)
        {
            CheckoutModel model = new()
            {
                Restaurant = restaurantRepository.Get(id),
                RestaurantId = id
            };
            Task.Delay(100);
            return View("Checkout", model);
        }

        [HttpPost]
        public IActionResult PostCheckout(CheckoutModel model)
        {
            var cart = GetCart(HttpContext.Connection.Id);
            Restaurant? restaurant = null;
            while(restaurant == null)
            {
                restaurant = restaurantRepository.Get(model.RestaurantId);
            }

            // retrieve/build the user
            var user = customerRepository.GetAll().FirstOrDefault(c => c.FullName == model.FullName && c.Address == model.Address) ?? new() { CustomerId = default,FullName = model.FullName, Address = model.Address};
            if(user.CustomerId == default)
            {
                customerRepository.Add(user);
            }

            foreach(var order in cart)
            {
                Reservation reservation = new()
                {
                    OrderId = orderRepository.Add(order).OrderId,
                    CustomerId = user.CustomerId,
                    RestaurantId = model.RestaurantId,
                    ReservationDate = model.ReservationDate
                };
                reservationRepository.Add(reservation);
            }

            ReferenceViewModel Rmodel = new()
            {
                ReservationDate = model.ReservationDate,
                RestaurantName = restaurant.Name,
            };
            Task.Delay(100);
            return View("Reference", Rmodel);
        }

        public IActionResult Order(int restaurantId, int productId, int quantity)
        {
            var order = new Order()
            {
                ProductId = productId,
                Quantity = quantity
            };
            AddToCart("MySession", order);
            sessionService.RestaurantIdSession.TryAdd("MySession", restaurantId);
            Task.Delay(500);
            return Redirect($"view/{restaurantId}");
        }

        private List<Order> GetCart(string id)
        {
            sessionService.SessionOrder.TryGetValue(id, out var order);
            return order ?? [];
        }

        private int GetCartSize(string id)
        {
            int TOTAL = 0;
            var d = GetCart(id);
            foreach (var item in d)
            {
                TOTAL += item.Quantity;
            }
            return TOTAL;
        }
        private void AddToCart(string id, Order order)
        {
            sessionService.SessionOrder.TryGetValue(id, out List<Order>? orderList);
            orderList ??= [];
            var orderFound = orderList.FirstOrDefault(r => r.ProductId == order.ProductId);
            if(orderFound == null)
            {
                orderList.Add(order);
            }
            else
            {
                orderFound.Quantity++;
            }
            sessionService.SessionOrder[id] = orderList;
        }

        private void RemoveFromCart(string id, int orderId)
        {
            sessionService.SessionOrder.TryGetValue(id, out var orderList);
            orderList ??= [];
            var data = orderList.FirstOrDefault(O => O.OrderId == orderId);
            if (data != null) orderList.Remove(data);
            sessionService.SessionOrder[id] = orderList;
        }
    }
}
