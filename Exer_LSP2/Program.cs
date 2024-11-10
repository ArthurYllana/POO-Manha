// Metodo Main()

using Exer_LSP;

IPagamento pagamentoCartao = new CartaoCredito();
pagamentoCartao.ProcessarPagamento(100);

IPagamento pagamentoPayPal = new PayPal();
pagamentoPayPal.ProcessarPagamento(200);

IPagamento pagamentoEspecie = new Especie();
pagamentoEspecie.ProcessarPagamento(50);
