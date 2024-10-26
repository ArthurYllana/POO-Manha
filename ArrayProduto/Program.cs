// Método Main()
using ArrayProduto;

Produto[] vetP = new Produto[3];
double total = 0;
for(int i = 0; i < vetP.Length; i++)
{
    vetP[i] = new Produto();
    Console.Write("Cadastre o código: ");
    vetP[i].codigo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Cadastre o nome: ");
    vetP[i].nome = Console.ReadLine();
    Console.Write("Cadastre o preço: ");
    vetP[i].preco = Convert.ToDouble(Console.ReadLine());
    Console.Write("Cadastre o quantidade: ");
    vetP[i].qtde = Convert.ToInt32(Console.ReadLine());
    total = total + vetP[i].preco * vetP[i].qtde;
}
Console.WriteLine($"Valor total {total:c}");
foreach (Produto p in vetP)
    p.MostrarAtributos();