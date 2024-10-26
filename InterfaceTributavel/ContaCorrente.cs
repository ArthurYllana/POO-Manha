namespace InterfaceTributavel
{
    public class ContaCorrente : ITributavel
    {
        public double Saldo { get; private set; }

        public ContaCorrente(double saldo)
        {
            Saldo = saldo; 
        }

        public double CalculaTributos()
        {
            return Saldo * 0.05; 
        }
    }
}
