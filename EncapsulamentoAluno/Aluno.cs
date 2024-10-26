using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoAluno
{
    public class Aluno
    {
        private int matricula;
        private double p1;
        private double p2;
        private double media;
        public int Matricula
        {
            get { return matricula; }
            set { 
                if (value > 0)
                    matricula = value; 
                }
        }
        public double P1
        {
            get { return p1; }
            set { 
                if (value > 0)
                    p1 = value; 
                }
        }
        public double P2
        {
            get { return p2; }
            set { 
                if (value > 0)
                    p2 = value; 
                }
        }
        public double Media
        {
            get { return media; }
            //set { media = value;}
        }
        public void CalcularMedia()
        {
            media = (P1 + P2) / 2;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Matrícula: " + matricula + 
            "\tP1: " + P1 + "\tP2: " + P2 + "\tMédia: " + Media);
        }
    }
}