using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models;

public class Order
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OrderId { get; set; }
    [ForeignKey(nameof(Product))]
    public int ProductId { get; set; } = 0;
    public int Quantity { get; set; } = 0;
}
