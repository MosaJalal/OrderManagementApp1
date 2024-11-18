namespace OrderManagementApp1.CQRS.Queries
{
    using OrderManagementApp1.Models;
    using OrderManagementApp1.Services;
    using System.Collections.Generic;

    // Handler för att hantera frågan "GetAllOrdersQuery"
    public class GetAllOrdersQueryHandler
    {
        private readonly OrderService _orderService; // OrderService används för att hämta ordrar

        // Konstruktor för att injicera OrderService
        public GetAllOrdersQueryHandler(OrderService orderService)
        {
            _orderService = orderService;
        }

        // Hanterar frågan genom att returnera alla ordrar som DTOs
        public IEnumerable<OrderDto> Handle(GetAllOrdersQuery query)
        {
            return _orderService.GetAllOrdersAsDto();
        }
    }
}
