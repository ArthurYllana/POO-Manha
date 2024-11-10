namespace Exer_LSP
{
    public class PayPal: IPagamento
    {
        public void ProcessarPagamento(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor deve ser maior que zero!");
                return;
            }

        // Implementa lógica específica para PayPal
        Console.WriteLine($"Processado pagamento de {valor:C} via PayPal.");
        }
    }   
}