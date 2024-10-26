// Método Main()
using EncapsulamentoAluno;

Aluno a1 = new Aluno();
a1.Matricula = 1;
a1.P1 = 10;
a1.P2 = 9;
a1.CalcularMedia();
Console.WriteLine(a1.Media);
a1.MostrarAtributos();