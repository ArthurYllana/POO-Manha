// Metodo main()

using Exer_SRP;
Conta conta = new Conta("João");
conta.Deposito(100);

ValidadorUsuarios validador = new ValidadorUsuarios();
bool usuarioValido = validador.ValidarUsuario("João", conta);

GeradorRelatorios gerador = new GeradorRelatorios();
string relatorio = gerador.GerarRelatorio(conta);

Console.WriteLine(relatorio);

