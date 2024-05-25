using Project.Models;

namespace Project.Services;

public class SessionService
{
    public Dictionary<string, List<Order>> SessionOrder = [];
    public Dictionary<string, int> RestaurantIdSession = [];
}
