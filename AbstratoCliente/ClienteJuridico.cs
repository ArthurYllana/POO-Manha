using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public class ClienteJuridico: Cliente
    {
        public int Cnpj { get; set; }
        public ClienteJuridico(int codigo, string nome, int idade, int cnpj): base(codigo, nome, idade)
        {
            Cnpj = cnpj;
        }
        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            Console.WriteLine("Cnpj: " + Cnpj);
        }
        public override void VerificaIdade()
        {
            if (Idade >= 41)
                Console.WriteLine("Cliente jurídico");
        }
        
    }
}