namespace InterfaceTributavel
{
    public class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Adiciona(ITributavel tributavel)
        {
            Total += tributavel.CalculaTributos();
        }
    }
}