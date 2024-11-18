using OrderManagementApp1.CQRS.Commands;
using OrderManagementApp1.Models;
using OrderManagementApp1.Services;

namespace OrderManagementApp1.Pages
{
    // Partial-klass för Blazor-komponenten "Home"
    public partial class Home
    {
        private IEnumerable<OrderDto> orders = new List<OrderDto>(); // Lista för att hålla ordrar i UI
        private string newCustomerName; // Kundnamn för ny order
        private decimal newTotalAmount; // Belopp för ny order

        // Körs vid initialisering av komponenten
        protected override void OnInitialized()
        {
            orders = OrderService.GetAllOrdersAsDto(); // Hämta alla ordrar från OrderService
        }

        // Lägg till en ny order
        private void AddOrder()
        {
            // Skapa en ny order med data från UI
            OrderService.AddOrder(new Order
            {
                CustomerName = newCustomerName,
                TotalAmount = newTotalAmount
            });

            RefreshOrders(); // Uppdatera orderlistan i UI
        }

        // Markera en order som betald
        private void PayOrder(OrderDto order)
        {
            var command = new PayOrderCommand { OrderId = order.OrderId }; // Skapa PayOrderCommand
            OrderService.MarkAsPaid(order.OrderId); // Markera ordern som betald via OrderService
            RefreshOrders(); // Uppdatera orderlistan i UI
        }

        // Uppdatera orderlistan i UI
        private void RefreshOrders()
        {
            orders = OrderService.GetAllOrdersAsDto(); // Hämta alla ordrar som DTOs
        }
    }
}
