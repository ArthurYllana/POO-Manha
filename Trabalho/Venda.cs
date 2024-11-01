using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho
{
    public class Venda
    {        
        public DateTime Data { get; set; }
        public List<ItemVenda> ItensVenda { get; set; } = new List<ItemVenda>();
        public double Total => CalcularTotal();

        private double CalcularTotal()
        {
            double total = 0;
            int quantidadeTotal = 0;

            foreach (var item in ItensVenda)
            {
                total += item.Subtotal;
                quantidadeTotal += item.Quantidade;
            }

            // Aplica desconto de 20% para compras em atacado (50 produtos ou mais)
            if (quantidadeTotal >= 50)
            {
                total *= 0.8;
            }

            return total;
        }

        public void AdicionarItem(ItemVenda item)
        {
            ItensVenda.Add(item);
        }   
    }
}