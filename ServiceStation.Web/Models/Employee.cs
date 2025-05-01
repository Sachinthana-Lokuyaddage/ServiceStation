namespace ServiceStation.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; } // e.g., Mechanic, Technician, Manager
        public bool IsDeleted { get; set; } = false;


    }
}
