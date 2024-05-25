namespace Project.Models.ViewModels;

public class CartViewModel
{
    public int RestaurantId { get; set; } = 0;
    public List<Order> Orders { get; set; } = [];
    public List<Product> Products { get; set; } = [];
}
