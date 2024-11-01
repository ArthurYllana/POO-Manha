// Metodo Main()
using Trabalho;
// Exemplo de uso
Produto produto1 = new Produto(1, "Produto A", 10.0, 100);
Produto produto2 = new Produto(2, "Produto B", 15.0, 100);

Venda venda = new Venda();
venda.AdicionarItem(new ItemVenda(produto1, 30));
venda.AdicionarItem(new ItemVenda(produto2, 20));

Console.WriteLine("Total da venda: " + venda.Total);

// Pagamento em espécie
Especie pagamentoEspecie = new Especie(venda.Total, 500);
Console.WriteLine("Troco: " + pagamentoEspecie.Troco);