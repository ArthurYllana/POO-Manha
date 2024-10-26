// Método Main()
using AbstratoCliente;
// ocorre erro na instância de um objeto
// de uma classe abstrata, pois não pode instanciar
//Cliente c = new Cliente(1, "Ana", 23);
//c.MostrarAtributos();

ClienteFisico cf = new ClienteFisico(2, "Bia", 2, 222);
cf.MostrarAtributos();

ClienteJuridico cj = new ClienteJuridico(3, "Empresa SA", 45, 1000);
cj.MostrarAtributos();

Teste teste = new Teste();
teste.AvaliarIdade(cf);


teste.AvaliarIdade(cj);