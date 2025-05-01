namespace ServiceStation.Web.Models
{
    public class VehicleService
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public string Description { get; set; } = string.Empty;
        public decimal Cost { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
