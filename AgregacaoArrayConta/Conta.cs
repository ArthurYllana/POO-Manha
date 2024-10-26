using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoArrayConta
{
    public class Conta
    {
        public int Numero { get; set; }
        //agregação é estabelecida
        public List<Cliente> VetTitulares { get; set; }
        public double Saldo { get; set; }
        
    }
}