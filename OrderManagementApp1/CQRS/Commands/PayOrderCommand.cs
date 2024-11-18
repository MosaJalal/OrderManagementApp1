
namespace OrderManagementApp1.CQRS.Commands
{
    public class PayOrderCommand
    {
        public Guid OrderId { get; internal set; }
    }
}
