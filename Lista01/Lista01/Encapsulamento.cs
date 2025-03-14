using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01
{
   
    public class ContaBancaria
    {
        private int numeroDaConta;
        private double saldo;

        public ContaBancaria(int numero)
        {
            numeroDaConta = numero;
            saldo = 0;
        }

        public int NumeroDaConta
        {
            get { return numeroDaConta; }
        }

        public double Saldo
        {
            get { return saldo; }
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor de saque inválido.");
            }
        }
    }

    public class NovaConta
    {
        public void testeConta()
        {
            Console.WriteLine("Insira o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            ContaBancaria conta = new ContaBancaria(numero);

            Console.WriteLine("Insira o valor a ser depositado: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.Depositar(deposito);

            Console.WriteLine("Saldo atual: " + conta.Saldo);


            Console.WriteLine("Insira valor do saque: ");
            double saque = double.Parse(Console.ReadLine());
            conta.Sacar(saque);
            Console.WriteLine("Saldo atual: " + conta.Saldo);
        }
        
        
    }


}
