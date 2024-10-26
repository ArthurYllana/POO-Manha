using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta
{
    public class Conta
    {
        //declaração de atributos
        public int numero;
        public string titular;
        public double saldo;

        //declaração dos métodos
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