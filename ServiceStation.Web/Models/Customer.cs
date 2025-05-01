using System.ComponentModel.DataAnnotations;

namespace ServiceStation.Web.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string Name { get; set; }

        public string Email { get; set; }

        public bool IsDeleted { get; set; } = false;

        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>(); 
    }
}
