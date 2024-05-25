using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Restaurant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Locaton { get; set; }
        public string Description { get; set; }  
    }
}
