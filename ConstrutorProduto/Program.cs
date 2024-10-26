// Método Main()
using ConstrutorProduto;

Produto p1 = new Produto();
p1.MostrarAtributos();

Produto p2 = new Produto(1);
p2.MostrarAtributos();

Produto p3 = new Produto(2,"Mouse",55);
p3.MostrarAtributos();

Console.WriteLine("Quantidade de instâncias: "+ 
Produto.Cont);
