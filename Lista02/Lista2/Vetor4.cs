using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    public class Vetor4
    {
        public void caso4()
        {
            int[] numeros = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Maior ou menor?\n");
            Console.WriteLine("1- Maior\n");
            Console.WriteLine("2- Menor\n");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {

                case 1:
                    int maior = numeros.Max();
                    Console.WriteLine($"O maior número é {maior}.");
                    break;

                case 2:
                    int menor = numeros.Min();
                    Console.WriteLine($"O menor número é {menor}.");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

}

