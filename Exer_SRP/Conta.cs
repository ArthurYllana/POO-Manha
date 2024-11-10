namespace Exer_SRP
{
   public class Conta
    {
        public string Titular { get; private set; }
        public decimal Saldo { get; private set; }

        public Conta(string titular)
        {
            Titular = titular;
            Saldo = 0;
        }

        // Responsabilidade de gerenciar o saldo: Depósito
        public void Deposito(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor deve ser positivo!");
                return;
            }
            Saldo += valor;
        }

        // Responsabilidade de gerenciar o saldo: Saque
        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
                return;
            }
            Saldo -= valor;
        }
    }
}