// Método Main()

using EncapsulamentoProduto;

Produto p1 = new Produto();
Console.Write("Cadastre o código: ");
p1.Codigo = Convert.ToInt32(Console.ReadLine());
Console.Write("Cadastre o nome: ");
p1.Nome = Console.ReadLine();
Console.Write("Cadastre a quantidade: ");
p1.Qtde = Convert.ToInt32(Console.ReadLine());
Console.Write("Cadastre o Preço: ");
p1.Preco = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Preço cadastrado {p1.Preco:c}");//get

