using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayProduto
{
    public class Produto
    {
        //declaração dos atributos
        public int codigo;
        public string nome;
        public double preco;
        public int qtde;
        //declaração dos métodos
        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo + 
            "\tNome: " + nome + "\tPreço R$ " + 
            preco + "\tQuantidade: " + qtde);
        }
    }
}