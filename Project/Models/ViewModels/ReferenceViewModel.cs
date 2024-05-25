namespace Project.Models.ViewModels;

public class ReferenceViewModel
{
    public string ReferenceId { get; set; } = Guid.NewGuid().ToString();
    public DateTime ReservationDate { get; set; } = DateTime.Now;
    public string RestaurantName { get; set; } = string.Empty;
}
