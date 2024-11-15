namespace OrderManagementApp1.Services
{
    // Importerar nödvändiga namnrymder
    using OrderManagementApp1.Models; // För att använda Order-modellen
    using System.Collections.Generic; // För List och IEnumerable

    // En tjänst som hanterar logik för att lagra och läsa ordrar
    public class OrderService
    {
        // En privat lista som fungerar som en in-memory-databas för ordrar
        private readonly List<Order> _orders = new();

        // En metod som returnerar alla ordrar
        public IEnumerable<Order> GetAllOrders() => _orders;
        // IEnumerable används för att returnera en "läsbar" version av listan
        // utan att ge direkt åtkomst till den privata _orders-listan.

        // En metod för att lägga till en ny order i listan
        public void AddOrder(Order order)
        {
            order.OrderId = Guid.NewGuid(); // Skapar ett unikt ID för varje order
            _orders.Add(order); // Lägger till den nya ordern i listan
        }
    }
}
