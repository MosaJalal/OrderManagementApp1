namespace OrderManagementApp1.CQRS.Commands
{
    public class CreateOrderCommand
    {
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
