namespace OrderManagementApp1.Adapters
{
    // Klassen PaymentAdapter implementerar IPaymentAdapter-interface
    public class PaymentAdapter : IPaymentAdapter
    {
        // Skapar en instans av ExternalPaymentService för att hantera betalningar
        private readonly ExternalPaymentService _paymentService = new();

        // Implementerar MakePayment-metoden från IPaymentAdapter
        public void MakePayment(string orderId, decimal amount)
        {
            // Använder ExternalPaymentService för att bearbeta betalningen
            _paymentService.ProcessPayment(orderId, amount);
        }
    }
}
