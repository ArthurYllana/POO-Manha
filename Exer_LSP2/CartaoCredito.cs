namespace Exer_LSP
{
    public class CartaoCredito : IPagamento
    {
        public void ProcessarPagamento(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor deve ser maior que zero!");
                return;
            }

            // Implementa lógica específica para cartão de crédito
            Console.WriteLine($"Processado pagamento de {valor:C} no Cartão de Crédito.");
        }
    }
}