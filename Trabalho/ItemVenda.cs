using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho
{
    public class ItemVenda
    {
        private int quantidade;
        private double preco;
        public double Subtotal => Quantidade * Preco;
        
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        public Produto Produto { get; set; }
        public ItemVenda(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
            Preco = produto.Preco;
        }
    }
}