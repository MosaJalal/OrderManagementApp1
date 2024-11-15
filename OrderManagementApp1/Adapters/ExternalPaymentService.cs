namespace OrderManagementApp1.Adapters
{
    // Klassen ExternalPaymentService simulerar en extern betaltjänst
    public class ExternalPaymentService
    {
        // Metoden ProcessPayment bearbetar betalningar
        public void ProcessPayment(string orderId, decimal amount)
        {
            // Skriver ut betalningsinformationen till konsolen (simulerar betalning)
            Console.WriteLine($"Betalar order {orderId} för {amount} SEK via extern tjänst.");
        }
    }
}
