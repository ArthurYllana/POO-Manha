using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente //extends
{//            classe derivada : classe base
    public class ClienteFisico : Cliente
    {
        public int Cpf { get; set; }//private
        public int Rg { get; set; }
        //override indica o polimorfismo
        public override void MostrarAtributos()
        {
            base.MostrarAtributos();//chama o método da superclasse
            Console.WriteLine("Cpf: " + Cpf + "\tRg: " + Rg);
        } 
        public ClienteFisico(int codigo, string nome, int cpf, int rg) : base(codigo, nome)
        {
            Cpf = cpf;
            Rg = rg;   
        }   
        public ClienteFisico() : base()//construtor padrão
        {
            
        } 
    }
}