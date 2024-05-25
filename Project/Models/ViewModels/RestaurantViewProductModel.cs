namespace Project.Models.ViewModels;

public class RestaurantViewProductModel
{
    public Restaurant Restaurant = default!;
    public IEnumerable<Product> ProductList { get; set; } = [];
    public List<Order> OrderList { get; set;} = [];
    public int CartSize { get; set; } = 0;
}
