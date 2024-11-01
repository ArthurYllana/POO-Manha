using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho
{
    public class Especie : Pagamento
    {
        public double Quantia { get; set; }
        public double Troco => Quantia - Total; 

        public Especie (double total, double quantia) : base(total)
        {
            Quantia = quantia;
        }
    }
}