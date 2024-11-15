namespace OrderManagementApp1.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }  // Unikt ID för varje order.
        public string CustomerName { get; set; } // Namnet på kunden som lade ordern.
        public decimal TotalAmount { get; set; } //  Totalsumman för ordern.

    }
}
