// função Main()
// autoriza usar or arquivos da pasta Classes
using ClasseConta;

//tipo - nome do objeto
Conta objetoConta; //declarando a variável objetoConta
objetoConta = new Conta(); //instanciando objeto
objetoConta.numero = 1;
objetoConta.titular = "Jonh";
objetoConta.saldo = 100;
objetoConta.MostrarAtributos();
objetoConta.Depositar(50);
objetoConta.MostrarAtributos();
Console.WriteLine($"Valor descontado do IOF {objetoConta.CalcularIof(4.38):c}");
objetoConta.MostrarAtributos();

/*Conta c1 = new Conta();
Console.Write("Digite o número da conta: ");
c1.numero = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o titular da conta: ");
c1.titular = Console.ReadLine();
Console.Write("Digite o saldo da conta: ");
c1.saldo = Convert.ToDouble(Console.ReadLine());
c1.MostrarAtributos();*/

Conta c2 = new Conta();
c2.numero = 2;
c2.titular = "Jane";
c2.saldo = 300;
c2.MostrarAtributos();
c2.Sacar(10);
c2.MostrarAtributos();
Console.WriteLine("Valor descontador: " +c2.CalcularIof(4.37));
c2.MostrarAtributos();

//realizando a transferência
c2.Transferencia(50, objetoConta);
c2.MostrarAtributos();
objetoConta.MostrarAtributos();

