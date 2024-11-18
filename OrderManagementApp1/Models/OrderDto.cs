namespace OrderManagementApp1.Models
{
    public class OrderDto
    {
        public Guid OrderId { get; set; } // Unikt ID för ordern
        public string CustomerName { get; set; } // Kundens namn
        public decimal TotalAmount { get; set; } // Beloppet för ordern
        public string Status { get; set; } // Status: "Betald" eller "Obetald"
    }
}
