namespace OrderManagementApp1.Services
{
    using OrderManagementApp1.Models;
    using System.Collections.Generic;
    using System.Linq;

    // Tjänst för att hantera ordrar
    public class OrderService
    {
        private readonly List<Order> _orders = new(); // Intern lista som fungerar som in-memory-databas

        // Lägg till en ny order
        public void AddOrder(Order order)
        {
            // Validera att kundnamn inte är tomt
            if (string.IsNullOrWhiteSpace(order.CustomerName))
                throw new ArgumentException("Kundnamn får inte vara tomt");

            // Validera att beloppet är större än 0
            if (order.TotalAmount <= 0)
                throw new ArgumentException("Belopp måste vara större än 0");

            order.OrderId = Guid.NewGuid(); // Skapa unikt ID för ordern
            _orders.Add(order); // Lägg till ordern i listan
        }

        // Markera en order som betald
        public void MarkAsPaid(Guid orderId)
        {
            var order = _orders.FirstOrDefault(o => o.OrderId == orderId); // Hitta ordern via ID

            if (order == null)
                throw new ArgumentException("Order med angivet ID hittades inte");

            order.IsPaid = true; // Markera ordern som betald
        }

        // Returnera alla ordrar som DTOs
        public IEnumerable<OrderDto> GetAllOrdersAsDto()
        {
            return _orders.Select(order => new OrderDto
            {
                OrderId = order.OrderId,
                CustomerName = order.CustomerName,
                TotalAmount = order.TotalAmount,
                Status = order.IsPaid ? "Betald" : "Obetald"
            });
        }
    }
}
