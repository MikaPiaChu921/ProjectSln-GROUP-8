using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models;

public class Reservation
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ReservationId { get; set; }
    [ForeignKey(nameof(Customer))]
    public int CustomerId { get; set; }
    [ForeignKey(nameof(Restaurant))]
    public int RestaurantId { get; set; }
    [ForeignKey(nameof(Order))]
    public int OrderId { get; set; }
    public DateTime ReservationDate { get; set; } = DateTime.Now;
}
