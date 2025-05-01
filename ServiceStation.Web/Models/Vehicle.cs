namespace ServiceStation.Web.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string LicensePlate { get; set; }
        public string VIN { get; set; } // Vehicle Identification Number
        public decimal Mileage { get; set; } // in kilometers or miles
        public string OwnerName { get; set; }
        public string CustomerId { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
