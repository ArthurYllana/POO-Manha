// Método Main()

using ArrayConta;

//declara uma variável como vetor da classe Conta
Conta[] vetContas = new Conta[3];
//manipular/digitar valores dos atributos dentro 
//de cada índice do vetor
for (int i = 0; i < vetContas.Length; i++)
{
    //instancie cada índice do vetor
    vetContas[i] = new Conta();
    //manipule/cadastre/digite em cada índice do vetor
    //os atributos
    Console.Write("Cadastre o número: ");
    vetContas[i].numero = Convert.ToInt32(Console.ReadLine());
    Console.Write("Cadastre o titular: ");
    vetContas[i].titular = Console.ReadLine();
    Console.Write("Cadastre o saldo: ");
    vetContas[i].saldo = Convert.ToDouble(Console.ReadLine());
} 
foreach (Conta c in vetContas)
    c.MostrarAtributos();

