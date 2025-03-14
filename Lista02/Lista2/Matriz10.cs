using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    public class Matriz10
    {
        public void caso10()
        {
            int[,] matriz = new int[5, 5];

            Console.WriteLine("Digite os elementos da matriz 5x5:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    
                    if (matriz[i, j] < 0)
                    {
                        matriz[i, j] = 0;
                    }
                }
            }

            Console.WriteLine("\nMatriz após a substituição:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
