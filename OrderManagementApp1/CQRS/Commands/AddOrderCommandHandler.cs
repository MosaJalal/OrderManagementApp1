namespace OrderManagementApp1.CQRS.Commands
{
    using OrderManagementApp1.Models;
    using OrderManagementApp1.Services;

    // Handler för att hantera kommandot "AddOrder"
    public class AddOrderCommandHandler
    {
        private readonly OrderService _orderService; // OrderService används för att hantera orderlogik

        // Konstruktor för att injicera OrderService
        public AddOrderCommandHandler(OrderService orderService)
        {
            _orderService = orderService;
        }

        // Hanterar "CreateOrderCommand" genom att skapa och lägga till en ny order
        public void Handle(CreateOrderCommand command)
        {
            // Validera att kundnamn inte är tomt
            if (string.IsNullOrWhiteSpace(command.CustomerName))
                throw new ArgumentException("Kundnamn får inte vara tomt");

            // Validera att beloppet är större än 0
            if (command.TotalAmount <= 0)
                throw new ArgumentException("Belopp måste vara större än 0");

            // Skapa en ny order med de värden som skickades med kommandot
            var newOrder = new Order
            {
                OrderId = Guid.NewGuid(),
                CustomerName = command.CustomerName,
                TotalAmount = command.TotalAmount,
                IsPaid = false // Ordern är inte betald som standard
            };

            // Lägg till ordern via OrderService
            _orderService.AddOrder(newOrder);
        }
    }
}
