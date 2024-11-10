namespace Exer_SRP
{
    public class GeradorRelatorios
    {
        public string GerarRelatorio(Conta conta)
        {
            return $"Titular: {conta.Titular}\tSaldo: {conta.Saldo:C}";
        }
    }  
}