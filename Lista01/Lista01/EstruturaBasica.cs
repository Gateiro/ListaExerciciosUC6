using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01
{
    public class EstruturaBasica
    {
        public void OlaMundo()
        {
            Console.WriteLine("Olá Mundo!!!!");
        }

        public void SeuNome()
        {
            Console.WriteLine("Insira o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Bem-vindo {nome}!");
        }

        public void NumerosInteiros()
        {
            Console.WriteLine("Escreva dois numeros inteiros\n");
            Console.WriteLine("1º número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n2º número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nAgora escolha uma operação matemática: ");
            Console.WriteLine("1) Soma ");
            Console.WriteLine("2) Subtração ");
            Console.WriteLine("3) Multiplicação ");
            Console.WriteLine("4) Divisão ");
            int opc = int.Parse(Console.ReadLine());

            int resultado = 0;
            switch (opc)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine("\nVocê escolheu soma!");
                    Console.WriteLine($"A soma de {num1} + {num2} é igual a {resultado}");
                    break;

                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine("\nVocê escolheu subtração!");
                    Console.WriteLine($"A subtração de {num1} - {num2} é igual a {resultado}");
                    break;

                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine("\nVocê escolheu multiplicação!");
                    Console.WriteLine($"A multiplicação de {num1} * {num2} é igual a {resultado}");
                    break;

                case 4:
                    resultado = num1 / num2;
                    Console.WriteLine("\nVocê escolheu divisão!");
                    Console.WriteLine($"A divisão de {num1} / {num2} é igual a {resultado}");
                    break;
            }
        }
    }
}
