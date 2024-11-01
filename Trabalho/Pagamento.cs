using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho
{
    public class Pagamento
    {
        public DateTime Data { get; set; }
        public double Total { get; set; }

        protected Pagamento(double total)
        {
            Data = DateTime.Now;
            Total = total;
        }

    }
}