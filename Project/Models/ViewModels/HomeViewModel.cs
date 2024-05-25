namespace Project.Models.ViewModels;

public class HomeViewModel
{
    public IEnumerable<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
}
