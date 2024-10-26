// Método Main()

using AgregacaoConta;

Cliente cli = new Cliente("Ana", 20, 1111);

Conta c1 = new Conta();
c1.Numero = 1;
c1.Saldo = 100;
c1.Titular = cli;//execução da agregação

Conta c2 = new Conta();
c2.Numero = 2;
c2.Saldo = 200;
c2.Titular = new Cliente();
c2.Titular.Nome = "Bia";
c2.Titular.Idade = 21;
c2.Titular.Telefone = 2222;