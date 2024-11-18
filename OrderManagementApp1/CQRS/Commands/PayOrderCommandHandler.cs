namespace OrderManagementApp1.CQRS.Commands
{
    using OrderManagementApp1.Services;

    // Handler för att hantera kommandot "PayOrder"
    public class PayOrderCommandHandler
    {
        private readonly OrderService _orderService; // OrderService används för att hantera orderlogik

        // Konstruktor för att injicera OrderService
        public PayOrderCommandHandler(OrderService orderService)
        {
            _orderService = orderService;
        }

        // Hanterar "PayOrderCommand" genom att markera en order som betald
        public void Handle(PayOrderCommand command)
        {
            // Markera ordern som betald via OrderService
            _orderService.MarkAsPaid(command.OrderId);
        }
    }
}
