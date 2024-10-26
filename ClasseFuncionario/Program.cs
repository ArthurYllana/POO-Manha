// Método Main()
using ClasseFuncionario;

//realizar instâncias
Funcionario f1 = new Funcionario();
f1.codigo = 1;
f1.nome = "Ana";
f1.salario = 1000;
f1.MostrarAtributos();
f1.CalcularAumento(5);
f1.MostrarAtributos();
