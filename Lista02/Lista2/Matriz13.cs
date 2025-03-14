using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    public class Matriz13
    {
        public void caso13()
        {
            int[,] matriz = new int[3, 3];
            int pares = 0, impares = 0;

            Console.WriteLine("Digite os elementos da matriz 3x3:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    if (matriz[i, j] % 2 == 0)
                        pares++;
                    else
                        impares++;
                }
            }

            Console.WriteLine($"A matriz possui {pares} números pares e {impares} números ímpares.");
        }
    }
}
