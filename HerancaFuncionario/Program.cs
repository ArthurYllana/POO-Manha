// Método Main()
using HerancaFuncionario;

Funcionario f = new Funcionario(1, "Funcionário", 1000);
f.MostrarAtributos();
Console.WriteLine($"Valor bonificação {f.CalcularBonificacao():c}");

Secretario s = new Secretario(2,"Secretario", 1000);
s.MostrarAtributos();
Console.WriteLine($"Valor bonificação {s.CalcularBonificacao():c}");

Gerente g = new Gerente(3, "Gerente", 1000);
g.MostrarAtributos();
Console.WriteLine($"Valor bonificação {g.CalcularBonificacao():c}");

Diretor d = new Diretor(4, "Diretor", 1000);
d.MostrarAtributos();
Console.WriteLine($"Valor bonificação {d.CalcularBonificacao():c}");
