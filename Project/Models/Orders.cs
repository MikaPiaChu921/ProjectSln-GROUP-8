using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrdersId { get; set; }
        public IEnumerable<Order> OrdersList { get; set; } = new List<Order>();
        public int CustomerId { get; set; }
    }
}
