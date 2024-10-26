using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    public class Conta
    {
        //declaração de atributos
        private int numero; // o atributo esta encapsulado
        private string titular;
        private double saldo;

        //declaração dos métodos
        /* exemplo de método de encapsulamento
        modelo Java ou PHP
        public void setNumero(int numero)
        {
            this.numero = numero;
        }
        public int getNumero()
        {
            return this.numero;
        }*/
        //Convenção C# 
        public int Numero //propriedade
        {//dentro da propriedade tem get e set
            set
            {     //atributo
                if (value > 0) 
                    this.numero = value;
            }
            get
            {
                return numero;
            }
        }
        public string Titular
        {
            get { return titular.ToUpper(); }
            set { 
                if (value != "")
                    titular = value; 
                else
                    Console.WriteLine("Nome inválido!");
            }
        }
        public double Saldo
        {
            get { return saldo; }
            //set { saldo = value; }
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + numero + 
            "\tTitular: " + titular + "\tSaldo R$ " + saldo);
        }
        public void Sacar(double valorSaque)
        {
            saldo = saldo - valorSaque;
        }
        public void Depositar(double valorDeposito)
        {
            saldo = saldo + valorDeposito;
        }
        //desenvolva um método para calcular IOF % desconte
        //retorne o valor que será descontado e apresente
        //na main()
        public double CalcularIof(double porcentagem)
        {
            double valorDescontado = saldo * porcentagem/100;
            saldo = saldo - valorDescontado; 
            return valorDescontado;
        }
        public void Transferencia(double valorTransferencia,
                                  Conta outraConta)
        {
            saldo = saldo - valorTransferencia;
            outraConta.saldo = outraConta.saldo + valorTransferencia;
        }

    }
}