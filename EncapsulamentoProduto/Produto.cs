using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoProduto
{
    public class Produto
    {
        private int codigo;
        private string nome;
        private int qtde;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Qtde
        {
            get { return qtde; }
            set { qtde = value; }
        }
        private decimal preco;
        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        
        
        
        
    }
}