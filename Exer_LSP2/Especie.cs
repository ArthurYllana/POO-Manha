namespace Exer_LSP
{
    public class Especie: IPagamento{
        public void ProcessarPagamento(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor deve ser maior que zero!");
                return;
            }

            // Implementa lógica específica para pagamento em espécie
            Console.WriteLine($"Processado pagamento em espécie de {valor:C}.");
        }
    }  
}