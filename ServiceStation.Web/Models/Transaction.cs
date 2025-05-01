namespace ServiceStation.Web.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }
        public int ServiceId { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Now;
        public decimal Amount { get; set; }
        public TransactionStatus status { get; set; } = TransactionStatus.New; // e.g., Pending, Completed, Cancelled
        public bool IsDeleted { get; set; } = false;
    
    }
}
