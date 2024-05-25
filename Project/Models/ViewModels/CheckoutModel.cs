namespace Project.Models.ViewModels;

public class CheckoutModel
{
    public Restaurant Restaurant { get; set; } = default!;
    public int RestaurantId { get; set; } = 0;
    public string FullName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public DateTime ReservationDate { get; set; } = DateTime.Now;
}
