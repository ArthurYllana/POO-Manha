// Método main()

using InterfaceTributavel;

// Criando uma instância de ContaCorrente com saldo de 1000
ContaCorrente cc = new ContaCorrente(1000.0);

// Criando uma instância de SeguroDeVida
SeguroDeVida sv = new SeguroDeVida();

// Exibindo o valor dos tributos calculados para cada objeto
Console.WriteLine($"Tributos da Conta Corrente: {cc.CalculaTributos()}");
Console.WriteLine($"Tributos do Seguro de Vida: {sv.CalculaTributos()}");

// Totalizando os tributos usando o TotalizadorDeTributos
TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
totalizador.Adiciona(cc);
totalizador.Adiciona(sv);

// Exibindo o total acumulado de tributos
Console.WriteLine($"Total de tributos acumulado: {totalizador.Total}");
