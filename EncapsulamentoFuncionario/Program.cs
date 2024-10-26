// Método main()
using EncapsulamentoFuncionario;

Funcionario f1 = new Funcionario();
Console.WriteLine("Digite o salário: ");
f1.Salario = Convert.ToDecimal(Console.ReadLine());//set

f1.CalcularAumento(5);
Console.WriteLine($"Salário após aumento {f1.Salario:c}");//get

