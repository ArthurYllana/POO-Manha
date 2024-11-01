using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho
{
    public class Cartão : Pagamento
    {
        public string DadosTransacao { get; set; }
        public int ResultadoTransacao { get; set; } 

        public Cartão(double total, string dadosTransacao, int resultadoTransacao) : base(total)
        {
            DadosTransacao = dadosTransacao;
            ResultadoTransacao = resultadoTransacao;
        }
    }
}