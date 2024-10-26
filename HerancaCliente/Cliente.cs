using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class Cliente //classe base, superclasse, classe pai/mae
    {
        protected int codigo;//protected é o encapsulamento da herança
        protected string nome;
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
        public virtual void MostrarAtributos()
        {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome);
        }  
        public Cliente(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        } 
        public Cliente()
        {
            
        }  
    }
}