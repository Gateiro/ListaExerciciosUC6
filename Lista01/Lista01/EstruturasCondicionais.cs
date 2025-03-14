using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01
{
    public class EstruturasCondicionais
    {
        public void parOuImpar()
        {
            Console.WriteLine("---- PAR OU ÍMPAR? ----");
            Console.WriteLine("Insira um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"O número {num} é par!");
            }
            else
            {
                Console.WriteLine($"O número {num} é ímpar!");
            }
        }

        public void maiorDeTres()
        {
            Console.WriteLine("---- QUAL É O MAIOR? ----");
            Console.WriteLine("Insira o 1º número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o 2º número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o 3º número: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine($"O número {num1} é o maior!");
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine($"O número {num2} é o maior!");
            }
            else
            {
                Console.WriteLine($"O número {num3} é o maior!");
            }
        }
    }

    
}
