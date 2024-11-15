namespace OrderManagementApp1.Adapters
{
    // Interfacet definierar ett kontrakt för betalningsadaptrar
    public interface IPaymentAdapter
    {
        // Metodsignaturen som alla adaptrar måste implementera
        void MakePayment(string orderId, decimal amount);
    }
}
