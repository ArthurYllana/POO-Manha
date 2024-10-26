// Método Main()
using InterfaceAutenticavel;

Gerente g = new Gerente();
g.Senha = 123; 
//g.Mostrar(); 

Cliente c = new Cliente();
c.Senha = 321;

//IAutenticavel ai = new Iutenticavel();  (Gera erro de compilação)
IAutenticavel ia = g;
System.Console.WriteLine("Acessou o sistema? " + ia.Autentica(123));

ia = c;
System.Console.WriteLine("\n\nAcessou o sistema? " + ia.Autentica(321));